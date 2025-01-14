/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// Information about a fulfillment order preview, including delivery and fee information based on shipping method.
    /// </summary>
    [DataContract]
    public partial class FulfillmentPreview : IEquatable<FulfillmentPreview>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShippingSpeedCategory
        /// </summary>
        [DataMember(Name = "ShippingSpeedCategory", EmitDefaultValue = false)]
        public ShippingSpeedCategory ShippingSpeedCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentPreview" /> class.
        /// </summary>
        /// <param name="ShippingSpeedCategory">ShippingSpeedCategory (required).</param>
        /// <param name="ScheduledDeliveryInfo">ScheduledDeliveryInfo.</param>
        /// <param name="IsFulfillable">When true, this fulfillment order preview is fulfillable. (required).</param>
        /// <param name="IsCODCapable">When true, this fulfillment order preview is for COD (Cash On Delivery). (required).</param>
        /// <param name="EstimatedShippingWeight">Estimated shipping weight for this fulfillment order preview..</param>
        /// <param name="EstimatedFees">The estimated fulfillment fees for this fulfillment order preview, if applicable..</param>
        /// <param name="FulfillmentPreviewShipments">FulfillmentPreviewShipments.</param>
        /// <param name="UnfulfillablePreviewItems">UnfulfillablePreviewItems.</param>
        /// <param name="OrderUnfulfillableReasons">Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  DeliverySLAUnavailable  InvalidDestinationAddress.</param>
        /// <param name="MarketplaceId">The marketplace the fulfillment order is placed against. (required).</param>
        public FulfillmentPreview(ShippingSpeedCategory ShippingSpeedCategory = default(ShippingSpeedCategory), ScheduledDeliveryInfo ScheduledDeliveryInfo = default(ScheduledDeliveryInfo), bool? IsFulfillable = default(bool?), bool? IsCODCapable = default(bool?), Weight EstimatedShippingWeight = default(Weight), FeeList EstimatedFees = default(FeeList), FulfillmentPreviewShipmentList FulfillmentPreviewShipments = default(FulfillmentPreviewShipmentList), UnfulfillablePreviewItemList UnfulfillablePreviewItems = default(UnfulfillablePreviewItemList), StringList OrderUnfulfillableReasons = default(StringList), string MarketplaceId = default(string))
        {
            // to ensure "ShippingSpeedCategory" is required (not null)
            if (ShippingSpeedCategory == null)
            {
                throw new InvalidDataException("ShippingSpeedCategory is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.ShippingSpeedCategory = ShippingSpeedCategory;
            }
            // to ensure "IsFulfillable" is required (not null)
            if (IsFulfillable == null)
            {
                throw new InvalidDataException("IsFulfillable is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.IsFulfillable = IsFulfillable;
            }
            // to ensure "IsCODCapable" is required (not null)
            if (IsCODCapable == null)
            {
                throw new InvalidDataException("IsCODCapable is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.IsCODCapable = IsCODCapable;
            }
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
            {
                throw new InvalidDataException("MarketplaceId is a required property for FulfillmentPreview and cannot be null");
            }
            else
            {
                this.MarketplaceId = MarketplaceId;
            }
            this.ScheduledDeliveryInfo = ScheduledDeliveryInfo;
            this.EstimatedShippingWeight = EstimatedShippingWeight;
            this.EstimatedFees = EstimatedFees;
            this.FulfillmentPreviewShipments = FulfillmentPreviewShipments;
            this.UnfulfillablePreviewItems = UnfulfillablePreviewItems;
            this.OrderUnfulfillableReasons = OrderUnfulfillableReasons;
        }


        /// <summary>
        /// Gets or Sets ScheduledDeliveryInfo
        /// </summary>
        [DataMember(Name = "ScheduledDeliveryInfo", EmitDefaultValue = false)]
        public ScheduledDeliveryInfo ScheduledDeliveryInfo { get; set; }

        /// <summary>
        /// When true, this fulfillment order preview is fulfillable.
        /// </summary>
        /// <value>When true, this fulfillment order preview is fulfillable.</value>
        [DataMember(Name = "IsFulfillable", EmitDefaultValue = false)]
        public bool? IsFulfillable { get; set; }

        /// <summary>
        /// When true, this fulfillment order preview is for COD (Cash On Delivery).
        /// </summary>
        /// <value>When true, this fulfillment order preview is for COD (Cash On Delivery).</value>
        [DataMember(Name = "IsCODCapable", EmitDefaultValue = false)]
        public bool? IsCODCapable { get; set; }

        /// <summary>
        /// Estimated shipping weight for this fulfillment order preview.
        /// </summary>
        /// <value>Estimated shipping weight for this fulfillment order preview.</value>
        [DataMember(Name = "EstimatedShippingWeight", EmitDefaultValue = false)]
        public Weight EstimatedShippingWeight { get; set; }

        /// <summary>
        /// The estimated fulfillment fees for this fulfillment order preview, if applicable.
        /// </summary>
        /// <value>The estimated fulfillment fees for this fulfillment order preview, if applicable.</value>
        [DataMember(Name = "EstimatedFees", EmitDefaultValue = false)]
        public FeeList EstimatedFees { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPreviewShipments
        /// </summary>
        [DataMember(Name = "FulfillmentPreviewShipments", EmitDefaultValue = false)]
        public FulfillmentPreviewShipmentList FulfillmentPreviewShipments { get; set; }

        /// <summary>
        /// Gets or Sets UnfulfillablePreviewItems
        /// </summary>
        [DataMember(Name = "UnfulfillablePreviewItems", EmitDefaultValue = false)]
        public UnfulfillablePreviewItemList UnfulfillablePreviewItems { get; set; }

        /// <summary>
        /// Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  DeliverySLAUnavailable  InvalidDestinationAddress
        /// </summary>
        /// <value>Error codes associated with the fulfillment order preview that indicate why the order is not fulfillable.  Error code examples:  DeliverySLAUnavailable  InvalidDestinationAddress</value>
        [DataMember(Name = "OrderUnfulfillableReasons", EmitDefaultValue = false)]
        public StringList OrderUnfulfillableReasons { get; set; }

        /// <summary>
        /// The marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The marketplace the fulfillment order is placed against.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentPreview {\n");
            sb.Append("  ShippingSpeedCategory: ").Append(ShippingSpeedCategory).Append("\n");
            sb.Append("  ScheduledDeliveryInfo: ").Append(ScheduledDeliveryInfo).Append("\n");
            sb.Append("  IsFulfillable: ").Append(IsFulfillable).Append("\n");
            sb.Append("  IsCODCapable: ").Append(IsCODCapable).Append("\n");
            sb.Append("  EstimatedShippingWeight: ").Append(EstimatedShippingWeight).Append("\n");
            sb.Append("  EstimatedFees: ").Append(EstimatedFees).Append("\n");
            sb.Append("  FulfillmentPreviewShipments: ").Append(FulfillmentPreviewShipments).Append("\n");
            sb.Append("  UnfulfillablePreviewItems: ").Append(UnfulfillablePreviewItems).Append("\n");
            sb.Append("  OrderUnfulfillableReasons: ").Append(OrderUnfulfillableReasons).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
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
            return this.Equals(input as FulfillmentPreview);
        }

        /// <summary>
        /// Returns true if FulfillmentPreview instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentPreview input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShippingSpeedCategory == input.ShippingSpeedCategory ||
                    (this.ShippingSpeedCategory != null &&
                    this.ShippingSpeedCategory.Equals(input.ShippingSpeedCategory))
                ) &&
                (
                    this.ScheduledDeliveryInfo == input.ScheduledDeliveryInfo ||
                    (this.ScheduledDeliveryInfo != null &&
                    this.ScheduledDeliveryInfo.Equals(input.ScheduledDeliveryInfo))
                ) &&
                (
                    this.IsFulfillable == input.IsFulfillable ||
                    (this.IsFulfillable != null &&
                    this.IsFulfillable.Equals(input.IsFulfillable))
                ) &&
                (
                    this.IsCODCapable == input.IsCODCapable ||
                    (this.IsCODCapable != null &&
                    this.IsCODCapable.Equals(input.IsCODCapable))
                ) &&
                (
                    this.EstimatedShippingWeight == input.EstimatedShippingWeight ||
                    (this.EstimatedShippingWeight != null &&
                    this.EstimatedShippingWeight.Equals(input.EstimatedShippingWeight))
                ) &&
                (
                    this.EstimatedFees == input.EstimatedFees ||
                    (this.EstimatedFees != null &&
                    this.EstimatedFees.Equals(input.EstimatedFees))
                ) &&
                (
                    this.FulfillmentPreviewShipments == input.FulfillmentPreviewShipments ||
                    (this.FulfillmentPreviewShipments != null &&
                    this.FulfillmentPreviewShipments.Equals(input.FulfillmentPreviewShipments))
                ) &&
                (
                    this.UnfulfillablePreviewItems == input.UnfulfillablePreviewItems ||
                    (this.UnfulfillablePreviewItems != null &&
                    this.UnfulfillablePreviewItems.Equals(input.UnfulfillablePreviewItems))
                ) &&
                (
                    this.OrderUnfulfillableReasons == input.OrderUnfulfillableReasons ||
                    (this.OrderUnfulfillableReasons != null &&
                    this.OrderUnfulfillableReasons.Equals(input.OrderUnfulfillableReasons))
                ) &&
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
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
                if (this.ShippingSpeedCategory != null)
                    hashCode = hashCode * 59 + this.ShippingSpeedCategory.GetHashCode();
                if (this.ScheduledDeliveryInfo != null)
                    hashCode = hashCode * 59 + this.ScheduledDeliveryInfo.GetHashCode();
                if (this.IsFulfillable != null)
                    hashCode = hashCode * 59 + this.IsFulfillable.GetHashCode();
                if (this.IsCODCapable != null)
                    hashCode = hashCode * 59 + this.IsCODCapable.GetHashCode();
                if (this.EstimatedShippingWeight != null)
                    hashCode = hashCode * 59 + this.EstimatedShippingWeight.GetHashCode();
                if (this.EstimatedFees != null)
                    hashCode = hashCode * 59 + this.EstimatedFees.GetHashCode();
                if (this.FulfillmentPreviewShipments != null)
                    hashCode = hashCode * 59 + this.FulfillmentPreviewShipments.GetHashCode();
                if (this.UnfulfillablePreviewItems != null)
                    hashCode = hashCode * 59 + this.UnfulfillablePreviewItems.GetHashCode();
                if (this.OrderUnfulfillableReasons != null)
                    hashCode = hashCode * 59 + this.OrderUnfulfillableReasons.GetHashCode();
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
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
