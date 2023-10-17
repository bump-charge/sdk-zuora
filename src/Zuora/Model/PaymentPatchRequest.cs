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
    /// PaymentPatchRequest
    /// </summary>
    [DataContract]
    public partial class PaymentPatchRequest :  IEquatable<PaymentPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentPatchRequest" /> class.
        /// </summary>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="referenceId">Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments..</param>
        public PaymentPatchRequest(Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string description = default(string), string referenceId = default(string))
        {
            this.custom_fields = customFields;
            this.description = description;
            this.reference_id = referenceId;
        }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; private set; }

        /// <summary>
        /// Unique identifier of the Zuora user who last updated the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who last updated the object</value>
        [DataMember(Name="updated_by_id", EmitDefaultValue=false)]
        public string updated_by_id { get; private set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO 8601 UTC format.</value>
        [DataMember(Name="updated_time", EmitDefaultValue=false)]
        public DateTime updated_time { get; private set; }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object</value>
        [DataMember(Name="created_by_id", EmitDefaultValue=false)]
        public string created_by_id { get; private set; }

        /// <summary>
        /// The date and time when the object was created in ISO 8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was created in ISO 8601 UTC format.</value>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public DateTime created_time { get; private set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields).
        /// </summary>
        /// <value>The custom fields associated with an object. For more information about custom fields, see [Manage custom fields](https://knowledgecenter.zuora.com/Central_Platform/Manage_Custom_Fields).</value>
        [DataMember(Name="custom_objects", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_objects { get; private set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string reference_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentPatchRequest {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  updated_by_id: ").Append(updated_by_id).Append("\n");
            sb.Append("  updated_time: ").Append(updated_time).Append("\n");
            sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
            sb.Append("  created_time: ").Append(created_time).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  custom_objects: ").Append(custom_objects).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  reference_id: ").Append(reference_id).Append("\n");
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
            return this.Equals(input as PaymentPatchRequest);
        }

        /// <summary>
        /// Returns true if PaymentPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.updated_by_id == input.updated_by_id ||
                    (this.updated_by_id != null &&
                    this.updated_by_id.Equals(input.updated_by_id))
                ) && 
                (
                    this.updated_time == input.updated_time ||
                    (this.updated_time != null &&
                    this.updated_time.Equals(input.updated_time))
                ) && 
                (
                    this.created_by_id == input.created_by_id ||
                    (this.created_by_id != null &&
                    this.created_by_id.Equals(input.created_by_id))
                ) && 
                (
                    this.created_time == input.created_time ||
                    (this.created_time != null &&
                    this.created_time.Equals(input.created_time))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.custom_objects == input.custom_objects ||
                    this.custom_objects != null &&
                    input.custom_objects != null &&
                    this.custom_objects.SequenceEqual(input.custom_objects)
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.reference_id == input.reference_id ||
                    (this.reference_id != null &&
                    this.reference_id.Equals(input.reference_id))
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.updated_by_id != null)
                    hashCode = hashCode * 59 + this.updated_by_id.GetHashCode();
                if (this.updated_time != null)
                    hashCode = hashCode * 59 + this.updated_time.GetHashCode();
                if (this.created_by_id != null)
                    hashCode = hashCode * 59 + this.created_by_id.GetHashCode();
                if (this.created_time != null)
                    hashCode = hashCode * 59 + this.created_time.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.custom_objects != null)
                    hashCode = hashCode * 59 + this.custom_objects.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.reference_id != null)
                    hashCode = hashCode * 59 + this.reference_id.GetHashCode();
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
