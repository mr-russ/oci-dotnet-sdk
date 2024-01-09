/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoggingService.Models;

namespace Oci.LoggingService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/logging/ChangeUnifiedAgentConfigurationCompartment.cs.html">here</a> to see an example of how to use ChangeUnifiedAgentConfigurationCompartment request.
    /// </example>
    public class ChangeUnifiedAgentConfigurationCompartmentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the Unified Agent configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnifiedAgentConfigurationId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "unifiedAgentConfigurationId")]
        public string UnifiedAgentConfigurationId { get; set; }
        
        /// <value>
        /// Request to change the compartment of a given resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangeUnifiedAgentConfigurationCompartmentDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ChangeUnifiedAgentConfigurationCompartmentDetails ChangeUnifiedAgentConfigurationCompartmentDetails { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case
        /// of a timeout or server error, without risk of executing that same action
        /// again. Retry tokens expire after 24 hours, but can be invalidated
        /// before then due to conflicting operations (e.g., if a resource has been
        /// deleted and purged from the system, then a retry of the original
        /// creation request may be rejected).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a
        /// resource, set the `if-match` parameter to the value of the etag from a
        /// previous GET or POST response for that resource. The resource will be
        /// updated or deleted only if the etag you provide matches the resource's
        /// current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
