# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetKarbonPrivateRegistriesResult',
    'AwaitableGetKarbonPrivateRegistriesResult',
    'get_karbon_private_registries',
]

@pulumi.output_type
class GetKarbonPrivateRegistriesResult:
    """
    A collection of values returned by getKarbonPrivateRegistries.
    """
    def __init__(__self__, id=None, private_registries=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if private_registries and not isinstance(private_registries, list):
            raise TypeError("Expected argument 'private_registries' to be a list")
        pulumi.set(__self__, "private_registries", private_registries)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="privateRegistries")
    def private_registries(self) -> Sequence['outputs.GetKarbonPrivateRegistriesPrivateRegistryResult']:
        return pulumi.get(self, "private_registries")


class AwaitableGetKarbonPrivateRegistriesResult(GetKarbonPrivateRegistriesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetKarbonPrivateRegistriesResult(
            id=self.id,
            private_registries=self.private_registries)


def get_karbon_private_registries(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetKarbonPrivateRegistriesResult:
    """
    Describes a List of Karbon private registry entry

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    registry = nutanix.get_karbon_private_registries()
    ```
    """
    __args__ = dict()
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getKarbonPrivateRegistries:getKarbonPrivateRegistries', __args__, opts=opts, typ=GetKarbonPrivateRegistriesResult).value

    return AwaitableGetKarbonPrivateRegistriesResult(
        id=__ret__.id,
        private_registries=__ret__.private_registries)
