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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Used for creating NFS backup destinations.
    /// </summary>
    public class CreateNFSBackupDestinationDetails : CreateBackupDestinationDetails
    {
        
        /// <value>
        /// **Deprecated.** The local directory path on each VM cluster node where the NFS server location is mounted. The local directory path and the NFS server location must each be the same across all of the VM cluster nodes. Ensure that the NFS mount is maintained continuously on all of the VM cluster nodes.
        /// This field is deprecated. Use the mountTypeDetails field instead to specify the mount type for NFS.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localMountPointPath")]
        public string LocalMountPointPath { get; set; }
        
        [JsonProperty(PropertyName = "mountTypeDetails")]
        public MountTypeDetails MountTypeDetails { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "NFS";
    }
}
