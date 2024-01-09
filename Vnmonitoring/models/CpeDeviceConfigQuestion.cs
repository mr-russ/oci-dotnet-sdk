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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// An individual question that the customer can answer about the CPE device.
    /// <br/>
    /// The customer provides answers to these questions in
    /// {@link #updateTunnelCpeDeviceConfig(UpdateTunnelCpeDeviceConfigRequest) updateTunnelCpeDeviceConfig}.
    /// 
    /// </summary>
    public class CpeDeviceConfigQuestion 
    {
        
        /// <value>
        /// A string that identifies the question.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// A descriptive label for the question (for example, to display in a form in a graphical interface).
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A description or explanation of the question, to help the customer answer accurately.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "explanation")]
        public string Explanation { get; set; }
        
    }
}
