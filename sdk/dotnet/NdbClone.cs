// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    /// <summary>
    /// Provides a resource to perform the clone of database instance based on the input parameters.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nutanix = PiersKarsenbarg.Nutanix;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var name = new Nutanix.NdbClone("name", new()
    ///     {
    ///         ComputeProfileId = "{{ compute_profile_id }}",
    ///         CreateDbserver = true,
    ///         DatabaseParameterProfileId = "{{ databse_profile_id }}",
    ///         NetworkProfileId = "{{ network_profile_id }}",
    ///         Nodes = new[]
    ///         {
    ///             new Nutanix.Inputs.NdbCloneNodeArgs
    ///             {
    ///                 ComputeProfileId = "{{ compute_profile_id }}",
    ///                 NetworkProfileId = "{{ network_profile_id }}",
    ///                 NxClusterId = "{{ nx_Cluster_id }}",
    ///                 VmName = "test_vm_clone",
    ///             },
    ///         },
    ///         NxClusterId = "{{ nx_Cluster_id }}",
    ///         PostgresqlInfos = new[]
    ///         {
    ///             new Nutanix.Inputs.NdbClonePostgresqlInfoArgs
    ///             {
    ///                 DbPassword = "pass",
    ///                 VmName = "test_vm_clone",
    ///             },
    ///         },
    ///         SshPublicKey = "{{ sshkey }}",
    ///         TimeMachineName = "test-pg-inst",
    ///         TimeZone = "Asia/Calcutta",
    ///         UserPitrTimestamp = "{{ point_in_time }}",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NutanixResourceType("nutanix:index/ndbClone:NdbClone")]
    public partial class NdbClone : global::Pulumi.CustomResource
    {
        /// <summary>
        /// if any action arguments is required
        /// </summary>
        [Output("actionarguments")]
        public Output<ImmutableArray<Outputs.NdbCloneActionargument>> Actionarguments { get; private set; } = null!;

        /// <summary>
        /// cloned or not
        /// </summary>
        [Output("clone")]
        public Output<bool> Clone { get; private set; } = null!;

        /// <summary>
        /// clone will be clustered or not
        /// </summary>
        [Output("clustered")]
        public Output<bool?> Clustered { get; private set; } = null!;

        /// <summary>
        /// specify the compute profile id
        /// </summary>
        [Output("computeProfileId")]
        public Output<string?> ComputeProfileId { get; private set; } = null!;

        /// <summary>
        /// create new dbserver
        /// </summary>
        [Output("createDbserver")]
        public Output<bool?> CreateDbserver { get; private set; } = null!;

        /// <summary>
        /// database cluster type
        /// </summary>
        [Output("databaseClusterType")]
        public Output<string> DatabaseClusterType { get; private set; } = null!;

        /// <summary>
        /// database name
        /// </summary>
        [Output("databaseName")]
        public Output<string> DatabaseName { get; private set; } = null!;

        /// <summary>
        /// database nodes associated with database instance
        /// </summary>
        [Output("databaseNodes")]
        public Output<ImmutableArray<Outputs.NdbCloneDatabaseNode>> DatabaseNodes { get; private set; } = null!;

        /// <summary>
        /// specify the database parameter profile id
        /// </summary>
        [Output("databaseParameterProfileId")]
        public Output<string?> DatabaseParameterProfileId { get; private set; } = null!;

        /// <summary>
        /// date created for clone
        /// </summary>
        [Output("dateCreated")]
        public Output<string> DateCreated { get; private set; } = null!;

        /// <summary>
        /// last modified date for clone
        /// </summary>
        [Output("dateModified")]
        public Output<string> DateModified { get; private set; } = null!;

        /// <summary>
        /// dbserver cluster id
        /// </summary>
        [Output("dbserverClusterId")]
        public Output<string?> DbserverClusterId { get; private set; } = null!;

        /// <summary>
        /// Specify if you want to create a database server. This value can be set to true or false as required.
        /// </summary>
        [Output("dbserverId")]
        public Output<string?> DbserverId { get; private set; } = null!;

        /// <summary>
        /// dbserver logical cluster
        /// </summary>
        [Output("dbserverLogicalCluster")]
        public Output<ImmutableDictionary<string, string>> DbserverLogicalCluster { get; private set; } = null!;

        /// <summary>
        /// dbserver logical cluster id
        /// </summary>
        [Output("dbserverLogicalClusterId")]
        public Output<string?> DbserverLogicalClusterId { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Delete the database clone from the VM. Default value is true
        /// </summary>
        [Output("delete")]
        public Output<bool?> Delete { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Delete the logical cluster. Default is true
        /// </summary>
        [Output("deleteLogicalCluster")]
        public Output<bool?> DeleteLogicalCluster { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
        /// </summary>
        [Output("deleteTimeMachine")]
        public Output<bool?> DeleteTimeMachine { get; private set; } = null!;

        /// <summary>
        /// database instance description
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Force delete of instance. Default is false
        /// </summary>
        [Output("forced")]
        public Output<bool?> Forced { get; private set; } = null!;

        /// <summary>
        /// info of clone
        /// </summary>
        [Output("infos")]
        public Output<ImmutableArray<Outputs.NdbCloneInfo>> Infos { get; private set; } = null!;

        /// <summary>
        /// latest snapshot
        /// </summary>
        [Output("latestSnapshot")]
        public Output<bool?> LatestSnapshot { get; private set; } = null!;

        /// <summary>
        /// LCM Config contains the expiry details and refresh details
        /// </summary>
        [Output("lcmConfigs")]
        public Output<ImmutableArray<Outputs.NdbCloneLcmConfig>> LcmConfigs { get; private set; } = null!;

        /// <summary>
        /// linked databases within database instance
        /// </summary>
        [Output("linkedDatabases")]
        public Output<ImmutableArray<Outputs.NdbCloneLinkedDatabase>> LinkedDatabases { get; private set; } = null!;

        /// <summary>
        /// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
        /// </summary>
        [Output("metric")]
        public Output<ImmutableDictionary<string, string>> Metric { get; private set; } = null!;

        /// <summary>
        /// database instance name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// specify the network profile id
        /// </summary>
        [Output("networkProfileId")]
        public Output<string?> NetworkProfileId { get; private set; } = null!;

        /// <summary>
        /// Node count. Default is 1 for single instance
        /// </summary>
        [Output("nodeCount")]
        public Output<int?> NodeCount { get; private set; } = null!;

        /// <summary>
        /// Nodes contain info about dbservers vm
        /// </summary>
        [Output("nodes")]
        public Output<ImmutableArray<Outputs.NdbCloneNode>> Nodes { get; private set; } = null!;

        /// <summary>
        /// cluster id on where clone will be present
        /// </summary>
        [Output("nxClusterId")]
        public Output<string> NxClusterId { get; private set; } = null!;

        [Output("parentDatabaseId")]
        public Output<string> ParentDatabaseId { get; private set; } = null!;

        /// <summary>
        /// postgresql info for the clone
        /// </summary>
        [Output("postgresqlInfos")]
        public Output<ImmutableArray<Outputs.NdbClonePostgresqlInfo>> PostgresqlInfos { get; private set; } = null!;

        /// <summary>
        /// List of all the properties
        /// </summary>
        [Output("properties")]
        public Output<ImmutableArray<Outputs.NdbCloneProperty>> Properties { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Unregister the database clone from NDB. Default value is false
        /// </summary>
        [Output("remove")]
        public Output<bool?> Remove { get; private set; } = null!;

        /// <summary>
        /// remove logical cluster. Default value is false
        /// </summary>
        [Output("removeLogicalCluster")]
        public Output<bool?> RemoveLogicalCluster { get; private set; } = null!;

        /// <summary>
        /// snapshot id from where clone is created
        /// </summary>
        [Output("snapshotId")]
        public Output<string?> SnapshotId { get; private set; } = null!;

        /// <summary>
        /// - (Optional) Soft remove. Default will be false
        /// </summary>
        [Output("softRemove")]
        public Output<bool?> SoftRemove { get; private set; } = null!;

        /// <summary>
        /// ssh public key
        /// </summary>
        [Output("sshPublicKey")]
        public Output<string?> SshPublicKey { get; private set; } = null!;

        /// <summary>
        /// status of clone
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.NdbCloneTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// time machine id
        /// </summary>
        [Output("timeMachineId")]
        public Output<string?> TimeMachineId { get; private set; } = null!;

        /// <summary>
        /// time machine name
        /// </summary>
        [Output("timeMachineName")]
        public Output<string?> TimeMachineName { get; private set; } = null!;

        [Output("timeMachines")]
        public Output<ImmutableArray<Outputs.NdbCloneTimeMachine>> TimeMachines { get; private set; } = null!;

        /// <summary>
        /// timezone
        /// </summary>
        [Output("timeZone")]
        public Output<string> TimeZone { get; private set; } = null!;

        /// <summary>
        /// type of clone
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// point in time for clone to be created
        /// </summary>
        [Output("userPitrTimestamp")]
        public Output<string?> UserPitrTimestamp { get; private set; } = null!;

        /// <summary>
        /// vm password
        /// </summary>
        [Output("vmPassword")]
        public Output<string?> VmPassword { get; private set; } = null!;


        /// <summary>
        /// Create a NdbClone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NdbClone(string name, NdbCloneArgs args, CustomResourceOptions? options = null)
            : base("nutanix:index/ndbClone:NdbClone", name, args ?? new NdbCloneArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NdbClone(string name, Input<string> id, NdbCloneState? state = null, CustomResourceOptions? options = null)
            : base("nutanix:index/ndbClone:NdbClone", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-nutanix",
                AdditionalSecretOutputs =
                {
                    "sshPublicKey",
                    "vmPassword",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NdbClone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NdbClone Get(string name, Input<string> id, NdbCloneState? state = null, CustomResourceOptions? options = null)
        {
            return new NdbClone(name, id, state, options);
        }
    }

    public sealed class NdbCloneArgs : global::Pulumi.ResourceArgs
    {
        [Input("actionarguments")]
        private InputList<Inputs.NdbCloneActionargumentArgs>? _actionarguments;

        /// <summary>
        /// if any action arguments is required
        /// </summary>
        public InputList<Inputs.NdbCloneActionargumentArgs> Actionarguments
        {
            get => _actionarguments ?? (_actionarguments = new InputList<Inputs.NdbCloneActionargumentArgs>());
            set => _actionarguments = value;
        }

        /// <summary>
        /// clone will be clustered or not
        /// </summary>
        [Input("clustered")]
        public Input<bool>? Clustered { get; set; }

        /// <summary>
        /// specify the compute profile id
        /// </summary>
        [Input("computeProfileId")]
        public Input<string>? ComputeProfileId { get; set; }

        /// <summary>
        /// create new dbserver
        /// </summary>
        [Input("createDbserver")]
        public Input<bool>? CreateDbserver { get; set; }

        /// <summary>
        /// specify the database parameter profile id
        /// </summary>
        [Input("databaseParameterProfileId")]
        public Input<string>? DatabaseParameterProfileId { get; set; }

        /// <summary>
        /// dbserver cluster id
        /// </summary>
        [Input("dbserverClusterId")]
        public Input<string>? DbserverClusterId { get; set; }

        /// <summary>
        /// Specify if you want to create a database server. This value can be set to true or false as required.
        /// </summary>
        [Input("dbserverId")]
        public Input<string>? DbserverId { get; set; }

        /// <summary>
        /// dbserver logical cluster id
        /// </summary>
        [Input("dbserverLogicalClusterId")]
        public Input<string>? DbserverLogicalClusterId { get; set; }

        /// <summary>
        /// - (Optional) Delete the database clone from the VM. Default value is true
        /// </summary>
        [Input("delete")]
        public Input<bool>? Delete { get; set; }

        /// <summary>
        /// - (Optional) Delete the logical cluster. Default is true
        /// </summary>
        [Input("deleteLogicalCluster")]
        public Input<bool>? DeleteLogicalCluster { get; set; }

        /// <summary>
        /// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
        /// </summary>
        [Input("deleteTimeMachine")]
        public Input<bool>? DeleteTimeMachine { get; set; }

        /// <summary>
        /// database instance description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// - (Optional) Force delete of instance. Default is false
        /// </summary>
        [Input("forced")]
        public Input<bool>? Forced { get; set; }

        /// <summary>
        /// latest snapshot
        /// </summary>
        [Input("latestSnapshot")]
        public Input<bool>? LatestSnapshot { get; set; }

        [Input("lcmConfigs")]
        private InputList<Inputs.NdbCloneLcmConfigArgs>? _lcmConfigs;

        /// <summary>
        /// LCM Config contains the expiry details and refresh details
        /// </summary>
        public InputList<Inputs.NdbCloneLcmConfigArgs> LcmConfigs
        {
            get => _lcmConfigs ?? (_lcmConfigs = new InputList<Inputs.NdbCloneLcmConfigArgs>());
            set => _lcmConfigs = value;
        }

        /// <summary>
        /// database instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// specify the network profile id
        /// </summary>
        [Input("networkProfileId")]
        public Input<string>? NetworkProfileId { get; set; }

        /// <summary>
        /// Node count. Default is 1 for single instance
        /// </summary>
        [Input("nodeCount")]
        public Input<int>? NodeCount { get; set; }

        [Input("nodes", required: true)]
        private InputList<Inputs.NdbCloneNodeArgs>? _nodes;

        /// <summary>
        /// Nodes contain info about dbservers vm
        /// </summary>
        public InputList<Inputs.NdbCloneNodeArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.NdbCloneNodeArgs>());
            set => _nodes = value;
        }

        /// <summary>
        /// cluster id on where clone will be present
        /// </summary>
        [Input("nxClusterId", required: true)]
        public Input<string> NxClusterId { get; set; } = null!;

        [Input("postgresqlInfos")]
        private InputList<Inputs.NdbClonePostgresqlInfoArgs>? _postgresqlInfos;

        /// <summary>
        /// postgresql info for the clone
        /// </summary>
        public InputList<Inputs.NdbClonePostgresqlInfoArgs> PostgresqlInfos
        {
            get => _postgresqlInfos ?? (_postgresqlInfos = new InputList<Inputs.NdbClonePostgresqlInfoArgs>());
            set => _postgresqlInfos = value;
        }

        /// <summary>
        /// - (Optional) Unregister the database clone from NDB. Default value is false
        /// </summary>
        [Input("remove")]
        public Input<bool>? Remove { get; set; }

        /// <summary>
        /// remove logical cluster. Default value is false
        /// </summary>
        [Input("removeLogicalCluster")]
        public Input<bool>? RemoveLogicalCluster { get; set; }

        /// <summary>
        /// snapshot id from where clone is created
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// - (Optional) Soft remove. Default will be false
        /// </summary>
        [Input("softRemove")]
        public Input<bool>? SoftRemove { get; set; }

        [Input("sshPublicKey")]
        private Input<string>? _sshPublicKey;

        /// <summary>
        /// ssh public key
        /// </summary>
        public Input<string>? SshPublicKey
        {
            get => _sshPublicKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _sshPublicKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("tags")]
        private InputList<Inputs.NdbCloneTagArgs>? _tags;

        /// <summary>
        /// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
        /// </summary>
        public InputList<Inputs.NdbCloneTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.NdbCloneTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// time machine id
        /// </summary>
        [Input("timeMachineId")]
        public Input<string>? TimeMachineId { get; set; }

        /// <summary>
        /// time machine name
        /// </summary>
        [Input("timeMachineName")]
        public Input<string>? TimeMachineName { get; set; }

        /// <summary>
        /// timezone
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        /// <summary>
        /// point in time for clone to be created
        /// </summary>
        [Input("userPitrTimestamp")]
        public Input<string>? UserPitrTimestamp { get; set; }

        [Input("vmPassword")]
        private Input<string>? _vmPassword;

        /// <summary>
        /// vm password
        /// </summary>
        public Input<string>? VmPassword
        {
            get => _vmPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _vmPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public NdbCloneArgs()
        {
        }
        public static new NdbCloneArgs Empty => new NdbCloneArgs();
    }

    public sealed class NdbCloneState : global::Pulumi.ResourceArgs
    {
        [Input("actionarguments")]
        private InputList<Inputs.NdbCloneActionargumentGetArgs>? _actionarguments;

        /// <summary>
        /// if any action arguments is required
        /// </summary>
        public InputList<Inputs.NdbCloneActionargumentGetArgs> Actionarguments
        {
            get => _actionarguments ?? (_actionarguments = new InputList<Inputs.NdbCloneActionargumentGetArgs>());
            set => _actionarguments = value;
        }

        /// <summary>
        /// cloned or not
        /// </summary>
        [Input("clone")]
        public Input<bool>? Clone { get; set; }

        /// <summary>
        /// clone will be clustered or not
        /// </summary>
        [Input("clustered")]
        public Input<bool>? Clustered { get; set; }

        /// <summary>
        /// specify the compute profile id
        /// </summary>
        [Input("computeProfileId")]
        public Input<string>? ComputeProfileId { get; set; }

        /// <summary>
        /// create new dbserver
        /// </summary>
        [Input("createDbserver")]
        public Input<bool>? CreateDbserver { get; set; }

        /// <summary>
        /// database cluster type
        /// </summary>
        [Input("databaseClusterType")]
        public Input<string>? DatabaseClusterType { get; set; }

        /// <summary>
        /// database name
        /// </summary>
        [Input("databaseName")]
        public Input<string>? DatabaseName { get; set; }

        [Input("databaseNodes")]
        private InputList<Inputs.NdbCloneDatabaseNodeGetArgs>? _databaseNodes;

        /// <summary>
        /// database nodes associated with database instance
        /// </summary>
        public InputList<Inputs.NdbCloneDatabaseNodeGetArgs> DatabaseNodes
        {
            get => _databaseNodes ?? (_databaseNodes = new InputList<Inputs.NdbCloneDatabaseNodeGetArgs>());
            set => _databaseNodes = value;
        }

        /// <summary>
        /// specify the database parameter profile id
        /// </summary>
        [Input("databaseParameterProfileId")]
        public Input<string>? DatabaseParameterProfileId { get; set; }

        /// <summary>
        /// date created for clone
        /// </summary>
        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        /// <summary>
        /// last modified date for clone
        /// </summary>
        [Input("dateModified")]
        public Input<string>? DateModified { get; set; }

        /// <summary>
        /// dbserver cluster id
        /// </summary>
        [Input("dbserverClusterId")]
        public Input<string>? DbserverClusterId { get; set; }

        /// <summary>
        /// Specify if you want to create a database server. This value can be set to true or false as required.
        /// </summary>
        [Input("dbserverId")]
        public Input<string>? DbserverId { get; set; }

        [Input("dbserverLogicalCluster")]
        private InputMap<string>? _dbserverLogicalCluster;

        /// <summary>
        /// dbserver logical cluster
        /// </summary>
        public InputMap<string> DbserverLogicalCluster
        {
            get => _dbserverLogicalCluster ?? (_dbserverLogicalCluster = new InputMap<string>());
            set => _dbserverLogicalCluster = value;
        }

        /// <summary>
        /// dbserver logical cluster id
        /// </summary>
        [Input("dbserverLogicalClusterId")]
        public Input<string>? DbserverLogicalClusterId { get; set; }

        /// <summary>
        /// - (Optional) Delete the database clone from the VM. Default value is true
        /// </summary>
        [Input("delete")]
        public Input<bool>? Delete { get; set; }

        /// <summary>
        /// - (Optional) Delete the logical cluster. Default is true
        /// </summary>
        [Input("deleteLogicalCluster")]
        public Input<bool>? DeleteLogicalCluster { get; set; }

        /// <summary>
        /// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
        /// </summary>
        [Input("deleteTimeMachine")]
        public Input<bool>? DeleteTimeMachine { get; set; }

        /// <summary>
        /// database instance description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// - (Optional) Force delete of instance. Default is false
        /// </summary>
        [Input("forced")]
        public Input<bool>? Forced { get; set; }

        [Input("infos")]
        private InputList<Inputs.NdbCloneInfoGetArgs>? _infos;

        /// <summary>
        /// info of clone
        /// </summary>
        public InputList<Inputs.NdbCloneInfoGetArgs> Infos
        {
            get => _infos ?? (_infos = new InputList<Inputs.NdbCloneInfoGetArgs>());
            set => _infos = value;
        }

        /// <summary>
        /// latest snapshot
        /// </summary>
        [Input("latestSnapshot")]
        public Input<bool>? LatestSnapshot { get; set; }

        [Input("lcmConfigs")]
        private InputList<Inputs.NdbCloneLcmConfigGetArgs>? _lcmConfigs;

        /// <summary>
        /// LCM Config contains the expiry details and refresh details
        /// </summary>
        public InputList<Inputs.NdbCloneLcmConfigGetArgs> LcmConfigs
        {
            get => _lcmConfigs ?? (_lcmConfigs = new InputList<Inputs.NdbCloneLcmConfigGetArgs>());
            set => _lcmConfigs = value;
        }

        [Input("linkedDatabases")]
        private InputList<Inputs.NdbCloneLinkedDatabaseGetArgs>? _linkedDatabases;

        /// <summary>
        /// linked databases within database instance
        /// </summary>
        public InputList<Inputs.NdbCloneLinkedDatabaseGetArgs> LinkedDatabases
        {
            get => _linkedDatabases ?? (_linkedDatabases = new InputList<Inputs.NdbCloneLinkedDatabaseGetArgs>());
            set => _linkedDatabases = value;
        }

        [Input("metric")]
        private InputMap<string>? _metric;

        /// <summary>
        /// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
        /// </summary>
        public InputMap<string> Metric
        {
            get => _metric ?? (_metric = new InputMap<string>());
            set => _metric = value;
        }

        /// <summary>
        /// database instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// specify the network profile id
        /// </summary>
        [Input("networkProfileId")]
        public Input<string>? NetworkProfileId { get; set; }

        /// <summary>
        /// Node count. Default is 1 for single instance
        /// </summary>
        [Input("nodeCount")]
        public Input<int>? NodeCount { get; set; }

        [Input("nodes")]
        private InputList<Inputs.NdbCloneNodeGetArgs>? _nodes;

        /// <summary>
        /// Nodes contain info about dbservers vm
        /// </summary>
        public InputList<Inputs.NdbCloneNodeGetArgs> Nodes
        {
            get => _nodes ?? (_nodes = new InputList<Inputs.NdbCloneNodeGetArgs>());
            set => _nodes = value;
        }

        /// <summary>
        /// cluster id on where clone will be present
        /// </summary>
        [Input("nxClusterId")]
        public Input<string>? NxClusterId { get; set; }

        [Input("parentDatabaseId")]
        public Input<string>? ParentDatabaseId { get; set; }

        [Input("postgresqlInfos")]
        private InputList<Inputs.NdbClonePostgresqlInfoGetArgs>? _postgresqlInfos;

        /// <summary>
        /// postgresql info for the clone
        /// </summary>
        public InputList<Inputs.NdbClonePostgresqlInfoGetArgs> PostgresqlInfos
        {
            get => _postgresqlInfos ?? (_postgresqlInfos = new InputList<Inputs.NdbClonePostgresqlInfoGetArgs>());
            set => _postgresqlInfos = value;
        }

        [Input("properties")]
        private InputList<Inputs.NdbClonePropertyGetArgs>? _properties;

        /// <summary>
        /// List of all the properties
        /// </summary>
        public InputList<Inputs.NdbClonePropertyGetArgs> Properties
        {
            get => _properties ?? (_properties = new InputList<Inputs.NdbClonePropertyGetArgs>());
            set => _properties = value;
        }

        /// <summary>
        /// - (Optional) Unregister the database clone from NDB. Default value is false
        /// </summary>
        [Input("remove")]
        public Input<bool>? Remove { get; set; }

        /// <summary>
        /// remove logical cluster. Default value is false
        /// </summary>
        [Input("removeLogicalCluster")]
        public Input<bool>? RemoveLogicalCluster { get; set; }

        /// <summary>
        /// snapshot id from where clone is created
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// - (Optional) Soft remove. Default will be false
        /// </summary>
        [Input("softRemove")]
        public Input<bool>? SoftRemove { get; set; }

        [Input("sshPublicKey")]
        private Input<string>? _sshPublicKey;

        /// <summary>
        /// ssh public key
        /// </summary>
        public Input<string>? SshPublicKey
        {
            get => _sshPublicKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _sshPublicKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// status of clone
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputList<Inputs.NdbCloneTagGetArgs>? _tags;

        /// <summary>
        /// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
        /// </summary>
        public InputList<Inputs.NdbCloneTagGetArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.NdbCloneTagGetArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// time machine id
        /// </summary>
        [Input("timeMachineId")]
        public Input<string>? TimeMachineId { get; set; }

        /// <summary>
        /// time machine name
        /// </summary>
        [Input("timeMachineName")]
        public Input<string>? TimeMachineName { get; set; }

        [Input("timeMachines")]
        private InputList<Inputs.NdbCloneTimeMachineGetArgs>? _timeMachines;
        public InputList<Inputs.NdbCloneTimeMachineGetArgs> TimeMachines
        {
            get => _timeMachines ?? (_timeMachines = new InputList<Inputs.NdbCloneTimeMachineGetArgs>());
            set => _timeMachines = value;
        }

        /// <summary>
        /// timezone
        /// </summary>
        [Input("timeZone")]
        public Input<string>? TimeZone { get; set; }

        /// <summary>
        /// type of clone
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// point in time for clone to be created
        /// </summary>
        [Input("userPitrTimestamp")]
        public Input<string>? UserPitrTimestamp { get; set; }

        [Input("vmPassword")]
        private Input<string>? _vmPassword;

        /// <summary>
        /// vm password
        /// </summary>
        public Input<string>? VmPassword
        {
            get => _vmPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _vmPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public NdbCloneState()
        {
        }
        public static new NdbCloneState Empty => new NdbCloneState();
    }
}
