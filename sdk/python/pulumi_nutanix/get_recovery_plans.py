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
    'GetRecoveryPlansResult',
    'AwaitableGetRecoveryPlansResult',
    'get_recovery_plans',
    'get_recovery_plans_output',
]

@pulumi.output_type
class GetRecoveryPlansResult:
    """
    A collection of values returned by getRecoveryPlans.
    """
    def __init__(__self__, api_version=None, entities=None, id=None):
        if api_version and not isinstance(api_version, str):
            raise TypeError("Expected argument 'api_version' to be a str")
        pulumi.set(__self__, "api_version", api_version)
        if entities and not isinstance(entities, list):
            raise TypeError("Expected argument 'entities' to be a list")
        pulumi.set(__self__, "entities", entities)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> builtins.str:
        """
        version of the API
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def entities(self) -> Sequence['outputs.GetRecoveryPlansEntityResult']:
        """
        List of Recovery Plans
        """
        return pulumi.get(self, "entities")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")


class AwaitableGetRecoveryPlansResult(GetRecoveryPlansResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRecoveryPlansResult(
            api_version=self.api_version,
            entities=self.entities,
            id=self.id)


def get_recovery_plans(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRecoveryPlansResult:
    """
    Describes Recovery Plans

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    recovery_plans = nutanix.get_recovery_plans()
    ```
    """
    __args__ = dict()
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getRecoveryPlans:getRecoveryPlans', __args__, opts=opts, typ=GetRecoveryPlansResult).value

    return AwaitableGetRecoveryPlansResult(
        api_version=pulumi.get(__ret__, 'api_version'),
        entities=pulumi.get(__ret__, 'entities'),
        id=pulumi.get(__ret__, 'id'))
def get_recovery_plans_output(opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetRecoveryPlansResult]:
    """
    Describes Recovery Plans

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nutanix as nutanix

    recovery_plans = nutanix.get_recovery_plans()
    ```
    """
    __args__ = dict()
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getRecoveryPlans:getRecoveryPlans', __args__, opts=opts, typ=GetRecoveryPlansResult)
    return __ret__.apply(lambda __response__: GetRecoveryPlansResult(
        api_version=pulumi.get(__response__, 'api_version'),
        entities=pulumi.get(__response__, 'entities'),
        id=pulumi.get(__response__, 'id')))
