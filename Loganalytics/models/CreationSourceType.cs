/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LoganalyticsService.Models
{
  /// <summary>
  /// Entities are auto-created when enterprise manager bridge is configured in logging analytics, or
    /// when logs are forwarded from service connector or through bulk discovery from object store.
    /// 
  /// </summary>
  public enum CreationSourceType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "EM_BRIDGE")]
      EmBridge,
      [EnumMember(Value = "BULK_DISCOVERY")]
      BulkDiscovery,
      [EnumMember(Value = "SERVICE_CONNECTOR_HUB")]
      ServiceConnectorHub,
      [EnumMember(Value = "DISCOVERY")]
      Discovery,
      [EnumMember(Value = "NONE")]
      None
  }
}
