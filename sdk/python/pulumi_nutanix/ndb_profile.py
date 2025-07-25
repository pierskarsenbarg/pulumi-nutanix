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

__all__ = ['NdbProfileArgs', 'NdbProfile']

@pulumi.input_type
class NdbProfileArgs:
    def __init__(__self__, *,
                 compute_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]] = None,
                 database_parameter_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 engine_type: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 network_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]] = None,
                 published: Optional[pulumi.Input[builtins.bool]] = None,
                 software_profile: Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']] = None):
        """
        The set of arguments for constructing a NdbProfile resource.
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]] compute_profiles: Compute Profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]] database_parameter_profiles: Database Parameter Profile
        :param pulumi.Input[builtins.str] description: Description of profile
        :param pulumi.Input[builtins.str] engine_type: Engine Type of database
        :param pulumi.Input[builtins.str] name: Name of profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]] network_profiles: Network Profile
        :param pulumi.Input[builtins.bool] published: Publish for all users
        :param pulumi.Input['NdbProfileSoftwareProfileArgs'] software_profile: Software Profile
        """
        if compute_profiles is not None:
            pulumi.set(__self__, "compute_profiles", compute_profiles)
        if database_parameter_profiles is not None:
            pulumi.set(__self__, "database_parameter_profiles", database_parameter_profiles)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if engine_type is not None:
            pulumi.set(__self__, "engine_type", engine_type)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_profiles is not None:
            pulumi.set(__self__, "network_profiles", network_profiles)
        if published is not None:
            pulumi.set(__self__, "published", published)
        if software_profile is not None:
            pulumi.set(__self__, "software_profile", software_profile)

    @property
    @pulumi.getter(name="computeProfiles")
    def compute_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]]:
        """
        Compute Profile
        """
        return pulumi.get(self, "compute_profiles")

    @compute_profiles.setter
    def compute_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]]):
        pulumi.set(self, "compute_profiles", value)

    @property
    @pulumi.getter(name="databaseParameterProfiles")
    def database_parameter_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]]:
        """
        Database Parameter Profile
        """
        return pulumi.get(self, "database_parameter_profiles")

    @database_parameter_profiles.setter
    def database_parameter_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]]):
        pulumi.set(self, "database_parameter_profiles", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description of profile
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Engine Type of database
        """
        return pulumi.get(self, "engine_type")

    @engine_type.setter
    def engine_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "engine_type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Name of profile
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkProfiles")
    def network_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]]:
        """
        Network Profile
        """
        return pulumi.get(self, "network_profiles")

    @network_profiles.setter
    def network_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]]):
        pulumi.set(self, "network_profiles", value)

    @property
    @pulumi.getter
    def published(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Publish for all users
        """
        return pulumi.get(self, "published")

    @published.setter
    def published(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "published", value)

    @property
    @pulumi.getter(name="softwareProfile")
    def software_profile(self) -> Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']]:
        """
        Software Profile
        """
        return pulumi.get(self, "software_profile")

    @software_profile.setter
    def software_profile(self, value: Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']]):
        pulumi.set(self, "software_profile", value)


@pulumi.input_type
class _NdbProfileState:
    def __init__(__self__, *,
                 assoc_databases: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 assoc_db_servers: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
                 cluster_availabilities: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileClusterAvailabilityArgs']]]] = None,
                 compute_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]] = None,
                 database_parameter_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 engine_type: Optional[pulumi.Input[builtins.str]] = None,
                 latest_version: Optional[pulumi.Input[builtins.str]] = None,
                 latest_version_id: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 network_profiles: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]] = None,
                 nx_cluster_id: Optional[pulumi.Input[builtins.str]] = None,
                 owner: Optional[pulumi.Input[builtins.str]] = None,
                 published: Optional[pulumi.Input[builtins.bool]] = None,
                 software_profile: Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']] = None,
                 status: Optional[pulumi.Input[builtins.str]] = None,
                 versions: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileVersionArgs']]]] = None):
        """
        Input properties used for looking up and filtering NdbProfile resources.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] assoc_databases: associated databases of profiles
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] assoc_db_servers: associated database servers for associated profiles
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileClusterAvailabilityArgs']]] cluster_availabilities: cluster availability of profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]] compute_profiles: Compute Profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]] database_parameter_profiles: Database Parameter Profile
        :param pulumi.Input[builtins.str] description: Description of profile
        :param pulumi.Input[builtins.str] engine_type: Engine Type of database
        :param pulumi.Input[builtins.str] latest_version: latest version of profile
        :param pulumi.Input[builtins.str] latest_version_id: latest version id of profile
        :param pulumi.Input[builtins.str] name: Name of profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]] network_profiles: Network Profile
        :param pulumi.Input[builtins.str] nx_cluster_id: cluster on which profile created
        :param pulumi.Input[builtins.str] owner: owner  of profile
        :param pulumi.Input[builtins.bool] published: Publish for all users
        :param pulumi.Input['NdbProfileSoftwareProfileArgs'] software_profile: Software Profile
        :param pulumi.Input[builtins.str] status: status of profile
        :param pulumi.Input[Sequence[pulumi.Input['NdbProfileVersionArgs']]] versions: versions of associated profiles
        """
        if assoc_databases is not None:
            pulumi.set(__self__, "assoc_databases", assoc_databases)
        if assoc_db_servers is not None:
            pulumi.set(__self__, "assoc_db_servers", assoc_db_servers)
        if cluster_availabilities is not None:
            pulumi.set(__self__, "cluster_availabilities", cluster_availabilities)
        if compute_profiles is not None:
            pulumi.set(__self__, "compute_profiles", compute_profiles)
        if database_parameter_profiles is not None:
            pulumi.set(__self__, "database_parameter_profiles", database_parameter_profiles)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if engine_type is not None:
            pulumi.set(__self__, "engine_type", engine_type)
        if latest_version is not None:
            pulumi.set(__self__, "latest_version", latest_version)
        if latest_version_id is not None:
            pulumi.set(__self__, "latest_version_id", latest_version_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_profiles is not None:
            pulumi.set(__self__, "network_profiles", network_profiles)
        if nx_cluster_id is not None:
            pulumi.set(__self__, "nx_cluster_id", nx_cluster_id)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if published is not None:
            pulumi.set(__self__, "published", published)
        if software_profile is not None:
            pulumi.set(__self__, "software_profile", software_profile)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if versions is not None:
            pulumi.set(__self__, "versions", versions)

    @property
    @pulumi.getter(name="assocDatabases")
    def assoc_databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        associated databases of profiles
        """
        return pulumi.get(self, "assoc_databases")

    @assoc_databases.setter
    def assoc_databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "assoc_databases", value)

    @property
    @pulumi.getter(name="assocDbServers")
    def assoc_db_servers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]:
        """
        associated database servers for associated profiles
        """
        return pulumi.get(self, "assoc_db_servers")

    @assoc_db_servers.setter
    def assoc_db_servers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]]):
        pulumi.set(self, "assoc_db_servers", value)

    @property
    @pulumi.getter(name="clusterAvailabilities")
    def cluster_availabilities(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileClusterAvailabilityArgs']]]]:
        """
        cluster availability of profile
        """
        return pulumi.get(self, "cluster_availabilities")

    @cluster_availabilities.setter
    def cluster_availabilities(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileClusterAvailabilityArgs']]]]):
        pulumi.set(self, "cluster_availabilities", value)

    @property
    @pulumi.getter(name="computeProfiles")
    def compute_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]]:
        """
        Compute Profile
        """
        return pulumi.get(self, "compute_profiles")

    @compute_profiles.setter
    def compute_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileComputeProfileArgs']]]]):
        pulumi.set(self, "compute_profiles", value)

    @property
    @pulumi.getter(name="databaseParameterProfiles")
    def database_parameter_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]]:
        """
        Database Parameter Profile
        """
        return pulumi.get(self, "database_parameter_profiles")

    @database_parameter_profiles.setter
    def database_parameter_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileDatabaseParameterProfileArgs']]]]):
        pulumi.set(self, "database_parameter_profiles", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Description of profile
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Engine Type of database
        """
        return pulumi.get(self, "engine_type")

    @engine_type.setter
    def engine_type(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "engine_type", value)

    @property
    @pulumi.getter(name="latestVersion")
    def latest_version(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        latest version of profile
        """
        return pulumi.get(self, "latest_version")

    @latest_version.setter
    def latest_version(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "latest_version", value)

    @property
    @pulumi.getter(name="latestVersionId")
    def latest_version_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        latest version id of profile
        """
        return pulumi.get(self, "latest_version_id")

    @latest_version_id.setter
    def latest_version_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "latest_version_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Name of profile
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkProfiles")
    def network_profiles(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]]:
        """
        Network Profile
        """
        return pulumi.get(self, "network_profiles")

    @network_profiles.setter
    def network_profiles(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileNetworkProfileArgs']]]]):
        pulumi.set(self, "network_profiles", value)

    @property
    @pulumi.getter(name="nxClusterId")
    def nx_cluster_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        cluster on which profile created
        """
        return pulumi.get(self, "nx_cluster_id")

    @nx_cluster_id.setter
    def nx_cluster_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "nx_cluster_id", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        owner  of profile
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter
    def published(self) -> Optional[pulumi.Input[builtins.bool]]:
        """
        Publish for all users
        """
        return pulumi.get(self, "published")

    @published.setter
    def published(self, value: Optional[pulumi.Input[builtins.bool]]):
        pulumi.set(self, "published", value)

    @property
    @pulumi.getter(name="softwareProfile")
    def software_profile(self) -> Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']]:
        """
        Software Profile
        """
        return pulumi.get(self, "software_profile")

    @software_profile.setter
    def software_profile(self, value: Optional[pulumi.Input['NdbProfileSoftwareProfileArgs']]):
        pulumi.set(self, "software_profile", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        status of profile
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def versions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileVersionArgs']]]]:
        """
        versions of associated profiles
        """
        return pulumi.get(self, "versions")

    @versions.setter
    def versions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NdbProfileVersionArgs']]]]):
        pulumi.set(self, "versions", value)


@pulumi.type_token("nutanix:index/ndbProfile:NdbProfile")
class NdbProfile(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compute_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileComputeProfileArgs', 'NdbProfileComputeProfileArgsDict']]]]] = None,
                 database_parameter_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileDatabaseParameterProfileArgs', 'NdbProfileDatabaseParameterProfileArgsDict']]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 engine_type: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 network_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileNetworkProfileArgs', 'NdbProfileNetworkProfileArgsDict']]]]] = None,
                 published: Optional[pulumi.Input[builtins.bool]] = None,
                 software_profile: Optional[pulumi.Input[Union['NdbProfileSoftwareProfileArgs', 'NdbProfileSoftwareProfileArgsDict']]] = None,
                 __props__=None):
        """
        Provides a resource to create profiles (Software, Network, Database Parameter, Compute) based on the input parameters.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileComputeProfileArgs', 'NdbProfileComputeProfileArgsDict']]]] compute_profiles: Compute Profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileDatabaseParameterProfileArgs', 'NdbProfileDatabaseParameterProfileArgsDict']]]] database_parameter_profiles: Database Parameter Profile
        :param pulumi.Input[builtins.str] description: Description of profile
        :param pulumi.Input[builtins.str] engine_type: Engine Type of database
        :param pulumi.Input[builtins.str] name: Name of profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileNetworkProfileArgs', 'NdbProfileNetworkProfileArgsDict']]]] network_profiles: Network Profile
        :param pulumi.Input[builtins.bool] published: Publish for all users
        :param pulumi.Input[Union['NdbProfileSoftwareProfileArgs', 'NdbProfileSoftwareProfileArgsDict']] software_profile: Software Profile
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[NdbProfileArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create profiles (Software, Network, Database Parameter, Compute) based on the input parameters.

        :param str resource_name: The name of the resource.
        :param NdbProfileArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NdbProfileArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compute_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileComputeProfileArgs', 'NdbProfileComputeProfileArgsDict']]]]] = None,
                 database_parameter_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileDatabaseParameterProfileArgs', 'NdbProfileDatabaseParameterProfileArgsDict']]]]] = None,
                 description: Optional[pulumi.Input[builtins.str]] = None,
                 engine_type: Optional[pulumi.Input[builtins.str]] = None,
                 name: Optional[pulumi.Input[builtins.str]] = None,
                 network_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileNetworkProfileArgs', 'NdbProfileNetworkProfileArgsDict']]]]] = None,
                 published: Optional[pulumi.Input[builtins.bool]] = None,
                 software_profile: Optional[pulumi.Input[Union['NdbProfileSoftwareProfileArgs', 'NdbProfileSoftwareProfileArgsDict']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NdbProfileArgs.__new__(NdbProfileArgs)

            __props__.__dict__["compute_profiles"] = compute_profiles
            __props__.__dict__["database_parameter_profiles"] = database_parameter_profiles
            __props__.__dict__["description"] = description
            __props__.__dict__["engine_type"] = engine_type
            __props__.__dict__["name"] = name
            __props__.__dict__["network_profiles"] = network_profiles
            __props__.__dict__["published"] = published
            __props__.__dict__["software_profile"] = software_profile
            __props__.__dict__["assoc_databases"] = None
            __props__.__dict__["assoc_db_servers"] = None
            __props__.__dict__["cluster_availabilities"] = None
            __props__.__dict__["latest_version"] = None
            __props__.__dict__["latest_version_id"] = None
            __props__.__dict__["nx_cluster_id"] = None
            __props__.__dict__["owner"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["versions"] = None
        super(NdbProfile, __self__).__init__(
            'nutanix:index/ndbProfile:NdbProfile',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            assoc_databases: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            assoc_db_servers: Optional[pulumi.Input[Sequence[pulumi.Input[builtins.str]]]] = None,
            cluster_availabilities: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileClusterAvailabilityArgs', 'NdbProfileClusterAvailabilityArgsDict']]]]] = None,
            compute_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileComputeProfileArgs', 'NdbProfileComputeProfileArgsDict']]]]] = None,
            database_parameter_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileDatabaseParameterProfileArgs', 'NdbProfileDatabaseParameterProfileArgsDict']]]]] = None,
            description: Optional[pulumi.Input[builtins.str]] = None,
            engine_type: Optional[pulumi.Input[builtins.str]] = None,
            latest_version: Optional[pulumi.Input[builtins.str]] = None,
            latest_version_id: Optional[pulumi.Input[builtins.str]] = None,
            name: Optional[pulumi.Input[builtins.str]] = None,
            network_profiles: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileNetworkProfileArgs', 'NdbProfileNetworkProfileArgsDict']]]]] = None,
            nx_cluster_id: Optional[pulumi.Input[builtins.str]] = None,
            owner: Optional[pulumi.Input[builtins.str]] = None,
            published: Optional[pulumi.Input[builtins.bool]] = None,
            software_profile: Optional[pulumi.Input[Union['NdbProfileSoftwareProfileArgs', 'NdbProfileSoftwareProfileArgsDict']]] = None,
            status: Optional[pulumi.Input[builtins.str]] = None,
            versions: Optional[pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileVersionArgs', 'NdbProfileVersionArgsDict']]]]] = None) -> 'NdbProfile':
        """
        Get an existing NdbProfile resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] assoc_databases: associated databases of profiles
        :param pulumi.Input[Sequence[pulumi.Input[builtins.str]]] assoc_db_servers: associated database servers for associated profiles
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileClusterAvailabilityArgs', 'NdbProfileClusterAvailabilityArgsDict']]]] cluster_availabilities: cluster availability of profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileComputeProfileArgs', 'NdbProfileComputeProfileArgsDict']]]] compute_profiles: Compute Profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileDatabaseParameterProfileArgs', 'NdbProfileDatabaseParameterProfileArgsDict']]]] database_parameter_profiles: Database Parameter Profile
        :param pulumi.Input[builtins.str] description: Description of profile
        :param pulumi.Input[builtins.str] engine_type: Engine Type of database
        :param pulumi.Input[builtins.str] latest_version: latest version of profile
        :param pulumi.Input[builtins.str] latest_version_id: latest version id of profile
        :param pulumi.Input[builtins.str] name: Name of profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileNetworkProfileArgs', 'NdbProfileNetworkProfileArgsDict']]]] network_profiles: Network Profile
        :param pulumi.Input[builtins.str] nx_cluster_id: cluster on which profile created
        :param pulumi.Input[builtins.str] owner: owner  of profile
        :param pulumi.Input[builtins.bool] published: Publish for all users
        :param pulumi.Input[Union['NdbProfileSoftwareProfileArgs', 'NdbProfileSoftwareProfileArgsDict']] software_profile: Software Profile
        :param pulumi.Input[builtins.str] status: status of profile
        :param pulumi.Input[Sequence[pulumi.Input[Union['NdbProfileVersionArgs', 'NdbProfileVersionArgsDict']]]] versions: versions of associated profiles
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NdbProfileState.__new__(_NdbProfileState)

        __props__.__dict__["assoc_databases"] = assoc_databases
        __props__.__dict__["assoc_db_servers"] = assoc_db_servers
        __props__.__dict__["cluster_availabilities"] = cluster_availabilities
        __props__.__dict__["compute_profiles"] = compute_profiles
        __props__.__dict__["database_parameter_profiles"] = database_parameter_profiles
        __props__.__dict__["description"] = description
        __props__.__dict__["engine_type"] = engine_type
        __props__.__dict__["latest_version"] = latest_version
        __props__.__dict__["latest_version_id"] = latest_version_id
        __props__.__dict__["name"] = name
        __props__.__dict__["network_profiles"] = network_profiles
        __props__.__dict__["nx_cluster_id"] = nx_cluster_id
        __props__.__dict__["owner"] = owner
        __props__.__dict__["published"] = published
        __props__.__dict__["software_profile"] = software_profile
        __props__.__dict__["status"] = status
        __props__.__dict__["versions"] = versions
        return NdbProfile(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="assocDatabases")
    def assoc_databases(self) -> pulumi.Output[Sequence[builtins.str]]:
        """
        associated databases of profiles
        """
        return pulumi.get(self, "assoc_databases")

    @property
    @pulumi.getter(name="assocDbServers")
    def assoc_db_servers(self) -> pulumi.Output[Sequence[builtins.str]]:
        """
        associated database servers for associated profiles
        """
        return pulumi.get(self, "assoc_db_servers")

    @property
    @pulumi.getter(name="clusterAvailabilities")
    def cluster_availabilities(self) -> pulumi.Output[Sequence['outputs.NdbProfileClusterAvailability']]:
        """
        cluster availability of profile
        """
        return pulumi.get(self, "cluster_availabilities")

    @property
    @pulumi.getter(name="computeProfiles")
    def compute_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.NdbProfileComputeProfile']]]:
        """
        Compute Profile
        """
        return pulumi.get(self, "compute_profiles")

    @property
    @pulumi.getter(name="databaseParameterProfiles")
    def database_parameter_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.NdbProfileDatabaseParameterProfile']]]:
        """
        Database Parameter Profile
        """
        return pulumi.get(self, "database_parameter_profiles")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Description of profile
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="engineType")
    def engine_type(self) -> pulumi.Output[builtins.str]:
        """
        Engine Type of database
        """
        return pulumi.get(self, "engine_type")

    @property
    @pulumi.getter(name="latestVersion")
    def latest_version(self) -> pulumi.Output[builtins.str]:
        """
        latest version of profile
        """
        return pulumi.get(self, "latest_version")

    @property
    @pulumi.getter(name="latestVersionId")
    def latest_version_id(self) -> pulumi.Output[builtins.str]:
        """
        latest version id of profile
        """
        return pulumi.get(self, "latest_version_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[builtins.str]:
        """
        Name of profile
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkProfiles")
    def network_profiles(self) -> pulumi.Output[Optional[Sequence['outputs.NdbProfileNetworkProfile']]]:
        """
        Network Profile
        """
        return pulumi.get(self, "network_profiles")

    @property
    @pulumi.getter(name="nxClusterId")
    def nx_cluster_id(self) -> pulumi.Output[builtins.str]:
        """
        cluster on which profile created
        """
        return pulumi.get(self, "nx_cluster_id")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[builtins.str]:
        """
        owner  of profile
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter
    def published(self) -> pulumi.Output[Optional[builtins.bool]]:
        """
        Publish for all users
        """
        return pulumi.get(self, "published")

    @property
    @pulumi.getter(name="softwareProfile")
    def software_profile(self) -> pulumi.Output[Optional['outputs.NdbProfileSoftwareProfile']]:
        """
        Software Profile
        """
        return pulumi.get(self, "software_profile")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[builtins.str]:
        """
        status of profile
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def versions(self) -> pulumi.Output[Sequence['outputs.NdbProfileVersion']]:
        """
        versions of associated profiles
        """
        return pulumi.get(self, "versions")

