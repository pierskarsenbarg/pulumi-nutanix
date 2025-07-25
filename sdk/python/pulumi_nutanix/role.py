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

__all__ = ['RoleArgs', 'Role']

@pulumi.input_type
class RoleArgs:
    def __init__(__self__, *,
                 permission_reference_lists: pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]],
                 categories: Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner_reference: Optional[pulumi.Input['RoleOwnerReferenceArgs']] = None,
                 project_reference: Optional[pulumi.Input['RoleProjectReferenceArgs']] = None):
        """
        The set of arguments for constructing a Role resource.
        :param pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]] permission_reference_lists: - (Required) List of permission references.
        :param pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]] categories: - (Optional) Categories for the role.
        :param pulumi.Input[builtins.str] description: - (Optional) The description of the role.
        :param pulumi.Input[builtins.str] name: - (Optional) Name of the role.
        :param pulumi.Input['RoleOwnerReferenceArgs'] owner_reference: - (Optional) The reference to a user.
        :param pulumi.Input['RoleProjectReferenceArgs'] project_reference: - (Optional) The reference to a project.
        """
        pulumi.set(__self__, "permission_reference_lists", permission_reference_lists)
        if categories is not None:
            pulumi.set(__self__, "categories", categories)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner_reference is not None:
            pulumi.set(__self__, "owner_reference", owner_reference)
        if project_reference is not None:
            pulumi.set(__self__, "project_reference", project_reference)

    @property
    @pulumi.getter(name="permissionReferenceLists")
    def permission_reference_lists(self) -> pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]]:
        """
        - (Required) List of permission references.
        """
        return pulumi.get(self, "permission_reference_lists")

    @permission_reference_lists.setter
    def permission_reference_lists(self, value: pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]]):
        pulumi.set(self, "permission_reference_lists", value)

    @property
    @pulumi.getter
    def categories(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]]:
        """
        - (Optional) Categories for the role.
        """
        return pulumi.get(self, "categories")

    @categories.setter
    def categories(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]]):
        pulumi.set(self, "categories", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        - (Optional) The description of the role.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        - (Optional) Name of the role.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="ownerReference")
    def owner_reference(self) -> Optional[pulumi.Input['RoleOwnerReferenceArgs']]:
        """
        - (Optional) The reference to a user.
        """
        return pulumi.get(self, "owner_reference")

    @owner_reference.setter
    def owner_reference(self, value: Optional[pulumi.Input['RoleOwnerReferenceArgs']]):
        pulumi.set(self, "owner_reference", value)

    @property
    @pulumi.getter(name="projectReference")
    def project_reference(self) -> Optional[pulumi.Input['RoleProjectReferenceArgs']]:
        """
        - (Optional) The reference to a project.
        """
        return pulumi.get(self, "project_reference")

    @project_reference.setter
    def project_reference(self, value: Optional[pulumi.Input['RoleProjectReferenceArgs']]):
        pulumi.set(self, "project_reference", value)


