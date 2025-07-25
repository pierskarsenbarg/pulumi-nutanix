// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Creates a Virtual Machine with the provided configuration.
 */
export class VirtualMachineV2 extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineV2 resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VirtualMachineV2State, opts?: pulumi.CustomResourceOptions): VirtualMachineV2 {
        return new VirtualMachineV2(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/virtualMachineV2:VirtualMachineV2';

    /**
     * Returns true if the given object is an instance of VirtualMachineV2.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineV2 {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineV2.__pulumiType;
    }

    /**
     * Advanced Processor Compatibility configuration for the VM. Enabling this retains the CPU model for the VM across power cycles and migrations.
     */
    public readonly apcConfigs!: pulumi.Output<outputs.VirtualMachineV2ApcConfig[]>;
    public readonly availabilityZones!: pulumi.Output<outputs.VirtualMachineV2AvailabilityZone[]>;
    /**
     * BIOS UUID of the VM. It should be of type UUID.
     */
    public readonly biosUuid!: pulumi.Output<string>;
    /**
     * Indicates the order of device types in which the VM should try to boot from. If the boot device order is not provided the system will decide an appropriate boot device order.
     */
    public readonly bootConfigs!: pulumi.Output<outputs.VirtualMachineV2BootConfig[]>;
    /**
     * Categories for the VM.
     */
    public readonly categories!: pulumi.Output<outputs.VirtualMachineV2Category[]>;
    /**
     * CD-ROMs attached to the VM.
     */
    public readonly cdRoms!: pulumi.Output<outputs.VirtualMachineV2CdRom[] | undefined>;
    /**
     * Reference to a cluster.
     */
    public readonly clusters!: pulumi.Output<outputs.VirtualMachineV2Cluster[]>;
    /**
     * VM creation time
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * VM description
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Disks attached to the VM.
     */
    public readonly disks!: pulumi.Output<outputs.VirtualMachineV2Disk[] | undefined>;
    /**
     * The list of additional CPU features to be enabled. HardwareVirtualization: Indicates whether hardware assisted virtualization should be enabled for the Guest OS or not. Once enabled, the Guest OS can deploy a nested hypervisor. Valid values are "HARDWARE_VIRTUALIZATION".
     */
    public readonly enabledCpuFeatures!: pulumi.Output<string[]>;
    /**
     * A globally unique identifier of an instance that is suitable for external consumption.
     */
    public /*out*/ readonly extId!: pulumi.Output<string>;
    /**
     * Generation UUID of the VM. It should be of type UUID.
     */
    public readonly generationUuid!: pulumi.Output<string>;
    /**
     * GPUs attached to the VM.
     */
    public readonly gpuses!: pulumi.Output<outputs.VirtualMachineV2Gpus[] | undefined>;
    /**
     * Stage a Sysprep or cloud-init configuration file to be used by the guest for the next boot. Note that the Sysprep command must be used to generalize the Windows VMs before triggering this API call.
     */
    public readonly guestCustomizations!: pulumi.Output<outputs.VirtualMachineV2GuestCustomization[]>;
    /**
     * The details about Nutanix Guest Tools for a VM.
     */
    public readonly guestTools!: pulumi.Output<outputs.VirtualMachineV2GuestTool[] | undefined>;
    /**
     * VM hardware clock timezone in IANA TZDB format (America/Los_Angeles).
     */
    public readonly hardwareClockTimezone!: pulumi.Output<string>;
    /**
     * Reference to the host, the VM is running on.
     */
    public readonly hosts!: pulumi.Output<outputs.VirtualMachineV2Host[]>;
    /**
     * Indicates whether the VM is an agent VM or not. When their host enters maintenance mode, once the normal VMs are evacuated, the agent VMs are powered off. When the host is restored, agent VMs are powered on before the normal VMs are restored. In other words, agent VMs cannot be HA-protected or live migrated.
     */
    public readonly isAgentVm!: pulumi.Output<boolean>;
    /**
     * Indicates whether to remove AHV branding from VM firmware tables or not.
     */
    public readonly isBrandingEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the VM CPU hotplug is enabled.
     */
    public readonly isCpuHotplugEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether to passthrough the host CPU features to the guest or not. Enabling this will make VM incapable of live migration.
     */
    public readonly isCpuPassthroughEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the vGPU console is enabled or not.
     */
    public readonly isGpuConsoleEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the memory overcommit feature should be enabled for the VM or not. If enabled, parts of the VM memory may reside outside of the hypervisor physical memory. Once enabled, it should be expected that the VM may suffer performance degradation.
     */
    public readonly isMemoryOvercommitEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the VM SCSI controller is enabled.
     */
    public readonly isScsiControllerEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the vCPUs should be hard pinned to specific pCPUs or not.
     */
    public readonly isVcpuHardPinningEnabled!: pulumi.Output<boolean>;
    /**
     * Indicates whether the VGA console should be disabled or not.
     */
    public readonly isVgaConsoleEnabled!: pulumi.Output<boolean>;
    /**
     * Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks. Valid values are "PSERIES", "Q35", "PC" .
     */
    public readonly machineType!: pulumi.Output<string>;
    /**
     * Memory size in bytes.
     */
    public readonly memorySizeBytes!: pulumi.Output<number>;
    /**
     * VM name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * NICs attached to the VM.
     */
    public readonly nics!: pulumi.Output<outputs.VirtualMachineV2Nic[] | undefined>;
    /**
     * Number of cores per socket. Value should be at least 1.
     */
    public readonly numCoresPerSocket!: pulumi.Output<number>;
    /**
     * Number of NUMA nodes. 0 means NUMA is disabled.
     */
    public readonly numNumaNodes!: pulumi.Output<number>;
    /**
     * Number of vCPU sockets. Value should be at least 1.
     */
    public readonly numSockets!: pulumi.Output<number>;
    /**
     * Number of threads per core. Value should be at least 1.
     */
    public readonly numThreadsPerCore!: pulumi.Output<number>;
    /**
     * Ownership information for the VM.
     */
    public readonly ownershipInfos!: pulumi.Output<outputs.VirtualMachineV2OwnershipInfo[]>;
    public readonly powerState!: pulumi.Output<string | undefined>;
    /**
     * Status of protection policy applied to this VM.
     */
    public readonly protectionPolicyStates!: pulumi.Output<outputs.VirtualMachineV2ProtectionPolicyState[]>;
    /**
     * The type of protection applied on a VM. Valid values "PD_PROTECTED", "UNPROTECTED", "RULE_PROTECTED".
     */
    public readonly protectionType!: pulumi.Output<string>;
    /**
     * Serial ports configured on the VM.
     */
    public readonly serialPorts!: pulumi.Output<outputs.VirtualMachineV2SerialPort[]>;
    /**
     * Reference to an entity that the VM should be cloned or created from. Valid values are "VM", "VM_RECOVERY_POINT".
     */
    public readonly sources!: pulumi.Output<outputs.VirtualMachineV2Source[]>;
    /**
     * Storage configuration for VM.
     */
    public readonly storageConfigs!: pulumi.Output<outputs.VirtualMachineV2StorageConfig[]>;
    /**
     * VM last updated time.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;
    /**
     * Indicates how the vTPM for the VM should be configured.
     */
    public readonly vtpmConfigs!: pulumi.Output<outputs.VirtualMachineV2VtpmConfig[]>;

    /**
     * Create a VirtualMachineV2 resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: VirtualMachineV2Args, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VirtualMachineV2Args | VirtualMachineV2State, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VirtualMachineV2State | undefined;
            resourceInputs["apcConfigs"] = state ? state.apcConfigs : undefined;
            resourceInputs["availabilityZones"] = state ? state.availabilityZones : undefined;
            resourceInputs["biosUuid"] = state ? state.biosUuid : undefined;
            resourceInputs["bootConfigs"] = state ? state.bootConfigs : undefined;
            resourceInputs["categories"] = state ? state.categories : undefined;
            resourceInputs["cdRoms"] = state ? state.cdRoms : undefined;
            resourceInputs["clusters"] = state ? state.clusters : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["disks"] = state ? state.disks : undefined;
            resourceInputs["enabledCpuFeatures"] = state ? state.enabledCpuFeatures : undefined;
            resourceInputs["extId"] = state ? state.extId : undefined;
            resourceInputs["generationUuid"] = state ? state.generationUuid : undefined;
            resourceInputs["gpuses"] = state ? state.gpuses : undefined;
            resourceInputs["guestCustomizations"] = state ? state.guestCustomizations : undefined;
            resourceInputs["guestTools"] = state ? state.guestTools : undefined;
            resourceInputs["hardwareClockTimezone"] = state ? state.hardwareClockTimezone : undefined;
            resourceInputs["hosts"] = state ? state.hosts : undefined;
            resourceInputs["isAgentVm"] = state ? state.isAgentVm : undefined;
            resourceInputs["isBrandingEnabled"] = state ? state.isBrandingEnabled : undefined;
            resourceInputs["isCpuHotplugEnabled"] = state ? state.isCpuHotplugEnabled : undefined;
            resourceInputs["isCpuPassthroughEnabled"] = state ? state.isCpuPassthroughEnabled : undefined;
            resourceInputs["isGpuConsoleEnabled"] = state ? state.isGpuConsoleEnabled : undefined;
            resourceInputs["isMemoryOvercommitEnabled"] = state ? state.isMemoryOvercommitEnabled : undefined;
            resourceInputs["isScsiControllerEnabled"] = state ? state.isScsiControllerEnabled : undefined;
            resourceInputs["isVcpuHardPinningEnabled"] = state ? state.isVcpuHardPinningEnabled : undefined;
            resourceInputs["isVgaConsoleEnabled"] = state ? state.isVgaConsoleEnabled : undefined;
            resourceInputs["machineType"] = state ? state.machineType : undefined;
            resourceInputs["memorySizeBytes"] = state ? state.memorySizeBytes : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nics"] = state ? state.nics : undefined;
            resourceInputs["numCoresPerSocket"] = state ? state.numCoresPerSocket : undefined;
            resourceInputs["numNumaNodes"] = state ? state.numNumaNodes : undefined;
            resourceInputs["numSockets"] = state ? state.numSockets : undefined;
            resourceInputs["numThreadsPerCore"] = state ? state.numThreadsPerCore : undefined;
            resourceInputs["ownershipInfos"] = state ? state.ownershipInfos : undefined;
            resourceInputs["powerState"] = state ? state.powerState : undefined;
            resourceInputs["protectionPolicyStates"] = state ? state.protectionPolicyStates : undefined;
            resourceInputs["protectionType"] = state ? state.protectionType : undefined;
            resourceInputs["serialPorts"] = state ? state.serialPorts : undefined;
            resourceInputs["sources"] = state ? state.sources : undefined;
            resourceInputs["storageConfigs"] = state ? state.storageConfigs : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
            resourceInputs["vtpmConfigs"] = state ? state.vtpmConfigs : undefined;
        } else {
            const args = argsOrState as VirtualMachineV2Args | undefined;
            resourceInputs["apcConfigs"] = args ? args.apcConfigs : undefined;
            resourceInputs["availabilityZones"] = args ? args.availabilityZones : undefined;
            resourceInputs["biosUuid"] = args ? args.biosUuid : undefined;
            resourceInputs["bootConfigs"] = args ? args.bootConfigs : undefined;
            resourceInputs["categories"] = args ? args.categories : undefined;
            resourceInputs["cdRoms"] = args ? args.cdRoms : undefined;
            resourceInputs["clusters"] = args ? args.clusters : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["disks"] = args ? args.disks : undefined;
            resourceInputs["enabledCpuFeatures"] = args ? args.enabledCpuFeatures : undefined;
            resourceInputs["generationUuid"] = args ? args.generationUuid : undefined;
            resourceInputs["gpuses"] = args ? args.gpuses : undefined;
            resourceInputs["guestCustomizations"] = args ? args.guestCustomizations : undefined;
            resourceInputs["guestTools"] = args ? args.guestTools : undefined;
            resourceInputs["hardwareClockTimezone"] = args ? args.hardwareClockTimezone : undefined;
            resourceInputs["hosts"] = args ? args.hosts : undefined;
            resourceInputs["isAgentVm"] = args ? args.isAgentVm : undefined;
            resourceInputs["isBrandingEnabled"] = args ? args.isBrandingEnabled : undefined;
            resourceInputs["isCpuHotplugEnabled"] = args ? args.isCpuHotplugEnabled : undefined;
            resourceInputs["isCpuPassthroughEnabled"] = args ? args.isCpuPassthroughEnabled : undefined;
            resourceInputs["isGpuConsoleEnabled"] = args ? args.isGpuConsoleEnabled : undefined;
            resourceInputs["isMemoryOvercommitEnabled"] = args ? args.isMemoryOvercommitEnabled : undefined;
            resourceInputs["isScsiControllerEnabled"] = args ? args.isScsiControllerEnabled : undefined;
            resourceInputs["isVcpuHardPinningEnabled"] = args ? args.isVcpuHardPinningEnabled : undefined;
            resourceInputs["isVgaConsoleEnabled"] = args ? args.isVgaConsoleEnabled : undefined;
            resourceInputs["machineType"] = args ? args.machineType : undefined;
            resourceInputs["memorySizeBytes"] = args ? args.memorySizeBytes : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["nics"] = args ? args.nics : undefined;
            resourceInputs["numCoresPerSocket"] = args ? args.numCoresPerSocket : undefined;
            resourceInputs["numNumaNodes"] = args ? args.numNumaNodes : undefined;
            resourceInputs["numSockets"] = args ? args.numSockets : undefined;
            resourceInputs["numThreadsPerCore"] = args ? args.numThreadsPerCore : undefined;
            resourceInputs["ownershipInfos"] = args ? args.ownershipInfos : undefined;
            resourceInputs["powerState"] = args ? args.powerState : undefined;
            resourceInputs["protectionPolicyStates"] = args ? args.protectionPolicyStates : undefined;
            resourceInputs["protectionType"] = args ? args.protectionType : undefined;
            resourceInputs["serialPorts"] = args ? args.serialPorts : undefined;
            resourceInputs["sources"] = args ? args.sources : undefined;
            resourceInputs["storageConfigs"] = args ? args.storageConfigs : undefined;
            resourceInputs["vtpmConfigs"] = args ? args.vtpmConfigs : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["extId"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VirtualMachineV2.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VirtualMachineV2 resources.
 */
export interface VirtualMachineV2State {
    /**
     * Advanced Processor Compatibility configuration for the VM. Enabling this retains the CPU model for the VM across power cycles and migrations.
     */
    apcConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2ApcConfig>[]>;
    availabilityZones?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2AvailabilityZone>[]>;
    /**
     * BIOS UUID of the VM. It should be of type UUID.
     */
    biosUuid?: pulumi.Input<string>;
    /**
     * Indicates the order of device types in which the VM should try to boot from. If the boot device order is not provided the system will decide an appropriate boot device order.
     */
    bootConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2BootConfig>[]>;
    /**
     * Categories for the VM.
     */
    categories?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Category>[]>;
    /**
     * CD-ROMs attached to the VM.
     */
    cdRoms?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2CdRom>[]>;
    /**
     * Reference to a cluster.
     */
    clusters?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Cluster>[]>;
    /**
     * VM creation time
     */
    createTime?: pulumi.Input<string>;
    /**
     * VM description
     */
    description?: pulumi.Input<string>;
    /**
     * Disks attached to the VM.
     */
    disks?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Disk>[]>;
    /**
     * The list of additional CPU features to be enabled. HardwareVirtualization: Indicates whether hardware assisted virtualization should be enabled for the Guest OS or not. Once enabled, the Guest OS can deploy a nested hypervisor. Valid values are "HARDWARE_VIRTUALIZATION".
     */
    enabledCpuFeatures?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A globally unique identifier of an instance that is suitable for external consumption.
     */
    extId?: pulumi.Input<string>;
    /**
     * Generation UUID of the VM. It should be of type UUID.
     */
    generationUuid?: pulumi.Input<string>;
    /**
     * GPUs attached to the VM.
     */
    gpuses?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Gpus>[]>;
    /**
     * Stage a Sysprep or cloud-init configuration file to be used by the guest for the next boot. Note that the Sysprep command must be used to generalize the Windows VMs before triggering this API call.
     */
    guestCustomizations?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2GuestCustomization>[]>;
    /**
     * The details about Nutanix Guest Tools for a VM.
     */
    guestTools?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2GuestTool>[]>;
    /**
     * VM hardware clock timezone in IANA TZDB format (America/Los_Angeles).
     */
    hardwareClockTimezone?: pulumi.Input<string>;
    /**
     * Reference to the host, the VM is running on.
     */
    hosts?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Host>[]>;
    /**
     * Indicates whether the VM is an agent VM or not. When their host enters maintenance mode, once the normal VMs are evacuated, the agent VMs are powered off. When the host is restored, agent VMs are powered on before the normal VMs are restored. In other words, agent VMs cannot be HA-protected or live migrated.
     */
    isAgentVm?: pulumi.Input<boolean>;
    /**
     * Indicates whether to remove AHV branding from VM firmware tables or not.
     */
    isBrandingEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VM CPU hotplug is enabled.
     */
    isCpuHotplugEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether to passthrough the host CPU features to the guest or not. Enabling this will make VM incapable of live migration.
     */
    isCpuPassthroughEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the vGPU console is enabled or not.
     */
    isGpuConsoleEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the memory overcommit feature should be enabled for the VM or not. If enabled, parts of the VM memory may reside outside of the hypervisor physical memory. Once enabled, it should be expected that the VM may suffer performance degradation.
     */
    isMemoryOvercommitEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VM SCSI controller is enabled.
     */
    isScsiControllerEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the vCPUs should be hard pinned to specific pCPUs or not.
     */
    isVcpuHardPinningEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VGA console should be disabled or not.
     */
    isVgaConsoleEnabled?: pulumi.Input<boolean>;
    /**
     * Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks. Valid values are "PSERIES", "Q35", "PC" .
     */
    machineType?: pulumi.Input<string>;
    /**
     * Memory size in bytes.
     */
    memorySizeBytes?: pulumi.Input<number>;
    /**
     * VM name.
     */
    name?: pulumi.Input<string>;
    /**
     * NICs attached to the VM.
     */
    nics?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Nic>[]>;
    /**
     * Number of cores per socket. Value should be at least 1.
     */
    numCoresPerSocket?: pulumi.Input<number>;
    /**
     * Number of NUMA nodes. 0 means NUMA is disabled.
     */
    numNumaNodes?: pulumi.Input<number>;
    /**
     * Number of vCPU sockets. Value should be at least 1.
     */
    numSockets?: pulumi.Input<number>;
    /**
     * Number of threads per core. Value should be at least 1.
     */
    numThreadsPerCore?: pulumi.Input<number>;
    /**
     * Ownership information for the VM.
     */
    ownershipInfos?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2OwnershipInfo>[]>;
    powerState?: pulumi.Input<string>;
    /**
     * Status of protection policy applied to this VM.
     */
    protectionPolicyStates?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2ProtectionPolicyState>[]>;
    /**
     * The type of protection applied on a VM. Valid values "PD_PROTECTED", "UNPROTECTED", "RULE_PROTECTED".
     */
    protectionType?: pulumi.Input<string>;
    /**
     * Serial ports configured on the VM.
     */
    serialPorts?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2SerialPort>[]>;
    /**
     * Reference to an entity that the VM should be cloned or created from. Valid values are "VM", "VM_RECOVERY_POINT".
     */
    sources?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Source>[]>;
    /**
     * Storage configuration for VM.
     */
    storageConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2StorageConfig>[]>;
    /**
     * VM last updated time.
     */
    updateTime?: pulumi.Input<string>;
    /**
     * Indicates how the vTPM for the VM should be configured.
     */
    vtpmConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2VtpmConfig>[]>;
}

/**
 * The set of arguments for constructing a VirtualMachineV2 resource.
 */
export interface VirtualMachineV2Args {
    /**
     * Advanced Processor Compatibility configuration for the VM. Enabling this retains the CPU model for the VM across power cycles and migrations.
     */
    apcConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2ApcConfig>[]>;
    availabilityZones?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2AvailabilityZone>[]>;
    /**
     * BIOS UUID of the VM. It should be of type UUID.
     */
    biosUuid?: pulumi.Input<string>;
    /**
     * Indicates the order of device types in which the VM should try to boot from. If the boot device order is not provided the system will decide an appropriate boot device order.
     */
    bootConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2BootConfig>[]>;
    /**
     * Categories for the VM.
     */
    categories?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Category>[]>;
    /**
     * CD-ROMs attached to the VM.
     */
    cdRoms?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2CdRom>[]>;
    /**
     * Reference to a cluster.
     */
    clusters?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Cluster>[]>;
    /**
     * VM description
     */
    description?: pulumi.Input<string>;
    /**
     * Disks attached to the VM.
     */
    disks?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Disk>[]>;
    /**
     * The list of additional CPU features to be enabled. HardwareVirtualization: Indicates whether hardware assisted virtualization should be enabled for the Guest OS or not. Once enabled, the Guest OS can deploy a nested hypervisor. Valid values are "HARDWARE_VIRTUALIZATION".
     */
    enabledCpuFeatures?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Generation UUID of the VM. It should be of type UUID.
     */
    generationUuid?: pulumi.Input<string>;
    /**
     * GPUs attached to the VM.
     */
    gpuses?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Gpus>[]>;
    /**
     * Stage a Sysprep or cloud-init configuration file to be used by the guest for the next boot. Note that the Sysprep command must be used to generalize the Windows VMs before triggering this API call.
     */
    guestCustomizations?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2GuestCustomization>[]>;
    /**
     * The details about Nutanix Guest Tools for a VM.
     */
    guestTools?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2GuestTool>[]>;
    /**
     * VM hardware clock timezone in IANA TZDB format (America/Los_Angeles).
     */
    hardwareClockTimezone?: pulumi.Input<string>;
    /**
     * Reference to the host, the VM is running on.
     */
    hosts?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Host>[]>;
    /**
     * Indicates whether the VM is an agent VM or not. When their host enters maintenance mode, once the normal VMs are evacuated, the agent VMs are powered off. When the host is restored, agent VMs are powered on before the normal VMs are restored. In other words, agent VMs cannot be HA-protected or live migrated.
     */
    isAgentVm?: pulumi.Input<boolean>;
    /**
     * Indicates whether to remove AHV branding from VM firmware tables or not.
     */
    isBrandingEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VM CPU hotplug is enabled.
     */
    isCpuHotplugEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether to passthrough the host CPU features to the guest or not. Enabling this will make VM incapable of live migration.
     */
    isCpuPassthroughEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the vGPU console is enabled or not.
     */
    isGpuConsoleEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the memory overcommit feature should be enabled for the VM or not. If enabled, parts of the VM memory may reside outside of the hypervisor physical memory. Once enabled, it should be expected that the VM may suffer performance degradation.
     */
    isMemoryOvercommitEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VM SCSI controller is enabled.
     */
    isScsiControllerEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the vCPUs should be hard pinned to specific pCPUs or not.
     */
    isVcpuHardPinningEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether the VGA console should be disabled or not.
     */
    isVgaConsoleEnabled?: pulumi.Input<boolean>;
    /**
     * Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks. Valid values are "PSERIES", "Q35", "PC" .
     */
    machineType?: pulumi.Input<string>;
    /**
     * Memory size in bytes.
     */
    memorySizeBytes?: pulumi.Input<number>;
    /**
     * VM name.
     */
    name?: pulumi.Input<string>;
    /**
     * NICs attached to the VM.
     */
    nics?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Nic>[]>;
    /**
     * Number of cores per socket. Value should be at least 1.
     */
    numCoresPerSocket?: pulumi.Input<number>;
    /**
     * Number of NUMA nodes. 0 means NUMA is disabled.
     */
    numNumaNodes?: pulumi.Input<number>;
    /**
     * Number of vCPU sockets. Value should be at least 1.
     */
    numSockets?: pulumi.Input<number>;
    /**
     * Number of threads per core. Value should be at least 1.
     */
    numThreadsPerCore?: pulumi.Input<number>;
    /**
     * Ownership information for the VM.
     */
    ownershipInfos?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2OwnershipInfo>[]>;
    powerState?: pulumi.Input<string>;
    /**
     * Status of protection policy applied to this VM.
     */
    protectionPolicyStates?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2ProtectionPolicyState>[]>;
    /**
     * The type of protection applied on a VM. Valid values "PD_PROTECTED", "UNPROTECTED", "RULE_PROTECTED".
     */
    protectionType?: pulumi.Input<string>;
    /**
     * Serial ports configured on the VM.
     */
    serialPorts?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2SerialPort>[]>;
    /**
     * Reference to an entity that the VM should be cloned or created from. Valid values are "VM", "VM_RECOVERY_POINT".
     */
    sources?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2Source>[]>;
    /**
     * Storage configuration for VM.
     */
    storageConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2StorageConfig>[]>;
    /**
     * Indicates how the vTPM for the VM should be configured.
     */
    vtpmConfigs?: pulumi.Input<pulumi.Input<inputs.VirtualMachineV2VtpmConfig>[]>;
}
