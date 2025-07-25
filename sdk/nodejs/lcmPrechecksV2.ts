// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Perform LCM prechecks for the intended update operation.
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const pre_checks = new nutanix.LcmPrechecksV2("pre-checks", {
 *     entityUpdateSpecs: [{
 *         entityUuid: "0c5c9e53-3551-4c5d-b13c-e41c04cbfaf7",
 *         toVersion: "4.0.0",
 *     }],
 *     xClusterId: "0005a104-0b0b-4b0-8005-0b0b0b0b0b0b",
 * });
 * ```
 */
export class LcmPrechecksV2 extends pulumi.CustomResource {
    /**
     * Get an existing LcmPrechecksV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LcmPrechecksV2State, opts?: pulumi.CustomResourceOptions): LcmPrechecksV2 {
        return new LcmPrechecksV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/lcmPrechecksV2:LcmPrechecksV2';

    /**
     * Returns true if the given object is an instance of LcmPrechecksV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LcmPrechecksV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LcmPrechecksV2.__pulumiType;
    }

    /**
     * List of entity update objects for getting recommendations.
     */
    public readonly entityUpdateSpecs!: pulumi.Output<outputs.LcmPrechecksV2EntityUpdateSpec[]>;
    public /*out*/ readonly extId!: pulumi.Output<string>;
    /**
     * Cluster management server configuration used while updating clusters with ESX or Hyper-V.
     */
    public readonly managementServer!: pulumi.Output<outputs.LcmPrechecksV2ManagementServer | undefined>;
    /**
     * List of prechecks to skip. The allowed value is 'powerOffUvms' that skips the pinned VM prechecks. Items Enum: `POWER_OFF_UVMS`
     */
    public readonly skippedPrecheckFlags!: pulumi.Output<string[] | undefined>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    public readonly xClusterId!: pulumi.Output<string | undefined>;

    /**
     * Create a LcmPrechecksV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LcmPrechecksV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LcmPrechecksV2Args | LcmPrechecksV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LcmPrechecksV2State | undefined;
            resourceInputs["entityUpdateSpecs"] = state ? state.entityUpdateSpecs : undefined;
            resourceInputs["extId"] = state ? state.extId : undefined;
            resourceInputs["managementServer"] = state ? state.managementServer : undefined;
            resourceInputs["skippedPrecheckFlags"] = state ? state.skippedPrecheckFlags : undefined;
            resourceInputs["xClusterId"] = state ? state.xClusterId : undefined;
        } else {
            const args = argsOrState as LcmPrechecksV2Args | undefined;
            if ((!args || args.entityUpdateSpecs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'entityUpdateSpecs'");
            }
            resourceInputs["entityUpdateSpecs"] = args ? args.entityUpdateSpecs : undefined;
            resourceInputs["managementServer"] = args ? args.managementServer : undefined;
            resourceInputs["skippedPrecheckFlags"] = args ? args.skippedPrecheckFlags : undefined;
            resourceInputs["xClusterId"] = args ? args.xClusterId : undefined;
            resourceInputs["extId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LcmPrechecksV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LcmPrechecksV2 resources.
 */
export interface LcmPrechecksV2State {
    /**
     * List of entity update objects for getting recommendations.
     */
    entityUpdateSpecs?: pulumi.Input<pulumi.Input<inputs.LcmPrechecksV2EntityUpdateSpec>[]>;
    extId?: pulumi.Input<string>;
    /**
     * Cluster management server configuration used while updating clusters with ESX or Hyper-V.
     */
    managementServer?: pulumi.Input<inputs.LcmPrechecksV2ManagementServer>;
    /**
     * List of prechecks to skip. The allowed value is 'powerOffUvms' that skips the pinned VM prechecks. Items Enum: `POWER_OFF_UVMS`
     */
    skippedPrecheckFlags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    xClusterId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LcmPrechecksV2 resource.
 */
export interface LcmPrechecksV2Args {
    /**
     * List of entity update objects for getting recommendations.
     */
    entityUpdateSpecs: pulumi.Input<pulumi.Input<inputs.LcmPrechecksV2EntityUpdateSpec>[]>;
    /**
     * Cluster management server configuration used while updating clusters with ESX or Hyper-V.
     */
    managementServer?: pulumi.Input<inputs.LcmPrechecksV2ManagementServer>;
    /**
     * List of prechecks to skip. The allowed value is 'powerOffUvms' that skips the pinned VM prechecks. Items Enum: `POWER_OFF_UVMS`
     */
    skippedPrecheckFlags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    xClusterId?: pulumi.Input<string>;
}
