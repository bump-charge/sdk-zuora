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
    ///  Class for testing PaymentRunPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentRunPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for PaymentRunPatchRequest
        //private PaymentRunPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PaymentRunPatchRequest
            //instance = new PaymentRunPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentRunPatchRequest
        /// </summary>
        [Test]
        public void PaymentRunPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PaymentRunPatchRequest
            //Assert.IsInstanceOf(typeof(PaymentRunPatchRequest), instance);
        }


        /// <summary>
        /// Test the property 'apply_credit_memos'
        /// </summary>
        [Test]
        public void apply_credit_memosTest()
        {
            // TODO unit test for the property 'apply_credit_memos'
        }
        /// <summary>
        /// Test the property 'apply_unapplied_payments'
        /// </summary>
        [Test]
        public void apply_unapplied_paymentsTest()
        {
            // TODO unit test for the property 'apply_unapplied_payments'
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
        /// Test the property 'bill_run_id'
        /// </summary>
        [Test]
        public void bill_run_idTest()
        {
            // TODO unit test for the property 'bill_run_id'
        }
        /// <summary>
        /// Test the property 'collect_payment'
        /// </summary>
        [Test]
        public void collect_paymentTest()
        {
            // TODO unit test for the property 'collect_payment'
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
        /// Test the property 'consolidated_payment'
        /// </summary>
        [Test]
        public void consolidated_paymentTest()
        {
            // TODO unit test for the property 'consolidated_payment'
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
        /// Test the property 'payment_run_date'
        /// </summary>
        [Test]
        public void payment_run_dateTest()
        {
            // TODO unit test for the property 'payment_run_date'
        }
        /// <summary>
        /// Test the property 'target_date'
        /// </summary>
        [Test]
        public void target_dateTest()
        {
            // TODO unit test for the property 'target_date'
        }

    }

}
