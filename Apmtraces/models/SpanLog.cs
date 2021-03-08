/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Definition of a log which is a key value pair of log data.
    /// 
    /// </summary>
    public class SpanLog 
    {
        
        /// <value>
        /// Key that specifies the log name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogKey is required.")]
        [JsonProperty(PropertyName = "logKey")]
        public string LogKey { get; set; }
        
        /// <value>
        /// Value associated with the log key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogValue is required.")]
        [JsonProperty(PropertyName = "logValue")]
        public string LogValue { get; set; }
        
    }
}
