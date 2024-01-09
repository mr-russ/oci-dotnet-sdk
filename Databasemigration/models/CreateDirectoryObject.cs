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
    /// Directory object details, used to define either import or export directory objects in Data Pump Settings.
    /// Import directory is required for Non-Autonomous target connections. If specified for an autonomous target, it will show an error.
    /// Export directory will error if there are database link details specified.
    /// 
    /// </summary>
    public class CreateDirectoryObject 
    {
        
        /// <value>
        /// Name of directory object in database
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Absolute path of directory on database server
        /// 
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
    }
}
