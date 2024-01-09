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


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// Object used to create a cursor to consume messages in a stream.
    /// </summary>
    public class CreateCursorDetails 
    {
        
        /// <value>
        /// The partition to get messages from.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Partition is required.")]
        [JsonProperty(PropertyName = "partition")]
        public string Partition { get; set; }
                ///
        /// <value>
        /// The type of cursor, which determines the starting point from which the stream will be consumed:
        /// <br/>
        /// - `AFTER_OFFSET:` The partition position immediately following the offset you specify. (Offsets are assigned when you successfully append a message to a partition in a stream.)
        /// - `AT_OFFSET:` The exact partition position indicated by the offset you specify.
        /// - `AT_TIME:` A specific point in time.
        /// - `LATEST:` The most recent message in the partition that was added after the cursor was created.
        /// - `TRIM_HORIZON:` The oldest message in the partition that is within the retention period window.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "AFTER_OFFSET")]
            AfterOffset,
            [EnumMember(Value = "AT_OFFSET")]
            AtOffset,
            [EnumMember(Value = "AT_TIME")]
            AtTime,
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "TRIM_HORIZON")]
            TrimHorizon
        };

        /// <value>
        /// The type of cursor, which determines the starting point from which the stream will be consumed:
        /// <br/>
        /// - `AFTER_OFFSET:` The partition position immediately following the offset you specify. (Offsets are assigned when you successfully append a message to a partition in a stream.)
        /// - `AT_OFFSET:` The exact partition position indicated by the offset you specify.
        /// - `AT_TIME:` A specific point in time.
        /// - `LATEST:` The most recent message in the partition that was added after the cursor was created.
        /// - `TRIM_HORIZON:` The oldest message in the partition that is within the retention period window.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The offset to consume from if the cursor type is `AT_OFFSET` or `AFTER_OFFSET`.
        /// </value>
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<long> Offset { get; set; }
        
        /// <value>
        /// The time to consume from if the cursor type is `AT_TIME`, expressed in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public System.Nullable<System.DateTime> Time { get; set; }
        
    }
}