@pulumi.input_type
class _RoleState:
    def __init__(__self__, *,
                 api_version: Optional[pulumi.Input[builtins.str]] = None,
                 categories: Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 metadata: Optional[pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner_reference: Optional[pulumi.Input['RoleOwnerReferenceArgs']] = None,
                 permission_reference_lists: Optional[pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]]] = None,
                 project_reference: Optional[pulumi.Input['RoleProjectReferenceArgs']] = None,
                 state: Optional[pulumi.Input[builtins.str]] = None):
        """
        Input properties used for looking up and filtering Role resources.
        :param pulumi.Input[builtins.str] api_version: The version of the API.
        :param pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]] categories: - (Optional) Categories for the role.
        :param pulumi.Input[builtins.str] description: - (Optional) The description of the role.
        :param pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]] metadata: - The role kind metadata.
        :param pulumi.Input[builtins.str] name: - (Optional) Name of the role.
        :param pulumi.Input['RoleOwnerReferenceArgs'] owner_reference: - (Optional) The reference to a user.
        :param pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]] permission_reference_lists: - (Required) List of permission references.
        :param pulumi.Input['RoleProjectReferenceArgs'] project_reference: - (Optional) The reference to a project.
        :param pulumi.Input[builtins.str] state: - The state of the role.
        """
        if api_version is not None:
            pulumi.set(__self__, "api_version", api_version)
        if categories is not None:
            pulumi.set(__self__, "categories", categories)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner_reference is not None:
            pulumi.set(__self__, "owner_reference", owner_reference)
        if permission_reference_lists is not None:
            pulumi.set(__self__, "permission_reference_lists", permission_reference_lists)
        if project_reference is not None:
            pulumi.set(__self__, "project_reference", project_reference)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The version of the API.
        """
        return pulumi.get(self, "api_version")

    @api_version.setter
    def api_version(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "api_version", value)

    @property
    @pulumi.getter
    def categories(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]]:
        """
        - (Optional) Categories for the role.
        """
        return pulumi.get(self, "categories")

    @categories.setter
    def categories(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RoleCategoryArgs']]]]):
        pulumi.set(self, "categories", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        - (Optional) The description of the role.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]]]:
        """
        - The role kind metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        - (Optional) Name of the role.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="ownerReference")
    def owner_reference(self) -> Optional[pulumi.Input['RoleOwnerReferenceArgs']]:
        """
        - (Optional) The reference to a user.
        """
        return pulumi.get(self, "owner_reference")

    @owner_reference.setter
    def owner_reference(self, value: Optional[pulumi.Input['RoleOwnerReferenceArgs']]):
        pulumi.set(self, "owner_reference", value)

    @property
    @pulumi.getter(name="permissionReferenceLists")
    def permission_reference_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]]]:
        """
        - (Required) List of permission references.
        """
        return pulumi.get(self, "permission_reference_lists")

    @permission_reference_lists.setter
    def permission_reference_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RolePermissionReferenceListArgs']]]]):
        pulumi.set(self, "permission_reference_lists", value)

    @property
    @pulumi.getter(name="projectReference")
    def project_reference(self) -> Optional[pulumi.Input['RoleProjectReferenceArgs']]:
        """
        - (Optional) The reference to a project.
        """
        return pulumi.get(self, "project_reference")

    @project_reference.setter
    def project_reference(self, value: Optional[pulumi.Input['RoleProjectReferenceArgs']]):
        pulumi.set(self, "project_reference", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        - The state of the role.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "state", value)


