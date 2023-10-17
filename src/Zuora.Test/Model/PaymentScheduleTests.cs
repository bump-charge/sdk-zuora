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
    ///  Class for testing PaymentSchedule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentScheduleTests
    {
        // TODO uncomment below to declare an instance variable for PaymentSchedule
        //private PaymentSchedule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PaymentSchedule
            //instance = new PaymentSchedule();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentSchedule
        /// </summary>
        [Test]
        public void PaymentScheduleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PaymentSchedule
            //Assert.IsInstanceOf(typeof(PaymentSchedule), instance);
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
        /// Test the property 'amount'
        /// </summary>
        [Test]
        public void amountTest()
        {
            // TODO unit test for the property 'amount'
        }
        /// <summary>
        /// Test the property 'period'
        /// </summary>
        [Test]
        public void periodTest()
        {
            // TODO unit test for the property 'period'
        }
        /// <summary>
        /// Test the property 'billing_document'
        /// </summary>
        [Test]
        public void billing_documentTest()
        {
            // TODO unit test for the property 'billing_document'
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
        /// Test the property 'description'
        /// </summary>
        [Test]
        public void descriptionTest()
        {
            // TODO unit test for the property 'description'
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
        /// Test the property 'number_of_payments'
        /// </summary>
        [Test]
        public void number_of_paymentsTest()
        {
            // TODO unit test for the property 'number_of_payments'
        }
        /// <summary>
        /// Test the property 'payment_gateway_id'
        /// </summary>
        [Test]
        public void payment_gateway_idTest()
        {
            // TODO unit test for the property 'payment_gateway_id'
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
        /// Test the property 'payment_schedule_number'
        /// </summary>
        [Test]
        public void payment_schedule_numberTest()
        {
            // TODO unit test for the property 'payment_schedule_number'
        }
        /// <summary>
        /// Test the property 'run_hour'
        /// </summary>
        [Test]
        public void run_hourTest()
        {
            // TODO unit test for the property 'run_hour'
        }
        /// <summary>
        /// Test the property 'standalone'
        /// </summary>
        [Test]
        public void standaloneTest()
        {
            // TODO unit test for the property 'standalone'
        }
        /// <summary>
        /// Test the property 'start_date'
        /// </summary>
        [Test]
        public void start_dateTest()
        {
            // TODO unit test for the property 'start_date'
        }
        /// <summary>
        /// Test the property 'total_amount'
        /// </summary>
        [Test]
        public void total_amountTest()
        {
            // TODO unit test for the property 'total_amount'
        }
        /// <summary>
        /// Test the property 'custom'
        /// </summary>
        [Test]
        public void customTest()
        {
            // TODO unit test for the property 'custom'
        }
        /// <summary>
        /// Test the property 'next_payment_date'
        /// </summary>
        [Test]
        public void next_payment_dateTest()
        {
            // TODO unit test for the property 'next_payment_date'
        }
        /// <summary>
        /// Test the property 'recent_payment_date'
        /// </summary>
        [Test]
        public void recent_payment_dateTest()
        {
            // TODO unit test for the property 'recent_payment_date'
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
        /// Test the property 'total_payments_errored'
        /// </summary>
        [Test]
        public void total_payments_erroredTest()
        {
            // TODO unit test for the property 'total_payments_errored'
        }
        /// <summary>
        /// Test the property 'total_payments_processed'
        /// </summary>
        [Test]
        public void total_payments_processedTest()
        {
            // TODO unit test for the property 'total_payments_processed'
        }
        /// <summary>
        /// Test the property 'payment_options'
        /// </summary>
        [Test]
        public void payment_optionsTest()
        {
            // TODO unit test for the property 'payment_options'
        }
        /// <summary>
        /// Test the property 'prepayment'
        /// </summary>
        [Test]
        public void prepaymentTest()
        {
            // TODO unit test for the property 'prepayment'
        }

    }

}
