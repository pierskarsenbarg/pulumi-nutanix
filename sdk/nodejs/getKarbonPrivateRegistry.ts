// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Describes Karbon private registry entry
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const registry = pulumi.output(nutanix.getKarbonPrivateRegistry({
 *     clusterId: "<YOUR-CLUSTER-ID>",
 * }));
 * ```
 */
export function getKarbonPrivateRegistry(args?: GetKarbonPrivateRegistryArgs, opts?: pulumi.InvokeOptions): Promise<GetKarbonPrivateRegistryResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getKarbonPrivateRegistry:getKarbonPrivateRegistry", {
        "privateRegistryId": args.privateRegistryId,
        "privateRegistryName": args.privateRegistryName,
    }, opts);
}

/**
 * A collection of arguments for invoking getKarbonPrivateRegistry.
 */
export interface GetKarbonPrivateRegistryArgs {
    privateRegistryId?: string;
    privateRegistryName?: string;
}

/**
 * A collection of values returned by getKarbonPrivateRegistry.
 */
export interface GetKarbonPrivateRegistryResult {
    readonly endpoint: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly privateRegistryId?: string;
    readonly privateRegistryName?: string;
    readonly uuid: string;
}

export function getKarbonPrivateRegistryOutput(args?: GetKarbonPrivateRegistryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKarbonPrivateRegistryResult> {
    return pulumi.output(args).apply(a => getKarbonPrivateRegistry(a, opts))
}

/**
 * A collection of arguments for invoking getKarbonPrivateRegistry.
 */
export interface GetKarbonPrivateRegistryOutputArgs {
    privateRegistryId?: pulumi.Input<string>;
    privateRegistryName?: pulumi.Input<string>;
}
