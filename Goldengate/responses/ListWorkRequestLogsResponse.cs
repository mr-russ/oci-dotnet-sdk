/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.GoldengateService.Models;

namespace Oci.GoldengateService.Responses
{
    public class ListWorkRequestLogsResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// The page token represents the page to start retrieving results. This is usually retrieved 
        /// from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }


        /// <value>
        /// A unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please include the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }

        /// <value>
        /// A list of WorkRequestLogEntry instances.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.Collections.Generic.List<WorkRequestLogEntry> Items { get; set; }

    }
}
