# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['NdbTmsClusterArgs', 'NdbTmsCluster']

@pulumi.input_type
class NdbTmsClusterArgs:
    def __init__(__self__, *,
                 nx_cluster_id: pulumi.Input[str],
                 sla_id: pulumi.Input[str],
                 time_machine_id: pulumi.Input[str],
                 type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a NdbTmsCluster resource.
        """
        pulumi.set(__self__, "nx_cluster_id", nx_cluster_id)
        pulumi.set(__self__, "sla_id", sla_id)
        pulumi.set(__self__, "time_machine_id", time_machine_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="nxClusterId")
    def nx_cluster_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "nx_cluster_id")

    @nx_cluster_id.setter
    def nx_cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "nx_cluster_id", value)

    @property
    @pulumi.getter(name="slaId")
    def sla_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "sla_id")

    @sla_id.setter
    def sla_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "sla_id", value)

    @property
    @pulumi.getter(name="timeMachineId")
    def time_machine_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "time_machine_id")

    @time_machine_id.setter
    def time_machine_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "time_machine_id", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class _NdbTmsClusterState:
    def __init__(__self__, *,
                 date_created: Optional[pulumi.Input[str]] = None,
                 date_modified: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 log_drive_id: Optional[pulumi.Input[str]] = None,
                 log_drive_status: Optional[pulumi.Input[str]] = None,
                 nx_cluster_id: Optional[pulumi.Input[str]] = None,
                 owner_id: Optional[pulumi.Input[str]] = None,
                 schedule_id: Optional[pulumi.Input[str]] = None,
                 sla_id: Optional[pulumi.Input[str]] = None,
                 source: Optional[pulumi.Input[bool]] = None,
                 source_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 time_machine_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering NdbTmsCluster resources.
        """
        if date_created is not None:
            pulumi.set(__self__, "date_created", date_created)
        if date_modified is not None:
            pulumi.set(__self__, "date_modified", date_modified)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if log_drive_id is not None:
            pulumi.set(__self__, "log_drive_id", log_drive_id)
        if log_drive_status is not None:
            pulumi.set(__self__, "log_drive_status", log_drive_status)
        if nx_cluster_id is not None:
            pulumi.set(__self__, "nx_cluster_id", nx_cluster_id)
        if owner_id is not None:
            pulumi.set(__self__, "owner_id", owner_id)
        if schedule_id is not None:
            pulumi.set(__self__, "schedule_id", schedule_id)
        if sla_id is not None:
            pulumi.set(__self__, "sla_id", sla_id)
        if source is not None:
            pulumi.set(__self__, "source", source)
        if source_clusters is not None:
            pulumi.set(__self__, "source_clusters", source_clusters)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if time_machine_id is not None:
            pulumi.set(__self__, "time_machine_id", time_machine_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="dateCreated")
    def date_created(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "date_created")

    @date_created.setter
    def date_created(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "date_created", value)

    @property
    @pulumi.getter(name="dateModified")
    def date_modified(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "date_modified")

    @date_modified.setter
    def date_modified(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "date_modified", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="logDriveId")
    def log_drive_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "log_drive_id")

    @log_drive_id.setter
    def log_drive_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_drive_id", value)

    @property
    @pulumi.getter(name="logDriveStatus")
    def log_drive_status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "log_drive_status")

    @log_drive_status.setter
    def log_drive_status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_drive_status", value)

    @property
    @pulumi.getter(name="nxClusterId")
    def nx_cluster_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "nx_cluster_id")

    @nx_cluster_id.setter
    def nx_cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "nx_cluster_id", value)

    @property
    @pulumi.getter(name="ownerId")
    def owner_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "owner_id")

    @owner_id.setter
    def owner_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "owner_id", value)

    @property
    @pulumi.getter(name="scheduleId")
    def schedule_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "schedule_id")

    @schedule_id.setter
    def schedule_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule_id", value)

    @property
    @pulumi.getter(name="slaId")
    def sla_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "sla_id")

    @sla_id.setter
    def sla_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sla_id", value)

    @property
    @pulumi.getter
    def source(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "source")

    @source.setter
    def source(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "source", value)

    @property
    @pulumi.getter(name="sourceClusters")
    def source_clusters(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "source_clusters")

    @source_clusters.setter
    def source_clusters(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "source_clusters", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="timeMachineId")
    def time_machine_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "time_machine_id")

    @time_machine_id.setter
    def time_machine_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_machine_id", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


