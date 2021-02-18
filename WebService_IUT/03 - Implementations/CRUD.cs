using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService_IUT.DataContracts;
using WebService_IUT.Services;
using WebService_IUT.Files;

namespace WebService_IUT.Implementations
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class CRUD : ICRUD
    {
        //Lists of required classes : promotions, students  and students
        List<Promotion> promosList = new List<Promotion>();
        List<Student> studentsList = new List<Student>();
        List<Department> deptsList = new List<Department>();

        /// <summary>
        /// Updating JSON file for the departments
        /// </summary>
        /// <param name="departmentName">Departments to add</param>
        public bool AddDepartment(string departmentName)
        {
            deptsList = JsonConvert.DeserializeObject<List<Department>>(OpenFiles.OpenDeptFile());
            Department department = new Department() { DeptName = departmentName };

            foreach (Department dept in deptsList)
            {
                if (dept.DeptName == departmentName)
                    return false;
            }
            deptsList.Add(department);
            var json = JsonConvert.SerializeObject(deptsList, Formatting.Indented);
            File.WriteAllText(OpenFiles.deptLocation, json);
            UpdateDeptLists();
            return true;
        }

        /// <summary>
        /// Adding promotion to the JSON file.
        /// </summary>
        /// <param name="promoName">Name of the promotion</param>
        /// <param name="promoDept">Department of the promotion</param>
        public void AddPromo(string promoName, string promoDept)
        {
            string content = OpenFiles.OpenPromoFile();
            promosList = JsonConvert.DeserializeObject<List<Promotion>>(content);
            Promotion promo = new Promotion()
            {
                PromoName = promoName,
                PromoDept = promoDept,
                StudentsPromotion = new List<Student>(),
            };
            promosList.Add(promo);
            var json = JsonConvert.SerializeObject(promosList, Formatting.Indented);
            File.WriteAllText(OpenFiles.promosLocation, json);
            UpdatePromoLists();
        }

        /// <summary>
        /// Updating JSON file by adding student on it
        /// </summary>
        /// <param name="studentFirstName">student' first name</param>
        /// <param name="studentLastName">student' last name</param>
        /// <param name="studentBirthDate">student' birth date</param>
        /// <param name="promoName">promotion where the student will be inserted</param>
        public void AddStudent(string studentFirstName, string studentLastName, DateTime studentBirthDate, string promoName)
        {
            string contentStudent = OpenFiles.OpenStudentFile();
            studentsList = JsonConvert.DeserializeObject<List<Student>>(contentStudent);

            Student student = new Student()
            {
                StudentFirstName = studentFirstName,
                StudentLastName = studentLastName,
                StudentDateBirth = studentBirthDate.Date.ToShortDateString(),
                StudentPromoName = promoName,
            };

            AddStudentToPromo(student, promoName);
            studentsList.Add(student);
            var json = JsonConvert.SerializeObject(studentsList, Formatting.Indented);
            File.WriteAllText(OpenFiles.studentLocation, json);
        }

        /// <summary>
        /// Link a student to his promotion
        /// </summary>
        /// <param name="student">The student to modify</param>
        /// <param name="promoName">The promotion in which the student will be added</param>
        public void AddStudentToPromo(Student student, string promoName)
        {
            //Lecture du fichier contenant les promotions
            string contentPromo = OpenFiles.OpenPromoFile();
            promosList = JsonConvert.DeserializeObject<List<Promotion>>(contentPromo);
            Promotion promoToFind = new Promotion();
            promoToFind = promosList.Find(x => x.PromoName.Contains(promoName));
            promoToFind.StudentsPromotion.Add(student);
            var json = JsonConvert.SerializeObject(promosList, Formatting.Indented);
            File.WriteAllText(OpenFiles.promosLocation, json);
        }

        /// <summary>
        /// Update the JSON file containing the departments' informations
        /// </summary>
        /// <returns>a list of departments' names</returns>
        public List<string> UpdateDeptLists()
        {
            string contentDepartments = OpenFiles.OpenDeptFile();
            deptsList = JsonConvert.DeserializeObject<List<Department>>(contentDepartments);
            List<string> departmentsNames = deptsList.Select(Dept => Dept.DeptName).ToList();
            return departmentsNames;
        }

        /// <summary>
        /// Update the JSON file containing the promotions' informations
        /// </summary>
        /// <returns>a list of string with the promotions</returns>
        public List<string> UpdatePromoLists()
        {
            string contentPromotions = OpenFiles.OpenPromoFile();
            promosList = JsonConvert.DeserializeObject<List<Promotion>>(contentPromotions);
            List<string> promosName = promosList.Select(Promo => Promo.PromoName).ToList();
            return promosName;
        }
    }
}
