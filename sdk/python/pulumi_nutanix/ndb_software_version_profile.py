# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['NdbSoftwareVersionProfileArgs', 'NdbSoftwareVersionProfile']

@pulumi.input_type
class NdbSoftwareVersionProfileArgs:
    def __init__(__self__, *,
                 engine_type: pulumi.Input[str],
                 profile_id: pulumi.Input[str],
                 available_cluster_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 postgres_databases: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a NdbSoftwareVersionProfile resource.
        """
        pulumi.set(__self__, "engine_type", engine_type)
        pulumi.set(__self__, "profile_id", profile_id)
        if available_cluster_ids is not None:
            pulumi.set(__self__, "available_cluster_ids", available_cluster_ids)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if postgres_databases is not None:
            pulumi.set(__self__, "postgres_databases", postgres_databases)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "engine_type")

    @engine_type.setter
    def engine_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "engine_type", value)

    @property
    @pulumi.getter(name="profileId")
    def profile_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "profile_id")

    @profile_id.setter
    def profile_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "profile_id", value)

    @property
    @pulumi.getter(name="availableClusterIds")
    def available_cluster_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "available_cluster_ids")

    @available_cluster_ids.setter
    def available_cluster_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "available_cluster_ids", value)

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

    @property
    @pulumi.getter(name="postgresDatabases")
    def postgres_databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]:
        return pulumi.get(self, "postgres_databases")

    @postgres_databases.setter
    def postgres_databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]):
        pulumi.set(self, "postgres_databases", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class _NdbSoftwareVersionProfileState:
    def __init__(__self__, *,
                 available_cluster_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 db_version: Optional[pulumi.Input[str]] = None,
                 deprecated: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 engine_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 postgres_databases: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]] = None,
                 profile_id: Optional[pulumi.Input[str]] = None,
                 properties: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePropertyArgs']]]] = None,
                 properties_map: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 published: Optional[pulumi.Input[bool]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 system_profile: Optional[pulumi.Input[bool]] = None,
                 topology: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 version_cluster_associations: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfileVersionClusterAssociationArgs']]]] = None):
        """
        Input properties used for looking up and filtering NdbSoftwareVersionProfile resources.
        """
        if available_cluster_ids is not None:
            pulumi.set(__self__, "available_cluster_ids", available_cluster_ids)
        if db_version is not None:
            pulumi.set(__self__, "db_version", db_version)
        if deprecated is not None:
            pulumi.set(__self__, "deprecated", deprecated)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if engine_type is not None:
            pulumi.set(__self__, "engine_type", engine_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if postgres_databases is not None:
            pulumi.set(__self__, "postgres_databases", postgres_databases)
        if profile_id is not None:
            pulumi.set(__self__, "profile_id", profile_id)
        if properties is not None:
            pulumi.set(__self__, "properties", properties)
        if properties_map is not None:
            pulumi.set(__self__, "properties_map", properties_map)
        if published is not None:
            pulumi.set(__self__, "published", published)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if system_profile is not None:
            pulumi.set(__self__, "system_profile", system_profile)
        if topology is not None:
            pulumi.set(__self__, "topology", topology)
        if version is not None:
            pulumi.set(__self__, "version", version)
        if version_cluster_associations is not None:
            pulumi.set(__self__, "version_cluster_associations", version_cluster_associations)

    @property
    @pulumi.getter(name="availableClusterIds")
    def available_cluster_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "available_cluster_ids")

    @available_cluster_ids.setter
    def available_cluster_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "available_cluster_ids", value)

    @property
    @pulumi.getter(name="dbVersion")
    def db_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "db_version")

    @db_version.setter
    def db_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "db_version", value)

    @property
    @pulumi.getter
    def deprecated(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "deprecated")

    @deprecated.setter
    def deprecated(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deprecated", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "engine_type")

    @engine_type.setter
    def engine_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "engine_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="postgresDatabases")
    def postgres_databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]:
        return pulumi.get(self, "postgres_databases")

    @postgres_databases.setter
    def postgres_databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]):
        pulumi.set(self, "postgres_databases", value)

    @property
    @pulumi.getter(name="profileId")
    def profile_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "profile_id")

    @profile_id.setter
    def profile_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "profile_id", value)

    @property
    @pulumi.getter
    def properties(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePropertyArgs']]]]:
        return pulumi.get(self, "properties")

    @properties.setter
    def properties(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfilePropertyArgs']]]]):
        pulumi.set(self, "properties", value)

    @property
    @pulumi.getter(name="propertiesMap")
    def properties_map(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "properties_map")

    @properties_map.setter
    def properties_map(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "properties_map", value)

    @property
    @pulumi.getter
    def published(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "published")

    @published.setter
    def published(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "published", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="systemProfile")
    def system_profile(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "system_profile")

    @system_profile.setter
    def system_profile(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "system_profile", value)

    @property
    @pulumi.getter
    def topology(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "topology")

    @topology.setter
    def topology(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "topology", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter(name="versionClusterAssociations")
    def version_cluster_associations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfileVersionClusterAssociationArgs']]]]:
        return pulumi.get(self, "version_cluster_associations")

    @version_cluster_associations.setter
    def version_cluster_associations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbSoftwareVersionProfileVersionClusterAssociationArgs']]]]):
        pulumi.set(self, "version_cluster_associations", value)


class NdbSoftwareVersionProfile(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 available_cluster_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 engine_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 postgres_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]] = None,
                 profile_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a NdbSoftwareVersionProfile resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NdbSoftwareVersionProfileArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a NdbSoftwareVersionProfile resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param NdbSoftwareVersionProfileArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NdbSoftwareVersionProfileArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 available_cluster_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 engine_type: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 postgres_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]] = None,
                 profile_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NdbSoftwareVersionProfileArgs.__new__(NdbSoftwareVersionProfileArgs)

            __props__.__dict__["available_cluster_ids"] = available_cluster_ids
            __props__.__dict__["description"] = description
            if engine_type is None and not opts.urn:
                raise TypeError("Missing required property 'engine_type'")
            __props__.__dict__["engine_type"] = engine_type
            __props__.__dict__["name"] = name
            __props__.__dict__["postgres_databases"] = postgres_databases
            if profile_id is None and not opts.urn:
                raise TypeError("Missing required property 'profile_id'")
            __props__.__dict__["profile_id"] = profile_id
            __props__.__dict__["status"] = status
            __props__.__dict__["db_version"] = None
            __props__.__dict__["deprecated"] = None
            __props__.__dict__["owner"] = None
            __props__.__dict__["properties"] = None
            __props__.__dict__["properties_map"] = None
            __props__.__dict__["published"] = None
            __props__.__dict__["system_profile"] = None
            __props__.__dict__["topology"] = None
            __props__.__dict__["version"] = None
            __props__.__dict__["version_cluster_associations"] = None
        super(NdbSoftwareVersionProfile, __self__).__init__(
            'nutanix:index/ndbSoftwareVersionProfile:NdbSoftwareVersionProfile',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            available_cluster_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            db_version: Optional[pulumi.Input[str]] = None,
            deprecated: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            engine_type: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            owner: Optional[pulumi.Input[str]] = None,
            postgres_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NdbSoftwareVersionProfilePostgresDatabaseArgs']]]]] = None,
            profile_id: Optional[pulumi.Input[str]] = None,
            properties: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NdbSoftwareVersionProfilePropertyArgs']]]]] = None,
            properties_map: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            published: Optional[pulumi.Input[bool]] = None,
            status: Optional[pulumi.Input[str]] = None,
            system_profile: Optional[pulumi.Input[bool]] = None,
            topology: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None,
            version_cluster_associations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NdbSoftwareVersionProfileVersionClusterAssociationArgs']]]]] = None) -> 'NdbSoftwareVersionProfile':
        """
        Get an existing NdbSoftwareVersionProfile resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NdbSoftwareVersionProfileState.__new__(_NdbSoftwareVersionProfileState)

        __props__.__dict__["available_cluster_ids"] = available_cluster_ids
        __props__.__dict__["db_version"] = db_version
        __props__.__dict__["deprecated"] = deprecated
        __props__.__dict__["description"] = description
        __props__.__dict__["engine_type"] = engine_type
        __props__.__dict__["name"] = name
        __props__.__dict__["owner"] = owner
        __props__.__dict__["postgres_databases"] = postgres_databases
        __props__.__dict__["profile_id"] = profile_id
        __props__.__dict__["properties"] = properties
        __props__.__dict__["properties_map"] = properties_map
        __props__.__dict__["published"] = published
        __props__.__dict__["status"] = status
        __props__.__dict__["system_profile"] = system_profile
        __props__.__dict__["topology"] = topology
        __props__.__dict__["version"] = version
        __props__.__dict__["version_cluster_associations"] = version_cluster_associations
        return NdbSoftwareVersionProfile(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="availableClusterIds")
    def available_cluster_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "available_cluster_ids")

    @property
    @pulumi.getter(name="dbVersion")
    def db_version(self) -> pulumi.Output[str]:
        return pulumi.get(self, "db_version")

    @property
    @pulumi.getter
    def deprecated(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "deprecated")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "engine_type")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[str]:
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="postgresDatabases")
    def postgres_databases(self) -> pulumi.Output[Optional[Sequence['outputs.NdbSoftwareVersionProfilePostgresDatabase']]]:
        return pulumi.get(self, "postgres_databases")

    @property
    @pulumi.getter(name="profileId")
    def profile_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "profile_id")

    @property
    @pulumi.getter
    def properties(self) -> pulumi.Output[Sequence['outputs.NdbSoftwareVersionProfileProperty']]:
        return pulumi.get(self, "properties")

    @property
    @pulumi.getter(name="propertiesMap")
    def properties_map(self) -> pulumi.Output[Mapping[str, str]]:
        return pulumi.get(self, "properties_map")

    @property
    @pulumi.getter
    def published(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "published")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="systemProfile")
    def system_profile(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "system_profile")

    @property
    @pulumi.getter
    def topology(self) -> pulumi.Output[str]:
        return pulumi.get(self, "topology")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="versionClusterAssociations")
    def version_cluster_associations(self) -> pulumi.Output[Sequence['outputs.NdbSoftwareVersionProfileVersionClusterAssociation']]:
        return pulumi.get(self, "version_cluster_associations")
