/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/EnableExadataInsight.cs.html">here</a> to see an example of how to use EnableExadataInsight request.
    /// </example>
    public class EnableExadataInsightRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Details for the Exadata system to be enabled in Operations Insights.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnableExadataInsightDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public EnableExadataInsightDetails EnableExadataInsightDetails { get; set; }
        
        /// <value>
        /// Unique Exadata insight identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInsightId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        /// <value>
        /// Used for optimistic concurrency control. In the update or delete call for a resource, set the `if-match`
        /// parameter to the value of the etag from a previous get, create, or update response for that resource.  The resource
        /// will be updated or deleted only if the etag you provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request that can be retried in case of a timeout or
        /// server error without risk of executing the same action again. Retry tokens expire after 24
        /// hours.
        /// <br/>
        /// *Note:* Retry tokens can be invalidated before the 24 hour time limit due to conflicting
        /// operations, such as a resource being deleted or purged from the system.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
