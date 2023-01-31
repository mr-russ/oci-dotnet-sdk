/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OpensearchService.Models
{
  /// <summary>
  /// The types of operations that spawn work requests.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_OPENSEARCH_CLUSTER")]
      CreateOpensearchCluster,
      [EnumMember(Value = "UPDATE_OPENSEARCH_CLUSTER")]
      UpdateOpensearchCluster,
      [EnumMember(Value = "DELETE_OPENSEARCH_CLUSTER")]
      DeleteOpensearchCluster,
      [EnumMember(Value = "MOVE_OPENSEARCH_CLUSTER")]
      MoveOpensearchCluster,
      [EnumMember(Value = "RESTORE_OPENSEARCH_CLUSTER")]
      RestoreOpensearchCluster,
      [EnumMember(Value = "BACKUP_OPENSEARCH_CLUSTER")]
      BackupOpensearchCluster,
      [EnumMember(Value = "UPDATE_OPENSEARCH_CLUSTER_BACKUP")]
      UpdateOpensearchClusterBackup,
      [EnumMember(Value = "MOVE_OPENSEARCH_CLUSTER_BACKUP")]
      MoveOpensearchClusterBackup,
      [EnumMember(Value = "DELETE_OPENSEARCH_CLUSTER_BACKUP")]
      DeleteOpensearchClusterBackup,
      [EnumMember(Value = "UPDATE_OPENSEARCH_CLUSTER_SECURITY_CONFIG")]
      UpdateOpensearchClusterSecurityConfig
  }
}
