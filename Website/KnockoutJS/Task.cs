using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Website.KnockoutJS
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public string title { get; set; }
        
        [DataMember]
        public bool isDone { get; set; }

        [DataMember]
        public bool _destroy { get; set; }
    }
}