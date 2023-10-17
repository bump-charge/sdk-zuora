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
    ///  Class for testing CreditMemoItemCreateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreditMemoItemCreateRequestTests
    {
        // TODO uncomment below to declare an instance variable for CreditMemoItemCreateRequest
        //private CreditMemoItemCreateRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CreditMemoItemCreateRequest
            //instance = new CreditMemoItemCreateRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreditMemoItemCreateRequest
        /// </summary>
        [Test]
        public void CreditMemoItemCreateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" CreditMemoItemCreateRequest
            //Assert.IsInstanceOf(typeof(CreditMemoItemCreateRequest), instance);
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
        /// Test the property 'deferred_revenue_account'
        /// </summary>
        [Test]
        public void deferred_revenue_accountTest()
        {
            // TODO unit test for the property 'deferred_revenue_account'
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
        /// Test the property 'recognized_revenue_account'
        /// </summary>
        [Test]
        public void recognized_revenue_accountTest()
        {
            // TODO unit test for the property 'recognized_revenue_account'
        }
        /// <summary>
        /// Test the property 'revenue_recognition_rule_name'
        /// </summary>
        [Test]
        public void revenue_recognition_rule_nameTest()
        {
            // TODO unit test for the property 'revenue_recognition_rule_name'
        }
        /// <summary>
        /// Test the property 'quantity'
        /// </summary>
        [Test]
        public void quantityTest()
        {
            // TODO unit test for the property 'quantity'
        }
        /// <summary>
        /// Test the property 'service_end'
        /// </summary>
        [Test]
        public void service_endTest()
        {
            // TODO unit test for the property 'service_end'
        }
        /// <summary>
        /// Test the property 'service_start'
        /// </summary>
        [Test]
        public void service_startTest()
        {
            // TODO unit test for the property 'service_start'
        }
        /// <summary>
        /// Test the property 'sku'
        /// </summary>
        [Test]
        public void skuTest()
        {
            // TODO unit test for the property 'sku'
        }
        /// <summary>
        /// Test the property 'tax_inclusive'
        /// </summary>
        [Test]
        public void tax_inclusiveTest()
        {
            // TODO unit test for the property 'tax_inclusive'
        }
        /// <summary>
        /// Test the property 'unit_of_measure'
        /// </summary>
        [Test]
        public void unit_of_measureTest()
        {
            // TODO unit test for the property 'unit_of_measure'
        }
        /// <summary>
        /// Test the property 'taxation_items'
        /// </summary>
        [Test]
        public void taxation_itemsTest()
        {
            // TODO unit test for the property 'taxation_items'
        }
        /// <summary>
        /// Test the property 'unit_amount'
        /// </summary>
        [Test]
        public void unit_amountTest()
        {
            // TODO unit test for the property 'unit_amount'
        }
        /// <summary>
        /// Test the property 'price_id'
        /// </summary>
        [Test]
        public void price_idTest()
        {
            // TODO unit test for the property 'price_id'
        }
        /// <summary>
        /// Test the property 'purchase_order_number'
        /// </summary>
        [Test]
        public void purchase_order_numberTest()
        {
            // TODO unit test for the property 'purchase_order_number'
        }
        /// <summary>
        /// Test the property 'tax_code'
        /// </summary>
        [Test]
        public void tax_codeTest()
        {
            // TODO unit test for the property 'tax_code'
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
        /// Test the property 'invoice_item_id'
        /// </summary>
        [Test]
        public void invoice_item_idTest()
        {
            // TODO unit test for the property 'invoice_item_id'
        }
        /// <summary>
        /// Test the property 'accounting_code'
        /// </summary>
        [Test]
        public void accounting_codeTest()
        {
            // TODO unit test for the property 'accounting_code'
        }
        /// <summary>
        /// Test the property 'custom_fields'
        /// </summary>
        [Test]
        public void custom_fieldsTest()
        {
            // TODO unit test for the property 'custom_fields'
        }

    }

}
