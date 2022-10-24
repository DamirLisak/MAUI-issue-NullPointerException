using System;
using System.Runtime.Serialization;
using System.Reflection;
using System.Collections.Generic;

namespace gip.vbm.mobile
{
    [DataContract]
    public class ACClass
    {
        [DataMember(Name = "ACI")]
        public string ACIdentifier
        {
            get; set;
        }

        [DataMember(Name = "CT")]
        public string ACCaption
        {
            get; set;
        }

        [DataMember(Name = "ACUrlC")]
        public string ACUrlComponent
        {
            get; set;
        }
    }
}
