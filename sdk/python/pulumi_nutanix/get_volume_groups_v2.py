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
    'GetVolumeGroupsV2Result',
    'AwaitableGetVolumeGroupsV2Result',
    'get_volume_groups_v2',
    'get_volume_groups_v2_output',
]

@pulumi.output_type
class GetVolumeGroupsV2Result:
    """
    A collection of values returned by getVolumeGroupsV2.
    """
    def __init__(__self__, expand=None, filter=None, id=None, limit=None, orderby=None, page=None, select=None, volumes=None):
        if expand and not isinstance(expand, str):
            raise TypeError("Expected argument 'expand' to be a str")
        pulumi.set(__self__, "expand", expand)
        if filter and not isinstance(filter, str):
            raise TypeError("Expected argument 'filter' to be a str")
        pulumi.set(__self__, "filter", filter)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if limit and not isinstance(limit, int):
            raise TypeError("Expected argument 'limit' to be a int")
        pulumi.set(__self__, "limit", limit)
        if orderby and not isinstance(orderby, str):
            raise TypeError("Expected argument 'orderby' to be a str")
        pulumi.set(__self__, "orderby", orderby)
        if page and not isinstance(page, int):
            raise TypeError("Expected argument 'page' to be a int")
        pulumi.set(__self__, "page", page)
        if select and not isinstance(select, str):
            raise TypeError("Expected argument 'select' to be a str")
        pulumi.set(__self__, "select", select)
        if volumes and not isinstance(volumes, list):
            raise TypeError("Expected argument 'volumes' to be a list")
        pulumi.set(__self__, "volumes", volumes)

    @property
    @pulumi.getter
    def expand(self) -> Optional[builtins.str]:
        return pulumi.get(self, "expand")

    @property
    @pulumi.getter
    def filter(self) -> Optional[builtins.str]:
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def limit(self) -> Optional[builtins.int]:
        return pulumi.get(self, "limit")

    @property
    @pulumi.getter
    def orderby(self) -> Optional[builtins.str]:
        return pulumi.get(self, "orderby")

    @property
    @pulumi.getter
    def page(self) -> Optional[builtins.int]:
        return pulumi.get(self, "page")

    @property
    @pulumi.getter
    def select(self) -> Optional[builtins.str]:
        return pulumi.get(self, "select")

    @property
    @pulumi.getter
    def volumes(self) -> Sequence['outputs.GetVolumeGroupsV2VolumeResult']:
        return pulumi.get(self, "volumes")


class AwaitableGetVolumeGroupsV2Result(GetVolumeGroupsV2Result):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVolumeGroupsV2Result(
            expand=self.expand,
            filter=self.filter,
            id=self.id,
            limit=self.limit,
            orderby=self.orderby,
            page=self.page,
            select=self.select,
            volumes=self.volumes)


