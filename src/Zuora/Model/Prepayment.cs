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
    /// Prepayment
    /// </summary>
    [DataContract]
    public partial class Prepayment :  IEquatable<Prepayment>, IValidatableObject
    {
        /// <summary>
        /// The way to calculate credit. See &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option&#39;  target&#x3D;&#39;_blank&#39;&gt;Credit Option&lt;/a&gt; for more information.
        /// </summary>
        /// <value>The way to calculate credit. See &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option&#39;  target&#x3D;&#39;_blank&#39;&gt;Credit Option&lt;/a&gt; for more information.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CreditOptionEnum
        {
            /// <summary>
            /// Enum Timebased for value: time_based
            /// </summary>
            [EnumMember(Value = "time_based")]
            Timebased = 1,

            /// <summary>
            /// Enum Consumptionbased for value: consumption_based
            /// </summary>
            [EnumMember(Value = "consumption_based")]
            Consumptionbased = 2,

            /// <summary>
            /// Enum Fullcredit for value: full_credit
            /// </summary>
            [EnumMember(Value = "full_credit")]
            Fullcredit = 3

        }

        /// <summary>
        /// The way to calculate credit. See &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option&#39;  target&#x3D;&#39;_blank&#39;&gt;Credit Option&lt;/a&gt; for more information.
        /// </summary>
        /// <value>The way to calculate credit. See &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option&#39;  target&#x3D;&#39;_blank&#39;&gt;Credit Option&lt;/a&gt; for more information.</value>
        [DataMember(Name="credit_option", EmitDefaultValue=false)]
        public CreditOptionEnum? credit_option { get; set; }
        /// <summary>
        /// The period in which the prepayment units are valid to use as defined in a prepayment charge.
        /// </summary>
        /// <value>The period in which the prepayment units are valid to use as defined in a prepayment charge.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidityPeriodEnum
        {
            /// <summary>
            /// Enum Subscriptionterm for value: subscription_term
            /// </summary>
            [EnumMember(Value = "subscription_term")]
            Subscriptionterm = 1,

            /// <summary>
            /// Enum Annual for value: annual
            /// </summary>
            [EnumMember(Value = "annual")]
            Annual = 2,

            /// <summary>
            /// Enum Semiannual for value: semi_annual
            /// </summary>
            [EnumMember(Value = "semi_annual")]
            Semiannual = 3,

            /// <summary>
            /// Enum Quarter for value: quarter
            /// </summary>
            [EnumMember(Value = "quarter")]
            Quarter = 4,

            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 5

        }

        /// <summary>
        /// The period in which the prepayment units are valid to use as defined in a prepayment charge.
        /// </summary>
        /// <value>The period in which the prepayment units are valid to use as defined in a prepayment charge.</value>
        [DataMember(Name="validity_period", EmitDefaultValue=false)]
        public ValidityPeriodEnum? validity_period { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Prepayment" /> class.
        /// </summary>
        /// <param name="creditOption">The way to calculate credit. See &lt;a href&#x3D;&#39;https://knowledgecenter.zuora.com/Zuora_Billing/Billing_and_Invoicing/JA_Advanced_Consumption_Billing/Prepaid_with_Drawdown/A_Create_prepayment_charge#Credit_Option&#39;  target&#x3D;&#39;_blank&#39;&gt;Credit Option&lt;/a&gt; for more information..</param>
        /// <param name="quantity">The number of units included in a prepayment charge..</param>
        /// <param name="totalQuantity">The total amount of units that end customers can use during a validity period when they subscribe to a prepayment charge..</param>
        /// <param name="unitOfMeasure">A configured unit of measure. This field is required for per-unit prices..</param>
        /// <param name="validityPeriod">The period in which the prepayment units are valid to use as defined in a prepayment charge..</param>
        public Prepayment(CreditOptionEnum? creditOption = default(CreditOptionEnum?), decimal quantity = default(decimal), decimal totalQuantity = default(decimal), string unitOfMeasure = default(string), ValidityPeriodEnum? validityPeriod = default(ValidityPeriodEnum?))
        {
            this.credit_option = creditOption;
            this.quantity = quantity;
            this.total_quantity = totalQuantity;
            this.unit_of_measure = unitOfMeasure;
            this.validity_period = validityPeriod;
        }


        /// <summary>
        /// The number of units included in a prepayment charge.
        /// </summary>
        /// <value>The number of units included in a prepayment charge.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// The total amount of units that end customers can use during a validity period when they subscribe to a prepayment charge.
        /// </summary>
        /// <value>The total amount of units that end customers can use during a validity period when they subscribe to a prepayment charge.</value>
        [DataMember(Name="total_quantity", EmitDefaultValue=false)]
        public decimal total_quantity { get; set; }

        /// <summary>
        /// A configured unit of measure. This field is required for per-unit prices.
        /// </summary>
        /// <value>A configured unit of measure. This field is required for per-unit prices.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Prepayment {\n");
            sb.Append("  credit_option: ").Append(credit_option).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  total_quantity: ").Append(total_quantity).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
            sb.Append("  validity_period: ").Append(validity_period).Append("\n");
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
            return this.Equals(input as Prepayment);
        }

        /// <summary>
        /// Returns true if Prepayment instances are equal
        /// </summary>
        /// <param name="input">Instance of Prepayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prepayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.credit_option == input.credit_option ||
                    (this.credit_option != null &&
                    this.credit_option.Equals(input.credit_option))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.total_quantity == input.total_quantity ||
                    (this.total_quantity != null &&
                    this.total_quantity.Equals(input.total_quantity))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
                ) && 
                (
                    this.validity_period == input.validity_period ||
                    (this.validity_period != null &&
                    this.validity_period.Equals(input.validity_period))
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
                if (this.credit_option != null)
                    hashCode = hashCode * 59 + this.credit_option.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.total_quantity != null)
                    hashCode = hashCode * 59 + this.total_quantity.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
                if (this.validity_period != null)
                    hashCode = hashCode * 59 + this.validity_period.GetHashCode();
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
