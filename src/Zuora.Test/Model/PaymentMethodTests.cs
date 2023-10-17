/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Zuora.Api;
using Zuora.Model;
using Zuora.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Zuora.Test
{
    /// <summary>
    ///  Class for testing PaymentMethod
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentMethodTests
    {
        // TODO uncomment below to declare an instance variable for PaymentMethod
        //private PaymentMethod instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PaymentMethod
            //instance = new PaymentMethod();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentMethod
        /// </summary>
        [Test]
        public void PaymentMethodInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PaymentMethod
            //Assert.IsInstanceOf(typeof(PaymentMethod), instance);
        }


        /// <summary>
        /// Test the property 'id'
        /// </summary>
        [Test]
        public void idTest()
        {
            // TODO unit test for the property 'id'
        }
        /// <summary>
        /// Test the property 'updated_by_id'
        /// </summary>
        [Test]
        public void updated_by_idTest()
        {
            // TODO unit test for the property 'updated_by_id'
        }
        /// <summary>
        /// Test the property 'updated_time'
        /// </summary>
        [Test]
        public void updated_timeTest()
        {
            // TODO unit test for the property 'updated_time'
        }
        /// <summary>
        /// Test the property 'created_by_id'
        /// </summary>
        [Test]
        public void created_by_idTest()
        {
            // TODO unit test for the property 'created_by_id'
        }
        /// <summary>
        /// Test the property 'created_time'
        /// </summary>
        [Test]
        public void created_timeTest()
        {
            // TODO unit test for the property 'created_time'
        }
        /// <summary>
        /// Test the property 'custom_fields'
        /// </summary>
        [Test]
        public void custom_fieldsTest()
        {
            // TODO unit test for the property 'custom_fields'
        }
        /// <summary>
        /// Test the property 'custom_objects'
        /// </summary>
        [Test]
        public void custom_objectsTest()
        {
            // TODO unit test for the property 'custom_objects'
        }
        /// <summary>
        /// Test the property 'type'
        /// </summary>
        [Test]
        public void typeTest()
        {
            // TODO unit test for the property 'type'
        }
        /// <summary>
        /// Test the property 'custom_type'
        /// </summary>
        [Test]
        public void custom_typeTest()
        {
            // TODO unit test for the property 'custom_type'
        }
        /// <summary>
        /// Test the property 'account_id'
        /// </summary>
        [Test]
        public void account_idTest()
        {
            // TODO unit test for the property 'account_id'
        }
        /// <summary>
        /// Test the property 'account'
        /// </summary>
        [Test]
        public void accountTest()
        {
            // TODO unit test for the property 'account'
        }
        /// <summary>
        /// Test the property 'billing_details'
        /// </summary>
        [Test]
        public void billing_detailsTest()
        {
            // TODO unit test for the property 'billing_details'
        }
        /// <summary>
        /// Test the property 'maximum_payment_attempts'
        /// </summary>
        [Test]
        public void maximum_payment_attemptsTest()
        {
            // TODO unit test for the property 'maximum_payment_attempts'
        }
        /// <summary>
        /// Test the property 'payment_retry_interval'
        /// </summary>
        [Test]
        public void payment_retry_intervalTest()
        {
            // TODO unit test for the property 'payment_retry_interval'
        }
        /// <summary>
        /// Test the property 'device_session_id'
        /// </summary>
        [Test]
        public void device_session_idTest()
        {
            // TODO unit test for the property 'device_session_id'
        }
        /// <summary>
        /// Test the property 'ip_address'
        /// </summary>
        [Test]
        public void ip_addressTest()
        {
            // TODO unit test for the property 'ip_address'
        }
        /// <summary>
        /// Test the property 'bank_identification_number'
        /// </summary>
        [Test]
        public void bank_identification_numberTest()
        {
            // TODO unit test for the property 'bank_identification_number'
        }
        /// <summary>
        /// Test the property 'card'
        /// </summary>
        [Test]
        public void cardTest()
        {
            // TODO unit test for the property 'card'
        }
        /// <summary>
        /// Test the property 'paypal_express_native'
        /// </summary>
        [Test]
        public void paypal_express_nativeTest()
        {
            // TODO unit test for the property 'paypal_express_native'
        }
        /// <summary>
        /// Test the property 'paypal_express'
        /// </summary>
        [Test]
        public void paypal_expressTest()
        {
            // TODO unit test for the property 'paypal_express'
        }
        /// <summary>
        /// Test the property 'paypal_adaptive'
        /// </summary>
        [Test]
        public void paypal_adaptiveTest()
        {
            // TODO unit test for the property 'paypal_adaptive'
        }
        /// <summary>
        /// Test the property 'sepa_debit'
        /// </summary>
        [Test]
        public void sepa_debitTest()
        {
            // TODO unit test for the property 'sepa_debit'
        }
        /// <summary>
        /// Test the property 'cc_ref'
        /// </summary>
        [Test]
        public void cc_refTest()
        {
            // TODO unit test for the property 'cc_ref'
        }
        /// <summary>
        /// Test the property 'apple_pay'
        /// </summary>
        [Test]
        public void apple_payTest()
        {
            // TODO unit test for the property 'apple_pay'
        }
        /// <summary>
        /// Test the property 'google_pay'
        /// </summary>
        [Test]
        public void google_payTest()
        {
            // TODO unit test for the property 'google_pay'
        }
        /// <summary>
        /// Test the property 'ach_debit'
        /// </summary>
        [Test]
        public void ach_debitTest()
        {
            // TODO unit test for the property 'ach_debit'
        }
        /// <summary>
        /// Test the property 'betalings_debit'
        /// </summary>
        [Test]
        public void betalings_debitTest()
        {
            // TODO unit test for the property 'betalings_debit'
        }
        /// <summary>
        /// Test the property 'autogiro_debit'
        /// </summary>
        [Test]
        public void autogiro_debitTest()
        {
            // TODO unit test for the property 'autogiro_debit'
        }
        /// <summary>
        /// Test the property 'bacs_debit'
        /// </summary>
        [Test]
        public void bacs_debitTest()
        {
            // TODO unit test for the property 'bacs_debit'
        }
        /// <summary>
        /// Test the property 'au_becs_debit'
        /// </summary>
        [Test]
        public void au_becs_debitTest()
        {
            // TODO unit test for the property 'au_becs_debit'
        }
        /// <summary>
        /// Test the property 'nz_becs_debit'
        /// </summary>
        [Test]
        public void nz_becs_debitTest()
        {
            // TODO unit test for the property 'nz_becs_debit'
        }
        /// <summary>
        /// Test the property 'pad_debit'
        /// </summary>
        [Test]
        public void pad_debitTest()
        {
            // TODO unit test for the property 'pad_debit'
        }
        /// <summary>
        /// Test the property 'state'
        /// </summary>
        [Test]
        public void stateTest()
        {
            // TODO unit test for the property 'state'
        }
        /// <summary>
        /// Test the property 'auto_generated'
        /// </summary>
        [Test]
        public void auto_generatedTest()
        {
            // TODO unit test for the property 'auto_generated'
        }
        /// <summary>
        /// Test the property 'use_default_retry_rule'
        /// </summary>
        [Test]
        public void use_default_retry_ruleTest()
        {
            // TODO unit test for the property 'use_default_retry_rule'
        }
        /// <summary>
        /// Test the property 'existing_mandate'
        /// </summary>
        [Test]
        public void existing_mandateTest()
        {
            // TODO unit test for the property 'existing_mandate'
        }
        /// <summary>
        /// Test the property 'last_failed_sale_transaction_time'
        /// </summary>
        [Test]
        public void last_failed_sale_transaction_timeTest()
        {
            // TODO unit test for the property 'last_failed_sale_transaction_time'
        }
        /// <summary>
        /// Test the property 'last_transaction_time'
        /// </summary>
        [Test]
        public void last_transaction_timeTest()
        {
            // TODO unit test for the property 'last_transaction_time'
        }
        /// <summary>
        /// Test the property 'last_transaction_status'
        /// </summary>
        [Test]
        public void last_transaction_statusTest()
        {
            // TODO unit test for the property 'last_transaction_status'
        }
        /// <summary>
        /// Test the property 'number_of_consecutive_failures'
        /// </summary>
        [Test]
        public void number_of_consecutive_failuresTest()
        {
            // TODO unit test for the property 'number_of_consecutive_failures'
        }
        /// <summary>
        /// Test the property 'total_number_of_processed_payments'
        /// </summary>
        [Test]
        public void total_number_of_processed_paymentsTest()
        {
            // TODO unit test for the property 'total_number_of_processed_payments'
        }
        /// <summary>
        /// Test the property 'total_number_of_error_payments'
        /// </summary>
        [Test]
        public void total_number_of_error_paymentsTest()
        {
            // TODO unit test for the property 'total_number_of_error_payments'
        }

    }

}
