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


namespace Oci.ComputeinstanceagentService.Models
{
    /// <summary>
    /// The execution output from a command when returned in plain text.
    /// </summary>
    public class InstanceAgentCommandExecutionOutputViaTextDetails : InstanceAgentCommandExecutionOutputContent
    {
        
        /// <value>
        /// The command output.
        /// </value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// SHA-256 checksum value of the text content.
        /// </value>
        [JsonProperty(PropertyName = "textSha256")]
        public string TextSha256 { get; set; }
        
        [JsonProperty(PropertyName = "outputType")]
        private readonly string outputType = "TEXT";
    }
}
