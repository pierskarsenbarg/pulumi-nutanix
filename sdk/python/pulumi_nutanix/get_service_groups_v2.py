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
    'GetServiceGroupsV2Result',
    'AwaitableGetServiceGroupsV2Result',
    'get_service_groups_v2',
    'get_service_groups_v2_output',
]

@pulumi.output_type
class GetServiceGroupsV2Result:
    """
    A collection of values returned by getServiceGroupsV2.
    """
    def __init__(__self__, filter=None, id=None, limit=None, order_by=None, page=None, select=None, service_groups=None):
        if filter and not isinstance(filter, str):
            raise TypeError("Expected argument 'filter' to be a str")
        pulumi.set(__self__, "filter", filter)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if limit and not isinstance(limit, int):
            raise TypeError("Expected argument 'limit' to be a int")
        pulumi.set(__self__, "limit", limit)
        if order_by and not isinstance(order_by, str):
            raise TypeError("Expected argument 'order_by' to be a str")
        pulumi.set(__self__, "order_by", order_by)
        if page and not isinstance(page, int):
            raise TypeError("Expected argument 'page' to be a int")
        pulumi.set(__self__, "page", page)
        if select and not isinstance(select, str):
            raise TypeError("Expected argument 'select' to be a str")
        pulumi.set(__self__, "select", select)
        if service_groups and not isinstance(service_groups, list):
            raise TypeError("Expected argument 'service_groups' to be a list")
        pulumi.set(__self__, "service_groups", service_groups)

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
    @pulumi.getter(name="orderBy")
    def order_by(self) -> Optional[builtins.str]:
        return pulumi.get(self, "order_by")

    @property
    @pulumi.getter
    def page(self) -> Optional[builtins.int]:
        return pulumi.get(self, "page")

    @property
    @pulumi.getter
    def select(self) -> Optional[builtins.str]:
        return pulumi.get(self, "select")

    @property
    @pulumi.getter(name="serviceGroups")
    def service_groups(self) -> Sequence['outputs.GetServiceGroupsV2ServiceGroupResult']:
        """
        List of service groups
        """
        return pulumi.get(self, "service_groups")


class AwaitableGetServiceGroupsV2Result(GetServiceGroupsV2Result):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetServiceGroupsV2Result(
            filter=self.filter,
            id=self.id,
            limit=self.limit,
            order_by=self.order_by,
            page=self.page,
            select=self.select,
            service_groups=self.service_groups)


def get_service_groups_v2(filter: Optional[builtins.str] = None,
                          limit: Optional[builtins.int] = None,
                          order_by: Optional[builtins.str] = None,
                          page: Optional[builtins.int] = None,
                          select: Optional[builtins.str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetServiceGroupsV2Result:
    """
    List all the service Groups.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    service_group = nutanix.get_service_groups_v2()
    service_group_filtered = nutanix.get_service_groups_v2(filter="name eq 'service_group_name'")
    ```


    :param builtins.str filter: A URL query parameter that allows clients to filter a collection of resources. The filter can be applied to the following fields:
           - `createdBy`
    :param builtins.int limit: A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
    :param builtins.str order_by: A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. The orderby can be applied to the following fields:
    :param builtins.int page: A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
    :param builtins.str select: A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. The select can be applied to the following fields:
           - `createdBy`
    """
    __args__ = dict()
    __args__['filter'] = filter
    __args__['limit'] = limit
    __args__['orderBy'] = order_by
    __args__['page'] = page
    __args__['select'] = select
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getServiceGroupsV2:getServiceGroupsV2', __args__, opts=opts, typ=GetServiceGroupsV2Result).value

    return AwaitableGetServiceGroupsV2Result(
        filter=pulumi.get(__ret__, 'filter'),
        id=pulumi.get(__ret__, 'id'),
        limit=pulumi.get(__ret__, 'limit'),
        order_by=pulumi.get(__ret__, 'order_by'),
        page=pulumi.get(__ret__, 'page'),
        select=pulumi.get(__ret__, 'select'),
        service_groups=pulumi.get(__ret__, 'service_groups'))
def get_service_groups_v2_output(filter: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                 limit: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                                 order_by: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                 page: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                                 select: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                 opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetServiceGroupsV2Result]:
    """
    List all the service Groups.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    service_group = nutanix.get_service_groups_v2()
    service_group_filtered = nutanix.get_service_groups_v2(filter="name eq 'service_group_name'")
    ```


    :param builtins.str filter: A URL query parameter that allows clients to filter a collection of resources. The filter can be applied to the following fields:
           - `createdBy`
    :param builtins.int limit: A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
    :param builtins.str order_by: A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. The orderby can be applied to the following fields:
    :param builtins.int page: A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
    :param builtins.str select: A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions. The select can be applied to the following fields:
           - `createdBy`
    """
    __args__ = dict()
    __args__['filter'] = filter
    __args__['limit'] = limit
    __args__['orderBy'] = order_by
    __args__['page'] = page
    __args__['select'] = select
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getServiceGroupsV2:getServiceGroupsV2', __args__, opts=opts, typ=GetServiceGroupsV2Result)
    return __ret__.apply(lambda __response__: GetServiceGroupsV2Result(
        filter=pulumi.get(__response__, 'filter'),
        id=pulumi.get(__response__, 'id'),
        limit=pulumi.get(__response__, 'limit'),
        order_by=pulumi.get(__response__, 'order_by'),
        page=pulumi.get(__response__, 'page'),
        select=pulumi.get(__response__, 'select'),
        service_groups=pulumi.get(__response__, 'service_groups')))
