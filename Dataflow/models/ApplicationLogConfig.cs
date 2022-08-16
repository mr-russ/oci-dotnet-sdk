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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// Logging details of Application logs for Data Flow Run.
    /// 
    /// </summary>
    public class ApplicationLogConfig 
    {
        
        /// <value>
        /// The log group id for where log objects will be for Data Flow Runs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogGroupId is required.")]
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// The log id of the log object the Application Logs of Data Flow Run will be shipped to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogId is required.")]
        [JsonProperty(PropertyName = "logId")]
        public string LogId { get; set; }
        
    }
}
