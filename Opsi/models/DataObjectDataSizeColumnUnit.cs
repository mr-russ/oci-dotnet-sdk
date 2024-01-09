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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Unit details of a data object column of DATA_SIZE unit category.
    /// </summary>
    public class DataObjectDataSizeColumnUnit : DataObjectColumnUnit
    {
                ///
        /// <value>
        /// Data size unit.
        /// </value>
        ///
        public enum UnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CHARACTER")]
            Character,
            [EnumMember(Value = "BLOCK")]
            Block,
            [EnumMember(Value = "BIT")]
            Bit,
            [EnumMember(Value = "BYTE")]
            Byte,
            [EnumMember(Value = "KILO_BYTE")]
            KiloByte,
            [EnumMember(Value = "MEGA_BYTE")]
            MegaByte,
            [EnumMember(Value = "GIGA_BYTE")]
            GigaByte,
            [EnumMember(Value = "TERA_BYTE")]
            TeraByte,
            [EnumMember(Value = "PETA_BYTE")]
            PetaByte,
            [EnumMember(Value = "EXA_BYTE")]
            ExaByte,
            [EnumMember(Value = "ZETTA_BYTE")]
            ZettaByte,
            [EnumMember(Value = "YOTTA_BYTE")]
            YottaByte
        };

        /// <value>
        /// Data size unit.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
        [JsonProperty(PropertyName = "unitCategory")]
        private readonly string unitCategory = "DATA_SIZE";
    }
}
