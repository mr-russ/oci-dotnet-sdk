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


namespace Oci.ResourcesearchService.Models
{
    /// <summary>
    /// A request containing arbitrary text that must be present in the resource.
    /// </summary>
    public class FreeTextSearchDetails : SearchDetails
    {
        
        /// <value>
        /// The text to search for.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Text is required.")]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "FreeText";
    }
}
