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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details for creating a block volume attachment.
    /// 
    /// </summary>
    public class CreateBlockVolumeAttachmentDetails 
    {
        
        /// <value>
        /// The OCID of the reference compute instance from which to obtain the attachment details for the volume.
        /// This reference compute instance is from the peer DR protection group.
        /// <br/>
        /// Example: ocid1.instance.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "volumeAttachmentReferenceInstanceId")]
        public string VolumeAttachmentReferenceInstanceId { get; set; }
        
    }
}
