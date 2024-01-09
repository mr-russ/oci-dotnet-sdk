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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// HCX on-premise license information summary.
    /// 
    /// </summary>
    public class HcxLicenseSummary 
    {
        
        /// <value>
        /// HCX on-premise license key value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivationKey is required.")]
        [JsonProperty(PropertyName = "activationKey")]
        public string ActivationKey { get; set; }
        
        /// <value>
        /// status of HCX on-premise license.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HcxLicenseStatus> Status { get; set; }
        
        /// <value>
        /// Name of the system that consumed the HCX on-premise license
        /// </value>
        [JsonProperty(PropertyName = "systemName")]
        public string SystemName { get; set; }
        
    }
}
