// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides Nutanix resource to create Static Routes within VPCs.
 *
 * ## create one static route for vpc uuid with external subnet
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const scn = new nutanix.StaticRoutes("scn", {
 *     staticRoutesLists: [{
 *         destination: "10.x.x.x/x",
 *         externalSubnetReferenceUuid: "{{ext_subnet_uuid}}",
 *     }],
 *     vpcUuid: "{{vpc_uuid}}",
 * });
 * ```
 *
 * ## create one static route with default route for vpc name with external subnet
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const scn = new nutanix.StaticRoutes("scn", {
 *     defaultRouteNexthops: [{
 *         externalSubnetReferenceUuid: "{{ext_subnet_uuid}}",
 *     }],
 *     staticRoutesLists: [{
 *         destination: "10.x.x.x/x",
 *         externalSubnetReferenceUuid: "{{ext_subnet_uuid}}",
 *     }],
 *     vpcName: "{{vpc_name}}",
 * });
 * ```
 *
 * #### Note: destination with 0.0.0.0/0 will be default route.
 */
export class StaticRoutes extends pulumi.CustomResource {
    /**
     * Get an existing StaticRoutes resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: StaticRoutesState, opts?: pulumi.CustomResourceOptions): StaticRoutes {
        return new StaticRoutes(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/staticRoutes:StaticRoutes';

    /**
     * Returns true if the given object is an instance of StaticRoutes.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StaticRoutes {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StaticRoutes.__pulumiType;
    }

    /**
     * The version of the API.
     */
    public readonly apiVersion!: pulumi.Output<string>;
    /**
     * Default Route
     */
    public readonly defaultRouteNexthops!: pulumi.Output<outputs.StaticRoutesDefaultRouteNexthop[] | undefined>;
    /**
     * The vpcRouteTable kind metadata.
     */
    public /*out*/ readonly metadata!: pulumi.Output<{[key: string]: string}>;
    /**
     * Static Routes.
     */
    public readonly staticRoutesLists!: pulumi.Output<outputs.StaticRoutesStaticRoutesList[] | undefined>;
    /**
     * vpc Name. Should not be used with vpc_uuid.
     */
    public readonly vpcName!: pulumi.Output<string | undefined>;
    /**
     * Reference to a VPC UUID. Should not be used with vpc_name.
     */
    public readonly vpcUuid!: pulumi.Output<string>;

    /**
     * Create a StaticRoutes resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: StaticRoutesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: StaticRoutesArgs | StaticRoutesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as StaticRoutesState | undefined;
            resourceInputs["apiVersion"] = state ? state.apiVersion : undefined;
            resourceInputs["defaultRouteNexthops"] = state ? state.defaultRouteNexthops : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["staticRoutesLists"] = state ? state.staticRoutesLists : undefined;
            resourceInputs["vpcName"] = state ? state.vpcName : undefined;
            resourceInputs["vpcUuid"] = state ? state.vpcUuid : undefined;
        } else {
            const args = argsOrState as StaticRoutesArgs | undefined;
            resourceInputs["apiVersion"] = args ? args.apiVersion : undefined;
            resourceInputs["defaultRouteNexthops"] = args ? args.defaultRouteNexthops : undefined;
            resourceInputs["staticRoutesLists"] = args ? args.staticRoutesLists : undefined;
            resourceInputs["vpcName"] = args ? args.vpcName : undefined;
            resourceInputs["vpcUuid"] = args ? args.vpcUuid : undefined;
            resourceInputs["metadata"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(StaticRoutes.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering StaticRoutes resources.
 */
export interface StaticRoutesState {
    /**
     * The version of the API.
     */
    apiVersion?: pulumi.Input<string>;
    /**
     * Default Route
     */
    defaultRouteNexthops?: pulumi.Input<pulumi.Input<inputs.StaticRoutesDefaultRouteNexthop>[]>;
    /**
     * The vpcRouteTable kind metadata.
     */
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Static Routes.
     */
    staticRoutesLists?: pulumi.Input<pulumi.Input<inputs.StaticRoutesStaticRoutesList>[]>;
    /**
     * vpc Name. Should not be used with vpc_uuid.
     */
    vpcName?: pulumi.Input<string>;
    /**
     * Reference to a VPC UUID. Should not be used with vpc_name.
     */
    vpcUuid?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a StaticRoutes resource.
 */
export interface StaticRoutesArgs {
    /**
     * The version of the API.
     */
    apiVersion?: pulumi.Input<string>;
    /**
     * Default Route
     */
    defaultRouteNexthops?: pulumi.Input<pulumi.Input<inputs.StaticRoutesDefaultRouteNexthop>[]>;
    /**
     * Static Routes.
     */
    staticRoutesLists?: pulumi.Input<pulumi.Input<inputs.StaticRoutesStaticRoutesList>[]>;
    /**
     * vpc Name. Should not be used with vpc_uuid.
     */
    vpcName?: pulumi.Input<string>;
    /**
     * Reference to a VPC UUID. Should not be used with vpc_name.
     */
    vpcUuid?: pulumi.Input<string>;
}
