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
    ///  Class for testing PricePatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PricePatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for PricePatchRequest
        //private PricePatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PricePatchRequest
            //instance = new PricePatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PricePatchRequest
        /// </summary>
        [Test]
        public void PricePatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PricePatchRequest
            //Assert.IsInstanceOf(typeof(PricePatchRequest), instance);
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
        /// Test the property 'recognized_revenue_accounting_code'
        /// </summary>
        [Test]
        public void recognized_revenue_accounting_codeTest()
        {
            // TODO unit test for the property 'recognized_revenue_accounting_code'
        }
        /// <summary>
        /// Test the property 'deferred_revenue_accounting_code'
        /// </summary>
        [Test]
        public void deferred_revenue_accounting_codeTest()
        {
            // TODO unit test for the property 'deferred_revenue_accounting_code'
        }
        /// <summary>
        /// Test the property 'recurring'
        /// </summary>
        [Test]
        public void recurringTest()
        {
            // TODO unit test for the property 'recurring'
        }
        /// <summary>
        /// Test the property 'start_event'
        /// </summary>
        [Test]
        public void start_eventTest()
        {
            // TODO unit test for the property 'start_event'
        }
        /// <summary>
        /// Test the property 'tiers_mode'
        /// </summary>
        [Test]
        public void tiers_modeTest()
        {
            // TODO unit test for the property 'tiers_mode'
        }
        /// <summary>
        /// Test the property 'apply_discount_to'
        /// </summary>
        [Test]
        public void apply_discount_toTest()
        {
            // TODO unit test for the property 'apply_discount_to'
        }
        /// <summary>
        /// Test the property 'tiers'
        /// </summary>
        [Test]
        public void tiersTest()
        {
            // TODO unit test for the property 'tiers'
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
        /// Test the property 'quantity'
        /// </summary>
        [Test]
        public void quantityTest()
        {
            // TODO unit test for the property 'quantity'
        }
        /// <summary>
        /// Test the property 'min_quantity'
        /// </summary>
        [Test]
        public void min_quantityTest()
        {
            // TODO unit test for the property 'min_quantity'
        }
        /// <summary>
        /// Test the property 'max_quantity'
        /// </summary>
        [Test]
        public void max_quantityTest()
        {
            // TODO unit test for the property 'max_quantity'
        }
        /// <summary>
        /// Test the property 'discount_level'
        /// </summary>
        [Test]
        public void discount_levelTest()
        {
            // TODO unit test for the property 'discount_level'
        }
        /// <summary>
        /// Test the property 'revenue_recognition_rule'
        /// </summary>
        [Test]
        public void revenue_recognition_ruleTest()
        {
            // TODO unit test for the property 'revenue_recognition_rule'
        }
        /// <summary>
        /// Test the property 'stacked_discount'
        /// </summary>
        [Test]
        public void stacked_discountTest()
        {
            // TODO unit test for the property 'stacked_discount'
        }
        /// <summary>
        /// Test the property 'amounts'
        /// </summary>
        [Test]
        public void amountsTest()
        {
            // TODO unit test for the property 'amounts'
        }
        /// <summary>
        /// Test the property 'unit_amounts'
        /// </summary>
        [Test]
        public void unit_amountsTest()
        {
            // TODO unit test for the property 'unit_amounts'
        }
        /// <summary>
        /// Test the property 'discount_amounts'
        /// </summary>
        [Test]
        public void discount_amountsTest()
        {
            // TODO unit test for the property 'discount_amounts'
        }
        /// <summary>
        /// Test the property 'discount_percent'
        /// </summary>
        [Test]
        public void discount_percentTest()
        {
            // TODO unit test for the property 'discount_percent'
        }
        /// <summary>
        /// Test the property 'price_base_interval'
        /// </summary>
        [Test]
        public void price_base_intervalTest()
        {
            // TODO unit test for the property 'price_base_interval'
        }
        /// <summary>
        /// Test the property 'overage'
        /// </summary>
        [Test]
        public void overageTest()
        {
            // TODO unit test for the property 'overage'
        }
        /// <summary>
        /// Test the property 'revenue'
        /// </summary>
        [Test]
        public void revenueTest()
        {
            // TODO unit test for the property 'revenue'
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
        /// Test the property 'prepayment'
        /// </summary>
        [Test]
        public void prepaymentTest()
        {
            // TODO unit test for the property 'prepayment'
        }
        /// <summary>
        /// Test the property 'drawdown'
        /// </summary>
        [Test]
        public void drawdownTest()
        {
            // TODO unit test for the property 'drawdown'
        }
        /// <summary>
        /// Test the property 'taxable'
        /// </summary>
        [Test]
        public void taxableTest()
        {
            // TODO unit test for the property 'taxable'
        }

    }

}
