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
    ///  Class for testing Refund
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RefundTests
    {
        // TODO uncomment below to declare an instance variable for Refund
        //private Refund instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Refund
            //instance = new Refund();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Refund
        /// </summary>
        [Test]
        public void RefundInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Refund
            //Assert.IsInstanceOf(typeof(Refund), instance);
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
        /// Test the property 'amount'
        /// </summary>
        [Test]
        public void amountTest()
        {
            // TODO unit test for the property 'amount'
        }
        /// <summary>
        /// Test the property 'description'
        /// </summary>
        [Test]
        public void descriptionTest()
        {
            // TODO unit test for the property 'description'
        }
        /// <summary>
        /// Test the property 'gateway_options'
        /// </summary>
        [Test]
        public void gateway_optionsTest()
        {
            // TODO unit test for the property 'gateway_options'
        }
        /// <summary>
        /// Test the property 'refund_date'
        /// </summary>
        [Test]
        public void refund_dateTest()
        {
            // TODO unit test for the property 'refund_date'
        }
        /// <summary>
        /// Test the property 'refund_method_type'
        /// </summary>
        [Test]
        public void refund_method_typeTest()
        {
            // TODO unit test for the property 'refund_method_type'
        }
        /// <summary>
        /// Test the property 'payment_id'
        /// </summary>
        [Test]
        public void payment_idTest()
        {
            // TODO unit test for the property 'payment_id'
        }
        /// <summary>
        /// Test the property 'reason_code'
        /// </summary>
        [Test]
        public void reason_codeTest()
        {
            // TODO unit test for the property 'reason_code'
        }
        /// <summary>
        /// Test the property 'statement_descriptor'
        /// </summary>
        [Test]
        public void statement_descriptorTest()
        {
            // TODO unit test for the property 'statement_descriptor'
        }
        /// <summary>
        /// Test the property 'statement_descriptor_phone'
        /// </summary>
        [Test]
        public void statement_descriptor_phoneTest()
        {
            // TODO unit test for the property 'statement_descriptor_phone'
        }
        /// <summary>
        /// Test the property 'external'
        /// </summary>
        [Test]
        public void externalTest()
        {
            // TODO unit test for the property 'external'
        }
        /// <summary>
        /// Test the property 'reference_id'
        /// </summary>
        [Test]
        public void reference_idTest()
        {
            // TODO unit test for the property 'reference_id'
        }
        /// <summary>
        /// Test the property 'second_reference_id'
        /// </summary>
        [Test]
        public void second_reference_idTest()
        {
            // TODO unit test for the property 'second_reference_id'
        }
        /// <summary>
        /// Test the property 'bank_account_account'
        /// </summary>
        [Test]
        public void bank_account_accountTest()
        {
            // TODO unit test for the property 'bank_account_account'
        }
        /// <summary>
        /// Test the property 'on_account_account'
        /// </summary>
        [Test]
        public void on_account_accountTest()
        {
            // TODO unit test for the property 'on_account_account'
        }
        /// <summary>
        /// Test the property 'unapplied_payment_account'
        /// </summary>
        [Test]
        public void unapplied_payment_accountTest()
        {
            // TODO unit test for the property 'unapplied_payment_account'
        }
        /// <summary>
        /// Test the property 'payment_method_id'
        /// </summary>
        [Test]
        public void payment_method_idTest()
        {
            // TODO unit test for the property 'payment_method_id'
        }
        /// <summary>
        /// Test the property 'credit_memo'
        /// </summary>
        [Test]
        public void credit_memoTest()
        {
            // TODO unit test for the property 'credit_memo'
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
        /// Test the property 'gateway_id'
        /// </summary>
        [Test]
        public void gateway_idTest()
        {
            // TODO unit test for the property 'gateway_id'
        }
        /// <summary>
        /// Test the property 'comment'
        /// </summary>
        [Test]
        public void commentTest()
        {
            // TODO unit test for the property 'comment'
        }
        /// <summary>
        /// Test the property 'gateway_response'
        /// </summary>
        [Test]
        public void gateway_responseTest()
        {
            // TODO unit test for the property 'gateway_response'
        }
        /// <summary>
        /// Test the property 'gateway_response_code'
        /// </summary>
        [Test]
        public void gateway_response_codeTest()
        {
            // TODO unit test for the property 'gateway_response_code'
        }
        /// <summary>
        /// Test the property 'gateway_state'
        /// </summary>
        [Test]
        public void gateway_stateTest()
        {
            // TODO unit test for the property 'gateway_state'
        }
        /// <summary>
        /// Test the property 'payment_method'
        /// </summary>
        [Test]
        public void payment_methodTest()
        {
            // TODO unit test for the property 'payment_method'
        }
        /// <summary>
        /// Test the property 'refund_number'
        /// </summary>
        [Test]
        public void refund_numberTest()
        {
            // TODO unit test for the property 'refund_number'
        }
        /// <summary>
        /// Test the property 'state_transitions'
        /// </summary>
        [Test]
        public void state_transitionsTest()
        {
            // TODO unit test for the property 'state_transitions'
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
        /// Test the property 'gateway_reconciliation_reason'
        /// </summary>
        [Test]
        public void gateway_reconciliation_reasonTest()
        {
            // TODO unit test for the property 'gateway_reconciliation_reason'
        }
        /// <summary>
        /// Test the property 'gateway_reconciliation_status'
        /// </summary>
        [Test]
        public void gateway_reconciliation_statusTest()
        {
            // TODO unit test for the property 'gateway_reconciliation_status'
        }
        /// <summary>
        /// Test the property 'payout_id'
        /// </summary>
        [Test]
        public void payout_idTest()
        {
            // TODO unit test for the property 'payout_id'
        }
        /// <summary>
        /// Test the property 'applied_to'
        /// </summary>
        [Test]
        public void applied_toTest()
        {
            // TODO unit test for the property 'applied_to'
        }

    }

}
