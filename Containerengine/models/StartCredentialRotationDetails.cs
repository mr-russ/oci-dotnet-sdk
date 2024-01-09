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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// Properties that define a request to start credential rotation on a kubernetes cluster.
    /// </summary>
    public class StartCredentialRotationDetails 
    {
        
        /// <value>
        /// The duration in days(in ISO 8601 notation eg. P5D) after which the old credentials should be retired. Maximum delay duration is 14 days.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AutoCompletionDelayDuration is required.")]
        [JsonProperty(PropertyName = "autoCompletionDelayDuration")]
        public string AutoCompletionDelayDuration { get; set; }
        
    }
}
