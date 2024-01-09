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
    /// The empty directory for the container instance.
    /// </summary>
    public class CreateContainerEmptyDirVolumeDetails : CreateContainerVolumeDetails
    {
        
        /// <value>
        /// The volume type of the empty directory, can be either File Storage or Memory.
        /// </value>
        [JsonProperty(PropertyName = "backingStore")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ContainerEmptyDirVolume.BackingStoreEnum> BackingStore { get; set; }
        
        [JsonProperty(PropertyName = "volumeType")]
        private readonly string volumeType = "EMPTYDIR";
    }
}
