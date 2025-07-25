// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Run the specified patch on the application by running patch action to update vm configuration, add nics, add disks, add/delete categories.
 *
 * ## Example 1: Update VM Configuration
 *
 * This will run set patch config action in application.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 * });
 * ```
 *
 * ## Example 2: Update VM Configuration with runtime editable
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 *     vmConfigs: [{
 *         memorySizeMib: "SIZE IN MiB",
 *         numSockets: "vCPU count",
 *         numVcpusPerSocket: "NUMBER OF CORES VCPU",
 *     }],
 * });
 * ```
 *
 * ## Example 3: Add Category
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 *     categories: [{
 *         value: "CATEGORY TO BE ADDED (KEY:VALUE PAIR)",
 *         operation: "add",
 *     }],
 * });
 * ```
 *
 * ## Example 4: Delete Category
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 *     categories: [{
 *         value: "CATEGORY TO BE ADDED (KEY:VALUE PAIR)",
 *         operation: "delete",
 *     }],
 * });
 * ```
 *
 * ## Example 5: Add Disk
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 *     disks: [{
 *         diskSizeMib: "SIZE OF DISK IN MiB",
 *         operation: "add",
 *     }],
 * });
 * ```
 *
 * ## Example 6: Add Nic
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Provision Application
 * const testSelfServiceAppProvision = new nutanix.SelfServiceAppProvision("testSelfServiceAppProvision", {
 *     bpName: "NAME OF BLUEPRINT",
 *     appName: "NAME OF APPLICATION",
 *     appDescription: "DESCRIPTION OF APPLICATION",
 * });
 * // Run patch config (update config)
 * const testSelfServiceAppPatch = new nutanix.SelfServiceAppPatch("testSelfServiceAppPatch", {
 *     appUuid: testSelfServiceAppProvision.id,
 *     patchName: "NAME OF PATCH ACTION",
 *     configName: "NAME OF PATCH CONFIG",
 *     nics: [{
 *         index: "DUMMY INDEX VALUE",
 *         operation: "add",
 *         subnetUuid: "VALID SUBNET UUID IN PROJECT ATTACHED TO APP",
 *     }],
 * });
 * ```
 */
export class SelfServiceAppPatch extends pulumi.CustomResource {
    /**
     * Get an existing SelfServiceAppPatch resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SelfServiceAppPatchState, opts?: pulumi.CustomResourceOptions): SelfServiceAppPatch {
        return new SelfServiceAppPatch(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/selfServiceAppPatch:SelfServiceAppPatch';

    /**
     * Returns true if the given object is an instance of SelfServiceAppPatch.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SelfServiceAppPatch {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SelfServiceAppPatch.__pulumiType;
    }

    /**
     * - (Required) The UUID of the application.
     */
    public readonly appUuid!: pulumi.Output<string>;
    public readonly categories!: pulumi.Output<outputs.SelfServiceAppPatchCategory[] | undefined>;
    /**
     * - (Required) The name of the patch configuration. (<b>Same as patchName for SINGLE VM)</b>
     */
    public readonly configName!: pulumi.Output<string>;
    public readonly disks!: pulumi.Output<outputs.SelfServiceAppPatchDisk[] | undefined>;
    public readonly nics!: pulumi.Output<outputs.SelfServiceAppPatchNic[] | undefined>;
    /**
     * - (Required) The name of the patch to be applied. This is used to identify the action name which needs to be executed to update an application.
     */
    public readonly patchName!: pulumi.Output<string>;
    /**
     * - (Computed) The UUID of the runlog that records the patch operation's execution details.
     */
    public readonly runlogUuid!: pulumi.Output<string>;
    public readonly vmConfigs!: pulumi.Output<outputs.SelfServiceAppPatchVmConfig[] | undefined>;

    /**
     * Create a SelfServiceAppPatch resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SelfServiceAppPatchArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SelfServiceAppPatchArgs | SelfServiceAppPatchState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SelfServiceAppPatchState | undefined;
            resourceInputs["appUuid"] = state ? state.appUuid : undefined;
            resourceInputs["categories"] = state ? state.categories : undefined;
            resourceInputs["configName"] = state ? state.configName : undefined;
            resourceInputs["disks"] = state ? state.disks : undefined;
            resourceInputs["nics"] = state ? state.nics : undefined;
            resourceInputs["patchName"] = state ? state.patchName : undefined;
            resourceInputs["runlogUuid"] = state ? state.runlogUuid : undefined;
            resourceInputs["vmConfigs"] = state ? state.vmConfigs : undefined;
        } else {
            const args = argsOrState as SelfServiceAppPatchArgs | undefined;
            if ((!args || args.appUuid === undefined) && !opts.urn) {
                throw new Error("Missing required property 'appUuid'");
            }
            if ((!args || args.configName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'configName'");
            }
            if ((!args || args.patchName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'patchName'");
            }
            resourceInputs["appUuid"] = args ? args.appUuid : undefined;
            resourceInputs["categories"] = args ? args.categories : undefined;
            resourceInputs["configName"] = args ? args.configName : undefined;
            resourceInputs["disks"] = args ? args.disks : undefined;
            resourceInputs["nics"] = args ? args.nics : undefined;
            resourceInputs["patchName"] = args ? args.patchName : undefined;
            resourceInputs["runlogUuid"] = args ? args.runlogUuid : undefined;
            resourceInputs["vmConfigs"] = args ? args.vmConfigs : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SelfServiceAppPatch.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SelfServiceAppPatch resources.
 */
export interface SelfServiceAppPatchState {
    /**
     * - (Required) The UUID of the application.
     */
    appUuid?: pulumi.Input<string>;
    categories?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchCategory>[]>;
    /**
     * - (Required) The name of the patch configuration. (<b>Same as patchName for SINGLE VM)</b>
     */
    configName?: pulumi.Input<string>;
    disks?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchDisk>[]>;
    nics?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchNic>[]>;
    /**
     * - (Required) The name of the patch to be applied. This is used to identify the action name which needs to be executed to update an application.
     */
    patchName?: pulumi.Input<string>;
    /**
     * - (Computed) The UUID of the runlog that records the patch operation's execution details.
     */
    runlogUuid?: pulumi.Input<string>;
    vmConfigs?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchVmConfig>[]>;
}

/**
 * The set of arguments for constructing a SelfServiceAppPatch resource.
 */
export interface SelfServiceAppPatchArgs {
    /**
     * - (Required) The UUID of the application.
     */
    appUuid: pulumi.Input<string>;
    categories?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchCategory>[]>;
    /**
     * - (Required) The name of the patch configuration. (<b>Same as patchName for SINGLE VM)</b>
     */
    configName: pulumi.Input<string>;
    disks?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchDisk>[]>;
    nics?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchNic>[]>;
    /**
     * - (Required) The name of the patch to be applied. This is used to identify the action name which needs to be executed to update an application.
     */
    patchName: pulumi.Input<string>;
    /**
     * - (Computed) The UUID of the runlog that records the patch operation's execution details.
     */
    runlogUuid?: pulumi.Input<string>;
    vmConfigs?: pulumi.Input<pulumi.Input<inputs.SelfServiceAppPatchVmConfig>[]>;
}
