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
    ///  Class for testing ItemTier
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ItemTierTests
    {
        // TODO uncomment below to declare an instance variable for ItemTier
        //private ItemTier instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ItemTier
            //instance = new ItemTier();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemTier
        /// </summary>
        [Test]
        public void ItemTierInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ItemTier
            //Assert.IsInstanceOf(typeof(ItemTier), instance);
        }


        /// <summary>
        /// Test the property 'up_to'
        /// </summary>
        [Test]
        public void up_toTest()
        {
            // TODO unit test for the property 'up_to'
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
        /// Test the property 'unit_amount'
        /// </summary>
        [Test]
        public void unit_amountTest()
        {
            // TODO unit test for the property 'unit_amount'
        }

    }

}
