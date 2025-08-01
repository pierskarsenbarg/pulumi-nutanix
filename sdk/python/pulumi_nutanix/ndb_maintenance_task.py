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

__all__ = ['NdbMaintenanceTaskArgs', 'NdbMaintenanceTask']

@pulumi.input_type
class NdbMaintenanceTaskArgs:
    def __init__(__self__, *,
                 maintenance_window_id: pulumi.Input[builtins.str],
                 dbserver_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 dbserver_ids: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 tasks: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]] = None):
        """
        The set of arguments for constructing a NdbMaintenanceTask resource.
        :param pulumi.Input[builtins.str] maintenance_window_id: maintenance window id which has to be associated
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_clusters: dbserver cluster ids. Conflicts with "dbserver_id"
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_ids: dbserver vm id. Conflicts with "dbserver_cluster"
        :param pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]] tasks: task input for Operating System Patching or Database Patching or both
        """
        pulumi.set(__self__, "maintenance_window_id", maintenance_window_id)
        if dbserver_clusters is not None:
            pulumi.set(__self__, "dbserver_clusters", dbserver_clusters)
        if dbserver_ids is not None:
            pulumi.set(__self__, "dbserver_ids", dbserver_ids)
        if tasks is not None:
            pulumi.set(__self__, "tasks", tasks)

    @property
    @pulumi.getter(name="maintenanceWindowId")
    def maintenance_window_id(self) -> pulumi.Input[builtins.str]:
        """
        maintenance window id which has to be associated
        """
        return pulumi.get(self, "maintenance_window_id")

    @maintenance_window_id.setter
    def maintenance_window_id(self, value: pulumi.Input[builtins.str]):
        pulumi.set(self, "maintenance_window_id", value)

    @property
    @pulumi.getter(name="dbserverClusters")
    def dbserver_clusters(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        dbserver cluster ids. Conflicts with "dbserver_id"
        """
        return pulumi.get(self, "dbserver_clusters")

    @dbserver_clusters.setter
    def dbserver_clusters(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dbserver_clusters", value)

    @property
    @pulumi.getter(name="dbserverIds")
    def dbserver_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        dbserver vm id. Conflicts with "dbserver_cluster"
        """
        return pulumi.get(self, "dbserver_ids")

    @dbserver_ids.setter
    def dbserver_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dbserver_ids", value)

    @property
    @pulumi.getter
    def tasks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]]:
        """
        task input for Operating System Patching or Database Patching or both
        """
        return pulumi.get(self, "tasks")

    @tasks.setter
    def tasks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]]):
        pulumi.set(self, "tasks", value)


