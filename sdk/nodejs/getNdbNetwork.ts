// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Describes a network in Nutanix Database Service
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const nw = nutanix.getNdbNetwork({
 *     id: "{{ id of network }}",
 * });
 * ```
 */
export function getNdbNetwork(args?: GetNdbNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetNdbNetworkResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getNdbNetwork:getNdbNetwork", {
        "id": args.id,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getNdbNetwork.
 */
export interface GetNdbNetworkArgs {
    /**
     * id of network
     */
    id?: string;
    /**
     * name of network
     */
    name?: string;
}

/**
 * A collection of values returned by getNdbNetwork.
 */
export interface GetNdbNetworkResult {
    /**
     * cluster id where network is present
     */
    readonly clusterId: string;
    /**
     * network id
     */
    readonly id: string;
    /**
     * IP addresses of network
     */
    readonly ipAddresses: outputs.GetNdbNetworkIpAddress[];
    /**
     * IP Pools of network
     */
    readonly ipPools: outputs.GetNdbNetworkIpPool[];
    /**
     * network managed by NDB or not
     */
    readonly managed: boolean;
    /**
     * network name
     */
    readonly name: string;
    /**
     * properties of network
     */
    readonly properties: outputs.GetNdbNetworkProperty[];
    /**
     * properties map of network
     */
    readonly propertiesMaps: outputs.GetNdbNetworkPropertiesMap[];
    /**
     * stretched vlan id
     */
    readonly stretchedVlanId: string;
    /**
     * type of network
     */
    readonly type: string;
}
/**
 * Describes a network in Nutanix Database Service
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const nw = nutanix.getNdbNetwork({
 *     id: "{{ id of network }}",
 * });
 * ```
 */
export function getNdbNetworkOutput(args?: GetNdbNetworkOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNdbNetworkResult> {
    return pulumi.output(args).apply((a: any) => getNdbNetwork(a, opts))
}

/**
 * A collection of arguments for invoking getNdbNetwork.
 */
export interface GetNdbNetworkOutputArgs {
    /**
     * id of network
     */
    id?: pulumi.Input<string>;
    /**
     * name of network
     */
    name?: pulumi.Input<string>;
}