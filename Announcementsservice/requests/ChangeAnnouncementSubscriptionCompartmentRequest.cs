/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AnnouncementsService.Models;

namespace Oci.AnnouncementsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/announcementsservice/ChangeAnnouncementSubscriptionCompartment.cs.html">here</a> to see an example of how to use ChangeAnnouncementSubscriptionCompartment request.
    /// </example>
    public class ChangeAnnouncementSubscriptionCompartmentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the announcement subscription.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnnouncementSubscriptionId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "announcementSubscriptionId")]
        public string AnnouncementSubscriptionId { get; set; }
        
        /// <value>
        /// The compartment information to update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangeAnnouncementSubscriptionCompartmentDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ChangeAnnouncementSubscriptionCompartmentDetails ChangeAnnouncementSubscriptionCompartmentDetails { get; set; }
        
        /// <value>
        /// The locking version, used for optimistic concurrency control.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the complete request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
