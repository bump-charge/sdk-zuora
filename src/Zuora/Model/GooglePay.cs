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
    /// If the &#x60;type&#x60; of the payment method is &#x60;apple_pay&#x60;, this hash contains details about the Apple Pay payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public partial class GooglePay :  IEquatable<GooglePay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooglePay" /> class.
        /// </summary>
        /// <param name="card">Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly..</param>
        /// <param name="token">A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method..</param>
        public GooglePay(GetCardList card = default(GetCardList), string token = default(string))
        {
            this.card = card;
            this.card = card;
            this.token = token;
        }

        /// <summary>
        /// Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.
        /// </summary>
        /// <value>Credit card information. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora.js instead of interacting with this API directly.</value>
        [DataMember(Name="card", EmitDefaultValue=true)]
        public GetCardList card { get; set; }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GooglePay {\n");
            sb.Append("  card: ").Append(card).Append("\n");
            sb.Append("  token: ").Append(token).Append("\n");
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
            return this.Equals(input as GooglePay);
        }

        /// <summary>
        /// Returns true if GooglePay instances are equal
        /// </summary>
        /// <param name="input">Instance of GooglePay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GooglePay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.card == input.card ||
                    (this.card != null &&
                    this.card.Equals(input.card))
                ) && 
                (
                    this.token == input.token ||
                    (this.token != null &&
                    this.token.Equals(input.token))
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
                if (this.card != null)
                    hashCode = hashCode * 59 + this.card.GetHashCode();
                if (this.token != null)
                    hashCode = hashCode * 59 + this.token.GetHashCode();
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
