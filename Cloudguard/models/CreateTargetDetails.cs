/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// The information about new Target.
    /// </summary>
    public class CreateTargetDetails 
    {
        
        /// <value>
        /// DetectorTemplate identifier.
        /// <br/>
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier where the resource is created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The target description.
        /// <br/>
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// possible type of targets(COMPARTMENT/FACLOUD)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetResourceType is required.")]
        [JsonProperty(PropertyName = "targetResourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TargetResourceType> TargetResourceType { get; set; }
        
        /// <value>
        /// Resource ID which the target uses to monitor
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetResourceId is required.")]
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }
        
        /// <value>
        /// List of detector recipes to associate with target
        /// </value>
        [JsonProperty(PropertyName = "targetDetectorRecipes")]
        public System.Collections.Generic.List<CreateTargetDetectorRecipeDetails> TargetDetectorRecipes { get; set; }
        
        /// <value>
        /// List of responder recipes to associate with target
        /// </value>
        [JsonProperty(PropertyName = "targetResponderRecipes")]
        public System.Collections.Generic.List<CreateTargetResponderRecipeDetails> TargetResponderRecipes { get; set; }
        
        /// <value>
        /// The current state of the DetectorRule.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
