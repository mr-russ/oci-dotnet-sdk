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
    /// Resource representing the location of the TLS certificate.
    /// </summary>
    [JsonConverter(typeof(TlsCertificateModelConverter))]
    public class TlsCertificate 
    {
                ///
        /// <value>
        /// Type of certificate.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "OCI_CERTIFICATES")]
            OciCertificates,
            [EnumMember(Value = "LOCAL_FILE")]
            LocalFile
        };

        
    }

    public class TlsCertificateModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TlsCertificate);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TlsCertificate);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OCI_CERTIFICATES":
                    obj = new OciTlsCertificate();
                    break;
                case "LOCAL_FILE":
                    obj = new LocalFileTlsCertificate();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TlsCertificate! Returning null value.");
            }
            return obj;
        }
    }
}
