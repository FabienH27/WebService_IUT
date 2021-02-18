using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCliente_WebServiceIUT
{
    public partial class Form1 : Form
    {
        ServiceCRUD.CRUDClient v_crud = new ServiceCRUD.CRUDClient();
        ServiceSearch.SearchClient v_search = new ServiceSearch.SearchClient();
        //readonly WebServiceIUT.Service1Client v_serv = new WebServiceIUT.Service1Client();
        bool isEditing;

        /// <summary>
        /// Initialize the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            UpdateDepartmentsLists();
            UpdatePromoLists();
            promoDeptSelector.SelectedIndex = -1;
            studentBirthInput.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Récupération du nom du département lors du click sur le bouton d'ajout.
        /// </summary>
        private void AddDeptButton_Click(object sender, EventArgs e)
        {
            bool deptExist;
            string m_deptName = deptInput.Text.ToString();
            if(m_deptName != "")
            {
                deptExist = v_crud.AddDepartment(m_deptName);
                if(deptExist == true)
                {
                    UpdateDepartmentsLists();
                    deptExistLabel.Text = "";
                }
                else
                {
                    deptExistLabel.Text = "Le département existe déjà";
                }

            }
        }

        /// <summary>
        /// Event when the add promotion button is clicked
        /// </summary>
        private void AddPromoButton_Click(object sender, EventArgs e)
        {
            string m_promoName = promoInput.Text.ToString();
            string m_promoDept = promoDeptSelector.GetItemText(promoDeptSelector.SelectedItem);
            if (m_promoName != "" && m_promoDept != "")
            {
                v_crud.AddPromo(m_promoName, m_promoDept);
                UpdatePromoLists();
            }   
        }

        /// <summary>
        /// Collecting data from the interface and sending them to the webservice.
        /// </summary>
        private void SaveStudent_Click(object sender, EventArgs e)
        {
            string m_studentFirstName = studentFirstNameInput.Text.ToString();
            string m_studentLastName = studentLastNameInput.Text.ToString();
            DateTime m_studentBirthDate = studentBirthInput.Value;
            string m_oldStudentInfos;
            string m_studentPromo = studentPromoList.GetItemText(studentPromoList.SelectedItem);

            if (m_studentFirstName != " " || m_studentLastName != " " || m_studentBirthDate.ToString() != " ")
            {
                if (isEditing == false)
                {
                    v_crud.AddStudent(m_studentFirstName, m_studentLastName, m_studentBirthDate, m_studentPromo);
                }
                else
                {
                    m_oldStudentInfos = listResults.GetItemText(listResults.SelectedItem);
                    v_search.EditStudent(m_oldStudentInfos,m_studentFirstName,m_studentLastName,
                        m_studentBirthDate.Date.ToShortDateString(),m_studentPromo);
                    listResults.DataSource = null;
                    searchInput.Text = "";
                }
            } 
        }

        /// <summary>
        /// Event when the search button is clicked
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string m_studentToSearch = searchInput.Text.ToString();
            if(m_studentToSearch != "")
            {
                SearchStudents(m_studentToSearch);
            }
        }

        /// <summary>
        /// Function called when the search button is clicked
        /// </summary>
        /// <param name="studentToSearch">string from the search field</param>
        void SearchStudents(string studentToSearch)
        {
            List<string> m_studentResultList = v_search.SearchStudents(studentToSearch).
                Select(x => x.StudentFirstName + "-" + x.StudentLastName + "-" + 
                x.StudentPromoName + "-" + x.StudentDateBirth).ToList();
            listResults.DataSource = m_studentResultList;
        }


        /// <summary>
        /// Updating the displayed list of departments based on the UpdateDeptLists() function from the webservice
        /// </summary>
        void UpdateDepartmentsLists()
        {
            string[] m_deptsName = v_crud.UpdateDeptLists();
            promoDeptSelector.DataSource = m_deptsName;
        }

        /// <summary>
        /// Updating the displayed list of promotions based on the UpdatePromoLists() function from the webservice
        /// </summary>
        void UpdatePromoLists()
        {
            string[] m_promosName = v_crud.UpdatePromoLists();
            studentPromoList.DataSource = m_promosName;
        }

        /// <summary>
        /// Event when the edit button is clicked
        /// </summary>
        private void EditStudent_Click(object sender, EventArgs e)
        {
            isEditing = true;
            if(listResults.SelectedIndex >= 0)
            {
                string m_selectedStudent = listResults.GetItemText(listResults.SelectedItem);

                string[] studentsInfos = m_selectedStudent.Split('-');
                string studentFirstName = studentsInfos[0];
                string studentLastName = studentsInfos[1];
                string studentPromoName = studentsInfos[2];
                string studentBirthDate = studentsInfos[3];
                int studentPromoIndex = studentPromoList.FindString(studentPromoName);

                studentLastNameInput.Text = studentLastName;
                studentFirstNameInput.Text = studentFirstName;
                studentBirthInput.Value = DateTime.Parse(studentBirthDate);
                studentPromoList.SelectedIndex = studentPromoIndex;    
            }
        }

        int savedIndex = -1;
        /// <summary>
        /// Preselection of the associated department for a user-friendly purpose.
        /// </summary>
        private void PromoInput_TextChanged(object sender, EventArgs e)
        {
            string m_promoName = promoInput.Text;
            List<string> m_deptList = promoDeptSelector.Items.Cast<string>().ToList();
            string m_list = m_deptList.Where(x => x.StartsWith(m_promoName,StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            int deptIndex = -1;
            try
            {
                deptIndex = promoDeptSelector.Items.IndexOf(m_list);
                if(deptIndex != -1)
                {
                    savedIndex = deptIndex;
                }
            }
            catch(ArgumentNullException)
            {
            }
            promoDeptSelector.SelectedIndex = savedIndex;
        }
    }
}