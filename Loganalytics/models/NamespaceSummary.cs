/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// The is the namespace summary of a tenancy in Logging Analytics application
    /// </summary>
    public class NamespaceSummary 
    {
        
        /// <value>
        /// This is the namespace name of a tenancy
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The is the tenancy ID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// This indicates if the tenancy is onboarded to Logging Analytics
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOnboarded is required.")]
        [JsonProperty(PropertyName = "isOnboarded")]
        public System.Nullable<bool> IsOnboarded { get; set; }
        
        /// <value>
        /// This indicates if the log set feature is enabled for the tenancy
        /// </value>
        [JsonProperty(PropertyName = "isLogSetEnabled")]
        public System.Nullable<bool> IsLogSetEnabled { get; set; }
        
        /// <value>
        /// This indicates if data has ever been ingested for the tenancy in Logging Analytics
        /// </value>
        [JsonProperty(PropertyName = "isDataEverIngested")]
        public System.Nullable<bool> IsDataEverIngested { get; set; }
        
    }
}
