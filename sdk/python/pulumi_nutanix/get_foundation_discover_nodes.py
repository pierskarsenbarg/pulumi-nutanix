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
    'GetFoundationDiscoverNodesResult',
    'AwaitableGetFoundationDiscoverNodesResult',
    'get_foundation_discover_nodes',
]

@pulumi.output_type
class GetFoundationDiscoverNodesResult:
    """
    A collection of values returned by getFoundationDiscoverNodes.
    """
    def __init__(__self__, entities=None, id=None):
        if entities and not isinstance(entities, list):
            raise TypeError("Expected argument 'entities' to be a list")
        pulumi.set(__self__, "entities", entities)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def entities(self) -> Sequence['outputs.GetFoundationDiscoverNodesEntityResult']:
        return pulumi.get(self, "entities")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")


class AwaitableGetFoundationDiscoverNodesResult(GetFoundationDiscoverNodesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFoundationDiscoverNodesResult(
            entities=self.entities,
            id=self.id)


def get_foundation_discover_nodes(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFoundationDiscoverNodesResult:
    """
    Discovers and lists Nutanix-imaged nodes within an IPv6 network.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    discovered_nodes = nutanix.get_foundation_discover_nodes()
    ```
    """
    __args__ = dict()
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getFoundationDiscoverNodes:getFoundationDiscoverNodes', __args__, opts=opts, typ=GetFoundationDiscoverNodesResult).value

    return AwaitableGetFoundationDiscoverNodesResult(
        entities=__ret__.entities,
        id=__ret__.id)