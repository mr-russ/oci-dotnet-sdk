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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Represents the metadata of a Amazon Redshift Connection.
    /// 
    /// </summary>
    public class AmazonRedshiftConnection : Connection
    {
                ///
        /// <value>
        /// The Amazon Redshift technology type.
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AMAZON_REDSHIFT")]
            AmazonRedshift
        };

        /// <value>
        /// The Amazon Redshift technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// Connection URL.
        /// e.g.: 'jdbc:redshift://aws-redshift-instance.aaaaaaaaaaaa.us-east-2.redshift.amazonaws.com:5439/mydb'
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectionUrl is required.")]
        [JsonProperty(PropertyName = "connectionUrl")]
        public string ConnectionUrl { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated system of the given technology.
        /// This username must already exist and be available by the system/application to be connected to
        /// and must conform to the case sensitivty requirments defined in it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "AMAZON_REDSHIFT";
    }
}
