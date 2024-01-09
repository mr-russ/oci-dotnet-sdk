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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// A backend set mapping between source and destination load balancer.
    /// 
    /// </summary>
    public class LoadBalancerBackendSetMapping 
    {
        
        /// <value>
        /// This flag specifies if this backend set is used for traffic for non-movable compute instances.
        /// Backend sets that point to non-movable instances are only enabled or disabled during DR. For non-movable instances this flag should be set to 'true'.
        /// Backend sets that point to movable instances are emptied and their contents are transferred to the destination region load balancer.  For movable instances this flag should be set to 'false'. 
        /// <br/>
        /// Example: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsBackendSetForNonMovable is required.")]
        [JsonProperty(PropertyName = "isBackendSetForNonMovable")]
        public System.Nullable<bool> IsBackendSetForNonMovable { get; set; }
        
        /// <value>
        /// The name of the source backend set.
        /// <br/>
        /// Example: My_Source_Backend_Set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceBackendSetName is required.")]
        [JsonProperty(PropertyName = "sourceBackendSetName")]
        public string SourceBackendSetName { get; set; }
        
        /// <value>
        /// The name of the destination backend set.
        /// <br/>
        /// Example: My_Destination_Backend_Set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBackendSetName is required.")]
        [JsonProperty(PropertyName = "destinationBackendSetName")]
        public string DestinationBackendSetName { get; set; }
        
    }
}
