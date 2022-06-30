/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.TenantmanagercontrolplaneService.Models
{
    /// <summary>
    /// Summary of subscription.
    /// </summary>
    public class SubscriptionSummary 
    {
        
        /// <value>
        /// OCID of the subscription details for a particular root compartment or tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Classic subscription ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClassicSubscriptionId is required.")]
        [JsonProperty(PropertyName = "classicSubscriptionId")]
        public string ClassicSubscriptionId { get; set; }
        
        /// <value>
        /// OCID of the compartment. Always a tenancy OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of subscription, such as 'CLOUDCM', 'SAAS', 'ERP', or 'CRM'.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// Denotes if the subscription is from classic systems or not.
        /// </value>
        [JsonProperty(PropertyName = "isClassicSubscription")]
        public System.Nullable<bool> IsClassicSubscription { get; set; }
        
        /// <value>
        /// The pay model of the subscription, such as 'Pay as you go' or 'Monthly'.
        /// </value>
        [JsonProperty(PropertyName = "paymentModel")]
        public string PaymentModel { get; set; }
        
        /// <value>
        /// Region for the subscription.
        /// </value>
        [JsonProperty(PropertyName = "regionAssignment")]
        public string RegionAssignment { get; set; }
        
        /// <value>
        /// Lifecycle state of the subscription.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SubscriptionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Subscription start time.
        /// </value>
        [JsonProperty(PropertyName = "startDate")]
        public System.Nullable<System.DateTime> StartDate { get; set; }
        
        /// <value>
        /// Subscription end time.
        /// </value>
        [JsonProperty(PropertyName = "endDate")]
        public System.Nullable<System.DateTime> EndDate { get; set; }
        
        /// <value>
        /// Date-time when subscription is updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Date-time when subscription is created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
