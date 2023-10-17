/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Zuora.Client.OpenAPIDateConverter;

namespace Zuora.Model
{
    /// <summary>
    /// FulfillmentCreateRequest
    /// </summary>
    [DataContract]
    public partial class FulfillmentCreateRequest :  IEquatable<FulfillmentCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of fulfillment.
        /// </summary>
        /// <value>The type of fulfillment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Delivery for value: delivery
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 1,

            /// <summary>
            /// Enum Return for value: return
            /// </summary>
            [EnumMember(Value = "return")]
            Return = 2

        }

        /// <summary>
        /// The type of fulfillment.
        /// </summary>
        /// <value>The type of fulfillment.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// The status of the invoice.
        /// </summary>
        /// <value>The status of the invoice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 1,

            /// <summary>
            /// Enum Booked for value: booked
            /// </summary>
            [EnumMember(Value = "booked")]
            Booked = 2,

            /// <summary>
            /// Enum Senttobilling for value: sent_to_billing
            /// </summary>
            [EnumMember(Value = "sent_to_billing")]
            Senttobilling = 3,

            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 4,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 5

        }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        /// <value>The status of the invoice.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCreateRequest" /> class.
        /// </summary>
        /// <param name="processingOptions">processingOptions.</param>
        /// <param name="orderLineItemId">The unique identifier of the associated order line item. (required).</param>
        /// <param name="carrier">The name of the shipping carrier for this fulfillment..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="externalId">An external identifier for the fulfillment.</param>
        /// <param name="fulfillmentDate">The date of the fulfillment. (required).</param>
        /// <param name="location">The fulfillment location of the fulfillment..</param>
        /// <param name="fulfillmentSystem">The fulfillment system for the fulfillment..</param>
        /// <param name="type">The type of fulfillment..</param>
        /// <param name="quantity">The number of units of this item. (required).</param>
        /// <param name="state">The status of the invoice..</param>
        /// <param name="trackingNumber">The tracking number of the fulfillment..</param>
        /// <param name="items">Information of all fulfillment items..</param>
        public FulfillmentCreateRequest(FulfillmentProcessingOption processingOptions = default(FulfillmentProcessingOption), string orderLineItemId = default(string), string carrier = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string description = default(string), Revenue revenue = default(Revenue), string externalId = default(string), DateTime fulfillmentDate = default(DateTime), string location = default(string), string fulfillmentSystem = default(string), TypeEnum? type = default(TypeEnum?), decimal quantity = default(decimal), StateEnum? state = default(StateEnum?), string trackingNumber = default(string), List<FulfillmentItemCreateRequestForFulfillmentPost> items = default(List<FulfillmentItemCreateRequestForFulfillmentPost>))
        {
            // to ensure "orderLineItemId" is required (not null)
            if (orderLineItemId == null)
            {
                throw new InvalidDataException("orderLineItemId is a required property for FulfillmentCreateRequest and cannot be null");
            }
            else
            {
                this.order_line_item_id = orderLineItemId;
            }

            this.revenue = revenue;
            // to ensure "fulfillmentDate" is required (not null)
            if (fulfillmentDate == null)
            {
                throw new InvalidDataException("fulfillmentDate is a required property for FulfillmentCreateRequest and cannot be null");
            }
            else
            {
                this.fulfillment_date = fulfillmentDate;
            }

            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for FulfillmentCreateRequest and cannot be null");
            }
            else
            {
                this.quantity = quantity;
            }

            this.processing_options = processingOptions;
            this.carrier = carrier;
            this.custom_fields = customFields;
            this.description = description;
            this.revenue = revenue;
            this.external_id = externalId;
            this.location = location;
            this.fulfillment_system = fulfillmentSystem;
            this.type = type;
            this.state = state;
            this.tracking_number = trackingNumber;
            this.items = items;
        }

        /// <summary>
        /// Gets or Sets processing_options
        /// </summary>
        [DataMember(Name="processing_options", EmitDefaultValue=false)]
        public FulfillmentProcessingOption processing_options { get; set; }

        /// <summary>
        /// The unique identifier of the associated order line item.
        /// </summary>
        /// <value>The unique identifier of the associated order line item.</value>
        [DataMember(Name="order_line_item_id", EmitDefaultValue=true)]
        public string order_line_item_id { get; set; }

        /// <summary>
        /// The name of the shipping carrier for this fulfillment.
        /// </summary>
        /// <value>The name of the shipping carrier for this fulfillment.</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string carrier { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Gets or Sets revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=true)]
        public Revenue revenue { get; set; }

        /// <summary>
        /// An external identifier for the fulfillment
        /// </summary>
        /// <value>An external identifier for the fulfillment</value>
        [DataMember(Name="external_id", EmitDefaultValue=false)]
        public string external_id { get; set; }

        /// <summary>
        /// The date of the fulfillment.
        /// </summary>
        /// <value>The date of the fulfillment.</value>
        [DataMember(Name="fulfillment_date", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime fulfillment_date { get; set; }

        /// <summary>
        /// The fulfillment location of the fulfillment.
        /// </summary>
        /// <value>The fulfillment location of the fulfillment.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string location { get; set; }

        /// <summary>
        /// The fulfillment system for the fulfillment.
        /// </summary>
        /// <value>The fulfillment system for the fulfillment.</value>
        [DataMember(Name="fulfillment_system", EmitDefaultValue=false)]
        public string fulfillment_system { get; set; }


        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=true)]
        public decimal quantity { get; set; }


        /// <summary>
        /// The tracking number of the fulfillment.
        /// </summary>
        /// <value>The tracking number of the fulfillment.</value>
        [DataMember(Name="tracking_number", EmitDefaultValue=false)]
        public string tracking_number { get; set; }

        /// <summary>
        /// Information of all fulfillment items.
        /// </summary>
        /// <value>Information of all fulfillment items.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<FulfillmentItemCreateRequestForFulfillmentPost> items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentCreateRequest {\n");
            sb.Append("  processing_options: ").Append(processing_options).Append("\n");
            sb.Append("  order_line_item_id: ").Append(order_line_item_id).Append("\n");
            sb.Append("  carrier: ").Append(carrier).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  revenue: ").Append(revenue).Append("\n");
            sb.Append("  external_id: ").Append(external_id).Append("\n");
            sb.Append("  fulfillment_date: ").Append(fulfillment_date).Append("\n");
            sb.Append("  location: ").Append(location).Append("\n");
            sb.Append("  fulfillment_system: ").Append(fulfillment_system).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  tracking_number: ").Append(tracking_number).Append("\n");
            sb.Append("  items: ").Append(items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FulfillmentCreateRequest);
        }

        /// <summary>
        /// Returns true if FulfillmentCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.processing_options == input.processing_options ||
                    (this.processing_options != null &&
                    this.processing_options.Equals(input.processing_options))
                ) && 
                (
                    this.order_line_item_id == input.order_line_item_id ||
                    (this.order_line_item_id != null &&
                    this.order_line_item_id.Equals(input.order_line_item_id))
                ) && 
                (
                    this.carrier == input.carrier ||
                    (this.carrier != null &&
                    this.carrier.Equals(input.carrier))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.revenue == input.revenue ||
                    (this.revenue != null &&
                    this.revenue.Equals(input.revenue))
                ) && 
                (
                    this.external_id == input.external_id ||
                    (this.external_id != null &&
                    this.external_id.Equals(input.external_id))
                ) && 
                (
                    this.fulfillment_date == input.fulfillment_date ||
                    (this.fulfillment_date != null &&
                    this.fulfillment_date.Equals(input.fulfillment_date))
                ) && 
                (
                    this.location == input.location ||
                    (this.location != null &&
                    this.location.Equals(input.location))
                ) && 
                (
                    this.fulfillment_system == input.fulfillment_system ||
                    (this.fulfillment_system != null &&
                    this.fulfillment_system.Equals(input.fulfillment_system))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.tracking_number == input.tracking_number ||
                    (this.tracking_number != null &&
                    this.tracking_number.Equals(input.tracking_number))
                ) && 
                (
                    this.items == input.items ||
                    this.items != null &&
                    input.items != null &&
                    this.items.SequenceEqual(input.items)
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
                if (this.processing_options != null)
                    hashCode = hashCode * 59 + this.processing_options.GetHashCode();
                if (this.order_line_item_id != null)
                    hashCode = hashCode * 59 + this.order_line_item_id.GetHashCode();
                if (this.carrier != null)
                    hashCode = hashCode * 59 + this.carrier.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.revenue != null)
                    hashCode = hashCode * 59 + this.revenue.GetHashCode();
                if (this.external_id != null)
                    hashCode = hashCode * 59 + this.external_id.GetHashCode();
                if (this.fulfillment_date != null)
                    hashCode = hashCode * 59 + this.fulfillment_date.GetHashCode();
                if (this.location != null)
                    hashCode = hashCode * 59 + this.location.GetHashCode();
                if (this.fulfillment_system != null)
                    hashCode = hashCode * 59 + this.fulfillment_system.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.tracking_number != null)
                    hashCode = hashCode * 59 + this.tracking_number.GetHashCode();
                if (this.items != null)
                    hashCode = hashCode * 59 + this.items.GetHashCode();
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
