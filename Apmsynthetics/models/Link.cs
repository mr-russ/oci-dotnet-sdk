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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Details of the link between two nodes.
    /// </summary>
    public class Link 
    {
        
        /// <value>
        /// ID of the link.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// ID of the source node.
        /// </value>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        
        /// <value>
        /// ID of the destination node.
        /// </value>
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
        
        /// <value>
        /// Number of times the link is repeated.
        /// </value>
        [JsonProperty(PropertyName = "repeatCount")]
        public System.Nullable<int> RepeatCount { get; set; }
        
        /// <value>
        /// Average packet loss.
        /// </value>
        [JsonProperty(PropertyName = "forwardingLoss")]
        public System.Double ForwardingLoss { get; set; }
        
        /// <value>
        /// Difference of the packet response time between source and destination nodes, in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "delayInMilliseconds")]
        public System.Double DelayInMilliseconds { get; set; }
        
        /// <value>
        /// Minimum delay in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "minDelayInMilliseconds")]
        public System.Double MinDelayInMilliseconds { get; set; }
        
        /// <value>
        /// Maximum delay in milliseconds.
        /// </value>
        [JsonProperty(PropertyName = "maxDelayInMilliseconds")]
        public System.Double MaxDelayInMilliseconds { get; set; }
        
        /// <value>
        /// List of all path IDs of which this link is part of.
        /// </value>
        [JsonProperty(PropertyName = "paths")]
        public System.Collections.Generic.List<string> Paths { get; set; }
        
    }
}
