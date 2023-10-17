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
    /// PaymentMethodAuthorizationResponse
    /// </summary>
    [DataContract]
    public partial class PaymentMethodAuthorizationResponse :  IEquatable<PaymentMethodAuthorizationResponse>, IValidatableObject
    {
        /// <summary>
        /// The status of the payment authorization.
        /// </summary>
        /// <value>The status of the payment authorization.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 1,

            /// <summary>
            /// Enum Queuedforsubmission for value: queued_for_submission
            /// </summary>
            [EnumMember(Value = "queued_for_submission")]
            Queuedforsubmission = 2

        }

        /// <summary>
        /// The status of the payment authorization.
        /// </summary>
        /// <value>The status of the payment authorization.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodAuthorizationResponse" /> class.
        /// </summary>
        /// <param name="authTransactionId">Identifier of the authorization transaction from the payment gateway..</param>
        /// <param name="gatewayOrderId">A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the &#x60;gateway_order_id&#x60; that you used when authorizing the funds by using the Create authorization operation, together with the &#x60;authorization_id&#x60; field..</param>
        /// <param name="state">The status of the payment authorization..</param>
        public PaymentMethodAuthorizationResponse(string authTransactionId = default(string), string gatewayOrderId = default(string), StateEnum? state = default(StateEnum?))
        {
            this.auth_transaction_id = authTransactionId;
            this.gateway_order_id = gatewayOrderId;
            this.state = state;
        }

        /// <summary>
        /// Identifier of the authorization transaction from the payment gateway.
        /// </summary>
        /// <value>Identifier of the authorization transaction from the payment gateway.</value>
        [DataMember(Name="auth_transaction_id", EmitDefaultValue=false)]
        public string auth_transaction_id { get; set; }

        /// <summary>
        /// A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the &#x60;gateway_order_id&#x60; that you used when authorizing the funds by using the Create authorization operation, together with the &#x60;authorization_id&#x60; field.
        /// </summary>
        /// <value>A merchant-specified natural key value that can be passed to the electronic payment gateway when a payment is created. If not specified, the payment number will be passed in instead. Gateways check duplicates on the gateway order ID to ensure that the merchant do not accidentally enter the same transaction twice. This ID can also be used to do reconciliation and tie the payment to a natural key in external systems. The source of this ID varies by merchant. Some merchants use their shopping cart order IDs, and others use something different. Merchants use this ID to track transactions in their eCommerce systems. When you create a payment for capturing the authorized funds, it is highly recommended to pass in the &#x60;gateway_order_id&#x60; that you used when authorizing the funds by using the Create authorization operation, together with the &#x60;authorization_id&#x60; field.</value>
        [DataMember(Name="gateway_order_id", EmitDefaultValue=false)]
        public string gateway_order_id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodAuthorizationResponse {\n");
            sb.Append("  auth_transaction_id: ").Append(auth_transaction_id).Append("\n");
            sb.Append("  gateway_order_id: ").Append(gateway_order_id).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
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
            return this.Equals(input as PaymentMethodAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if PaymentMethodAuthorizationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodAuthorizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodAuthorizationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.auth_transaction_id == input.auth_transaction_id ||
                    (this.auth_transaction_id != null &&
                    this.auth_transaction_id.Equals(input.auth_transaction_id))
                ) && 
                (
                    this.gateway_order_id == input.gateway_order_id ||
                    (this.gateway_order_id != null &&
                    this.gateway_order_id.Equals(input.gateway_order_id))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
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
                if (this.auth_transaction_id != null)
                    hashCode = hashCode * 59 + this.auth_transaction_id.GetHashCode();
                if (this.gateway_order_id != null)
                    hashCode = hashCode * 59 + this.gateway_order_id.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
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
