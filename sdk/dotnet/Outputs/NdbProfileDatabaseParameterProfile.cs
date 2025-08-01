// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class NdbProfileDatabaseParameterProfile
    {
        /// <summary>
        /// Database parameters suuported for postgress.
        /// * `postgres_database.max_connections`: (Optional) Determines the maximum number of concurrent connections to the database server. The default is set to 100
        /// * `postgres_database.max_replication_slots`: (Optional) Specifies the maximum number of replication slots that the server can support. The default is zero. wal_level must be set to archive or higher to allow replication slots to be used. Setting it to a lower value than the number of currently existing replication slots will prevent the server from starting.
        /// * `postgres_database.effective_io_concurrency`: (Optional) Sets the number of concurrent disk I/O operations that PostgreSQL expects can be executed simultaneously. Raising this value will increase the number of I/O operations that any individual PostgreSQL session attempts to initiate in parallel.
        /// * `postgres_database.timezone`: (Optional) Sets the time zone for displaying and interpreting time stamps. Defult is UTC .
        /// * `postgres_database.max_prepared_transactions`: (Optional) Sets the maximum number of transactions that can be in the prepared state simultaneously. Setting this parameter to zero (which is the default) disables the prepared-transaction feature.
        /// * `postgres_database.max_locks_per_transaction`: (Optional) This parameter controls the average number of object locks allocated for each transaction; individual transactions can lock more objects as long as the locks of all transactions fit in the lock table. Default is 64.
        /// * `postgres_database.max_wal_senders`: (Optional) Specifies the maximum number of concurrent connections from standby servers or streaming base backup clients (i.e., the maximum number of simultaneously running WAL sender processes). The default is 10.
        /// * `postgres_database.max_worker_processes`: (Optional) Sets the maximum number of background processes that the system can support. The default is 8.
        /// * `postgres_database.min_wal_size`: (Optional) As long as WAL disk usage stays below this setting, old WAL files are always recycled for future use at a checkpoint, rather than removed. This can be used to ensure that enough WAL space is reserved to handle spikes in WAL usage, for example when running large batch jobs. The default is 80 MB.
        /// * `postgres_database.max_wal_size`: (Optional) Maximum size to let the WAL grow to between automatic WAL checkpoints. The default is 1 GB
        /// * `postgres_database.checkpoint_timeout`: (Optional) Sets the maximum time between automatic WAL checkpoints . High Value gives Good Performance, but takes More Recovery Time, Reboot time. can reduce the I/O load on your system, especially when using large values for shared_buffers. Default is 5min
        /// * `postgres_database.autovacuum`: (Optional) Controls whether the server should run the autovacuum launcher daemon. This is on by default; however, track_counts must also be enabled for autovacuum to work.
        /// * `postgres_database.checkpoint_completion_target`: (Optional)
        /// Specifies the target of checkpoint completion, as a fraction of total time between checkpoints. Time spent flushing dirty buffers during checkpoint, as fraction of checkpoint interval . Formula - (checkpoint_timeout - 2min) / checkpoint_timeout. The default is 0.5.
        /// * `postgres_database.autovacuum_freeze_max_age`: (Optional) Age at which to autovacuum a table to prevent transaction ID wraparound. Default is 200000000
        /// * `postgres_database.autovacuum_vacuum_threshold`: (Optional) Min number of row updates before vacuum. Minimum number of tuple updates or deletes prior to vacuum. Take value in KB. Default is 50 .
        /// * `postgres_database.autovacuum_vacuum_scale_factor`: (Optional) Number of tuple updates or deletes prior to vacuum as a fraction of reltuples. Default is 0.2
        /// * `postgres_database.autovacuum_work_mem`: (Optional) Sets the maximum memory to be used by each autovacuum worker process. Unit is in KB. Default is -1
        /// * `postgres_database.autovacuum_max_workers`: (Optional) Sets the maximum number of simultaneously running autovacuum worker processes. Default is 3
        /// * `postgres_database.autovacuum_vacuum_cost_delay`: (Optional) Vacuum cost delay in milliseconds, for autovacuum. Specifies the cost delay value that will be used in automatic VACUUM operation. Default is 2ms
        /// * `postgres_database.wal_buffers`: (Optional)
        /// Sets the number of disk-page buffers in shared memory for WAL. The amount of shared memory used for WAL data that has not yet been written to disk. The default is -1.
        /// * `postgres_database.synchronous_commit`: (Optional) Sets the current transaction's synchronization level. Specifies whether transaction commit will wait for WAL records to be written to disk before the command returns a success indication to the client. Default is on.
        /// * `postgres_database.random_page_cost`: (Optional) Sets the planner's estimate of the cost of a nonsequentially fetched disk page. Sets the planner's estimate of the cost of a non-sequentially-fetched disk page. The default is 4.0.
        /// * `postgres_database.wal_keep_segments`: (Optional) Sets the number of WAL files held for standby servers, Specifies the minimum number of past log file segments kept in the pg_wal directory. Default is 700 .
        /// </summary>
        public readonly ImmutableArray<Outputs.NdbProfileDatabaseParameterProfilePostgresDatabase> PostgresDatabases;

        [OutputConstructor]
        private NdbProfileDatabaseParameterProfile(ImmutableArray<Outputs.NdbProfileDatabaseParameterProfilePostgresDatabase> postgresDatabases)
        {
            PostgresDatabases = postgresDatabases;
        }
    }
}
