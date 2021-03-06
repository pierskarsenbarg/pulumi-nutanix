// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a Virtual Machine
func LookupVirtualMachine(ctx *pulumi.Context, args *LookupVirtualMachineArgs, opts ...pulumi.InvokeOption) (*LookupVirtualMachineResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupVirtualMachineResult
	err := ctx.Invoke("nutanix:index/getVirtualMachine:getVirtualMachine", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVirtualMachine.
type LookupVirtualMachineArgs struct {
	BootDeviceDiskAddress map[string]string           `pulumi:"bootDeviceDiskAddress"`
	BootDeviceMacAddress  *string                     `pulumi:"bootDeviceMacAddress"`
	Categories            []GetVirtualMachineCategory `pulumi:"categories"`
	VmId                  string                      `pulumi:"vmId"`
}

// A collection of values returned by getVirtualMachine.
type LookupVirtualMachineResult struct {
	// The version of the API.
	// * `description`: - A description for vm.
	// * `numVnumaNodes`: - Number of vNUMA nodes. 0 means vNUMA is disabled.
	// * `nicList`: - NICs attached to the VM.
	// * `serialPortList`: - (Optional) Serial Ports configured on the VM.
	// * `guestOsId`: - Guest OS Identifier. For ESX, refer to VMware documentation [link](https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.
	// * `powerState`: - The current or desired power state of the VM. (Options : ON , OFF)
	// * `nutanixGuestTools`: - Information regarding Nutanix Guest Tools.
	// * `ngtCredentials`: - Credentials to login server.
	ApiVersion                                 string                      `pulumi:"apiVersion"`
	AvailabilityZoneReference                  map[string]string           `pulumi:"availabilityZoneReference"`
	BootDeviceDiskAddress                      map[string]string           `pulumi:"bootDeviceDiskAddress"`
	BootDeviceMacAddress                       string                      `pulumi:"bootDeviceMacAddress"`
	BootDeviceOrderLists                       []string                    `pulumi:"bootDeviceOrderLists"`
	BootType                                   string                      `pulumi:"bootType"`
	Categories                                 []GetVirtualMachineCategory `pulumi:"categories"`
	ClusterName                                string                      `pulumi:"clusterName"`
	ClusterUuid                                string                      `pulumi:"clusterUuid"`
	Description                                string                      `pulumi:"description"`
	DiskLists                                  []GetVirtualMachineDiskList `pulumi:"diskLists"`
	EnableCpuPassthrough                       bool                        `pulumi:"enableCpuPassthrough"`
	EnableScriptExec                           bool                        `pulumi:"enableScriptExec"`
	GpuLists                                   []GetVirtualMachineGpuList  `pulumi:"gpuLists"`
	GuestCustomizationCloudInitCustomKeyValues map[string]interface{}      `pulumi:"guestCustomizationCloudInitCustomKeyValues"`
	// The contents of the metaData configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64 encoded.
	// * `guestCustomizationIsOverridable`: - Flag to allow override of customization by deployer.
	// * `guestCustomizationCloudInitCustomKeyValues`: - Generic key value pair used for custom attributes in cloud init.
	// * `guestCustomizationSysprep`: - VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloudInit should be provided. Note that guest customization can currently only be set during VM creation. Attempting to change it after creation will result in an error. Additional properties can be specified. For example - in the context of VM template creation if \"override_script\" is set to \"True\" then the deployer can upload their own custom script.
	// * `guestCustomizationSysrepCustomKeyValues`: - Generic key value pair used for custom attributes in sysrep.
	// * `shouldFailOnScriptFailure`: -  Extra configs related to power state transition. Indicates whether to abort ngt shutdown/reboot if script fails.
	// * `enableScriptExec`: - Extra configs related to power state transition. Indicates whether to execute set script before ngt shutdown/reboot.
	// * `powerStateMechanism`: - Indicates the mechanism guiding the VM power state transition. Currently used for the transition to \"OFF\" state. Power state mechanism (ACPI/GUEST/HARD).
	// * `vgaConsoleEnabled`: - Indicates whether VGA console should be enabled or not.
	// * `diskList` Disks attached to the VM.
	// * `metadata`: - The vm kind metadata.
	// * `state`: - The state of the vm.
	// * `ipAddress`: - An IP address.
	// * `hostReference`: - Reference to a host.
	// * `hypervisorType`: - The hypervisor type for the hypervisor the VM is hosted on.
	GuestCustomizationCloudInitMetaData      string                 `pulumi:"guestCustomizationCloudInitMetaData"`
	GuestCustomizationCloudInitUserData      string                 `pulumi:"guestCustomizationCloudInitUserData"`
	GuestCustomizationIsOverridable          bool                   `pulumi:"guestCustomizationIsOverridable"`
	GuestCustomizationSysprep                map[string]string      `pulumi:"guestCustomizationSysprep"`
	GuestCustomizationSysprepCustomKeyValues map[string]interface{} `pulumi:"guestCustomizationSysprepCustomKeyValues"`
	GuestOsId                                string                 `pulumi:"guestOsId"`
	HardwareClockTimezone                    string                 `pulumi:"hardwareClockTimezone"`
	HostReference                            map[string]string      `pulumi:"hostReference"`
	HypervisorType                           string                 `pulumi:"hypervisorType"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                         `pulumi:"id"`
	IsVcpuHardPinned bool                           `pulumi:"isVcpuHardPinned"`
	MachineType      string                         `pulumi:"machineType"`
	MemorySizeMib    int                            `pulumi:"memorySizeMib"`
	MessageLists     []GetVirtualMachineMessageList `pulumi:"messageLists"`
	Metadata         map[string]string              `pulumi:"metadata"`
	Name             string                         `pulumi:"name"`
	NgtCredentials   map[string]interface{}         `pulumi:"ngtCredentials"`
	// Application names that are enabled.
	// * `numVcpusPerSocket`: - Number of vCPUs per socket.
	// * `numSockets`: - Number of vCPU sockets.
	// * `gpuList`: - GPUs attached to the VM.
	// * `parentReferece`: - Reference to an entity that the VM cloned from.
	// * `memorySizeMib`: - Memory size in MiB.
	// * `bootDeviceOrderList`: - Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.
	// * `bootDeviceDiskAddress`: - Address of disk to boot from.
	// * `bootDeviceMacAddress`: - MAC address of nic to boot from.
	// * `bootType`: - Indicates whether the VM should use Secure boot, UEFI boot or Legacy boot.If UEFI or; Secure boot is enabled then other legacy boot options (like bootDevice and; boot_device_order_list) are ignored. Secure boot depends on UEFI boot, i.e. enabling; Secure boot means that UEFI boot is also enabled. The possible value are: UEFI", "LEGACY", "SECURE_BOOT".
	// * `machineType`: - Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks.
	// * `hardwareClockTimezone`: - VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).
	// * `guestCustomizationCloudInitUserData`: - The contents of the userData configuration for cloud-init. This can be formatted as YAML, JSON, or could be a shell script. The value must be base64 encoded.
	NgtEnabledCapabilityLists []string                          `pulumi:"ngtEnabledCapabilityLists"`
	NicLists                  []GetVirtualMachineNicList        `pulumi:"nicLists"`
	NumSockets                int                               `pulumi:"numSockets"`
	NumVcpusPerSocket         int                               `pulumi:"numVcpusPerSocket"`
	NumVnumaNodes             int                               `pulumi:"numVnumaNodes"`
	NutanixGuestTools         map[string]string                 `pulumi:"nutanixGuestTools"`
	OwnerReference            map[string]string                 `pulumi:"ownerReference"`
	ParentReference           map[string]string                 `pulumi:"parentReference"`
	PowerState                string                            `pulumi:"powerState"`
	PowerStateMechanism       string                            `pulumi:"powerStateMechanism"`
	ProjectReference          map[string]string                 `pulumi:"projectReference"`
	SerialPortLists           []GetVirtualMachineSerialPortList `pulumi:"serialPortLists"`
	ShouldFailOnScriptFailure bool                              `pulumi:"shouldFailOnScriptFailure"`
	State                     string                            `pulumi:"state"`
	VgaConsoleEnabled         bool                              `pulumi:"vgaConsoleEnabled"`
	VmId                      string                            `pulumi:"vmId"`
}

func LookupVirtualMachineOutput(ctx *pulumi.Context, args LookupVirtualMachineOutputArgs, opts ...pulumi.InvokeOption) LookupVirtualMachineResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupVirtualMachineResult, error) {
			args := v.(LookupVirtualMachineArgs)
			r, err := LookupVirtualMachine(ctx, &args, opts...)
			var s LookupVirtualMachineResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupVirtualMachineResultOutput)
}

// A collection of arguments for invoking getVirtualMachine.
type LookupVirtualMachineOutputArgs struct {
	BootDeviceDiskAddress pulumi.StringMapInput               `pulumi:"bootDeviceDiskAddress"`
	BootDeviceMacAddress  pulumi.StringPtrInput               `pulumi:"bootDeviceMacAddress"`
	Categories            GetVirtualMachineCategoryArrayInput `pulumi:"categories"`
	VmId                  pulumi.StringInput                  `pulumi:"vmId"`
}

func (LookupVirtualMachineOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVirtualMachineArgs)(nil)).Elem()
}

// A collection of values returned by getVirtualMachine.
type LookupVirtualMachineResultOutput struct{ *pulumi.OutputState }

func (LookupVirtualMachineResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVirtualMachineResult)(nil)).Elem()
}

func (o LookupVirtualMachineResultOutput) ToLookupVirtualMachineResultOutput() LookupVirtualMachineResultOutput {
	return o
}

func (o LookupVirtualMachineResultOutput) ToLookupVirtualMachineResultOutputWithContext(ctx context.Context) LookupVirtualMachineResultOutput {
	return o
}

// The version of the API.
// * `description`: - A description for vm.
// * `numVnumaNodes`: - Number of vNUMA nodes. 0 means vNUMA is disabled.
// * `nicList`: - NICs attached to the VM.
// * `serialPortList`: - (Optional) Serial Ports configured on the VM.
// * `guestOsId`: - Guest OS Identifier. For ESX, refer to VMware documentation [link](https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.
// * `powerState`: - The current or desired power state of the VM. (Options : ON , OFF)
// * `nutanixGuestTools`: - Information regarding Nutanix Guest Tools.
// * `ngtCredentials`: - Credentials to login server.
func (o LookupVirtualMachineResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) AvailabilityZoneReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.AvailabilityZoneReference }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) BootDeviceDiskAddress() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.BootDeviceDiskAddress }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) BootDeviceMacAddress() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.BootDeviceMacAddress }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) BootDeviceOrderLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []string { return v.BootDeviceOrderLists }).(pulumi.StringArrayOutput)
}

func (o LookupVirtualMachineResultOutput) BootType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.BootType }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) Categories() GetVirtualMachineCategoryArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineCategory { return v.Categories }).(GetVirtualMachineCategoryArrayOutput)
}

func (o LookupVirtualMachineResultOutput) ClusterName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.ClusterName }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) ClusterUuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.ClusterUuid }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) DiskLists() GetVirtualMachineDiskListArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineDiskList { return v.DiskLists }).(GetVirtualMachineDiskListArrayOutput)
}

func (o LookupVirtualMachineResultOutput) EnableCpuPassthrough() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.EnableCpuPassthrough }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) EnableScriptExec() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.EnableScriptExec }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) GpuLists() GetVirtualMachineGpuListArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineGpuList { return v.GpuLists }).(GetVirtualMachineGpuListArrayOutput)
}

func (o LookupVirtualMachineResultOutput) GuestCustomizationCloudInitCustomKeyValues() pulumi.MapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]interface{} {
		return v.GuestCustomizationCloudInitCustomKeyValues
	}).(pulumi.MapOutput)
}

// The contents of the metaData configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64 encoded.
// * `guestCustomizationIsOverridable`: - Flag to allow override of customization by deployer.
// * `guestCustomizationCloudInitCustomKeyValues`: - Generic key value pair used for custom attributes in cloud init.
// * `guestCustomizationSysprep`: - VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloudInit should be provided. Note that guest customization can currently only be set during VM creation. Attempting to change it after creation will result in an error. Additional properties can be specified. For example - in the context of VM template creation if \"override_script\" is set to \"True\" then the deployer can upload their own custom script.
// * `guestCustomizationSysrepCustomKeyValues`: - Generic key value pair used for custom attributes in sysrep.
// * `shouldFailOnScriptFailure`: -  Extra configs related to power state transition. Indicates whether to abort ngt shutdown/reboot if script fails.
// * `enableScriptExec`: - Extra configs related to power state transition. Indicates whether to execute set script before ngt shutdown/reboot.
// * `powerStateMechanism`: - Indicates the mechanism guiding the VM power state transition. Currently used for the transition to \"OFF\" state. Power state mechanism (ACPI/GUEST/HARD).
// * `vgaConsoleEnabled`: - Indicates whether VGA console should be enabled or not.
// * `diskList` Disks attached to the VM.
// * `metadata`: - The vm kind metadata.
// * `state`: - The state of the vm.
// * `ipAddress`: - An IP address.
// * `hostReference`: - Reference to a host.
// * `hypervisorType`: - The hypervisor type for the hypervisor the VM is hosted on.
func (o LookupVirtualMachineResultOutput) GuestCustomizationCloudInitMetaData() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.GuestCustomizationCloudInitMetaData }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) GuestCustomizationCloudInitUserData() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.GuestCustomizationCloudInitUserData }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) GuestCustomizationIsOverridable() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.GuestCustomizationIsOverridable }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) GuestCustomizationSysprep() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.GuestCustomizationSysprep }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) GuestCustomizationSysprepCustomKeyValues() pulumi.MapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]interface{} {
		return v.GuestCustomizationSysprepCustomKeyValues
	}).(pulumi.MapOutput)
}

func (o LookupVirtualMachineResultOutput) GuestOsId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.GuestOsId }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) HardwareClockTimezone() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.HardwareClockTimezone }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) HostReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.HostReference }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) HypervisorType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.HypervisorType }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVirtualMachineResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) IsVcpuHardPinned() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.IsVcpuHardPinned }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) MachineType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.MachineType }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) MemorySizeMib() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) int { return v.MemorySizeMib }).(pulumi.IntOutput)
}

func (o LookupVirtualMachineResultOutput) MessageLists() GetVirtualMachineMessageListArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineMessageList { return v.MessageLists }).(GetVirtualMachineMessageListArrayOutput)
}

func (o LookupVirtualMachineResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) NgtCredentials() pulumi.MapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]interface{} { return v.NgtCredentials }).(pulumi.MapOutput)
}

// Application names that are enabled.
// * `numVcpusPerSocket`: - Number of vCPUs per socket.
// * `numSockets`: - Number of vCPU sockets.
// * `gpuList`: - GPUs attached to the VM.
// * `parentReferece`: - Reference to an entity that the VM cloned from.
// * `memorySizeMib`: - Memory size in MiB.
// * `bootDeviceOrderList`: - Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.
// * `bootDeviceDiskAddress`: - Address of disk to boot from.
// * `bootDeviceMacAddress`: - MAC address of nic to boot from.
// * `bootType`: - Indicates whether the VM should use Secure boot, UEFI boot or Legacy boot.If UEFI or; Secure boot is enabled then other legacy boot options (like bootDevice and; boot_device_order_list) are ignored. Secure boot depends on UEFI boot, i.e. enabling; Secure boot means that UEFI boot is also enabled. The possible value are: UEFI", "LEGACY", "SECURE_BOOT".
// * `machineType`: - Machine type for the VM. Machine type Q35 is required for secure boot and does not support IDE disks.
// * `hardwareClockTimezone`: - VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).
// * `guestCustomizationCloudInitUserData`: - The contents of the userData configuration for cloud-init. This can be formatted as YAML, JSON, or could be a shell script. The value must be base64 encoded.
func (o LookupVirtualMachineResultOutput) NgtEnabledCapabilityLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []string { return v.NgtEnabledCapabilityLists }).(pulumi.StringArrayOutput)
}

func (o LookupVirtualMachineResultOutput) NicLists() GetVirtualMachineNicListArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineNicList { return v.NicLists }).(GetVirtualMachineNicListArrayOutput)
}

func (o LookupVirtualMachineResultOutput) NumSockets() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) int { return v.NumSockets }).(pulumi.IntOutput)
}

func (o LookupVirtualMachineResultOutput) NumVcpusPerSocket() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) int { return v.NumVcpusPerSocket }).(pulumi.IntOutput)
}

func (o LookupVirtualMachineResultOutput) NumVnumaNodes() pulumi.IntOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) int { return v.NumVnumaNodes }).(pulumi.IntOutput)
}

func (o LookupVirtualMachineResultOutput) NutanixGuestTools() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.NutanixGuestTools }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.OwnerReference }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) ParentReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.ParentReference }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) PowerState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.PowerState }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) PowerStateMechanism() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.PowerStateMechanism }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) map[string]string { return v.ProjectReference }).(pulumi.StringMapOutput)
}

func (o LookupVirtualMachineResultOutput) SerialPortLists() GetVirtualMachineSerialPortListArrayOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) []GetVirtualMachineSerialPortList { return v.SerialPortLists }).(GetVirtualMachineSerialPortListArrayOutput)
}

func (o LookupVirtualMachineResultOutput) ShouldFailOnScriptFailure() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.ShouldFailOnScriptFailure }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.State }).(pulumi.StringOutput)
}

func (o LookupVirtualMachineResultOutput) VgaConsoleEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) bool { return v.VgaConsoleEnabled }).(pulumi.BoolOutput)
}

func (o LookupVirtualMachineResultOutput) VmId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVirtualMachineResult) string { return v.VmId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVirtualMachineResultOutput{})
}
