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
    ///  Class for testing DebitMemo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DebitMemoTests
    {
        // TODO uncomment below to declare an instance variable for DebitMemo
        //private DebitMemo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DebitMemo
            //instance = new DebitMemo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DebitMemo
        /// </summary>
        [Test]
        public void DebitMemoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" DebitMemo
            //Assert.IsInstanceOf(typeof(DebitMemo), instance);
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
        /// Test the property 'account_id'
        /// </summary>
        [Test]
        public void account_idTest()
        {
            // TODO unit test for the property 'account_id'
        }
        /// <summary>
        /// Test the property 'account_number'
        /// </summary>
        [Test]
        public void account_numberTest()
        {
            // TODO unit test for the property 'account_number'
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
        /// Test the property 'due_date'
        /// </summary>
        [Test]
        public void due_dateTest()
        {
            // TODO unit test for the property 'due_date'
        }
        /// <summary>
        /// Test the property 'document_date'
        /// </summary>
        [Test]
        public void document_dateTest()
        {
            // TODO unit test for the property 'document_date'
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
        /// Test the property 'invoice_id'
        /// </summary>
        [Test]
        public void invoice_idTest()
        {
            // TODO unit test for the property 'invoice_id'
        }
        /// <summary>
        /// Test the property 'transfer_to_accounting'
        /// </summary>
        [Test]
        public void transfer_to_accountingTest()
        {
            // TODO unit test for the property 'transfer_to_accounting'
        }
        /// <summary>
        /// Test the property 'exclude_from_auto_apply_rules'
        /// </summary>
        [Test]
        public void exclude_from_auto_apply_rulesTest()
        {
            // TODO unit test for the property 'exclude_from_auto_apply_rules'
        }
        /// <summary>
        /// Test the property 'pay'
        /// </summary>
        [Test]
        public void payTest()
        {
            // TODO unit test for the property 'pay'
        }
        /// <summary>
        /// Test the property 'debit_memo_number'
        /// </summary>
        [Test]
        public void debit_memo_numberTest()
        {
            // TODO unit test for the property 'debit_memo_number'
        }
        /// <summary>
        /// Test the property 'amount_refunded'
        /// </summary>
        [Test]
        public void amount_refundedTest()
        {
            // TODO unit test for the property 'amount_refunded'
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
        /// Test the property 'posted_by_id'
        /// </summary>
        [Test]
        public void posted_by_idTest()
        {
            // TODO unit test for the property 'posted_by_id'
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
        /// Test the property 'account'
        /// </summary>
        [Test]
        public void accountTest()
        {
            // TODO unit test for the property 'account'
        }
        /// <summary>
        /// Test the property 'items'
        /// </summary>
        [Test]
        public void itemsTest()
        {
            // TODO unit test for the property 'items'
        }
        /// <summary>
        /// Test the property 'total'
        /// </summary>
        [Test]
        public void totalTest()
        {
            // TODO unit test for the property 'total'
        }
        /// <summary>
        /// Test the property 'subtotal'
        /// </summary>
        [Test]
        public void subtotalTest()
        {
            // TODO unit test for the property 'subtotal'
        }
        /// <summary>
        /// Test the property 'tax'
        /// </summary>
        [Test]
        public void taxTest()
        {
            // TODO unit test for the property 'tax'
        }
        /// <summary>
        /// Test the property 'balance'
        /// </summary>
        [Test]
        public void balanceTest()
        {
            // TODO unit test for the property 'balance'
        }
        /// <summary>
        /// Test the property 'remaining_balance'
        /// </summary>
        [Test]
        public void remaining_balanceTest()
        {
            // TODO unit test for the property 'remaining_balance'
        }
        /// <summary>
        /// Test the property 'amount_paid'
        /// </summary>
        [Test]
        public void amount_paidTest()
        {
            // TODO unit test for the property 'amount_paid'
        }
        /// <summary>
        /// Test the property 'paid'
        /// </summary>
        [Test]
        public void paidTest()
        {
            // TODO unit test for the property 'paid'
        }
        /// <summary>
        /// Test the property 'past_due'
        /// </summary>
        [Test]
        public void past_dueTest()
        {
            // TODO unit test for the property 'past_due'
        }
        /// <summary>
        /// Test the property 'bill_to_id'
        /// </summary>
        [Test]
        public void bill_to_idTest()
        {
            // TODO unit test for the property 'bill_to_id'
        }
        /// <summary>
        /// Test the property 'payment_terms'
        /// </summary>
        [Test]
        public void payment_termsTest()
        {
            // TODO unit test for the property 'payment_terms'
        }
        /// <summary>
        /// Test the property 'bill_to'
        /// </summary>
        [Test]
        public void bill_toTest()
        {
            // TODO unit test for the property 'bill_to'
        }
        /// <summary>
        /// Test the property 'billing_document_settings'
        /// </summary>
        [Test]
        public void billing_document_settingsTest()
        {
            // TODO unit test for the property 'billing_document_settings'
        }

    }

}
