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
    /// MemoInvoiceItemCreateRequest
    /// </summary>
    [DataContract]
    public partial class MemoInvoiceItemCreateRequest :  IEquatable<MemoInvoiceItemCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoInvoiceItemCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MemoInvoiceItemCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoInvoiceItemCreateRequest" /> class.
        /// </summary>
        /// <param name="amount">Amount (in the currency specified) of the invoice item. This should always be equal to unit_amount * quantity. (required).</param>
        /// <param name="description">An arbitrary string associated with the object. Often useful for displaying to users..</param>
        /// <param name="deferredRevenueAccount">An active account in your Zuora Chart of Accounts..</param>
        /// <param name="onAccountAccount">An active account in your Zuora Chart of Accounts..</param>
        /// <param name="recognizedRevenueAccount">An active account in your Zuora Chart of Accounts..</param>
        /// <param name="revenueRecognitionRuleName">The name of the revenue recognition rule governing the revenue schedule..</param>
        /// <param name="quantity">The number of units of this item..</param>
        /// <param name="serviceEnd">The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item..</param>
        /// <param name="serviceStart">The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item. (required).</param>
        /// <param name="sku">The unique SKU (stock keeping unit) of the product associated with this item..</param>
        /// <param name="taxInclusive">Indicates whether the invoice item amount is inclusive or exclusive of tax..</param>
        /// <param name="unitOfMeasure">Specifies the units used to measure usage..</param>
        /// <param name="taxationItems">List of taxation items..</param>
        /// <param name="unitAmount">Unit amount (in the currency specified) of the invoice item..</param>
        /// <param name="bookingReference">The booking reference for this invoice item..</param>
        /// <param name="priceId">The identifier of the price this invoice item is associated with..</param>
        /// <param name="purchaseOrderNumber">The purchase order number associated with this invoice item..</param>
        /// <param name="taxCode">The designated tax code..</param>
        /// <param name="documentItemDate">The date when the invoice item takes effect. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;invoice&#x60;..</param>
        /// <param name="name">Name of the invoice item displayed to customers on billing documents..</param>
        /// <param name="accountingCode">accountingCode.</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="invoiceItemId">The identifier of the invoice item associated with this memo item..</param>
        public MemoInvoiceItemCreateRequest(decimal amount = default(decimal), string description = default(string), string deferredRevenueAccount = default(string), string onAccountAccount = default(string), string recognizedRevenueAccount = default(string), string revenueRecognitionRuleName = default(string), decimal quantity = default(decimal), DateTime serviceEnd = default(DateTime), DateTime serviceStart = default(DateTime), string sku = default(string), bool taxInclusive = default(bool), string unitOfMeasure = default(string), List<TaxationItemCreateRequest> taxationItems = default(List<TaxationItemCreateRequest>), decimal unitAmount = default(decimal), string bookingReference = default(string), string priceId = default(string), string purchaseOrderNumber = default(string), string taxCode = default(string), DateTime documentItemDate = default(DateTime), string name = default(string), string accountingCode = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string invoiceItemId = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for MemoInvoiceItemCreateRequest and cannot be null");
            }
            else
            {
                this.amount = amount;
            }

            // to ensure "serviceStart" is required (not null)
            if (serviceStart == null)
            {
                throw new InvalidDataException("serviceStart is a required property for MemoInvoiceItemCreateRequest and cannot be null");
            }
            else
            {
                this.service_start = serviceStart;
            }

            this.description = description;
            this.deferred_revenue_account = deferredRevenueAccount;
            this.on_account_account = onAccountAccount;
            this.recognized_revenue_account = recognizedRevenueAccount;
            this.revenue_recognition_rule_name = revenueRecognitionRuleName;
            this.quantity = quantity;
            this.service_end = serviceEnd;
            this.sku = sku;
            this.tax_inclusive = taxInclusive;
            this.unit_of_measure = unitOfMeasure;
            this.taxation_items = taxationItems;
            this.unit_amount = unitAmount;
            this.booking_reference = bookingReference;
            this.price_id = priceId;
            this.purchase_order_number = purchaseOrderNumber;
            this.tax_code = taxCode;
            this.document_item_date = documentItemDate;
            this.name = name;
            this.accounting_code = accountingCode;
            this.custom_fields = customFields;
            this.invoice_item_id = invoiceItemId;
        }

        /// <summary>
        /// Amount (in the currency specified) of the invoice item. This should always be equal to unit_amount * quantity.
        /// </summary>
        /// <value>Amount (in the currency specified) of the invoice item. This should always be equal to unit_amount * quantity.</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal amount { get; set; }

        /// <summary>
        /// An arbitrary string associated with the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string associated with the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name="deferred_revenue_account", EmitDefaultValue=false)]
        public string deferred_revenue_account { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name="on_account_account", EmitDefaultValue=false)]
        public string on_account_account { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name="recognized_revenue_account", EmitDefaultValue=false)]
        public string recognized_revenue_account { get; set; }

        /// <summary>
        /// The name of the revenue recognition rule governing the revenue schedule.
        /// </summary>
        /// <value>The name of the revenue recognition rule governing the revenue schedule.</value>
        [DataMember(Name="revenue_recognition_rule_name", EmitDefaultValue=false)]
        public string revenue_recognition_rule_name { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
        /// </summary>
        /// <value>The end date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
        [DataMember(Name="service_end", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime service_end { get; set; }

        /// <summary>
        /// The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.
        /// </summary>
        /// <value>The start date of the service period associated with this invoice item. If the price for the associated subscription item is a one-time fee, then this date is the date of that subscription item.</value>
        [DataMember(Name="service_start", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime service_start { get; set; }

        /// <summary>
        /// The unique SKU (stock keeping unit) of the product associated with this item.
        /// </summary>
        /// <value>The unique SKU (stock keeping unit) of the product associated with this item.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string sku { get; set; }

        /// <summary>
        /// Indicates whether the invoice item amount is inclusive or exclusive of tax.
        /// </summary>
        /// <value>Indicates whether the invoice item amount is inclusive or exclusive of tax.</value>
        [DataMember(Name="tax_inclusive", EmitDefaultValue=false)]
        public bool tax_inclusive { get; set; }

        /// <summary>
        /// Specifies the units used to measure usage.
        /// </summary>
        /// <value>Specifies the units used to measure usage.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// List of taxation items.
        /// </summary>
        /// <value>List of taxation items.</value>
        [DataMember(Name="taxation_items", EmitDefaultValue=false)]
        public List<TaxationItemCreateRequest> taxation_items { get; set; }

        /// <summary>
        /// Unit amount (in the currency specified) of the invoice item.
        /// </summary>
        /// <value>Unit amount (in the currency specified) of the invoice item.</value>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        public decimal unit_amount { get; set; }

        /// <summary>
        /// The booking reference for this invoice item.
        /// </summary>
        /// <value>The booking reference for this invoice item.</value>
        [DataMember(Name="booking_reference", EmitDefaultValue=false)]
        public string booking_reference { get; set; }

        /// <summary>
        /// The identifier of the price this invoice item is associated with.
        /// </summary>
        /// <value>The identifier of the price this invoice item is associated with.</value>
        [DataMember(Name="price_id", EmitDefaultValue=false)]
        public string price_id { get; set; }

        /// <summary>
        /// The purchase order number associated with this invoice item.
        /// </summary>
        /// <value>The purchase order number associated with this invoice item.</value>
        [DataMember(Name="purchase_order_number", EmitDefaultValue=false)]
        public string purchase_order_number { get; set; }

        /// <summary>
        /// The designated tax code.
        /// </summary>
        /// <value>The designated tax code.</value>
        [DataMember(Name="tax_code", EmitDefaultValue=false)]
        public string tax_code { get; set; }

        /// <summary>
        /// The date when the invoice item takes effect. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;invoice&#x60;.
        /// </summary>
        /// <value>The date when the invoice item takes effect. This field is applicable only if the &#x60;type&#x60; field is set to &#x60;invoice&#x60;.</value>
        [DataMember(Name="document_item_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime document_item_date { get; set; }

        /// <summary>
        /// Name of the invoice item displayed to customers on billing documents.
        /// </summary>
        /// <value>Name of the invoice item displayed to customers on billing documents.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets accounting_code
        /// </summary>
        [DataMember(Name="accounting_code", EmitDefaultValue=false)]
        public string accounting_code { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// The identifier of the invoice item associated with this memo item.
        /// </summary>
        /// <value>The identifier of the invoice item associated with this memo item.</value>
        [DataMember(Name="invoice_item_id", EmitDefaultValue=false)]
        public string invoice_item_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemoInvoiceItemCreateRequest {\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  deferred_revenue_account: ").Append(deferred_revenue_account).Append("\n");
            sb.Append("  on_account_account: ").Append(on_account_account).Append("\n");
            sb.Append("  recognized_revenue_account: ").Append(recognized_revenue_account).Append("\n");
            sb.Append("  revenue_recognition_rule_name: ").Append(revenue_recognition_rule_name).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  service_end: ").Append(service_end).Append("\n");
            sb.Append("  service_start: ").Append(service_start).Append("\n");
            sb.Append("  sku: ").Append(sku).Append("\n");
            sb.Append("  tax_inclusive: ").Append(tax_inclusive).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
            sb.Append("  taxation_items: ").Append(taxation_items).Append("\n");
            sb.Append("  unit_amount: ").Append(unit_amount).Append("\n");
            sb.Append("  booking_reference: ").Append(booking_reference).Append("\n");
            sb.Append("  price_id: ").Append(price_id).Append("\n");
            sb.Append("  purchase_order_number: ").Append(purchase_order_number).Append("\n");
            sb.Append("  tax_code: ").Append(tax_code).Append("\n");
            sb.Append("  document_item_date: ").Append(document_item_date).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  accounting_code: ").Append(accounting_code).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  invoice_item_id: ").Append(invoice_item_id).Append("\n");
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
            return this.Equals(input as MemoInvoiceItemCreateRequest);
        }

        /// <summary>
        /// Returns true if MemoInvoiceItemCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MemoInvoiceItemCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemoInvoiceItemCreateRequest input)
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
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.deferred_revenue_account == input.deferred_revenue_account ||
                    (this.deferred_revenue_account != null &&
                    this.deferred_revenue_account.Equals(input.deferred_revenue_account))
                ) && 
                (
                    this.on_account_account == input.on_account_account ||
                    (this.on_account_account != null &&
                    this.on_account_account.Equals(input.on_account_account))
                ) && 
                (
                    this.recognized_revenue_account == input.recognized_revenue_account ||
                    (this.recognized_revenue_account != null &&
                    this.recognized_revenue_account.Equals(input.recognized_revenue_account))
                ) && 
                (
                    this.revenue_recognition_rule_name == input.revenue_recognition_rule_name ||
                    (this.revenue_recognition_rule_name != null &&
                    this.revenue_recognition_rule_name.Equals(input.revenue_recognition_rule_name))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.service_end == input.service_end ||
                    (this.service_end != null &&
                    this.service_end.Equals(input.service_end))
                ) && 
                (
                    this.service_start == input.service_start ||
                    (this.service_start != null &&
                    this.service_start.Equals(input.service_start))
                ) && 
                (
                    this.sku == input.sku ||
                    (this.sku != null &&
                    this.sku.Equals(input.sku))
                ) && 
                (
                    this.tax_inclusive == input.tax_inclusive ||
                    (this.tax_inclusive != null &&
                    this.tax_inclusive.Equals(input.tax_inclusive))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
                ) && 
                (
                    this.taxation_items == input.taxation_items ||
                    this.taxation_items != null &&
                    input.taxation_items != null &&
                    this.taxation_items.SequenceEqual(input.taxation_items)
                ) && 
                (
                    this.unit_amount == input.unit_amount ||
                    (this.unit_amount != null &&
                    this.unit_amount.Equals(input.unit_amount))
                ) && 
                (
                    this.booking_reference == input.booking_reference ||
                    (this.booking_reference != null &&
                    this.booking_reference.Equals(input.booking_reference))
                ) && 
                (
                    this.price_id == input.price_id ||
                    (this.price_id != null &&
                    this.price_id.Equals(input.price_id))
                ) && 
                (
                    this.purchase_order_number == input.purchase_order_number ||
                    (this.purchase_order_number != null &&
                    this.purchase_order_number.Equals(input.purchase_order_number))
                ) && 
                (
                    this.tax_code == input.tax_code ||
                    (this.tax_code != null &&
                    this.tax_code.Equals(input.tax_code))
                ) && 
                (
                    this.document_item_date == input.document_item_date ||
                    (this.document_item_date != null &&
                    this.document_item_date.Equals(input.document_item_date))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.accounting_code == input.accounting_code ||
                    (this.accounting_code != null &&
                    this.accounting_code.Equals(input.accounting_code))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.invoice_item_id == input.invoice_item_id ||
                    (this.invoice_item_id != null &&
                    this.invoice_item_id.Equals(input.invoice_item_id))
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
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.deferred_revenue_account != null)
                    hashCode = hashCode * 59 + this.deferred_revenue_account.GetHashCode();
                if (this.on_account_account != null)
                    hashCode = hashCode * 59 + this.on_account_account.GetHashCode();
                if (this.recognized_revenue_account != null)
                    hashCode = hashCode * 59 + this.recognized_revenue_account.GetHashCode();
                if (this.revenue_recognition_rule_name != null)
                    hashCode = hashCode * 59 + this.revenue_recognition_rule_name.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.service_end != null)
                    hashCode = hashCode * 59 + this.service_end.GetHashCode();
                if (this.service_start != null)
                    hashCode = hashCode * 59 + this.service_start.GetHashCode();
                if (this.sku != null)
                    hashCode = hashCode * 59 + this.sku.GetHashCode();
                if (this.tax_inclusive != null)
                    hashCode = hashCode * 59 + this.tax_inclusive.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
                if (this.taxation_items != null)
                    hashCode = hashCode * 59 + this.taxation_items.GetHashCode();
                if (this.unit_amount != null)
                    hashCode = hashCode * 59 + this.unit_amount.GetHashCode();
                if (this.booking_reference != null)
                    hashCode = hashCode * 59 + this.booking_reference.GetHashCode();
                if (this.price_id != null)
                    hashCode = hashCode * 59 + this.price_id.GetHashCode();
                if (this.purchase_order_number != null)
                    hashCode = hashCode * 59 + this.purchase_order_number.GetHashCode();
                if (this.tax_code != null)
                    hashCode = hashCode * 59 + this.tax_code.GetHashCode();
                if (this.document_item_date != null)
                    hashCode = hashCode * 59 + this.document_item_date.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.accounting_code != null)
                    hashCode = hashCode * 59 + this.accounting_code.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.invoice_item_id != null)
                    hashCode = hashCode * 59 + this.invoice_item_id.GetHashCode();
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
