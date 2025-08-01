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

__all__ = [
    'GetImageV2Result',
    'AwaitableGetImageV2Result',
    'get_image_v2',
    'get_image_v2_output',
]

@pulumi.output_type
class GetImageV2Result:
    """
    A collection of values returned by getImageV2.
    """
    def __init__(__self__, category_ext_ids=None, checksums=None, cluster_location_ext_ids=None, create_time=None, description=None, ext_id=None, id=None, last_update_time=None, name=None, owner_ext_id=None, placement_policy_statuses=None, size_bytes=None, sources=None, type=None):
        if category_ext_ids and not isinstance(category_ext_ids, list):
            raise TypeError("Expected argument 'category_ext_ids' to be a list")
        pulumi.set(__self__, "category_ext_ids", category_ext_ids)
        if checksums and not isinstance(checksums, list):
            raise TypeError("Expected argument 'checksums' to be a list")
        pulumi.set(__self__, "checksums", checksums)
        if cluster_location_ext_ids and not isinstance(cluster_location_ext_ids, list):
            raise TypeError("Expected argument 'cluster_location_ext_ids' to be a list")
        pulumi.set(__self__, "cluster_location_ext_ids", cluster_location_ext_ids)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if ext_id and not isinstance(ext_id, str):
            raise TypeError("Expected argument 'ext_id' to be a str")
        pulumi.set(__self__, "ext_id", ext_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if last_update_time and not isinstance(last_update_time, str):
            raise TypeError("Expected argument 'last_update_time' to be a str")
        pulumi.set(__self__, "last_update_time", last_update_time)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if owner_ext_id and not isinstance(owner_ext_id, str):
            raise TypeError("Expected argument 'owner_ext_id' to be a str")
        pulumi.set(__self__, "owner_ext_id", owner_ext_id)
        if placement_policy_statuses and not isinstance(placement_policy_statuses, list):
            raise TypeError("Expected argument 'placement_policy_statuses' to be a list")
        pulumi.set(__self__, "placement_policy_statuses", placement_policy_statuses)
        if size_bytes and not isinstance(size_bytes, int):
            raise TypeError("Expected argument 'size_bytes' to be a int")
        pulumi.set(__self__, "size_bytes", size_bytes)
        if sources and not isinstance(sources, list):
            raise TypeError("Expected argument 'sources' to be a list")
        pulumi.set(__self__, "sources", sources)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="categoryExtIds")
    def category_ext_ids(self) -> Sequence[builtins.str]:
        """
        List of category external identifiers for an image.
        """
        return pulumi.get(self, "category_ext_ids")

    @property
    @pulumi.getter
    def checksums(self) -> Sequence['outputs.GetImageV2ChecksumResult']:
        """
        The checksum of an image.
        """
        return pulumi.get(self, "checksums")

    @property
    @pulumi.getter(name="clusterLocationExtIds")
    def cluster_location_ext_ids(self) -> Sequence[builtins.str]:
        """
        List of cluster external identifiers where the image is located.
        """
        return pulumi.get(self, "cluster_location_ext_ids")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> builtins.str:
        """
        Create time of an image.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> builtins.str:
        """
        The user defined description of an image.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> builtins.str:
        """
        The external identifier of VM Disk.
        """
        return pulumi.get(self, "ext_id")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="lastUpdateTime")
    def last_update_time(self) -> builtins.str:
        """
        Last update time of an image.
        """
        return pulumi.get(self, "last_update_time")

    @property
    @pulumi.getter
    def name(self) -> builtins.str:
        """
        The user defined name of an image.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownerExtId")
    def owner_ext_id(self) -> builtins.str:
        """
        External identifier of the owner of the image
        """
        return pulumi.get(self, "owner_ext_id")

    @property
    @pulumi.getter(name="placementPolicyStatuses")
    def placement_policy_statuses(self) -> Sequence['outputs.GetImageV2PlacementPolicyStatusResult']:
        """
        Status of an image placement policy.
        """
        return pulumi.get(self, "placement_policy_statuses")

    @property
    @pulumi.getter(name="sizeBytes")
    def size_bytes(self) -> builtins.int:
        """
        The size in bytes of an image file.
        """
        return pulumi.get(self, "size_bytes")

    @property
    @pulumi.getter
    def sources(self) -> Sequence['outputs.GetImageV2SourceResult']:
        """
        The source of an image. It can be a VM disk or a URL.
        """
        return pulumi.get(self, "sources")

    @property
    @pulumi.getter
    def type(self) -> builtins.str:
        """
        The type of an image.
        """
        return pulumi.get(self, "type")


class AwaitableGetImageV2Result(GetImageV2Result):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetImageV2Result(
            category_ext_ids=self.category_ext_ids,
            checksums=self.checksums,
            cluster_location_ext_ids=self.cluster_location_ext_ids,
            create_time=self.create_time,
            description=self.description,
            ext_id=self.ext_id,
            id=self.id,
            last_update_time=self.last_update_time,
            name=self.name,
            owner_ext_id=self.owner_ext_id,
            placement_policy_statuses=self.placement_policy_statuses,
            size_bytes=self.size_bytes,
            sources=self.sources,
            type=self.type)


def get_image_v2(ext_id: Optional[builtins.str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetImageV2Result:
    """
    Retrieve the image details for the provided external identifier.

    ## Example

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    get_image = nutanix.get_image_v2(ext_id="0005a7b1-0b3b-4b3b-8b3b-0b3b4b3b4b3b")
    ```


    :param builtins.str ext_id: The external identifier of an image.
    """
    __args__ = dict()
    __args__['extId'] = ext_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getImageV2:getImageV2', __args__, opts=opts, typ=GetImageV2Result).value

    return AwaitableGetImageV2Result(
        category_ext_ids=pulumi.get(__ret__, 'category_ext_ids'),
        checksums=pulumi.get(__ret__, 'checksums'),
        cluster_location_ext_ids=pulumi.get(__ret__, 'cluster_location_ext_ids'),
        create_time=pulumi.get(__ret__, 'create_time'),
        description=pulumi.get(__ret__, 'description'),
        ext_id=pulumi.get(__ret__, 'ext_id'),
        id=pulumi.get(__ret__, 'id'),
        last_update_time=pulumi.get(__ret__, 'last_update_time'),
        name=pulumi.get(__ret__, 'name'),
        owner_ext_id=pulumi.get(__ret__, 'owner_ext_id'),
        placement_policy_statuses=pulumi.get(__ret__, 'placement_policy_statuses'),
        size_bytes=pulumi.get(__ret__, 'size_bytes'),
        sources=pulumi.get(__ret__, 'sources'),
        type=pulumi.get(__ret__, 'type'))
def get_image_v2_output(ext_id: Optional[pulumi.Input[builtins.str]] = None,
                        opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetImageV2Result]:
    """
    Retrieve the image details for the provided external identifier.

    ## Example

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    get_image = nutanix.get_image_v2(ext_id="0005a7b1-0b3b-4b3b-8b3b-0b3b4b3b4b3b")
    ```


    :param builtins.str ext_id: The external identifier of an image.
    """
    __args__ = dict()
    __args__['extId'] = ext_id
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getImageV2:getImageV2', __args__, opts=opts, typ=GetImageV2Result)
    return __ret__.apply(lambda __response__: GetImageV2Result(
        category_ext_ids=pulumi.get(__response__, 'category_ext_ids'),
        checksums=pulumi.get(__response__, 'checksums'),
        cluster_location_ext_ids=pulumi.get(__response__, 'cluster_location_ext_ids'),
        create_time=pulumi.get(__response__, 'create_time'),
        description=pulumi.get(__response__, 'description'),
        ext_id=pulumi.get(__response__, 'ext_id'),
        id=pulumi.get(__response__, 'id'),
        last_update_time=pulumi.get(__response__, 'last_update_time'),
        name=pulumi.get(__response__, 'name'),
        owner_ext_id=pulumi.get(__response__, 'owner_ext_id'),
        placement_policy_statuses=pulumi.get(__response__, 'placement_policy_statuses'),
        size_bytes=pulumi.get(__response__, 'size_bytes'),
        sources=pulumi.get(__response__, 'sources'),
        type=pulumi.get(__response__, 'type')))
