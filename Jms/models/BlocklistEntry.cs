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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// An entry for blocklist to describe blocked operation and reason.
    /// </summary>
    public class BlocklistEntry 
    {
        
        /// <value>
        /// The operation type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operation is required.")]
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationType> Operation { get; set; }
        
        /// <value>
        /// The reason why the operation is blocklisted.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Reason is required.")]
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        
    }
}
