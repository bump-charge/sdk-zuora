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
    /// If the &#x60;type&#x60; of the payment method is &#x60;cc_ref&#x60;, this hash contains details about the Credit Card Reference Transactions payment method. See [Supported payment methods](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/L_Payment_Methods/A_Supported_Payment_Methods) for payment gateways that support this type of payment method.
    /// </summary>
    [DataContract]
    public partial class CcRef :  IEquatable<CcRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CcRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CcRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CcRef" /> class.
        /// </summary>
        /// <param name="secondToken">A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when &#x60;token&#x60; is being used to represent a gateway customer profile..</param>
        /// <param name="token">A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method. (required).</param>
        /// <param name="mandate">mandate.</param>
        /// <param name="card">card.</param>
        public CcRef(string secondToken = default(string), string token = default(string), Mandate mandate = default(Mandate), CcRefCard card = default(CcRefCard))
        {
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for CcRef and cannot be null");
            }
            else
            {
                this.token = token;
            }

            this.second_token = secondToken;
            this.mandate = mandate;
            this.card = card;
        }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when &#x60;token&#x60; is being used to represent a gateway customer profile.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data. This field is conditionally required only when &#x60;token&#x60; is being used to represent a gateway customer profile.</value>
        [DataMember(Name="second_token", EmitDefaultValue=false)]
        public string second_token { get; set; }

        /// <summary>
        /// A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method.
        /// </summary>
        /// <value>A gateway unique identifier that replaces sensitive payment method data or represents a gateway&#39;s unique customer profile. When &#x60;token&#x60; is used to represent a customer profile, &#x60;second_token&#x60; is conditionally required for representing the underlying tokenized payment method.</value>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string token { get; set; }

        /// <summary>
        /// Gets or Sets mandate
        /// </summary>
        [DataMember(Name="mandate", EmitDefaultValue=false)]
        public Mandate mandate { get; set; }

        /// <summary>
        /// Gets or Sets card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public CcRefCard card { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CcRef {\n");
            sb.Append("  second_token: ").Append(second_token).Append("\n");
            sb.Append("  token: ").Append(token).Append("\n");
            sb.Append("  mandate: ").Append(mandate).Append("\n");
            sb.Append("  card: ").Append(card).Append("\n");
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
            return this.Equals(input as CcRef);
        }

        /// <summary>
        /// Returns true if CcRef instances are equal
        /// </summary>
        /// <param name="input">Instance of CcRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CcRef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.second_token == input.second_token ||
                    (this.second_token != null &&
                    this.second_token.Equals(input.second_token))
                ) && 
                (
                    this.token == input.token ||
                    (this.token != null &&
                    this.token.Equals(input.token))
                ) && 
                (
                    this.mandate == input.mandate ||
                    (this.mandate != null &&
                    this.mandate.Equals(input.mandate))
                ) && 
                (
                    this.card == input.card ||
                    (this.card != null &&
                    this.card.Equals(input.card))
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
                if (this.second_token != null)
                    hashCode = hashCode * 59 + this.second_token.GetHashCode();
                if (this.token != null)
                    hashCode = hashCode * 59 + this.token.GetHashCode();
                if (this.mandate != null)
                    hashCode = hashCode * 59 + this.mandate.GetHashCode();
                if (this.card != null)
                    hashCode = hashCode * 59 + this.card.GetHashCode();
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
