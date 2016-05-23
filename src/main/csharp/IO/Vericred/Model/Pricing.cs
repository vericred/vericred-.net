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
    public partial class Pricing :  IEquatable<Pricing>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// Initializes a new instance of the <see cref="Pricing" />class.
        /// </summary>
        /// <param name="Age">Age of applicant.</param>
        /// <param name="EffectiveDate">Effective date of plan.</param>
        /// <param name="ExpirationDate">Plan expiration date.</param>
        /// <param name="PlanId">Foreign key to plans.</param>
        /// <param name="PremiumChildOnly">Child-only premium.</param>
        /// <param name="PremiumFamily">Family premium.</param>
        /// <param name="PremiumSingle">Single-person premium.</param>
        /// <param name="PremiumSingleAndChildren">Single person including children premium.</param>
        /// <param name="PremiumSingleAndSpouse">Person with spouse premium.</param>
        /// <param name="PremiumSingleSmoker">Premium for single smoker.</param>
        /// <param name="RatingAreaId">Foreign key to rating areas.</param>

        public Pricing(int? Age = null, DateTime? EffectiveDate = null, DateTime? ExpirationDate = null, int? PlanId = null, double? PremiumChildOnly = null, double? PremiumFamily = null, double? PremiumSingle = null, double? PremiumSingleAndChildren = null, double? PremiumSingleAndSpouse = null, double? PremiumSingleSmoker = null, string RatingAreaId = null)
        {
            this.Age = Age;
            this.EffectiveDate = EffectiveDate;
            this.ExpirationDate = ExpirationDate;
            this.PlanId = PlanId;
            this.PremiumChildOnly = PremiumChildOnly;
            this.PremiumFamily = PremiumFamily;
            this.PremiumSingle = PremiumSingle;
            this.PremiumSingleAndChildren = PremiumSingleAndChildren;
            this.PremiumSingleAndSpouse = PremiumSingleAndSpouse;
            this.PremiumSingleSmoker = PremiumSingleSmoker;
            this.RatingAreaId = RatingAreaId;
            
        }

    
        /// <summary>
        /// Age of applicant
        /// </summary>
        /// <value>Age of applicant</value>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public int? Age { get; set; }
    
        /// <summary>
        /// Effective date of plan
        /// </summary>
        /// <value>Effective date of plan</value>
        [DataMember(Name="effective_date", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
    
        /// <summary>
        /// Plan expiration date
        /// </summary>
        /// <value>Plan expiration date</value>
        [DataMember(Name="expiration_date", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }
    
        /// <summary>
        /// Foreign key to plans
        /// </summary>
        /// <value>Foreign key to plans</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public int? PlanId { get; set; }
    
        /// <summary>
        /// Child-only premium
        /// </summary>
        /// <value>Child-only premium</value>
        [DataMember(Name="premium_child_only", EmitDefaultValue=false)]
        public double? PremiumChildOnly { get; set; }
    
        /// <summary>
        /// Family premium
        /// </summary>
        /// <value>Family premium</value>
        [DataMember(Name="premium_family", EmitDefaultValue=false)]
        public double? PremiumFamily { get; set; }
    
        /// <summary>
        /// Single-person premium
        /// </summary>
        /// <value>Single-person premium</value>
        [DataMember(Name="premium_single", EmitDefaultValue=false)]
        public double? PremiumSingle { get; set; }
    
        /// <summary>
        /// Single person including children premium
        /// </summary>
        /// <value>Single person including children premium</value>
        [DataMember(Name="premium_single_and_children", EmitDefaultValue=false)]
        public double? PremiumSingleAndChildren { get; set; }
    
        /// <summary>
        /// Person with spouse premium
        /// </summary>
        /// <value>Person with spouse premium</value>
        [DataMember(Name="premium_single_and_spouse", EmitDefaultValue=false)]
        public double? PremiumSingleAndSpouse { get; set; }
    
        /// <summary>
        /// Premium for single smoker
        /// </summary>
        /// <value>Premium for single smoker</value>
        [DataMember(Name="premium_single_smoker", EmitDefaultValue=false)]
        public double? PremiumSingleSmoker { get; set; }
    
        /// <summary>
        /// Foreign key to rating areas
        /// </summary>
        /// <value>Foreign key to rating areas</value>
        [DataMember(Name="rating_area_id", EmitDefaultValue=false)]
        public string RatingAreaId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pricing {\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PremiumChildOnly: ").Append(PremiumChildOnly).Append("\n");
            sb.Append("  PremiumFamily: ").Append(PremiumFamily).Append("\n");
            sb.Append("  PremiumSingle: ").Append(PremiumSingle).Append("\n");
            sb.Append("  PremiumSingleAndChildren: ").Append(PremiumSingleAndChildren).Append("\n");
            sb.Append("  PremiumSingleAndSpouse: ").Append(PremiumSingleAndSpouse).Append("\n");
            sb.Append("  PremiumSingleSmoker: ").Append(PremiumSingleSmoker).Append("\n");
            sb.Append("  RatingAreaId: ").Append(RatingAreaId).Append("\n");
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
            return this.Equals(obj as Pricing);
        }

        /// <summary>
        /// Returns true if Pricing instances are equal
        /// </summary>
        /// <param name="other">Instance of Pricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pricing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Age == other.Age ||
                    this.Age != null &&
                    this.Age.Equals(other.Age)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.PremiumChildOnly == other.PremiumChildOnly ||
                    this.PremiumChildOnly != null &&
                    this.PremiumChildOnly.Equals(other.PremiumChildOnly)
                ) && 
                (
                    this.PremiumFamily == other.PremiumFamily ||
                    this.PremiumFamily != null &&
                    this.PremiumFamily.Equals(other.PremiumFamily)
                ) && 
                (
                    this.PremiumSingle == other.PremiumSingle ||
                    this.PremiumSingle != null &&
                    this.PremiumSingle.Equals(other.PremiumSingle)
                ) && 
                (
                    this.PremiumSingleAndChildren == other.PremiumSingleAndChildren ||
                    this.PremiumSingleAndChildren != null &&
                    this.PremiumSingleAndChildren.Equals(other.PremiumSingleAndChildren)
                ) && 
                (
                    this.PremiumSingleAndSpouse == other.PremiumSingleAndSpouse ||
                    this.PremiumSingleAndSpouse != null &&
                    this.PremiumSingleAndSpouse.Equals(other.PremiumSingleAndSpouse)
                ) && 
                (
                    this.PremiumSingleSmoker == other.PremiumSingleSmoker ||
                    this.PremiumSingleSmoker != null &&
                    this.PremiumSingleSmoker.Equals(other.PremiumSingleSmoker)
                ) && 
                (
                    this.RatingAreaId == other.RatingAreaId ||
                    this.RatingAreaId != null &&
                    this.RatingAreaId.Equals(other.RatingAreaId)
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
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.PremiumChildOnly != null)
                    hash = hash * 59 + this.PremiumChildOnly.GetHashCode();
                if (this.PremiumFamily != null)
                    hash = hash * 59 + this.PremiumFamily.GetHashCode();
                if (this.PremiumSingle != null)
                    hash = hash * 59 + this.PremiumSingle.GetHashCode();
                if (this.PremiumSingleAndChildren != null)
                    hash = hash * 59 + this.PremiumSingleAndChildren.GetHashCode();
                if (this.PremiumSingleAndSpouse != null)
                    hash = hash * 59 + this.PremiumSingleAndSpouse.GetHashCode();
                if (this.PremiumSingleSmoker != null)
                    hash = hash * 59 + this.PremiumSingleSmoker.GetHashCode();
                if (this.RatingAreaId != null)
                    hash = hash * 59 + this.RatingAreaId.GetHashCode();
                return hash;
            }
        }

    }
}
