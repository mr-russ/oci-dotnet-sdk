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


namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Traffic router target for a virtual service version.
    /// </summary>
    public class VirtualDeploymentTrafficRuleTargetDetails : TrafficRuleTargetDetails
    {
        
        /// <value>
        /// The OCID of the virtual deployment where the request will be routed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualDeploymentId is required.")]
        [JsonProperty(PropertyName = "virtualDeploymentId")]
        public string VirtualDeploymentId { get; set; }
        
        /// <value>
        /// Port on virtual deployment to target.
        /// If port is missing, the rule will target all ports on the virtual deployment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Weight of traffic target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Weight is required.")]
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<int> Weight { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VIRTUAL_DEPLOYMENT";
    }
}
