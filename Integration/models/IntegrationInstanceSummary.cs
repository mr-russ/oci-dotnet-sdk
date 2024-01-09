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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// Summary of the Integration Instance.
    /// </summary>
    public class IntegrationInstanceSummary 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Integration Instance Identifier, can be renamed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Standard or Enterprise type, 
        /// Oracle Integration Generation 2 uses ENTERPRISE and STANDARD, 
        /// Oracle Integration 3 uses ENTERPRISEX and STANDARDX
        /// 
        /// </value>
        ///
        public enum IntegrationInstanceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "ENTERPRISE")]
            Enterprise,
            [EnumMember(Value = "STANDARDX")]
            Standardx,
            [EnumMember(Value = "ENTERPRISEX")]
            Enterprisex
        };

        /// <value>
        /// Standard or Enterprise type, 
        /// Oracle Integration Generation 2 uses ENTERPRISE and STANDARD, 
        /// Oracle Integration 3 uses ENTERPRISEX and STANDARDX
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntegrationInstanceType is required.")]
        [JsonProperty(PropertyName = "integrationInstanceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IntegrationInstanceTypeEnum> IntegrationInstanceType { get; set; }
        
        /// <value>
        /// The time the the Integration Instance was created. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the IntegrationInstance was updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// The current state of the Integration Instance.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Integration Instance.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// An message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "stateMessage")]
        public string StateMessage { get; set; }
        
        /// <value>
        /// Bring your own license.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsByol is required.")]
        [JsonProperty(PropertyName = "isByol")]
        public System.Nullable<bool> IsByol { get; set; }
        
        /// <value>
        /// The Integration Instance URL.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceUrl is required.")]
        [JsonProperty(PropertyName = "instanceUrl")]
        public string InstanceUrl { get; set; }
        
        /// <value>
        /// The number of configured message packs (if any)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessagePacks is required.")]
        [JsonProperty(PropertyName = "messagePacks")]
        public System.Nullable<int> MessagePacks { get; set; }
        
        /// <value>
        /// The file server is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isFileServerEnabled")]
        public System.Nullable<bool> IsFileServerEnabled { get; set; }
        
        /// <value>
        /// Visual Builder is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isVisualBuilderEnabled")]
        public System.Nullable<bool> IsVisualBuilderEnabled { get; set; }
        
        [JsonProperty(PropertyName = "customEndpoint")]
        public CustomEndpointDetails CustomEndpoint { get; set; }
        
        /// <value>
        /// A list of alternate custom endpoints used for the integration instance URL.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternateCustomEndpoints")]
        public System.Collections.Generic.List<CustomEndpointDetails> AlternateCustomEndpoints { get; set; }
                ///
        /// <value>
        /// The entitlement used for billing purposes.
        /// </value>
        ///
        public enum ConsumptionModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UCM")]
            Ucm,
            [EnumMember(Value = "GOV")]
            Gov,
            [EnumMember(Value = "OIC4SAAS")]
            Oic4Saas
        };

        /// <value>
        /// The entitlement used for billing purposes.
        /// </value>
        [JsonProperty(PropertyName = "consumptionModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConsumptionModelEnum> ConsumptionModel { get; set; }
        
        [JsonProperty(PropertyName = "networkEndpointDetails")]
        public NetworkEndpointDetails NetworkEndpointDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name,
        /// type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to
        /// namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
                ///
        /// <value>
        /// Shape
        /// </value>
        ///
        public enum ShapeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DEVELOPMENT")]
            Development,
            [EnumMember(Value = "PRODUCTION")]
            Production
        };

        /// <value>
        /// Shape
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShapeEnum> Shape { get; set; }
        
        [JsonProperty(PropertyName = "privateEndpointOutboundConnection")]
        public OutboundConnection PrivateEndpointOutboundConnection { get; set; }
        
    }
}
