/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Responses
{
    public class ListPreauthenticatedRequestsResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular
        /// request, provide this request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// For paginating a list of pre-authenticated requests.
        /// In the GET request, set the limit to the number of pre-authenticated requests that you want returned in
        /// the response. If the `opc-next-page` header appears in the response, then this is a partial list and there
        /// are additional pre-authenticated requests to get. Include the header's value as the `page` parameter in
        /// the subsequent GET request to get the next batch of pre-authenticated requests. Repeat this process to
        /// retrieve the entire list of pre-authenticated requests.
        /// <br/>
        /// For more details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }

        /// <value>
        /// A list of PreauthenticatedRequestSummary instances.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.Collections.Generic.List<PreauthenticatedRequestSummary> Items { get; set; }

    }
}
