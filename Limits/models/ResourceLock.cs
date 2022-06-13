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


namespace Oci.LimitsService.Models
{
    /// <summary>
    /// Resource locks prevent certain APIs from being called for the resource.
    /// A full lock prevents both updating and deleting the resource. A lock delete
    /// prevents deleting the resource.
    /// 
    /// </summary>
    public class ResourceLock 
    {
                ///
        /// <value>
        /// Lock type.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "DELETE")]
            Delete
        };

        /// <value>
        /// Lock type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The resource ID that is locking this resource. Indicates that deleting this resource removes the lock.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "relatedResourceId")]
        public string RelatedResourceId { get; set; }
        
        /// <value>
        /// A message added by the lock creator. The message typically gives an
        /// indication of why the resource is locked.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// Indicates when the lock was created, in the format defined by RFC 3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
