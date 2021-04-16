using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AnagraficaClienti.EntitiesLayer.Entities
{
    //[DataContract]
    public class Client
    {
        public int Id { get; set; }

        //[DataMember]
        public string ClientCode { get; set; }

        //[DataMember]
        public string Name { get; set; }

        //[DataMember]
        public string Surname { get; set; }

        //[DataMember]
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
