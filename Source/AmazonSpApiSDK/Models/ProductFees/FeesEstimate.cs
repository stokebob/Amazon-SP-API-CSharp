/* 
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.ProductFees
{
    /// <summary>
    /// The total estimated fees for an item and a list of details.
    /// </summary>
    [DataContract]
    public partial class FeesEstimate : IEquatable<FeesEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeesEstimate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimate" /> class.
        /// </summary>
        /// <param name="TimeOfFeesEstimation">The time for which the fees were estimated. This defaults to the time the request is made. (required).</param>
        /// <param name="TotalFeesEstimate">Total estimated fees for a given item, price, and fulfillment channel..</param>
        /// <param name="FeeDetailList">FeeDetailList.</param>
        public FeesEstimate(DateTime? TimeOfFeesEstimation = default(DateTime?), MoneyType TotalFeesEstimate = default(MoneyType), FeeDetailList FeeDetailList = default(FeeDetailList))
        {
            // to ensure "TimeOfFeesEstimation" is required (not null)
            if (TimeOfFeesEstimation == null)
            {
                throw new InvalidDataException("TimeOfFeesEstimation is a required property for FeesEstimate and cannot be null");
            }
            else
            {
                this.TimeOfFeesEstimation = TimeOfFeesEstimation;
            }
            this.TotalFeesEstimate = TotalFeesEstimate;
            this.FeeDetailList = FeeDetailList;
        }

        /// <summary>
        /// The time for which the fees were estimated. This defaults to the time the request is made.
        /// </summary>
        /// <value>The time for which the fees were estimated. This defaults to the time the request is made.</value>
        [DataMember(Name = "TimeOfFeesEstimation", EmitDefaultValue = false)]
        public DateTime? TimeOfFeesEstimation { get; set; }

        /// <summary>
        /// Total estimated fees for a given item, price, and fulfillment channel.
        /// </summary>
        /// <value>Total estimated fees for a given item, price, and fulfillment channel.</value>
        [DataMember(Name = "TotalFeesEstimate", EmitDefaultValue = false)]
        public MoneyType TotalFeesEstimate { get; set; }

        /// <summary>
        /// Gets or Sets FeeDetailList
        /// </summary>
        [DataMember(Name = "FeeDetailList", EmitDefaultValue = false)]
        public FeeDetailList FeeDetailList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeesEstimate {\n");
            sb.Append("  TimeOfFeesEstimation: ").Append(TimeOfFeesEstimation).Append("\n");
            sb.Append("  TotalFeesEstimate: ").Append(TotalFeesEstimate).Append("\n");
            sb.Append("  FeeDetailList: ").Append(FeeDetailList).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FeesEstimate);
        }

        /// <summary>
        /// Returns true if FeesEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of FeesEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeesEstimate input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TimeOfFeesEstimation == input.TimeOfFeesEstimation ||
                    (this.TimeOfFeesEstimation != null &&
                    this.TimeOfFeesEstimation.Equals(input.TimeOfFeesEstimation))
                ) &&
                (
                    this.TotalFeesEstimate == input.TotalFeesEstimate ||
                    (this.TotalFeesEstimate != null &&
                    this.TotalFeesEstimate.Equals(input.TotalFeesEstimate))
                ) &&
                (
                    this.FeeDetailList == input.FeeDetailList ||
                    (this.FeeDetailList != null &&
                    this.FeeDetailList.Equals(input.FeeDetailList))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TimeOfFeesEstimation != null)
                    hashCode = hashCode * 59 + this.TimeOfFeesEstimation.GetHashCode();
                if (this.TotalFeesEstimate != null)
                    hashCode = hashCode * 59 + this.TotalFeesEstimate.GetHashCode();
                if (this.FeeDetailList != null)
                    hashCode = hashCode * 59 + this.FeeDetailList.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}