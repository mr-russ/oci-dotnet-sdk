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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// A summary of the routes advertised to and received from the on-premises network.
    /// 
    /// </summary>
    public class TunnelRouteSummary 
    {
        
        /// <value>
        /// The BGP network layer reachability information.
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// The age of the route.
        /// </value>
        [JsonProperty(PropertyName = "age")]
        public System.Nullable<long> Age { get; set; }
        
        /// <value>
        /// Indicates this is the best route.
        /// </value>
        [JsonProperty(PropertyName = "isBestPath")]
        public System.Nullable<bool> IsBestPath { get; set; }
        
        /// <value>
        /// A list of ASNs in AS_Path.
        /// </value>
        [JsonProperty(PropertyName = "asPath")]
        public System.Collections.Generic.List<int> AsPath { get; set; }
                ///
        /// <value>
        /// The source of the route advertisement.
        /// </value>
        ///
        public enum AdvertiserEnum {
            [EnumMember(Value = "CUSTOMER")]
            Customer,
            [EnumMember(Value = "ORACLE")]
            Oracle
        };

        /// <value>
        /// The source of the route advertisement.
        /// </value>
        [JsonProperty(PropertyName = "advertiser")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AdvertiserEnum> Advertiser { get; set; }
        
    }
}
