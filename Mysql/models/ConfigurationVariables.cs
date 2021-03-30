/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// User controllable service variables.
    /// </summary>
    public class ConfigurationVariables 
    {
                ///
        /// <value>
        /// (\"completion_type\")
        /// </value>
        ///
        public enum CompletionTypeEnum {
            [EnumMember(Value = "NO_CHAIN")]
            NoChain,
            [EnumMember(Value = "CHAIN")]
            Chain,
            [EnumMember(Value = "RELEASE")]
            Release
        };

        /// <value>
        /// (\"completion_type\")
        /// </value>
        [JsonProperty(PropertyName = "completionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CompletionTypeEnum> CompletionType { get; set; }
                ///
        /// <value>
        /// (\"default_authentication_plugin\")
        /// </value>
        ///
        public enum DefaultAuthenticationPluginEnum {
            [EnumMember(Value = "mysql_native_password")]
            MysqlNativePassword,
            [EnumMember(Value = "sha256_password")]
            Sha256Password,
            [EnumMember(Value = "caching_sha2_password")]
            CachingSha2Password
        };

        /// <value>
        /// (\"default_authentication_plugin\")
        /// </value>
        [JsonProperty(PropertyName = "defaultAuthenticationPlugin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DefaultAuthenticationPluginEnum> DefaultAuthenticationPlugin { get; set; }
                ///
        /// <value>
        /// (\"transaction_isolation\")
        /// </value>
        ///
        public enum TransactionIsolationEnum {
            [EnumMember(Value = "READ-UNCOMMITTED")]
            ReadUncommitted,
            [EnumMember(Value = "READ-COMMITED")]
            ReadCommited,
            [EnumMember(Value = "READ-COMMITTED")]
            ReadCommitted,
            [EnumMember(Value = "REPEATABLE-READ")]
            RepeatableRead,
            [EnumMember(Value = "SERIALIZABLE")]
            Serializable
        };

        /// <value>
        /// (\"transaction_isolation\")
        /// </value>
        [JsonProperty(PropertyName = "transactionIsolation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TransactionIsolationEnum> TransactionIsolation { get; set; }
        
        /// <value>
        /// (\"innodb_ft_server_stopword_table\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtServerStopwordTable")]
        public string InnodbFtServerStopwordTable { get; set; }
        
        /// <value>
        /// (\"mandatory_roles\")
        /// </value>
        [JsonProperty(PropertyName = "mandatoryRoles")]
        public string MandatoryRoles { get; set; }
        
        /// <value>
        /// (\"autocommit\")
        /// </value>
        [JsonProperty(PropertyName = "autocommit")]
        public System.Nullable<bool> Autocommit { get; set; }
        
        /// <value>
        /// (\"foreign_key_checks\")
        /// </value>
        [JsonProperty(PropertyName = "foreignKeyChecks")]
        public System.Nullable<bool> ForeignKeyChecks { get; set; }
                ///
        /// <value>
        /// - EVENTUAL:
        ///     Both RO and RW transactions do not wait for preceding transactions to be applied before executing.
        ///     A RW transaction does not wait for other members to apply a transaction. This means that a transaction
        ///     could be externalized on one member before the others. This also means that in the event of a primary failover,
        ///     the new primary can accept new RO and RW transactions before the previous primary transactions are all applied.
        ///     RO transactions could result in outdated values, RW transactions could result in a rollback due to conflicts.
        /// - BEFORE_ON_PRIMARY_FAILOVER:
        ///     New RO or RW transactions with a newly elected primary that is applying backlog from the old
        ///     primary are held (not applied) until any backlog has been applied. This ensures that when a primary failover happens,
        ///     intentionally or not, clients always see the latest value on the primary. This guarantees consistency, but means that
        ///     clients must be able to handle the delay in the event that a backlog is being applied. Usually this delay should be minimal,
        ///     but does depend on the size of the backlog.
        /// - BEFORE:
        ///     A RW transaction waits for all preceding transactions to complete before being applied. A RO transaction waits for all preceding
        ///     transactions to complete before being executed. This ensures that this transaction reads the latest value by only affecting the
        ///     latency of the transaction. This reduces the overhead of synchronization on every RW transaction, by ensuring synchronization is
        ///     used only on RO transactions. This consistency level also includes the consistency guarantees provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// - AFTER:
        ///     A RW transaction waits until its changes have been applied to all of the other members. This value has no effect on RO transactions.
        ///     This mode ensures that when a transaction is committed on the local member, any subsequent transaction reads the written value or
        ///     a more recent value on any group member. Use this mode with a group that is used for predominantly RO operations to ensure that
        ///     applied RW transactions are applied everywhere once they commit. This could be used by your application to ensure that subsequent
        ///     reads fetch the latest data which includes the latest writes. This reduces the overhead of synchronization on every RO transaction,
        ///     by ensuring synchronization is used only on RW transactions. This consistency level also includes the consistency guarantees
        ///     provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// - BEFORE_AND_AFTER:
        ///     A RW transaction waits for 1) all preceding transactions to complete before being applied and 2) until its changes have been
        ///     applied on other members. A RO transaction waits for all preceding transactions to complete before execution takes place.
        ///     This consistency level also includes the consistency guarantees provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// 
        /// </value>
        ///
        public enum GroupReplicationConsistencyEnum {
            [EnumMember(Value = "EVENTUAL")]
            Eventual,
            [EnumMember(Value = "BEFORE_ON_PRIMARY_FAILOVER")]
            BeforeOnPrimaryFailover,
            [EnumMember(Value = "BEFORE")]
            Before,
            [EnumMember(Value = "AFTER")]
            After,
            [EnumMember(Value = "BEFORE_AND_AFTER")]
            BeforeAndAfter
        };

        /// <value>
        /// - EVENTUAL:
        ///     Both RO and RW transactions do not wait for preceding transactions to be applied before executing.
        ///     A RW transaction does not wait for other members to apply a transaction. This means that a transaction
        ///     could be externalized on one member before the others. This also means that in the event of a primary failover,
        ///     the new primary can accept new RO and RW transactions before the previous primary transactions are all applied.
        ///     RO transactions could result in outdated values, RW transactions could result in a rollback due to conflicts.
        /// - BEFORE_ON_PRIMARY_FAILOVER:
        ///     New RO or RW transactions with a newly elected primary that is applying backlog from the old
        ///     primary are held (not applied) until any backlog has been applied. This ensures that when a primary failover happens,
        ///     intentionally or not, clients always see the latest value on the primary. This guarantees consistency, but means that
        ///     clients must be able to handle the delay in the event that a backlog is being applied. Usually this delay should be minimal,
        ///     but does depend on the size of the backlog.
        /// - BEFORE:
        ///     A RW transaction waits for all preceding transactions to complete before being applied. A RO transaction waits for all preceding
        ///     transactions to complete before being executed. This ensures that this transaction reads the latest value by only affecting the
        ///     latency of the transaction. This reduces the overhead of synchronization on every RW transaction, by ensuring synchronization is
        ///     used only on RO transactions. This consistency level also includes the consistency guarantees provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// - AFTER:
        ///     A RW transaction waits until its changes have been applied to all of the other members. This value has no effect on RO transactions.
        ///     This mode ensures that when a transaction is committed on the local member, any subsequent transaction reads the written value or
        ///     a more recent value on any group member. Use this mode with a group that is used for predominantly RO operations to ensure that
        ///     applied RW transactions are applied everywhere once they commit. This could be used by your application to ensure that subsequent
        ///     reads fetch the latest data which includes the latest writes. This reduces the overhead of synchronization on every RO transaction,
        ///     by ensuring synchronization is used only on RW transactions. This consistency level also includes the consistency guarantees
        ///     provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// - BEFORE_AND_AFTER:
        ///     A RW transaction waits for 1) all preceding transactions to complete before being applied and 2) until its changes have been
        ///     applied on other members. A RO transaction waits for all preceding transactions to complete before execution takes place.
        ///     This consistency level also includes the consistency guarantees provided by BEFORE_ON_PRIMARY_FAILOVER.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "groupReplicationConsistency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<GroupReplicationConsistencyEnum> GroupReplicationConsistency { get; set; }
        
        /// <value>
        /// (\"innodb_ft_enable_stopword\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtEnableStopword")]
        public System.Nullable<bool> InnodbFtEnableStopword { get; set; }
        
        /// <value>
        /// (\"local_infile\")
        /// </value>
        [JsonProperty(PropertyName = "localInfile")]
        public System.Nullable<bool> LocalInfile { get; set; }
        
        /// <value>
        /// (\"mysql_firewall_mode\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlFirewallMode")]
        public System.Nullable<bool> MysqlFirewallMode { get; set; }
        
        /// <value>
        /// (\"mysqlx_enable_hello_notice\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxEnableHelloNotice")]
        public System.Nullable<bool> MysqlxEnableHelloNotice { get; set; }
        
        /// <value>
        /// (\"sql_require_primary_key\")
        /// </value>
        [JsonProperty(PropertyName = "sqlRequirePrimaryKey")]
        public System.Nullable<bool> SqlRequirePrimaryKey { get; set; }
        
        /// <value>
        /// (\"sql_warnings\")
        /// </value>
        [JsonProperty(PropertyName = "sqlWarnings")]
        public System.Nullable<bool> SqlWarnings { get; set; }
        
        /// <value>
        /// (\"binlog_expire_logs_seconds\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "binlogExpireLogsSeconds")]
        public System.Nullable<int> BinlogExpireLogsSeconds { get; set; }
        
        /// <value>
        /// (\"innodb_buffer_pool_size\")
        /// </value>
        [JsonProperty(PropertyName = "innodbBufferPoolSize")]
        public System.Nullable<long> InnodbBufferPoolSize { get; set; }
        
        /// <value>
        /// (\"innodb_ft_result_cache_limit\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtResultCacheLimit")]
        public System.Nullable<int> InnodbFtResultCacheLimit { get; set; }
        
        /// <value>
        /// (\"max_connections\")
        /// </value>
        [JsonProperty(PropertyName = "maxConnections")]
        public System.Nullable<int> MaxConnections { get; set; }
        
        /// <value>
        /// (\"max_prepared_stmt_count\")
        /// </value>
        [JsonProperty(PropertyName = "maxPreparedStmtCount")]
        public System.Nullable<int> MaxPreparedStmtCount { get; set; }
        
        /// <value>
        /// (\"connect_timeout\")
        /// </value>
        [JsonProperty(PropertyName = "connectTimeout")]
        public System.Nullable<int> ConnectTimeout { get; set; }
        
        /// <value>
        /// (\"cte_max_recursion_depth\")
        /// </value>
        [JsonProperty(PropertyName = "cteMaxRecursionDepth")]
        public System.Nullable<int> CteMaxRecursionDepth { get; set; }
        
        /// <value>
        /// (\"generated_random_password_length\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "generatedRandomPasswordLength")]
        public System.Nullable<int> GeneratedRandomPasswordLength { get; set; }
        
        /// <value>
        /// (\"information_schema_stats_expiry\")
        /// </value>
        [JsonProperty(PropertyName = "informationSchemaStatsExpiry")]
        public System.Nullable<int> InformationSchemaStatsExpiry { get; set; }
        
        /// <value>
        /// (\"innodb_buffer_pool_instances\")
        /// </value>
        [JsonProperty(PropertyName = "innodbBufferPoolInstances")]
        public System.Nullable<int> InnodbBufferPoolInstances { get; set; }
        
        /// <value>
        /// (\"innodb_ft_max_token_size\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtMaxTokenSize")]
        public System.Nullable<int> InnodbFtMaxTokenSize { get; set; }
        
        /// <value>
        /// (\"innodb_ft_min_token_size\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtMinTokenSize")]
        public System.Nullable<int> InnodbFtMinTokenSize { get; set; }
        
        /// <value>
        /// (\"innodb_ft_num_word_optimize\")
        /// </value>
        [JsonProperty(PropertyName = "innodbFtNumWordOptimize")]
        public System.Nullable<int> InnodbFtNumWordOptimize { get; set; }
        
        /// <value>
        /// (\"innodb_lock_wait_timeout\")
        /// </value>
        [JsonProperty(PropertyName = "innodbLockWaitTimeout")]
        public System.Nullable<int> InnodbLockWaitTimeout { get; set; }
        
        /// <value>
        /// (\"innodb_max_purge_lag\")
        /// </value>
        [JsonProperty(PropertyName = "innodbMaxPurgeLag")]
        public System.Nullable<int> InnodbMaxPurgeLag { get; set; }
        
        /// <value>
        /// (\"innodb_max_purge_lag_delay\")
        /// </value>
        [JsonProperty(PropertyName = "innodbMaxPurgeLagDelay")]
        public System.Nullable<int> InnodbMaxPurgeLagDelay { get; set; }
        
        /// <value>
        /// (\"max_execution_time\")
        /// </value>
        [JsonProperty(PropertyName = "maxExecutionTime")]
        public System.Nullable<int> MaxExecutionTime { get; set; }
        
        /// <value>
        /// (\"mysqlx_connect_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxConnectTimeout")]
        public System.Nullable<int> MysqlxConnectTimeout { get; set; }
        
        /// <value>
        /// (\"mysqlx_document_id_unique_prefix\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxDocumentIdUniquePrefix")]
        public System.Nullable<int> MysqlxDocumentIdUniquePrefix { get; set; }
        
        /// <value>
        /// (\"mysqlx_idle_worker_thread_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxIdleWorkerThreadTimeout")]
        public System.Nullable<int> MysqlxIdleWorkerThreadTimeout { get; set; }
        
        /// <value>
        /// (\"mysqlx_interactive_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxInteractiveTimeout")]
        public System.Nullable<int> MysqlxInteractiveTimeout { get; set; }
        
        /// <value>
        /// (\"mysqlx_max_allowed_packet\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxMaxAllowedPacket")]
        public System.Nullable<int> MysqlxMaxAllowedPacket { get; set; }
        
        /// <value>
        /// (\"mysqlx_min_worker_threads\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxMinWorkerThreads")]
        public System.Nullable<int> MysqlxMinWorkerThreads { get; set; }
        
        /// <value>
        /// (\"mysqlx_read_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxReadTimeout")]
        public System.Nullable<int> MysqlxReadTimeout { get; set; }
        
        /// <value>
        /// (\"mysqlx_wait_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxWaitTimeout")]
        public System.Nullable<int> MysqlxWaitTimeout { get; set; }
        
        /// <value>
        /// (\"mysqlx_write_timeout\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "mysqlxWriteTimeout")]
        public System.Nullable<int> MysqlxWriteTimeout { get; set; }
        
        /// <value>
        /// (\"parser_max_mem_size\")
        /// </value>
        [JsonProperty(PropertyName = "parserMaxMemSize")]
        public System.Nullable<int> ParserMaxMemSize { get; set; }
        
        /// <value>
        /// (\"query_alloc_block_size\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "queryAllocBlockSize")]
        public System.Nullable<int> QueryAllocBlockSize { get; set; }
        
        /// <value>
        /// (\"query_prealloc_size\") DEPRECATED -- variable should not be settable and will be ignored
        /// </value>
        [JsonProperty(PropertyName = "queryPreallocSize")]
        public System.Nullable<int> QueryPreallocSize { get; set; }
        
        /// <value>
        /// (\"sql_mode\")
        /// </value>
        [JsonProperty(PropertyName = "sqlMode")]
        public string SqlMode { get; set; }
        
        /// <value>
        /// Set the default compression level for the deflate algorithm. (\"mysqlx_deflate_default_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxDeflateDefaultCompressionLevel")]
        public System.Nullable<int> MysqlxDeflateDefaultCompressionLevel { get; set; }
        
        /// <value>
        /// Limit the upper bound of accepted compression levels for the deflate algorithm. (\"mysqlx_deflate_max_client_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxDeflateMaxClientCompressionLevel")]
        public System.Nullable<int> MysqlxDeflateMaxClientCompressionLevel { get; set; }
        
        /// <value>
        /// Limit the upper bound of accepted compression levels for the lz4 algorithm. (\"mysqlx_lz4_max_client_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxLz4MaxClientCompressionLevel")]
        public System.Nullable<int> MysqlxLz4MaxClientCompressionLevel { get; set; }
        
        /// <value>
        /// Set the default compression level for the lz4 algorithm. (\"mysqlx_lz4_default_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxLz4DefaultCompressionLevel")]
        public System.Nullable<int> MysqlxLz4DefaultCompressionLevel { get; set; }
        
        /// <value>
        /// Limit the upper bound of accepted compression levels for the zstd algorithm. (\"mysqlx_zstd_max_client_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxZstdMaxClientCompressionLevel")]
        public System.Nullable<int> MysqlxZstdMaxClientCompressionLevel { get; set; }
        
        /// <value>
        /// Set the default compression level for the zstd algorithm. (\"mysqlx_zstd_default_compression_level\")
        /// </value>
        [JsonProperty(PropertyName = "mysqlxZstdDefaultCompressionLevel")]
        public System.Nullable<int> MysqlxZstdDefaultCompressionLevel { get; set; }
        
        /// <value>
        /// DEPRECATED -- typo of mysqlx_zstd_default_compression_level. variable will be ignored.
        /// </value>
        [JsonProperty(PropertyName = "mysqlZstdDefaultCompressionLevel")]
        public System.Nullable<int> MysqlZstdDefaultCompressionLevel { get; set; }
        
    }
}
