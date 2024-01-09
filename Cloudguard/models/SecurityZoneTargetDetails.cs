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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Details about Security Zone Target.
    /// </summary>
    public class SecurityZoneTargetDetails : TargetDetails
    {
        
        /// <value>
        /// The OCID of the security zone to associate this compartment with.
        /// </value>
        [JsonProperty(PropertyName = "securityZoneId")]
        public string SecurityZoneId { get; set; }
        
        /// <value>
        /// The name of the security zone to associate this compartment with.
        /// </value>
        [JsonProperty(PropertyName = "securityZoneDisplayName")]
        public string SecurityZoneDisplayName { get; set; }
        
        /// <value>
        /// The list of security zone recipes to associate this compartment with.
        /// </value>
        [JsonProperty(PropertyName = "targetSecurityZoneRecipes")]
        public System.Collections.Generic.List<SecurityRecipe> TargetSecurityZoneRecipes { get; set; }
        
        [JsonProperty(PropertyName = "targetResourceType")]
        private readonly string targetResourceType = "SECURITY_ZONE";
    }
}
