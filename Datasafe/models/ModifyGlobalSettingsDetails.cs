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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details required to modify the global settings in Data Safe.
    /// </summary>
    public class ModifyGlobalSettingsDetails 
    {
        
        /// <value>
        /// The paid usage option chosen by the customer admin.
        /// </value>
        [JsonProperty(PropertyName = "isPaidUsage")]
        public System.Nullable<bool> IsPaidUsage { get; set; }
        
        /// <value>
        /// The online retention period in months.
        /// </value>
        [JsonProperty(PropertyName = "onlineRetentionPeriod")]
        public System.Nullable<int> OnlineRetentionPeriod { get; set; }
        
        /// <value>
        /// The offline retention period in months.
        /// </value>
        [JsonProperty(PropertyName = "offlineRetentionPeriod")]
        public System.Nullable<int> OfflineRetentionPeriod { get; set; }
        
    }
}
