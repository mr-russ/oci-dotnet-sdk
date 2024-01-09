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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Properties required to create a Cortana channel.
    /// </summary>
    public class CreateCortanaChannelDetails : CreateChannelDetails
    {
        
        /// <value>
        /// The Microsoft App ID that you obtained when you created your bot registration in Azure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MsaAppId is required.")]
        [JsonProperty(PropertyName = "msaAppId")]
        public string MsaAppId { get; set; }
        
        /// <value>
        /// The client secret that you obtained from your bot registration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MsaAppPassword is required.")]
        [JsonProperty(PropertyName = "msaAppPassword")]
        public string MsaAppPassword { get; set; }
        
        /// <value>
        /// The ID of the Skill or Digital Assistant that the Channel is routed to.
        /// </value>
        [JsonProperty(PropertyName = "botId")]
        public string BotId { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "CORTANA";
    }
}
