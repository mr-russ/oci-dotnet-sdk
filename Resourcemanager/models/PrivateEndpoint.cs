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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// A private endpoint allowing Resource Manager to access nonpublic cloud resources. For more information about private endpoints, see [Private Endpoint Management](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Tasks/private-endpoints.htm).
    /// 
    /// </summary>
    public class PrivateEndpoint 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the private endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing this private endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the private endpoint. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN for the private endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet within the VCN for the private endpoint.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The source IP addresses that Resource Manager uses to connect to your network. Automatically assigned by Resource Manager.
        /// </value>
        [JsonProperty(PropertyName = "sourceIps")]
        public System.Collections.Generic.List<string> SourceIps { get; set; }
        
        /// <value>
        /// The [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of
        /// [network security groups (NSGs)](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/networksecuritygroups.htm)
        /// for the private endpoint.
        /// Order does not matter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIdList")]
        public System.Collections.Generic.List<string> NsgIdList { get; set; }
        
        /// <value>
        /// When `true`, allows the private endpoint to be used with a configuration source provider.
        /// </value>
        [JsonProperty(PropertyName = "isUsedWithConfigurationSourceProvider")]
        public System.Nullable<bool> IsUsedWithConfigurationSourceProvider { get; set; }
        
        /// <value>
        /// DNS zones to use for accessing private Git servers. 
        /// For private Git server instructions, see
        /// [Private Git Server](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Tasks/private-endpoints.htm#private-git).
        /// Specify DNS fully qualified domain names (FQDNs); DNS Proxy forwards related DNS FQDN queries to the consumer DNS resolver.
        /// For DNS FQDNs not specified, queries go to service provider VCN resolver.
        /// Example: abc.oraclevcn.com
        /// </value>
        [JsonProperty(PropertyName = "dnsZones")]
        public System.Collections.Generic.List<string> DnsZones { get; set; }
        
        /// <value>
        /// The date and time at which the private endpoint was created.
        /// Format is defined by RFC3339.
        /// Example: 2020-11-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the private endpoint.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current lifecycle state of the private endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Free-form tags associated with the resource. Each tag is a key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
