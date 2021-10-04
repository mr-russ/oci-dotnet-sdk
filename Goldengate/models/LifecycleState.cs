/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.GoldengateService.Models
{
  /// <summary>
  /// Possible lifecycle states.
    /// 
  /// </summary>
  public enum LifecycleState {
      [EnumMember(Value = "CREATING")]
      Creating,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "NEEDS_ATTENTION")]
      NeedsAttention,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "CANCELING")]
      Canceling,
      [EnumMember(Value = "CANCELED")]
      Canceled,
      [EnumMember(Value = "SUCCEEDED")]
      Succeeded
  }
}
