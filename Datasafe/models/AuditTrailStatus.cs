/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatasafeService.Models
{
  /// <summary>
  /// The current sub-state of the audit trail.
  /// </summary>
  public enum AuditTrailStatus {
      [EnumMember(Value = "STARTING")]
      Starting,
      [EnumMember(Value = "COLLECTING")]
      Collecting,
      [EnumMember(Value = "RECOVERING")]
      Recovering,
      [EnumMember(Value = "IDLE")]
      Idle,
      [EnumMember(Value = "STOPPING")]
      Stopping,
      [EnumMember(Value = "STOPPED")]
      Stopped,
      [EnumMember(Value = "RESUMING")]
      Resuming,
      [EnumMember(Value = "RETRYING")]
      Retrying
  }
}