@pulumi.type_token("nutanix:index/role:Role")
class Role(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 categories: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RoleCategoryArgs', 'RoleCategoryArgsDict']]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner_reference: Optional[pulumi.Input[Union['RoleOwnerReferenceArgs', 'RoleOwnerReferenceArgsDict']]] = None,
                 permission_reference_lists: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RolePermissionReferenceListArgs', 'RolePermissionReferenceListArgsDict']]]]] = None,
                 project_reference: Optional[pulumi.Input[Union['RoleProjectReferenceArgs', 'RoleProjectReferenceArgsDict']]] = None,
                 __props__=None):
        """
        Provides a resource to create a role based on the input parameters.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        test = nutanix.Role("test",
            description="DESCRIPTION",
            permission_reference_lists=[
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RoleCategoryArgs', 'RoleCategoryArgsDict']]]] categories: - (Optional) Categories for the role.
        :param pulumi.Input[builtins.str] description: - (Optional) The description of the role.
        :param pulumi.Input[builtins.str] name: - (Optional) Name of the role.
        :param pulumi.Input[Union['RoleOwnerReferenceArgs', 'RoleOwnerReferenceArgsDict']] owner_reference: - (Optional) The reference to a user.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RolePermissionReferenceListArgs', 'RolePermissionReferenceListArgsDict']]]] permission_reference_lists: - (Required) List of permission references.
        :param pulumi.Input[Union['RoleProjectReferenceArgs', 'RoleProjectReferenceArgsDict']] project_reference: - (Optional) The reference to a project.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RoleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a role based on the input parameters.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        test = nutanix.Role("test",
            description="DESCRIPTION",
            permission_reference_lists=[
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
                {
                    "kind": "permission",
                    "uuid": "ID OF PERMISSION",
                },
            ])
        ```

        :param str resource_name: The name of the resource.
        :param RoleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RoleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 categories: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RoleCategoryArgs', 'RoleCategoryArgsDict']]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner_reference: Optional[pulumi.Input[Union['RoleOwnerReferenceArgs', 'RoleOwnerReferenceArgsDict']]] = None,
                 permission_reference_lists: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RolePermissionReferenceListArgs', 'RolePermissionReferenceListArgsDict']]]]] = None,
                 project_reference: Optional[pulumi.Input[Union['RoleProjectReferenceArgs', 'RoleProjectReferenceArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RoleArgs.__new__(RoleArgs)

            __props__.__dict__["categories"] = categories
            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            __props__.__dict__["owner_reference"] = owner_reference
            if permission_reference_lists is None and not opts.urn:
                raise TypeError("Missing required property 'permission_reference_lists'")
            __props__.__dict__["permission_reference_lists"] = permission_reference_lists
            __props__.__dict__["project_reference"] = project_reference
            __props__.__dict__["api_version"] = None
            __props__.__dict__["metadata"] = None
            __props__.__dict__["state"] = None
        super(Role, __self__).__init__(
            'nutanix:index/role:Role',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            api_version: Optional[pulumi.Input[builtins.str]] = None,
            categories: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RoleCategoryArgs', 'RoleCategoryArgsDict']]]]] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            metadata: Optional[pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            owner_reference: Optional[pulumi.Input[Union['RoleOwnerReferenceArgs', 'RoleOwnerReferenceArgsDict']]] = None,
            permission_reference_lists: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RolePermissionReferenceListArgs', 'RolePermissionReferenceListArgsDict']]]]] = None,
            project_reference: Optional[pulumi.Input[Union['RoleProjectReferenceArgs', 'RoleProjectReferenceArgsDict']]] = None,
            state: Optional[pulumi.Input[builtins.str]] = None) -> 'Role':
        """
        Get an existing Role resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] api_version: The version of the API.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RoleCategoryArgs', 'RoleCategoryArgsDict']]]] categories: - (Optional) Categories for the role.
        :param pulumi.Input[builtins.str] description: - (Optional) The description of the role.
        :param pulumi.Input[Mapping[str, pulumi.Input[builtins.str]]] metadata: - The role kind metadata.
        :param pulumi.Input[builtins.str] name: - (Optional) Name of the role.
        :param pulumi.Input[Union['RoleOwnerReferenceArgs', 'RoleOwnerReferenceArgsDict']] owner_reference: - (Optional) The reference to a user.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RolePermissionReferenceListArgs', 'RolePermissionReferenceListArgsDict']]]] permission_reference_lists: - (Required) List of permission references.
        :param pulumi.Input[Union['RoleProjectReferenceArgs', 'RoleProjectReferenceArgsDict']] project_reference: - (Optional) The reference to a project.
        :param pulumi.Input[builtins.str] state: - The state of the role.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RoleState.__new__(_RoleState)

        __props__.__dict__["api_version"] = api_version
        __props__.__dict__["categories"] = categories
        __props__.__dict__["description"] = description
        __props__.__dict__["metadata"] = metadata
        __props__.__dict__["name"] = name
        __props__.__dict__["owner_reference"] = owner_reference
        __props__.__dict__["permission_reference_lists"] = permission_reference_lists
        __props__.__dict__["project_reference"] = project_reference
        __props__.__dict__["state"] = state
        return Role(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> pulumi.Output[builtins.str]:
        """
        The version of the API.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def categories(self) -> pulumi.Output[Sequence['outputs.RoleCategory']]:
        """
        - (Optional) Categories for the role.
        """
        return pulumi.get(self, "categories")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[builtins.str]:
        """
        - (Optional) The description of the role.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Mapping[str, builtins.str]]:
        """
        - The role kind metadata.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        - (Optional) Name of the role.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownerReference")
    def owner_reference(self) -> pulumi.Output['outputs.RoleOwnerReference']:
        """
        - (Optional) The reference to a user.
        """
        return pulumi.get(self, "owner_reference")

    @property
    @pulumi.getter(name="permissionReferenceLists")
    def permission_reference_lists(self) -> pulumi.Output[Sequence['outputs.RolePermissionReferenceList']]:
        """
        - (Required) List of permission references.
        """
        return pulumi.get(self, "permission_reference_lists")

    @property
    @pulumi.getter(name="projectReference")
    def project_reference(self) -> pulumi.Output['outputs.RoleProjectReference']:
        """
        - (Optional) The reference to a project.
        """
        return pulumi.get(self, "project_reference")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[builtins.str]:
        """
        - The state of the role.
        """
        return pulumi.get(self, "state")

