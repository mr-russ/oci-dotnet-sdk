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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// training model details
    /// 
    /// </summary>
    public class ConfigurationDetails 
    {
        
        /// <value>
        /// model configuration details
        /// For PII : ConfigurationDetails will be PiiEntityMasking can be anyone of the following
        /// ex.{ \"mode\" : \"MASK\",\"maskingCharacter\" : \"&\",\"leaveCharactersUnmasked\": 3,\"isUnmaskedFromEnd\" : true  }
        ///    { \"mode\" : \"MASK\",\"replaceWith\" : \"&\"  }
        ///    { \"mode\" : \"REPLACE\" }
        /// For language translation :  { \"languageCodes\" : [\"cs\", \"ar\"]}
        /// Language code supported
        ///           Automatically detect language - auto
        ///           Arabic - ar
        ///           Brazilian Portuguese -  pt-BR
        ///           Czech - cs
        ///           Danish - da
        ///           Dutch - nl
        ///           English - en
        ///           Finnish - fi
        ///           French - fr
        ///           Canadian French - fr-CA
        ///           German - de
        ///           Italian - it
        ///           Japanese - ja
        ///           Korean - ko
        ///           Norwegian - no
        ///           Polish - pl
        ///           Romanian - ro
        ///           Simplified Chinese - zh-CN
        ///           Spanish - es
        ///           Swedish - sv
        ///           Traditional Chinese - zh-TW
        ///           Turkish - tr
        ///           Greek - el
        ///           Hebrew - he
        /// 
        /// </value>
        [JsonProperty(PropertyName = "configurationMap")]
        public System.Collections.Generic.Dictionary<string, string> ConfigurationMap { get; set; }
        
    }
}
