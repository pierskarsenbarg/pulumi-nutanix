// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describe a Nutanix Recovery Plan and its values (if it has them).
func LookupRecoveryPlan(ctx *pulumi.Context, args *LookupRecoveryPlanArgs, opts ...pulumi.InvokeOption) (*LookupRecoveryPlanResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRecoveryPlanResult
	err := ctx.Invoke("nutanix:index/getRecoveryPlan:getRecoveryPlan", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRecoveryPlan.
type LookupRecoveryPlanArgs struct {
	Categories []GetRecoveryPlanCategory `pulumi:"categories"`
	// - (Required) The `id` of the Recovery Plan.
	RecoveryPlanId   *string `pulumi:"recoveryPlanId"`
	RecoveryPlanName *string `pulumi:"recoveryPlanName"`
}

// A collection of values returned by getRecoveryPlan.
type LookupRecoveryPlanResult struct {
	ApiVersion string                    `pulumi:"apiVersion"`
	Categories []GetRecoveryPlanCategory `pulumi:"categories"`
	// A description for Recovery Plan.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id       string            `pulumi:"id"`
	Metadata map[string]string `pulumi:"metadata"`
	// (Optional) the name.
	Name            string                          `pulumi:"name"`
	OwnerReferences []GetRecoveryPlanOwnerReference `pulumi:"ownerReferences"`
	// (Required) Parameters for the Recovery Plan.
	// * `parameters.0.floating_ip_assignment_list` - (Optional/Computed) Floating IP assignment for VMs upon recovery in an Availability Zone. This is applicable only for the public cloud Availability Zones.
	// * `parameters.0.floating_ip_assignment_list.#.availability_zone_url` - (Required) URL of the Availability Zone.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list` - (Required) IP assignment for VMs upon recovery in the specified Availability Zone.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference` - (Required) Reference to a vm.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.kind` - (Required) The kind name.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.uuid` - (Required) The uuid.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information` - (Required) Information about vnic to which floating IP has to be assigned.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.ip` - (Optional/Computed) IP address associated with vnic for which floating IP has to be assigned on failover.
	// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.uuid` - (Required) Uuid of the vnic of the VM to which floating IP has to be assigned.
	// * `parameters.0.network_mapping_list` - (Required) Network mappings to be used for the Recovery Plan. This will be represented by array of network mappings across the Availability Zones.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list` - (Required) Mapping of networks across the Availability Zones.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.availability_zone_url` - (Optional/Computed) URL of the Availability Zone.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.use_vpc_reference` - (Optional/Computed) The reference to a VPC.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference` - (Optional/Computed) The reference to a VPC.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.name` - (Required) Name of the network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.name` - (Required) Name of the network.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the recovery network for migrate/ failover action on the Recovery Plan.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the test network for test failover action on the Recovery Plan.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list` - (Optional/Computed) The clusters where the recovery and test networks reside. This is required to specify network mapping across clusters for a Recovery Plan created to handle failover within the same Availability Zone.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.kind` - (Optional/Computed) The kind name.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.uuid` - (Optional/Computed) The uuid.
	// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.name` - (Optional/Computed) The name.
	Parameters        []GetRecoveryPlanParameter        `pulumi:"parameters"`
	ProjectReferences []GetRecoveryPlanProjectReference `pulumi:"projectReferences"`
	RecoveryPlanId    *string                           `pulumi:"recoveryPlanId"`
	RecoveryPlanName  *string                           `pulumi:"recoveryPlanName"`
	// (Required) Input for the stages of the Recovery Plan. Each stage will perform a predefined type of task.
	// * `stage_list.stage_uuid` - (Optional/Computed) UUID of stage.
	// * `stage_list.delay_time_secs` - (Optional/Computed) Amount of time in seconds to delay the execution of next stage after execution of current stage.
	// * `stage_list.stage_work` - (Required) A stage specifies the work to be performed when the Recovery Plan is executed.
	// * `stage_list.stage_work.0.recover_entities` - (Optional/Computed) Information about entities to be recovered.
	// * `stage_list.stage_work.0.recover_entities.0.entity_info_list` - (Optional/Computed) Information about entities to be recovered as part of this stage. For VM, entity information will include set of scripts to be executed after recovery of VM. Only one of categories or anyEntityReference has to be provided.
	// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_kind` - (Optional/Computed) Reference to a kind.
	// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_uuid` - (Optional/Computed) Reference to a uuid.
	// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_name` - (Optional/Computed) Reference to a name.
	// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.categories` - (Optional/Computed)  Categories for filtering entities.
	StageLists []GetRecoveryPlanStageList `pulumi:"stageLists"`
	State      string                     `pulumi:"state"`
}

func LookupRecoveryPlanOutput(ctx *pulumi.Context, args LookupRecoveryPlanOutputArgs, opts ...pulumi.InvokeOption) LookupRecoveryPlanResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRecoveryPlanResult, error) {
			args := v.(LookupRecoveryPlanArgs)
			r, err := LookupRecoveryPlan(ctx, &args, opts...)
			var s LookupRecoveryPlanResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRecoveryPlanResultOutput)
}

// A collection of arguments for invoking getRecoveryPlan.
type LookupRecoveryPlanOutputArgs struct {
	Categories GetRecoveryPlanCategoryArrayInput `pulumi:"categories"`
	// - (Required) The `id` of the Recovery Plan.
	RecoveryPlanId   pulumi.StringPtrInput `pulumi:"recoveryPlanId"`
	RecoveryPlanName pulumi.StringPtrInput `pulumi:"recoveryPlanName"`
}

