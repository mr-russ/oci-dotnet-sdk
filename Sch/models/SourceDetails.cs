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

namespace Oci.SchService.Models
{
    /// <summary>
    /// An object that represents the source of the flow defined by the service connector.
    /// An example source is the VCNFlow logs within the NetworkLogs group.
    /// For more information about flows defined by service connectors, see
    /// [Service Connector Hub Overview](https://docs.cloud.oracle.com/iaas/Content/service-connector-hub/overview.htm).
    /// For configuration instructions, see
    /// [To create a service connector](https://docs.cloud.oracle.com/iaas/Content/service-connector-hub/managingconnectors.htm#create).
    /// 
    /// </summary>
    [JsonConverter(typeof(SourceDetailsModelConverter))]
    public class SourceDetails 
    {
                ///
        /// <value>
        /// The type descriminator.
        /// 
        /// </value>
        ///
        public enum KindEnum {
            [EnumMember(Value = "logging")]
            Logging,
            [EnumMember(Value = "monitoring")]
            Monitoring,
            [EnumMember(Value = "streaming")]
            Streaming
        };

        
    }

    public class SourceDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SourceDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SourceDetails);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "logging":
                    obj = new LoggingSourceDetails();
                    break;
                case "monitoring":
                    obj = new MonitoringSourceDetails();
                    break;
                case "streaming":
                    obj = new StreamingSourceDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SourceDetails! Returning null value.");
            }
            return obj;
        }
    }
}
