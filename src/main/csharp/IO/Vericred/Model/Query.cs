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
    public partial class Query :  IEquatable<Query>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// Initializes a new instance of the <see cref="Query" />class.
        /// </summary>
        /// <param name="Applicants">Applicants.</param>
        /// <param name="EnrollmentDate">EnrollmentDate.</param>
        /// <param name="FipsCode">FipsCode.</param>
        /// <param name="HouseholdIncome">HouseholdIncome.</param>
        /// <param name="HouseholdSize">HouseholdSize.</param>
        /// <param name="Market">Market.</param>
        /// <param name="Providers">Providers.</param>
        /// <param name="ZipCode">ZipCode.</param>

        public Query(List<Applicant> Applicants = null, DateTime? EnrollmentDate = null, string FipsCode = null, string HouseholdIncome = null, string HouseholdSize = null, string Market = null, List<string> Providers = null, string ZipCode = null)
        {
            this.Applicants = Applicants;
            this.EnrollmentDate = EnrollmentDate;
            this.FipsCode = FipsCode;
            this.HouseholdIncome = HouseholdIncome;
            this.HouseholdSize = HouseholdSize;
            this.Market = Market;
            this.Providers = Providers;
            this.ZipCode = ZipCode;
            
        }

    
        /// <summary>
        /// Gets or Sets Applicants
        /// </summary>
        [DataMember(Name="applicants", EmitDefaultValue=false)]
        public List<Applicant> Applicants { get; set; }
    
        /// <summary>
        /// Gets or Sets EnrollmentDate
        /// </summary>
        [DataMember(Name="enrollment_date", EmitDefaultValue=false)]
        public DateTime? EnrollmentDate { get; set; }
    
        /// <summary>
        /// Gets or Sets FipsCode
        /// </summary>
        [DataMember(Name="fips_code", EmitDefaultValue=false)]
        public string FipsCode { get; set; }
    
        /// <summary>
        /// Gets or Sets HouseholdIncome
        /// </summary>
        [DataMember(Name="household_income", EmitDefaultValue=false)]
        public string HouseholdIncome { get; set; }
    
        /// <summary>
        /// Gets or Sets HouseholdSize
        /// </summary>
        [DataMember(Name="household_size", EmitDefaultValue=false)]
        public string HouseholdSize { get; set; }
    
        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public string Market { get; set; }
    
        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public List<string> Providers { get; set; }
    
        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Query {\n");
            sb.Append("  Applicants: ").Append(Applicants).Append("\n");
            sb.Append("  EnrollmentDate: ").Append(EnrollmentDate).Append("\n");
            sb.Append("  FipsCode: ").Append(FipsCode).Append("\n");
            sb.Append("  HouseholdIncome: ").Append(HouseholdIncome).Append("\n");
            sb.Append("  HouseholdSize: ").Append(HouseholdSize).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
            return this.Equals(obj as Query);
        }

        /// <summary>
        /// Returns true if Query instances are equal
        /// </summary>
        /// <param name="other">Instance of Query to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Query other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Applicants == other.Applicants ||
                    this.Applicants != null &&
                    this.Applicants.SequenceEqual(other.Applicants)
                ) && 
                (
                    this.EnrollmentDate == other.EnrollmentDate ||
                    this.EnrollmentDate != null &&
                    this.EnrollmentDate.Equals(other.EnrollmentDate)
                ) && 
                (
                    this.FipsCode == other.FipsCode ||
                    this.FipsCode != null &&
                    this.FipsCode.Equals(other.FipsCode)
                ) && 
                (
                    this.HouseholdIncome == other.HouseholdIncome ||
                    this.HouseholdIncome != null &&
                    this.HouseholdIncome.Equals(other.HouseholdIncome)
                ) && 
                (
                    this.HouseholdSize == other.HouseholdSize ||
                    this.HouseholdSize != null &&
                    this.HouseholdSize.Equals(other.HouseholdSize)
                ) && 
                (
                    this.Market == other.Market ||
                    this.Market != null &&
                    this.Market.Equals(other.Market)
                ) && 
                (
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.SequenceEqual(other.Providers)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
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
                if (this.Applicants != null)
                    hash = hash * 59 + this.Applicants.GetHashCode();
                if (this.EnrollmentDate != null)
                    hash = hash * 59 + this.EnrollmentDate.GetHashCode();
                if (this.FipsCode != null)
                    hash = hash * 59 + this.FipsCode.GetHashCode();
                if (this.HouseholdIncome != null)
                    hash = hash * 59 + this.HouseholdIncome.GetHashCode();
                if (this.HouseholdSize != null)
                    hash = hash * 59 + this.HouseholdSize.GetHashCode();
                if (this.Market != null)
                    hash = hash * 59 + this.Market.GetHashCode();
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                return hash;
            }
        }

    }
}
