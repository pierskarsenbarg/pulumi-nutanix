# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetRecoveryPlanResult',
    'AwaitableGetRecoveryPlanResult',
    'get_recovery_plan',
    'get_recovery_plan_output',
]

@pulumi.output_type
class GetRecoveryPlanResult:
    """
    A collection of values returned by getRecoveryPlan.
    """
    def __init__(__self__, api_version=None, categories=None, description=None, id=None, metadata=None, name=None, owner_references=None, parameters=None, project_references=None, recovery_plan_id=None, recovery_plan_name=None, stage_lists=None, state=None):
        if api_version and not isinstance(api_version, str):
            raise TypeError("Expected argument 'api_version' to be a str")
        pulumi.set(__self__, "api_version", api_version)
        if categories and not isinstance(categories, list):
            raise TypeError("Expected argument 'categories' to be a list")
        pulumi.set(__self__, "categories", categories)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if owner_references and not isinstance(owner_references, list):
            raise TypeError("Expected argument 'owner_references' to be a list")
        pulumi.set(__self__, "owner_references", owner_references)
        if parameters and not isinstance(parameters, list):
            raise TypeError("Expected argument 'parameters' to be a list")
        pulumi.set(__self__, "parameters", parameters)
        if project_references and not isinstance(project_references, list):
            raise TypeError("Expected argument 'project_references' to be a list")
        pulumi.set(__self__, "project_references", project_references)
        if recovery_plan_id and not isinstance(recovery_plan_id, str):
            raise TypeError("Expected argument 'recovery_plan_id' to be a str")
        pulumi.set(__self__, "recovery_plan_id", recovery_plan_id)
        if recovery_plan_name and not isinstance(recovery_plan_name, str):
            raise TypeError("Expected argument 'recovery_plan_name' to be a str")
        pulumi.set(__self__, "recovery_plan_name", recovery_plan_name)
        if stage_lists and not isinstance(stage_lists, list):
            raise TypeError("Expected argument 'stage_lists' to be a list")
        pulumi.set(__self__, "stage_lists", stage_lists)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def categories(self) -> Sequence['outputs.GetRecoveryPlanCategoryResult']:
        return pulumi.get(self, "categories")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def metadata(self) -> Mapping[str, str]:
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        (Optional) the name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownerReferences")
    def owner_references(self) -> Sequence['outputs.GetRecoveryPlanOwnerReferenceResult']:
        return pulumi.get(self, "owner_references")

    @property
    @pulumi.getter
    def parameters(self) -> Sequence['outputs.GetRecoveryPlanParameterResult']:
        """
        (Required) Parameters for the Recovery Plan.
        * `parameters.0.floating_ip_assignment_list` - (Optional/Computed) Floating IP assignment for VMs upon recovery in an Availability Zone. This is applicable only for the public cloud Availability Zones.
        * `parameters.0.floating_ip_assignment_list.#.availability_zone_url` - (Required) URL of the Availability Zone.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list` - (Required) IP assignment for VMs upon recovery in the specified Availability Zone.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.test_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config` - (Optional/Computed) Configuration for assigning floating IP to a VM on the execution of the Recovery Plan.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.ip` - (Optional/Computed) IP to be assigned to VM, in case of failover.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.recovery_floating_ip_config.should_allocate_dynamically` - (Optional/Computed) Whether to allocate the floating IPs for the VMs dynamically.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference` - (Required) Reference to a vm.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.kind` - (Required) The kind name.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.uuid` - (Required) The uuid.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_reference.name` - (Optional/Computed) The name.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information` - (Required) Information about vnic to which floating IP has to be assigned.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.ip` - (Optional/Computed) IP address associated with vnic for which floating IP has to be assigned on failover.
        * `parameters.0.floating_ip_assignment_list.#.vm_ip_assignment_list.#.vm_nic_information.uuid` - (Required) Uuid of the vnic of the VM to which floating IP has to be assigned.
        * `parameters.0.network_mapping_list` - (Required) Network mappings to be used for the Recovery Plan. This will be represented by array of network mappings across the Availability Zones.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list` - (Required) Mapping of networks across the Availability Zones.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.availability_zone_url` - (Optional/Computed) URL of the Availability Zone.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.use_vpc_reference` - (Optional/Computed) The reference to a VPC.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference` - (Optional/Computed) The reference to a VPC.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.vpc_reference.name` - (Optional/Computed) The name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_network.0.name` - (Required) Name of the network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network` - (Optional/Computed) Network configuration to be used for performing network mapping and IP preservation/mapping on Recovery Plan execution.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference` - (Optional/Computed) The reference to a virtual_network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.virtual_network_reference.name` - (Optional/Computed) The name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list` - (Optional/Computed) List of subnets for the network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.gateway_ip` - (Required) Gateway IP address for the subnet.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.external_connectivity_state` - (Optional/Computed) External connectivity state of the subnet. This is applicable only for the subnet to be created in public cloud Availability Zone.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.subnet_list.#.prefix_length` - (Required) Prefix length for the subnet.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_network.0.name` - (Required) Name of the network.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the recovery network for migrate/ failover action on the Recovery Plan.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.recovery_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list` - (Optional/Computed) Static IP configuration for the VMs to be applied post recovery in the test network for test failover action on the Recovery Plan.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference` - (Optional/Computed) The reference to a vm.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.vm_reference.name` - (Optional/Computed) The name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list` - (Optional/Computed) List of IP configurations for a VM.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.ip_config_list.#.ip_address` - (Required) IP address.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list` - (Optional/Computed) The clusters where the recovery and test networks reside. This is required to specify network mapping across clusters for a Recovery Plan created to handle failover within the same Availability Zone.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.kind` - (Optional/Computed) The kind name.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.cluster_reference_list.0.uuid` - (Optional/Computed) The uuid.
        * `parameters.0.network_mapping_list.#.availability_zone_network_mapping_list.#.test_ip_assignment_list.0.name` - (Optional/Computed) The name.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="projectReferences")
    def project_references(self) -> Sequence['outputs.GetRecoveryPlanProjectReferenceResult']:
        return pulumi.get(self, "project_references")

    @property
    @pulumi.getter(name="recoveryPlanId")
    def recovery_plan_id(self) -> Optional[str]:
        return pulumi.get(self, "recovery_plan_id")

    @property
    @pulumi.getter(name="recoveryPlanName")
    def recovery_plan_name(self) -> Optional[str]:
        return pulumi.get(self, "recovery_plan_name")

    @property
    @pulumi.getter(name="stageLists")
    def stage_lists(self) -> Sequence['outputs.GetRecoveryPlanStageListResult']:
        """
        (Required) Input for the stages of the Recovery Plan. Each stage will perform a predefined type of task.
        * `stage_list.stage_uuid` - (Optional/Computed) UUID of stage.
        * `stage_list.delay_time_secs` - (Optional/Computed) Amount of time in seconds to delay the execution of next stage after execution of current stage.
        * `stage_list.stage_work` - (Required) A stage specifies the work to be performed when the Recovery Plan is executed.
        * `stage_list.stage_work.0.recover_entities` - (Optional/Computed) Information about entities to be recovered.
        * `stage_list.stage_work.0.recover_entities.0.entity_info_list` - (Optional/Computed) Information about entities to be recovered as part of this stage. For VM, entity information will include set of scripts to be executed after recovery of VM. Only one of categories or any_entity_reference has to be provided.
        * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_kind` - (Optional/Computed) Reference to a kind.
        * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_uuid` - (Optional/Computed) Reference to a uuid.
        * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.any_entity_reference_name` - (Optional/Computed) Reference to a name.
        * `stage_list.stage_work.0.recover_entities.0.entity_info_list.#.categories` - (Optional/Computed)  Categories for filtering entities.
        """
        return pulumi.get(self, "stage_lists")

    @property
    @pulumi.getter
    def state(self) -> str:
        return pulumi.get(self, "state")


class AwaitableGetRecoveryPlanResult(GetRecoveryPlanResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRecoveryPlanResult(
            api_version=self.api_version,
            categories=self.categories,
            description=self.description,
            id=self.id,
            metadata=self.metadata,
            name=self.name,
            owner_references=self.owner_references,
            parameters=self.parameters,
            project_references=self.project_references,
            recovery_plan_id=self.recovery_plan_id,
            recovery_plan_name=self.recovery_plan_name,
            stage_lists=self.stage_lists,
            state=self.state)


def get_recovery_plan(categories: Optional[Sequence[pulumi.InputType['GetRecoveryPlanCategoryArgs']]] = None,
                      recovery_plan_id: Optional[str] = None,
                      recovery_plan_name: Optional[str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRecoveryPlanResult:
    """
    Describe a Nutanix Recovery Plan and its values (if it has them).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    recovery_plan_test = nutanix.RecoveryPlan("recoveryPlanTest",
        description="%s",
        parameters=nutanix.RecoveryPlanParametersArgs(),
        stage_lists=[nutanix.RecoveryPlanStageListArgs(
            delay_time_secs=0,
            stage_uuid="ab788130-0820-4d07-a1b5-b0ba4d3a42asd",
            stage_work=nutanix.RecoveryPlanStageListStageWorkArgs(
                recover_entities=nutanix.RecoveryPlanStageListStageWorkRecoverEntitiesArgs(
                    entity_info_list=[{
                        "categories": [{
                            "name": "Environment",
                            "value": "Dev",
                        }],
                    }],
                ),
            ),
        )])
    ```
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['recoveryPlanId'] = recovery_plan_id
    __args__['recoveryPlanName'] = recovery_plan_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getRecoveryPlan:getRecoveryPlan', __args__, opts=opts, typ=GetRecoveryPlanResult).value

    return AwaitableGetRecoveryPlanResult(
        api_version=__ret__.api_version,
        categories=__ret__.categories,
        description=__ret__.description,
        id=__ret__.id,
        metadata=__ret__.metadata,
        name=__ret__.name,
        owner_references=__ret__.owner_references,
        parameters=__ret__.parameters,
        project_references=__ret__.project_references,
        recovery_plan_id=__ret__.recovery_plan_id,
        recovery_plan_name=__ret__.recovery_plan_name,
        stage_lists=__ret__.stage_lists,
        state=__ret__.state)


@_utilities.lift_output_func(get_recovery_plan)
def get_recovery_plan_output(categories: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetRecoveryPlanCategoryArgs']]]]] = None,
                             recovery_plan_id: Optional[pulumi.Input[Optional[str]]] = None,
                             recovery_plan_name: Optional[pulumi.Input[Optional[str]]] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRecoveryPlanResult]:
    """
    Describe a Nutanix Recovery Plan and its values (if it has them).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    recovery_plan_test = nutanix.RecoveryPlan("recoveryPlanTest",
        description="%s",
        parameters=nutanix.RecoveryPlanParametersArgs(),
        stage_lists=[nutanix.RecoveryPlanStageListArgs(
            delay_time_secs=0,
            stage_uuid="ab788130-0820-4d07-a1b5-b0ba4d3a42asd",
            stage_work=nutanix.RecoveryPlanStageListStageWorkArgs(
                recover_entities=nutanix.RecoveryPlanStageListStageWorkRecoverEntitiesArgs(
                    entity_info_list=[{
                        "categories": [{
                            "name": "Environment",
                            "value": "Dev",
                        }],
                    }],
                ),
            ),
        )])
    ```
    """
    ...