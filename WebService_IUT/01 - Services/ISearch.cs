using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService_IUT.DataContracts;

namespace WebService_IUT.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ISearch
    {
        [OperationContract]
        List<Student> SearchStudents(string studentToSearch);

        [OperationContract]
        void EditStudent(string oldStudentInfos, string studentFirstName, string studentLastName,
            string studentBirthDate, string studentPromo);
    }
}
