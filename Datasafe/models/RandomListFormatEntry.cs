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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Random List masking format randomly selects values from a list of values
    /// to replace the original values. To learn more, check Random List in the
    /// Data Safe documentation. 
    /// 
    /// </summary>
    public class RandomListFormatEntry : FormatEntry
    {
        
        /// <value>
        /// A comma-separated list of values to be used to replace column values.
        /// The list can be of strings, numbers, or dates. The data type of each
        /// value in the list must be compatible with the data type of the column.
        /// The number of entries in the list cannot be more than 999. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RandomList is required.")]
        [JsonProperty(PropertyName = "randomList")]
        public System.Collections.Generic.List<string> RandomList { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RANDOM_LIST";
    }
}
