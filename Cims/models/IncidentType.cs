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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the incident type associated with the support ticket.
    /// </summary>
    public class IncidentType 
    {
        
        /// <value>
        /// Unique identifier for the incident type.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the incident type.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The label associated with the incident type.
        /// </value>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// The description of the incident type.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The list of classifiers.
        /// </value>
        [JsonProperty(PropertyName = "classifierList")]
        public System.Collections.Generic.List<Classifier> ClassifierList { get; set; }
        
    }
}
