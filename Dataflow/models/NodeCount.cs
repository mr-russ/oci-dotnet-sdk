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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// An object with a logical shape and count of the number of nodes with that shape.
    /// 
    /// </summary>
    public class NodeCount 
    {
        
        /// <value>
        /// The compute shape of the nodes that the count is for.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logicalShape")]
        public string LogicalShape { get; set; }
        
        /// <value>
        /// The node count of this compute shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
    }
}
