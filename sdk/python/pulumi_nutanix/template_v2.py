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
from ._inputs import *

__all__ = ['TemplateV2Args', 'TemplateV2']

@pulumi.input_type
class TemplateV2Args:
    def __init__(__self__, *,
                 template_name: pulumi.Input[builtins.str],
                 template_version_spec: pulumi.Input['TemplateV2TemplateVersionSpecArgs'],
                 created_bies: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]] = None,
                 guest_update_statuses: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]] = None,
                 template_description: Optional[pulumi.Input[builtins.str]] = None,
                 updated_bies: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]] = None):
        """
        The set of arguments for constructing a TemplateV2 resource.
        """
        pulumi.set(__self__, "template_name", template_name)
        pulumi.set(__self__, "template_version_spec", template_version_spec)
        if created_bies is not None:
            pulumi.set(__self__, "created_bies", created_bies)
        if guest_update_statuses is not None:
            pulumi.set(__self__, "guest_update_statuses", guest_update_statuses)
        if template_description is not None:
            pulumi.set(__self__, "template_description", template_description)
        if updated_bies is not None:
            pulumi.set(__self__, "updated_bies", updated_bies)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Input[builtins.str]:
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "template_name", value)

    @property
    @pulumi.getter(name="templateVersionSpec")
    def template_version_spec(self) -> pulumi.Input['TemplateV2TemplateVersionSpecArgs']:
        return pulumi.get(self, "template_version_spec")

    @template_version_spec.setter
    def template_version_spec(self, value: pulumi.Input['TemplateV2TemplateVersionSpecArgs']):
        pulumi.set(self, "template_version_spec", value)

    @property
    @pulumi.getter(name="createdBies")
    def created_bies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]]:
        return pulumi.get(self, "created_bies")

    @created_bies.setter
    def created_bies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]]):
        pulumi.set(self, "created_bies", value)

    @property
    @pulumi.getter(name="guestUpdateStatuses")
    def guest_update_statuses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]]:
        return pulumi.get(self, "guest_update_statuses")

    @guest_update_statuses.setter
    def guest_update_statuses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]]):
        pulumi.set(self, "guest_update_statuses", value)

    @property
    @pulumi.getter(name="templateDescription")
    def template_description(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "template_description")

    @template_description.setter
    def template_description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "template_description", value)

    @property
    @pulumi.getter(name="updatedBies")
    def updated_bies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]]:
        return pulumi.get(self, "updated_bies")

    @updated_bies.setter
    def updated_bies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]]):
        pulumi.set(self, "updated_bies", value)


