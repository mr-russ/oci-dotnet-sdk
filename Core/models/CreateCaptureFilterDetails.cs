/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// A capture filter contains a set of rules governing what traffic a VTAP mirrors or a VCN flow log collects.
    /// 
    /// </summary>
    public class CreateCaptureFilterDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the capture filter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
                ///
        /// <value>
        /// Indicates which service will use this capture filter
        /// </value>
        ///
        public enum FilterTypeEnum {
            [EnumMember(Value = "VTAP")]
            Vtap,
            [EnumMember(Value = "FLOWLOG")]
            Flowlog
        };

        /// <value>
        /// Indicates which service will use this capture filter
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FilterType is required.")]
        [JsonProperty(PropertyName = "filterType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FilterTypeEnum> FilterType { get; set; }
        
        /// <value>
        /// The set of rules governing what traffic a VTAP mirrors.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vtapCaptureFilterRules")]
        public System.Collections.Generic.List<VtapCaptureFilterRuleDetails> VtapCaptureFilterRules { get; set; }
        
        /// <value>
        /// The set of rules governing what traffic the VCN flow log collects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "flowLogCaptureFilterRules")]
        public System.Collections.Generic.List<FlowLogCaptureFilterRuleDetails> FlowLogCaptureFilterRules { get; set; }
        
    }
}
