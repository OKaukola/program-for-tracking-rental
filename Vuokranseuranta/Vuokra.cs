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
    public class Vuokra
    {
        [DataMember]
        public string Kuukausi { get; set; }
        [DataMember]
        public string Vuokrasumma { get; set; }
        [DataMember]
        public string Vuokrapvm { get; set; }
        [DataMember]
        public string Vastike { get; set; }
        [DataMember]
        public string Vastikepvm { get; set; }
        [DataMember]
        public string Muistiinp { get; set; }

        public Vuokra()
        {

        }

        public Vuokra(string kuukausi,string vuokrasumma,string vuokrapvm, string vastike, string vastikepvm,string muistiinp)
        {
            Kuukausi = kuukausi;
            Vuokrasumma = vuokrasumma;
            Vuokrapvm = vuokrapvm;
            Vastike = vastike;
            Vastikepvm = vastikepvm;
            Muistiinp = muistiinp;
        }

        public override string ToString()
        {
            return Kuukausi + " " + Vuokrasumma + " " + Vuokrapvm + " " + Vastike + " " + Vastikepvm + " " + Muistiinp;
        }




    }
}