@pulumi.input_type
class _TemplateV2State:
    def __init__(__self__, *,
                 create_time: Optional[pulumi.Input[builtins.str]] = None,
                 created_bies: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]] = None,
                 ext_id: Optional[pulumi.Input[builtins.str]] = None,
                 guest_update_statuses: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]] = None,
                 links: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2LinkArgs']]]] = None,
                 template_description: Optional[pulumi.Input[builtins.str]] = None,
                 template_name: Optional[pulumi.Input[builtins.str]] = None,
                 template_version_spec: Optional[pulumi.Input['TemplateV2TemplateVersionSpecArgs']] = None,
                 tenant_id: Optional[pulumi.Input[builtins.str]] = None,
                 update_time: Optional[pulumi.Input[builtins.str]] = None,
                 updated_bies: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]] = None):
        """
        Input properties used for looking up and filtering TemplateV2 resources.
        """
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if created_bies is not None:
            pulumi.set(__self__, "created_bies", created_bies)
        if ext_id is not None:
            pulumi.set(__self__, "ext_id", ext_id)
        if guest_update_statuses is not None:
            pulumi.set(__self__, "guest_update_statuses", guest_update_statuses)
        if links is not None:
            pulumi.set(__self__, "links", links)
        if template_description is not None:
            pulumi.set(__self__, "template_description", template_description)
        if template_name is not None:
            pulumi.set(__self__, "template_name", template_name)
        if template_version_spec is not None:
            pulumi.set(__self__, "template_version_spec", template_version_spec)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if update_time is not None:
            pulumi.set(__self__, "update_time", update_time)
        if updated_bies is not None:
            pulumi.set(__self__, "updated_bies", updated_bies)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter(name="createdBies")
    def created_bies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]]:
        return pulumi.get(self, "created_bies")

    @created_bies.setter
    def created_bies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2CreatedByArgs']]]]):
        pulumi.set(self, "created_bies", value)

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "ext_id")

    @ext_id.setter
    def ext_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "ext_id", value)

    @property
    @pulumi.getter(name="guestUpdateStatuses")
    def guest_update_statuses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]]:
        return pulumi.get(self, "guest_update_statuses")

    @guest_update_statuses.setter
    def guest_update_statuses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2GuestUpdateStatusArgs']]]]):
        pulumi.set(self, "guest_update_statuses", value)

    @property
    @pulumi.getter
    def links(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2LinkArgs']]]]:
        return pulumi.get(self, "links")

    @links.setter
    def links(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2LinkArgs']]]]):
        pulumi.set(self, "links", value)

    @property
    @pulumi.getter(name="templateDescription")
    def template_description(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "template_description")

    @template_description.setter
    def template_description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "template_description", value)

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "template_name")

    @template_name.setter
    def template_name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "template_name", value)

    @property
    @pulumi.getter(name="templateVersionSpec")
    def template_version_spec(self) -> Optional[pulumi.Input['TemplateV2TemplateVersionSpecArgs']]:
        return pulumi.get(self, "template_version_spec")

    @template_version_spec.setter
    def template_version_spec(self, value: Optional[pulumi.Input['TemplateV2TemplateVersionSpecArgs']]):
        pulumi.set(self, "template_version_spec", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "tenant_id", value)

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> Optional[pulumi.Input[builtins.str]]:
        return pulumi.get(self, "update_time")

    @update_time.setter
    def update_time(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "update_time", value)

    @property
    @pulumi.getter(name="updatedBies")
    def updated_bies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]]:
        return pulumi.get(self, "updated_bies")

    @updated_bies.setter
    def updated_bies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateV2UpdatedByArgs']]]]):
        pulumi.set(self, "updated_bies", value)


