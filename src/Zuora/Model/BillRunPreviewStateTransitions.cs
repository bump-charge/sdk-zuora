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
    /// The timestamps at which the object&#39;s state was updated.
    /// </summary>
    [DataContract]
    public partial class BillRunPreviewStateTransitions :  IEquatable<BillRunPreviewStateTransitions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillRunPreviewStateTransitions" /> class.
        /// </summary>
        /// <param name="completeTime">The time when the bill run preview completed..</param>
        /// <param name="processingStartTime">The time when the bill run preview started..</param>
        public BillRunPreviewStateTransitions(DateTime completeTime = default(DateTime), DateTime processingStartTime = default(DateTime))
        {
            this.complete_time = completeTime;
            this.processing_start_time = processingStartTime;
        }

        /// <summary>
        /// The time when the bill run preview completed.
        /// </summary>
        /// <value>The time when the bill run preview completed.</value>
        [DataMember(Name="complete_time", EmitDefaultValue=false)]
        public DateTime complete_time { get; set; }

        /// <summary>
        /// The time when the bill run preview started.
        /// </summary>
        /// <value>The time when the bill run preview started.</value>
        [DataMember(Name="processing_start_time", EmitDefaultValue=false)]
        public DateTime processing_start_time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillRunPreviewStateTransitions {\n");
            sb.Append("  complete_time: ").Append(complete_time).Append("\n");
            sb.Append("  processing_start_time: ").Append(processing_start_time).Append("\n");
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
            return this.Equals(input as BillRunPreviewStateTransitions);
        }

        /// <summary>
        /// Returns true if BillRunPreviewStateTransitions instances are equal
        /// </summary>
        /// <param name="input">Instance of BillRunPreviewStateTransitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillRunPreviewStateTransitions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.complete_time == input.complete_time ||
                    (this.complete_time != null &&
                    this.complete_time.Equals(input.complete_time))
                ) && 
                (
                    this.processing_start_time == input.processing_start_time ||
                    (this.processing_start_time != null &&
                    this.processing_start_time.Equals(input.processing_start_time))
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
                if (this.complete_time != null)
                    hashCode = hashCode * 59 + this.complete_time.GetHashCode();
                if (this.processing_start_time != null)
                    hashCode = hashCode * 59 + this.processing_start_time.GetHashCode();
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
