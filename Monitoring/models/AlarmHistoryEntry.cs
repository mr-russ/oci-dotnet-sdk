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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// An alarm history entry indicating a description of the entry and the time that the entry occurred.
    /// If the entry corresponds to a state transition, such as OK to Firing, then the entry also includes a transition timestamp.
    /// 
    /// </summary>
    public class AlarmHistoryEntry 
    {
        
        /// <value>
        /// Customizable alarm summary (`alarmSummary` [alarm message parameter](https://docs.cloud.oracle.com/iaas/Content/Monitoring/alarm-message-format.htm)).
        /// Optionally include [dynamic variables](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Tasks/update-alarm-dynamic-variables.htm).
        /// The alarm summary appears within the body of the alarm message and in responses to 
        /// {@link #listAlarmsStatus(ListAlarmsStatusRequest) listAlarmsStatus} 
        /// {@link #getAlarmHistory(GetAlarmHistoryRequest) getAlarmHistory} and
        /// {@link #retrieveDimensionStates(RetrieveDimensionStatesRequest) retrieveDimensionStates}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AlarmSummary is required.")]
        [JsonProperty(PropertyName = "alarmSummary")]
        public string AlarmSummary { get; set; }
        
        /// <value>
        /// Description for this alarm history entry.
        /// <br/>
        /// Example 1 - alarm state history entry: `The alarm state is FIRING`
        /// <br/>
        /// Example 2 - alarm state transition history entry: `State transitioned from OK to Firing`
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Summary is required.")]
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// Timestamp for this alarm history entry. Format defined by RFC3339.
        /// <br/>
        /// Example: 2023-02-01T01:02:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timestamp is required.")]
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// Timestamp for the transition of the alarm state. For example, the time when the alarm transitioned from OK to Firing.
        /// Available for state transition entries only. Note: A three-minute lag for this value accounts for any late-arriving metrics.
        /// <br/>
        /// Example: 2023-02-01T0:59:00.789Z
        /// </value>
        [JsonProperty(PropertyName = "timestampTriggered")]
        public System.Nullable<System.DateTime> TimestampTriggered { get; set; }
        
    }
}
