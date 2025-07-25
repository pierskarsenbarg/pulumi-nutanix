// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a resource to create database instance based on the input parameters. For 1.8.0 release, only postgress database type is qualified and officially supported.
 *
 * ## Example Usage
 *
 * ### NDB database resource with new database server VM
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const dbp = new nutanix.NdbDatabase("dbp", {
 *     databasetype: "postgres_database",
 *     description: "add description",
 *     softwareprofileid: "{{ software_profile_id }}",
 *     softwareprofileversionid: "{{ software_profile_version_id }}",
 *     computeprofileid: "{{ compute_profile_id }}",
 *     networkprofileid: "{{ network_profile_id }}",
 *     dbparameterprofileid: "{{ db_parameter_profile_id }}",
 *     postgresqlInfo: {
 *         listenerPort: "{{ listner_port }}",
 *         databaseSize: "{{ 200 }}",
 *         dbPassword: "password",
 *         databaseNames: "testdb1",
 *     },
 *     nxclusterid: local.clusters.EraCluster.id,
 *     sshpublickey: "{{ ssh-public-key }}",
 *     nodes: [{
 *         vmname: "test-era-vm1",
 *         networkprofileid: "<network-profile-uuid>",
 *     }],
 *     timemachineinfo: {
 *         name: "test-pg-inst",
 *         description: "description of time machine",
 *         slaid: "{{ sla_id }}",
 *         schedule: {
 *             snapshottimeofday: {
 *                 hours: 16,
 *                 minutes: 0,
 *                 seconds: 0,
 *             },
 *             continuousschedule: {
 *                 enabled: true,
 *                 logbackupinterval: 30,
 *                 snapshotsperday: 1,
 *             },
 *             weeklyschedule: {
 *                 enabled: true,
 *                 dayofweek: "WEDNESDAY",
 *             },
 *             monthlyschedule: {
 *                 enabled: true,
 *                 dayofmonth: 27,
 *             },
 *             quartelyschedule: {
 *                 enabled: true,
 *                 startmonth: "JANUARY",
 *                 dayofmonth: 27,
 *             },
 *             yearlyschedule: {
 *                 enabled: false,
 *                 dayofmonth: 31,
 *                 month: "DECEMBER",
 *             },
 *         },
 *     },
 * });
 * ```
 *
 * ### NDB database resource with registered database server VM
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const dbp = new nutanix.NdbDatabase("dbp", {
 *     actionarguments: [{
 *         name: "host_ip",
 *         value: "{{ hostIP }}",
 *     }],
 *     createdbserver: false,
 *     databasetype: "postgres_database",
 *     dbparameterprofileid: "{{ db_parameter_profile_id }}",
 *     dbserverId: "{{ dbserver_id }}",
 *     description: "add description",
 *     nodes: [{
 *         dbserverid: "{{ dbserver_id }}",
 *     }],
 *     postgresqlInfo: {
 *         databaseNames: "testdb1",
 *         databaseSize: "{{ 200 }}",
 *         dbPassword: "password",
 *         listenerPort: "{{ listner_port }}",
 *     },
 *     timemachineinfo: {
 *         description: "description of time machine",
 *         name: "test-pg-inst",
 *         schedule: {
 *             continuousschedule: {
 *                 enabled: true,
 *                 logbackupinterval: 30,
 *                 snapshotsperday: 1,
 *             },
 *             monthlyschedule: {
 *                 dayofmonth: 27,
 *                 enabled: true,
 *             },
 *             quartelyschedule: {
 *                 dayofmonth: 27,
 *                 enabled: true,
 *                 startmonth: "JANUARY",
 *             },
 *             snapshottimeofday: {
 *                 hours: 16,
 *                 minutes: 0,
 *                 seconds: 0,
 *             },
 *             weeklyschedule: {
 *                 dayofweek: "WEDNESDAY",
 *                 enabled: true,
 *             },
 *             yearlyschedule: {
 *                 dayofmonth: 31,
 *                 enabled: false,
 *                 month: "DECEMBER",
 *             },
 *         },
 *         slaid: "{{ sla_id }}",
 *     },
 * });
 * ```
 *
 * ## lifecycle
 *
 * * `Update` : - Currently only update of instance's name and description is supported using this resource
 *
 * See detailed information in [NDB Database Instance](https://www.nutanix.dev/api_references/ndb/#/9d9eee4304496-provision-a-database).
 */
export class NdbDatabase extends pulumi.CustomResource {
    /**
     * Get an existing NdbDatabase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NdbDatabaseState, opts?: pulumi.CustomResourceOptions): NdbDatabase {
        return new NdbDatabase(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/ndbDatabase:NdbDatabase';

    /**
     * Returns true if the given object is an instance of NdbDatabase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NdbDatabase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NdbDatabase.__pulumiType;
    }

    /**
     * - (Optional) action arguments for database. For postgress, you can use postgresql_info
     */
    public readonly actionarguments!: pulumi.Output<outputs.NdbDatabaseActionargument[] | undefined>;
    /**
     * - (Optional) Enable auto tuning of staging drive. Default: true
     */
    public readonly autotunestagingdrive!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly clone!: pulumi.Output<boolean>;
    public readonly clusterInfos!: pulumi.Output<outputs.NdbDatabaseClusterInfo[] | undefined>;
    /**
     * - (Optional) If clustered database. Default: false
     */
    public readonly clustered!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) ID of compute profile
     */
    public readonly computeprofileid!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) Set this to create new DB server VM. Default: true
     */
    public readonly createdbserver!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly databaseClusterType!: pulumi.Output<string>;
    public readonly databaseInstanceId!: pulumi.Output<string>;
    public /*out*/ readonly databaseName!: pulumi.Output<string>;
    public /*out*/ readonly databaseNodes!: pulumi.Output<outputs.NdbDatabaseDatabaseNode[]>;
    /**
     * - (Required) Type of database. Valid values: postgres_database
     */
    public readonly databasetype!: pulumi.Output<string | undefined>;
    public /*out*/ readonly dateCreated!: pulumi.Output<string>;
    public /*out*/ readonly dateModified!: pulumi.Output<string>;
    /**
     * - (Optional) DB parameters profile ID
     */
    public readonly dbparameterprofileid!: pulumi.Output<string | undefined>;
    public /*out*/ readonly dbserverLogicalCluster!: pulumi.Output<{[key: string]: string}>;
    public /*out*/ readonly dbserverLogicalClusterId!: pulumi.Output<string>;
    /**
     * - (Optional) DB server VM ID for creating instance on registered DB server VM
     */
    public readonly dbserverid!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) Delete the database from the VM. Default value is true
     */
    public readonly delete!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) Delete the logical cluster. Default is true
     */
    public readonly deleteLogicalCluster!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
     */
    public readonly deleteTimeMachine!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) The description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    public readonly forced!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly infos!: pulumi.Output<outputs.NdbDatabaseInfo[]>;
    public /*out*/ readonly lcmConfigs!: pulumi.Output<outputs.NdbDatabaseLcmConfig[]>;
    public /*out*/ readonly linkedDatabases!: pulumi.Output<outputs.NdbDatabaseLinkedDatabase[]>;
    public readonly maintenanceTasks!: pulumi.Output<outputs.NdbDatabaseMaintenanceTasks | undefined>;
    public /*out*/ readonly metric!: pulumi.Output<{[key: string]: string}>;
    /**
     * - (Required) Name of the instance.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * - (Optional) ID of network profile
     */
    public readonly networkprofileid!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) Timezone of new DB server VM
     */
    public readonly newdbservertimezone!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) No. of nodes/db server vms. Default: 1
     */
    public readonly nodecount!: pulumi.Output<number | undefined>;
    /**
     * - (Optional) nodes info
     */
    public readonly nodes!: pulumi.Output<outputs.NdbDatabaseNode[]>;
    /**
     * - (Optional) Cluster ID for DB server VM
     */
    public readonly nxclusterid!: pulumi.Output<string | undefined>;
    public /*out*/ readonly parentDatabaseId!: pulumi.Output<string>;
    /**
     * - (Optional) action arguments for postgress type database.
     */
    public readonly postgresqlInfo!: pulumi.Output<outputs.NdbDatabasePostgresqlInfo | undefined>;
    /**
     * List of all the properties
     */
    public /*out*/ readonly properties!: pulumi.Output<outputs.NdbDatabaseProperty[]>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    public readonly remove!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    public readonly softRemove!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) ID of software profile
     */
    public readonly softwareprofileid!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) ID of version in software profile
     */
    public readonly softwareprofileversionid!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) public key for ssh access to DB server VM
     */
    public readonly sshpublickey!: pulumi.Output<string | undefined>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.NdbDatabaseTag[]>;
    public /*out*/ readonly timeMachineId!: pulumi.Output<string>;
    public /*out*/ readonly timeMachines!: pulumi.Output<outputs.NdbDatabaseTimeMachine[]>;
    public /*out*/ readonly timeZone!: pulumi.Output<string>;
    /**
     * - (Optional) time machine config
     */
    public readonly timemachineinfo!: pulumi.Output<outputs.NdbDatabaseTimemachineinfo | undefined>;
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * - (Optional) password for DB server VM and era drive user
     */
    public readonly vmPassword!: pulumi.Output<string | undefined>;

    /**
     * Create a NdbDatabase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: NdbDatabaseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NdbDatabaseArgs | NdbDatabaseState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NdbDatabaseState | undefined;
            resourceInputs["actionarguments"] = state ? state.actionarguments : undefined;
            resourceInputs["autotunestagingdrive"] = state ? state.autotunestagingdrive : undefined;
            resourceInputs["clone"] = state ? state.clone : undefined;
            resourceInputs["clusterInfos"] = state ? state.clusterInfos : undefined;
            resourceInputs["clustered"] = state ? state.clustered : undefined;
            resourceInputs["computeprofileid"] = state ? state.computeprofileid : undefined;
            resourceInputs["createdbserver"] = state ? state.createdbserver : undefined;
            resourceInputs["databaseClusterType"] = state ? state.databaseClusterType : undefined;
            resourceInputs["databaseInstanceId"] = state ? state.databaseInstanceId : undefined;
            resourceInputs["databaseName"] = state ? state.databaseName : undefined;
            resourceInputs["databaseNodes"] = state ? state.databaseNodes : undefined;
            resourceInputs["databasetype"] = state ? state.databasetype : undefined;
            resourceInputs["dateCreated"] = state ? state.dateCreated : undefined;
            resourceInputs["dateModified"] = state ? state.dateModified : undefined;
            resourceInputs["dbparameterprofileid"] = state ? state.dbparameterprofileid : undefined;
            resourceInputs["dbserverLogicalCluster"] = state ? state.dbserverLogicalCluster : undefined;
            resourceInputs["dbserverLogicalClusterId"] = state ? state.dbserverLogicalClusterId : undefined;
            resourceInputs["dbserverid"] = state ? state.dbserverid : undefined;
            resourceInputs["delete"] = state ? state.delete : undefined;
            resourceInputs["deleteLogicalCluster"] = state ? state.deleteLogicalCluster : undefined;
            resourceInputs["deleteTimeMachine"] = state ? state.deleteTimeMachine : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["forced"] = state ? state.forced : undefined;
            resourceInputs["infos"] = state ? state.infos : undefined;
            resourceInputs["lcmConfigs"] = state ? state.lcmConfigs : undefined;
            resourceInputs["linkedDatabases"] = state ? state.linkedDatabases : undefined;
            resourceInputs["maintenanceTasks"] = state ? state.maintenanceTasks : undefined;
            resourceInputs["metric"] = state ? state.metric : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkprofileid"] = state ? state.networkprofileid : undefined;
            resourceInputs["newdbservertimezone"] = state ? state.newdbservertimezone : undefined;
            resourceInputs["nodecount"] = state ? state.nodecount : undefined;
            resourceInputs["nodes"] = state ? state.nodes : undefined;
            resourceInputs["nxclusterid"] = state ? state.nxclusterid : undefined;
            resourceInputs["parentDatabaseId"] = state ? state.parentDatabaseId : undefined;
            resourceInputs["postgresqlInfo"] = state ? state.postgresqlInfo : undefined;
            resourceInputs["properties"] = state ? state.properties : undefined;
            resourceInputs["remove"] = state ? state.remove : undefined;
            resourceInputs["softRemove"] = state ? state.softRemove : undefined;
            resourceInputs["softwareprofileid"] = state ? state.softwareprofileid : undefined;
            resourceInputs["softwareprofileversionid"] = state ? state.softwareprofileversionid : undefined;
            resourceInputs["sshpublickey"] = state ? state.sshpublickey : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["timeMachineId"] = state ? state.timeMachineId : undefined;
            resourceInputs["timeMachines"] = state ? state.timeMachines : undefined;
            resourceInputs["timeZone"] = state ? state.timeZone : undefined;
            resourceInputs["timemachineinfo"] = state ? state.timemachineinfo : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["vmPassword"] = state ? state.vmPassword : undefined;
        } else {
            const args = argsOrState as NdbDatabaseArgs | undefined;
            resourceInputs["actionarguments"] = args ? args.actionarguments : undefined;
            resourceInputs["autotunestagingdrive"] = args ? args.autotunestagingdrive : undefined;
            resourceInputs["clusterInfos"] = args ? args.clusterInfos : undefined;
            resourceInputs["clustered"] = args ? args.clustered : undefined;
            resourceInputs["computeprofileid"] = args ? args.computeprofileid : undefined;
            resourceInputs["createdbserver"] = args ? args.createdbserver : undefined;
            resourceInputs["databaseInstanceId"] = args ? args.databaseInstanceId : undefined;
            resourceInputs["databasetype"] = args ? args.databasetype : undefined;
            resourceInputs["dbparameterprofileid"] = args ? args.dbparameterprofileid : undefined;
            resourceInputs["dbserverid"] = args ? args.dbserverid : undefined;
            resourceInputs["delete"] = args ? args.delete : undefined;
            resourceInputs["deleteLogicalCluster"] = args ? args.deleteLogicalCluster : undefined;
            resourceInputs["deleteTimeMachine"] = args ? args.deleteTimeMachine : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["forced"] = args ? args.forced : undefined;
            resourceInputs["maintenanceTasks"] = args ? args.maintenanceTasks : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkprofileid"] = args ? args.networkprofileid : undefined;
            resourceInputs["newdbservertimezone"] = args ? args.newdbservertimezone : undefined;
            resourceInputs["nodecount"] = args ? args.nodecount : undefined;
            resourceInputs["nodes"] = args ? args.nodes : undefined;
            resourceInputs["nxclusterid"] = args ? args.nxclusterid : undefined;
            resourceInputs["postgresqlInfo"] = args ? args.postgresqlInfo : undefined;
            resourceInputs["remove"] = args ? args.remove : undefined;
            resourceInputs["softRemove"] = args ? args.softRemove : undefined;
            resourceInputs["softwareprofileid"] = args ? args.softwareprofileid : undefined;
            resourceInputs["softwareprofileversionid"] = args ? args.softwareprofileversionid : undefined;
            resourceInputs["sshpublickey"] = args?.sshpublickey ? pulumi.secret(args.sshpublickey) : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["timemachineinfo"] = args ? args.timemachineinfo : undefined;
            resourceInputs["vmPassword"] = args?.vmPassword ? pulumi.secret(args.vmPassword) : undefined;
            resourceInputs["clone"] = undefined /*out*/;
            resourceInputs["databaseClusterType"] = undefined /*out*/;
            resourceInputs["databaseName"] = undefined /*out*/;
            resourceInputs["databaseNodes"] = undefined /*out*/;
            resourceInputs["dateCreated"] = undefined /*out*/;
            resourceInputs["dateModified"] = undefined /*out*/;
            resourceInputs["dbserverLogicalCluster"] = undefined /*out*/;
            resourceInputs["dbserverLogicalClusterId"] = undefined /*out*/;
            resourceInputs["infos"] = undefined /*out*/;
            resourceInputs["lcmConfigs"] = undefined /*out*/;
            resourceInputs["linkedDatabases"] = undefined /*out*/;
            resourceInputs["metric"] = undefined /*out*/;
            resourceInputs["parentDatabaseId"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["timeMachineId"] = undefined /*out*/;
            resourceInputs["timeMachines"] = undefined /*out*/;
            resourceInputs["timeZone"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["sshpublickey", "vmPassword"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(NdbDatabase.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NdbDatabase resources.
 */
export interface NdbDatabaseState {
    /**
     * - (Optional) action arguments for database. For postgress, you can use postgresql_info
     */
    actionarguments?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseActionargument>[]>;
    /**
     * - (Optional) Enable auto tuning of staging drive. Default: true
     */
    autotunestagingdrive?: pulumi.Input<boolean>;
    clone?: pulumi.Input<boolean>;
    clusterInfos?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseClusterInfo>[]>;
    /**
     * - (Optional) If clustered database. Default: false
     */
    clustered?: pulumi.Input<boolean>;
    /**
     * - (Optional) ID of compute profile
     */
    computeprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) Set this to create new DB server VM. Default: true
     */
    createdbserver?: pulumi.Input<boolean>;
    databaseClusterType?: pulumi.Input<string>;
    databaseInstanceId?: pulumi.Input<string>;
    databaseName?: pulumi.Input<string>;
    databaseNodes?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseDatabaseNode>[]>;
    /**
     * - (Required) Type of database. Valid values: postgres_database
     */
    databasetype?: pulumi.Input<string>;
    dateCreated?: pulumi.Input<string>;
    dateModified?: pulumi.Input<string>;
    /**
     * - (Optional) DB parameters profile ID
     */
    dbparameterprofileid?: pulumi.Input<string>;
    dbserverLogicalCluster?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    dbserverLogicalClusterId?: pulumi.Input<string>;
    /**
     * - (Optional) DB server VM ID for creating instance on registered DB server VM
     */
    dbserverid?: pulumi.Input<string>;
    /**
     * - (Optional) Delete the database from the VM. Default value is true
     */
    delete?: pulumi.Input<boolean>;
    /**
     * - (Optional) Delete the logical cluster. Default is true
     */
    deleteLogicalCluster?: pulumi.Input<boolean>;
    /**
     * - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
     */
    deleteTimeMachine?: pulumi.Input<boolean>;
    /**
     * - (Optional) The description
     */
    description?: pulumi.Input<string>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    forced?: pulumi.Input<boolean>;
    infos?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseInfo>[]>;
    lcmConfigs?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseLcmConfig>[]>;
    linkedDatabases?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseLinkedDatabase>[]>;
    maintenanceTasks?: pulumi.Input<inputs.NdbDatabaseMaintenanceTasks>;
    metric?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * - (Required) Name of the instance.
     */
    name?: pulumi.Input<string>;
    /**
     * - (Optional) ID of network profile
     */
    networkprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) Timezone of new DB server VM
     */
    newdbservertimezone?: pulumi.Input<string>;
    /**
     * - (Optional) No. of nodes/db server vms. Default: 1
     */
    nodecount?: pulumi.Input<number>;
    /**
     * - (Optional) nodes info
     */
    nodes?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseNode>[]>;
    /**
     * - (Optional) Cluster ID for DB server VM
     */
    nxclusterid?: pulumi.Input<string>;
    parentDatabaseId?: pulumi.Input<string>;
    /**
     * - (Optional) action arguments for postgress type database.
     */
    postgresqlInfo?: pulumi.Input<inputs.NdbDatabasePostgresqlInfo>;
    /**
     * List of all the properties
     */
    properties?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseProperty>[]>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    remove?: pulumi.Input<boolean>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    softRemove?: pulumi.Input<boolean>;
    /**
     * - (Optional) ID of software profile
     */
    softwareprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) ID of version in software profile
     */
    softwareprofileversionid?: pulumi.Input<string>;
    /**
     * - (Optional) public key for ssh access to DB server VM
     */
    sshpublickey?: pulumi.Input<string>;
    status?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseTag>[]>;
    timeMachineId?: pulumi.Input<string>;
    timeMachines?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseTimeMachine>[]>;
    timeZone?: pulumi.Input<string>;
    /**
     * - (Optional) time machine config
     */
    timemachineinfo?: pulumi.Input<inputs.NdbDatabaseTimemachineinfo>;
    type?: pulumi.Input<string>;
    /**
     * - (Optional) password for DB server VM and era drive user
     */
    vmPassword?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a NdbDatabase resource.
 */
export interface NdbDatabaseArgs {
    /**
     * - (Optional) action arguments for database. For postgress, you can use postgresql_info
     */
    actionarguments?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseActionargument>[]>;
    /**
     * - (Optional) Enable auto tuning of staging drive. Default: true
     */
    autotunestagingdrive?: pulumi.Input<boolean>;
    clusterInfos?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseClusterInfo>[]>;
    /**
     * - (Optional) If clustered database. Default: false
     */
    clustered?: pulumi.Input<boolean>;
    /**
     * - (Optional) ID of compute profile
     */
    computeprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) Set this to create new DB server VM. Default: true
     */
    createdbserver?: pulumi.Input<boolean>;
    databaseInstanceId?: pulumi.Input<string>;
    /**
     * - (Required) Type of database. Valid values: postgres_database
     */
    databasetype?: pulumi.Input<string>;
    /**
     * - (Optional) DB parameters profile ID
     */
    dbparameterprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) DB server VM ID for creating instance on registered DB server VM
     */
    dbserverid?: pulumi.Input<string>;
    /**
     * - (Optional) Delete the database from the VM. Default value is true
     */
    delete?: pulumi.Input<boolean>;
    /**
     * - (Optional) Delete the logical cluster. Default is true
     */
    deleteLogicalCluster?: pulumi.Input<boolean>;
    /**
     * - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
     */
    deleteTimeMachine?: pulumi.Input<boolean>;
    /**
     * - (Optional) The description
     */
    description?: pulumi.Input<string>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    forced?: pulumi.Input<boolean>;
    maintenanceTasks?: pulumi.Input<inputs.NdbDatabaseMaintenanceTasks>;
    /**
     * - (Required) Name of the instance.
     */
    name?: pulumi.Input<string>;
    /**
     * - (Optional) ID of network profile
     */
    networkprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) Timezone of new DB server VM
     */
    newdbservertimezone?: pulumi.Input<string>;
    /**
     * - (Optional) No. of nodes/db server vms. Default: 1
     */
    nodecount?: pulumi.Input<number>;
    /**
     * - (Optional) nodes info
     */
    nodes?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseNode>[]>;
    /**
     * - (Optional) Cluster ID for DB server VM
     */
    nxclusterid?: pulumi.Input<string>;
    /**
     * - (Optional) action arguments for postgress type database.
     */
    postgresqlInfo?: pulumi.Input<inputs.NdbDatabasePostgresqlInfo>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    remove?: pulumi.Input<boolean>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    softRemove?: pulumi.Input<boolean>;
    /**
     * - (Optional) ID of software profile
     */
    softwareprofileid?: pulumi.Input<string>;
    /**
     * - (Optional) ID of version in software profile
     */
    softwareprofileversionid?: pulumi.Input<string>;
    /**
     * - (Optional) public key for ssh access to DB server VM
     */
    sshpublickey?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.NdbDatabaseTag>[]>;
    /**
     * - (Optional) time machine config
     */
    timemachineinfo?: pulumi.Input<inputs.NdbDatabaseTimemachineinfo>;
    /**
     * - (Optional) password for DB server VM and era drive user
     */
    vmPassword?: pulumi.Input<string>;
}
