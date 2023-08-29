/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Configuration details for the BROWSER monitor type.
    /// </summary>
    public class BrowserMonitorConfiguration : MonitorConfiguration
    {
        
        /// <value>
        /// If certificate validation is enabled, then the call will fail in case of certification errors.
        /// </value>
        [JsonProperty(PropertyName = "isCertificateValidationEnabled")]
        public System.Nullable<bool> IsCertificateValidationEnabled { get; set; }
        
        /// <value>
        /// If disabled, auto snapshots are not collected.
        /// </value>
        [JsonProperty(PropertyName = "isDefaultSnapshotEnabled")]
        public System.Nullable<bool> IsDefaultSnapshotEnabled { get; set; }
        
        /// <value>
        /// Verifies all the search strings present in the response.
        /// If any search string is not present in the response, then it will be considered as a failure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "verifyTexts")]
        public System.Collections.Generic.List<VerifyText> VerifyTexts { get; set; }
        
        /// <value>
        /// Expected HTTP response codes. For status code range, set values such as 2xx, 3xx.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "verifyResponseCodes")]
        public System.Collections.Generic.List<string> VerifyResponseCodes { get; set; }
        
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "BROWSER_CONFIG";
    }
}
