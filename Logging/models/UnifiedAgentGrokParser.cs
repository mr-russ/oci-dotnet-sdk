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


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// Grok parser.
    /// </summary>
    public class UnifiedAgentGrokParser : UnifiedAgentParser
    {
        
        /// <value>
        /// Grok name key.
        /// </value>
        [JsonProperty(PropertyName = "grokNameKey")]
        public string GrokNameKey { get; set; }
        
        /// <value>
        /// Grok failure key.
        /// </value>
        [JsonProperty(PropertyName = "grokFailureKey")]
        public string GrokFailureKey { get; set; }
        
        /// <value>
        /// Grok pattern object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Patterns is required.")]
        [JsonProperty(PropertyName = "patterns")]
        public System.Collections.Generic.List<GrokPattern> Patterns { get; set; }
        
        [JsonProperty(PropertyName = "parserType")]
        private readonly string parserType = "GROK";
    }
}
