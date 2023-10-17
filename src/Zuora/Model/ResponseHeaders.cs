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
    /// ResponseHeaders
    /// </summary>
    [DataContract]
    public partial class ResponseHeaders :  IEquatable<ResponseHeaders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHeaders" /> class.
        /// </summary>
        /// <param name="ratelimitLimit">The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information..</param>
        /// <param name="ratelimitRemaining">The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information..</param>
        /// <param name="ratelimitReset">The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information..</param>
        /// <param name="zuoraRequestId">Zuoraâ€™s internal identifier for this request..</param>
        /// <param name="zuoraTrackId">A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header. .</param>
        public ResponseHeaders(string ratelimitLimit = default(string), decimal ratelimitRemaining = default(decimal), decimal ratelimitReset = default(decimal), string zuoraRequestId = default(string), string zuoraTrackId = default(string))
        {
            this.ratelimit_limit = ratelimitLimit;
            this.ratelimit_remaining = ratelimitRemaining;
            this.ratelimit_reset = ratelimitReset;
            this.zuora_request_id = zuoraRequestId;
            this.zuora_track_id = zuoraTrackId;
        }

        /// <summary>
        /// The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The request limit quota for the time window closest to exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name="ratelimit-limit", EmitDefaultValue=false)]
        public string ratelimit_limit { get; set; }

        /// <summary>
        /// The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The number of requests remaining in the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name="ratelimit-remaining", EmitDefaultValue=false)]
        public decimal ratelimit_remaining { get; set; }

        /// <summary>
        /// The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.
        /// </summary>
        /// <value>The number of seconds until the quota resets for the time window closest to quota exhaustion. See [rate limits](https://www.zuora.com/developer/rest-api/general-concepts/rate-concurrency-limits/#rate-limits) for more information.</value>
        [DataMember(Name="ratelimit-reset", EmitDefaultValue=false)]
        public decimal ratelimit_reset { get; set; }

        /// <summary>
        /// Zuoraâ€™s internal identifier for this request.
        /// </summary>
        /// <value>Zuoraâ€™s internal identifier for this request.</value>
        [DataMember(Name="zuora-request-id", EmitDefaultValue=false)]
        public string zuora_request_id { get; set; }

        /// <summary>
        /// A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header. 
        /// </summary>
        /// <value>A user-supplied identifier for this request. If you supply a &#x60;zuora-track-id&#x60; as a request header, Zuora returns the &#x60;zuora-track-id&#x60; as a response header. </value>
        [DataMember(Name="zuora-track-id", EmitDefaultValue=false)]
        public string zuora_track_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseHeaders {\n");
            sb.Append("  ratelimit_limit: ").Append(ratelimit_limit).Append("\n");
            sb.Append("  ratelimit_remaining: ").Append(ratelimit_remaining).Append("\n");
            sb.Append("  ratelimit_reset: ").Append(ratelimit_reset).Append("\n");
            sb.Append("  zuora_request_id: ").Append(zuora_request_id).Append("\n");
            sb.Append("  zuora_track_id: ").Append(zuora_track_id).Append("\n");
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
            return this.Equals(input as ResponseHeaders);
        }

        /// <summary>
        /// Returns true if ResponseHeaders instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseHeaders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseHeaders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ratelimit_limit == input.ratelimit_limit ||
                    (this.ratelimit_limit != null &&
                    this.ratelimit_limit.Equals(input.ratelimit_limit))
                ) && 
                (
                    this.ratelimit_remaining == input.ratelimit_remaining ||
                    (this.ratelimit_remaining != null &&
                    this.ratelimit_remaining.Equals(input.ratelimit_remaining))
                ) && 
                (
                    this.ratelimit_reset == input.ratelimit_reset ||
                    (this.ratelimit_reset != null &&
                    this.ratelimit_reset.Equals(input.ratelimit_reset))
                ) && 
                (
                    this.zuora_request_id == input.zuora_request_id ||
                    (this.zuora_request_id != null &&
                    this.zuora_request_id.Equals(input.zuora_request_id))
                ) && 
                (
                    this.zuora_track_id == input.zuora_track_id ||
                    (this.zuora_track_id != null &&
                    this.zuora_track_id.Equals(input.zuora_track_id))
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
                if (this.ratelimit_limit != null)
                    hashCode = hashCode * 59 + this.ratelimit_limit.GetHashCode();
                if (this.ratelimit_remaining != null)
                    hashCode = hashCode * 59 + this.ratelimit_remaining.GetHashCode();
                if (this.ratelimit_reset != null)
                    hashCode = hashCode * 59 + this.ratelimit_reset.GetHashCode();
                if (this.zuora_request_id != null)
                    hashCode = hashCode * 59 + this.zuora_request_id.GetHashCode();
                if (this.zuora_track_id != null)
                    hashCode = hashCode * 59 + this.zuora_track_id.GetHashCode();
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
