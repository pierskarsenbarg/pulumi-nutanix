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
    public static class GetRecoveryPlan
    {
        /// <summary>
        /// Describe a Nutanix Recovery Plan and its values (if it has them).
        /// </summary>
        public static Task<GetRecoveryPlanResult> InvokeAsync(GetRecoveryPlanArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRecoveryPlanResult>("nutanix:index/getRecoveryPlan:getRecoveryPlan", args ?? new GetRecoveryPlanArgs(), options.WithDefaults());

        /// <summary>
        /// Describe a Nutanix Recovery Plan and its values (if it has them).
        /// </summary>
        public static Output<GetRecoveryPlanResult> Invoke(GetRecoveryPlanInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRecoveryPlanResult>("nutanix:index/getRecoveryPlan:getRecoveryPlan", args ?? new GetRecoveryPlanInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRecoveryPlanArgs : global::Pulumi.InvokeArgs
    {
        [Input("categories")]
        private List<Inputs.GetRecoveryPlanCategoryArgs>? _categories;
        public List<Inputs.GetRecoveryPlanCategoryArgs> Categories
        {
            get => _categories ?? (_categories = new List<Inputs.GetRecoveryPlanCategoryArgs>());
            set => _categories = value;
        }

        /// <summary>
        /// - (Required) The `id` of the Recovery Plan.
        /// </summary>
        [Input("recoveryPlanId")]
        public string? RecoveryPlanId { get; set; }

        [Input("recoveryPlanName")]
        public string? RecoveryPlanName { get; set; }

        public GetRecoveryPlanArgs()
        {
        }
        public static new GetRecoveryPlanArgs Empty => new GetRecoveryPlanArgs();
    }

    public sealed class GetRecoveryPlanInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("categories")]
        private InputList<Inputs.GetRecoveryPlanCategoryInputArgs>? _categories;
        public InputList<Inputs.GetRecoveryPlanCategoryInputArgs> Categories
        {
            get => _categories ?? (_categories = new InputList<Inputs.GetRecoveryPlanCategoryInputArgs>());
            set => _categories = value;
        }

        /// <summary>
        /// - (Required) The `id` of the Recovery Plan.
        /// </summary>
        [Input("recoveryPlanId")]
        public Input<string>? RecoveryPlanId { get; set; }

        [Input("recoveryPlanName")]
        public Input<string>? RecoveryPlanName { get; set; }

        public GetRecoveryPlanInvokeArgs()
        {
        }
        public static new GetRecoveryPlanInvokeArgs Empty => new GetRecoveryPlanInvokeArgs();
    }


    [OutputType]
    public sealed class GetRecoveryPlanResult
    {
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetRecoveryPlanCategoryResult> Categories;
        /// <summary>
        /// A description for Recovery Plan.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Metadata;
        /// <summary>
        /// (Optional) the name.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetRecoveryPlanOwnerReferenceResult> OwnerReferences;
        /// <summary>
        /// (Required) Parameters for the Recovery Plan.
        /// * `parameters.0.floating_ip_assignment_list` - (Optional/Computed) Floating IP assignment for VMs upon recovery in an Availability Zone. This is applicable only for the public cloud Availability Zones.
        /// * `parameters.0.floating_ip_assignment_list.#.availability_zone_url` - (Required) URL of the Availability Zone.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list` - (Required) IP assignment for VMs upon recovery in the specified Availability Zone.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference` - (Required) Reference to a vm.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.kind` - (Required) The kind name.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.uuid` - (Required) The uuid.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information` - (Required) Information about vnic to which floating IP has to be assigned.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.ip` - (Optional/Computed) IP address associated with vnic for which floating IP has to be assigned on failover.
        /// * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.uuid` - (Required) Uuid of the vnic of the VM to which floating IP has to be assigned.
        /// * `parameters.0.network_mapping_list` - (Required) Network mappings to be used for the Recovery Plan. This will be represented by array of network mappings across the Availability Zones.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list` - (Required) Mapping of networks across the Availability Zones.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.availability_zone_url` - (Optional/Computed) URL of the Availability Zone.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.use_vpc_reference` - (Optional/Computed) The reference to a VPC.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference` - (Optional/Computed) The reference to a VPC.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.name` - (Required) Name of the network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.name` - (Required) Name of the network.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the recovery network for migrate/ failover action on the Recovery Plan.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the test network for test failover action on the Recovery Plan.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list` - (Optional/Computed) The clusters where the recovery and test networks reside. This is required to specify network mapping across clusters for a Recovery Plan created to handle failover within the same Availability Zone.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.kind` - (Optional/Computed) The kind name.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.uuid` - (Optional/Computed) The uuid.
        /// * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.name` - (Optional/Computed) The name.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRecoveryPlanParameterResult> Parameters;
        public readonly ImmutableArray<Outputs.GetRecoveryPlanProjectReferenceResult> ProjectReferences;
        public readonly string? RecoveryPlanId;
        public readonly string? RecoveryPlanName;
        /// <summary>
        /// (Required) Input for the stages of the Recovery Plan. Each stage will perform a predefined type of task.
        /// * `stage_list.stage_uuid` - (Optional/Computed) UUID of stage.
        /// * `stage_list.delay_time_secs` - (Optional/Computed) Amount of time in seconds to delay the execution of next stage after execution of current stage.
        /// * `stage_list.stage_work` - (Required) A stage specifies the work to be performed when the Recovery Plan is executed.
        /// * `stage_list.stage_work.0.recover_entities` - (Optional/Computed) Information about entities to be recovered.
        /// * `stage_list.stage_work.0.recover_entities.0.entity_info_list` - (Optional/Computed) Information about entities to be recovered as part of this stage. For VM, entity information will include set of scripts to be executed after recovery of VM. Only one of categories or any_entity_reference has to be provided.
        /// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_kind` - (Optional/Computed) Reference to a kind.
        /// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_uuid` - (Optional/Computed) Reference to a uuid.
        /// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_name` - (Optional/Computed) Reference to a name.
        /// * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.categories` - (Optional/Computed)  Categories for filtering entities.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRecoveryPlanStageListResult> StageLists;
        public readonly string State;

        [OutputConstructor]
        private GetRecoveryPlanResult(
            string apiVersion,

            ImmutableArray<Outputs.GetRecoveryPlanCategoryResult> categories,

            string description,

            string id,

            ImmutableDictionary<string, string> metadata,

            string name,

            ImmutableArray<Outputs.GetRecoveryPlanOwnerReferenceResult> ownerReferences,

            ImmutableArray<Outputs.GetRecoveryPlanParameterResult> parameters,

            ImmutableArray<Outputs.GetRecoveryPlanProjectReferenceResult> projectReferences,

            string? recoveryPlanId,

            string? recoveryPlanName,

            ImmutableArray<Outputs.GetRecoveryPlanStageListResult> stageLists,

            string state)
        {
            ApiVersion = apiVersion;
            Categories = categories;
            Description = description;
            Id = id;
            Metadata = metadata;
            Name = name;
            OwnerReferences = ownerReferences;
            Parameters = parameters;
            ProjectReferences = projectReferences;
            RecoveryPlanId = recoveryPlanId;
            RecoveryPlanName = recoveryPlanName;
            StageLists = stageLists;
            State = state;
        }
    }
}
