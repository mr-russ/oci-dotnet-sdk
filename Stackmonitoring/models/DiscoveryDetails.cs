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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The request of DiscoveryJob Resource details.
    /// </summary>
    public class DiscoveryDetails 
    {
        
        /// <value>
        /// The OCID of Management Agent
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AgentId is required.")]
        [JsonProperty(PropertyName = "agentId")]
        public string AgentId { get; set; }
                ///
        /// <value>
        /// Resource Type.
        /// </value>
        ///
        public enum ResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "WEBLOGIC_DOMAIN")]
            WeblogicDomain,
            [EnumMember(Value = "EBS_INSTANCE")]
            EbsInstance,
            [EnumMember(Value = "SQL_SERVER")]
            SqlServer,
            [EnumMember(Value = "APACHE_TOMCAT")]
            ApacheTomcat,
            [EnumMember(Value = "ORACLE_DATABASE")]
            OracleDatabase,
            [EnumMember(Value = "OCI_ORACLE_DB")]
            OciOracleDb,
            [EnumMember(Value = "OCI_ORACLE_CDB")]
            OciOracleCdb,
            [EnumMember(Value = "OCI_ORACLE_PDB")]
            OciOraclePdb,
            [EnumMember(Value = "HOST")]
            Host,
            [EnumMember(Value = "ORACLE_PSFT")]
            OraclePsft,
            [EnumMember(Value = "ORACLE_MFT")]
            OracleMft,
            [EnumMember(Value = "APACHE_HTTP_SERVER")]
            ApacheHttpServer,
            [EnumMember(Value = "ORACLE_GOLDENGATE")]
            OracleGoldengate,
            [EnumMember(Value = "CUSTOM_RESOURCE")]
            CustomResource,
            [EnumMember(Value = "ORACLE_HTTP_SERVER")]
            OracleHttpServer
        };

        /// <value>
        /// Resource Type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourceTypeEnum> ResourceType { get; set; }
        
        /// <value>
        /// The Name of resource type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// License edition of the monitored resource.
        /// </value>
        [JsonProperty(PropertyName = "license")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseType> License { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Properties is required.")]
        [JsonProperty(PropertyName = "properties")]
        public PropertyDetails Properties { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public CredentialCollection Credentials { get; set; }
        
        [JsonProperty(PropertyName = "tags")]
        public PropertyDetails Tags { get; set; }
        
    }
}
