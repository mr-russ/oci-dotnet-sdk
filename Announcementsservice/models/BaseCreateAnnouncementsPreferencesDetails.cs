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

namespace Oci.AnnouncementsService.Models
{
    /// <summary>
    /// The model for the parameters of announcement email preferences configured for the tenancy (root compartment).
    /// </summary>
    [JsonConverter(typeof(BaseCreateAnnouncementsPreferencesDetailsModelConverter))]
    public class BaseCreateAnnouncementsPreferencesDetails 
    {
        
        
        /// <value>
        /// A Boolean value to indicate whether the specified compartment chooses to not to receive informational announcements by email.
        /// (Manage preferences for receiving announcements by email by specifying the `preferenceType` attribute instead.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUnsubscribed")]
        public System.Nullable<bool> IsUnsubscribed { get; set; }
        
        /// <value>
        /// The OCID of the compartment for which you want to manage announcement email preferences. (Specify the tenancy by providing the
        /// root compartment OCID.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The string representing the user's preference, whether to opt in to only required announcements, to opt in to all announcements, including informational announcements, or to opt out of all announcements.
        /// </value>
        ///
        public enum PreferenceTypeEnum {
            [EnumMember(Value = "OPT_IN_TENANT_ANNOUNCEMENTS")]
            OptInTenantAnnouncements,
            [EnumMember(Value = "OPT_IN_TENANT_AND_INFORMATIONAL_ANNOUNCEMENTS")]
            OptInTenantAndInformationalAnnouncements,
            [EnumMember(Value = "OPT_OUT_ALL_ANNOUNCEMENTS")]
            OptOutAllAnnouncements
        };

        /// <value>
        /// The string representing the user's preference, whether to opt in to only required announcements, to opt in to all announcements, including informational announcements, or to opt out of all announcements.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PreferenceType is required.")]
        [JsonProperty(PropertyName = "preferenceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PreferenceTypeEnum> PreferenceType { get; set; }
        
    }

    public class BaseCreateAnnouncementsPreferencesDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseCreateAnnouncementsPreferencesDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseCreateAnnouncementsPreferencesDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "CreateAnnouncementsPreferencesDetails":
                    obj = new CreateAnnouncementsPreferencesDetails();
                    break;
                case "UpdateAnnouncementsPreferencesDetails":
                    obj = new UpdateAnnouncementsPreferencesDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
