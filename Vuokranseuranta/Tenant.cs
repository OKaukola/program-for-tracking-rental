using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace Vuokranseuranta
{
    [DataContract]
    public class Tenant
    {
        [DataMember]
        public int Aid { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public int Cid { get; set; }

        public Tenant()
        {

        }

        public Tenant(int aid, string name, string phone, int cid)
        {
            Aid = aid;
            Name = name;
            Phone = phone;
            Cid = cid;
        }

        public override string ToString()
        {
            return Name + " " + Phone;
        }
    }
}
