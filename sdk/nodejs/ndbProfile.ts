// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a resource to create profiles (Software, Network, Database Parameter, Compute) based on the input parameters.
 */
export class NdbProfile extends pulumi.CustomResource {
    /**
     * Get an existing NdbProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NdbProfileState, opts?: pulumi.CustomResourceOptions): NdbProfile {
        return new NdbProfile(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/ndbProfile:NdbProfile';

    /**
     * Returns true if the given object is an instance of NdbProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NdbProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NdbProfile.__pulumiType;
    }

    /**
     * associated databases of profiles
     */
    public /*out*/ readonly assocDatabases!: pulumi.Output<string[]>;
    /**
     * associated database servers for associated profiles
     */
    public /*out*/ readonly assocDbServers!: pulumi.Output<string[]>;
    /**
     * cluster availability of profile
     */
    public /*out*/ readonly clusterAvailabilities!: pulumi.Output<outputs.NdbProfileClusterAvailability[]>;
    /**
     * Compute Profile
     */
    public readonly computeProfiles!: pulumi.Output<outputs.NdbProfileComputeProfile[] | undefined>;
    /**
     * Database Parameter Profile
     */
    public readonly databaseParameterProfiles!: pulumi.Output<outputs.NdbProfileDatabaseParameterProfile[] | undefined>;
    /**
     * Description of profile
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Engine Type of database
     */
    public readonly engineType!: pulumi.Output<string>;
    /**
     * latest version of profile
     */
    public /*out*/ readonly latestVersion!: pulumi.Output<string>;
    /**
     * latest version id of profile
     */
    public /*out*/ readonly latestVersionId!: pulumi.Output<string>;
    /**
     * Name of profile
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Network Profile
     */
    public readonly networkProfiles!: pulumi.Output<outputs.NdbProfileNetworkProfile[] | undefined>;
    /**
     * cluster on which profile created
     */
    public /*out*/ readonly nxClusterId!: pulumi.Output<string>;
    /**
     * owner  of profile
     */
    public /*out*/ readonly owner!: pulumi.Output<string>;
    /**
     * Publish for all users
     */
    public readonly published!: pulumi.Output<boolean | undefined>;
    /**
     * Software Profile
     */
    public readonly softwareProfile!: pulumi.Output<outputs.NdbProfileSoftwareProfile | undefined>;
    /**
     * status of profile
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * versions of associated profiles
     */
    public /*out*/ readonly versions!: pulumi.Output<outputs.NdbProfileVersion[]>;

    /**
     * Create a NdbProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: NdbProfileArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NdbProfileArgs | NdbProfileState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NdbProfileState | undefined;
            resourceInputs["assocDatabases"] = state ? state.assocDatabases : undefined;
            resourceInputs["assocDbServers"] = state ? state.assocDbServers : undefined;
            resourceInputs["clusterAvailabilities"] = state ? state.clusterAvailabilities : undefined;
            resourceInputs["computeProfiles"] = state ? state.computeProfiles : undefined;
            resourceInputs["databaseParameterProfiles"] = state ? state.databaseParameterProfiles : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["engineType"] = state ? state.engineType : undefined;
            resourceInputs["latestVersion"] = state ? state.latestVersion : undefined;
            resourceInputs["latestVersionId"] = state ? state.latestVersionId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkProfiles"] = state ? state.networkProfiles : undefined;
            resourceInputs["nxClusterId"] = state ? state.nxClusterId : undefined;
            resourceInputs["owner"] = state ? state.owner : undefined;
            resourceInputs["published"] = state ? state.published : undefined;
            resourceInputs["softwareProfile"] = state ? state.softwareProfile : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["versions"] = state ? state.versions : undefined;
        } else {
            const args = argsOrState as NdbProfileArgs | undefined;
            resourceInputs["computeProfiles"] = args ? args.computeProfiles : undefined;
            resourceInputs["databaseParameterProfiles"] = args ? args.databaseParameterProfiles : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["engineType"] = args ? args.engineType : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkProfiles"] = args ? args.networkProfiles : undefined;
            resourceInputs["published"] = args ? args.published : undefined;
            resourceInputs["softwareProfile"] = args ? args.softwareProfile : undefined;
            resourceInputs["assocDatabases"] = undefined /*out*/;
            resourceInputs["assocDbServers"] = undefined /*out*/;
            resourceInputs["clusterAvailabilities"] = undefined /*out*/;
            resourceInputs["latestVersion"] = undefined /*out*/;
            resourceInputs["latestVersionId"] = undefined /*out*/;
            resourceInputs["nxClusterId"] = undefined /*out*/;
            resourceInputs["owner"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["versions"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(NdbProfile.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NdbProfile resources.
 */
export interface NdbProfileState {
    /**
     * associated databases of profiles
     */
    assocDatabases?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * associated database servers for associated profiles
     */
    assocDbServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * cluster availability of profile
     */
    clusterAvailabilities?: pulumi.Input<pulumi.Input<inputs.NdbProfileClusterAvailability>[]>;
    /**
     * Compute Profile
     */
    computeProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileComputeProfile>[]>;
    /**
     * Database Parameter Profile
     */
    databaseParameterProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileDatabaseParameterProfile>[]>;
    /**
     * Description of profile
     */
    description?: pulumi.Input<string>;
    /**
     * Engine Type of database
     */
    engineType?: pulumi.Input<string>;
    /**
     * latest version of profile
     */
    latestVersion?: pulumi.Input<string>;
    /**
     * latest version id of profile
     */
    latestVersionId?: pulumi.Input<string>;
    /**
     * Name of profile
     */
    name?: pulumi.Input<string>;
    /**
     * Network Profile
     */
    networkProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileNetworkProfile>[]>;
    /**
     * cluster on which profile created
     */
    nxClusterId?: pulumi.Input<string>;
    /**
     * owner  of profile
     */
    owner?: pulumi.Input<string>;
    /**
     * Publish for all users
     */
    published?: pulumi.Input<boolean>;
    /**
     * Software Profile
     */
    softwareProfile?: pulumi.Input<inputs.NdbProfileSoftwareProfile>;
    /**
     * status of profile
     */
    status?: pulumi.Input<string>;
    /**
     * versions of associated profiles
     */
    versions?: pulumi.Input<pulumi.Input<inputs.NdbProfileVersion>[]>;
}

/**
 * The set of arguments for constructing a NdbProfile resource.
 */
export interface NdbProfileArgs {
    /**
     * Compute Profile
     */
    computeProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileComputeProfile>[]>;
    /**
     * Database Parameter Profile
     */
    databaseParameterProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileDatabaseParameterProfile>[]>;
    /**
     * Description of profile
     */
    description?: pulumi.Input<string>;
    /**
     * Engine Type of database
     */
    engineType?: pulumi.Input<string>;
    /**
     * Name of profile
     */
    name?: pulumi.Input<string>;
    /**
     * Network Profile
     */
    networkProfiles?: pulumi.Input<pulumi.Input<inputs.NdbProfileNetworkProfile>[]>;
    /**
     * Publish for all users
     */
    published?: pulumi.Input<boolean>;
    /**
     * Software Profile
     */
    softwareProfile?: pulumi.Input<inputs.NdbProfileSoftwareProfile>;
}
