/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    public class RemovePublicIpPoolCapacityRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the Public Ip Pool object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicIpPoolId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "publicIpPoolId")]
        public string PublicIpPoolId { get; set; }
        
        /// <value>
        /// The Cidr to be removed from the Public Ip Pool
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RemovePublicIpPoolCapacityDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public RemovePublicIpPoolCapacityDetails RemovePublicIpPoolCapacityDetails { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations (for example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// may be rejected).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}