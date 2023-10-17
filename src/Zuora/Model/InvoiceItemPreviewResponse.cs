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
    /// InvoiceItemPreviewResponse
    /// </summary>
    [DataContract]
    public partial class InvoiceItemPreviewResponse :  IEquatable<InvoiceItemPreviewResponse>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="InvoiceItemPreviewResponse" /> class.
        /// </summary>
        /// <param name="amount">The total amount of this invoice item..</param>
        /// <param name="appliedToItemId">Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to..</param>
        /// <param name="documentDate">documentDate.</param>
        /// <param name="subscriptionItemDescription">subscriptionItemDescription.</param>
        /// <param name="subscriptionItemId">The identifier the subscription item associated with this invoice item..</param>
        /// <param name="subscriptionItemName">subscriptionItemName.</param>
        /// <param name="subscriptionItemNumber">Human-readable identifier of the subscription item. It can be user-supplied..</param>
        /// <param name="chargeType">Type of the charge. It can be one of the following types: one-time, recurring, or usage..</param>
        /// <param name="id">Unique identifier of the object.</param>
        /// <param name="processingType">processingType.</param>
        /// <param name="productName">productName.</param>
        /// <param name="quantity">The number of units of this item..</param>
        /// <param name="serviceStartDate">The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="serviceEndDate">The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="subscriptionId">The identifier of the subscription associated with the invoice item..</param>
        /// <param name="subscriptionNumber">The subscription number of the subscription associated with this item..</param>
        /// <param name="subscriptionName">The name of the subscription associated with this item..</param>
        /// <param name="tax">The amount of tax applied to the invoice item..</param>
        /// <param name="unitOfMeasure">Specifies the units used to measure usage..</param>
        public InvoiceItemPreviewResponse(decimal amount = default(decimal), string appliedToItemId = default(string), DateTime documentDate = default(DateTime), string subscriptionItemDescription = default(string), string subscriptionItemId = default(string), string subscriptionItemName = default(string), string subscriptionItemNumber = default(string), string chargeType = default(string), string id = default(string), ProcessingTypeEnum? processingType = default(ProcessingTypeEnum?), string productName = default(string), decimal quantity = default(decimal), string serviceStartDate = default(string), string serviceEndDate = default(string), string subscriptionId = default(string), string subscriptionNumber = default(string), string subscriptionName = default(string), decimal tax = default(decimal), string unitOfMeasure = default(string))
        {
            this.amount = amount;
            this.applied_to_item_id = appliedToItemId;
            this.document_date = documentDate;
            this.subscription_item_description = subscriptionItemDescription;
            this.subscription_item_id = subscriptionItemId;
            this.subscription_item_name = subscriptionItemName;
            this.subscription_item_number = subscriptionItemNumber;
            this.charge_type = chargeType;
            this.id = id;
            this.processing_type = processingType;
            this.product_name = productName;
            this.quantity = quantity;
            this.service_start_date = serviceStartDate;
            this.service_end_date = serviceEndDate;
            this.subscription_id = subscriptionId;
            this.subscription_number = subscriptionNumber;
            this.subscription_name = subscriptionName;
            this.tax = tax;
            this.unit_of_measure = unitOfMeasure;
        }

        /// <summary>
        /// The total amount of this invoice item.
        /// </summary>
        /// <value>The total amount of this invoice item.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal amount { get; set; }

        /// <summary>
        /// Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.
        /// </summary>
        /// <value>Identifier of an invoice item or a debit memo item that this discount item or credit memo item is applied to.</value>
        [DataMember(Name="applied_to_item_id", EmitDefaultValue=false)]
        public string applied_to_item_id { get; set; }

        /// <summary>
        /// Gets or Sets document_date
        /// </summary>
        [DataMember(Name="document_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime document_date { get; set; }

        /// <summary>
        /// Gets or Sets subscription_item_description
        /// </summary>
        [DataMember(Name="subscription_item_description", EmitDefaultValue=false)]
        public string subscription_item_description { get; set; }

        /// <summary>
        /// The identifier the subscription item associated with this invoice item.
        /// </summary>
        /// <value>The identifier the subscription item associated with this invoice item.</value>
        [DataMember(Name="subscription_item_id", EmitDefaultValue=false)]
        public string subscription_item_id { get; set; }

        /// <summary>
        /// Gets or Sets subscription_item_name
        /// </summary>
        [DataMember(Name="subscription_item_name", EmitDefaultValue=false)]
        public string subscription_item_name { get; set; }

        /// <summary>
        /// Human-readable identifier of the subscription item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the subscription item. It can be user-supplied.</value>
        [DataMember(Name="subscription_item_number", EmitDefaultValue=false)]
        public string subscription_item_number { get; set; }

        /// <summary>
        /// Type of the charge. It can be one of the following types: one-time, recurring, or usage.
        /// </summary>
        /// <value>Type of the charge. It can be one of the following types: one-time, recurring, or usage.</value>
        [DataMember(Name="charge_type", EmitDefaultValue=false)]
        public string charge_type { get; set; }

        /// <summary>
        /// Unique identifier of the object
        /// </summary>
        /// <value>Unique identifier of the object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }


        /// <summary>
        /// Gets or Sets product_name
        /// </summary>
        [DataMember(Name="product_name", EmitDefaultValue=false)]
        public string product_name { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_start_date", EmitDefaultValue=false)]
        public string service_start_date { get; set; }

        /// <summary>
        /// The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this invoice item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_end_date", EmitDefaultValue=false)]
        public string service_end_date { get; set; }

        /// <summary>
        /// The identifier of the subscription associated with the invoice item.
        /// </summary>
        /// <value>The identifier of the subscription associated with the invoice item.</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public string subscription_id { get; set; }

        /// <summary>
        /// The subscription number of the subscription associated with this item.
        /// </summary>
        /// <value>The subscription number of the subscription associated with this item.</value>
        [DataMember(Name="subscription_number", EmitDefaultValue=false)]
        public string subscription_number { get; set; }

        /// <summary>
        /// The name of the subscription associated with this item.
        /// </summary>
        /// <value>The name of the subscription associated with this item.</value>
        [DataMember(Name="subscription_name", EmitDefaultValue=false)]
        public string subscription_name { get; set; }

        /// <summary>
        /// The amount of tax applied to the invoice item.
        /// </summary>
        /// <value>The amount of tax applied to the invoice item.</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public decimal tax { get; set; }

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
            sb.Append("class InvoiceItemPreviewResponse {\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  applied_to_item_id: ").Append(applied_to_item_id).Append("\n");
            sb.Append("  document_date: ").Append(document_date).Append("\n");
            sb.Append("  subscription_item_description: ").Append(subscription_item_description).Append("\n");
            sb.Append("  subscription_item_id: ").Append(subscription_item_id).Append("\n");
            sb.Append("  subscription_item_name: ").Append(subscription_item_name).Append("\n");
            sb.Append("  subscription_item_number: ").Append(subscription_item_number).Append("\n");
            sb.Append("  charge_type: ").Append(charge_type).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  processing_type: ").Append(processing_type).Append("\n");
            sb.Append("  product_name: ").Append(product_name).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  service_start_date: ").Append(service_start_date).Append("\n");
            sb.Append("  service_end_date: ").Append(service_end_date).Append("\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  subscription_number: ").Append(subscription_number).Append("\n");
            sb.Append("  subscription_name: ").Append(subscription_name).Append("\n");
            sb.Append("  tax: ").Append(tax).Append("\n");
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
            return this.Equals(input as InvoiceItemPreviewResponse);
        }

        /// <summary>
        /// Returns true if InvoiceItemPreviewResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceItemPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceItemPreviewResponse input)
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
                    this.applied_to_item_id == input.applied_to_item_id ||
                    (this.applied_to_item_id != null &&
                    this.applied_to_item_id.Equals(input.applied_to_item_id))
                ) && 
                (
                    this.document_date == input.document_date ||
                    (this.document_date != null &&
                    this.document_date.Equals(input.document_date))
                ) && 
                (
                    this.subscription_item_description == input.subscription_item_description ||
                    (this.subscription_item_description != null &&
                    this.subscription_item_description.Equals(input.subscription_item_description))
                ) && 
                (
                    this.subscription_item_id == input.subscription_item_id ||
                    (this.subscription_item_id != null &&
                    this.subscription_item_id.Equals(input.subscription_item_id))
                ) && 
                (
                    this.subscription_item_name == input.subscription_item_name ||
                    (this.subscription_item_name != null &&
                    this.subscription_item_name.Equals(input.subscription_item_name))
                ) && 
                (
                    this.subscription_item_number == input.subscription_item_number ||
                    (this.subscription_item_number != null &&
                    this.subscription_item_number.Equals(input.subscription_item_number))
                ) && 
                (
                    this.charge_type == input.charge_type ||
                    (this.charge_type != null &&
                    this.charge_type.Equals(input.charge_type))
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
                    this.product_name == input.product_name ||
                    (this.product_name != null &&
                    this.product_name.Equals(input.product_name))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
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
                    this.subscription_name == input.subscription_name ||
                    (this.subscription_name != null &&
                    this.subscription_name.Equals(input.subscription_name))
                ) && 
                (
                    this.tax == input.tax ||
                    (this.tax != null &&
                    this.tax.Equals(input.tax))
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
                if (this.applied_to_item_id != null)
                    hashCode = hashCode * 59 + this.applied_to_item_id.GetHashCode();
                if (this.document_date != null)
                    hashCode = hashCode * 59 + this.document_date.GetHashCode();
                if (this.subscription_item_description != null)
                    hashCode = hashCode * 59 + this.subscription_item_description.GetHashCode();
                if (this.subscription_item_id != null)
                    hashCode = hashCode * 59 + this.subscription_item_id.GetHashCode();
                if (this.subscription_item_name != null)
                    hashCode = hashCode * 59 + this.subscription_item_name.GetHashCode();
                if (this.subscription_item_number != null)
                    hashCode = hashCode * 59 + this.subscription_item_number.GetHashCode();
                if (this.charge_type != null)
                    hashCode = hashCode * 59 + this.charge_type.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.processing_type != null)
                    hashCode = hashCode * 59 + this.processing_type.GetHashCode();
                if (this.product_name != null)
                    hashCode = hashCode * 59 + this.product_name.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.service_start_date != null)
                    hashCode = hashCode * 59 + this.service_start_date.GetHashCode();
                if (this.service_end_date != null)
                    hashCode = hashCode * 59 + this.service_end_date.GetHashCode();
                if (this.subscription_id != null)
                    hashCode = hashCode * 59 + this.subscription_id.GetHashCode();
                if (this.subscription_number != null)
                    hashCode = hashCode * 59 + this.subscription_number.GetHashCode();
                if (this.subscription_name != null)
                    hashCode = hashCode * 59 + this.subscription_name.GetHashCode();
                if (this.tax != null)
                    hashCode = hashCode * 59 + this.tax.GetHashCode();
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
