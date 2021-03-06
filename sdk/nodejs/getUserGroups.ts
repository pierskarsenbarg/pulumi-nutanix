// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve all the user groups.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const usergroups = pulumi.output(nutanix.getUserGroups());
 * ```
 */
export function getUserGroups(args?: GetUserGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetUserGroupsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getUserGroups:getUserGroups", {
        "metadatas": args.metadatas,
    }, opts);
}

/**
 * A collection of arguments for invoking getUserGroups.
 */
export interface GetUserGroupsArgs {
    metadatas?: inputs.GetUserGroupsMetadata[];
}

/**
 * A collection of values returned by getUserGroups.
 */
export interface GetUserGroupsResult {
    readonly apiVersion: string;
    readonly entities: outputs.GetUserGroupsEntity[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly metadatas: outputs.GetUserGroupsMetadata[];
}

export function getUserGroupsOutput(args?: GetUserGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetUserGroupsResult> {
    return pulumi.output(args).apply(a => getUserGroups(a, opts))
}

/**
 * A collection of arguments for invoking getUserGroups.
 */
export interface GetUserGroupsOutputArgs {
    metadatas?: pulumi.Input<pulumi.Input<inputs.GetUserGroupsMetadataArgs>[]>;
}
