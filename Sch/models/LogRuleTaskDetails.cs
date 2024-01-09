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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The log rule task.
    /// For configuration instructions, see
    /// [To create a service connector](https://docs.cloud.oracle.com/iaas/Content/service-connector-hub/managingconnectors.htm#create).
    /// 
    /// </summary>
    public class LogRuleTaskDetails : TaskDetails
    {
        
        /// <value>
        /// A filter or mask to limit the source used in the flow defined by the service connector.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "logRule";
    }
}
