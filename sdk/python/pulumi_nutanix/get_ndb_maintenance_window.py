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
    'GetNdbMaintenanceWindowResult',
    'AwaitableGetNdbMaintenanceWindowResult',
    'get_ndb_maintenance_window',
    'get_ndb_maintenance_window_output',
]

@pulumi.output_type
class GetNdbMaintenanceWindowResult:
    """
    A collection of values returned by getNdbMaintenanceWindow.
    """
    def __init__(__self__, access_level=None, date_created=None, date_modified=None, description=None, entity_task_assocs=None, id=None, name=None, next_run_time=None, owner_id=None, properties=None, schedules=None, status=None, tags=None, timezone=None):
        if access_level and not isinstance(access_level, str):
            raise TypeError("Expected argument 'access_level' to be a str")
        pulumi.set(__self__, "access_level", access_level)
        if date_created and not isinstance(date_created, str):
            raise TypeError("Expected argument 'date_created' to be a str")
        pulumi.set(__self__, "date_created", date_created)
        if date_modified and not isinstance(date_modified, str):
            raise TypeError("Expected argument 'date_modified' to be a str")
        pulumi.set(__self__, "date_modified", date_modified)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if entity_task_assocs and not isinstance(entity_task_assocs, list):
            raise TypeError("Expected argument 'entity_task_assocs' to be a list")
        pulumi.set(__self__, "entity_task_assocs", entity_task_assocs)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if next_run_time and not isinstance(next_run_time, str):
            raise TypeError("Expected argument 'next_run_time' to be a str")
        pulumi.set(__self__, "next_run_time", next_run_time)
        if owner_id and not isinstance(owner_id, str):
            raise TypeError("Expected argument 'owner_id' to be a str")
        pulumi.set(__self__, "owner_id", owner_id)
        if properties and not isinstance(properties, list):
            raise TypeError("Expected argument 'properties' to be a list")
        pulumi.set(__self__, "properties", properties)
        if schedules and not isinstance(schedules, list):
            raise TypeError("Expected argument 'schedules' to be a list")
        pulumi.set(__self__, "schedules", schedules)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if tags and not isinstance(tags, list):
            raise TypeError("Expected argument 'tags' to be a list")
        pulumi.set(__self__, "tags", tags)
        if timezone and not isinstance(timezone, str):
            raise TypeError("Expected argument 'timezone' to be a str")
        pulumi.set(__self__, "timezone", timezone)

    @property
    @pulumi.getter(name="accessLevel")
    def access_level(self) -> builtins.str:
        """
        access level
        """
        return pulumi.get(self, "access_level")

    @property
    @pulumi.getter(name="dateCreated")
    def date_created(self) -> builtins.str:
        """
        created date of maintenance window
        """
        return pulumi.get(self, "date_created")

    @property
    @pulumi.getter(name="dateModified")
    def date_modified(self) -> builtins.str:
        """
        modified date of maintenance window
        """
        return pulumi.get(self, "date_modified")

    @property
    @pulumi.getter
    def description(self) -> builtins.str:
        """
        description of maintenance window
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="entityTaskAssocs")
    def entity_task_assocs(self) -> Sequence['outputs.GetNdbMaintenanceWindowEntityTaskAssocResult']:
        """
        entity task association for maintenance window
        """
        return pulumi.get(self, "entity_task_assocs")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
        """
        name of maintenance window
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nextRunTime")
    def next_run_time(self) -> builtins.str:
        """
        next run time for maintenance window to trigger
        """
        return pulumi.get(self, "next_run_time")

    @property
    @pulumi.getter(name="ownerId")
    def owner_id(self) -> builtins.str:
        """
        owner id of maintenance window
        """
        return pulumi.get(self, "owner_id")

    @property
    @pulumi.getter
    def properties(self) -> Sequence['outputs.GetNdbMaintenanceWindowPropertyResult']:
        """
        properties of maintenance window
        """
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter
    def schedules(self) -> Sequence['outputs.GetNdbMaintenanceWindowScheduleResult']:
        """
        schedule of maintenance window
        """
        return pulumi.get(self, "schedules")

    @property
    @pulumi.getter
    def status(self) -> builtins.str:
        """
        status of maintennace window
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tags(self) -> Sequence['outputs.GetNdbMaintenanceWindowTagResult']:
        """
        tags of maintenance window
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def timezone(self) -> builtins.str:
        """
        timezone
        """
        return pulumi.get(self, "timezone")


