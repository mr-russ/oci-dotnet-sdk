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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details required to change database parameter values.
    /// 
    /// </summary>
    public class ChangeDatabaseParametersDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Credentials is required.")]
        [JsonProperty(PropertyName = "credentials")]
        public DatabaseCredentials Credentials { get; set; }
        
        /// <value>
        /// The clause used to specify when the parameter change takes effect.
        /// <br/>
        /// Use `MEMORY` to make the change in memory and affect it immediately.
        /// Use `SPFILE` to make the change in the server parameter file. The
        /// change takes effect when the database is next shut down and started
        /// up again. Use `BOTH` to make the change in memory and in the server
        /// parameter file. The change takes effect immediately and persists
        /// after the database is shut down and started up again.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scope is required.")]
        [JsonProperty(PropertyName = "scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ParameterScope> Scope { get; set; }
        
        /// <value>
        /// A list of database parameters and their values.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Parameters is required.")]
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<ChangeDatabaseParameterDetails> Parameters { get; set; }
        
    }
}
