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


namespace Oci.EventsService.Models
{
    /// <summary>
    /// Create an action that delivers to an Oracle Notification Service topic.
    /// </summary>
    public class CreateNotificationServiceActionDetails : ActionDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the topic to which messages are delivered.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topicId")]
        public string TopicId { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "ONS";
    }
}
