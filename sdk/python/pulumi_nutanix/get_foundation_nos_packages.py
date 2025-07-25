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

__all__ = [
    'GetFoundationNosPackagesResult',
    'AwaitableGetFoundationNosPackagesResult',
    'get_foundation_nos_packages',
    'get_foundation_nos_packages_output',
]

@pulumi.output_type
class GetFoundationNosPackagesResult:
    """
    A collection of values returned by getFoundationNosPackages.
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
    def entities(self) -> Sequence[builtins.str]:
        """
        List of nos packages file names present in foundation vm
        """
        return pulumi.get(self, "entities")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")


class AwaitableGetFoundationNosPackagesResult(GetFoundationNosPackagesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFoundationNosPackagesResult(
            entities=self.entities,
            id=self.id)


def get_foundation_nos_packages(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFoundationNosPackagesResult:
    """
    Describes a list of nos (aos) packages present in foundation vm

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    nos_packages = nutanix.get_foundation_nos_packages()
    ```

    ## Note

    * This data source only lists .tar file names.

    See detailed information in [Nutanix Foundation Nos Packages](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjMzODg-get-list-of-aos-packages-available-in-foundation).
    """
    __args__ = dict()
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getFoundationNosPackages:getFoundationNosPackages', __args__, opts=opts, typ=GetFoundationNosPackagesResult).value

    return AwaitableGetFoundationNosPackagesResult(
        entities=pulumi.get(__ret__, 'entities'),
        id=pulumi.get(__ret__, 'id'))
def get_foundation_nos_packages_output(opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetFoundationNosPackagesResult]:
    """
    Describes a list of nos (aos) packages present in foundation vm

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    nos_packages = nutanix.get_foundation_nos_packages()
    ```

    ## Note

    * This data source only lists .tar file names.

    See detailed information in [Nutanix Foundation Nos Packages](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjMzODg-get-list-of-aos-packages-available-in-foundation).
    """
    __args__ = dict()
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getFoundationNosPackages:getFoundationNosPackages', __args__, opts=opts, typ=GetFoundationNosPackagesResult)
    return __ret__.apply(lambda __response__: GetFoundationNosPackagesResult(
        entities=pulumi.get(__response__, 'entities'),
        id=pulumi.get(__response__, 'id')))
