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

__all__ = ['AddressGroupArgs', 'AddressGroup']

@pulumi.input_type
class AddressGroupArgs:
    def __init__(__self__, *,
                 ip_address_block_lists: pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AddressGroup resource.
        """
        pulumi.set(__self__, "ip_address_block_lists", ip_address_block_lists)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="ipAddressBlockLists")
    def ip_address_block_lists(self) -> pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]]:
        return pulumi.get(self, "ip_address_block_lists")

    @ip_address_block_lists.setter
    def ip_address_block_lists(self, value: pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]]):
        pulumi.set(self, "ip_address_block_lists", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _AddressGroupState:
    def __init__(__self__, *,
                 address_group_string: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_address_block_lists: Optional[pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AddressGroup resources.
        """
        if address_group_string is not None:
            pulumi.set(__self__, "address_group_string", address_group_string)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if ip_address_block_lists is not None:
            pulumi.set(__self__, "ip_address_block_lists", ip_address_block_lists)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="addressGroupString")
    def address_group_string(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "address_group_string")

    @address_group_string.setter
    def address_group_string(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "address_group_string", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="ipAddressBlockLists")
    def ip_address_block_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]]]:
        return pulumi.get(self, "ip_address_block_lists")

    @ip_address_block_lists.setter
    def ip_address_block_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AddressGroupIpAddressBlockListArgs']]]]):
        pulumi.set(self, "ip_address_block_lists", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class AddressGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_address_block_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddressGroupIpAddressBlockListArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a address group based on the input parameters.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        test_address = nutanix.AddressGroup("testAddress",
            description="test address groups resource",
            ip_address_block_lists=[nutanix.AddressGroupIpAddressBlockListArgs(
                ip="10.0.0.0",
                prefix_length=24,
            )])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AddressGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a address group based on the input parameters.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        test_address = nutanix.AddressGroup("testAddress",
            description="test address groups resource",
            ip_address_block_lists=[nutanix.AddressGroupIpAddressBlockListArgs(
                ip="10.0.0.0",
                prefix_length=24,
            )])
        ```

        :param str resource_name: The name of the resource.
        :param AddressGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AddressGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_address_block_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddressGroupIpAddressBlockListArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AddressGroupArgs.__new__(AddressGroupArgs)

            __props__.__dict__["description"] = description
            if ip_address_block_lists is None and not opts.urn:
                raise TypeError("Missing required property 'ip_address_block_lists'")
            __props__.__dict__["ip_address_block_lists"] = ip_address_block_lists
            __props__.__dict__["name"] = name
            __props__.__dict__["address_group_string"] = None
        super(AddressGroup, __self__).__init__(
            'nutanix:index/addressGroup:AddressGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            address_group_string: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            ip_address_block_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddressGroupIpAddressBlockListArgs']]]]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'AddressGroup':
        """
        Get an existing AddressGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AddressGroupState.__new__(_AddressGroupState)

        __props__.__dict__["address_group_string"] = address_group_string
        __props__.__dict__["description"] = description
        __props__.__dict__["ip_address_block_lists"] = ip_address_block_lists
        __props__.__dict__["name"] = name
        return AddressGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addressGroupString")
    def address_group_string(self) -> pulumi.Output[str]:
        return pulumi.get(self, "address_group_string")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="ipAddressBlockLists")
    def ip_address_block_lists(self) -> pulumi.Output[Sequence['outputs.AddressGroupIpAddressBlockList']]:
        return pulumi.get(self, "ip_address_block_lists")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")
