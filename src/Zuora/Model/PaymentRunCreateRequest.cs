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
    /// PaymentRunCreateRequest
    /// </summary>
    [DataContract]
    public partial class PaymentRunCreateRequest :  IEquatable<PaymentRunCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRunCreateRequest" /> class.
        /// </summary>
        /// <param name="applyCreditMemos">If true, any posted credit memos are applied first..</param>
        /// <param name="applyUnappliedPayments">If true, any unapplied payments are applied first..</param>
        /// <param name="batch">Identifier of the customer account batch to be included in this payment run..</param>
        /// <param name="billCycleDay">The day of the month to bill multiple customer accounts..</param>
        /// <param name="billRunId">The unique identifier of a bill run..</param>
        /// <param name="collectPayment">Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \&quot;Process Electronic Payment\&quot; is disabled, this field will be ignored..</param>
        /// <param name="currency">Three-letter ISO currency code..</param>
        /// <param name="consolidatedPayment">If true, a single payment will be collected for all receivables due on an account..</param>
        /// <param name="gatewayId">Unique identifier for the payment gateway..</param>
        /// <param name="paymentRunDate">The date and time when the scheduled payment run is to be executed, in &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. The backend will ignore mintues and seconds in the field value. For example, if you specify &#x60;2017-03-01 11:30:37&#x60; for this value, this payment run will be run at 2017-03-01 11:00:00.      &lt;br /&gt;       You must specify either the &#x60;payment_run_date&#x60; field or the &#x60;target_date&#x60; field in the request body.      If you specify the &#x60;payment_run_date&#x60; field, the scheduced payment run is to be executed on the specified payment run date. If you specify the &#x60;target_date&#x60; field, the payment run is executed immediately after it is created..</param>
        /// <param name="targetDate">The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date..</param>
        public PaymentRunCreateRequest(bool applyCreditMemos = default(bool), bool applyUnappliedPayments = default(bool), string batch = default(string), string billCycleDay = default(string), string billRunId = default(string), bool collectPayment = default(bool), string currency = default(string), bool consolidatedPayment = default(bool), string gatewayId = default(string), DateTime paymentRunDate = default(DateTime), DateTime targetDate = default(DateTime))
        {
            this.apply_credit_memos = applyCreditMemos;
            this.apply_unapplied_payments = applyUnappliedPayments;
            this.batch = batch;
            this.bill_cycle_day = billCycleDay;
            this.bill_run_id = billRunId;
            this.collect_payment = collectPayment;
            this.currency = currency;
            this.consolidated_payment = consolidatedPayment;
            this.gateway_id = gatewayId;
            this.payment_run_date = paymentRunDate;
            this.target_date = targetDate;
        }

        /// <summary>
        /// If true, any posted credit memos are applied first.
        /// </summary>
        /// <value>If true, any posted credit memos are applied first.</value>
        [DataMember(Name="apply_credit_memos", EmitDefaultValue=false)]
        public bool apply_credit_memos { get; set; }

        /// <summary>
        /// If true, any unapplied payments are applied first.
        /// </summary>
        /// <value>If true, any unapplied payments are applied first.</value>
        [DataMember(Name="apply_unapplied_payments", EmitDefaultValue=false)]
        public bool apply_unapplied_payments { get; set; }

        /// <summary>
        /// Identifier of the customer account batch to be included in this payment run.
        /// </summary>
        /// <value>Identifier of the customer account batch to be included in this payment run.</value>
        [DataMember(Name="batch", EmitDefaultValue=false)]
        public string batch { get; set; }

        /// <summary>
        /// The day of the month to bill multiple customer accounts.
        /// </summary>
        /// <value>The day of the month to bill multiple customer accounts.</value>
        [DataMember(Name="bill_cycle_day", EmitDefaultValue=false)]
        public string bill_cycle_day { get; set; }

        /// <summary>
        /// The unique identifier of a bill run.
        /// </summary>
        /// <value>The unique identifier of a bill run.</value>
        [DataMember(Name="bill_run_id", EmitDefaultValue=false)]
        public string bill_run_id { get; set; }

        /// <summary>
        /// Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \&quot;Process Electronic Payment\&quot; is disabled, this field will be ignored.
        /// </summary>
        /// <value>Indicates whether to process electronic payments during the execution of payment runs.       If the Payment user permission \&quot;Process Electronic Payment\&quot; is disabled, this field will be ignored.</value>
        [DataMember(Name="collect_payment", EmitDefaultValue=false)]
        public bool collect_payment { get; set; }

        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        /// <value>Three-letter ISO currency code.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string currency { get; set; }

        /// <summary>
        /// If true, a single payment will be collected for all receivables due on an account.
        /// </summary>
        /// <value>If true, a single payment will be collected for all receivables due on an account.</value>
        [DataMember(Name="consolidated_payment", EmitDefaultValue=false)]
        public bool consolidated_payment { get; set; }

        /// <summary>
        /// Unique identifier for the payment gateway.
        /// </summary>
        /// <value>Unique identifier for the payment gateway.</value>
        [DataMember(Name="gateway_id", EmitDefaultValue=false)]
        public string gateway_id { get; set; }

        /// <summary>
        /// The date and time when the scheduled payment run is to be executed, in &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. The backend will ignore mintues and seconds in the field value. For example, if you specify &#x60;2017-03-01 11:30:37&#x60; for this value, this payment run will be run at 2017-03-01 11:00:00.      &lt;br /&gt;       You must specify either the &#x60;payment_run_date&#x60; field or the &#x60;target_date&#x60; field in the request body.      If you specify the &#x60;payment_run_date&#x60; field, the scheduced payment run is to be executed on the specified payment run date. If you specify the &#x60;target_date&#x60; field, the payment run is executed immediately after it is created.
        /// </summary>
        /// <value>The date and time when the scheduled payment run is to be executed, in &#x60;yyyy-mm-dd hh:mm:ss&#x60; format. The backend will ignore mintues and seconds in the field value. For example, if you specify &#x60;2017-03-01 11:30:37&#x60; for this value, this payment run will be run at 2017-03-01 11:00:00.      &lt;br /&gt;       You must specify either the &#x60;payment_run_date&#x60; field or the &#x60;target_date&#x60; field in the request body.      If you specify the &#x60;payment_run_date&#x60; field, the scheduced payment run is to be executed on the specified payment run date. If you specify the &#x60;target_date&#x60; field, the payment run is executed immediately after it is created.</value>
        [DataMember(Name="payment_run_date", EmitDefaultValue=false)]
        public DateTime payment_run_date { get; set; }

        /// <summary>
        /// The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.
        /// </summary>
        /// <value>The target date used to determine which receivables to be paid in the payment run.       The payments are collected for all receivables with the due date no later than the target date.</value>
        [DataMember(Name="target_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime target_date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRunCreateRequest {\n");
            sb.Append("  apply_credit_memos: ").Append(apply_credit_memos).Append("\n");
            sb.Append("  apply_unapplied_payments: ").Append(apply_unapplied_payments).Append("\n");
            sb.Append("  batch: ").Append(batch).Append("\n");
            sb.Append("  bill_cycle_day: ").Append(bill_cycle_day).Append("\n");
            sb.Append("  bill_run_id: ").Append(bill_run_id).Append("\n");
            sb.Append("  collect_payment: ").Append(collect_payment).Append("\n");
            sb.Append("  currency: ").Append(currency).Append("\n");
            sb.Append("  consolidated_payment: ").Append(consolidated_payment).Append("\n");
            sb.Append("  gateway_id: ").Append(gateway_id).Append("\n");
            sb.Append("  payment_run_date: ").Append(payment_run_date).Append("\n");
            sb.Append("  target_date: ").Append(target_date).Append("\n");
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
            return this.Equals(input as PaymentRunCreateRequest);
        }

        /// <summary>
        /// Returns true if PaymentRunCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRunCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRunCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.apply_credit_memos == input.apply_credit_memos ||
                    (this.apply_credit_memos != null &&
                    this.apply_credit_memos.Equals(input.apply_credit_memos))
                ) && 
                (
                    this.apply_unapplied_payments == input.apply_unapplied_payments ||
                    (this.apply_unapplied_payments != null &&
                    this.apply_unapplied_payments.Equals(input.apply_unapplied_payments))
                ) && 
                (
                    this.batch == input.batch ||
                    (this.batch != null &&
                    this.batch.Equals(input.batch))
                ) && 
                (
                    this.bill_cycle_day == input.bill_cycle_day ||
                    (this.bill_cycle_day != null &&
                    this.bill_cycle_day.Equals(input.bill_cycle_day))
                ) && 
                (
                    this.bill_run_id == input.bill_run_id ||
                    (this.bill_run_id != null &&
                    this.bill_run_id.Equals(input.bill_run_id))
                ) && 
                (
                    this.collect_payment == input.collect_payment ||
                    (this.collect_payment != null &&
                    this.collect_payment.Equals(input.collect_payment))
                ) && 
                (
                    this.currency == input.currency ||
                    (this.currency != null &&
                    this.currency.Equals(input.currency))
                ) && 
                (
                    this.consolidated_payment == input.consolidated_payment ||
                    (this.consolidated_payment != null &&
                    this.consolidated_payment.Equals(input.consolidated_payment))
                ) && 
                (
                    this.gateway_id == input.gateway_id ||
                    (this.gateway_id != null &&
                    this.gateway_id.Equals(input.gateway_id))
                ) && 
                (
                    this.payment_run_date == input.payment_run_date ||
                    (this.payment_run_date != null &&
                    this.payment_run_date.Equals(input.payment_run_date))
                ) && 
                (
                    this.target_date == input.target_date ||
                    (this.target_date != null &&
                    this.target_date.Equals(input.target_date))
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
                if (this.apply_credit_memos != null)
                    hashCode = hashCode * 59 + this.apply_credit_memos.GetHashCode();
                if (this.apply_unapplied_payments != null)
                    hashCode = hashCode * 59 + this.apply_unapplied_payments.GetHashCode();
                if (this.batch != null)
                    hashCode = hashCode * 59 + this.batch.GetHashCode();
                if (this.bill_cycle_day != null)
                    hashCode = hashCode * 59 + this.bill_cycle_day.GetHashCode();
                if (this.bill_run_id != null)
                    hashCode = hashCode * 59 + this.bill_run_id.GetHashCode();
                if (this.collect_payment != null)
                    hashCode = hashCode * 59 + this.collect_payment.GetHashCode();
                if (this.currency != null)
                    hashCode = hashCode * 59 + this.currency.GetHashCode();
                if (this.consolidated_payment != null)
                    hashCode = hashCode * 59 + this.consolidated_payment.GetHashCode();
                if (this.gateway_id != null)
                    hashCode = hashCode * 59 + this.gateway_id.GetHashCode();
                if (this.payment_run_date != null)
                    hashCode = hashCode * 59 + this.payment_run_date.GetHashCode();
                if (this.target_date != null)
                    hashCode = hashCode * 59 + this.target_date.GetHashCode();
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
