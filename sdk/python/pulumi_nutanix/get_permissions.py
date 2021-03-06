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
    'GetPermissionsResult',
    'AwaitableGetPermissionsResult',
    'get_permissions',
    'get_permissions_output',
]

@pulumi.output_type
class GetPermissionsResult:
    """
    A collection of values returned by getPermissions.
    """
    def __init__(__self__, api_version=None, entities=None, id=None, metadatas=None):
        if api_version and not isinstance(api_version, str):
            raise TypeError("Expected argument 'api_version' to be a str")
        pulumi.set(__self__, "api_version", api_version)
        if entities and not isinstance(entities, list):
            raise TypeError("Expected argument 'entities' to be a list")
        pulumi.set(__self__, "entities", entities)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if metadatas and not isinstance(metadatas, list):
            raise TypeError("Expected argument 'metadatas' to be a list")
        pulumi.set(__self__, "metadatas", metadatas)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def entities(self) -> Sequence['outputs.GetPermissionsEntityResult']:
        return pulumi.get(self, "entities")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def metadatas(self) -> Sequence['outputs.GetPermissionsMetadataResult']:
        return pulumi.get(self, "metadatas")


class AwaitableGetPermissionsResult(GetPermissionsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetPermissionsResult(
            api_version=self.api_version,
            entities=self.entities,
            id=self.id,
            metadatas=self.metadatas)


def get_permissions(metadatas: Optional[Sequence[pulumi.InputType['GetPermissionsMetadataArgs']]] = None,
                    opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetPermissionsResult:
    """
    Provides a datasource to retrieve all the permissions.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    permissions = nutanix.get_permission()
    ```
    """
    __args__ = dict()
    __args__['metadatas'] = metadatas
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getPermissions:getPermissions', __args__, opts=opts, typ=GetPermissionsResult).value

    return AwaitableGetPermissionsResult(
        api_version=__ret__.api_version,
        entities=__ret__.entities,
        id=__ret__.id,
        metadatas=__ret__.metadatas)


@_utilities.lift_output_func(get_permissions)
def get_permissions_output(metadatas: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetPermissionsMetadataArgs']]]]] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetPermissionsResult]:
    """
    Provides a datasource to retrieve all the permissions.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    permissions = nutanix.get_permission()
    ```
    """
    ...
