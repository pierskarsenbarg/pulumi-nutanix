// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Describes a Virtual Machine
 */
export function getVirtualMachine(args: GetVirtualMachineArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualMachineResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getVirtualMachine:getVirtualMachine", {
        "bootDeviceDiskAddress": args.bootDeviceDiskAddress,
        "bootDeviceMacAddress": args.bootDeviceMacAddress,
        "categories": args.categories,
        "vmId": args.vmId,
    }, opts);
}

/**
 * A collection of arguments for invoking getVirtualMachine.
 */
export interface GetVirtualMachineArgs {
    bootDeviceDiskAddress?: {[key: string]: string};
    bootDeviceMacAddress?: string;
    categories?: inputs.GetVirtualMachineCategory[];
    vmId: string;
}

/**
 * A collection of values returned by getVirtualMachine.
 */
export interface GetVirtualMachineResult {
    /**
     * The version of the API.
     * * `description`: - A description for vm.
     * * `numVnumaNodes`: - Number of vNUMA nodes. 0 means vNUMA is disabled.
     * * `nicList`: - NICs attached to the VM.
     * * `serialPortList`: - (Optional) Serial Ports configured on the VM.
     * * `guestOsId`: - Guest OS Identifier. For ESX, refer to VMware documentation [link](https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.
     * * `powerState`: - The current or desired power state of the VM. (Options : ON , OFF)
     * * `nutanixGuestTools`: - Information regarding Nutanix Guest Tools.
     * * `ngtCredentials`: - Credentials to login server.
     */
    readonly apiVersion: string;
    readonly availabilityZoneReference: {[key: string]: string};
    readonly bootDeviceDiskAddress: {[key: string]: string};
    readonly bootDeviceMacAddress: string;
    readonly bootDeviceOrderLists: string[];
    readonly bootType: string;
    readonly categories: outputs.GetVirtualMachineCategory[];
    readonly clusterName: string;
    readonly clusterUuid: string;
    readonly description: string;
    readonly diskLists: outputs.GetVirtualMachineDiskList[];
    readonly enableCpuPassthrough: boolean;
    readonly enableScriptExec: boolean;
    readonly gpuLists: outputs.GetVirtualMachineGpuList[];
    readonly guestCustomizationCloudInitCustomKeyValues: {[key: string]: any};
    /**
     * The contents of the metaData configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64 encoded.
     * * `guestCustomizationIsOverridable`: - Flag to allow override of customization by deployer.
     * * `guestCustomizationCloudInitCustomKeyValues`: - Generic key value pair used for custom attributes in cloud init.
     * * `guestCustomizationSysprep`: - VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloudInit should be provided. Note that guest customization can currently only be set during VM creation. Attempting to change it after creation will result in an error. Additional properties can be specified. For example - in the context of VM template creation if \"override_script\" is set to \"True\" then the deployer can upload their own custom script.
     * * `guestCustomizationSysrepCustomKeyValues`: - Generic key value pair used for custom attributes in sysrep.
     * * `shouldFailOnScriptFailure`: -  Extra configs related to power state transition. Indicates whether to abort ngt shutdown/reboot if script fails.
     * * `enableScriptExec`: - Extra configs related to power state transition. Indicates whether to execute set script before ngt shutdown/reboot.
     * * `powerStateMechanism`: - Indicates the mechanism guiding the VM power state transition. Currently used for the transition to \"OFF\" state. Power state mechanism (ACPI/GUEST/HARD).
     * * `vgaConsoleEnabled`: - Indicates whether VGA console should be enabled or not.
     * * `diskList` Disks attached to the VM.
     * * `metadata`: - The vm kind metadata.
     * * `state`: - The state of the vm.
     * * `ipAddress`: - An IP address.
     * * `hostReference`: - Reference to a host.
     * * `hypervisorType`: - The hypervisor type for the hypervisor the VM is hosted on.
     */
    readonly guestCustomizationCloudInitMetaData: string;
    readonly guestCustomizationCloudInitUserData: string;
    readonly guestCustomizationIsOverridable: boolean;
    readonly guestCustomizationSysprep: {[key: string]: string};
    readonly guestCustomizationSysprepCustomKeyValues: {[key: string]: any};
    readonly guestOsId: string;
    readonly hardwareClockTimezone: string;
    readonly hostReference: {[key: string]: string};
    readonly hypervisorType: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly isVcpuHardPinned: boolean;
    readonly machineType: string;
    readonly memorySizeMib: number;
    readonly messageLists: outputs.GetVirtualMachineMessageList[];
    readonly metadata: {[key: string]: string};
    readonly name: string;
    readonly ngtCredentials: {[key: string]: any};
    /**
     * Application names that are enabled.
     * * `numVcpusPerSocket`: - Number of vCPUs per socket.
     * * `numSockets`: - Number of vCPU sockets.
     * * `gpuList`: - GPUs attached to the VM.
     * * `parentReferece`: - Reference to an entity that the VM cloned from.
     * * `memorySizeMib`: - Memory size in MiB.
     * * `bootDeviceOrderList`: - Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.
     * * `bootDeviceDiskAddress`: - Address of disk to boot from.
     * * `bootDeviceMacAddress`: - MAC address of nic to boot from.
     * * `bootType`: - Indicates whether the VM should use Secure boot, UEFI boot or Legacy boot.If UEFI or; Secure boot is enabled then other legacy boot options (like bootDevice and; boot_device_order_list) are ignored. Secure boot depends on UEFI boot, i.e. enabling; Secure boot means that UEFI boot is also enabled. The possible value are: UEFI", "LEGACY", "SECURE_BOOT".
     * * `machineType`: - Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks.
     * * `hardwareClockTimezone`: - VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).
     * * `guestCustomizationCloudInitUserData`: - The contents of the userData configuration for cloud-init. This can be formatted as YAML, JSON, or could be a shell script. The value must be base64 encoded.
     */
    readonly ngtEnabledCapabilityLists: string[];
    readonly nicLists: outputs.GetVirtualMachineNicList[];
    readonly numSockets: number;
    readonly numVcpusPerSocket: number;
    readonly numVnumaNodes: number;
    readonly nutanixGuestTools: {[key: string]: string};
    readonly ownerReference: {[key: string]: string};
    readonly parentReference: {[key: string]: string};
    readonly powerState: string;
    readonly powerStateMechanism: string;
    readonly projectReference: {[key: string]: string};
    readonly serialPortLists: outputs.GetVirtualMachineSerialPortList[];
    readonly shouldFailOnScriptFailure: boolean;
    readonly state: string;
    readonly vgaConsoleEnabled: boolean;
    readonly vmId: string;
}

export function getVirtualMachineOutput(args: GetVirtualMachineOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVirtualMachineResult> {
    return pulumi.output(args).apply(a => getVirtualMachine(a, opts))
}

/**
 * A collection of arguments for invoking getVirtualMachine.
 */
export interface GetVirtualMachineOutputArgs {
    bootDeviceDiskAddress?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    bootDeviceMacAddress?: pulumi.Input<string>;
    categories?: pulumi.Input<pulumi.Input<inputs.GetVirtualMachineCategoryArgs>[]>;
    vmId: pulumi.Input<string>;
}