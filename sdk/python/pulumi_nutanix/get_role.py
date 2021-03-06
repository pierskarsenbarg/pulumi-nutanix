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
    'GetRoleResult',
    'AwaitableGetRoleResult',
    'get_role',
    'get_role_output',
]

@pulumi.output_type
class GetRoleResult:
    """
    A collection of values returned by getRole.
    """
    def __init__(__self__, api_version=None, categories=None, description=None, id=None, metadata=None, name=None, owner_reference=None, permission_reference_lists=None, project_reference=None, role_id=None, role_name=None, state=None):
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
        if owner_reference and not isinstance(owner_reference, dict):
            raise TypeError("Expected argument 'owner_reference' to be a dict")
        pulumi.set(__self__, "owner_reference", owner_reference)
        if permission_reference_lists and not isinstance(permission_reference_lists, list):
            raise TypeError("Expected argument 'permission_reference_lists' to be a list")
        pulumi.set(__self__, "permission_reference_lists", permission_reference_lists)
        if project_reference and not isinstance(project_reference, dict):
            raise TypeError("Expected argument 'project_reference' to be a dict")
        pulumi.set(__self__, "project_reference", project_reference)
        if role_id and not isinstance(role_id, str):
            raise TypeError("Expected argument 'role_id' to be a str")
        pulumi.set(__self__, "role_id", role_id)
        if role_name and not isinstance(role_name, str):
            raise TypeError("Expected argument 'role_name' to be a str")
        pulumi.set(__self__, "role_name", role_name)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        The version of the API.
        * `state`: - The state of the role.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def categories(self) -> Sequence['outputs.GetRoleCategoryResult']:
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
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownerReference")
    def owner_reference(self) -> Mapping[str, str]:
        return pulumi.get(self, "owner_reference")

    @property
    @pulumi.getter(name="permissionReferenceLists")
    def permission_reference_lists(self) -> Sequence['outputs.GetRolePermissionReferenceListResult']:
        return pulumi.get(self, "permission_reference_lists")

    @property
    @pulumi.getter(name="projectReference")
    def project_reference(self) -> Mapping[str, str]:
        return pulumi.get(self, "project_reference")

    @property
    @pulumi.getter(name="roleId")
    def role_id(self) -> Optional[str]:
        return pulumi.get(self, "role_id")

    @property
    @pulumi.getter(name="roleName")
    def role_name(self) -> Optional[str]:
        return pulumi.get(self, "role_name")

    @property
    @pulumi.getter
    def state(self) -> str:
        return pulumi.get(self, "state")


class AwaitableGetRoleResult(GetRoleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRoleResult(
            api_version=self.api_version,
            categories=self.categories,
            description=self.description,
            id=self.id,
            metadata=self.metadata,
            name=self.name,
            owner_reference=self.owner_reference,
            permission_reference_lists=self.permission_reference_lists,
            project_reference=self.project_reference,
            role_id=self.role_id,
            role_name=self.role_name,
            state=self.state)


def get_role(categories: Optional[Sequence[pulumi.InputType['GetRoleCategoryArgs']]] = None,
             role_id: Optional[str] = None,
             role_name: Optional[str] = None,
             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRoleResult:
    """
    Describes a Role.
    """
    __args__ = dict()
    __args__['categories'] = categories
    __args__['roleId'] = role_id
    __args__['roleName'] = role_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getRole:getRole', __args__, opts=opts, typ=GetRoleResult).value

    return AwaitableGetRoleResult(
        api_version=__ret__.api_version,
        categories=__ret__.categories,
        description=__ret__.description,
        id=__ret__.id,
        metadata=__ret__.metadata,
        name=__ret__.name,
        owner_reference=__ret__.owner_reference,
        permission_reference_lists=__ret__.permission_reference_lists,
        project_reference=__ret__.project_reference,
        role_id=__ret__.role_id,
        role_name=__ret__.role_name,
        state=__ret__.state)


@_utilities.lift_output_func(get_role)
def get_role_output(categories: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetRoleCategoryArgs']]]]] = None,
                    role_id: Optional[pulumi.Input[Optional[str]]] = None,
                    role_name: Optional[pulumi.Input[Optional[str]]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRoleResult]:
    """
    Describes a Role.
    """
    ...
