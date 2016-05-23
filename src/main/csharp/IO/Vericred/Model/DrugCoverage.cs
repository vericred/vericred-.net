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
    public partial class DrugCoverage :  IEquatable<DrugCoverage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DrugCoverage" /> class.
        /// Initializes a new instance of the <see cref="DrugCoverage" />class.
        /// </summary>
        /// <param name="PlanId">Health Insurance Oversight System id.</param>
        /// <param name="DrugPackageId">NDC package code.</param>
        /// <param name="Tier">Tier Name.</param>
        /// <param name="QuantityLimit">Quantity limit exists.</param>
        /// <param name="PriorAuthorization">Prior authorization required.</param>
        /// <param name="StepTherapy">Step Treatment required.</param>

        public DrugCoverage(string PlanId = null, string DrugPackageId = null, string Tier = null, bool? QuantityLimit = null, bool? PriorAuthorization = null, bool? StepTherapy = null)
        {
            this.PlanId = PlanId;
            this.DrugPackageId = DrugPackageId;
            this.Tier = Tier;
            this.QuantityLimit = QuantityLimit;
            this.PriorAuthorization = PriorAuthorization;
            this.StepTherapy = StepTherapy;
            
        }

    
        /// <summary>
        /// Health Insurance Oversight System id
        /// </summary>
        /// <value>Health Insurance Oversight System id</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string PlanId { get; set; }
    
        /// <summary>
        /// NDC package code
        /// </summary>
        /// <value>NDC package code</value>
        [DataMember(Name="drug_package_id", EmitDefaultValue=false)]
        public string DrugPackageId { get; set; }
    
        /// <summary>
        /// Tier Name
        /// </summary>
        /// <value>Tier Name</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }
    
        /// <summary>
        /// Quantity limit exists
        /// </summary>
        /// <value>Quantity limit exists</value>
        [DataMember(Name="quantity_limit", EmitDefaultValue=false)]
        public bool? QuantityLimit { get; set; }
    
        /// <summary>
        /// Prior authorization required
        /// </summary>
        /// <value>Prior authorization required</value>
        [DataMember(Name="prior_authorization", EmitDefaultValue=false)]
        public bool? PriorAuthorization { get; set; }
    
        /// <summary>
        /// Step Treatment required
        /// </summary>
        /// <value>Step Treatment required</value>
        [DataMember(Name="step_therapy", EmitDefaultValue=false)]
        public bool? StepTherapy { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrugCoverage {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  DrugPackageId: ").Append(DrugPackageId).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  QuantityLimit: ").Append(QuantityLimit).Append("\n");
            sb.Append("  PriorAuthorization: ").Append(PriorAuthorization).Append("\n");
            sb.Append("  StepTherapy: ").Append(StepTherapy).Append("\n");
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
            return this.Equals(obj as DrugCoverage);
        }

        /// <summary>
        /// Returns true if DrugCoverage instances are equal
        /// </summary>
        /// <param name="other">Instance of DrugCoverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrugCoverage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.DrugPackageId == other.DrugPackageId ||
                    this.DrugPackageId != null &&
                    this.DrugPackageId.Equals(other.DrugPackageId)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) && 
                (
                    this.QuantityLimit == other.QuantityLimit ||
                    this.QuantityLimit != null &&
                    this.QuantityLimit.Equals(other.QuantityLimit)
                ) && 
                (
                    this.PriorAuthorization == other.PriorAuthorization ||
                    this.PriorAuthorization != null &&
                    this.PriorAuthorization.Equals(other.PriorAuthorization)
                ) && 
                (
                    this.StepTherapy == other.StepTherapy ||
                    this.StepTherapy != null &&
                    this.StepTherapy.Equals(other.StepTherapy)
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
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.DrugPackageId != null)
                    hash = hash * 59 + this.DrugPackageId.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                if (this.QuantityLimit != null)
                    hash = hash * 59 + this.QuantityLimit.GetHashCode();
                if (this.PriorAuthorization != null)
                    hash = hash * 59 + this.PriorAuthorization.GetHashCode();
                if (this.StepTherapy != null)
                    hash = hash * 59 + this.StepTherapy.GetHashCode();
                return hash;
            }
        }

    }
}
