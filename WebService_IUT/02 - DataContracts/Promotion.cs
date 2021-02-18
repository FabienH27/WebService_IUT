using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService_IUT.DataContracts
{
    [DataContract]
    public class Promotion
    {
        public string m_promotionName;
        public string m_promoDept;
        public List<Student> m_studentPromo = new List<Student>();
        int m_promoId;

        [DataMember]
        public string PromoName
        {
            get { return m_promotionName; }
            set { m_promotionName = value; }
        }

        [DataMember]
        public string PromoDept
        {
            get { return m_promoDept; }
            set { m_promoDept = value; }
        }

        [DataMember]
        public List<Student> StudentsPromotion
        {
            get { return m_studentPromo; }
            set { m_studentPromo = value; }
        }

        public int DeptId
        {
            get { return m_promoId++; }
            private set { }
        }
    }
}
