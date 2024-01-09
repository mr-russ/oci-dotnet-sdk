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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details for audit policy provisioning.
    /// </summary>
    public class ProvisionAuditPolicyDetails 
    {
        
        /// <value>
        /// Option provided to users at the target to indicate whether the Data Safe service account has to be excluded while provisioning the audit policies.
        /// </value>
        [JsonProperty(PropertyName = "isDataSafeServiceAccountExcluded")]
        public System.Nullable<bool> IsDataSafeServiceAccountExcluded { get; set; }
        
        /// <value>
        /// The audit policy details for provisioning.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProvisionAuditConditions is required.")]
        [JsonProperty(PropertyName = "provisionAuditConditions")]
        public System.Collections.Generic.List<ProvisionAuditConditions> ProvisionAuditConditions { get; set; }
        
    }
}
