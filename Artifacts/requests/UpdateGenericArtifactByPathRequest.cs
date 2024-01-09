/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ArtifactsService.Models;

namespace Oci.ArtifactsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/artifacts/UpdateGenericArtifactByPath.cs.html">here</a> to see an example of how to use UpdateGenericArtifactByPath request.
    /// </example>
    public class UpdateGenericArtifactByPathRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the repository.
        /// <br/>
        /// Example: ocid1.artifactrepository.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "repositoryId")]
        public string RepositoryId { get; set; }
        
        /// <value>
        /// A user-defined path to describe the location of an artifact. You can use slashes to organize the repository, but slashes do not create a directory structure. An artifact path does not include an artifact version.
        /// <br/>
        /// Example: project01/my-web-app/artifact-abc
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArtifactPath is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "artifactPath")]
        public string ArtifactPath { get; set; }
        
        /// <value>
        /// A user-defined string to describe the artifact version.
        /// <br/>
        /// Example: 1.1.2 or 1.2-beta-2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Updates an artifact with a specified `artifactPath` and `version`. You can only update the tags of an artifact.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateGenericArtifactByPathDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateGenericArtifactByPathDetails UpdateGenericArtifactByPathDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match`
        /// parameter to the value of the etag from a previous GET or POST response for that resource. The resource
        /// will be updated or deleted only if the etag you provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
