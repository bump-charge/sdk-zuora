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
    ///  Class for testing AccountPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for AccountPatchRequest
        //private AccountPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountPatchRequest
            //instance = new AccountPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountPatchRequest
        /// </summary>
        [Test]
        public void AccountPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" AccountPatchRequest
            //Assert.IsInstanceOf(typeof(AccountPatchRequest), instance);
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
        /// Test the property 'account_number'
        /// </summary>
        [Test]
        public void account_numberTest()
        {
            // TODO unit test for the property 'account_number'
        }
        /// <summary>
        /// Test the property 'billing_document_settings'
        /// </summary>
        [Test]
        public void billing_document_settingsTest()
        {
            // TODO unit test for the property 'billing_document_settings'
        }
        /// <summary>
        /// Test the property 'batch'
        /// </summary>
        [Test]
        public void batchTest()
        {
            // TODO unit test for the property 'batch'
        }
        /// <summary>
        /// Test the property 'bill_cycle_day'
        /// </summary>
        [Test]
        public void bill_cycle_dayTest()
        {
            // TODO unit test for the property 'bill_cycle_day'
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
        /// Test the property 'sold_to'
        /// </summary>
        [Test]
        public void sold_toTest()
        {
            // TODO unit test for the property 'sold_to'
        }
        /// <summary>
        /// Test the property 'communication_profile_id'
        /// </summary>
        [Test]
        public void communication_profile_idTest()
        {
            // TODO unit test for the property 'communication_profile_id'
        }
        /// <summary>
        /// Test the property 'crm_id'
        /// </summary>
        [Test]
        public void crm_idTest()
        {
            // TODO unit test for the property 'crm_id'
        }
        /// <summary>
        /// Test the property 'default_payment_method_id'
        /// </summary>
        [Test]
        public void default_payment_method_idTest()
        {
            // TODO unit test for the property 'default_payment_method_id'
        }
        /// <summary>
        /// Test the property 'name'
        /// </summary>
        [Test]
        public void nameTest()
        {
            // TODO unit test for the property 'name'
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
        /// Test the property 'parent_account_id'
        /// </summary>
        [Test]
        public void parent_account_idTest()
        {
            // TODO unit test for the property 'parent_account_id'
        }
        /// <summary>
        /// Test the property 'payment_gateway'
        /// </summary>
        [Test]
        public void payment_gatewayTest()
        {
            // TODO unit test for the property 'payment_gateway'
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
        /// Test the property 'sequence_set_id'
        /// </summary>
        [Test]
        public void sequence_set_idTest()
        {
            // TODO unit test for the property 'sequence_set_id'
        }
        /// <summary>
        /// Test the property 'auto_pay'
        /// </summary>
        [Test]
        public void auto_payTest()
        {
            // TODO unit test for the property 'auto_pay'
        }
        /// <summary>
        /// Test the property 'tax_certificate'
        /// </summary>
        [Test]
        public void tax_certificateTest()
        {
            // TODO unit test for the property 'tax_certificate'
        }
        /// <summary>
        /// Test the property 'tax_identifier'
        /// </summary>
        [Test]
        public void tax_identifierTest()
        {
            // TODO unit test for the property 'tax_identifier'
        }
        /// <summary>
        /// Test the property 'currency'
        /// </summary>
        [Test]
        public void currencyTest()
        {
            // TODO unit test for the property 'currency'
        }
        /// <summary>
        /// Test the property 'sales_rep'
        /// </summary>
        [Test]
        public void sales_repTest()
        {
            // TODO unit test for the property 'sales_rep'
        }

    }

}
