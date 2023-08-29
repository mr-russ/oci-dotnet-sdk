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
    /// Information about the monitor.
    /// </summary>
    public class MonitorSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique name that can be edited. The name should not contain any confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonitorType is required.")]
        [JsonProperty(PropertyName = "monitorType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MonitorTypes> MonitorType { get; set; }
        
        /// <value>
        /// List of public and dedicated vantage points where the monitor is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VantagePoints is required.")]
        [JsonProperty(PropertyName = "vantagePoints")]
        public System.Collections.Generic.List<VantagePointInfo> VantagePoints { get; set; }
        
        /// <value>
        /// Number of vantage points where monitor is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VantagePointCount is required.")]
        [JsonProperty(PropertyName = "vantagePointCount")]
        public System.Nullable<int> VantagePointCount { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the script.
        /// scriptId is mandatory for creation of SCRIPTED_BROWSER and SCRIPTED_REST monitor types. For other monitor types, it should be set to null.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScriptId is required.")]
        [JsonProperty(PropertyName = "scriptId")]
        public string ScriptId { get; set; }
        
        /// <value>
        /// Name of the script.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScriptName is required.")]
        [JsonProperty(PropertyName = "scriptName")]
        public string ScriptName { get; set; }
        
        /// <value>
        /// Enables or disables the monitor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MonitorStatus> Status { get; set; }
        
        /// <value>
        /// Interval in seconds after the start time when the job should be repeated.
        /// Minimum repeatIntervalInSeconds should be 300 seconds for Scripted REST, Scripted Browser and Browser monitors, and 60 seconds for REST monitor.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepeatIntervalInSeconds is required.")]
        [JsonProperty(PropertyName = "repeatIntervalInSeconds")]
        public System.Nullable<int> RepeatIntervalInSeconds { get; set; }
        
        /// <value>
        /// If runOnce is enabled, then the monitor will run once.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRunOnce is required.")]
        [JsonProperty(PropertyName = "isRunOnce")]
        public System.Nullable<bool> IsRunOnce { get; set; }
        
        /// <value>
        /// Timeout in seconds. If isFailureRetried is true, then timeout cannot be more than 30% of repeatIntervalInSeconds time for monitors.
        /// If isFailureRetried is false, then timeout cannot be more than 50% of repeatIntervalInSeconds time for monitors.
        /// Also, timeoutInSeconds should be a multiple of 60 for Scripted REST, Scripted Browser and Browser monitors.
        /// Monitor will be allowed to run only for timeoutInSeconds time. It would be terminated after that.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeoutInSeconds is required.")]
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        /// <value>
        /// Specify the endpoint on which to run the monitor.
        /// For BROWSER and REST monitor types, target is mandatory.
        /// If target is specified in the SCRIPTED_BROWSER monitor type, then the monitor will run the selected script (specified by scriptId in monitor) against the specified target endpoint.
        /// If target is not specified in the SCRIPTED_BROWSER monitor type, then the monitor will run the selected script as it is.
        /// For NETWORK monitor with TCP protocol, a port needs to be provided along with target. Example: 192.168.0.1:80
        /// </value>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowSchedule")]
        public MaintenanceWindowSchedule MaintenanceWindowSchedule { get; set; }
        
        /// <value>
        /// The time the resource was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-12T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the resource was updated, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// Example: 2020-02-13T22:47:12.613Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// If isRunNow is enabled, then the monitor will run immediately.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsRunNow is required.")]
        [JsonProperty(PropertyName = "isRunNow")]
        public System.Nullable<bool> IsRunNow { get; set; }
        
        /// <value>
        /// Scheduling policy to decide the distribution of monitor executions on vantage points.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SchedulingPolicy is required.")]
        [JsonProperty(PropertyName = "schedulingPolicy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SchedulingPolicy> SchedulingPolicy { get; set; }
        
        /// <value>
        /// Time interval between two runs in round robin batch mode (SchedulingPolicy - BATCHED_ROUND_ROBIN).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BatchIntervalInSeconds is required.")]
        [JsonProperty(PropertyName = "batchIntervalInSeconds")]
        public System.Nullable<int> BatchIntervalInSeconds { get; set; }
        
    }
}
