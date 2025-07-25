// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Run snapshot action in application to create recovery point.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const test = new nutanix.SelfServiceAppRecoveryPoint("test", {
 *     actionName: "SNAPSHOT ACTION NAME",
 *     appName: "NAME OF APPLICATION",
 *     recoveryPointName: "RECOVERY POINT NAME",
 * });
 * ```
 */
export class SelfServiceAppRecoveryPoint extends pulumi.CustomResource {
    /**
     * Get an existing SelfServiceAppRecoveryPoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SelfServiceAppRecoveryPointState, opts?: pulumi.CustomResourceOptions): SelfServiceAppRecoveryPoint {
        return new SelfServiceAppRecoveryPoint(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/selfServiceAppRecoveryPoint:SelfServiceAppRecoveryPoint';

    /**
     * Returns true if the given object is an instance of SelfServiceAppRecoveryPoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SelfServiceAppRecoveryPoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SelfServiceAppRecoveryPoint.__pulumiType;
    }

    /**
     * - (Required) The name of the snapshot action to trigger.
     */
    public readonly actionName!: pulumi.Output<string>;
    /**
     * - (Optional) The name of the application
     */
    public readonly appName!: pulumi.Output<string | undefined>;
    /**
     * - (Required) The UUID of the application.
     *
     * Both (`appName` and `appUuid`) are optional but atleast one of them should be provided for resource to work.
     */
    public readonly appUuid!: pulumi.Output<string | undefined>;
    /**
     * - (Required) The name of recovery point.
     */
    public readonly recoveryPointName!: pulumi.Output<string | undefined>;

    /**
     * Create a SelfServiceAppRecoveryPoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SelfServiceAppRecoveryPointArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SelfServiceAppRecoveryPointArgs | SelfServiceAppRecoveryPointState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SelfServiceAppRecoveryPointState | undefined;
            resourceInputs["actionName"] = state ? state.actionName : undefined;
            resourceInputs["appName"] = state ? state.appName : undefined;
            resourceInputs["appUuid"] = state ? state.appUuid : undefined;
            resourceInputs["recoveryPointName"] = state ? state.recoveryPointName : undefined;
        } else {
            const args = argsOrState as SelfServiceAppRecoveryPointArgs | undefined;
            if ((!args || args.actionName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'actionName'");
            }
            resourceInputs["actionName"] = args ? args.actionName : undefined;
            resourceInputs["appName"] = args ? args.appName : undefined;
            resourceInputs["appUuid"] = args ? args.appUuid : undefined;
            resourceInputs["recoveryPointName"] = args ? args.recoveryPointName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SelfServiceAppRecoveryPoint.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SelfServiceAppRecoveryPoint resources.
 */
export interface SelfServiceAppRecoveryPointState {
    /**
     * - (Required) The name of the snapshot action to trigger.
     */
    actionName?: pulumi.Input<string>;
    /**
     * - (Optional) The name of the application
     */
    appName?: pulumi.Input<string>;
    /**
     * - (Required) The UUID of the application.
     *
     * Both (`appName` and `appUuid`) are optional but atleast one of them should be provided for resource to work.
     */
    appUuid?: pulumi.Input<string>;
    /**
     * - (Required) The name of recovery point.
     */
    recoveryPointName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SelfServiceAppRecoveryPoint resource.
 */
export interface SelfServiceAppRecoveryPointArgs {
    /**
     * - (Required) The name of the snapshot action to trigger.
     */
    actionName: pulumi.Input<string>;
    /**
     * - (Optional) The name of the application
     */
    appName?: pulumi.Input<string>;
    /**
     * - (Required) The UUID of the application.
     *
     * Both (`appName` and `appUuid`) are optional but atleast one of them should be provided for resource to work.
     */
    appUuid?: pulumi.Input<string>;
    /**
     * - (Required) The name of recovery point.
     */
    recoveryPointName?: pulumi.Input<string>;
}
