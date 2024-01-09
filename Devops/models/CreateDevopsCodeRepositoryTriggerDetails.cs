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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The trigger for DevOps code repository as the caller.
    /// </summary>
    public class CreateDevopsCodeRepositoryTriggerDetails : CreateTriggerDetails
    {
        
        /// <value>
        /// The OCID of the DevOps code repository.
        /// </value>
        [JsonProperty(PropertyName = "repositoryId")]
        public string RepositoryId { get; set; }
        
        [JsonProperty(PropertyName = "triggerSource")]
        private readonly string triggerSource = "DEVOPS_CODE_REPOSITORY";
    }
}
