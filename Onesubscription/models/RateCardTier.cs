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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Rate Card Tier details
    /// 
    /// </summary>
    public class RateCardTier 
    {
        
        /// <value>
        /// Rate card tier quantity range
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upToQuantity")]
        public string UpToQuantity { get; set; }
        
        /// <value>
        /// Rate card tier net unit price
        /// 
        /// </value>
        [JsonProperty(PropertyName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }
        
        /// <value>
        /// Rate card tier overage price
        /// 
        /// </value>
        [JsonProperty(PropertyName = "overagePrice")]
        public string OveragePrice { get; set; }
        
    }
}
