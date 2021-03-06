// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetVirtualMachine
    {
        /// <summary>
        /// Describes a Virtual Machine
        /// </summary>
        public static Task<GetVirtualMachineResult> InvokeAsync(GetVirtualMachineArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineResult>("nutanix:index/getVirtualMachine:getVirtualMachine", args ?? new GetVirtualMachineArgs(), options.WithDefaults());

        /// <summary>
        /// Describes a Virtual Machine
        /// </summary>
        public static Output<GetVirtualMachineResult> Invoke(GetVirtualMachineInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualMachineResult>("nutanix:index/getVirtualMachine:getVirtualMachine", args ?? new GetVirtualMachineInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualMachineArgs : Pulumi.InvokeArgs
    {
        [Input("bootDeviceDiskAddress")]
        private Dictionary<string, string>? _bootDeviceDiskAddress;
        public Dictionary<string, string> BootDeviceDiskAddress
        {
            get => _bootDeviceDiskAddress ?? (_bootDeviceDiskAddress = new Dictionary<string, string>());
            set => _bootDeviceDiskAddress = value;
        }

        [Input("bootDeviceMacAddress")]
        public string? BootDeviceMacAddress { get; set; }

        [Input("categories")]
        private List<Inputs.GetVirtualMachineCategoryArgs>? _categories;
        public List<Inputs.GetVirtualMachineCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new List<Inputs.GetVirtualMachineCategoryArgs>());
            set => _categories = value;
        }

        [Input("vmId", required: true)]
        public string VmId { get; set; } = null!;

        public GetVirtualMachineArgs()
        {
        }
    }

    public sealed class GetVirtualMachineInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("bootDeviceDiskAddress")]
        private InputMap<string>? _bootDeviceDiskAddress;
        public InputMap<string> BootDeviceDiskAddress
        {
            get => _bootDeviceDiskAddress ?? (_bootDeviceDiskAddress = new InputMap<string>());
            set => _bootDeviceDiskAddress = value;
        }

        [Input("bootDeviceMacAddress")]
        public Input<string>? BootDeviceMacAddress { get; set; }

        [Input("categories")]
        private InputList<Inputs.GetVirtualMachineCategoryInputArgs>? _categories;
        public InputList<Inputs.GetVirtualMachineCategoryInputArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.GetVirtualMachineCategoryInputArgs>());
            set => _categories = value;
        }

        [Input("vmId", required: true)]
        public Input<string> VmId { get; set; } = null!;

        public GetVirtualMachineInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineResult
    {
        /// <summary>
        /// The version of the API.
        /// * `description`: - A description for vm.
        /// * `num_vnuma_nodes`: - Number of vNUMA nodes. 0 means vNUMA is disabled.
        /// * `nic_list`: - NICs attached to the VM.
        /// * `serial_port_list`: - (Optional) Serial Ports configured on the VM.
        /// * `guest_os_id`: - Guest OS Identifier. For ESX, refer to VMware documentation [link](https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.
        /// * `power_state`: - The current or desired power state of the VM. (Options : ON , OFF)
        /// * `nutanix_guest_tools`: - Information regarding Nutanix Guest Tools.
        /// * `ngt_credentials`: - Credentials to login server.
        /// </summary>
        public readonly string ApiVersion;
        public readonly ImmutableDictionary<string, string> AvailabilityZoneReference;
        public readonly ImmutableDictionary<string, string> BootDeviceDiskAddress;
        public readonly string BootDeviceMacAddress;
        public readonly ImmutableArray<string> BootDeviceOrderLists;
        public readonly string BootType;
        public readonly ImmutableArray<Outputs.GetVirtualMachineCategoryResult> Categories;
        public readonly string ClusterName;
        public readonly string ClusterUuid;
        public readonly string Description;
        public readonly ImmutableArray<Outputs.GetVirtualMachineDiskListResult> DiskLists;
        public readonly bool EnableCpuPassthrough;
        public readonly bool EnableScriptExec;
        public readonly ImmutableArray<Outputs.GetVirtualMachineGpuListResult> GpuLists;
        public readonly ImmutableDictionary<string, object> GuestCustomizationCloudInitCustomKeyValues;
        /// <summary>
        /// The contents of the meta_data configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64 encoded.
        /// * `guest_customization_is_overridable`: - Flag to allow override of customization by deployer.
        /// * `guest_customization_cloud_init_custom_key_values`: - Generic key value pair used for custom attributes in cloud init.
        /// * `guest_customization_sysprep`: - VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note that guest customization can currently only be set during VM creation. Attempting to change it after creation will result in an error. Additional properties can be specified. For example - in the context of VM template creation if \"override_script\" is set to \"True\" then the deployer can upload their own custom script.
        /// * `guest_customization_sysrep_custom_key_values`: - Generic key value pair used for custom attributes in sysrep.
        /// * `should_fail_on_script_failure`: -  Extra configs related to power state transition. Indicates whether to abort ngt shutdown/reboot if script fails.
        /// * `enable_script_exec`: - Extra configs related to power state transition. Indicates whether to execute set script before ngt shutdown/reboot.
        /// * `power_state_mechanism`: - Indicates the mechanism guiding the VM power state transition. Currently used for the transition to \"OFF\" state. Power state mechanism (ACPI/GUEST/HARD).
        /// * `vga_console_enabled`: - Indicates whether VGA console should be enabled or not.
        /// * `disk_list` Disks attached to the VM.
        /// * `metadata`: - The vm kind metadata.
        /// * `state`: - The state of the vm.
        /// * `ip_address`: - An IP address.
        /// * `host_reference`: - Reference to a host.
        /// * `hypervisor_type`: - The hypervisor type for the hypervisor the VM is hosted on.
        /// </summary>
        public readonly string GuestCustomizationCloudInitMetaData;
        public readonly string GuestCustomizationCloudInitUserData;
        public readonly bool GuestCustomizationIsOverridable;
        public readonly ImmutableDictionary<string, string> GuestCustomizationSysprep;
        public readonly ImmutableDictionary<string, object> GuestCustomizationSysprepCustomKeyValues;
        public readonly string GuestOsId;
        public readonly string HardwareClockTimezone;
        public readonly ImmutableDictionary<string, string> HostReference;
        public readonly string HypervisorType;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool IsVcpuHardPinned;
        public readonly string MachineType;
        public readonly int MemorySizeMib;
        public readonly ImmutableArray<Outputs.GetVirtualMachineMessageListResult> MessageLists;
        public readonly ImmutableDictionary<string, string> Metadata;
        public readonly string Name;
        public readonly ImmutableDictionary<string, object> NgtCredentials;
        /// <summary>
        /// Application names that are enabled.
        /// * `num_vcpus_per_socket`: - Number of vCPUs per socket.
        /// * `num_sockets`: - Number of vCPU sockets.
        /// * `gpu_list`: - GPUs attached to the VM.
        /// * `parent_referece`: - Reference to an entity that the VM cloned from.
        /// * `memory_size_mib`: - Memory size in MiB.
        /// * `boot_device_order_list`: - Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.
        /// * `boot_device_disk_address`: - Address of disk to boot from.
        /// * `boot_device_mac_address`: - MAC address of nic to boot from.
        /// * `boot_type`: - Indicates whether the VM should use Secure boot, UEFI boot or Legacy boot.If UEFI or; Secure boot is enabled then other legacy boot options (like boot_device and; boot_device_order_list) are ignored. Secure boot depends on UEFI boot, i.e. enabling; Secure boot means that UEFI boot is also enabled. The possible value are: UEFI", "LEGACY", "SECURE_BOOT".
        /// * `machine_type`: - Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks.
        /// * `hardware_clock_timezone`: - VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).
        /// * `guest_customization_cloud_init_user_data`: - The contents of the user_data configuration for cloud-init. This can be formatted as YAML, JSON, or could be a shell script. The value must be base64 encoded.
        /// </summary>
        public readonly ImmutableArray<string> NgtEnabledCapabilityLists;
        public readonly ImmutableArray<Outputs.GetVirtualMachineNicListResult> NicLists;
        public readonly int NumSockets;
        public readonly int NumVcpusPerSocket;
        public readonly int NumVnumaNodes;
        public readonly ImmutableDictionary<string, string> NutanixGuestTools;
        public readonly ImmutableDictionary<string, string> OwnerReference;
        public readonly ImmutableDictionary<string, string> ParentReference;
        public readonly string PowerState;
        public readonly string PowerStateMechanism;
        public readonly ImmutableDictionary<string, string> ProjectReference;
        public readonly ImmutableArray<Outputs.GetVirtualMachineSerialPortListResult> SerialPortLists;
        public readonly bool ShouldFailOnScriptFailure;
        public readonly string State;
        public readonly bool VgaConsoleEnabled;
        public readonly string VmId;

        [OutputConstructor]
        private GetVirtualMachineResult(
            string apiVersion,

            ImmutableDictionary<string, string> availabilityZoneReference,

            ImmutableDictionary<string, string> bootDeviceDiskAddress,

            string bootDeviceMacAddress,

            ImmutableArray<string> bootDeviceOrderLists,

            string bootType,

            ImmutableArray<Outputs.GetVirtualMachineCategoryResult> categories,

            string clusterName,

            string clusterUuid,

            string description,

            ImmutableArray<Outputs.GetVirtualMachineDiskListResult> diskLists,

            bool enableCpuPassthrough,

            bool enableScriptExec,

            ImmutableArray<Outputs.GetVirtualMachineGpuListResult> gpuLists,

            ImmutableDictionary<string, object> guestCustomizationCloudInitCustomKeyValues,

            string guestCustomizationCloudInitMetaData,

            string guestCustomizationCloudInitUserData,

            bool guestCustomizationIsOverridable,

            ImmutableDictionary<string, string> guestCustomizationSysprep,

            ImmutableDictionary<string, object> guestCustomizationSysprepCustomKeyValues,

            string guestOsId,

            string hardwareClockTimezone,

            ImmutableDictionary<string, string> hostReference,

            string hypervisorType,

            string id,

            bool isVcpuHardPinned,

            string machineType,

            int memorySizeMib,

            ImmutableArray<Outputs.GetVirtualMachineMessageListResult> messageLists,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableDictionary<string, object> ngtCredentials,

            ImmutableArray<string> ngtEnabledCapabilityLists,

            ImmutableArray<Outputs.GetVirtualMachineNicListResult> nicLists,

            int numSockets,

            int numVcpusPerSocket,

            int numVnumaNodes,

            ImmutableDictionary<string, string> nutanixGuestTools,

            ImmutableDictionary<string, string> ownerReference,

            ImmutableDictionary<string, string> parentReference,

            string powerState,

            string powerStateMechanism,

            ImmutableDictionary<string, string> projectReference,

            ImmutableArray<Outputs.GetVirtualMachineSerialPortListResult> serialPortLists,

            bool shouldFailOnScriptFailure,

            string state,

            bool vgaConsoleEnabled,

            string vmId)
        {
            ApiVersion = apiVersion;
            AvailabilityZoneReference = availabilityZoneReference;
            BootDeviceDiskAddress = bootDeviceDiskAddress;
            BootDeviceMacAddress = bootDeviceMacAddress;
            BootDeviceOrderLists = bootDeviceOrderLists;
            BootType = bootType;
            Categories = categories;
            ClusterName = clusterName;
            ClusterUuid = clusterUuid;
            Description = description;
            DiskLists = diskLists;
            EnableCpuPassthrough = enableCpuPassthrough;
            EnableScriptExec = enableScriptExec;
            GpuLists = gpuLists;
            GuestCustomizationCloudInitCustomKeyValues = guestCustomizationCloudInitCustomKeyValues;
            GuestCustomizationCloudInitMetaData = guestCustomizationCloudInitMetaData;
            GuestCustomizationCloudInitUserData = guestCustomizationCloudInitUserData;
            GuestCustomizationIsOverridable = guestCustomizationIsOverridable;
            GuestCustomizationSysprep = guestCustomizationSysprep;
            GuestCustomizationSysprepCustomKeyValues = guestCustomizationSysprepCustomKeyValues;
            GuestOsId = guestOsId;
            HardwareClockTimezone = hardwareClockTimezone;
            HostReference = hostReference;
            HypervisorType = hypervisorType;
            Id = id;
            IsVcpuHardPinned = isVcpuHardPinned;
            MachineType = machineType;
            MemorySizeMib = memorySizeMib;
            MessageLists = messageLists;
            Metadata = metadata;
            Name = name;
            NgtCredentials = ngtCredentials;
            NgtEnabledCapabilityLists = ngtEnabledCapabilityLists;
            NicLists = nicLists;
            NumSockets = numSockets;
            NumVcpusPerSocket = numVcpusPerSocket;
            NumVnumaNodes = numVnumaNodes;
            NutanixGuestTools = nutanixGuestTools;
            OwnerReference = ownerReference;
            ParentReference = parentReference;
            PowerState = powerState;
            PowerStateMechanism = powerStateMechanism;
            ProjectReference = projectReference;
            SerialPortLists = serialPortLists;
            ShouldFailOnScriptFailure = shouldFailOnScriptFailure;
            State = state;
            VgaConsoleEnabled = vgaConsoleEnabled;
            VmId = vmId;
        }
    }
}
