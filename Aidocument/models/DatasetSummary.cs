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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// Summary of count of samples used during model training.
    /// </summary>
    public class DatasetSummary 
    {
        
        /// <value>
        /// Number of samples used for training the model.
        /// </value>
        [JsonProperty(PropertyName = "trainingSampleCount")]
        public System.Nullable<int> TrainingSampleCount { get; set; }
        
        /// <value>
        /// Number of samples used for validating the model.
        /// </value>
        [JsonProperty(PropertyName = "validationSampleCount")]
        public System.Nullable<int> ValidationSampleCount { get; set; }
        
        /// <value>
        /// Number of samples used for testing the model.
        /// </value>
        [JsonProperty(PropertyName = "testSampleCount")]
        public System.Nullable<int> TestSampleCount { get; set; }
        
    }
}
