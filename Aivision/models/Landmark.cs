/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The landmark on the face.
    /// </summary>
    public class Landmark 
    {
                ///
        /// <value>
        /// The face landmark type
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LEFT_EYE")]
            LeftEye,
            [EnumMember(Value = "RIGHT_EYE")]
            RightEye,
            [EnumMember(Value = "NOSE_TIP")]
            NoseTip,
            [EnumMember(Value = "LEFT_EDGE_OF_MOUTH")]
            LeftEdgeOfMouth,
            [EnumMember(Value = "RIGHT_EDGE_OF_MOUTH")]
            RightEdgeOfMouth
        };

        /// <value>
        /// The face landmark type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The X-axis normalized coordinate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "X is required.")]
        [JsonProperty(PropertyName = "x")]
        public System.Nullable<float> X { get; set; }
        
        /// <value>
        /// The Y-axis normalized coordinate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Y is required.")]
        [JsonProperty(PropertyName = "y")]
        public System.Nullable<float> Y { get; set; }
        
    }
}
