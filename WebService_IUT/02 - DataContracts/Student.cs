using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService_IUT.DataContracts
{
    [DataContract]
    public class Student
    {
        string m_lastName;
        string m_firstName;
        string m_birth;
        string m_promo;
        int m_studentId = 0;

        [DataMember]
        public string StudentFirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }

        [DataMember]
        public string StudentLastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }

        [DataMember]
        public string StudentDateBirth
        {
            get { return m_birth; }
            set { m_birth = value; }
        }

        [DataMember]
        public string StudentPromoName
        {
            get { return m_promo; }
            set { m_promo = value; }
        }

        public int StudentId
        {
            get { return m_studentId;}
            private set { m_studentId++; }
        }

        public Student()
        {
            StudentId++;
        }
    }
}
    