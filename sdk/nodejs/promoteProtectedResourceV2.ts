// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Promotes the specified synced entity at the target site. This is only relevant if the synced entity is protected in a synchronous schedule.
 *
 * ## Example:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * // Promote a protected virtual machine on remote site
 * // This example promotes a protected virtual machine on a remote site.
 * // Steps:
 * // 1. Define the provider for the remote site
 * // 2. Create a category and a protection policy, on the local site
 * // 3. Create a virtual machine and associate it with the protection policy, on local site
 * // 4. Promote the protected virtual machine on the remote site
 * // define another alias for the provider, this time for the remote PC
 * const remote = new nutanix.Provider("remote", {
 *     username: _var.nutanix_remote_username,
 *     password: _var.nutanix_remote_password,
 *     endpoint: _var.nutanix_remote_endpoint,
 *     insecure: true,
 *     port: "9440",
 * });
 * // create a category and a protection policy on the local site
 * // promote the protected virtual machine on the remote site
 * const promote_example = new nutanix.PromoteProtectedResourceV2("promote-example", {extId: "d22529bb-f02d-4710-894b-d1de772d7832"}, {
 *     provider: nutanix.remote,
 * });
 * // protected resource (VM or VG) ext_id
 * ```
 */
export class PromoteProtectedResourceV2 extends pulumi.CustomResource {
    /**
     * Get an existing PromoteProtectedResourceV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PromoteProtectedResourceV2State, opts?: pulumi.CustomResourceOptions): PromoteProtectedResourceV2 {
        return new PromoteProtectedResourceV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/promoteProtectedResourceV2:PromoteProtectedResourceV2';

    /**
     * Returns true if the given object is an instance of PromoteProtectedResourceV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PromoteProtectedResourceV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PromoteProtectedResourceV2.__pulumiType;
    }

    /**
     * -(Required) The external identifier of a protected VM or volume group that can be used to retrieve the protected resource.
     *
     *
     * See detailed information in [Nutanix Promote Protected Resource v4](https://developers.nutanix.com/api-reference?namespace=dataprotection&version=v4.0#tag/ProtectedResources/operation/promoteProtectedResource).
     */
    public readonly extId!: pulumi.Output<string>;

    /**
     * Create a PromoteProtectedResourceV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PromoteProtectedResourceV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PromoteProtectedResourceV2Args | PromoteProtectedResourceV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as PromoteProtectedResourceV2State | undefined;
            resourceInputs["extId"] = state ? state.extId : undefined;
        } else {
            const args = argsOrState as PromoteProtectedResourceV2Args | undefined;
            if ((!args || args.extId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'extId'");
            }
            resourceInputs["extId"] = args ? args.extId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PromoteProtectedResourceV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PromoteProtectedResourceV2 resources.
 */
export interface PromoteProtectedResourceV2State {
    /**
     * -(Required) The external identifier of a protected VM or volume group that can be used to retrieve the protected resource.
     *
     *
     * See detailed information in [Nutanix Promote Protected Resource v4](https://developers.nutanix.com/api-reference?namespace=dataprotection&version=v4.0#tag/ProtectedResources/operation/promoteProtectedResource).
     */
    extId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PromoteProtectedResourceV2 resource.
 */
export interface PromoteProtectedResourceV2Args {
    /**
     * -(Required) The external identifier of a protected VM or volume group that can be used to retrieve the protected resource.
     *
     *
     * See detailed information in [Nutanix Promote Protected Resource v4](https://developers.nutanix.com/api-reference?namespace=dataprotection&version=v4.0#tag/ProtectedResources/operation/promoteProtectedResource).
     */
    extId: pulumi.Input<string>;
}
