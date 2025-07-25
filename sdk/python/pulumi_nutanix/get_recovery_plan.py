# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
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
    def api_version(self) -> builtins.str:
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def categories(self) -> Sequence['outputs.GetRecoveryPlanCategoryResult']:
        return pulumi.get(self, "categories")

    @property
    @pulumi.getter
    def description(self) -> builtins.str:
        """
        A description for Recovery Plan.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def metadata(self) -> Mapping[str, builtins.str]:
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
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
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="projectReferences")
    def project_references(self) -> Sequence['outputs.GetRecoveryPlanProjectReferenceResult']:
        return pulumi.get(self, "project_references")

    @property
    @pulumi.getter(name="recoveryPlanId")
    def recovery_plan_id(self) -> Optional[builtins.str]:
        return pulumi.get(self, "recovery_plan_id")

    @property
    @pulumi.getter(name="recoveryPlanName")
    def recovery_plan_name(self) -> Optional[builtins.str]:
        return pulumi.get(self, "recovery_plan_name")

    @property
    @pulumi.getter(name="stageLists")
    def stage_lists(self) -> Sequence['outputs.GetRecoveryPlanStageListResult']:
        """
        (Required) Input for the stages of the Recovery Plan. Each stage will perform a predefined type of task.
        """
        return pulumi.get(self, "stage_lists")

    @property
    @pulumi.getter
    def state(self) -> builtins.str:
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


def get_recovery_plan(categories: Optional[Sequence[Union['GetRecoveryPlanCategoryArgs', 'GetRecoveryPlanCategoryArgsDict']]] = None,
                      recovery_plan_id: Optional[builtins.str] = None,
                      recovery_plan_name: Optional[builtins.str] = None,
                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRecoveryPlanResult:
    """
    Describe a Nutanix Recovery Plan and its values (if it has them).


    :param builtins.str recovery_plan_id: - (Required) The `id` of the Recovery Plan.
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['recoveryPlanId'] = recovery_plan_id
    __args__['recoveryPlanName'] = recovery_plan_name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getRecoveryPlan:getRecoveryPlan', __args__, opts=opts, typ=GetRecoveryPlanResult).value

    return AwaitableGetRecoveryPlanResult(
        api_version=pulumi.get(__ret__, 'api_version'),
        categories=pulumi.get(__ret__, 'categories'),
        description=pulumi.get(__ret__, 'description'),
        id=pulumi.get(__ret__, 'id'),
        metadata=pulumi.get(__ret__, 'metadata'),
        name=pulumi.get(__ret__, 'name'),
        owner_references=pulumi.get(__ret__, 'owner_references'),
        parameters=pulumi.get(__ret__, 'parameters'),
        project_references=pulumi.get(__ret__, 'project_references'),
        recovery_plan_id=pulumi.get(__ret__, 'recovery_plan_id'),
        recovery_plan_name=pulumi.get(__ret__, 'recovery_plan_name'),
        stage_lists=pulumi.get(__ret__, 'stage_lists'),
        state=pulumi.get(__ret__, 'state'))
def get_recovery_plan_output(categories: Optional[pulumi.Input[Optional[Sequence[Union['GetRecoveryPlanCategoryArgs', 'GetRecoveryPlanCategoryArgsDict']]]]] = None,
                             recovery_plan_id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                             recovery_plan_name: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                             opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetRecoveryPlanResult]:
    """
    Describe a Nutanix Recovery Plan and its values (if it has them).


    :param builtins.str recovery_plan_id: - (Required) The `id` of the Recovery Plan.
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['recoveryPlanId'] = recovery_plan_id
    __args__['recoveryPlanName'] = recovery_plan_name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getRecoveryPlan:getRecoveryPlan', __args__, opts=opts, typ=GetRecoveryPlanResult)
    return __ret__.apply(lambda __response__: GetRecoveryPlanResult(
        api_version=pulumi.get(__response__, 'api_version'),
        categories=pulumi.get(__response__, 'categories'),
        description=pulumi.get(__response__, 'description'),
        id=pulumi.get(__response__, 'id'),
        metadata=pulumi.get(__response__, 'metadata'),
        name=pulumi.get(__response__, 'name'),
        owner_references=pulumi.get(__response__, 'owner_references'),
        parameters=pulumi.get(__response__, 'parameters'),
        project_references=pulumi.get(__response__, 'project_references'),
        recovery_plan_id=pulumi.get(__response__, 'recovery_plan_id'),
        recovery_plan_name=pulumi.get(__response__, 'recovery_plan_name'),
        stage_lists=pulumi.get(__response__, 'stage_lists'),
        state=pulumi.get(__response__, 'state')))
