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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// A usage plan entitlement, comprising of rate limits, quotas and the deployments they are applied to.
    /// 
    /// </summary>
    public class Entitlement 
    {
        
        /// <value>
        /// An entitlement name, unique within a usage plan.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A user-friendly description. To provide some insight about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "rateLimit")]
        public RateLimit RateLimit { get; set; }
        
        [JsonProperty(PropertyName = "quota")]
        public Quota Quota { get; set; }
        
        /// <value>
        /// A collection of targeted deployments that the entitlement will be applied to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<EntitlementTarget> Targets { get; set; }
        
    }
}
