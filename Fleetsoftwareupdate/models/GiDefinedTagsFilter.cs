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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Defined tags to include in the discovery.
    /// 
    /// </summary>
    public class GiDefinedTagsFilter : GiFleetDiscoveryFilter
    {
        
        /// <value>
        /// Defined tags to include in the discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Tags is required.")]
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<DefinedTagFilterEntry> Tags { get; set; }
        
        /// <value>
        /// Type of join for each element in this filter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FleetDiscoveryOperators> Operator { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DEFINED_TAG";
    }
}
