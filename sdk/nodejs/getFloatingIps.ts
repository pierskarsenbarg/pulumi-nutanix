// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve all the floating IPs .
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const test = pulumi.output(nutanix.getFloatingIps());
 * ```
 */
export function getFloatingIps(args?: GetFloatingIpsArgs, opts?: pulumi.InvokeOptions): Promise<GetFloatingIpsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getFloatingIps:getFloatingIps", {
        "metadatas": args.metadatas,
    }, opts);
}

/**
 * A collection of arguments for invoking getFloatingIps.
 */
export interface GetFloatingIpsArgs {
    metadatas?: inputs.GetFloatingIpsMetadata[];
}

/**
 * A collection of values returned by getFloatingIps.
 */
export interface GetFloatingIpsResult {
    readonly apiVersion: string;
    readonly entities: outputs.GetFloatingIpsEntity[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly metadatas: outputs.GetFloatingIpsMetadata[];
}

export function getFloatingIpsOutput(args?: GetFloatingIpsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFloatingIpsResult> {
    return pulumi.output(args).apply(a => getFloatingIps(a, opts))
}

/**
 * A collection of arguments for invoking getFloatingIps.
 */
export interface GetFloatingIpsOutputArgs {
    metadatas?: pulumi.Input<pulumi.Input<inputs.GetFloatingIpsMetadataArgs>[]>;
}