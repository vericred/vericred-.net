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
    public partial class RequestPlanFind :  IEquatable<RequestPlanFind>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPlanFind" /> class.
        /// Initializes a new instance of the <see cref="RequestPlanFind" />class.
        /// </summary>
        /// <param name="Applicants">Applicants for desired plans..</param>
        /// <param name="EnrollmentDate">Date of enrollment.</param>
        /// <param name="DrugPackages">National Drug Code Package Id.</param>
        /// <param name="FipsCode">County code to determine eligibility.</param>
        /// <param name="HouseholdIncome">Total household income..</param>
        /// <param name="HouseholdSize">Number of people living in household..</param>
        /// <param name="Market">Type of plan to search for..</param>
        /// <param name="Providers">List of providers to search for..</param>
        /// <param name="Page">Selected page of paginated response..</param>
        /// <param name="PerPage">Results per page of response..</param>
        /// <param name="Sort">Sort responses by plan field..</param>
        /// <param name="ZipCode">5-digit zip code - this helps determine pricing..</param>

        public RequestPlanFind(List<RequestPlanFindApplicant> Applicants = null, string EnrollmentDate = null, List<DrugPackage> DrugPackages = null, string FipsCode = null, int? HouseholdIncome = null, int? HouseholdSize = null, string Market = null, List<RequestPlanFindProvider> Providers = null, int? Page = null, int? PerPage = null, string Sort = null, string ZipCode = null)
        {
            this.Applicants = Applicants;
            this.EnrollmentDate = EnrollmentDate;
            this.DrugPackages = DrugPackages;
            this.FipsCode = FipsCode;
            this.HouseholdIncome = HouseholdIncome;
            this.HouseholdSize = HouseholdSize;
            this.Market = Market;
            this.Providers = Providers;
            this.Page = Page;
            this.PerPage = PerPage;
            this.Sort = Sort;
            this.ZipCode = ZipCode;
            
        }

    
        /// <summary>
        /// Applicants for desired plans.
        /// </summary>
        /// <value>Applicants for desired plans.</value>
        [DataMember(Name="applicants", EmitDefaultValue=false)]
        public List<RequestPlanFindApplicant> Applicants { get; set; }
    
        /// <summary>
        /// Date of enrollment
        /// </summary>
        /// <value>Date of enrollment</value>
        [DataMember(Name="enrollment_date", EmitDefaultValue=false)]
        public string EnrollmentDate { get; set; }
    
        /// <summary>
        /// National Drug Code Package Id
        /// </summary>
        /// <value>National Drug Code Package Id</value>
        [DataMember(Name="drug_packages", EmitDefaultValue=false)]
        public List<DrugPackage> DrugPackages { get; set; }
    
        /// <summary>
        /// County code to determine eligibility
        /// </summary>
        /// <value>County code to determine eligibility</value>
        [DataMember(Name="fips_code", EmitDefaultValue=false)]
        public string FipsCode { get; set; }
    
        /// <summary>
        /// Total household income.
        /// </summary>
        /// <value>Total household income.</value>
        [DataMember(Name="household_income", EmitDefaultValue=false)]
        public int? HouseholdIncome { get; set; }
    
        /// <summary>
        /// Number of people living in household.
        /// </summary>
        /// <value>Number of people living in household.</value>
        [DataMember(Name="household_size", EmitDefaultValue=false)]
        public int? HouseholdSize { get; set; }
    
        /// <summary>
        /// Type of plan to search for.
        /// </summary>
        /// <value>Type of plan to search for.</value>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public string Market { get; set; }
    
        /// <summary>
        /// List of providers to search for.
        /// </summary>
        /// <value>List of providers to search for.</value>
        [DataMember(Name="providers", EmitDefaultValue=false)]
        public List<RequestPlanFindProvider> Providers { get; set; }
    
        /// <summary>
        /// Selected page of paginated response.
        /// </summary>
        /// <value>Selected page of paginated response.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
    
        /// <summary>
        /// Results per page of response.
        /// </summary>
        /// <value>Results per page of response.</value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }
    
        /// <summary>
        /// Sort responses by plan field.
        /// </summary>
        /// <value>Sort responses by plan field.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }
    
        /// <summary>
        /// 5-digit zip code - this helps determine pricing.
        /// </summary>
        /// <value>5-digit zip code - this helps determine pricing.</value>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestPlanFind {\n");
            sb.Append("  Applicants: ").Append(Applicants).Append("\n");
            sb.Append("  EnrollmentDate: ").Append(EnrollmentDate).Append("\n");
            sb.Append("  DrugPackages: ").Append(DrugPackages).Append("\n");
            sb.Append("  FipsCode: ").Append(FipsCode).Append("\n");
            sb.Append("  HouseholdIncome: ").Append(HouseholdIncome).Append("\n");
            sb.Append("  HouseholdSize: ").Append(HouseholdSize).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(obj as RequestPlanFind);
        }

        /// <summary>
        /// Returns true if RequestPlanFind instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestPlanFind to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestPlanFind other)
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
                    this.DrugPackages == other.DrugPackages ||
                    this.DrugPackages != null &&
                    this.DrugPackages.SequenceEqual(other.DrugPackages)
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
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PerPage == other.PerPage ||
                    this.PerPage != null &&
                    this.PerPage.Equals(other.PerPage)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
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
                if (this.DrugPackages != null)
                    hash = hash * 59 + this.DrugPackages.GetHashCode();
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
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hash = hash * 59 + this.PerPage.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                return hash;
            }
        }

    }
}
