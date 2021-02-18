using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService_IUT.DataContracts
{
    [DataContract]
    public class Departments
    {
        string m_departmentName;
        int m_deptId;

        [DataMember]
        public string DeptName
        {
            get { return m_departmentName; }
            set { m_departmentName = value; }
        }
        public int DeptId
        {
            get { return m_deptId++; }
            private set { }
        }
    }
}
