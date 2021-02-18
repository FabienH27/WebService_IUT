using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService_IUT.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICRUD
    {
        [OperationContract]
        bool AddDepartment(string departmentName);

        [OperationContract]
        void AddPromo(string promoName, string promoDept);

        [OperationContract]
        void AddStudent(string studentFirstName, string studentLastName, DateTime studentBirthDate, string promoName);

        [OperationContract]
        List<string> UpdatePromoLists();

        [OperationContract]
        List<string> UpdateDeptLists();
    }
}
