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
        string m_promotionName;
        string m_promoDept;
        List<Student> m_studentPromo = new List<Student>();
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

        public int PromoId
        {
            get { return m_promoId; }
            private set { m_promoId++; }
        }

        public Promotion()
        {
            PromoId++;
        }

    }
}
