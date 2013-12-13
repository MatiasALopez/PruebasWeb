using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Website.KnockoutJS
{
    [DataContract]
    public class Status
    {
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public bool Value { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }
    }
}