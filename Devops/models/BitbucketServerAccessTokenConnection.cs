/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The properties that define a connection of the type `BITBUCKET_SERVER_ACCESS_TOKEN`.
    /// This type corresponds to a connection in Bitbucket that is authenticated with a personal access token.
    /// 
    /// </summary>
    public class BitbucketServerAccessTokenConnection : Connection
    {
        
        /// <value>
        /// The OCID of personal access token saved in secret store.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessToken is required.")]
        [JsonProperty(PropertyName = "accessToken")]
        public string AccessToken { get; set; }
        
        /// <value>
        /// The Base URL of the hosted BitbucketServer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BaseUrl is required.")]
        [JsonProperty(PropertyName = "baseUrl")]
        public string BaseUrl { get; set; }
        
        [JsonProperty(PropertyName = "tlsVerifyConfig")]
        public TlsVerifyConfig TlsVerifyConfig { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "BITBUCKET_SERVER_ACCESS_TOKEN";
    }
}
