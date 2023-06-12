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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Management Agent Configuration for a Fleet. Includes JRE scanning frequency and a list of include/exclude file system paths.
    /// 
    /// </summary>
    public class FleetAgentConfiguration 
    {
        
        /// <value>
        /// The frequency (in minutes) of JRE scanning. (That is, how often should JMS scan for JRE installations.)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JreScanFrequencyInMinutes is required.")]
        [JsonProperty(PropertyName = "jreScanFrequencyInMinutes")]
        public System.Nullable<int> JreScanFrequencyInMinutes { get; set; }
        
        /// <value>
        /// The frequency (in minutes) of Java Usage Tracker processing. (That is, how often should JMS process data from the Java Usage Tracker.)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JavaUsageTrackerProcessingFrequencyInMinutes is required.")]
        [JsonProperty(PropertyName = "javaUsageTrackerProcessingFrequencyInMinutes")]
        public System.Nullable<int> JavaUsageTrackerProcessingFrequencyInMinutes { get; set; }
        
        /// <value>
        /// The validity period in days for work requests.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workRequestValidityPeriodInDays")]
        public System.Nullable<int> WorkRequestValidityPeriodInDays { get; set; }
        
        /// <value>
        /// Agent polling interval in minutes
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agentPollingIntervalInMinutes")]
        public System.Nullable<int> AgentPollingIntervalInMinutes { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LinuxConfiguration is required.")]
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public FleetAgentOsConfiguration LinuxConfiguration { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WindowsConfiguration is required.")]
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public FleetAgentOsConfiguration WindowsConfiguration { get; set; }
        
        /// <value>
        /// The date and time of the last modification to the Fleet Agent Configuration (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastModified is required.")]
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
    }
}
