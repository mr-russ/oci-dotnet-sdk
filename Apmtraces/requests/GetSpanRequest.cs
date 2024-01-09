/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ApmtracesService.Models;

namespace Oci.ApmtracesService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/GetSpan.cs.html">here</a> to see an example of how to use GetSpan request.
    /// </example>
    public class GetSpanRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The APM Domain ID the request is intended for.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApmDomainId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "apmDomainId")]
        public string ApmDomainId { get; set; }
        
        /// <value>
        /// Unique Application Performance Monitoring span identifier (spanId).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SpanKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "spanKey")]
        public string SpanKey { get; set; }
        
        /// <value>
        /// Unique Application Performance Monitoring trace identifier (traceId).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "traceKey")]
        public string TraceKey { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
