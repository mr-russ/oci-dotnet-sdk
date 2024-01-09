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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details required to add a HeatWave cluster.
    /// 
    /// </summary>
    public class AddHeatWaveClusterDetails 
    {
        
        /// <value>
        /// The shape determines resources to allocate to the HeatWave
        /// nodes - CPU cores, memory.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The number of analytics-processing nodes provisioned for the
        /// HeatWave cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterSize is required.")]
        [JsonProperty(PropertyName = "clusterSize")]
        public System.Nullable<int> ClusterSize { get; set; }
        
        /// <value>
        /// Enable/disable Lakehouse for the HeatWave cluster.
        /// </value>
        [JsonProperty(PropertyName = "isLakehouseEnabled")]
        public System.Nullable<bool> IsLakehouseEnabled { get; set; }
        
    }
}
