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
    /// This is the recall count statistics for a given tenant
    /// 
    /// </summary>
    public class RecallCount 
    {
        
        /// <value>
        /// This is the total number of recalls made so far
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecallCountProp is required.")]
        [JsonProperty(PropertyName = "recallCount")]
        public System.Nullable<int> RecallCountProp { get; set; }
        
        /// <value>
        /// This is the number of recalls that succeeded
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecallSucceeded is required.")]
        [JsonProperty(PropertyName = "recallSucceeded")]
        public System.Nullable<int> RecallSucceeded { get; set; }
        
        /// <value>
        /// This is the number of recalls that failed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecallFailed is required.")]
        [JsonProperty(PropertyName = "recallFailed")]
        public System.Nullable<int> RecallFailed { get; set; }
        
        /// <value>
        /// This is the number of recalls in pending state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecallPending is required.")]
        [JsonProperty(PropertyName = "recallPending")]
        public System.Nullable<int> RecallPending { get; set; }
        
        /// <value>
        /// This is the maximum number of recalls (including successful and pending recalls) allowed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecallLimit is required.")]
        [JsonProperty(PropertyName = "recallLimit")]
        public System.Nullable<int> RecallLimit { get; set; }
        
    }
}
