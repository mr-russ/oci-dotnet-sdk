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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Summary information pertaining to a module stream on a managed instance
    /// </summary>
    public class ModuleStreamOnManagedInstanceSummary 
    {
        
        /// <value>
        /// The name of the module that contains the stream.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// The name of the stream.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamName is required.")]
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
                ///
        /// <value>
        /// The status of the stream
        /// <br/>
        /// A stream with the \"ENABLED\" status can be used as a source for installing
        /// profiles.  Streams with this status are also \"ACTIVE\".
        /// <br/>
        /// A stream with the \"DISABLED\" status cannot be the source for installing
        /// profiles.  To install profiles and packages from this stream, it must be
        /// enabled.
        /// <br/>
        /// A stream with the \"ACTIVE\" status can be used as a source for installing
        /// profiles.  The packages that comprise the stream are also used when a
        /// matching package is installed directly.  In general, a stream can have
        /// this status if it is the default stream for the module and no stream has
        /// been explicitly enabled.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "ACTIVE")]
            Active
        };

        /// <value>
        /// The status of the stream
        /// <br/>
        /// A stream with the \"ENABLED\" status can be used as a source for installing
        /// profiles.  Streams with this status are also \"ACTIVE\".
        /// <br/>
        /// A stream with the \"DISABLED\" status cannot be the source for installing
        /// profiles.  To install profiles and packages from this stream, it must be
        /// enabled.
        /// <br/>
        /// A stream with the \"ACTIVE\" status can be used as a source for installing
        /// profiles.  The packages that comprise the stream are also used when a
        /// matching package is installed directly.  In general, a stream can have
        /// this status if it is the default stream for the module and no stream has
        /// been explicitly enabled.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The set of profiles that the module stream contains.
        /// </value>
        [JsonProperty(PropertyName = "profiles")]
        public System.Collections.Generic.List<ModuleStreamProfileOnManagedInstanceSummary> Profiles { get; set; }
        
        /// <value>
        /// The OCID of the software source that provides this module stream.
        /// </value>
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
        /// <value>
        /// The date and time of the last status change for this profile, as
        /// described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339),
        /// section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
    }
}
