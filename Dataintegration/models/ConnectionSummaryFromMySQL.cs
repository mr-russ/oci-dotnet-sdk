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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The connection details for a MYSQL data asset.
    /// </summary>
    public class ConnectionSummaryFromMySQL : ConnectionSummary
    {
        
        /// <value>
        /// The user name for the connection.
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "MYSQL_CONNECTION";
    }
}
