/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/Recommendations.cs.html">here</a> to see an example of how to use Recommendations request.
    /// </example>
    public class RecommendationsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// A filter used to return only recommendations of the specified type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecommendationType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "recommendationType")]
        public System.Collections.Generic.List<RecommendationType> RecommendationType { get; set; }
        
        /// <value>
        /// A filter used to provide the unique identifier of the source object, for which a list of recommendations will be returned for review.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceObjectKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceObjectKey")]
        public string SourceObjectKey { get; set; }
        
        /// <value>
        /// A filter used to provide the type of the source object, for which a list of recommendations will be returned for review.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceObjectType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceObjectType")]
        public System.Nullable<RecommendationResourceType> SourceObjectType { get; set; }
        
        /// <value>
        /// A filter used to return only recommendations having the requested status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "recommendationStatus")]
        public System.Nullable<RecommendationStatus> RecommendationStatus { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
