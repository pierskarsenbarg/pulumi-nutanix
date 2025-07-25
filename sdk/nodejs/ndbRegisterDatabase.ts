// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a resource to register the database based on the input parameters.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // register PostgreSQL database with instance not registered on VM
 * const name = new nutanix.NdbRegisterDatabase("name", {
 *     category: "DEFAULT",
 *     databaseName: "test-inst",
 *     databaseType: "postgres_database",
 *     description: "added by terraform",
 *     nxClusterId: "{{ cluster_ID }}",
 *     postgressInfos: [{
 *         backupPolicy: "prefer_secondary",
 *         dbName: "testdb1",
 *         dbPassword: "pass",
 *         dbUser: "postgres",
 *         listenerPort: "5432",
 *         postgresSoftwareHome: "{{ directory where the PostgreSQL database software is installed }}",
 *     }],
 *     resetDescriptionInNxCluster: false,
 *     timeMachineInfo: {
 *         description: "description of tms",
 *         name: "test-pg-inst-regis",
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
 *         slaid: " {{ SLA ID}}",
 *     },
 *     vmIp: "{{ vm_ip }}",
 *     vmPassword: "{{ vm_password }}",
 *     vmUsername: "{{ vm_username }}",
 *     workingDirectory: "/tmp",
 * });
 * ```
 */
export class NdbRegisterDatabase extends pulumi.CustomResource {
    /**
     * Get an existing NdbRegisterDatabase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NdbRegisterDatabaseState, opts?: pulumi.CustomResourceOptions): NdbRegisterDatabase {
        return new NdbRegisterDatabase(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/ndbRegisterDatabase:NdbRegisterDatabase';

    /**
     * Returns true if the given object is an instance of NdbRegisterDatabase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NdbRegisterDatabase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NdbRegisterDatabase.__pulumiType;
    }

    /**
     * action arguments
     */
    public readonly actionarguments!: pulumi.Output<outputs.NdbRegisterDatabaseActionargument[] | undefined>;
    /**
     * auto tune staging drive. Default is true
     */
    public readonly autoTuneStagingDrive!: pulumi.Output<boolean | undefined>;
    /**
     * category of database. Default is "DEFAULT"
     */
    public readonly category!: pulumi.Output<string | undefined>;
    /**
     * whether instance is cloned or not
     */
    public /*out*/ readonly clone!: pulumi.Output<boolean>;
    /**
     * clustered or not. Default is false
     */
    public readonly clustered!: pulumi.Output<boolean | undefined>;
    /**
     * database cluster type
     */
    public /*out*/ readonly databaseClusterType!: pulumi.Output<string>;
    /**
     * name of database
     */
    public readonly databaseName!: pulumi.Output<string>;
    /**
     * database nodes associated with database instance
     */
    public /*out*/ readonly databaseNodes!: pulumi.Output<outputs.NdbRegisterDatabaseDatabaseNode[]>;
    /**
     * status of database
     */
    public /*out*/ readonly databaseStatus!: pulumi.Output<string>;
    /**
     * type of database. Required value: postgres_database
     */
    public readonly databaseType!: pulumi.Output<string>;
    /**
     * date created for db instance
     */
    public /*out*/ readonly dateCreated!: pulumi.Output<string>;
    /**
     * date modified for instance
     */
    public /*out*/ readonly dateModified!: pulumi.Output<string>;
    /**
     * dbserver logical cluster
     */
    public /*out*/ readonly dbserverLogicalCluster!: pulumi.Output<{[key: string]: string}>;
    /**
     * dbserver logical cluster id
     */
    public /*out*/ readonly dbserverLogicalClusterId!: pulumi.Output<string>;
    /**
     * - (Optional) Delete the database from the VM. Default value is false
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
     * description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    public readonly forced!: pulumi.Output<boolean | undefined>;
    /**
     * forced install. Default:  true
     */
    public readonly forcedInstall!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly groupInfo!: pulumi.Output<{[key: string]: string}>;
    /**
     * info of instance
     */
    public /*out*/ readonly infos!: pulumi.Output<outputs.NdbRegisterDatabaseInfo[]>;
    /**
     * LCM config of instance
     */
    public /*out*/ readonly lcmConfigs!: pulumi.Output<outputs.NdbRegisterDatabaseLcmConfig[]>;
    /**
     * linked databases within database instance
     */
    public /*out*/ readonly linkedDatabases!: pulumi.Output<outputs.NdbRegisterDatabaseLinkedDatabase[]>;
    /**
     * Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
     */
    public /*out*/ readonly metric!: pulumi.Output<{[key: string]: string}>;
    /**
     * Name of database instance
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * cluster on which NDB is present
     */
    public readonly nxClusterId!: pulumi.Output<string | undefined>;
    /**
     * parent database id
     */
    public /*out*/ readonly parentDatabaseId!: pulumi.Output<string>;
    /**
     * parent source database id
     */
    public /*out*/ readonly parentSourceDatabaseId!: pulumi.Output<string>;
    /**
     * parent time machine id
     */
    public /*out*/ readonly parentTimeMachineId!: pulumi.Output<string>;
    /**
     * Postgress_Info for registering.
     */
    public readonly postgressInfos!: pulumi.Output<outputs.NdbRegisterDatabasePostgressInfo[] | undefined>;
    /**
     * properties of database created
     */
    public /*out*/ readonly properties!: pulumi.Output<outputs.NdbRegisterDatabaseProperty[]>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    public readonly remove!: pulumi.Output<boolean | undefined>;
    /**
     * Reset description in cluster
     */
    public readonly resetDescriptionInNxCluster!: pulumi.Output<boolean | undefined>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    public readonly softRemove!: pulumi.Output<boolean | undefined>;
    /**
     * status of instance
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * tags
     */
    public readonly tags!: pulumi.Output<outputs.NdbRegisterDatabaseTag[]>;
    /**
     * time machine id of instance
     */
    public /*out*/ readonly timeMachineId!: pulumi.Output<string>;
    /**
     * Time Machine info
     */
    public readonly timeMachineInfo!: pulumi.Output<outputs.NdbRegisterDatabaseTimeMachineInfo | undefined>;
    /**
     * Time Machine details of instance
     */
    public /*out*/ readonly timeMachines!: pulumi.Output<outputs.NdbRegisterDatabaseTimeMachine[]>;
    /**
     * timezone on which instance is created xw
     */
    public /*out*/ readonly timeZone!: pulumi.Output<string>;
    /**
     * type of database
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * description for VM
     */
    public readonly vmDescription!: pulumi.Output<string | undefined>;
    /**
     * IP address of dbserver VM
     */
    public readonly vmIp!: pulumi.Output<string>;
    /**
     * password of the NDB drive user account.
     */
    public readonly vmPassword!: pulumi.Output<string | undefined>;
    /**
     * ssh key for vm
     */
    public readonly vmSshkey!: pulumi.Output<string | undefined>;
    /**
     * username of the NDB drive user account that has sudo access.
     */
    public readonly vmUsername!: pulumi.Output<string | undefined>;
    /**
     * working directory. Default is /tmp
     */
    public readonly workingDirectory!: pulumi.Output<string | undefined>;

    /**
     * Create a NdbRegisterDatabase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NdbRegisterDatabaseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NdbRegisterDatabaseArgs | NdbRegisterDatabaseState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NdbRegisterDatabaseState | undefined;
            resourceInputs["actionarguments"] = state ? state.actionarguments : undefined;
            resourceInputs["autoTuneStagingDrive"] = state ? state.autoTuneStagingDrive : undefined;
            resourceInputs["category"] = state ? state.category : undefined;
            resourceInputs["clone"] = state ? state.clone : undefined;
            resourceInputs["clustered"] = state ? state.clustered : undefined;
            resourceInputs["databaseClusterType"] = state ? state.databaseClusterType : undefined;
            resourceInputs["databaseName"] = state ? state.databaseName : undefined;
            resourceInputs["databaseNodes"] = state ? state.databaseNodes : undefined;
            resourceInputs["databaseStatus"] = state ? state.databaseStatus : undefined;
            resourceInputs["databaseType"] = state ? state.databaseType : undefined;
            resourceInputs["dateCreated"] = state ? state.dateCreated : undefined;
            resourceInputs["dateModified"] = state ? state.dateModified : undefined;
            resourceInputs["dbserverLogicalCluster"] = state ? state.dbserverLogicalCluster : undefined;
            resourceInputs["dbserverLogicalClusterId"] = state ? state.dbserverLogicalClusterId : undefined;
            resourceInputs["delete"] = state ? state.delete : undefined;
            resourceInputs["deleteLogicalCluster"] = state ? state.deleteLogicalCluster : undefined;
            resourceInputs["deleteTimeMachine"] = state ? state.deleteTimeMachine : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["forced"] = state ? state.forced : undefined;
            resourceInputs["forcedInstall"] = state ? state.forcedInstall : undefined;
            resourceInputs["groupInfo"] = state ? state.groupInfo : undefined;
            resourceInputs["infos"] = state ? state.infos : undefined;
            resourceInputs["lcmConfigs"] = state ? state.lcmConfigs : undefined;
            resourceInputs["linkedDatabases"] = state ? state.linkedDatabases : undefined;
            resourceInputs["metric"] = state ? state.metric : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nxClusterId"] = state ? state.nxClusterId : undefined;
            resourceInputs["parentDatabaseId"] = state ? state.parentDatabaseId : undefined;
            resourceInputs["parentSourceDatabaseId"] = state ? state.parentSourceDatabaseId : undefined;
            resourceInputs["parentTimeMachineId"] = state ? state.parentTimeMachineId : undefined;
            resourceInputs["postgressInfos"] = state ? state.postgressInfos : undefined;
            resourceInputs["properties"] = state ? state.properties : undefined;
            resourceInputs["remove"] = state ? state.remove : undefined;
            resourceInputs["resetDescriptionInNxCluster"] = state ? state.resetDescriptionInNxCluster : undefined;
            resourceInputs["softRemove"] = state ? state.softRemove : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["timeMachineId"] = state ? state.timeMachineId : undefined;
            resourceInputs["timeMachineInfo"] = state ? state.timeMachineInfo : undefined;
            resourceInputs["timeMachines"] = state ? state.timeMachines : undefined;
            resourceInputs["timeZone"] = state ? state.timeZone : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["vmDescription"] = state ? state.vmDescription : undefined;
            resourceInputs["vmIp"] = state ? state.vmIp : undefined;
            resourceInputs["vmPassword"] = state ? state.vmPassword : undefined;
            resourceInputs["vmSshkey"] = state ? state.vmSshkey : undefined;
            resourceInputs["vmUsername"] = state ? state.vmUsername : undefined;
            resourceInputs["workingDirectory"] = state ? state.workingDirectory : undefined;
        } else {
            const args = argsOrState as NdbRegisterDatabaseArgs | undefined;
            if ((!args || args.databaseName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'databaseName'");
            }
            if ((!args || args.databaseType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'databaseType'");
            }
            if ((!args || args.vmIp === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vmIp'");
            }
            resourceInputs["actionarguments"] = args ? args.actionarguments : undefined;
            resourceInputs["autoTuneStagingDrive"] = args ? args.autoTuneStagingDrive : undefined;
            resourceInputs["category"] = args ? args.category : undefined;
            resourceInputs["clustered"] = args ? args.clustered : undefined;
            resourceInputs["databaseName"] = args ? args.databaseName : undefined;
            resourceInputs["databaseType"] = args ? args.databaseType : undefined;
            resourceInputs["delete"] = args ? args.delete : undefined;
            resourceInputs["deleteLogicalCluster"] = args ? args.deleteLogicalCluster : undefined;
            resourceInputs["deleteTimeMachine"] = args ? args.deleteTimeMachine : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["forced"] = args ? args.forced : undefined;
            resourceInputs["forcedInstall"] = args ? args.forcedInstall : undefined;
            resourceInputs["nxClusterId"] = args ? args.nxClusterId : undefined;
            resourceInputs["postgressInfos"] = args ? args.postgressInfos : undefined;
            resourceInputs["remove"] = args ? args.remove : undefined;
            resourceInputs["resetDescriptionInNxCluster"] = args ? args.resetDescriptionInNxCluster : undefined;
            resourceInputs["softRemove"] = args ? args.softRemove : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["timeMachineInfo"] = args ? args.timeMachineInfo : undefined;
            resourceInputs["vmDescription"] = args ? args.vmDescription : undefined;
            resourceInputs["vmIp"] = args ? args.vmIp : undefined;
            resourceInputs["vmPassword"] = args?.vmPassword ? pulumi.secret(args.vmPassword) : undefined;
            resourceInputs["vmSshkey"] = args?.vmSshkey ? pulumi.secret(args.vmSshkey) : undefined;
            resourceInputs["vmUsername"] = args ? args.vmUsername : undefined;
            resourceInputs["workingDirectory"] = args ? args.workingDirectory : undefined;
            resourceInputs["clone"] = undefined /*out*/;
            resourceInputs["databaseClusterType"] = undefined /*out*/;
            resourceInputs["databaseNodes"] = undefined /*out*/;
            resourceInputs["databaseStatus"] = undefined /*out*/;
            resourceInputs["dateCreated"] = undefined /*out*/;
            resourceInputs["dateModified"] = undefined /*out*/;
            resourceInputs["dbserverLogicalCluster"] = undefined /*out*/;
            resourceInputs["dbserverLogicalClusterId"] = undefined /*out*/;
            resourceInputs["groupInfo"] = undefined /*out*/;
            resourceInputs["infos"] = undefined /*out*/;
            resourceInputs["lcmConfigs"] = undefined /*out*/;
            resourceInputs["linkedDatabases"] = undefined /*out*/;
            resourceInputs["metric"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["parentDatabaseId"] = undefined /*out*/;
            resourceInputs["parentSourceDatabaseId"] = undefined /*out*/;
            resourceInputs["parentTimeMachineId"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["timeMachineId"] = undefined /*out*/;
            resourceInputs["timeMachines"] = undefined /*out*/;
            resourceInputs["timeZone"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["vmPassword", "vmSshkey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(NdbRegisterDatabase.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NdbRegisterDatabase resources.
 */
export interface NdbRegisterDatabaseState {
    /**
     * action arguments
     */
    actionarguments?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseActionargument>[]>;
    /**
     * auto tune staging drive. Default is true
     */
    autoTuneStagingDrive?: pulumi.Input<boolean>;
    /**
     * category of database. Default is "DEFAULT"
     */
    category?: pulumi.Input<string>;
    /**
     * whether instance is cloned or not
     */
    clone?: pulumi.Input<boolean>;
    /**
     * clustered or not. Default is false
     */
    clustered?: pulumi.Input<boolean>;
    /**
     * database cluster type
     */
    databaseClusterType?: pulumi.Input<string>;
    /**
     * name of database
     */
    databaseName?: pulumi.Input<string>;
    /**
     * database nodes associated with database instance
     */
    databaseNodes?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseDatabaseNode>[]>;
    /**
     * status of database
     */
    databaseStatus?: pulumi.Input<string>;
    /**
     * type of database. Required value: postgres_database
     */
    databaseType?: pulumi.Input<string>;
    /**
     * date created for db instance
     */
    dateCreated?: pulumi.Input<string>;
    /**
     * date modified for instance
     */
    dateModified?: pulumi.Input<string>;
    /**
     * dbserver logical cluster
     */
    dbserverLogicalCluster?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * dbserver logical cluster id
     */
    dbserverLogicalClusterId?: pulumi.Input<string>;
    /**
     * - (Optional) Delete the database from the VM. Default value is false
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
     * description
     */
    description?: pulumi.Input<string>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    forced?: pulumi.Input<boolean>;
    /**
     * forced install. Default:  true
     */
    forcedInstall?: pulumi.Input<boolean>;
    groupInfo?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * info of instance
     */
    infos?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseInfo>[]>;
    /**
     * LCM config of instance
     */
    lcmConfigs?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseLcmConfig>[]>;
    /**
     * linked databases within database instance
     */
    linkedDatabases?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseLinkedDatabase>[]>;
    /**
     * Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
     */
    metric?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of database instance
     */
    name?: pulumi.Input<string>;
    /**
     * cluster on which NDB is present
     */
    nxClusterId?: pulumi.Input<string>;
    /**
     * parent database id
     */
    parentDatabaseId?: pulumi.Input<string>;
    /**
     * parent source database id
     */
    parentSourceDatabaseId?: pulumi.Input<string>;
    /**
     * parent time machine id
     */
    parentTimeMachineId?: pulumi.Input<string>;
    /**
     * Postgress_Info for registering.
     */
    postgressInfos?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabasePostgressInfo>[]>;
    /**
     * properties of database created
     */
    properties?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseProperty>[]>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    remove?: pulumi.Input<boolean>;
    /**
     * Reset description in cluster
     */
    resetDescriptionInNxCluster?: pulumi.Input<boolean>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    softRemove?: pulumi.Input<boolean>;
    /**
     * status of instance
     */
    status?: pulumi.Input<string>;
    /**
     * tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseTag>[]>;
    /**
     * time machine id of instance
     */
    timeMachineId?: pulumi.Input<string>;
    /**
     * Time Machine info
     */
    timeMachineInfo?: pulumi.Input<inputs.NdbRegisterDatabaseTimeMachineInfo>;
    /**
     * Time Machine details of instance
     */
    timeMachines?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseTimeMachine>[]>;
    /**
     * timezone on which instance is created xw
     */
    timeZone?: pulumi.Input<string>;
    /**
     * type of database
     */
    type?: pulumi.Input<string>;
    /**
     * description for VM
     */
    vmDescription?: pulumi.Input<string>;
    /**
     * IP address of dbserver VM
     */
    vmIp?: pulumi.Input<string>;
    /**
     * password of the NDB drive user account.
     */
    vmPassword?: pulumi.Input<string>;
    /**
     * ssh key for vm
     */
    vmSshkey?: pulumi.Input<string>;
    /**
     * username of the NDB drive user account that has sudo access.
     */
    vmUsername?: pulumi.Input<string>;
    /**
     * working directory. Default is /tmp
     */
    workingDirectory?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a NdbRegisterDatabase resource.
 */
export interface NdbRegisterDatabaseArgs {
    /**
     * action arguments
     */
    actionarguments?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseActionargument>[]>;
    /**
     * auto tune staging drive. Default is true
     */
    autoTuneStagingDrive?: pulumi.Input<boolean>;
    /**
     * category of database. Default is "DEFAULT"
     */
    category?: pulumi.Input<string>;
    /**
     * clustered or not. Default is false
     */
    clustered?: pulumi.Input<boolean>;
    /**
     * name of database
     */
    databaseName: pulumi.Input<string>;
    /**
     * type of database. Required value: postgres_database
     */
    databaseType: pulumi.Input<string>;
    /**
     * - (Optional) Delete the database from the VM. Default value is false
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
     * description
     */
    description?: pulumi.Input<string>;
    /**
     * - (Optional) Force delete of instance. Default is false
     */
    forced?: pulumi.Input<boolean>;
    /**
     * forced install. Default:  true
     */
    forcedInstall?: pulumi.Input<boolean>;
    /**
     * cluster on which NDB is present
     */
    nxClusterId?: pulumi.Input<string>;
    /**
     * Postgress_Info for registering.
     */
    postgressInfos?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabasePostgressInfo>[]>;
    /**
     * - (Optional) Unregister the database from NDB. Default value is true
     */
    remove?: pulumi.Input<boolean>;
    /**
     * Reset description in cluster
     */
    resetDescriptionInNxCluster?: pulumi.Input<boolean>;
    /**
     * - (Optional) Soft remove. Default will be false
     */
    softRemove?: pulumi.Input<boolean>;
    /**
     * tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.NdbRegisterDatabaseTag>[]>;
    /**
     * Time Machine info
     */
    timeMachineInfo?: pulumi.Input<inputs.NdbRegisterDatabaseTimeMachineInfo>;
    /**
     * description for VM
     */
    vmDescription?: pulumi.Input<string>;
    /**
     * IP address of dbserver VM
     */
    vmIp: pulumi.Input<string>;
    /**
     * password of the NDB drive user account.
     */
    vmPassword?: pulumi.Input<string>;
    /**
     * ssh key for vm
     */
    vmSshkey?: pulumi.Input<string>;
    /**
     * username of the NDB drive user account that has sudo access.
     */
    vmUsername?: pulumi.Input<string>;
    /**
     * working directory. Default is /tmp
     */
    workingDirectory?: pulumi.Input<string>;
}
