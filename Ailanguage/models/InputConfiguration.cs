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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// input documents configuration
    /// by default TXT files will be processed and this behaviour will not change in future after adding new types
    /// 
    /// </summary>
    public class InputConfiguration 
    {
        
        /// <value>
        /// Type of documents supported
        /// for this release only TXT,CSV  and one element is allowed here.
        /// for future scope this is marked as list
        /// 
        /// </value>
        [JsonProperty(PropertyName = "documentTypes")]
        public System.Collections.Generic.List<string> DocumentTypes { get; set; }
        
        /// <value>
        /// meta data about documents
        ///  For CSV valid JSON format is {\"CSV\" :{inputColumn: \"reviewDetails\", rowId: \"reviewId\", copyColumnsToOutput: [\"reviewId\" \"userId\"] , delimiter: \",\"}
        /// Note: In future if new file types added we will update here in documentation about input file meta data
        /// 
        /// </value>
        [JsonProperty(PropertyName = "configuration")]
        public System.Collections.Generic.Dictionary<string, DocumentsConfiguration> Configuration { get; set; }
        
    }
}