func (LookupRecoveryPlanOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRecoveryPlanArgs)(nil)).Elem()
}

// A collection of values returned by getRecoveryPlan.
type LookupRecoveryPlanResultOutput struct{ *pulumi.OutputState }

func (LookupRecoveryPlanResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRecoveryPlanResult)(nil)).Elem()
}

func (o LookupRecoveryPlanResultOutput) ToLookupRecoveryPlanResultOutput() LookupRecoveryPlanResultOutput {
	return o
}

func (o LookupRecoveryPlanResultOutput) ToLookupRecoveryPlanResultOutputWithContext(ctx context.Context) LookupRecoveryPlanResultOutput {
	return o
}

func (o LookupRecoveryPlanResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupRecoveryPlanResultOutput) Categories() GetRecoveryPlanCategoryArrayOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) []GetRecoveryPlanCategory { return v.Categories }).(GetRecoveryPlanCategoryArrayOutput)
}

// A description for Recovery Plan.
func (o LookupRecoveryPlanResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupRecoveryPlanResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupRecoveryPlanResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

// (Optional) the name.
func (o LookupRecoveryPlanResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupRecoveryPlanResultOutput) OwnerReferences() GetRecoveryPlanOwnerReferenceArrayOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) []GetRecoveryPlanOwnerReference { return v.OwnerReferences }).(GetRecoveryPlanOwnerReferenceArrayOutput)
}

// (Required) Parameters for the Recovery Plan.
// * `parameters.0.floating_ip_assignment_list` - (Optional/Computed) Floating IP assignment for VMs upon recovery in an Availability Zone. This is applicable only for the public cloud Availability Zones.
// * `parameters.0.floating_ip_assignment_list.#.availability_zone_url` - (Required) URL of the Availability Zone.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list` - (Required) IP assignment for VMs upon recovery in the specified Availability Zone.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference` - (Required) Reference to a vm.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.kind` - (Required) The kind name.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.uuid` - (Required) The uuid.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.name` - (Optional/Computed) The name.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information` - (Required) Information about vnic to which floating IP has to be assigned.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.ip` - (Optional/Computed) IP address associated with vnic for which floating IP has to be assigned on failover.
// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.uuid` - (Required) Uuid of the vnic of the VM to which floating IP has to be assigned.
// * `parameters.0.network_mapping_list` - (Required) Network mappings to be used for the Recovery Plan. This will be represented by array of network mappings across the Availability Zones.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list` - (Required) Mapping of networks across the Availability Zones.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.availability_zone_url` - (Optional/Computed) URL of the Availability Zone.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.use_vpc_reference` - (Optional/Computed) The reference to a VPC.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference` - (Optional/Computed) The reference to a VPC.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.name` - (Optional/Computed) The name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.name` - (Required) Name of the network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.name` - (Required) Name of the network.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the recovery network for migrate/ failover action on the Recovery Plan.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the test network for test failover action on the Recovery Plan.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list` - (Optional/Computed) The clusters where the recovery and test networks reside. This is required to specify network mapping across clusters for a Recovery Plan created to handle failover within the same Availability Zone.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.kind` - (Optional/Computed) The kind name.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.uuid` - (Optional/Computed) The uuid.
// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.name` - (Optional/Computed) The name.
func (o LookupRecoveryPlanResultOutput) Parameters() GetRecoveryPlanParameterArrayOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) []GetRecoveryPlanParameter { return v.Parameters }).(GetRecoveryPlanParameterArrayOutput)
}

func (o LookupRecoveryPlanResultOutput) ProjectReferences() GetRecoveryPlanProjectReferenceArrayOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) []GetRecoveryPlanProjectReference { return v.ProjectReferences }).(GetRecoveryPlanProjectReferenceArrayOutput)
}

func (o LookupRecoveryPlanResultOutput) RecoveryPlanId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) *string { return v.RecoveryPlanId }).(pulumi.StringPtrOutput)
}

func (o LookupRecoveryPlanResultOutput) RecoveryPlanName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) *string { return v.RecoveryPlanName }).(pulumi.StringPtrOutput)
}

// (Required) Input for the stages of the Recovery Plan. Each stage will perform a predefined type of task.
// * `stage_list.stage_uuid` - (Optional/Computed) UUID of stage.
// * `stage_list.delay_time_secs` - (Optional/Computed) Amount of time in seconds to delay the execution of next stage after execution of current stage.
// * `stage_list.stage_work` - (Required) A stage specifies the work to be performed when the Recovery Plan is executed.
// * `stage_list.stage_work.0.recover_entities` - (Optional/Computed) Information about entities to be recovered.
// * `stage_list.stage_work.0.recover_entities.0.entity_info_list` - (Optional/Computed) Information about entities to be recovered as part of this stage. For VM, entity information will include set of scripts to be executed after recovery of VM. Only one of categories or anyEntityReference has to be provided.
// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_kind` - (Optional/Computed) Reference to a kind.
// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_uuid` - (Optional/Computed) Reference to a uuid.
// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_name` - (Optional/Computed) Reference to a name.
// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.categories` - (Optional/Computed)  Categories for filtering entities.
func (o LookupRecoveryPlanResultOutput) StageLists() GetRecoveryPlanStageListArrayOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) []GetRecoveryPlanStageList { return v.StageLists }).(GetRecoveryPlanStageListArrayOutput)
}

func (o LookupRecoveryPlanResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRecoveryPlanResult) string { return v.State }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRecoveryPlanResultOutput{})
}
