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
    /// Address information used in billing details.
    /// </summary>
    [DataContract]
    public partial class AddressFieldDefinitions :  IEquatable<AddressFieldDefinitions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressFieldDefinitions" /> class.
        /// </summary>
        /// <param name="line1">Address line 1 (e.g., street, PO Box, or company name)..</param>
        /// <param name="line2">Address line 2 (e.g., apartment, suite, unit, or building)..</param>
        /// <param name="city">City, district, suburb, town, or village..</param>
        /// <param name="country">Two-letter country code (ISO 3166-1 alpha-2)..</param>
        /// <param name="state">The state, county, province, or region..</param>
        /// <param name="postalCode">ZIP or postal code..</param>
        public AddressFieldDefinitions(string line1 = default(string), string line2 = default(string), string city = default(string), string country = default(string), string state = default(string), string postalCode = default(string))
        {
            this.line1 = line1;
            this.line2 = line2;
            this.city = city;
            this.country = country;
            this.state = state;
            this.postal_code = postalCode;
        }

        /// <summary>
        /// Address line 1 (e.g., street, PO Box, or company name).
        /// </summary>
        /// <value>Address line 1 (e.g., street, PO Box, or company name).</value>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        public string line1 { get; set; }

        /// <summary>
        /// Address line 2 (e.g., apartment, suite, unit, or building).
        /// </summary>
        /// <value>Address line 2 (e.g., apartment, suite, unit, or building).</value>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        public string line2 { get; set; }

        /// <summary>
        /// City, district, suburb, town, or village.
        /// </summary>
        /// <value>City, district, suburb, town, or village.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string city { get; set; }

        /// <summary>
        /// Two-letter country code (ISO 3166-1 alpha-2).
        /// </summary>
        /// <value>Two-letter country code (ISO 3166-1 alpha-2).</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string country { get; set; }

        /// <summary>
        /// The state, county, province, or region.
        /// </summary>
        /// <value>The state, county, province, or region.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string state { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        /// <value>ZIP or postal code.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string postal_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressFieldDefinitions {\n");
            sb.Append("  line1: ").Append(line1).Append("\n");
            sb.Append("  line2: ").Append(line2).Append("\n");
            sb.Append("  city: ").Append(city).Append("\n");
            sb.Append("  country: ").Append(country).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  postal_code: ").Append(postal_code).Append("\n");
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
            return this.Equals(input as AddressFieldDefinitions);
        }

        /// <summary>
        /// Returns true if AddressFieldDefinitions instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressFieldDefinitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressFieldDefinitions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.line1 == input.line1 ||
                    (this.line1 != null &&
                    this.line1.Equals(input.line1))
                ) && 
                (
                    this.line2 == input.line2 ||
                    (this.line2 != null &&
                    this.line2.Equals(input.line2))
                ) && 
                (
                    this.city == input.city ||
                    (this.city != null &&
                    this.city.Equals(input.city))
                ) && 
                (
                    this.country == input.country ||
                    (this.country != null &&
                    this.country.Equals(input.country))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.postal_code == input.postal_code ||
                    (this.postal_code != null &&
                    this.postal_code.Equals(input.postal_code))
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
                if (this.line1 != null)
                    hashCode = hashCode * 59 + this.line1.GetHashCode();
                if (this.line2 != null)
                    hashCode = hashCode * 59 + this.line2.GetHashCode();
                if (this.city != null)
                    hashCode = hashCode * 59 + this.city.GetHashCode();
                if (this.country != null)
                    hashCode = hashCode * 59 + this.country.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.postal_code != null)
                    hashCode = hashCode * 59 + this.postal_code.GetHashCode();
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
