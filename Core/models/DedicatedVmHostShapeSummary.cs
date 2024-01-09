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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The shape used to launch the dedicated virtual machine (VM) host.
    /// 
    /// </summary>
    public class DedicatedVmHostShapeSummary 
    {
        
        /// <value>
        /// The shape's availability domain.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The name of the dedicated VM host shape. You can enumerate all available shapes by calling
        /// {@link DedicatedVmHostShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DedicatedVmHostShape is required.")]
        [JsonProperty(PropertyName = "dedicatedVmHostShape")]
        public string DedicatedVmHostShape { get; set; }
        
    }
}