class AwaitableGetNdbMaintenanceWindowResult(GetNdbMaintenanceWindowResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetNdbMaintenanceWindowResult(
            access_level=self.access_level,
            date_created=self.date_created,
            date_modified=self.date_modified,
            description=self.description,
            entity_task_assocs=self.entity_task_assocs,
            id=self.id,
            name=self.name,
            next_run_time=self.next_run_time,
            owner_id=self.owner_id,
            properties=self.properties,
            schedules=self.schedules,
            status=self.status,
            tags=self.tags,
            timezone=self.timezone)


def get_ndb_maintenance_window(id: Optional[builtins.str] = None,
                               tags: Optional[Sequence[Union['GetNdbMaintenanceWindowTagArgs', 'GetNdbMaintenanceWindowTagArgsDict']]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetNdbMaintenanceWindowResult:
    """
    Describes a maintenance window in Nutanix Database Service

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    window = nutanix.get_ndb_maintenance_window(id="{{ maintenance_window_id }}")
    ```


    :param builtins.str id: Maintenance window id.
    :param Sequence[Union['GetNdbMaintenanceWindowTagArgs', 'GetNdbMaintenanceWindowTagArgsDict']] tags: tags of maintenance window
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['tags'] = tags
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getNdbMaintenanceWindow:getNdbMaintenanceWindow', __args__, opts=opts, typ=GetNdbMaintenanceWindowResult).value

    return AwaitableGetNdbMaintenanceWindowResult(
        access_level=pulumi.get(__ret__, 'access_level'),
        date_created=pulumi.get(__ret__, 'date_created'),
        date_modified=pulumi.get(__ret__, 'date_modified'),
        description=pulumi.get(__ret__, 'description'),
        entity_task_assocs=pulumi.get(__ret__, 'entity_task_assocs'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'),
        next_run_time=pulumi.get(__ret__, 'next_run_time'),
        owner_id=pulumi.get(__ret__, 'owner_id'),
        properties=pulumi.get(__ret__, 'properties'),
        schedules=pulumi.get(__ret__, 'schedules'),
        status=pulumi.get(__ret__, 'status'),
        tags=pulumi.get(__ret__, 'tags'),
        timezone=pulumi.get(__ret__, 'timezone'))
def get_ndb_maintenance_window_output(id: Optional[pulumi.Input[builtins.str]] = None,
                                      tags: Optional[pulumi.Input[Optional[Sequence[Union['GetNdbMaintenanceWindowTagArgs', 'GetNdbMaintenanceWindowTagArgsDict']]]]] = None,
                                      opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetNdbMaintenanceWindowResult]:
    """
    Describes a maintenance window in Nutanix Database Service

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    window = nutanix.get_ndb_maintenance_window(id="{{ maintenance_window_id }}")
    ```


    :param builtins.str id: Maintenance window id.
    :param Sequence[Union['GetNdbMaintenanceWindowTagArgs', 'GetNdbMaintenanceWindowTagArgsDict']] tags: tags of maintenance window
    """
    __args__ = dict()
    __args__['id'] = id
    __args__['tags'] = tags
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getNdbMaintenanceWindow:getNdbMaintenanceWindow', __args__, opts=opts, typ=GetNdbMaintenanceWindowResult)
    return __ret__.apply(lambda __response__: GetNdbMaintenanceWindowResult(
        access_level=pulumi.get(__response__, 'access_level'),
        date_created=pulumi.get(__response__, 'date_created'),
        date_modified=pulumi.get(__response__, 'date_modified'),
        description=pulumi.get(__response__, 'description'),
        entity_task_assocs=pulumi.get(__response__, 'entity_task_assocs'),
        id=pulumi.get(__response__, 'id'),
        name=pulumi.get(__response__, 'name'),
        next_run_time=pulumi.get(__response__, 'next_run_time'),
        owner_id=pulumi.get(__response__, 'owner_id'),
        properties=pulumi.get(__response__, 'properties'),
        schedules=pulumi.get(__response__, 'schedules'),
        status=pulumi.get(__response__, 'status'),
        tags=pulumi.get(__response__, 'tags'),
        timezone=pulumi.get(__response__, 'timezone')))
