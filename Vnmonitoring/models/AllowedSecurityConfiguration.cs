/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the allowed security configuration for the traffic.
    /// </summary>
    [JsonConverter(typeof(AllowedSecurityConfigurationModelConverter))]
    public class AllowedSecurityConfiguration 
    {
                ///
        /// <value>
        /// The type of the allowed security configuration.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "NSG")]
            Nsg,
            [EnumMember(Value = "STATEFUL_NSG")]
            StatefulNsg,
            [EnumMember(Value = "INGRESS_SECURITY_LIST")]
            IngressSecurityList,
            [EnumMember(Value = "STATEFUL_INGRESS_SECURITY_LIST")]
            StatefulIngressSecurityList,
            [EnumMember(Value = "EGRESS_SECURITY_LIST")]
            EgressSecurityList,
            [EnumMember(Value = "STATEFUL_EGRESS_SECURITY_LIST")]
            StatefulEgressSecurityList
        };

        
    }

    public class AllowedSecurityConfigurationModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AllowedSecurityConfiguration);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AllowedSecurityConfiguration);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "STATEFUL_EGRESS_SECURITY_LIST":
                    obj = new StatefulEgressSecurityListConfiguration();
                    break;
                case "NSG":
                    obj = new NsgConfiguration();
                    break;
                case "INGRESS_SECURITY_LIST":
                    obj = new IngressSecurityListConfiguration();
                    break;
                case "STATEFUL_INGRESS_SECURITY_LIST":
                    obj = new StatefulIngressSecurityListConfiguration();
                    break;
                case "EGRESS_SECURITY_LIST":
                    obj = new EgressSecurityListConfiguration();
                    break;
                case "STATEFUL_NSG":
                    obj = new StatefulNsgConfiguration();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under AllowedSecurityConfiguration! Returning null value.");
            }
            return obj;
        }
    }
}
