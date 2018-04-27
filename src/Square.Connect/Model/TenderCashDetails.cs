/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents the details of a tender with &#x60;type&#x60; &#x60;CASH&#x60;.
    /// </summary>
    [DataContract]
    public partial class TenderCashDetails :  IEquatable<TenderCashDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderCashDetails" /> class.
        /// </summary>
        /// <param name="BuyerTenderedMoney">The total amount of cash provided by the buyer, before change is given..</param>
        /// <param name="ChangeBackMoney">The amount of change returned to the buyer..</param>
        public TenderCashDetails(Money BuyerTenderedMoney = default(Money), Money ChangeBackMoney = default(Money))
        {
            this.BuyerTenderedMoney = BuyerTenderedMoney;
            this.ChangeBackMoney = ChangeBackMoney;
        }

        [Key]
        public Guid FakeId { get { return Guid.NewGuid(); } set { Guid g = value; } }
        /// <summary>
        /// The total amount of cash provided by the buyer, before change is given.
        /// </summary>
        /// <value>The total amount of cash provided by the buyer, before change is given.</value>
        /// 
        [DataMember(Name="buyer_tendered_money", EmitDefaultValue=false)]
        public Money BuyerTenderedMoney { get; set; }
        /// <summary>
        /// The amount of change returned to the buyer.
        /// </summary>
        /// <value>The amount of change returned to the buyer.</value>
        [DataMember(Name="change_back_money", EmitDefaultValue=false)]
        public Money ChangeBackMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenderCashDetails {\n");
            sb.Append("  BuyerTenderedMoney: ").Append(BuyerTenderedMoney).Append("\n");
            sb.Append("  ChangeBackMoney: ").Append(ChangeBackMoney).Append("\n");
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
            return this.Equals(obj as TenderCashDetails);
        }

        /// <summary>
        /// Returns true if TenderCashDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of TenderCashDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderCashDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuyerTenderedMoney == other.BuyerTenderedMoney ||
                    this.BuyerTenderedMoney != null &&
                    this.BuyerTenderedMoney.Equals(other.BuyerTenderedMoney)
                ) && 
                (
                    this.ChangeBackMoney == other.ChangeBackMoney ||
                    this.ChangeBackMoney != null &&
                    this.ChangeBackMoney.Equals(other.ChangeBackMoney)
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
                if (this.BuyerTenderedMoney != null)
                    hash = hash * 59 + this.BuyerTenderedMoney.GetHashCode();
                if (this.ChangeBackMoney != null)
                    hash = hash * 59 + this.ChangeBackMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
