// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Update LCM configuration.
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Enable Auto Inventory, Add Auto Inventory Schedule and enable auto upgrade
 * const lcm_configuration_update = new nutanix.LcmConfigV2("lcm-configuration-update", {
 *     autoInventorySchedule: "16:30",
 *     hasModuleAutoUpgradeEnabled: true,
 *     isAutoInventoryEnabled: true,
 *     xClusterId: "0005a104-0b0b-4b0b-8005-0b0b0b0b0b0b",
 * });
 * // Update the LCM url to darksite server
 * const lcm_configuration_update_connectivity_type = new nutanix.LcmConfigV2("lcm-configuration-update-connectivity-type", {
 *     connectivityType: "DARKSITE_WEB_SERVER",
 *     url: "https://x.x.x.x:8000/builds",
 *     xClusterId: "0005a104-0b0b-4b0b-8005-0b0b0b0b0b0b",
 * });
 * ```
 */
export class LcmConfigV2 extends pulumi.CustomResource {
    /**
     * Get an existing LcmConfigV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LcmConfigV2State, opts?: pulumi.CustomResourceOptions): LcmConfigV2 {
        return new LcmConfigV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/lcmConfigV2:LcmConfigV2';

    /**
     * Returns true if the given object is an instance of LcmConfigV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LcmConfigV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LcmConfigV2.__pulumiType;
    }

    /**
     * The scheduled time in "%H:%M" 24-hour format of the next inventory execution. Used when autoInventoryEnabled is set to True. The default schedule time is 03:00(AM).
     */
    public readonly autoInventorySchedule!: pulumi.Output<string | undefined>;
    /**
     * This field indicates whether LCM framework on the cluster is running in connected-site mode or darksite mode.
     */
    public readonly connectivityType!: pulumi.Output<string | undefined>;
    public /*out*/ readonly extId!: pulumi.Output<string>;
    /**
     * Indicates if LCM is enabled to auto-upgrade products. The default value is False.
     *
     * See detailed information in [Nutanix Update LCM Config V4](https://developers.nutanix.com/api-reference?namespace=lifecycle&version=v4.0#tag/Config/operation/updateConfig)
     */
    public readonly hasModuleAutoUpgradeEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates if the auto inventory operation is enabled. The default value is set to False.
     */
    public readonly isAutoInventoryEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates if the LCM URL has HTTPS enabled. The default value is True.
     */
    public readonly isHttpsEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * URL of the LCM repository.
     */
    public readonly url!: pulumi.Output<string | undefined>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    public readonly xClusterId!: pulumi.Output<string | undefined>;

    /**
     * Create a LcmConfigV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: LcmConfigV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LcmConfigV2Args | LcmConfigV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LcmConfigV2State | undefined;
            resourceInputs["autoInventorySchedule"] = state ? state.autoInventorySchedule : undefined;
            resourceInputs["connectivityType"] = state ? state.connectivityType : undefined;
            resourceInputs["extId"] = state ? state.extId : undefined;
            resourceInputs["hasModuleAutoUpgradeEnabled"] = state ? state.hasModuleAutoUpgradeEnabled : undefined;
            resourceInputs["isAutoInventoryEnabled"] = state ? state.isAutoInventoryEnabled : undefined;
            resourceInputs["isHttpsEnabled"] = state ? state.isHttpsEnabled : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
            resourceInputs["xClusterId"] = state ? state.xClusterId : undefined;
        } else {
            const args = argsOrState as LcmConfigV2Args | undefined;
            resourceInputs["autoInventorySchedule"] = args ? args.autoInventorySchedule : undefined;
            resourceInputs["connectivityType"] = args ? args.connectivityType : undefined;
            resourceInputs["hasModuleAutoUpgradeEnabled"] = args ? args.hasModuleAutoUpgradeEnabled : undefined;
            resourceInputs["isAutoInventoryEnabled"] = args ? args.isAutoInventoryEnabled : undefined;
            resourceInputs["isHttpsEnabled"] = args ? args.isHttpsEnabled : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
            resourceInputs["xClusterId"] = args ? args.xClusterId : undefined;
            resourceInputs["extId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LcmConfigV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LcmConfigV2 resources.
 */
export interface LcmConfigV2State {
    /**
     * The scheduled time in "%H:%M" 24-hour format of the next inventory execution. Used when autoInventoryEnabled is set to True. The default schedule time is 03:00(AM).
     */
    autoInventorySchedule?: pulumi.Input<string>;
    /**
     * This field indicates whether LCM framework on the cluster is running in connected-site mode or darksite mode.
     */
    connectivityType?: pulumi.Input<string>;
    extId?: pulumi.Input<string>;
    /**
     * Indicates if LCM is enabled to auto-upgrade products. The default value is False.
     *
     * See detailed information in [Nutanix Update LCM Config V4](https://developers.nutanix.com/api-reference?namespace=lifecycle&version=v4.0#tag/Config/operation/updateConfig)
     */
    hasModuleAutoUpgradeEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates if the auto inventory operation is enabled. The default value is set to False.
     */
    isAutoInventoryEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates if the LCM URL has HTTPS enabled. The default value is True.
     */
    isHttpsEnabled?: pulumi.Input<boolean>;
    /**
     * URL of the LCM repository.
     */
    url?: pulumi.Input<string>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    xClusterId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LcmConfigV2 resource.
 */
export interface LcmConfigV2Args {
    /**
     * The scheduled time in "%H:%M" 24-hour format of the next inventory execution. Used when autoInventoryEnabled is set to True. The default schedule time is 03:00(AM).
     */
    autoInventorySchedule?: pulumi.Input<string>;
    /**
     * This field indicates whether LCM framework on the cluster is running in connected-site mode or darksite mode.
     */
    connectivityType?: pulumi.Input<string>;
    /**
     * Indicates if LCM is enabled to auto-upgrade products. The default value is False.
     *
     * See detailed information in [Nutanix Update LCM Config V4](https://developers.nutanix.com/api-reference?namespace=lifecycle&version=v4.0#tag/Config/operation/updateConfig)
     */
    hasModuleAutoUpgradeEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates if the auto inventory operation is enabled. The default value is set to False.
     */
    isAutoInventoryEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates if the LCM URL has HTTPS enabled. The default value is True.
     */
    isHttpsEnabled?: pulumi.Input<boolean>;
    /**
     * URL of the LCM repository.
     */
    url?: pulumi.Input<string>;
    /**
     * Cluster uuid on which the resource is present or operation is being performed.
     */
    xClusterId?: pulumi.Input<string>;
}
