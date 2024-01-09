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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Authentication configuration that uses OCI Resource Principal Auth for Generic REST invocation.
    /// </summary>
    public class ResourcePrincipalAuthConfig : AuthConfig
    {
                ///
        /// <value>
        /// The OCI resource type that will supply the authentication token
        /// </value>
        ///
        public enum ResourcePrincipalSourceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "WORKSPACE")]
            Workspace,
            [EnumMember(Value = "APPLICATION")]
            Application
        };

        /// <value>
        /// The OCI resource type that will supply the authentication token
        /// </value>
        [JsonProperty(PropertyName = "resourcePrincipalSource")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResourcePrincipalSourceEnum> ResourcePrincipalSource { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "OCI_RESOURCE_AUTH_CONFIG";
    }
}
