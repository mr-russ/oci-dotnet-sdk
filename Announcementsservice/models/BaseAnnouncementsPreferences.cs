/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The object that contains the announcement email preferences configured for the tenancy (root compartment).
    /// </summary>
    [JsonConverter(typeof(BaseAnnouncementsPreferencesModelConverter))]
    public class BaseAnnouncementsPreferences 
    {
        
        
        /// <value>
        /// The OCID of the compartment for which the email preferences apply. Because announcements are
        /// specific to a tenancy, specify the tenancy by providing the root compartment OCID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The ID of the preferences.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A Boolean value to indicate whether the specified compartment chooses to not to receive informational announcements by email.
        /// (Manage preferences for receiving announcements by email by specifying the `preferenceType` attribute instead.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUnsubscribed")]
        public System.Nullable<bool> IsUnsubscribed { get; set; }
        
        /// <value>
        /// When the preferences were set initially.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// When the preferences were last updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The string representing the user's preference regarding receiving announcements by email.
        /// </value>
        [JsonProperty(PropertyName = "preferenceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BaseCreateAnnouncementsPreferencesDetails.PreferenceTypeEnum> PreferenceType { get; set; }
        
        /// <value>
        /// The time zone in which the user prefers to receive announcements. Specify the preference with a value that uses the IANA Time Zone Database format (x-obmcs-time-zone). For example - America/Los_Angeles
        /// </value>
        [JsonProperty(PropertyName = "preferredTimeZone")]
        public string PreferredTimeZone { get; set; }
        
    }

    public class BaseAnnouncementsPreferencesModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseAnnouncementsPreferences);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseAnnouncementsPreferences);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "AnnouncementsPreferencesSummary":
                    obj = new AnnouncementsPreferencesSummary();
                    break;
                case "AnnouncementsPreferences":
                    obj = new AnnouncementsPreferences();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
