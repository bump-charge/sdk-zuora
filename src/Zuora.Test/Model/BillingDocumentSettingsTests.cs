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
    ///  Class for testing BillingDocumentSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BillingDocumentSettingsTests
    {
        // TODO uncomment below to declare an instance variable for BillingDocumentSettings
        //private BillingDocumentSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BillingDocumentSettings
            //instance = new BillingDocumentSettings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingDocumentSettings
        /// </summary>
        [Test]
        public void BillingDocumentSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" BillingDocumentSettings
            //Assert.IsInstanceOf(typeof(BillingDocumentSettings), instance);
        }


        /// <summary>
        /// Test the property 'credit_memo_template_id'
        /// </summary>
        [Test]
        public void credit_memo_template_idTest()
        {
            // TODO unit test for the property 'credit_memo_template_id'
        }
        /// <summary>
        /// Test the property 'debit_memo_template_id'
        /// </summary>
        [Test]
        public void debit_memo_template_idTest()
        {
            // TODO unit test for the property 'debit_memo_template_id'
        }
        /// <summary>
        /// Test the property 'email_documents'
        /// </summary>
        [Test]
        public void email_documentsTest()
        {
            // TODO unit test for the property 'email_documents'
        }
        /// <summary>
        /// Test the property 'print_documents'
        /// </summary>
        [Test]
        public void print_documentsTest()
        {
            // TODO unit test for the property 'print_documents'
        }
        /// <summary>
        /// Test the property 'invoice_template_id'
        /// </summary>
        [Test]
        public void invoice_template_idTest()
        {
            // TODO unit test for the property 'invoice_template_id'
        }
        /// <summary>
        /// Test the property 'additional_email'
        /// </summary>
        [Test]
        public void additional_emailTest()
        {
            // TODO unit test for the property 'additional_email'
        }

    }

}
