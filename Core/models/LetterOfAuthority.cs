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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The Letter of Authority for the cross-connect. You must submit this letter when
    /// requesting cabling for the cross-connect at the FastConnect location.
    /// 
    /// </summary>
    public class LetterOfAuthority 
    {
        
        /// <value>
        /// The name of the entity authorized by this Letter of Authority.
        /// </value>
        [JsonProperty(PropertyName = "authorizedEntityName")]
        public string AuthorizedEntityName { get; set; }
                ///
        /// <value>
        /// The type of cross-connect fiber, termination, and optical specification.
        /// </value>
        ///
        public enum CircuitTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "Single_mode_LC")]
            SingleModeLc,
            [EnumMember(Value = "Single_mode_SC")]
            SingleModeSc
        };

        /// <value>
        /// The type of cross-connect fiber, termination, and optical specification.
        /// </value>
        [JsonProperty(PropertyName = "circuitType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CircuitTypeEnum> CircuitType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cross-connect.
        /// </value>
        [JsonProperty(PropertyName = "crossConnectId")]
        public string CrossConnectId { get; set; }
        
        /// <value>
        /// The address of the FastConnect location.
        /// </value>
        [JsonProperty(PropertyName = "facilityLocation")]
        public string FacilityLocation { get; set; }
        
        /// <value>
        /// The meet-me room port for this cross-connect.
        /// </value>
        [JsonProperty(PropertyName = "portName")]
        public string PortName { get; set; }
        
        /// <value>
        /// The date and time when the Letter of Authority expires, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
        /// <value>
        /// The date and time the Letter of Authority was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeIssued")]
        public System.Nullable<System.DateTime> TimeIssued { get; set; }
        
    }
}
