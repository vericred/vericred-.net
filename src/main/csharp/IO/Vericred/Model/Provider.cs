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
    public partial class Provider :  IEquatable<Provider>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// Initializes a new instance of the <see cref="Provider" />class.
        /// </summary>
        /// <param name="AcceptingChangeOfPayorPatients">Is this provider accepting patients with a change of insurance?.</param>
        /// <param name="AcceptingMedicaidPatients">Is this provider accepting new Medicaid patients?.</param>
        /// <param name="AcceptingMedicarePatients">Is this provider accepting new Medicare patients?.</param>
        /// <param name="AcceptingPrivatePatients">Is this provider accepting new patients with private insurance?.</param>
        /// <param name="AcceptingReferralPatients">Is this provider accepting new patients via referrals?.</param>
        /// <param name="City">City name (e.g. Springfield)..</param>
        /// <param name="Email">Primary email address to contact the provider..</param>
        /// <param name="Gender">Provider&#39;s gender (M or F).</param>
        /// <param name="FirstName">Given name for the provider..</param>
        /// <param name="Id">National Provider Index (NPI) number.</param>
        /// <param name="LastName">Family name for the provider..</param>
        /// <param name="MiddleName">Middle name for the provider..</param>
        /// <param name="PersonalPhone">Personal contact phone for the provider..</param>
        /// <param name="Phone">Office phone for the provider.</param>
        /// <param name="PresentationName">Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White).</param>
        /// <param name="Specialty">Name of the primary Specialty.</param>
        /// <param name="State">State code for the provider&#39;s address (e.g. NY)..</param>
        /// <param name="StateId">Foreign key to States.</param>
        /// <param name="StreetLine1">First line of the provider&#39;s street address..</param>
        /// <param name="StreetLine2">Second line of the provider&#39;s street address..</param>
        /// <param name="Suffix">Suffix for the provider&#39;s name (e.g. Jr).</param>
        /// <param name="Title">Professional title for the provider (e.g. Dr)..</param>
        /// <param name="Type">Type of NPI number (individual provider vs organization)..</param>
        /// <param name="ZipCode">Postal code for the provider&#39;s address (e.g. 11215).</param>

        public Provider(bool? AcceptingChangeOfPayorPatients = null, bool? AcceptingMedicaidPatients = null, bool? AcceptingMedicarePatients = null, bool? AcceptingPrivatePatients = null, bool? AcceptingReferralPatients = null, string City = null, string Email = null, string Gender = null, string FirstName = null, int? Id = null, string LastName = null, string MiddleName = null, string PersonalPhone = null, string Phone = null, string PresentationName = null, string Specialty = null, string State = null, int? StateId = null, string StreetLine1 = null, string StreetLine2 = null, string Suffix = null, string Title = null, string Type = null, string ZipCode = null)
        {
            this.AcceptingChangeOfPayorPatients = AcceptingChangeOfPayorPatients;
            this.AcceptingMedicaidPatients = AcceptingMedicaidPatients;
            this.AcceptingMedicarePatients = AcceptingMedicarePatients;
            this.AcceptingPrivatePatients = AcceptingPrivatePatients;
            this.AcceptingReferralPatients = AcceptingReferralPatients;
            this.City = City;
            this.Email = Email;
            this.Gender = Gender;
            this.FirstName = FirstName;
            this.Id = Id;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.PersonalPhone = PersonalPhone;
            this.Phone = Phone;
            this.PresentationName = PresentationName;
            this.Specialty = Specialty;
            this.State = State;
            this.StateId = StateId;
            this.StreetLine1 = StreetLine1;
            this.StreetLine2 = StreetLine2;
            this.Suffix = Suffix;
            this.Title = Title;
            this.Type = Type;
            this.ZipCode = ZipCode;
            
        }

    
        /// <summary>
        /// Is this provider accepting patients with a change of insurance?
        /// </summary>
        /// <value>Is this provider accepting patients with a change of insurance?</value>
        [DataMember(Name="accepting_change_of_payor_patients", EmitDefaultValue=false)]
        public bool? AcceptingChangeOfPayorPatients { get; set; }
    
        /// <summary>
        /// Is this provider accepting new Medicaid patients?
        /// </summary>
        /// <value>Is this provider accepting new Medicaid patients?</value>
        [DataMember(Name="accepting_medicaid_patients", EmitDefaultValue=false)]
        public bool? AcceptingMedicaidPatients { get; set; }
    
        /// <summary>
        /// Is this provider accepting new Medicare patients?
        /// </summary>
        /// <value>Is this provider accepting new Medicare patients?</value>
        [DataMember(Name="accepting_medicare_patients", EmitDefaultValue=false)]
        public bool? AcceptingMedicarePatients { get; set; }
    
        /// <summary>
        /// Is this provider accepting new patients with private insurance?
        /// </summary>
        /// <value>Is this provider accepting new patients with private insurance?</value>
        [DataMember(Name="accepting_private_patients", EmitDefaultValue=false)]
        public bool? AcceptingPrivatePatients { get; set; }
    
        /// <summary>
        /// Is this provider accepting new patients via referrals?
        /// </summary>
        /// <value>Is this provider accepting new patients via referrals?</value>
        [DataMember(Name="accepting_referral_patients", EmitDefaultValue=false)]
        public bool? AcceptingReferralPatients { get; set; }
    
        /// <summary>
        /// City name (e.g. Springfield).
        /// </summary>
        /// <value>City name (e.g. Springfield).</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Primary email address to contact the provider.
        /// </summary>
        /// <value>Primary email address to contact the provider.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Provider&#39;s gender (M or F)
        /// </summary>
        /// <value>Provider&#39;s gender (M or F)</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
    
        /// <summary>
        /// Given name for the provider.
        /// </summary>
        /// <value>Given name for the provider.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// National Provider Index (NPI) number
        /// </summary>
        /// <value>National Provider Index (NPI) number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Family name for the provider.
        /// </summary>
        /// <value>Family name for the provider.</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Middle name for the provider.
        /// </summary>
        /// <value>Middle name for the provider.</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Personal contact phone for the provider.
        /// </summary>
        /// <value>Personal contact phone for the provider.</value>
        [DataMember(Name="personal_phone", EmitDefaultValue=false)]
        public string PersonalPhone { get; set; }
    
        /// <summary>
        /// Office phone for the provider
        /// </summary>
        /// <value>Office phone for the provider</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White)
        /// </summary>
        /// <value>Preferred name for display (e.g. Dr. Francis White may prefer Dr. Frank White)</value>
        [DataMember(Name="presentation_name", EmitDefaultValue=false)]
        public string PresentationName { get; set; }
    
        /// <summary>
        /// Name of the primary Specialty
        /// </summary>
        /// <value>Name of the primary Specialty</value>
        [DataMember(Name="specialty", EmitDefaultValue=false)]
        public string Specialty { get; set; }
    
        /// <summary>
        /// State code for the provider&#39;s address (e.g. NY).
        /// </summary>
        /// <value>State code for the provider&#39;s address (e.g. NY).</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Foreign key to States
        /// </summary>
        /// <value>Foreign key to States</value>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public int? StateId { get; set; }
    
        /// <summary>
        /// First line of the provider&#39;s street address.
        /// </summary>
        /// <value>First line of the provider&#39;s street address.</value>
        [DataMember(Name="street_line_1", EmitDefaultValue=false)]
        public string StreetLine1 { get; set; }
    
        /// <summary>
        /// Second line of the provider&#39;s street address.
        /// </summary>
        /// <value>Second line of the provider&#39;s street address.</value>
        [DataMember(Name="street_line_2", EmitDefaultValue=false)]
        public string StreetLine2 { get; set; }
    
        /// <summary>
        /// Suffix for the provider&#39;s name (e.g. Jr)
        /// </summary>
        /// <value>Suffix for the provider&#39;s name (e.g. Jr)</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }
    
        /// <summary>
        /// Professional title for the provider (e.g. Dr).
        /// </summary>
        /// <value>Professional title for the provider (e.g. Dr).</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Type of NPI number (individual provider vs organization).
        /// </summary>
        /// <value>Type of NPI number (individual provider vs organization).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Postal code for the provider&#39;s address (e.g. 11215)
        /// </summary>
        /// <value>Postal code for the provider&#39;s address (e.g. 11215)</value>
        [DataMember(Name="zip_code", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Provider {\n");
            sb.Append("  AcceptingChangeOfPayorPatients: ").Append(AcceptingChangeOfPayorPatients).Append("\n");
            sb.Append("  AcceptingMedicaidPatients: ").Append(AcceptingMedicaidPatients).Append("\n");
            sb.Append("  AcceptingMedicarePatients: ").Append(AcceptingMedicarePatients).Append("\n");
            sb.Append("  AcceptingPrivatePatients: ").Append(AcceptingPrivatePatients).Append("\n");
            sb.Append("  AcceptingReferralPatients: ").Append(AcceptingReferralPatients).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  PersonalPhone: ").Append(PersonalPhone).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PresentationName: ").Append(PresentationName).Append("\n");
            sb.Append("  Specialty: ").Append(Specialty).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  StreetLine1: ").Append(StreetLine1).Append("\n");
            sb.Append("  StreetLine2: ").Append(StreetLine2).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Provider);
        }

        /// <summary>
        /// Returns true if Provider instances are equal
        /// </summary>
        /// <param name="other">Instance of Provider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Provider other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptingChangeOfPayorPatients == other.AcceptingChangeOfPayorPatients ||
                    this.AcceptingChangeOfPayorPatients != null &&
                    this.AcceptingChangeOfPayorPatients.Equals(other.AcceptingChangeOfPayorPatients)
                ) && 
                (
                    this.AcceptingMedicaidPatients == other.AcceptingMedicaidPatients ||
                    this.AcceptingMedicaidPatients != null &&
                    this.AcceptingMedicaidPatients.Equals(other.AcceptingMedicaidPatients)
                ) && 
                (
                    this.AcceptingMedicarePatients == other.AcceptingMedicarePatients ||
                    this.AcceptingMedicarePatients != null &&
                    this.AcceptingMedicarePatients.Equals(other.AcceptingMedicarePatients)
                ) && 
                (
                    this.AcceptingPrivatePatients == other.AcceptingPrivatePatients ||
                    this.AcceptingPrivatePatients != null &&
                    this.AcceptingPrivatePatients.Equals(other.AcceptingPrivatePatients)
                ) && 
                (
                    this.AcceptingReferralPatients == other.AcceptingReferralPatients ||
                    this.AcceptingReferralPatients != null &&
                    this.AcceptingReferralPatients.Equals(other.AcceptingReferralPatients)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.PersonalPhone == other.PersonalPhone ||
                    this.PersonalPhone != null &&
                    this.PersonalPhone.Equals(other.PersonalPhone)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PresentationName == other.PresentationName ||
                    this.PresentationName != null &&
                    this.PresentationName.Equals(other.PresentationName)
                ) && 
                (
                    this.Specialty == other.Specialty ||
                    this.Specialty != null &&
                    this.Specialty.Equals(other.Specialty)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.StateId == other.StateId ||
                    this.StateId != null &&
                    this.StateId.Equals(other.StateId)
                ) && 
                (
                    this.StreetLine1 == other.StreetLine1 ||
                    this.StreetLine1 != null &&
                    this.StreetLine1.Equals(other.StreetLine1)
                ) && 
                (
                    this.StreetLine2 == other.StreetLine2 ||
                    this.StreetLine2 != null &&
                    this.StreetLine2.Equals(other.StreetLine2)
                ) && 
                (
                    this.Suffix == other.Suffix ||
                    this.Suffix != null &&
                    this.Suffix.Equals(other.Suffix)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AcceptingChangeOfPayorPatients != null)
                    hash = hash * 59 + this.AcceptingChangeOfPayorPatients.GetHashCode();
                if (this.AcceptingMedicaidPatients != null)
                    hash = hash * 59 + this.AcceptingMedicaidPatients.GetHashCode();
                if (this.AcceptingMedicarePatients != null)
                    hash = hash * 59 + this.AcceptingMedicarePatients.GetHashCode();
                if (this.AcceptingPrivatePatients != null)
                    hash = hash * 59 + this.AcceptingPrivatePatients.GetHashCode();
                if (this.AcceptingReferralPatients != null)
                    hash = hash * 59 + this.AcceptingReferralPatients.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.PersonalPhone != null)
                    hash = hash * 59 + this.PersonalPhone.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.PresentationName != null)
                    hash = hash * 59 + this.PresentationName.GetHashCode();
                if (this.Specialty != null)
                    hash = hash * 59 + this.Specialty.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                if (this.StreetLine1 != null)
                    hash = hash * 59 + this.StreetLine1.GetHashCode();
                if (this.StreetLine2 != null)
                    hash = hash * 59 + this.StreetLine2.GetHashCode();
                if (this.Suffix != null)
                    hash = hash * 59 + this.Suffix.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                return hash;
            }
        }

    }
}
