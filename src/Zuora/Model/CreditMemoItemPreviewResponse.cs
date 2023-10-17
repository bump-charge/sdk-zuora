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
    /// CreditMemoItemPreviewResponse
    /// </summary>
    [DataContract]
    public partial class CreditMemoItemPreviewResponse :  IEquatable<CreditMemoItemPreviewResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines processing_type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessingTypeEnum
        {
            /// <summary>
            /// Enum Subscriptionitem for value: subscription_item
            /// </summary>
            [EnumMember(Value = "subscription_item")]
            Subscriptionitem = 1,

            /// <summary>
            /// Enum Discount for value: discount
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount = 2,

            /// <summary>
            /// Enum Prepayment for value: prepayment
            /// </summary>
            [EnumMember(Value = "prepayment")]
            Prepayment = 3,

            /// <summary>
            /// Enum Tax for value: tax
            /// </summary>
            [EnumMember(Value = "tax")]
            Tax = 4

        }

        /// <summary>
        /// Gets or Sets processing_type
        /// </summary>
        [DataMember(Name="processing_type", EmitDefaultValue=false)]
        public ProcessingTypeEnum? processing_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditMemoItemPreviewResponse" /> class.
        /// </summary>
        /// <param name="amount">The total amount of this credit memo item..</param>
        /// <param name="subtotal">The total amount of this credit memo item exclusive of tax..</param>
        /// <param name="appliedToItemId">Identifier of an invoice item that this credit memo item is applied to..</param>
        /// <param name="documentItemDate">The date when the credit memo item takes effect..</param>
        /// <param name="documentItemNumber">documentItemNumber.</param>
        /// <param name="chargeType">Type of the charge. It can be one of the following types: one-time, recurring, or usage..</param>
        /// <param name="description">An arbitrary string associated with the object. Often useful for displaying to users..</param>
        /// <param name="id">Unique identifier of the object.</param>
        /// <param name="processingType">processingType.</param>
        /// <param name="quantity">The number of units of this item..</param>
        /// <param name="subscriptionItemId">The identifier the subscription item associated with this credit memo item..</param>
        /// <param name="serviceStartDate">The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="serviceEndDate">The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="sku">The unique SKU (stock keeping unit) of the product associated with this item..</param>
        /// <param name="skuName">The name of the SKU associated with this item.</param>
        /// <param name="subscriptionId">The identifier of the subscription associated with the credit memo item..</param>
        /// <param name="subscriptionNumber">Human-readable identifier of the subscription. It can be user-supplied..</param>
        /// <param name="unitOfMeasure">Specifies the units used to measure usage..</param>
        public CreditMemoItemPreviewResponse(decimal amount = default(decimal), decimal subtotal = default(decimal), string appliedToItemId = default(string), DateTime documentItemDate = default(DateTime), string documentItemNumber = default(string), string chargeType = default(string), string description = default(string), string id = default(string), ProcessingTypeEnum? processingType = default(ProcessingTypeEnum?), decimal quantity = default(decimal), string subscriptionItemId = default(string), string serviceStartDate = default(string), string serviceEndDate = default(string), string sku = default(string), string skuName = default(string), string subscriptionId = default(string), string subscriptionNumber = default(string), string unitOfMeasure = default(string))
        {
            this.amount = amount;
            this.subtotal = subtotal;
            this.applied_to_item_id = appliedToItemId;
            this.document_item_date = documentItemDate;
            this.document_item_number = documentItemNumber;
            this.charge_type = chargeType;
            this.description = description;
            this.id = id;
            this.processing_type = processingType;
            this.quantity = quantity;
            this.subscription_item_id = subscriptionItemId;
            this.service_start_date = serviceStartDate;
            this.service_end_date = serviceEndDate;
            this.sku = sku;
            this.sku_name = skuName;
            this.subscription_id = subscriptionId;
            this.subscription_number = subscriptionNumber;
            this.unit_of_measure = unitOfMeasure;
        }

        /// <summary>
        /// The total amount of this credit memo item.
        /// </summary>
        /// <value>The total amount of this credit memo item.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal amount { get; set; }

        /// <summary>
        /// The total amount of this credit memo item exclusive of tax.
        /// </summary>
        /// <value>The total amount of this credit memo item exclusive of tax.</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public decimal subtotal { get; set; }

        /// <summary>
        /// Identifier of an invoice item that this credit memo item is applied to.
        /// </summary>
        /// <value>Identifier of an invoice item that this credit memo item is applied to.</value>
        [DataMember(Name="applied_to_item_id", EmitDefaultValue=false)]
        public string applied_to_item_id { get; set; }

        /// <summary>
        /// The date when the credit memo item takes effect.
        /// </summary>
        /// <value>The date when the credit memo item takes effect.</value>
        [DataMember(Name="document_item_date", EmitDefaultValue=false)]
        public DateTime document_item_date { get; set; }

        /// <summary>
        /// Gets or Sets document_item_number
        /// </summary>
        [DataMember(Name="document_item_number", EmitDefaultValue=false)]
        public string document_item_number { get; set; }

        /// <summary>
        /// Type of the charge. It can be one of the following types: one-time, recurring, or usage.
        /// </summary>
        /// <value>Type of the charge. It can be one of the following types: one-time, recurring, or usage.</value>
        [DataMember(Name="charge_type", EmitDefaultValue=false)]
        public string charge_type { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Unique identifier of the object
        /// </summary>
        /// <value>Unique identifier of the object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }


        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// The identifier the subscription item associated with this credit memo item.
        /// </summary>
        /// <value>The identifier the subscription item associated with this credit memo item.</value>
        [DataMember(Name="subscription_item_id", EmitDefaultValue=false)]
        public string subscription_item_id { get; set; }

        /// <summary>
        /// The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_start_date", EmitDefaultValue=false)]
        public string service_start_date { get; set; }

        /// <summary>
        /// The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this credit memo item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_end_date", EmitDefaultValue=false)]
        public string service_end_date { get; set; }

        /// <summary>
        /// The unique SKU (stock keeping unit) of the product associated with this item.
        /// </summary>
        /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string sku { get; set; }

        /// <summary>
        /// The name of the SKU associated with this item
        /// </summary>
        /// <value>The name of the SKU associated with this item</value>
        [DataMember(Name="sku_name", EmitDefaultValue=false)]
        public string sku_name { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the credit memo item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the credit memo item.</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public string subscription_id { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription. It can be user-supplied.</value>
        [DataMember(Name="subscription_number", EmitDefaultValue=false)]
        public string subscription_number { get; set; }

        /// <summary>
        /// Specifies the units used to measure usage.
        /// </summary>
        /// <value>Specifies the units used to measure usage.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditMemoItemPreviewResponse {\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  subtotal: ").Append(subtotal).Append("\n");
            sb.Append("  applied_to_item_id: ").Append(applied_to_item_id).Append("\n");
            sb.Append("  document_item_date: ").Append(document_item_date).Append("\n");
            sb.Append("  document_item_number: ").Append(document_item_number).Append("\n");
            sb.Append("  charge_type: ").Append(charge_type).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  processing_type: ").Append(processing_type).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  subscription_item_id: ").Append(subscription_item_id).Append("\n");
            sb.Append("  service_start_date: ").Append(service_start_date).Append("\n");
            sb.Append("  service_end_date: ").Append(service_end_date).Append("\n");
            sb.Append("  sku: ").Append(sku).Append("\n");
            sb.Append("  sku_name: ").Append(sku_name).Append("\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  subscription_number: ").Append(subscription_number).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
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
            return this.Equals(input as CreditMemoItemPreviewResponse);
        }

        /// <summary>
        /// Returns true if CreditMemoItemPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditMemoItemPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditMemoItemPreviewResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) && 
                (
                    this.subtotal == input.subtotal ||
                    (this.subtotal != null &&
                    this.subtotal.Equals(input.subtotal))
                ) && 
                (
                    this.applied_to_item_id == input.applied_to_item_id ||
                    (this.applied_to_item_id != null &&
                    this.applied_to_item_id.Equals(input.applied_to_item_id))
                ) && 
                (
                    this.document_item_date == input.document_item_date ||
                    (this.document_item_date != null &&
                    this.document_item_date.Equals(input.document_item_date))
                ) && 
                (
                    this.document_item_number == input.document_item_number ||
                    (this.document_item_number != null &&
                    this.document_item_number.Equals(input.document_item_number))
                ) && 
                (
                    this.charge_type == input.charge_type ||
                    (this.charge_type != null &&
                    this.charge_type.Equals(input.charge_type))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.processing_type == input.processing_type ||
                    (this.processing_type != null &&
                    this.processing_type.Equals(input.processing_type))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.subscription_item_id == input.subscription_item_id ||
                    (this.subscription_item_id != null &&
                    this.subscription_item_id.Equals(input.subscription_item_id))
                ) && 
                (
                    this.service_start_date == input.service_start_date ||
                    (this.service_start_date != null &&
                    this.service_start_date.Equals(input.service_start_date))
                ) && 
                (
                    this.service_end_date == input.service_end_date ||
                    (this.service_end_date != null &&
                    this.service_end_date.Equals(input.service_end_date))
                ) && 
                (
                    this.sku == input.sku ||
                    (this.sku != null &&
                    this.sku.Equals(input.sku))
                ) && 
                (
                    this.sku_name == input.sku_name ||
                    (this.sku_name != null &&
                    this.sku_name.Equals(input.sku_name))
                ) && 
                (
                    this.subscription_id == input.subscription_id ||
                    (this.subscription_id != null &&
                    this.subscription_id.Equals(input.subscription_id))
                ) && 
                (
                    this.subscription_number == input.subscription_number ||
                    (this.subscription_number != null &&
                    this.subscription_number.Equals(input.subscription_number))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
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
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.subtotal != null)
                    hashCode = hashCode * 59 + this.subtotal.GetHashCode();
                if (this.applied_to_item_id != null)
                    hashCode = hashCode * 59 + this.applied_to_item_id.GetHashCode();
                if (this.document_item_date != null)
                    hashCode = hashCode * 59 + this.document_item_date.GetHashCode();
                if (this.document_item_number != null)
                    hashCode = hashCode * 59 + this.document_item_number.GetHashCode();
                if (this.charge_type != null)
                    hashCode = hashCode * 59 + this.charge_type.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.processing_type != null)
                    hashCode = hashCode * 59 + this.processing_type.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.subscription_item_id != null)
                    hashCode = hashCode * 59 + this.subscription_item_id.GetHashCode();
                if (this.service_start_date != null)
                    hashCode = hashCode * 59 + this.service_start_date.GetHashCode();
                if (this.service_end_date != null)
                    hashCode = hashCode * 59 + this.service_end_date.GetHashCode();
                if (this.sku != null)
                    hashCode = hashCode * 59 + this.sku.GetHashCode();
                if (this.sku_name != null)
                    hashCode = hashCode * 59 + this.sku_name.GetHashCode();
                if (this.subscription_id != null)
                    hashCode = hashCode * 59 + this.subscription_id.GetHashCode();
                if (this.subscription_number != null)
                    hashCode = hashCode * 59 + this.subscription_number.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
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
