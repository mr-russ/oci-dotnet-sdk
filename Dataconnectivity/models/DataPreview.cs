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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// The data preview response.
    /// </summary>
    public class DataPreview 
    {
        
        /// <value>
        /// Name of the entity for which data preview is requested.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityName is required.")]
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// Total number of rows taken for sampling.
        /// </value>
        [JsonProperty(PropertyName = "sampleRowsCount")]
        public System.Nullable<int> SampleRowsCount { get; set; }
        
        /// <value>
        /// Array of column definition for the preview result.
        /// </value>
        [JsonProperty(PropertyName = "columns")]
        public System.Collections.Generic.List<Column> Columns { get; set; }
        
        /// <value>
        /// Array of row values for the preview result.
        /// </value>
        [JsonProperty(PropertyName = "rows")]
        public System.Collections.Generic.List<Row> Rows { get; set; }
        
    }
}
