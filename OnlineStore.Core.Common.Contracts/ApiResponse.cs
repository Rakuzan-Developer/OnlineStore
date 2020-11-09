using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OnlineStore.Core.Common.Contracts
{
    [DataContract]
    public class ApiResponse<T>
    {
        [DataMember]
        public string Version { get { return "1.0"; } }

        [DataMember]
        public int StatusCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public T Result { get; set; }

    }
}
