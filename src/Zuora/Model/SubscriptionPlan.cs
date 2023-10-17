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
    /// Subscription plan information.
    /// </summary>
    [DataContract]
    public partial class SubscriptionPlan :  IEquatable<SubscriptionPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlan" /> class.
        /// </summary>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="subscription">The subscription to which this subscription plan belongs..</param>
        /// <param name="subscriptionId">Identifier of the subscription this subscription plan belongs to..</param>
        /// <param name="productId">Identifier of the product associated with this subscription plan..</param>
        /// <param name="planId">Identifier of the plan associated with this subscription plan..</param>
        /// <param name="plan">The plan object associated with this subscription plan..</param>
        /// <param name="product">The product associated with the subscription plan..</param>
        /// <param name="name">The name of the subscription plan..</param>
        public SubscriptionPlan(Dictionary<string, Object> customFields = default(Dictionary<string, Object>), Subscription subscription = default(Subscription), string subscriptionId = default(string), string productId = default(string), string planId = default(string), Plan plan = default(Plan), Product product = default(Product), string name = default(string))
        {
            this.subscription = subscription;
            this.plan = plan;
            this.product = product;
            this.custom_fields = customFields;
            this.subscription = subscription;
            this.subscription_id = subscriptionId;
            this.product_id = productId;
            this.plan_id = planId;
            this.plan = plan;
            this.product = product;
            this.name = name;
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
        /// The subscription to which this subscription plan belongs.
        /// </summary>
        /// <value>The subscription to which this subscription plan belongs.</value>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public Subscription subscription { get; set; }

        /// <summary>
        /// Identifier of the subscription this subscription plan belongs to.
        /// </summary>
        /// <value>Identifier of the subscription this subscription plan belongs to.</value>
        [DataMember(Name="subscription_id", EmitDefaultValue=false)]
        public string subscription_id { get; set; }

        /// <summary>
        /// Identifier of the product associated with this subscription plan.
        /// </summary>
        /// <value>Identifier of the product associated with this subscription plan.</value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public string product_id { get; set; }

        /// <summary>
        /// Identifier of the plan associated with this subscription plan.
        /// </summary>
        /// <value>Identifier of the plan associated with this subscription plan.</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string plan_id { get; set; }

        /// <summary>
        /// The plan object associated with this subscription plan.
        /// </summary>
        /// <value>The plan object associated with this subscription plan.</value>
        [DataMember(Name="plan", EmitDefaultValue=true)]
        public Plan plan { get; set; }

        /// <summary>
        /// The product associated with the subscription plan.
        /// </summary>
        /// <value>The product associated with the subscription plan.</value>
        [DataMember(Name="product", EmitDefaultValue=true)]
        public Product product { get; set; }

        /// <summary>
        /// The name of the subscription plan.
        /// </summary>
        /// <value>The name of the subscription plan.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// List of subscription items.
        /// </summary>
        /// <value>List of subscription items.</value>
        [DataMember(Name="subscription_items", EmitDefaultValue=true)]
        public SubscriptionItemListResponse subscription_items { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlan {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  updated_by_id: ").Append(updated_by_id).Append("\n");
            sb.Append("  updated_time: ").Append(updated_time).Append("\n");
            sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
            sb.Append("  created_time: ").Append(created_time).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  custom_objects: ").Append(custom_objects).Append("\n");
            sb.Append("  subscription: ").Append(subscription).Append("\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  product_id: ").Append(product_id).Append("\n");
            sb.Append("  plan_id: ").Append(plan_id).Append("\n");
            sb.Append("  plan: ").Append(plan).Append("\n");
            sb.Append("  product: ").Append(product).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  subscription_items: ").Append(subscription_items).Append("\n");
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
            return this.Equals(input as SubscriptionPlan);
        }

        /// <summary>
        /// Returns true if SubscriptionPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlan input)
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
                    this.subscription == input.subscription ||
                    (this.subscription != null &&
                    this.subscription.Equals(input.subscription))
                ) && 
                (
                    this.subscription_id == input.subscription_id ||
                    (this.subscription_id != null &&
                    this.subscription_id.Equals(input.subscription_id))
                ) && 
                (
                    this.product_id == input.product_id ||
                    (this.product_id != null &&
                    this.product_id.Equals(input.product_id))
                ) && 
                (
                    this.plan_id == input.plan_id ||
                    (this.plan_id != null &&
                    this.plan_id.Equals(input.plan_id))
                ) && 
                (
                    this.plan == input.plan ||
                    (this.plan != null &&
                    this.plan.Equals(input.plan))
                ) && 
                (
                    this.product == input.product ||
                    (this.product != null &&
                    this.product.Equals(input.product))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.subscription_items == input.subscription_items ||
                    (this.subscription_items != null &&
                    this.subscription_items.Equals(input.subscription_items))
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
                if (this.subscription != null)
                    hashCode = hashCode * 59 + this.subscription.GetHashCode();
                if (this.subscription_id != null)
                    hashCode = hashCode * 59 + this.subscription_id.GetHashCode();
                if (this.product_id != null)
                    hashCode = hashCode * 59 + this.product_id.GetHashCode();
                if (this.plan_id != null)
                    hashCode = hashCode * 59 + this.plan_id.GetHashCode();
                if (this.plan != null)
                    hashCode = hashCode * 59 + this.plan.GetHashCode();
                if (this.product != null)
                    hashCode = hashCode * 59 + this.product.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.subscription_items != null)
                    hashCode = hashCode * 59 + this.subscription_items.GetHashCode();
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
