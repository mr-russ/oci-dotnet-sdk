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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The configuration details of a step.
    /// </summary>
    public class PipelineStepConfigurationDetails 
    {
        
        /// <value>
        /// A time bound for the execution of the step.
        /// </value>
        [JsonProperty(PropertyName = "maximumRuntimeInMinutes")]
        public System.Nullable<long> MaximumRuntimeInMinutes { get; set; }
        
        /// <value>
        /// Environment variables to set for step.
        /// </value>
        [JsonProperty(PropertyName = "environmentVariables")]
        public System.Collections.Generic.Dictionary<string, string> EnvironmentVariables { get; set; }
        
        /// <value>
        /// The command line arguments to set for step.
        /// </value>
        [JsonProperty(PropertyName = "commandLineArguments")]
        public string CommandLineArguments { get; set; }
        
    }
}
