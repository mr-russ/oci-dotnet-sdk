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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Summary of the progress of a Migration Job.
    /// 
    /// </summary>
    public class MigrationJobProgressSummary 
    {
        
        /// <value>
        /// Current phase of the job.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentPhase is required.")]
        [JsonProperty(PropertyName = "currentPhase")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OdmsJobPhases> CurrentPhase { get; set; }
        
        /// <value>
        /// Current status of the job.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrentStatus is required.")]
        [JsonProperty(PropertyName = "currentStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobPhaseStatus> CurrentStatus { get; set; }
        
        /// <value>
        /// Job progress percentage (0 - 100)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobProgress is required.")]
        [JsonProperty(PropertyName = "jobProgress")]
        public System.Nullable<int> JobProgress { get; set; }
        
    }
}
