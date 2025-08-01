// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Describes the statistics data of the host identified by {hostExtId} belonging to the cluster identified by {clusterExtId}.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const host = nutanix.getHostV2({
 *     clusterExtId: "021151dc-3ed1-4fec-a81d-39606451750c",
 *     extId: "919c9488-0b50-4fc8-9159-923e56a3abca",
 * });
 * ```
 */
export function getHostV2(args: GetHostV2Args, opts?: pulumi.InvokeOptions): Promise<GetHostV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getHostV2:getHostV2", {
        "clusterExtId": args.clusterExtId,
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getHostV2.
 */
export interface GetHostV2Args {
    /**
     * - (Required) cluster uuid
     */
    clusterExtId: string;
    /**
     * - (Required) host uuid
     */
    extId: string;
}

/**
 * A collection of values returned by getHostV2.
 */
export interface GetHostV2Result {
    /**
     * - Rackable unit model name.
     */
    readonly blockModel: string;
    /**
     * - Rackable unit serial name.
     */
    readonly blockSerial: string;
    /**
     * - Boot time in secs.
     */
    readonly bootTimeUsecs: number;
    readonly clusterExtId: string;
    /**
     * - Cluster reference for an entity.
     */
    readonly clusters: outputs.GetHostV2Cluster[];
    /**
     * - Host entity with its attributes.
     */
    readonly controllerVms: outputs.GetHostV2ControllerVm[];
    /**
     * - CPU capacity in Hz.
     */
    readonly cpuCapacityHz: number;
    /**
     * - CPU frequency in Hz.
     */
    readonly cpuFrequencyHz: number;
    /**
     * - CPU model name.
     */
    readonly cpuModel: string;
    /**
     * - Default VHD container UUID.
     */
    readonly defaultVhdContainerUuid: string;
    /**
     * - Default VHD location.
     */
    readonly defaultVhdLocation: string;
    /**
     * - Default VM container UUID.
     */
    readonly defaultVmContainerUuid: string;
    /**
     * - Default VM location.
     */
    readonly defaultVmLocation: string;
    /**
     * - Disks attached to host.
     */
    readonly disks: outputs.GetHostV2Disk[];
    /**
     * - A globally unique identifier of an instance that is suitable for external consumption.
     */
    readonly extId: string;
    /**
     * - Failover cluster FQDN.
     */
    readonly failoverClusterFqdn: string;
    /**
     * - Failover cluster node status.
     */
    readonly failoverClusterNodeStatus: string;
    /**
     * - GPU driver version.
     */
    readonly gpuDriverVersion: string;
    /**
     * - GPU attached list.
     */
    readonly gpuLists: string[];
    /**
     * - Certificate signing request status.
     */
    readonly hasCsr: boolean;
    /**
     * - Name of the host.
     */
    readonly hostName: string;
    /**
     * - Type of the host.
     * * `HYPER_CONVERGED`: Hyper-converged node.
     * * `COMPUTE_ONLY`: Compute only node.
     * * `STORAGE_ONLY`: Storage only node.
     */
    readonly hostType: string;
    /**
     * - Hypervisor details.
     */
    readonly hypervisors: outputs.GetHostV2Hypervisor[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * - IPMI reference.
     */
    readonly ipmis: outputs.GetHostV2Ipmi[];
    /**
     * - Node degraded status.
     */
    readonly isDegraded: boolean;
    /**
     * - Indicates whether the hardware is virtualized or not.
     */
    readonly isHardwareVirtualized: boolean;
    readonly isRebootPending: boolean;
    /**
     * - Secure boot status.
     */
    readonly isSecureBooted: boolean;
    /**
     * - Mapping of key management device to certificate status list.
     */
    readonly keyManagementDeviceToCertStatuses: outputs.GetHostV2KeyManagementDeviceToCertStatus[];
    /**
     * - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
     */
    readonly links: outputs.GetHostV2Link[];
    /**
     * - Host Maintenance State.
     */
    readonly maintenanceState: string;
    /**
     * - Memory size in bytes.
     */
    readonly memorySizeBytes: number;
    /**
     * - Node status.
     * * `TO_BE_PREPROTECTED`: Node to be preprotected.
     * * `TO_BE_REMOVED`: Node to be removed.
     * * `PREPROTECTED`: Node is preprotected.
     * * `OK_TO_BE_REMOVED`: Indicates whether removing the node from the cluster is adequate.
     * * `NORMAL`: Normal node.
     * * `NEW_NODE`: New node.
     */
    readonly nodeStatus: string;
    /**
     * - Number of CPU cores.
     */
    readonly numberOfCpuCores: number;
    /**
     * - Number of CPU sockets.
     */
    readonly numberOfCpuSockets: number;
    /**
     * - Number of CPU threads.
     */
    readonly numberOfCpuThreads: number;
    /**
     * - Rackable unit UUID.
     */
    readonly rackableUnitUuid: string;
    /**
     * - image uuid.
     */
    readonly tenantId: string;
}
/**
 * Describes the statistics data of the host identified by {hostExtId} belonging to the cluster identified by {clusterExtId}.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const host = nutanix.getHostV2({
 *     clusterExtId: "021151dc-3ed1-4fec-a81d-39606451750c",
 *     extId: "919c9488-0b50-4fc8-9159-923e56a3abca",
 * });
 * ```
 */
export function getHostV2Output(args: GetHostV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetHostV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getHostV2:getHostV2", {
        "clusterExtId": args.clusterExtId,
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getHostV2.
 */
export interface GetHostV2OutputArgs {
    /**
     * - (Required) cluster uuid
     */
    clusterExtId: pulumi.Input<string>;
    /**
     * - (Required) host uuid
     */
    extId: pulumi.Input<string>;
}
