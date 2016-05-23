using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Vericred.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RequestPlanFindApplicant :  IEquatable<RequestPlanFindApplicant>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPlanFindApplicant" /> class.
        /// Initializes a new instance of the <see cref="RequestPlanFindApplicant" />class.
        /// </summary>
        /// <param name="Age">Age of applicant to search for.</param>

        public RequestPlanFindApplicant(int? Age = null)
        {
            this.Age = Age;
            
        }

    
        /// <summary>
        /// Age of applicant to search for
        /// </summary>
        /// <value>Age of applicant to search for</value>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public int? Age { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestPlanFindApplicant {\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RequestPlanFindApplicant);
        }

        /// <summary>
        /// Returns true if RequestPlanFindApplicant instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestPlanFindApplicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestPlanFindApplicant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Age == other.Age ||
                    this.Age != null &&
                    this.Age.Equals(other.Age)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Age != null)
                    hash = hash * 59 + this.Age.GetHashCode();
                return hash;
            }
        }

    }
}
