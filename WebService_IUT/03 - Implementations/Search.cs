using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService_IUT.Services;
using WebService_IUT.DataContracts;
using Newtonsoft.Json;
using WebService_IUT.Files;
using System.IO;

namespace WebService_IUT.Implementations
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Search : ISearch
    {
        List<Student> results = new List<Student>();
        List<Student> studentsList = JsonConvert.DeserializeObject<List<Student>>(OpenFiles.OpenStudentFile());
        List<Promotion> promoList = JsonConvert.DeserializeObject<List<Promotion>>(OpenFiles.OpenPromoFile());

        /// <summary>
        /// Search student with his name, age, department or his promotion
        /// </summary>
        /// <param name="search">The information to search</param>
        /// <returns>return a list of Student object</returns>
        public List<Student> SearchStudents(string search)
        {
            DateTime today = DateTime.Today;

            int number = 0;
            try { number = Byte.Parse(search); }
            catch (FormatException) { }
            if (number > 0)
            {
                List<Student> resultsAge = studentsList.Where(d =>
                    today.Year - DateTime.Parse(d.StudentDateBirth).Year == number).ToList();
                results.AddRange(resultsAge);
            }

            List<Student> studentPromoOrName = studentsList.Where(x => x.StudentPromoName.Contains(search)
                || x.StudentLastName.StartsWith(search)).ToList();
            results.AddRange(studentPromoOrName);

            foreach (var promo in promoList)
            {
                foreach (var student in studentsList)
                {
                    if (student.StudentPromoName == promo.PromoName && promo.PromoDept.Contains(search))
                        results.Add(student);
                }
            }
            //Deleting doublons
            return results.Distinct().ToList();
        }

        /// <summary>
        /// Function to edit a student
        /// </summary>
        /// <param name="oldStudentInfos">The string containing the students' informations to edit</param>
        /// <param name="studentFirstName">new student' firstname</param>
        /// <param name="studentLastName">new student' lastname</param>
        /// <param name="studentBirthDate">new student' birth date</param>
        /// <param name="studentPromo">the new student' promotion</param>
        public void EditStudent(string oldStudentInfos, string studentFirstName, string studentLastName,
            string studentBirthDate, string studentPromo)
        {
            string[] studentsInfos = oldStudentInfos.Split('-');
            string m_studentOldFirstName = studentsInfos[0];
            string m_studentOldLastName = studentsInfos[1];
            string m_studentOldPromoName = studentsInfos[2];
            string m_studentOldBirthDate = studentsInfos[3];

            Student studentOldInfos = new Student()
            {
                StudentFirstName = m_studentOldFirstName,
                StudentLastName = m_studentOldFirstName,
                StudentPromoName = m_studentOldPromoName,
                StudentDateBirth = m_studentOldBirthDate
            };

            string contentStudents = OpenFiles.OpenStudentFile();
            studentsList = JsonConvert.DeserializeObject<List<Student>>(contentStudents);

            int studentIndexToEdit = studentsList.FindIndex(x => x.StudentLastName == m_studentOldLastName
                && x.StudentFirstName == m_studentOldFirstName
                && x.StudentDateBirth == m_studentOldBirthDate);

            Student studentToEdit = studentsList[studentIndexToEdit];
            studentsList.Remove(studentToEdit);
            studentToEdit = new Student()
            {
                StudentFirstName = studentFirstName,
                StudentLastName = studentLastName,
                StudentDateBirth = studentBirthDate,
                StudentPromoName = studentPromo
            };
            studentsList.Add(studentToEdit);
            var json = JsonConvert.SerializeObject(studentsList, Formatting.Indented);
            File.WriteAllText(OpenFiles.studentLocation, json);
        }
    }
}
