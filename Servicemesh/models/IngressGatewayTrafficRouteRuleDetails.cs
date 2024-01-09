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
using Newtonsoft.Json.Linq;

namespace Oci.ServicemeshService.Models
{
    /// <summary>
    /// Rule for routing incoming ingress gateway traffic to a virtual service.
    /// </summary>
    [JsonConverter(typeof(IngressGatewayTrafficRouteRuleDetailsModelConverter))]
    public class IngressGatewayTrafficRouteRuleDetails 
    {
                ///
        /// <value>
        /// Type of protocol.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "HTTP")]
            Http,
            [EnumMember(Value = "TLS_PASSTHROUGH")]
            TlsPassthrough,
            [EnumMember(Value = "TCP")]
            Tcp
        };

        
        [JsonProperty(PropertyName = "ingressGatewayHost")]
        public IngressGatewayHostRef IngressGatewayHost { get; set; }
        
        /// <value>
        /// The destination of the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destinations is required.")]
        [JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.List<VirtualServiceTrafficRuleTargetDetails> Destinations { get; set; }
        
    }

    public class IngressGatewayTrafficRouteRuleDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(IngressGatewayTrafficRouteRuleDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(IngressGatewayTrafficRouteRuleDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "TLS_PASSTHROUGH":
                    obj = new TlsPassthroughIngressGatewayTrafficRouteRuleDetails();
                    break;
                case "TCP":
                    obj = new TcpIngressGatewayTrafficRouteRuleDetails();
                    break;
                case "HTTP":
                    obj = new HttpIngressGatewayTrafficRouteRuleDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
