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
    'GetFoundationCentralImagedClustersListResult',
    'AwaitableGetFoundationCentralImagedClustersListResult',
    'get_foundation_central_imaged_clusters_list',
    'get_foundation_central_imaged_clusters_list_output',
]

@pulumi.output_type
class GetFoundationCentralImagedClustersListResult:
    """
    A collection of values returned by getFoundationCentralImagedClustersList.
    """
    def __init__(__self__, filters=None, id=None, imaged_clusters=None, length=None, metadatas=None, offset=None):
        if filters and not isinstance(filters, dict):
            raise TypeError("Expected argument 'filters' to be a dict")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if imaged_clusters and not isinstance(imaged_clusters, list):
            raise TypeError("Expected argument 'imaged_clusters' to be a list")
        pulumi.set(__self__, "imaged_clusters", imaged_clusters)
        if length and not isinstance(length, int):
            raise TypeError("Expected argument 'length' to be a int")
        pulumi.set(__self__, "length", length)
        if metadatas and not isinstance(metadatas, list):
            raise TypeError("Expected argument 'metadatas' to be a list")
        pulumi.set(__self__, "metadatas", metadatas)
        if offset and not isinstance(offset, int):
            raise TypeError("Expected argument 'offset' to be a int")
        pulumi.set(__self__, "offset", offset)

    @property
    @pulumi.getter
    def filters(self) -> Optional['outputs.GetFoundationCentralImagedClustersListFiltersResult']:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="imagedClusters")
    def imaged_clusters(self) -> Sequence['outputs.GetFoundationCentralImagedClustersListImagedClusterResult']:
        return pulumi.get(self, "imaged_clusters")

    @property
    @pulumi.getter
    def length(self) -> Optional[int]:
        return pulumi.get(self, "length")

    @property
    @pulumi.getter
    def metadatas(self) -> Sequence['outputs.GetFoundationCentralImagedClustersListMetadataResult']:
        return pulumi.get(self, "metadatas")

    @property
    @pulumi.getter
    def offset(self) -> Optional[int]:
        return pulumi.get(self, "offset")


class AwaitableGetFoundationCentralImagedClustersListResult(GetFoundationCentralImagedClustersListResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFoundationCentralImagedClustersListResult(
            filters=self.filters,
            id=self.id,
            imaged_clusters=self.imaged_clusters,
            length=self.length,
            metadatas=self.metadatas,
            offset=self.offset)


def get_foundation_central_imaged_clusters_list(filters: Optional[pulumi.InputType['GetFoundationCentralImagedClustersListFiltersArgs']] = None,
                                                length: Optional[int] = None,
                                                offset: Optional[int] = None,
                                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFoundationCentralImagedClustersListResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['filters'] = filters
    __args__['length'] = length
    __args__['offset'] = offset
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
    __ret__ = pulumi.runtime.invoke('nutanix:index/getFoundationCentralImagedClustersList:getFoundationCentralImagedClustersList', __args__, opts=opts, typ=GetFoundationCentralImagedClustersListResult).value

    return AwaitableGetFoundationCentralImagedClustersListResult(
        filters=__ret__.filters,
        id=__ret__.id,
        imaged_clusters=__ret__.imaged_clusters,
        length=__ret__.length,
        metadatas=__ret__.metadatas,
        offset=__ret__.offset)


@_utilities.lift_output_func(get_foundation_central_imaged_clusters_list)
def get_foundation_central_imaged_clusters_list_output(filters: Optional[pulumi.Input[Optional[pulumi.InputType['GetFoundationCentralImagedClustersListFiltersArgs']]]] = None,
                                                       length: Optional[pulumi.Input[Optional[int]]] = None,
                                                       offset: Optional[pulumi.Input[Optional[int]]] = None,
                                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetFoundationCentralImagedClustersListResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