@pulumi.type_token("nutanix:index/templateV2:TemplateV2")
class TemplateV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2CreatedByArgs', 'TemplateV2CreatedByArgsDict']]]]] = None,
                 guest_update_statuses: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2GuestUpdateStatusArgs', 'TemplateV2GuestUpdateStatusArgsDict']]]]] = None,
                 template_description: Optional[pulumi.Input[builtins.str]] = None,
                 template_name: Optional[pulumi.Input[builtins.str]] = None,
                 template_version_spec: Optional[pulumi.Input[Union['TemplateV2TemplateVersionSpecArgs', 'TemplateV2TemplateVersionSpecArgsDict']]] = None,
                 updated_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2UpdatedByArgs', 'TemplateV2UpdatedByArgsDict']]]]] = None,
                 __props__=None):
        """
        Create a TemplateV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TemplateV2Args,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a TemplateV2 resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param TemplateV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TemplateV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 created_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2CreatedByArgs', 'TemplateV2CreatedByArgsDict']]]]] = None,
                 guest_update_statuses: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2GuestUpdateStatusArgs', 'TemplateV2GuestUpdateStatusArgsDict']]]]] = None,
                 template_description: Optional[pulumi.Input[builtins.str]] = None,
                 template_name: Optional[pulumi.Input[builtins.str]] = None,
                 template_version_spec: Optional[pulumi.Input[Union['TemplateV2TemplateVersionSpecArgs', 'TemplateV2TemplateVersionSpecArgsDict']]] = None,
                 updated_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2UpdatedByArgs', 'TemplateV2UpdatedByArgsDict']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = TemplateV2Args.__new__(TemplateV2Args)

            __props__.__dict__["created_bies"] = created_bies
            __props__.__dict__["guest_update_statuses"] = guest_update_statuses
            __props__.__dict__["template_description"] = template_description
            if template_name is None and not opts.urn:
                raise TypeError("Missing required property 'template_name'")
            __props__.__dict__["template_name"] = template_name
            if template_version_spec is None and not opts.urn:
                raise TypeError("Missing required property 'template_version_spec'")
            __props__.__dict__["template_version_spec"] = template_version_spec
            __props__.__dict__["updated_bies"] = updated_bies
            __props__.__dict__["create_time"] = None
            __props__.__dict__["ext_id"] = None
            __props__.__dict__["links"] = None
            __props__.__dict__["tenant_id"] = None
            __props__.__dict__["update_time"] = None
        super(TemplateV2, __self__).__init__(
            'nutanix:index/templateV2:TemplateV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            create_time: Optional[pulumi.Input[builtins.str]] = None,
            created_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2CreatedByArgs', 'TemplateV2CreatedByArgsDict']]]]] = None,
            ext_id: Optional[pulumi.Input[builtins.str]] = None,
            guest_update_statuses: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2GuestUpdateStatusArgs', 'TemplateV2GuestUpdateStatusArgsDict']]]]] = None,
            links: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2LinkArgs', 'TemplateV2LinkArgsDict']]]]] = None,
            template_description: Optional[pulumi.Input[builtins.str]] = None,
            template_name: Optional[pulumi.Input[builtins.str]] = None,
            template_version_spec: Optional[pulumi.Input[Union['TemplateV2TemplateVersionSpecArgs', 'TemplateV2TemplateVersionSpecArgsDict']]] = None,
            tenant_id: Optional[pulumi.Input[builtins.str]] = None,
            update_time: Optional[pulumi.Input[builtins.str]] = None,
            updated_bies: Optional[pulumi.Input[Sequence[pulumi.Input[Union['TemplateV2UpdatedByArgs', 'TemplateV2UpdatedByArgsDict']]]]] = None) -> 'TemplateV2':
        """
        Get an existing TemplateV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _TemplateV2State.__new__(_TemplateV2State)

        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["created_bies"] = created_bies
        __props__.__dict__["ext_id"] = ext_id
        __props__.__dict__["guest_update_statuses"] = guest_update_statuses
        __props__.__dict__["links"] = links
        __props__.__dict__["template_description"] = template_description
        __props__.__dict__["template_name"] = template_name
        __props__.__dict__["template_version_spec"] = template_version_spec
        __props__.__dict__["tenant_id"] = tenant_id
        __props__.__dict__["update_time"] = update_time
        __props__.__dict__["updated_bies"] = updated_bies
        return TemplateV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="createdBies")
    def created_bies(self) -> pulumi.Output[Sequence['outputs.TemplateV2CreatedBy']]:
        return pulumi.get(self, "created_bies")

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "ext_id")

    @property
    @pulumi.getter(name="guestUpdateStatuses")
    def guest_update_statuses(self) -> pulumi.Output[Sequence['outputs.TemplateV2GuestUpdateStatus']]:
        return pulumi.get(self, "guest_update_statuses")

    @property
    @pulumi.getter
    def links(self) -> pulumi.Output[Sequence['outputs.TemplateV2Link']]:
        return pulumi.get(self, "links")

    @property
    @pulumi.getter(name="templateDescription")
    def template_description(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "template_description")

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "template_name")

    @property
    @pulumi.getter(name="templateVersionSpec")
    def template_version_spec(self) -> pulumi.Output['outputs.TemplateV2TemplateVersionSpec']:
        return pulumi.get(self, "template_version_spec")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter(name="updateTime")
    def update_time(self) -> pulumi.Output[builtins.str]:
        return pulumi.get(self, "update_time")

    @property
    @pulumi.getter(name="updatedBies")
    def updated_bies(self) -> pulumi.Output[Sequence['outputs.TemplateV2UpdatedBy']]:
        return pulumi.get(self, "updated_bies")

