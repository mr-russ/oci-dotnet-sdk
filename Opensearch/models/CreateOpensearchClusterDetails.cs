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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// The configuration details for a new OpenSearch cluster.
    /// </summary>
    public class CreateOpensearchClusterDetails 
    {
        
        /// <value>
        /// The name of the cluster. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment to create the cluster in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The version of the software the cluster is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareVersion is required.")]
        [JsonProperty(PropertyName = "softwareVersion")]
        public string SoftwareVersion { get; set; }
        
        /// <value>
        /// The number of master nodes to configure for the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MasterNodeCount is required.")]
        [JsonProperty(PropertyName = "masterNodeCount")]
        public System.Nullable<int> MasterNodeCount { get; set; }
        
        /// <value>
        /// The instance type for the cluster's master nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MasterNodeHostType is required.")]
        [JsonProperty(PropertyName = "masterNodeHostType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MasterNodeHostType> MasterNodeHostType { get; set; }
        
        /// <value>
        /// The bare metal shape for the cluster's master nodes.
        /// </value>
        [JsonProperty(PropertyName = "masterNodeHostBareMetalShape")]
        public string MasterNodeHostBareMetalShape { get; set; }
        
        /// <value>
        /// The number of OCPUs to configure for the cluser's master nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MasterNodeHostOcpuCount is required.")]
        [JsonProperty(PropertyName = "masterNodeHostOcpuCount")]
        public System.Nullable<int> MasterNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure per node for the cluster's master nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MasterNodeHostMemoryGB is required.")]
        [JsonProperty(PropertyName = "masterNodeHostMemoryGB")]
        public System.Nullable<int> MasterNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The number of data nodes to configure for the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodeCount is required.")]
        [JsonProperty(PropertyName = "dataNodeCount")]
        public System.Nullable<int> DataNodeCount { get; set; }
        
        /// <value>
        /// TThe instance type for the cluster's data nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodeHostType is required.")]
        [JsonProperty(PropertyName = "dataNodeHostType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataNodeHostType> DataNodeHostType { get; set; }
        
        /// <value>
        /// The bare metal shape for the cluster's data nodes.
        /// </value>
        [JsonProperty(PropertyName = "dataNodeHostBareMetalShape")]
        public string DataNodeHostBareMetalShape { get; set; }
        
        /// <value>
        /// The number of OCPUs to configure for the cluster's data nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodeHostOcpuCount is required.")]
        [JsonProperty(PropertyName = "dataNodeHostOcpuCount")]
        public System.Nullable<int> DataNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure per node for the cluster's data nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodeHostMemoryGB is required.")]
        [JsonProperty(PropertyName = "dataNodeHostMemoryGB")]
        public System.Nullable<int> DataNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The amount of storage in GB, to configure per node for the cluster's data nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodeStorageGB is required.")]
        [JsonProperty(PropertyName = "dataNodeStorageGB")]
        public System.Nullable<int> DataNodeStorageGB { get; set; }
        
        /// <value>
        /// The number of OpenSearch Dashboard nodes to configure for the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpendashboardNodeCount is required.")]
        [JsonProperty(PropertyName = "opendashboardNodeCount")]
        public System.Nullable<int> OpendashboardNodeCount { get; set; }
        
        /// <value>
        /// The number of OCPUs to configure for the cluster's OpenSearch Dashboard nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpendashboardNodeHostOcpuCount is required.")]
        [JsonProperty(PropertyName = "opendashboardNodeHostOcpuCount")]
        public System.Nullable<int> OpendashboardNodeHostOcpuCount { get; set; }
        
        /// <value>
        /// The amount of memory in GB, to configure for the cluster's OpenSearch Dashboard nodes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpendashboardNodeHostMemoryGB is required.")]
        [JsonProperty(PropertyName = "opendashboardNodeHostMemoryGB")]
        public System.Nullable<int> OpendashboardNodeHostMemoryGB { get; set; }
        
        /// <value>
        /// The OCID of the cluster's VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
        /// <value>
        /// The OCID of the cluster's subnet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The OCID for the compartment where the cluster's VCN is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnCompartmentId is required.")]
        [JsonProperty(PropertyName = "vcnCompartmentId")]
        public string VcnCompartmentId { get; set; }
        
        /// <value>
        /// The OCID for the compartment where the cluster's subnet is located.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetCompartmentId is required.")]
        [JsonProperty(PropertyName = "subnetCompartmentId")]
        public string SubnetCompartmentId { get; set; }
        
        /// <value>
        /// The security mode of the cluster.
        /// </value>
        [JsonProperty(PropertyName = "securityMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SecurityMode> SecurityMode { get; set; }
        
        /// <value>
        /// The name of the master user that are used to manage security config
        /// </value>
        [JsonProperty(PropertyName = "securityMasterUserName")]
        public string SecurityMasterUserName { get; set; }
        
        /// <value>
        /// The password hash of the master user that are used to manage security config
        /// </value>
        [JsonProperty(PropertyName = "securityMasterUserPasswordHash")]
        public string SecurityMasterUserPasswordHash { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
