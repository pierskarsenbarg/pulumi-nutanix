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
    'GetFoundationCentralListApiKeysResult',
    'AwaitableGetFoundationCentralListApiKeysResult',
    'get_foundation_central_list_api_keys',
    'get_foundation_central_list_api_keys_output',
]

@pulumi.output_type
class GetFoundationCentralListApiKeysResult:
    """
    A collection of values returned by getFoundationCentralListApiKeys.
    """
    def __init__(__self__, api_keys=None, id=None, length=None, metadata=None, offset=None):
        if api_keys and not isinstance(api_keys, list):
            raise TypeError("Expected argument 'api_keys' to be a list")
        pulumi.set(__self__, "api_keys", api_keys)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if length and not isinstance(length, int):
            raise TypeError("Expected argument 'length' to be a int")
        pulumi.set(__self__, "length", length)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if offset and not isinstance(offset, int):
            raise TypeError("Expected argument 'offset' to be a int")
        pulumi.set(__self__, "offset", offset)

    @property
    @pulumi.getter(name="apiKeys")
    def api_keys(self) -> Sequence['outputs.GetFoundationCentralListApiKeysApiKeyResult']:
        return pulumi.get(self, "api_keys")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def length(self) -> Optional[int]:
        return pulumi.get(self, "length")

    @property
    @pulumi.getter
    def metadata(self) -> Optional['outputs.GetFoundationCentralListApiKeysMetadataResult']:
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def offset(self) -> Optional[int]:
        return pulumi.get(self, "offset")


class AwaitableGetFoundationCentralListApiKeysResult(GetFoundationCentralListApiKeysResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFoundationCentralListApiKeysResult(
            api_keys=self.api_keys,
            id=self.id,
            length=self.length,
            metadata=self.metadata,
            offset=self.offset)


def get_foundation_central_list_api_keys(length: Optional[int] = None,
                                         metadata: Optional[pulumi.InputType['GetFoundationCentralListApiKeysMetadataArgs']] = None,
                                         offset: Optional[int] = None,
                                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFoundationCentralListApiKeysResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['length'] = length
    __args__['metadata'] = metadata
    __args__['offset'] = offset
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getFoundationCentralListApiKeys:getFoundationCentralListApiKeys', __args__, opts=opts, typ=GetFoundationCentralListApiKeysResult).value

    return AwaitableGetFoundationCentralListApiKeysResult(
        api_keys=__ret__.api_keys,
        id=__ret__.id,
        length=__ret__.length,
        metadata=__ret__.metadata,
        offset=__ret__.offset)


@_utilities.lift_output_func(get_foundation_central_list_api_keys)
def get_foundation_central_list_api_keys_output(length: Optional[pulumi.Input[Optional[int]]] = None,
                                                metadata: Optional[pulumi.Input[Optional[pulumi.InputType['GetFoundationCentralListApiKeysMetadataArgs']]]] = None,
                                                offset: Optional[pulumi.Input[Optional[int]]] = None,
                                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetFoundationCentralListApiKeysResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