@pulumi.input_type
class _NdbMaintenanceTaskState:
    def __init__(__self__, *,
                 dbserver_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 dbserver_ids: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 entity_task_associations: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskEntityTaskAssociationArgs']]]] = None,
                 maintenance_window_id: Optional[pulumi.Input[builtins.str]] = None,
                 tasks: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]] = None):
        """
        Input properties used for looking up and filtering NdbMaintenanceTask resources.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_clusters: dbserver cluster ids. Conflicts with "dbserver_id"
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_ids: dbserver vm id. Conflicts with "dbserver_cluster"
        :param pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskEntityTaskAssociationArgs']]] entity_task_associations: Entity Task Association  List.
        :param pulumi.Input[builtins.str] maintenance_window_id: maintenance window id which has to be associated
        :param pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]] tasks: task input for Operating System Patching or Database Patching or both
        """
        if dbserver_clusters is not None:
            pulumi.set(__self__, "dbserver_clusters", dbserver_clusters)
        if dbserver_ids is not None:
            pulumi.set(__self__, "dbserver_ids", dbserver_ids)
        if entity_task_associations is not None:
            pulumi.set(__self__, "entity_task_associations", entity_task_associations)
        if maintenance_window_id is not None:
            pulumi.set(__self__, "maintenance_window_id", maintenance_window_id)
        if tasks is not None:
            pulumi.set(__self__, "tasks", tasks)

    @property
    @pulumi.getter(name="dbserverClusters")
    def dbserver_clusters(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        dbserver cluster ids. Conflicts with "dbserver_id"
        """
        return pulumi.get(self, "dbserver_clusters")

    @dbserver_clusters.setter
    def dbserver_clusters(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dbserver_clusters", value)

    @property
    @pulumi.getter(name="dbserverIds")
    def dbserver_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        dbserver vm id. Conflicts with "dbserver_cluster"
        """
        return pulumi.get(self, "dbserver_ids")

    @dbserver_ids.setter
    def dbserver_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "dbserver_ids", value)

    @property
    @pulumi.getter(name="entityTaskAssociations")
    def entity_task_associations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskEntityTaskAssociationArgs']]]]:
        """
        Entity Task Association  List.
        """
        return pulumi.get(self, "entity_task_associations")

    @entity_task_associations.setter
    def entity_task_associations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskEntityTaskAssociationArgs']]]]):
        pulumi.set(self, "entity_task_associations", value)

    @property
    @pulumi.getter(name="maintenanceWindowId")
    def maintenance_window_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        maintenance window id which has to be associated
        """
        return pulumi.get(self, "maintenance_window_id")

    @maintenance_window_id.setter
    def maintenance_window_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "maintenance_window_id", value)

    @property
    @pulumi.getter
    def tasks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]]:
        """
        task input for Operating System Patching or Database Patching or both
        """
        return pulumi.get(self, "tasks")

    @tasks.setter
    def tasks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbMaintenanceTaskTaskArgs']]]]):
        pulumi.set(self, "tasks", value)


@pulumi.type_token("nutanix:index/ndbMaintenanceTask:NdbMaintenanceTask")
class NdbMaintenanceTask(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dbserver_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 dbserver_ids: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 maintenance_window_id: Optional[pulumi.Input[builtins.str]] = None,
                 tasks: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskTaskArgs', 'NdbMaintenanceTaskTaskArgsDict']]]]] = None,
                 __props__=None):
        """
        Provides a resource to associate a maintenance window with database server VM based on the input parameters.

        ## Example Usage

        ### resource to associated maintenance window with OS_PATCHING
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[{
                "task_type": "OS_PATCHING",
            }])
        ```

        ### resource to associated maintenance window with DB_PATCHING
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[{
                "task_type": "DB_PATCHING",
            }])
        ```

        ### resource to associated maintenance window with pre and post command on each task
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[
                {
                    "post_command": "{{ post_command for db patching }}",
                    "pre_command": "{{ pre_command for db patching }}",
                    "task_type": "DB_PATCHING",
                },
                {
                    "post_command": "{{ post_command for os patching }}",
                    "pre_command": "{{ pre_command for os patching}}",
                    "task_type": "OS_PATCHING",
                },
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_clusters: dbserver cluster ids. Conflicts with "dbserver_id"
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_ids: dbserver vm id. Conflicts with "dbserver_cluster"
        :param pulumi.Input[builtins.str] maintenance_window_id: maintenance window id which has to be associated
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskTaskArgs', 'NdbMaintenanceTaskTaskArgsDict']]]] tasks: task input for Operating System Patching or Database Patching or both
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NdbMaintenanceTaskArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to associate a maintenance window with database server VM based on the input parameters.

        ## Example Usage

        ### resource to associated maintenance window with OS_PATCHING
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[{
                "task_type": "OS_PATCHING",
            }])
        ```

        ### resource to associated maintenance window with DB_PATCHING
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[{
                "task_type": "DB_PATCHING",
            }])
        ```

        ### resource to associated maintenance window with pre and post command on each task
        ```python
        import pulumi
        import pulumi_nutanix as nutanix

        name = nutanix.NdbMaintenanceTask("name",
            dbserver_ids=["{{ dbserver_vm_id }}"],
            maintenance_window_id="{{ maintenance_window_id }}",
            tasks=[
                {
                    "post_command": "{{ post_command for db patching }}",
                    "pre_command": "{{ pre_command for db patching }}",
                    "task_type": "DB_PATCHING",
                },
                {
                    "post_command": "{{ post_command for os patching }}",
                    "pre_command": "{{ pre_command for os patching}}",
                    "task_type": "OS_PATCHING",
                },
            ])
        ```

        :param str resource_name: The name of the resource.
        :param NdbMaintenanceTaskArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NdbMaintenanceTaskArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dbserver_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 dbserver_ids: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 maintenance_window_id: Optional[pulumi.Input[builtins.str]] = None,
                 tasks: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskTaskArgs', 'NdbMaintenanceTaskTaskArgsDict']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NdbMaintenanceTaskArgs.__new__(NdbMaintenanceTaskArgs)

            __props__.__dict__["dbserver_clusters"] = dbserver_clusters
            __props__.__dict__["dbserver_ids"] = dbserver_ids
            if maintenance_window_id is None and not opts.urn:
                raise TypeError("Missing required property 'maintenance_window_id'")
            __props__.__dict__["maintenance_window_id"] = maintenance_window_id
            __props__.__dict__["tasks"] = tasks
            __props__.__dict__["entity_task_associations"] = None
        super(NdbMaintenanceTask, __self__).__init__(
            'nutanix:index/ndbMaintenanceTask:NdbMaintenanceTask',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dbserver_clusters: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            dbserver_ids: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            entity_task_associations: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskEntityTaskAssociationArgs', 'NdbMaintenanceTaskEntityTaskAssociationArgsDict']]]]] = None,
            maintenance_window_id: Optional[pulumi.Input[builtins.str]] = None,
            tasks: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskTaskArgs', 'NdbMaintenanceTaskTaskArgsDict']]]]] = None) -> 'NdbMaintenanceTask':
        """
        Get an existing NdbMaintenanceTask resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_clusters: dbserver cluster ids. Conflicts with "dbserver_id"
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] dbserver_ids: dbserver vm id. Conflicts with "dbserver_cluster"
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskEntityTaskAssociationArgs', 'NdbMaintenanceTaskEntityTaskAssociationArgsDict']]]] entity_task_associations: Entity Task Association  List.
        :param pulumi.Input[builtins.str] maintenance_window_id: maintenance window id which has to be associated
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbMaintenanceTaskTaskArgs', 'NdbMaintenanceTaskTaskArgsDict']]]] tasks: task input for Operating System Patching or Database Patching or both
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NdbMaintenanceTaskState.__new__(_NdbMaintenanceTaskState)

        __props__.__dict__["dbserver_clusters"] = dbserver_clusters
        __props__.__dict__["dbserver_ids"] = dbserver_ids
        __props__.__dict__["entity_task_associations"] = entity_task_associations
        __props__.__dict__["maintenance_window_id"] = maintenance_window_id
        __props__.__dict__["tasks"] = tasks
        return NdbMaintenanceTask(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dbserverClusters")
    def dbserver_clusters(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        dbserver cluster ids. Conflicts with "dbserver_id"
        """
        return pulumi.get(self, "dbserver_clusters")

    @property
    @pulumi.getter(name="dbserverIds")
    def dbserver_ids(self) -> pulumi.Output[Optional[Sequence[builtins.str]]]:
        """
        dbserver vm id. Conflicts with "dbserver_cluster"
        """
        return pulumi.get(self, "dbserver_ids")

    @property
    @pulumi.getter(name="entityTaskAssociations")
    def entity_task_associations(self) -> pulumi.Output[Sequence['outputs.NdbMaintenanceTaskEntityTaskAssociation']]:
        """
        Entity Task Association  List.
        """
        return pulumi.get(self, "entity_task_associations")

    @property
    @pulumi.getter(name="maintenanceWindowId")
    def maintenance_window_id(self) -> pulumi.Output[builtins.str]:
        """
        maintenance window id which has to be associated
        """
        return pulumi.get(self, "maintenance_window_id")

    @property
    @pulumi.getter
    def tasks(self) -> pulumi.Output[Optional[Sequence['outputs.NdbMaintenanceTaskTask']]]:
        """
        task input for Operating System Patching or Database Patching or both
        """
        return pulumi.get(self, "tasks")