def get_volume_groups_v2(expand: Optional[builtins.str] = None,
                         filter: Optional[builtins.str] = None,
                         limit: Optional[builtins.int] = None,
                         orderby: Optional[builtins.str] = None,
                         page: Optional[builtins.int] = None,
                         select: Optional[builtins.str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVolumeGroupsV2Result:
    """
    Describes a List all the Volume Groups.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    volume_groups = nutanix.get_volume_groups_v2()
    vg_pagination = nutanix.get_volume_groups_v2(limit=10,
        page=1)
    vg_filter = nutanix.get_volume_groups_v2(filter="name eq 'volume_group_test'")
    ```

    ## Argument Reference

    The following arguments are supported:

    * `page`: - A query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource.
    * `limit` : A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
    * `filter` : A URL query parameter that allows clients to filter a collection of resources. The expression specified with \\$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \\$filter must conform to the OData V4.01 URL conventions. For example, filter '\\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
      - clusterReference
      - extId
      - name
    * `orderby` : A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
      - clusterReference
      - extId
      - name
    * `expand` : A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \\$filter, \\$select and \\$orderby. The following expansion keys are supported. The expand can be applied to the following fields:
      - clusterReference
      - metadata
    * `select` : A query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \\$select must conform to the OData V4.01 URL conventions. If a \\$select expression consists of a single select item that is an asterisk (i.e., \\*), then all properties on the matching resource will be returned. The select can be applied to the following fields:
      - clusterReference
      - extId
      - name

    ## Volume Groups

    The `volume_groups` contains list of Volume Groups. Each Volume Group contains the following attributes:

    * `tenant_id`: - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
    * `ext_id`: - A globally unique identifier of an instance that is suitable for external consumption.
    * `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
    * `name`: -(Required) Volume Group name. This is an optional field.
    * `description`: - Volume Group description. This is an optional field.
    * `should_load_balance_vm_attachments`: - Indicates whether to enable Volume Group load balancing for VM attachments. This cannot be enabled if there are iSCSI client attachments already associated with the Volume Group, and vice-versa. This is an optional field.
    * `sharing_status`: - Indicates whether the Volume Group can be shared across multiple iSCSI initiators. The mode cannot be changed from SHARED to NOT_SHARED on a Volume Group with multiple attachments. Similarly, a Volume Group cannot be associated with more than one attachment as long as it is in exclusive mode. This is an optional field. Valid values are SHARED, NOT_SHARED
    * `target_name`: - Name of the external client target that will be visible and accessible to the client.
    * `enabled_authentications`: - The authentication type enabled for the Volume Group. Valid values are CHAP, NONE
    * `iscsi_features`: - iSCSI specific settings for the Volume Group.
    * `created_by`: - Service/user who created this Volume Group.
    * `cluster_reference`: - The UUID of the cluster that will host the Volume Group.
    * `storage_features`: - Storage optimization features which must be enabled on the Volume Group.
    * `usage_type`: - Expected usage type for the Volume Group. This is an indicative hint on how the caller will consume the Volume Group.  Valid values are BACKUP_TARGET, INTERNAL, TEMPORARY, USER
    * `is_hidden`: - Indicates whether the Volume Group is meant to be hidden or not.

    #### Links

    The links attribute supports the following:

    * `href`: - The URL at which the entity described by the link can be accessed.
    * `rel`: - A name that identifies the relationship of the link to the object that is returned by the URL. The unique value of "self" identifies the URL for the object.

    #### Iscsi Features

    The iscsi_features attribute supports the following:

    * `enabled_authentications`: - The authentication type enabled for the Volume Group.

    #### Storage Features

    The storage features attribute supports the following:

    * `flash_mode`: - this field will avoid down migration of data from the hot tier unless the overrides field is specified for the virtual disks.

    ##### Flash Mode

    The flash mode features attribute supports the following:

    * `is_enabled`: - Indicates whether the flash mode is enabled for the Volume Group.

    See detailed information in [Nutanix List Volume Groups V4](https://developers.nutanix.com/api-reference?namespace=volumes&version=v4.0#tag/VolumeGroups/operation/listVolumeGroups).
    """
    __args__ = dict()
    __args__['expand'] = expand
    __args__['filter'] = filter
    __args__['limit'] = limit
    __args__['orderby'] = orderby
    __args__['page'] = page
    __args__['select'] = select
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getVolumeGroupsV2:getVolumeGroupsV2', __args__, opts=opts, typ=GetVolumeGroupsV2Result).value

    return AwaitableGetVolumeGroupsV2Result(
        expand=pulumi.get(__ret__, 'expand'),
        filter=pulumi.get(__ret__, 'filter'),
        id=pulumi.get(__ret__, 'id'),
        limit=pulumi.get(__ret__, 'limit'),
        orderby=pulumi.get(__ret__, 'orderby'),
        page=pulumi.get(__ret__, 'page'),
        select=pulumi.get(__ret__, 'select'),
        volumes=pulumi.get(__ret__, 'volumes'))
def get_volume_groups_v2_output(expand: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                filter: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                limit: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                                orderby: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                page: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                                select: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetVolumeGroupsV2Result]:
    """
    Describes a List all the Volume Groups.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    volume_groups = nutanix.get_volume_groups_v2()
    vg_pagination = nutanix.get_volume_groups_v2(limit=10,
        page=1)
    vg_filter = nutanix.get_volume_groups_v2(filter="name eq 'volume_group_test'")
    ```

    ## Argument Reference

    The following arguments are supported:

    * `page`: - A query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource.
    * `limit` : A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
    * `filter` : A URL query parameter that allows clients to filter a collection of resources. The expression specified with \\$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \\$filter must conform to the OData V4.01 URL conventions. For example, filter '\\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
      - clusterReference
      - extId
      - name
    * `orderby` : A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
      - clusterReference
      - extId
      - name
    * `expand` : A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \\$filter, \\$select and \\$orderby. The following expansion keys are supported. The expand can be applied to the following fields:
      - clusterReference
      - metadata
    * `select` : A query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \\$select must conform to the OData V4.01 URL conventions. If a \\$select expression consists of a single select item that is an asterisk (i.e., \\*), then all properties on the matching resource will be returned. The select can be applied to the following fields:
      - clusterReference
      - extId
      - name

    ## Volume Groups

    The `volume_groups` contains list of Volume Groups. Each Volume Group contains the following attributes:

    * `tenant_id`: - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
    * `ext_id`: - A globally unique identifier of an instance that is suitable for external consumption.
    * `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
    * `name`: -(Required) Volume Group name. This is an optional field.
    * `description`: - Volume Group description. This is an optional field.
    * `should_load_balance_vm_attachments`: - Indicates whether to enable Volume Group load balancing for VM attachments. This cannot be enabled if there are iSCSI client attachments already associated with the Volume Group, and vice-versa. This is an optional field.
    * `sharing_status`: - Indicates whether the Volume Group can be shared across multiple iSCSI initiators. The mode cannot be changed from SHARED to NOT_SHARED on a Volume Group with multiple attachments. Similarly, a Volume Group cannot be associated with more than one attachment as long as it is in exclusive mode. This is an optional field. Valid values are SHARED, NOT_SHARED
    * `target_name`: - Name of the external client target that will be visible and accessible to the client.
    * `enabled_authentications`: - The authentication type enabled for the Volume Group. Valid values are CHAP, NONE
    * `iscsi_features`: - iSCSI specific settings for the Volume Group.
    * `created_by`: - Service/user who created this Volume Group.
    * `cluster_reference`: - The UUID of the cluster that will host the Volume Group.
    * `storage_features`: - Storage optimization features which must be enabled on the Volume Group.
    * `usage_type`: - Expected usage type for the Volume Group. This is an indicative hint on how the caller will consume the Volume Group.  Valid values are BACKUP_TARGET, INTERNAL, TEMPORARY, USER
    * `is_hidden`: - Indicates whether the Volume Group is meant to be hidden or not.

    #### Links

    The links attribute supports the following:

    * `href`: - The URL at which the entity described by the link can be accessed.
    * `rel`: - A name that identifies the relationship of the link to the object that is returned by the URL. The unique value of "self" identifies the URL for the object.

    #### Iscsi Features

    The iscsi_features attribute supports the following:

    * `enabled_authentications`: - The authentication type enabled for the Volume Group.

    #### Storage Features

    The storage features attribute supports the following:

    * `flash_mode`: - this field will avoid down migration of data from the hot tier unless the overrides field is specified for the virtual disks.

    ##### Flash Mode

    The flash mode features attribute supports the following:

    * `is_enabled`: - Indicates whether the flash mode is enabled for the Volume Group.

    See detailed information in [Nutanix List Volume Groups V4](https://developers.nutanix.com/api-reference?namespace=volumes&version=v4.0#tag/VolumeGroups/operation/listVolumeGroups).
    """
    __args__ = dict()
    __args__['expand'] = expand
    __args__['filter'] = filter
    __args__['limit'] = limit
    __args__['orderby'] = orderby
    __args__['page'] = page
    __args__['select'] = select
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getVolumeGroupsV2:getVolumeGroupsV2', __args__, opts=opts, typ=GetVolumeGroupsV2Result)
    return __ret__.apply(lambda __response__: GetVolumeGroupsV2Result(
        expand=pulumi.get(__response__, 'expand'),
        filter=pulumi.get(__response__, 'filter'),
        id=pulumi.get(__response__, 'id'),
        limit=pulumi.get(__response__, 'limit'),
        orderby=pulumi.get(__response__, 'orderby'),
        page=pulumi.get(__response__, 'page'),
        select=pulumi.get(__response__, 'select'),
        volumes=pulumi.get(__response__, 'volumes')))
