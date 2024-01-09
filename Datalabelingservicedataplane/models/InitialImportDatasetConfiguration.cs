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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// Initial import dataset configuration. Allows user to create dataset from existing dataset files.
    /// </summary>
    public class InitialImportDatasetConfiguration 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImportFormat is required.")]
        [JsonProperty(PropertyName = "importFormat")]
        public ImportFormat ImportFormat { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImportMetadataPath is required.")]
        [JsonProperty(PropertyName = "importMetadataPath")]
        public ImportMetadataPath ImportMetadataPath { get; set; }
        
    }
}
