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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// To capture all the statistical data related to profiling.
    /// </summary>
    public class ProfileStat 
    {
        
        /// <value>
        /// Placeholder for now, in future we will return the confidence of the profile result (because we are using sampled data and not whole data)
        /// </value>
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// Value of the confidence of the profile result.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
    }
}
