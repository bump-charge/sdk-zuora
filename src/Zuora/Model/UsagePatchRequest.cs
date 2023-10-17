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
    /// UsagePatchRequest
    /// </summary>
    [DataContract]
    public partial class UsagePatchRequest :  IEquatable<UsagePatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsagePatchRequest" /> class.
        /// </summary>
        /// <param name="endTime">The end time for which usage is recorded..</param>
        /// <param name="quantity">The number of units of this item..</param>
        /// <param name="startTime">The start time for which usage is recorded..</param>
        /// <param name="unitOfMeasure">Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public UsagePatchRequest(DateTime endTime = default(DateTime), decimal quantity = default(decimal), DateTime startTime = default(DateTime), string unitOfMeasure = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.end_time = endTime;
            this.quantity = quantity;
            this.start_time = startTime;
            this.unit_of_measure = unitOfMeasure;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// The end time for which usage is recorded.
        /// </summary>
        /// <value>The end time for which usage is recorded.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public DateTime end_time { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// The start time for which usage is recorded.
        /// </summary>
        /// <value>The start time for which usage is recorded.</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public DateTime start_time { get; set; }

        /// <summary>
        /// Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.
        /// </summary>
        /// <value>Specifies the units to measure usage. Units of measure are configured in Zuora Central. Your values depend on your configuration in Billing Settings.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsagePatchRequest {\n");
            sb.Append("  end_time: ").Append(end_time).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  start_time: ").Append(start_time).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
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
            return this.Equals(input as UsagePatchRequest);
        }

        /// <summary>
        /// Returns true if UsagePatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UsagePatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsagePatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.end_time == input.end_time ||
                    (this.end_time != null &&
                    this.end_time.Equals(input.end_time))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.start_time == input.start_time ||
                    (this.start_time != null &&
                    this.start_time.Equals(input.start_time))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
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
                if (this.end_time != null)
                    hashCode = hashCode * 59 + this.end_time.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.start_time != null)
                    hashCode = hashCode * 59 + this.start_time.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
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
