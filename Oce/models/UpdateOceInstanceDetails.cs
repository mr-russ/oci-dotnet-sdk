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


namespace Oci.OceService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    public class UpdateOceInstanceDetails 
    {
        
        /// <value>
        /// OceInstance description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Web Application Firewall(WAF) primary domain
        /// </value>
        [JsonProperty(PropertyName = "wafPrimaryDomain")]
        public string WafPrimaryDomain { get; set; }
        
        /// <value>
        /// Flag indicating whether the instance license is new cloud or bring your own license
        /// </value>
        [JsonProperty(PropertyName = "instanceLicenseType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> InstanceLicenseType { get; set; }
                ///
        /// <value>
        /// Instance type based on its usage
        /// </value>
        ///
        public enum InstanceUsageTypeEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "NONPRIMARY")]
            Nonprimary
        };

        /// <value>
        /// Instance type based on its usage
        /// </value>
        [JsonProperty(PropertyName = "instanceUsageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceUsageTypeEnum> InstanceUsageType { get; set; }
        
        /// <value>
        /// a list of add-on features for the ocm instance
        /// </value>
        [JsonProperty(PropertyName = "addOnFeatures")]
        public System.Collections.Generic.List<string> AddOnFeatures { get; set; }
        
        /// <value>
        /// Details of the current state of the instance lifecycle
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleDetails> LifecycleDetails { get; set; }
        
        /// <value>
        /// disaster recovery paired ragion name
        /// </value>
        [JsonProperty(PropertyName = "drRegion")]
        public string DrRegion { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
