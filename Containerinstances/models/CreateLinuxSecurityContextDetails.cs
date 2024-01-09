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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// Security context for Linux container.
    /// </summary>
    public class CreateLinuxSecurityContextDetails : CreateSecurityContextDetails
    {
        
        /// <value>
        /// The user ID (UID) to run the entrypoint process of the container. Defaults to user specified UID in container image metadata if not provided. This must be provided if runAsGroup is provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "runAsUser")]
        public System.Nullable<int> RunAsUser { get; set; }
        
        /// <value>
        /// The group ID (GID) to run the entrypoint process of the container. Uses runtime default if not provided.
        /// </value>
        [JsonProperty(PropertyName = "runAsGroup")]
        public System.Nullable<int> RunAsGroup { get; set; }
        
        /// <value>
        /// Indicates if the container must run as a non-root user. If true, the service validates the container image at runtime to ensure that it is not going to run with UID 0 (root) and fails the container instance creation if the validation fails.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isNonRootUserCheckEnabled")]
        public System.Nullable<bool> IsNonRootUserCheckEnabled { get; set; }
        
        /// <value>
        /// Determines if the container will have a read-only root file system. Default value is false.
        /// </value>
        [JsonProperty(PropertyName = "isRootFileSystemReadonly")]
        public System.Nullable<bool> IsRootFileSystemReadonly { get; set; }
        
        [JsonProperty(PropertyName = "securityContextType")]
        private readonly string securityContextType = "LINUX";
    }
}
