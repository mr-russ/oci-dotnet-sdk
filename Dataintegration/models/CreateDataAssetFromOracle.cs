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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details for the Oracle Database data asset type.
    /// </summary>
    public class CreateDataAssetFromOracle : CreateDataAssetDetails
    {
        
        /// <value>
        /// The Oracle Database hostname.
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The Oracle Database port.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// The service name for the data asset.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The Oracle Database driver class.
        /// </value>
        [JsonProperty(PropertyName = "driverClass")]
        public string DriverClass { get; set; }
        
        /// <value>
        /// The Oracle Database SID.
        /// </value>
        [JsonProperty(PropertyName = "sid")]
        public string Sid { get; set; }
        
        /// <value>
        /// The credential file content from a wallet for the data asset.
        /// </value>
        [JsonProperty(PropertyName = "credentialFileContent")]
        public string CredentialFileContent { get; set; }
        
        [JsonProperty(PropertyName = "walletSecret")]
        public SensitiveAttribute WalletSecret { get; set; }
        
        [JsonProperty(PropertyName = "walletPasswordSecret")]
        public SensitiveAttribute WalletPasswordSecret { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public CreateConnectionFromOracle DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLE_DATA_ASSET";
    }
}
