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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Determines the size and amount of resources available to the instance.
    /// </summary>
    public class ShapeConfig 
    {
        
        /// <value>
        /// The total number of OCPUs available to the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocpus is required.")]
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// The total amount of memory available to the instance, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
    }
}
