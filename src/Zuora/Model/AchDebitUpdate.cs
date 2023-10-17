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
    /// AchDebitUpdate
    /// </summary>
    [DataContract]
    public partial class AchDebitUpdate :  IEquatable<AchDebitUpdate>, IValidatableObject
    {
        /// <summary>
        /// The type of bank account associated with the payment method.
        /// </summary>
        /// <value>The type of bank account associated with the payment method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BankAccountTypeEnum
        {
            /// <summary>
            /// Enum Businesssaving for value: business_saving
            /// </summary>
            [EnumMember(Value = "business_saving")]
            Businesssaving = 1,

            /// <summary>
            /// Enum Businesschecking for value: business_checking
            /// </summary>
            [EnumMember(Value = "business_checking")]
            Businesschecking = 2,

            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 3,

            /// <summary>
            /// Enum Saving for value: saving
            /// </summary>
            [EnumMember(Value = "saving")]
            Saving = 4

        }

        /// <summary>
        /// The type of bank account associated with the payment method.
        /// </summary>
        /// <value>The type of bank account associated with the payment method.</value>
        [DataMember(Name="bank_account_type", EmitDefaultValue=false)]
        public BankAccountTypeEnum? bank_account_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AchDebitUpdate" /> class.
        /// </summary>
        /// <param name="mandate">mandate.</param>
        /// <param name="bankAbaCode">The nine-digit routing number or ABA number used by banks..</param>
        /// <param name="bankAccountName">The name of the account holder, which can be either a person or a company..</param>
        /// <param name="bankAccountType">The type of bank account associated with the payment method..</param>
        /// <param name="bankName">Name of the bank associated with this bank account..</param>
        public AchDebitUpdate(Mandate mandate = default(Mandate), string bankAbaCode = default(string), string bankAccountName = default(string), BankAccountTypeEnum? bankAccountType = default(BankAccountTypeEnum?), string bankName = default(string))
        {
            this.mandate = mandate;
            this.bank_aba_code = bankAbaCode;
            this.bank_account_name = bankAccountName;
            this.bank_account_type = bankAccountType;
            this.bank_name = bankName;
        }

        /// <summary>
        /// Gets or Sets mandate
        /// </summary>
        [DataMember(Name="mandate", EmitDefaultValue=false)]
        public Mandate mandate { get; set; }

        /// <summary>
        /// The nine-digit routing number or ABA number used by banks.
        /// </summary>
        /// <value>The nine-digit routing number or ABA number used by banks.</value>
        [DataMember(Name="bank_aba_code", EmitDefaultValue=false)]
        public string bank_aba_code { get; set; }

        /// <summary>
        /// The name of the account holder, which can be either a person or a company.
        /// </summary>
        /// <value>The name of the account holder, which can be either a person or a company.</value>
        [DataMember(Name="bank_account_name", EmitDefaultValue=false)]
        public string bank_account_name { get; set; }


        /// <summary>
        /// Name of the bank associated with this bank account.
        /// </summary>
        /// <value>Name of the bank associated with this bank account.</value>
        [DataMember(Name="bank_name", EmitDefaultValue=false)]
        public string bank_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchDebitUpdate {\n");
            sb.Append("  mandate: ").Append(mandate).Append("\n");
            sb.Append("  bank_aba_code: ").Append(bank_aba_code).Append("\n");
            sb.Append("  bank_account_name: ").Append(bank_account_name).Append("\n");
            sb.Append("  bank_account_type: ").Append(bank_account_type).Append("\n");
            sb.Append("  bank_name: ").Append(bank_name).Append("\n");
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
            return this.Equals(input as AchDebitUpdate);
        }

        /// <summary>
        /// Returns true if AchDebitUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AchDebitUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchDebitUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.mandate == input.mandate ||
                    (this.mandate != null &&
                    this.mandate.Equals(input.mandate))
                ) && 
                (
                    this.bank_aba_code == input.bank_aba_code ||
                    (this.bank_aba_code != null &&
                    this.bank_aba_code.Equals(input.bank_aba_code))
                ) && 
                (
                    this.bank_account_name == input.bank_account_name ||
                    (this.bank_account_name != null &&
                    this.bank_account_name.Equals(input.bank_account_name))
                ) && 
                (
                    this.bank_account_type == input.bank_account_type ||
                    (this.bank_account_type != null &&
                    this.bank_account_type.Equals(input.bank_account_type))
                ) && 
                (
                    this.bank_name == input.bank_name ||
                    (this.bank_name != null &&
                    this.bank_name.Equals(input.bank_name))
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
                if (this.mandate != null)
                    hashCode = hashCode * 59 + this.mandate.GetHashCode();
                if (this.bank_aba_code != null)
                    hashCode = hashCode * 59 + this.bank_aba_code.GetHashCode();
                if (this.bank_account_name != null)
                    hashCode = hashCode * 59 + this.bank_account_name.GetHashCode();
                if (this.bank_account_type != null)
                    hashCode = hashCode * 59 + this.bank_account_type.GetHashCode();
                if (this.bank_name != null)
                    hashCode = hashCode * 59 + this.bank_name.GetHashCode();
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
