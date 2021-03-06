// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Describes a Host
 */
export function getHost(args: GetHostArgs, opts?: pulumi.InvokeOptions): Promise<GetHostResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getHost:getHost", {
        "categories": args.categories,
        "hostId": args.hostId,
    }, opts);
}

/**
 * A collection of arguments for invoking getHost.
 */
export interface GetHostArgs {
    categories?: inputs.GetHostCategory[];
    hostId: string;
}

/**
 * A collection of values returned by getHost.
 */
export interface GetHostResult {
    /**
     * The API version.
     * * `gpuDriverVersion`: - Host GPU driver version.
     * * `failoverCluster`: - Hyper-V failover cluster.
     * * `ipmi`: - Host IPMI info.
     * * `cpuModel`: - Host CPU model.
     * * `hostNicsIdList`: - Host NICs.
     * * `numCpuSockets`: - Number of CPU sockets.
     * * `windowsDomain`: - The name of the node to be renamed to during domain-join. If not given,a new name will be automatically assigned.
     * * `gpuList`: - List of GPUs on the host.
     * * `serialNumber`: - Node serial number.
     * * `cpuCapacityHz`: - Host CPU capacity.
     * * `memoryCapacityMib`: - Host memory capacity in MiB.
     * * `hostDisksReferenceList`: - The reference to a disk.
     * * `monitoringState`: - Host monitoring status.
     * * `hypervisor`: - Host Hypervisor information.
     * * `hostType`: - Host type.
     * * `numCpuCores`: - Number of CPU cores on Host.
     * * `rackableUnitReference`: - The reference to a rackable_unit.
     * * `controllerVm`: - Host controller vm information.
     * * `block`: - Host block config info.
     */
    readonly apiVersion: string;
    readonly block: {[key: string]: string};
    readonly categories: outputs.GetHostCategory[];
    readonly clusterReference: {[key: string]: string};
    readonly controllerVm: {[key: string]: string};
    readonly cpuCapacityHz: number;
    readonly cpuModel: string;
    readonly failoverCluster: {[key: string]: string};
    readonly gpuDriverVersion: string;
    readonly gpuLists: outputs.GetHostGpuList[];
    readonly hostDisksReferenceLists: outputs.GetHostHostDisksReferenceList[];
    readonly hostId: string;
    readonly hostNicsIdLists: string[];
    readonly hostType: string;
    readonly hypervisor: {[key: string]: string};
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ipmi: {[key: string]: string};
    readonly memoryCapacityMib: number;
    readonly metadata: {[key: string]: string};
    readonly monitoringState: string;
    readonly name: string;
    readonly numCpuCores: number;
    readonly numCpuSockets: number;
    readonly ownerReference: {[key: string]: string};
    readonly projectReference: {[key: string]: string};
    readonly rackableUnitReference: {[key: string]: string};
    readonly serialNumber: string;
    readonly windowsDomain: {[key: string]: string};
}

export function getHostOutput(args: GetHostOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetHostResult> {
    return pulumi.output(args).apply(a => getHost(a, opts))
}

/**
 * A collection of arguments for invoking getHost.
 */
export interface GetHostOutputArgs {
    categories?: pulumi.Input<pulumi.Input<inputs.GetHostCategoryArgs>[]>;
    hostId: pulumi.Input<string>;
}
