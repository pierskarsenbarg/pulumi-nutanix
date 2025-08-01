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
    'GetProtectionRuleResult',
    'AwaitableGetProtectionRuleResult',
    'get_protection_rule',
    'get_protection_rule_output',
]

@pulumi.output_type
class GetProtectionRuleResult:
    """
    A collection of values returned by getProtectionRule.
    """
    def __init__(__self__, api_version=None, availability_zone_connectivity_lists=None, categories=None, category_filters=None, description=None, id=None, metadata=None, name=None, ordered_availability_zone_lists=None, owner_references=None, project_references=None, protection_rule_id=None, protection_rule_name=None, start_time=None, state=None):
        if api_version and not isinstance(api_version, str):
            raise TypeError("Expected argument 'api_version' to be a str")
        pulumi.set(__self__, "api_version", api_version)
        if availability_zone_connectivity_lists and not isinstance(availability_zone_connectivity_lists, list):
            raise TypeError("Expected argument 'availability_zone_connectivity_lists' to be a list")
        pulumi.set(__self__, "availability_zone_connectivity_lists", availability_zone_connectivity_lists)
        if categories and not isinstance(categories, list):
            raise TypeError("Expected argument 'categories' to be a list")
        pulumi.set(__self__, "categories", categories)
        if category_filters and not isinstance(category_filters, list):
            raise TypeError("Expected argument 'category_filters' to be a list")
        pulumi.set(__self__, "category_filters", category_filters)
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
        if ordered_availability_zone_lists and not isinstance(ordered_availability_zone_lists, list):
            raise TypeError("Expected argument 'ordered_availability_zone_lists' to be a list")
        pulumi.set(__self__, "ordered_availability_zone_lists", ordered_availability_zone_lists)
        if owner_references and not isinstance(owner_references, list):
            raise TypeError("Expected argument 'owner_references' to be a list")
        pulumi.set(__self__, "owner_references", owner_references)
        if project_references and not isinstance(project_references, list):
            raise TypeError("Expected argument 'project_references' to be a list")
        pulumi.set(__self__, "project_references", project_references)
        if protection_rule_id and not isinstance(protection_rule_id, str):
            raise TypeError("Expected argument 'protection_rule_id' to be a str")
        pulumi.set(__self__, "protection_rule_id", protection_rule_id)
        if protection_rule_name and not isinstance(protection_rule_name, str):
            raise TypeError("Expected argument 'protection_rule_name' to be a str")
        pulumi.set(__self__, "protection_rule_name", protection_rule_name)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> builtins.str:
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter(name="availabilityZoneConnectivityLists")
    def availability_zone_connectivity_lists(self) -> Sequence['outputs.GetProtectionRuleAvailabilityZoneConnectivityListResult']:
        """
        (Required) This encodes the datapipes between various availability zones and\\nthe backup policy of the pipes.
        """
        return pulumi.get(self, "availability_zone_connectivity_lists")

    @property
    @pulumi.getter
    def categories(self) -> Sequence['outputs.GetProtectionRuleCategoryResult']:
        return pulumi.get(self, "categories")

    @property
    @pulumi.getter(name="categoryFilters")
    def category_filters(self) -> Sequence['outputs.GetProtectionRuleCategoryFilterResult']:
        """
        (Optional/Computed)
        """
        return pulumi.get(self, "category_filters")

    @property
    @pulumi.getter
    def description(self) -> builtins.str:
        """
        A description for protection rule.
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
    @pulumi.getter(name="orderedAvailabilityZoneLists")
    def ordered_availability_zone_lists(self) -> Sequence['outputs.GetProtectionRuleOrderedAvailabilityZoneListResult']:
        """
        (Required) A list of availability zones, each of which, receives a replica\\nof the data for the entities protected by this protection rule.
        * `ordered_availability_zone_list.#.cluster_uuid` - (Optional/Computed) UUID of specific cluster to which we will be replicating.
        * `ordered_availability_zone_list.#.availability_zone_url` - (Optional/Computed) The FQDN or IP address of the availability zone.
        """
        return pulumi.get(self, "ordered_availability_zone_lists")

    @property
    @pulumi.getter(name="ownerReferences")
    def owner_references(self) -> Sequence['outputs.GetProtectionRuleOwnerReferenceResult']:
        return pulumi.get(self, "owner_references")

    @property
    @pulumi.getter(name="projectReferences")
    def project_references(self) -> Sequence['outputs.GetProtectionRuleProjectReferenceResult']:
        return pulumi.get(self, "project_references")

    @property
    @pulumi.getter(name="protectionRuleId")
    def protection_rule_id(self) -> Optional[builtins.str]:
        return pulumi.get(self, "protection_rule_id")

    @property
    @pulumi.getter(name="protectionRuleName")
    def protection_rule_name(self) -> Optional[builtins.str]:
        return pulumi.get(self, "protection_rule_name")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> builtins.str:
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def state(self) -> builtins.str:
        return pulumi.get(self, "state")


class AwaitableGetProtectionRuleResult(GetProtectionRuleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetProtectionRuleResult(
            api_version=self.api_version,
            availability_zone_connectivity_lists=self.availability_zone_connectivity_lists,
            categories=self.categories,
            category_filters=self.category_filters,
            description=self.description,
            id=self.id,
            metadata=self.metadata,
            name=self.name,
            ordered_availability_zone_lists=self.ordered_availability_zone_lists,
            owner_references=self.owner_references,
            project_references=self.project_references,
            protection_rule_id=self.protection_rule_id,
            protection_rule_name=self.protection_rule_name,
            start_time=self.start_time,
            state=self.state)


def get_protection_rule(categories: Optional[Sequence[Union['GetProtectionRuleCategoryArgs', 'GetProtectionRuleCategoryArgsDict']]] = None,
                        protection_rule_id: Optional[builtins.str] = None,
                        protection_rule_name: Optional[builtins.str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetProtectionRuleResult:
    """
    Describe a Nutanix Protection Rule and its values (if it has them).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    protection_rule_test = nutanix.ProtectionRule("protectionRuleTest",
        description="test",
        ordered_availability_zone_lists=[{
            "availability_zone_url": "ab788130-0820-4d07-a1b5-b0ba4d3a42asd",
        }],
        availability_zone_connectivity_lists=[{
            "snapshot_schedule_lists": [{
                "recovery_point_objective_secs": 3600,
                "snapshot_type": "CRASH_CONSISTENT",
                "local_snapshot_retention_policy": {
                    "num_snapshots": 1,
                },
            }],
        }],
        category_filter={
            "params": [{
                "name": "Environment",
                "values": ["Dev"],
            }],
        })
    test = nutanix.get_protection_rule_output(protection_rule_id=protection_rule_test.id)
    ```


    :param builtins.str protection_rule_id: - (Required) The `id` of the protection rule.
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['protectionRuleId'] = protection_rule_id
    __args__['protectionRuleName'] = protection_rule_name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getProtectionRule:getProtectionRule', __args__, opts=opts, typ=GetProtectionRuleResult).value

    return AwaitableGetProtectionRuleResult(
        api_version=pulumi.get(__ret__, 'api_version'),
        availability_zone_connectivity_lists=pulumi.get(__ret__, 'availability_zone_connectivity_lists'),
        categories=pulumi.get(__ret__, 'categories'),
        category_filters=pulumi.get(__ret__, 'category_filters'),
        description=pulumi.get(__ret__, 'description'),
        id=pulumi.get(__ret__, 'id'),
        metadata=pulumi.get(__ret__, 'metadata'),
        name=pulumi.get(__ret__, 'name'),
        ordered_availability_zone_lists=pulumi.get(__ret__, 'ordered_availability_zone_lists'),
        owner_references=pulumi.get(__ret__, 'owner_references'),
        project_references=pulumi.get(__ret__, 'project_references'),
        protection_rule_id=pulumi.get(__ret__, 'protection_rule_id'),
        protection_rule_name=pulumi.get(__ret__, 'protection_rule_name'),
        start_time=pulumi.get(__ret__, 'start_time'),
        state=pulumi.get(__ret__, 'state'))
def get_protection_rule_output(categories: Optional[pulumi.Input[Optional[Sequence[Union['GetProtectionRuleCategoryArgs', 'GetProtectionRuleCategoryArgsDict']]]]] = None,
                               protection_rule_id: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                               protection_rule_name: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                               opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetProtectionRuleResult]:
    """
    Describe a Nutanix Protection Rule and its values (if it has them).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    protection_rule_test = nutanix.ProtectionRule("protectionRuleTest",
        description="test",
        ordered_availability_zone_lists=[{
            "availability_zone_url": "ab788130-0820-4d07-a1b5-b0ba4d3a42asd",
        }],
        availability_zone_connectivity_lists=[{
            "snapshot_schedule_lists": [{
                "recovery_point_objective_secs": 3600,
                "snapshot_type": "CRASH_CONSISTENT",
                "local_snapshot_retention_policy": {
                    "num_snapshots": 1,
                },
            }],
        }],
        category_filter={
            "params": [{
                "name": "Environment",
                "values": ["Dev"],
            }],
        })
    test = nutanix.get_protection_rule_output(protection_rule_id=protection_rule_test.id)
    ```


    :param builtins.str protection_rule_id: - (Required) The `id` of the protection rule.
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['protectionRuleId'] = protection_rule_id
    __args__['protectionRuleName'] = protection_rule_name
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getProtectionRule:getProtectionRule', __args__, opts=opts, typ=GetProtectionRuleResult)
    return __ret__.apply(lambda __response__: GetProtectionRuleResult(
        api_version=pulumi.get(__response__, 'api_version'),
        availability_zone_connectivity_lists=pulumi.get(__response__, 'availability_zone_connectivity_lists'),
        categories=pulumi.get(__response__, 'categories'),
        category_filters=pulumi.get(__response__, 'category_filters'),
        description=pulumi.get(__response__, 'description'),
        id=pulumi.get(__response__, 'id'),
        metadata=pulumi.get(__response__, 'metadata'),
        name=pulumi.get(__response__, 'name'),
        ordered_availability_zone_lists=pulumi.get(__response__, 'ordered_availability_zone_lists'),
        owner_references=pulumi.get(__response__, 'owner_references'),
        project_references=pulumi.get(__response__, 'project_references'),
        protection_rule_id=pulumi.get(__response__, 'protection_rule_id'),
        protection_rule_name=pulumi.get(__response__, 'protection_rule_name'),
        start_time=pulumi.get(__response__, 'start_time'),
        state=pulumi.get(__response__, 'state')))
