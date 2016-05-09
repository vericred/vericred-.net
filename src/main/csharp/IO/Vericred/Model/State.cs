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
    public partial class State :  IEquatable<State>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="State" /> class.
        /// Initializes a new instance of the <see cref="State" />class.
        /// </summary>
        /// <param name="Id">Primary Key of State.</param>
        /// <param name="Name">Name of state.</param>
        /// <param name="Code">2 letter code for state.</param>
        /// <param name="FipsNumber">National FIPs number.</param>
        /// <param name="LastDateForIndividual">Last date this state is live for individuals.</param>
        /// <param name="LastDateForShop">Last date this state is live for shop.</param>
        /// <param name="LiveForBusiness">Is this State available for businesses.</param>
        /// <param name="LiveForConsumers">Is this State available for individuals.</param>

        public State(int? Id = null, string Name = null, string Code = null, string FipsNumber = null, DateTime? LastDateForIndividual = null, DateTime? LastDateForShop = null, bool? LiveForBusiness = null, bool? LiveForConsumers = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Code = Code;
            this.FipsNumber = FipsNumber;
            this.LastDateForIndividual = LastDateForIndividual;
            this.LastDateForShop = LastDateForShop;
            this.LiveForBusiness = LiveForBusiness;
            this.LiveForConsumers = LiveForConsumers;
            
        }

    
        /// <summary>
        /// Primary Key of State
        /// </summary>
        /// <value>Primary Key of State</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Name of state
        /// </summary>
        /// <value>Name of state</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// 2 letter code for state
        /// </summary>
        /// <value>2 letter code for state</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
    
        /// <summary>
        /// National FIPs number
        /// </summary>
        /// <value>National FIPs number</value>
        [DataMember(Name="fips_number", EmitDefaultValue=false)]
        public string FipsNumber { get; set; }
    
        /// <summary>
        /// Last date this state is live for individuals
        /// </summary>
        /// <value>Last date this state is live for individuals</value>
        [DataMember(Name="last_date_for_individual", EmitDefaultValue=false)]
        public DateTime? LastDateForIndividual { get; set; }
    
        /// <summary>
        /// Last date this state is live for shop
        /// </summary>
        /// <value>Last date this state is live for shop</value>
        [DataMember(Name="last_date_for_shop", EmitDefaultValue=false)]
        public DateTime? LastDateForShop { get; set; }
    
        /// <summary>
        /// Is this State available for businesses
        /// </summary>
        /// <value>Is this State available for businesses</value>
        [DataMember(Name="live_for_business", EmitDefaultValue=false)]
        public bool? LiveForBusiness { get; set; }
    
        /// <summary>
        /// Is this State available for individuals
        /// </summary>
        /// <value>Is this State available for individuals</value>
        [DataMember(Name="live_for_consumers", EmitDefaultValue=false)]
        public bool? LiveForConsumers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class State {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FipsNumber: ").Append(FipsNumber).Append("\n");
            sb.Append("  LastDateForIndividual: ").Append(LastDateForIndividual).Append("\n");
            sb.Append("  LastDateForShop: ").Append(LastDateForShop).Append("\n");
            sb.Append("  LiveForBusiness: ").Append(LiveForBusiness).Append("\n");
            sb.Append("  LiveForConsumers: ").Append(LiveForConsumers).Append("\n");
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
            return this.Equals(obj as State);
        }

        /// <summary>
        /// Returns true if State instances are equal
        /// </summary>
        /// <param name="other">Instance of State to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(State other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.FipsNumber == other.FipsNumber ||
                    this.FipsNumber != null &&
                    this.FipsNumber.Equals(other.FipsNumber)
                ) && 
                (
                    this.LastDateForIndividual == other.LastDateForIndividual ||
                    this.LastDateForIndividual != null &&
                    this.LastDateForIndividual.Equals(other.LastDateForIndividual)
                ) && 
                (
                    this.LastDateForShop == other.LastDateForShop ||
                    this.LastDateForShop != null &&
                    this.LastDateForShop.Equals(other.LastDateForShop)
                ) && 
                (
                    this.LiveForBusiness == other.LiveForBusiness ||
                    this.LiveForBusiness != null &&
                    this.LiveForBusiness.Equals(other.LiveForBusiness)
                ) && 
                (
                    this.LiveForConsumers == other.LiveForConsumers ||
                    this.LiveForConsumers != null &&
                    this.LiveForConsumers.Equals(other.LiveForConsumers)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.FipsNumber != null)
                    hash = hash * 59 + this.FipsNumber.GetHashCode();
                if (this.LastDateForIndividual != null)
                    hash = hash * 59 + this.LastDateForIndividual.GetHashCode();
                if (this.LastDateForShop != null)
                    hash = hash * 59 + this.LastDateForShop.GetHashCode();
                if (this.LiveForBusiness != null)
                    hash = hash * 59 + this.LiveForBusiness.GetHashCode();
                if (this.LiveForConsumers != null)
                    hash = hash * 59 + this.LiveForConsumers.GetHashCode();
                return hash;
            }
        }

    }
}
