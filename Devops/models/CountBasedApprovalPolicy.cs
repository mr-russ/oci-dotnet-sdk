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
    /// Count based stage approval policy.
    /// </summary>
    public class CountBasedApprovalPolicy : ApprovalPolicy
    {
        
        /// <value>
        /// A minimum number of approvals required for stage to proceed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfApprovalsRequired is required.")]
        [JsonProperty(PropertyName = "numberOfApprovalsRequired")]
        public System.Nullable<int> NumberOfApprovalsRequired { get; set; }
        
        [JsonProperty(PropertyName = "approvalPolicyType")]
        private readonly string approvalPolicyType = "COUNT_BASED_APPROVAL";
    }
}
