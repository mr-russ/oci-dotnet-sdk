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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Details about a line within the difference.
    /// </summary>
    public class DiffLineDetails 
    {
        
        /// <value>
        /// The number of a line in the base version.
        /// </value>
        [JsonProperty(PropertyName = "baseLine")]
        public System.Nullable<int> BaseLine { get; set; }
        
        /// <value>
        /// The number of a line in the target version.
        /// </value>
        [JsonProperty(PropertyName = "targetLine")]
        public System.Nullable<int> TargetLine { get; set; }
        
        /// <value>
        /// The contents of a line.
        /// </value>
        [JsonProperty(PropertyName = "lineContent")]
        public string LineContent { get; set; }
                ///
        /// <value>
        /// Indicates whether a line in a conflicted section of the difference is from the base version, the target version, or if its just a marker indicating the beginning, middle, or end of a conflicted section.
        /// </value>
        ///
        public enum ConflictMarkerEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BASE")]
            Base,
            [EnumMember(Value = "TARGET")]
            Target,
            [EnumMember(Value = "MARKER")]
            Marker,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// Indicates whether a line in a conflicted section of the difference is from the base version, the target version, or if its just a marker indicating the beginning, middle, or end of a conflicted section.
        /// </value>
        [JsonProperty(PropertyName = "conflictMarker")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConflictMarkerEnum> ConflictMarker { get; set; }
        
    }
}
