/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OdaService.Models
{
  /// <summary>
  /// The set of supported Channel types.
  /// </summary>
  public enum ChannelType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ANDROID")]
      Android,
      [EnumMember(Value = "APPEVENT")]
      Appevent,
      [EnumMember(Value = "APPLICATION")]
      Application,
      [EnumMember(Value = "CORTANA")]
      Cortana,
      [EnumMember(Value = "FACEBOOK")]
      Facebook,
      [EnumMember(Value = "IOS")]
      Ios,
      [EnumMember(Value = "MSTEAMS")]
      Msteams,
      [EnumMember(Value = "OSS")]
      Oss,
      [EnumMember(Value = "OSVC")]
      Osvc,
      [EnumMember(Value = "SERVICECLOUD")]
      Servicecloud,
      [EnumMember(Value = "SLACK")]
      Slack,
      [EnumMember(Value = "TEST")]
      Test,
      [EnumMember(Value = "TWILIO")]
      Twilio,
      [EnumMember(Value = "WEB")]
      Web,
      [EnumMember(Value = "WEBHOOK")]
      Webhook
  }
}
