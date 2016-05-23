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
    public partial class Applicant :  IEquatable<Applicant>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Applicant" /> class.
        /// Initializes a new instance of the <see cref="Applicant" />class.
        /// </summary>
        /// <param name="Id">Primary key.</param>
        /// <param name="Dob">Date of Birth.</param>
        /// <param name="MemberId">Member token.</param>
        /// <param name="Name">Full name of the Applicant.</param>
        /// <param name="Relationship">Relationship of the Applicant to the Member.</param>
        /// <param name="Smoker">Does the Applicant smoke?.</param>
        /// <param name="Ssn">Applicant&#39;s Social Security Number.</param>

        public Applicant(int? Id = null, DateTime? Dob = null, string MemberId = null, string Name = null, string Relationship = null, bool? Smoker = null, string Ssn = null)
        {
            this.Id = Id;
            this.Dob = Dob;
            this.MemberId = MemberId;
            this.Name = Name;
            this.Relationship = Relationship;
            this.Smoker = Smoker;
            this.Ssn = Ssn;
            
        }

    
        /// <summary>
        /// Primary key
        /// </summary>
        /// <value>Primary key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Date of Birth
        /// </summary>
        /// <value>Date of Birth</value>
        [DataMember(Name="dob", EmitDefaultValue=false)]
        public DateTime? Dob { get; set; }
    
        /// <summary>
        /// Member token
        /// </summary>
        /// <value>Member token</value>
        [DataMember(Name="member_id", EmitDefaultValue=false)]
        public string MemberId { get; set; }
    
        /// <summary>
        /// Full name of the Applicant
        /// </summary>
        /// <value>Full name of the Applicant</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Relationship of the Applicant to the Member
        /// </summary>
        /// <value>Relationship of the Applicant to the Member</value>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string Relationship { get; set; }
    
        /// <summary>
        /// Does the Applicant smoke?
        /// </summary>
        /// <value>Does the Applicant smoke?</value>
        [DataMember(Name="smoker", EmitDefaultValue=false)]
        public bool? Smoker { get; set; }
    
        /// <summary>
        /// Applicant&#39;s Social Security Number
        /// </summary>
        /// <value>Applicant&#39;s Social Security Number</value>
        [DataMember(Name="ssn", EmitDefaultValue=false)]
        public string Ssn { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Applicant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  Smoker: ").Append(Smoker).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
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
            return this.Equals(obj as Applicant);
        }

        /// <summary>
        /// Returns true if Applicant instances are equal
        /// </summary>
        /// <param name="other">Instance of Applicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Applicant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Dob == other.Dob ||
                    this.Dob != null &&
                    this.Dob.Equals(other.Dob)
                ) && 
                (
                    this.MemberId == other.MemberId ||
                    this.MemberId != null &&
                    this.MemberId.Equals(other.MemberId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Relationship == other.Relationship ||
                    this.Relationship != null &&
                    this.Relationship.Equals(other.Relationship)
                ) && 
                (
                    this.Smoker == other.Smoker ||
                    this.Smoker != null &&
                    this.Smoker.Equals(other.Smoker)
                ) && 
                (
                    this.Ssn == other.Ssn ||
                    this.Ssn != null &&
                    this.Ssn.Equals(other.Ssn)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Dob != null)
                    hash = hash * 59 + this.Dob.GetHashCode();
                if (this.MemberId != null)
                    hash = hash * 59 + this.MemberId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Relationship != null)
                    hash = hash * 59 + this.Relationship.GetHashCode();
                if (this.Smoker != null)
                    hash = hash * 59 + this.Smoker.GetHashCode();
                if (this.Ssn != null)
                    hash = hash * 59 + this.Ssn.GetHashCode();
                return hash;
            }
        }

    }
}
