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
    /// PauseSubscriptionRequest
    /// </summary>
    [DataContract]
    public partial class PauseSubscriptionRequest :  IEquatable<PauseSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Can be either the end of the current billing period or a specific date.
        /// </summary>
        /// <value>Can be either the end of the current billing period or a specific date.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PauseAtEnum
        {
            /// <summary>
            /// Enum Invoiceperiodend for value: invoice_period_end
            /// </summary>
            [EnumMember(Value = "invoice_period_end")]
            Invoiceperiodend = 1

        }

        /// <summary>
        /// Can be either the end of the current billing period or a specific date.
        /// </summary>
        /// <value>Can be either the end of the current billing period or a specific date.</value>
        [DataMember(Name="pause_at", EmitDefaultValue=false)]
        public PauseAtEnum? pause_at { get; set; }
        /// <summary>
        /// Unit in which the pause duration is defined. One of day, week, month or year.
        /// </summary>
        /// <value>Unit in which the pause duration is defined. One of day, week, month or year.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PauseIntervalEnum
        {
            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 1,

            /// <summary>
            /// Enum Day for value: day
            /// </summary>
            [EnumMember(Value = "day")]
            Day = 2,

            /// <summary>
            /// Enum Year for value: year
            /// </summary>
            [EnumMember(Value = "year")]
            Year = 3,

            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 4

        }

        /// <summary>
        /// Unit in which the pause duration is defined. One of day, week, month or year.
        /// </summary>
        /// <value>Unit in which the pause duration is defined. One of day, week, month or year.</value>
        [DataMember(Name="pause_interval", EmitDefaultValue=false)]
        public PauseIntervalEnum? pause_interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PauseSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="pauseDate">Date on which the subscription is paused..</param>
        /// <param name="pauseAt">Can be either the end of the current billing period or a specific date..</param>
        /// <param name="pauseIntervalCount">The number of intervals in a duration where the subscription is paused. For example, pause_interval&#x3D;year and pause_interval_count&#x3D;1 represents a 1-year pause..</param>
        /// <param name="pauseInterval">Unit in which the pause duration is defined. One of day, week, month or year..</param>
        /// <param name="resumeBehavior">resumeBehavior.</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public PauseSubscriptionRequest(DateTime pauseDate = default(DateTime), PauseAtEnum? pauseAt = default(PauseAtEnum?), decimal pauseIntervalCount = default(decimal), PauseIntervalEnum? pauseInterval = default(PauseIntervalEnum?), ResumeSubscriptionRequest resumeBehavior = default(ResumeSubscriptionRequest), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.pause_date = pauseDate;
            this.pause_at = pauseAt;
            this.pause_interval_count = pauseIntervalCount;
            this.pause_interval = pauseInterval;
            this.resume_behavior = resumeBehavior;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// Date on which the subscription is paused.
        /// </summary>
        /// <value>Date on which the subscription is paused.</value>
        [DataMember(Name="pause_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime pause_date { get; set; }


        /// <summary>
        /// The number of intervals in a duration where the subscription is paused. For example, pause_interval&#x3D;year and pause_interval_count&#x3D;1 represents a 1-year pause.
        /// </summary>
        /// <value>The number of intervals in a duration where the subscription is paused. For example, pause_interval&#x3D;year and pause_interval_count&#x3D;1 represents a 1-year pause.</value>
        [DataMember(Name="pause_interval_count", EmitDefaultValue=false)]
        public decimal pause_interval_count { get; set; }


        /// <summary>
        /// Gets or Sets resume_behavior
        /// </summary>
        [DataMember(Name="resume_behavior", EmitDefaultValue=false)]
        public ResumeSubscriptionRequest resume_behavior { get; set; }

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
            sb.Append("class PauseSubscriptionRequest {\n");
            sb.Append("  pause_date: ").Append(pause_date).Append("\n");
            sb.Append("  pause_at: ").Append(pause_at).Append("\n");
            sb.Append("  pause_interval_count: ").Append(pause_interval_count).Append("\n");
            sb.Append("  pause_interval: ").Append(pause_interval).Append("\n");
            sb.Append("  resume_behavior: ").Append(resume_behavior).Append("\n");
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
            return this.Equals(input as PauseSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if PauseSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PauseSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PauseSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.pause_date == input.pause_date ||
                    (this.pause_date != null &&
                    this.pause_date.Equals(input.pause_date))
                ) && 
                (
                    this.pause_at == input.pause_at ||
                    (this.pause_at != null &&
                    this.pause_at.Equals(input.pause_at))
                ) && 
                (
                    this.pause_interval_count == input.pause_interval_count ||
                    (this.pause_interval_count != null &&
                    this.pause_interval_count.Equals(input.pause_interval_count))
                ) && 
                (
                    this.pause_interval == input.pause_interval ||
                    (this.pause_interval != null &&
                    this.pause_interval.Equals(input.pause_interval))
                ) && 
                (
                    this.resume_behavior == input.resume_behavior ||
                    (this.resume_behavior != null &&
                    this.resume_behavior.Equals(input.resume_behavior))
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
                if (this.pause_date != null)
                    hashCode = hashCode * 59 + this.pause_date.GetHashCode();
                if (this.pause_at != null)
                    hashCode = hashCode * 59 + this.pause_at.GetHashCode();
                if (this.pause_interval_count != null)
                    hashCode = hashCode * 59 + this.pause_interval_count.GetHashCode();
                if (this.pause_interval != null)
                    hashCode = hashCode * 59 + this.pause_interval.GetHashCode();
                if (this.resume_behavior != null)
                    hashCode = hashCode * 59 + this.resume_behavior.GetHashCode();
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
