using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebService_IUT.Files
{
    public class OpenFiles
    {
        static string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string studentLocation = Path.Combine(executableLocation, "students.json");

        public static string deptLocation = Path.Combine(executableLocation, "depts.json");

        public static string promosLocation = Path.Combine(executableLocation, "promos.json");

        public static string OpenStudentFile()
        {
            string contentStudent = "[]";
            try
            {
                contentStudent = File.ReadAllText(studentLocation);
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.Message);
                File.Create(studentLocation);
            }
            if (contentStudent == "")
            {
                contentStudent += "[]";
            }
            return contentStudent;
        }
        public static string OpenDeptFile()
        {
            string contentDepts = "[]";
            try
            {
                contentDepts = File.ReadAllText(deptLocation);
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.Message);
                File.Create(deptLocation);
            }
            if (contentDepts == "")
            {
                contentDepts += "[]";
            }
            return contentDepts;
        }
        public static string OpenPromoFile()
        {
            string contentPromo = "[]";
            try
            {
                contentPromo = File.ReadAllText(promosLocation);
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.Message);
                File.Create(promosLocation);
            }
            if (contentPromo == "")
            {
                contentPromo += "[]";
            }
            return contentPromo;
        }
    }
}
