// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Describe a Nutanix Category Key and its values (if it has them).
 */
export function getCategoryKey(args: GetCategoryKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetCategoryKeyResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getCategoryKey:getCategoryKey", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getCategoryKey.
 */
export interface GetCategoryKeyArgs {
    name: string;
}

/**
 * A collection of values returned by getCategoryKey.
 */
export interface GetCategoryKeyResult {
    /**
     * The version of the API.
     * * `values`: - A list of the values from this category key (if it has them).
     */
    readonly apiVersion: string;
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly systemDefined: boolean;
    readonly values: string[];
}

export function getCategoryKeyOutput(args: GetCategoryKeyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCategoryKeyResult> {
    return pulumi.output(args).apply(a => getCategoryKey(a, opts))
}

/**
 * A collection of arguments for invoking getCategoryKey.
 */
export interface GetCategoryKeyOutputArgs {
    name: pulumi.Input<string>;
}