class NdbTmsCluster(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 nx_cluster_id: Optional[pulumi.Input[str]] = None,
                 sla_id: Optional[pulumi.Input[str]] = None,
                 time_machine_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a NdbTmsCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NdbTmsClusterArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a NdbTmsCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param NdbTmsClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NdbTmsClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 nx_cluster_id: Optional[pulumi.Input[str]] = None,
                 sla_id: Optional[pulumi.Input[str]] = None,
                 time_machine_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NdbTmsClusterArgs.__new__(NdbTmsClusterArgs)

            if nx_cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'nx_cluster_id'")
            __props__.__dict__["nx_cluster_id"] = nx_cluster_id
            if sla_id is None and not opts.urn:
                raise TypeError("Missing required property 'sla_id'")
            __props__.__dict__["sla_id"] = sla_id
            if time_machine_id is None and not opts.urn:
                raise TypeError("Missing required property 'time_machine_id'")
            __props__.__dict__["time_machine_id"] = time_machine_id
            __props__.__dict__["type"] = type
            __props__.__dict__["date_created"] = None
            __props__.__dict__["date_modified"] = None
            __props__.__dict__["description"] = None
            __props__.__dict__["log_drive_id"] = None
            __props__.__dict__["log_drive_status"] = None
            __props__.__dict__["owner_id"] = None
            __props__.__dict__["schedule_id"] = None
            __props__.__dict__["source"] = None
            __props__.__dict__["source_clusters"] = None
            __props__.__dict__["status"] = None
        super(NdbTmsCluster, __self__).__init__(
            'nutanix:index/ndbTmsCluster:NdbTmsCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            date_created: Optional[pulumi.Input[str]] = None,
            date_modified: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            log_drive_id: Optional[pulumi.Input[str]] = None,
            log_drive_status: Optional[pulumi.Input[str]] = None,
            nx_cluster_id: Optional[pulumi.Input[str]] = None,
            owner_id: Optional[pulumi.Input[str]] = None,
            schedule_id: Optional[pulumi.Input[str]] = None,
            sla_id: Optional[pulumi.Input[str]] = None,
            source: Optional[pulumi.Input[bool]] = None,
            source_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None,
            time_machine_id: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'NdbTmsCluster':
        """
        Get an existing NdbTmsCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NdbTmsClusterState.__new__(_NdbTmsClusterState)

        __props__.__dict__["date_created"] = date_created
        __props__.__dict__["date_modified"] = date_modified
        __props__.__dict__["description"] = description
        __props__.__dict__["log_drive_id"] = log_drive_id
        __props__.__dict__["log_drive_status"] = log_drive_status
        __props__.__dict__["nx_cluster_id"] = nx_cluster_id
        __props__.__dict__["owner_id"] = owner_id
        __props__.__dict__["schedule_id"] = schedule_id
        __props__.__dict__["sla_id"] = sla_id
        __props__.__dict__["source"] = source
        __props__.__dict__["source_clusters"] = source_clusters
        __props__.__dict__["status"] = status
        __props__.__dict__["time_machine_id"] = time_machine_id
        __props__.__dict__["type"] = type
        return NdbTmsCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dateCreated")
    def date_created(self) -> pulumi.Output[str]:
        return pulumi.get(self, "date_created")

    @property
    @pulumi.getter(name="dateModified")
    def date_modified(self) -> pulumi.Output[str]:
        return pulumi.get(self, "date_modified")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="logDriveId")
    def log_drive_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "log_drive_id")

    @property
    @pulumi.getter(name="logDriveStatus")
    def log_drive_status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "log_drive_status")

    @property
    @pulumi.getter(name="nxClusterId")
    def nx_cluster_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "nx_cluster_id")

    @property
    @pulumi.getter(name="ownerId")
    def owner_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "owner_id")

    @property
    @pulumi.getter(name="scheduleId")
    def schedule_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "schedule_id")

    @property
    @pulumi.getter(name="slaId")
    def sla_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "sla_id")

    @property
    @pulumi.getter
    def source(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "source")

    @property
    @pulumi.getter(name="sourceClusters")
    def source_clusters(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "source_clusters")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="timeMachineId")
    def time_machine_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "time_machine_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "type")
