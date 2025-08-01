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

__all__ = ['RecoveryPointsV2Args', 'RecoveryPointsV2']

@pulumi.input_type
class RecoveryPointsV2Args:
    def __init__(__self__, *,
                 expiration_time: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 recovery_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 status: Optional[pulumi.Input[builtins.str]] = None,
                 vm_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]] = None,
                 volume_group_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]] = None):
        """
        The set of arguments for constructing a RecoveryPointsV2 resource.
        :param pulumi.Input[builtins.str] expiration_time: -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        :param pulumi.Input[builtins.str] name: -(Optional) The name of the Recovery point.
        :param pulumi.Input[builtins.str] recovery_point_type: -(Optional) Type of the Recovery point.
               * supported values:
               * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
               * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        :param pulumi.Input[builtins.str] status: -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
               * supported values:
               * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]] vm_recovery_points: -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]] volume_group_recovery_points: -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        if expiration_time is not None:
            pulumi.set(__self__, "expiration_time", expiration_time)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if recovery_point_type is not None:
            pulumi.set(__self__, "recovery_point_type", recovery_point_type)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if vm_recovery_points is not None:
            pulumi.set(__self__, "vm_recovery_points", vm_recovery_points)
        if volume_group_recovery_points is not None:
            pulumi.set(__self__, "volume_group_recovery_points", volume_group_recovery_points)

    @property
    @pulumi.getter(name="expirationTime")
    def expiration_time(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        """
        return pulumi.get(self, "expiration_time")

    @expiration_time.setter
    def expiration_time(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "expiration_time", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The name of the Recovery point.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="recoveryPointType")
    def recovery_point_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) Type of the Recovery point.
        * supported values:
        * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
        * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        """
        return pulumi.get(self, "recovery_point_type")

    @recovery_point_type.setter
    def recovery_point_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "recovery_point_type", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
        * supported values:
        * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="vmRecoveryPoints")
    def vm_recovery_points(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]]:
        """
        -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "vm_recovery_points")

    @vm_recovery_points.setter
    def vm_recovery_points(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]]):
        pulumi.set(self, "vm_recovery_points", value)

    @property
    @pulumi.getter(name="volumeGroupRecoveryPoints")
    def volume_group_recovery_points(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]]:
        """
        -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "volume_group_recovery_points")

    @volume_group_recovery_points.setter
    def volume_group_recovery_points(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]]):
        pulumi.set(self, "volume_group_recovery_points", value)


@pulumi.input_type
class _RecoveryPointsV2State:
    def __init__(__self__, *,
                 creation_time: Optional[pulumi.Input[builtins.str]] = None,
                 expiration_time: Optional[pulumi.Input[builtins.str]] = None,
                 ext_id: Optional[pulumi.Input[builtins.str]] = None,
                 links: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LinkArgs']]]] = None,
                 location_agnostic_id: Optional[pulumi.Input[builtins.str]] = None,
                 location_references: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LocationReferenceArgs']]]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 owner_ext_id: Optional[pulumi.Input[builtins.str]] = None,
                 recovery_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 status: Optional[pulumi.Input[builtins.str]] = None,
                 tenant_id: Optional[pulumi.Input[builtins.str]] = None,
                 vm_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]] = None,
                 volume_group_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]] = None):
        """
        Input properties used for looking up and filtering RecoveryPointsV2 resources.
        :param pulumi.Input[builtins.str] creation_time: The UTC date and time in ISO-8601 format when the Recovery point is created.
        :param pulumi.Input[builtins.str] expiration_time: -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        :param pulumi.Input[builtins.str] ext_id: recovery point UUID
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LinkArgs']]] links: A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        :param pulumi.Input[builtins.str] location_agnostic_id: Location agnostic identifier of the recovery point. This identifier is used to identify the same instances of a recovery point across different sites.
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LocationReferenceArgs']]] location_references: List of location references where the VM or volume group recovery point are a part of the specified recovery point.
        :param pulumi.Input[builtins.str] name: -(Optional) The name of the Recovery point.
        :param pulumi.Input[builtins.str] owner_ext_id: A read only field inserted into recovery point at the time of recovery point creation, indicating the external identifier of the user who created this recovery point.
        :param pulumi.Input[builtins.str] recovery_point_type: -(Optional) Type of the Recovery point.
               * supported values:
               * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
               * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        :param pulumi.Input[builtins.str] status: -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
               * supported values:
               * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        :param pulumi.Input[builtins.str] tenant_id: A globally unique identifier that represents the tenant that owns this entity
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]] vm_recovery_points: -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        :param pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]] volume_group_recovery_points: -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        if creation_time is not None:
            pulumi.set(__self__, "creation_time", creation_time)
        if expiration_time is not None:
            pulumi.set(__self__, "expiration_time", expiration_time)
        if ext_id is not None:
            pulumi.set(__self__, "ext_id", ext_id)
        if links is not None:
            pulumi.set(__self__, "links", links)
        if location_agnostic_id is not None:
            pulumi.set(__self__, "location_agnostic_id", location_agnostic_id)
        if location_references is not None:
            pulumi.set(__self__, "location_references", location_references)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner_ext_id is not None:
            pulumi.set(__self__, "owner_ext_id", owner_ext_id)
        if recovery_point_type is not None:
            pulumi.set(__self__, "recovery_point_type", recovery_point_type)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if tenant_id is not None:
            pulumi.set(__self__, "tenant_id", tenant_id)
        if vm_recovery_points is not None:
            pulumi.set(__self__, "vm_recovery_points", vm_recovery_points)
        if volume_group_recovery_points is not None:
            pulumi.set(__self__, "volume_group_recovery_points", volume_group_recovery_points)

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        The UTC date and time in ISO-8601 format when the Recovery point is created.
        """
        return pulumi.get(self, "creation_time")

    @creation_time.setter
    def creation_time(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "creation_time", value)

    @property
    @pulumi.getter(name="expirationTime")
    def expiration_time(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        """
        return pulumi.get(self, "expiration_time")

    @expiration_time.setter
    def expiration_time(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "expiration_time", value)

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        recovery point UUID
        """
        return pulumi.get(self, "ext_id")

    @ext_id.setter
    def ext_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "ext_id", value)

    @property
    @pulumi.getter
    def links(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LinkArgs']]]]:
        """
        A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        """
        return pulumi.get(self, "links")

    @links.setter
    def links(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LinkArgs']]]]):
        pulumi.set(self, "links", value)

    @property
    @pulumi.getter(name="locationAgnosticId")
    def location_agnostic_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Location agnostic identifier of the recovery point. This identifier is used to identify the same instances of a recovery point across different sites.
        """
        return pulumi.get(self, "location_agnostic_id")

    @location_agnostic_id.setter
    def location_agnostic_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "location_agnostic_id", value)

    @property
    @pulumi.getter(name="locationReferences")
    def location_references(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LocationReferenceArgs']]]]:
        """
        List of location references where the VM or volume group recovery point are a part of the specified recovery point.
        """
        return pulumi.get(self, "location_references")

    @location_references.setter
    def location_references(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2LocationReferenceArgs']]]]):
        pulumi.set(self, "location_references", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The name of the Recovery point.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="ownerExtId")
    def owner_ext_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        A read only field inserted into recovery point at the time of recovery point creation, indicating the external identifier of the user who created this recovery point.
        """
        return pulumi.get(self, "owner_ext_id")

    @owner_ext_id.setter
    def owner_ext_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "owner_ext_id", value)

    @property
    @pulumi.getter(name="recoveryPointType")
    def recovery_point_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) Type of the Recovery point.
        * supported values:
        * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
        * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        """
        return pulumi.get(self, "recovery_point_type")

    @recovery_point_type.setter
    def recovery_point_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "recovery_point_type", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
        * supported values:
        * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        A globally unique identifier that represents the tenant that owns this entity
        """
        return pulumi.get(self, "tenant_id")

    @tenant_id.setter
    def tenant_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "tenant_id", value)

    @property
    @pulumi.getter(name="vmRecoveryPoints")
    def vm_recovery_points(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]]:
        """
        -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "vm_recovery_points")

    @vm_recovery_points.setter
    def vm_recovery_points(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VmRecoveryPointArgs']]]]):
        pulumi.set(self, "vm_recovery_points", value)

    @property
    @pulumi.getter(name="volumeGroupRecoveryPoints")
    def volume_group_recovery_points(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]]:
        """
        -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "volume_group_recovery_points")

    @volume_group_recovery_points.setter
    def volume_group_recovery_points(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RecoveryPointsV2VolumeGroupRecoveryPointArgs']]]]):
        pulumi.set(self, "volume_group_recovery_points", value)


@pulumi.type_token("nutanix:index/recoveryPointsV2:RecoveryPointsV2")
class RecoveryPointsV2(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 expiration_time: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 recovery_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 status: Optional[pulumi.Input[builtins.str]] = None,
                 vm_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VmRecoveryPointArgs', 'RecoveryPointsV2VmRecoveryPointArgsDict']]]]] = None,
                 volume_group_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VolumeGroupRecoveryPointArgs', 'RecoveryPointsV2VolumeGroupRecoveryPointArgsDict']]]]] = None,
                 __props__=None):
        """
        Create a new recovery point.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        # create RP with Vm Rp
        rp_example = nutanix.RecoveryPointsV2("rp-example",
            expiration_time="2024-09-17T09:20:42Z",
            recovery_point_type="APPLICATION_CONSISTENT",
            status="COMPLETE",
            vm_recovery_points=[{
                "vm_ext_id": "ab520e1d-4950-1db1-917f-a9e2ea35b8e3",
            }])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] expiration_time: -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        :param pulumi.Input[builtins.str] name: -(Optional) The name of the Recovery point.
        :param pulumi.Input[builtins.str] recovery_point_type: -(Optional) Type of the Recovery point.
               * supported values:
               * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
               * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        :param pulumi.Input[builtins.str] status: -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
               * supported values:
               * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VmRecoveryPointArgs', 'RecoveryPointsV2VmRecoveryPointArgsDict']]]] vm_recovery_points: -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VolumeGroupRecoveryPointArgs', 'RecoveryPointsV2VolumeGroupRecoveryPointArgsDict']]]] volume_group_recovery_points: -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[RecoveryPointsV2Args] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a new recovery point.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        # create RP with Vm Rp
        rp_example = nutanix.RecoveryPointsV2("rp-example",
            expiration_time="2024-09-17T09:20:42Z",
            recovery_point_type="APPLICATION_CONSISTENT",
            status="COMPLETE",
            vm_recovery_points=[{
                "vm_ext_id": "ab520e1d-4950-1db1-917f-a9e2ea35b8e3",
            }])
        ```

        :param str resource_name: The name of the resource.
        :param RecoveryPointsV2Args args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RecoveryPointsV2Args, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 expiration_time: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 recovery_point_type: Optional[pulumi.Input[builtins.str]] = None,
                 status: Optional[pulumi.Input[builtins.str]] = None,
                 vm_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VmRecoveryPointArgs', 'RecoveryPointsV2VmRecoveryPointArgsDict']]]]] = None,
                 volume_group_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VolumeGroupRecoveryPointArgs', 'RecoveryPointsV2VolumeGroupRecoveryPointArgsDict']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RecoveryPointsV2Args.__new__(RecoveryPointsV2Args)

            __props__.__dict__["expiration_time"] = expiration_time
            __props__.__dict__["name"] = name
            __props__.__dict__["recovery_point_type"] = recovery_point_type
            __props__.__dict__["status"] = status
            __props__.__dict__["vm_recovery_points"] = vm_recovery_points
            __props__.__dict__["volume_group_recovery_points"] = volume_group_recovery_points
            __props__.__dict__["creation_time"] = None
            __props__.__dict__["ext_id"] = None
            __props__.__dict__["links"] = None
            __props__.__dict__["location_agnostic_id"] = None
            __props__.__dict__["location_references"] = None
            __props__.__dict__["owner_ext_id"] = None
            __props__.__dict__["tenant_id"] = None
        super(RecoveryPointsV2, __self__).__init__(
            'nutanix:index/recoveryPointsV2:RecoveryPointsV2',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            creation_time: Optional[pulumi.Input[builtins.str]] = None,
            expiration_time: Optional[pulumi.Input[builtins.str]] = None,
            ext_id: Optional[pulumi.Input[builtins.str]] = None,
            links: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2LinkArgs', 'RecoveryPointsV2LinkArgsDict']]]]] = None,
            location_agnostic_id: Optional[pulumi.Input[builtins.str]] = None,
            location_references: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2LocationReferenceArgs', 'RecoveryPointsV2LocationReferenceArgsDict']]]]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            owner_ext_id: Optional[pulumi.Input[builtins.str]] = None,
            recovery_point_type: Optional[pulumi.Input[builtins.str]] = None,
            status: Optional[pulumi.Input[builtins.str]] = None,
            tenant_id: Optional[pulumi.Input[builtins.str]] = None,
            vm_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VmRecoveryPointArgs', 'RecoveryPointsV2VmRecoveryPointArgsDict']]]]] = None,
            volume_group_recovery_points: Optional[pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VolumeGroupRecoveryPointArgs', 'RecoveryPointsV2VolumeGroupRecoveryPointArgsDict']]]]] = None) -> 'RecoveryPointsV2':
        """
        Get an existing RecoveryPointsV2 resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] creation_time: The UTC date and time in ISO-8601 format when the Recovery point is created.
        :param pulumi.Input[builtins.str] expiration_time: -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        :param pulumi.Input[builtins.str] ext_id: recovery point UUID
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2LinkArgs', 'RecoveryPointsV2LinkArgsDict']]]] links: A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        :param pulumi.Input[builtins.str] location_agnostic_id: Location agnostic identifier of the recovery point. This identifier is used to identify the same instances of a recovery point across different sites.
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2LocationReferenceArgs', 'RecoveryPointsV2LocationReferenceArgsDict']]]] location_references: List of location references where the VM or volume group recovery point are a part of the specified recovery point.
        :param pulumi.Input[builtins.str] name: -(Optional) The name of the Recovery point.
        :param pulumi.Input[builtins.str] owner_ext_id: A read only field inserted into recovery point at the time of recovery point creation, indicating the external identifier of the user who created this recovery point.
        :param pulumi.Input[builtins.str] recovery_point_type: -(Optional) Type of the Recovery point.
               * supported values:
               * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
               * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        :param pulumi.Input[builtins.str] status: -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
               * supported values:
               * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        :param pulumi.Input[builtins.str] tenant_id: A globally unique identifier that represents the tenant that owns this entity
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VmRecoveryPointArgs', 'RecoveryPointsV2VmRecoveryPointArgsDict']]]] vm_recovery_points: -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        :param pulumi.Input[Sequence[pulumi.Input[Union['RecoveryPointsV2VolumeGroupRecoveryPointArgs', 'RecoveryPointsV2VolumeGroupRecoveryPointArgsDict']]]] volume_group_recovery_points: -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RecoveryPointsV2State.__new__(_RecoveryPointsV2State)

        __props__.__dict__["creation_time"] = creation_time
        __props__.__dict__["expiration_time"] = expiration_time
        __props__.__dict__["ext_id"] = ext_id
        __props__.__dict__["links"] = links
        __props__.__dict__["location_agnostic_id"] = location_agnostic_id
        __props__.__dict__["location_references"] = location_references
        __props__.__dict__["name"] = name
        __props__.__dict__["owner_ext_id"] = owner_ext_id
        __props__.__dict__["recovery_point_type"] = recovery_point_type
        __props__.__dict__["status"] = status
        __props__.__dict__["tenant_id"] = tenant_id
        __props__.__dict__["vm_recovery_points"] = vm_recovery_points
        __props__.__dict__["volume_group_recovery_points"] = volume_group_recovery_points
        return RecoveryPointsV2(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> pulumi.Output[builtins.str]:
        """
        The UTC date and time in ISO-8601 format when the Recovery point is created.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter(name="expirationTime")
    def expiration_time(self) -> pulumi.Output[builtins.str]:
        """
        -(Optional) The UTC date and time in ISO-8601 format when the current Recovery point expires and will be garbage collected.
        """
        return pulumi.get(self, "expiration_time")

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> pulumi.Output[builtins.str]:
        """
        recovery point UUID
        """
        return pulumi.get(self, "ext_id")

    @property
    @pulumi.getter
    def links(self) -> pulumi.Output[Sequence['outputs.RecoveryPointsV2Link']]:
        """
        A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
        """
        return pulumi.get(self, "links")

    @property
    @pulumi.getter(name="locationAgnosticId")
    def location_agnostic_id(self) -> pulumi.Output[builtins.str]:
        """
        Location agnostic identifier of the recovery point. This identifier is used to identify the same instances of a recovery point across different sites.
        """
        return pulumi.get(self, "location_agnostic_id")

    @property
    @pulumi.getter(name="locationReferences")
    def location_references(self) -> pulumi.Output[Sequence['outputs.RecoveryPointsV2LocationReference']]:
        """
        List of location references where the VM or volume group recovery point are a part of the specified recovery point.
        """
        return pulumi.get(self, "location_references")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        -(Optional) The name of the Recovery point.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="ownerExtId")
    def owner_ext_id(self) -> pulumi.Output[builtins.str]:
        """
        A read only field inserted into recovery point at the time of recovery point creation, indicating the external identifier of the user who created this recovery point.
        """
        return pulumi.get(self, "owner_ext_id")

    @property
    @pulumi.getter(name="recoveryPointType")
    def recovery_point_type(self) -> pulumi.Output[builtins.str]:
        """
        -(Optional) Type of the Recovery point.
        * supported values:
        * `CRASH_CONSISTENT`: -  capture all the VM and application level details.
        * `APPLICATION_CONSISTENT`: -  stored in the memory and also the in-progress transaction details.
        """
        return pulumi.get(self, "recovery_point_type")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[builtins.str]:
        """
        -(Optional) The status of the Recovery point, which indicates whether this Recovery point is fit to be consumed.
        * supported values:
        * `COMPLETE`: -  The Recovery point is in a complete state and ready to be consumed.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> pulumi.Output[builtins.str]:
        """
        A globally unique identifier that represents the tenant that owns this entity
        """
        return pulumi.get(self, "tenant_id")

    @property
    @pulumi.getter(name="vmRecoveryPoints")
    def vm_recovery_points(self) -> pulumi.Output[Optional[Sequence['outputs.RecoveryPointsV2VmRecoveryPoint']]]:
        """
        -(Optional) List of VM recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "vm_recovery_points")

    @property
    @pulumi.getter(name="volumeGroupRecoveryPoints")
    def volume_group_recovery_points(self) -> pulumi.Output[Sequence['outputs.RecoveryPointsV2VolumeGroupRecoveryPoint']]:
        """
        -(Optional) List of volume group recovery point that are a part of the specified top-level recovery point. Note that a recovery point can contain a maximum number of 30 entities. These entities can be a combination of VM(s) and volume group(s).
        """
        return pulumi.get(self, "volume_group_recovery_points")

