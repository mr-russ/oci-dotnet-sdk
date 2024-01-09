/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CertificatesmanagementService.Models;

namespace Oci.CertificatesmanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/certificatesmanagement/ChangeCertificateAuthorityCompartment.cs.html">here</a> to see an example of how to use ChangeCertificateAuthorityCompartment request.
    /// </example>
    public class ChangeCertificateAuthorityCompartmentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the certificate authority (CA).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateAuthorityId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "certificateAuthorityId")]
        public string CertificateAuthorityId { get; set; }
        
        /// <value>
        /// The updated compartment details
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangeCertificateAuthorityCompartmentDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ChangeCertificateAuthorityCompartmentDetails ChangeCertificateAuthorityCompartmentDetails { get; set; }
        
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
        /// Unique Oracle-assigned identifier for the request. If provided, the returned request ID
        /// will include this value. Otherwise, a random request ID will be
        /// generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case
        /// of a timeout or server error without risk of executing that same action
        /// again. Retry tokens expire after 24 hours, but can be invalidated
        /// before then due to conflicting operations (for example, if a resource has been
        /// deleted and purged from the system, then a retry of the original
        /// creation request may be rejected).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
