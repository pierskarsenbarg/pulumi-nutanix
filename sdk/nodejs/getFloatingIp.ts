// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve floating IPs with floatingIpUuid .
 */
export function getFloatingIp(args: GetFloatingIpArgs, opts?: pulumi.InvokeOptions): Promise<GetFloatingIpResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getFloatingIp:getFloatingIp", {
        "floatingIpUuid": args.floatingIpUuid,
    }, opts);
}

/**
 * A collection of arguments for invoking getFloatingIp.
 */
export interface GetFloatingIpArgs {
    /**
     * Floating IP UUID
     */
    floatingIpUuid: string;
}

/**
 * A collection of values returned by getFloatingIp.
 */
export interface GetFloatingIpResult {
    /**
     * The version of the API.
     */
    readonly apiVersion: string;
    readonly floatingIpUuid: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly metadata: {[key: string]: string};
    /**
     * Floating IP spec
     */
    readonly specs: outputs.GetFloatingIpSpec[];
    /**
     * Floating IP output status
     */
    readonly statuses: outputs.GetFloatingIpStatus[];
}

export function getFloatingIpOutput(args: GetFloatingIpOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetFloatingIpResult> {
    return pulumi.output(args).apply(a => getFloatingIp(a, opts))
}

/**
 * A collection of arguments for invoking getFloatingIp.
 */
export interface GetFloatingIpOutputArgs {
    /**
     * Floating IP UUID
     */
    floatingIpUuid: pulumi.Input<string>;
}