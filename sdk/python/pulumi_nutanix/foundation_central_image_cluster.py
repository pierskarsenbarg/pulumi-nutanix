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

__all__ = ['FoundationCentralImageClusterArgs', 'FoundationCentralImageCluster']

@pulumi.input_type
class FoundationCentralImageClusterArgs:
    def __init__(__self__, *,
                 aos_package_sha256sum: Optional[pulumi.Input[str]] = None,
                 aos_package_url: Optional[pulumi.Input[str]] = None,
                 cluster_external_ip: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 cluster_size: Optional[pulumi.Input[int]] = None,
                 cluster_status: Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']] = None,
                 common_network_settings: Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']] = None,
                 hypervisor_iso_details: Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']] = None,
                 image_cluster_uuid: Optional[pulumi.Input[str]] = None,
                 node_lists: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]] = None,
                 redundancy_factor: Optional[pulumi.Input[int]] = None,
                 skip_cluster_creation: Optional[pulumi.Input[bool]] = None,
                 storage_node_count: Optional[pulumi.Input[int]] = None,
                 timezone: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a FoundationCentralImageCluster resource.
        """
        if aos_package_sha256sum is not None:
            pulumi.set(__self__, "aos_package_sha256sum", aos_package_sha256sum)
        if aos_package_url is not None:
            pulumi.set(__self__, "aos_package_url", aos_package_url)
        if cluster_external_ip is not None:
            pulumi.set(__self__, "cluster_external_ip", cluster_external_ip)
        if cluster_name is not None:
            pulumi.set(__self__, "cluster_name", cluster_name)
        if cluster_size is not None:
            pulumi.set(__self__, "cluster_size", cluster_size)
        if cluster_status is not None:
            pulumi.set(__self__, "cluster_status", cluster_status)
        if common_network_settings is not None:
            pulumi.set(__self__, "common_network_settings", common_network_settings)
        if hypervisor_iso_details is not None:
            pulumi.set(__self__, "hypervisor_iso_details", hypervisor_iso_details)
        if image_cluster_uuid is not None:
            pulumi.set(__self__, "image_cluster_uuid", image_cluster_uuid)
        if node_lists is not None:
            pulumi.set(__self__, "node_lists", node_lists)
        if redundancy_factor is not None:
            pulumi.set(__self__, "redundancy_factor", redundancy_factor)
        if skip_cluster_creation is not None:
            pulumi.set(__self__, "skip_cluster_creation", skip_cluster_creation)
        if storage_node_count is not None:
            pulumi.set(__self__, "storage_node_count", storage_node_count)
        if timezone is not None:
            pulumi.set(__self__, "timezone", timezone)

    @property
    @pulumi.getter(name="aosPackageSha256sum")
    def aos_package_sha256sum(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "aos_package_sha256sum")

    @aos_package_sha256sum.setter
    def aos_package_sha256sum(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aos_package_sha256sum", value)

    @property
    @pulumi.getter(name="aosPackageUrl")
    def aos_package_url(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "aos_package_url")

    @aos_package_url.setter
    def aos_package_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aos_package_url", value)

    @property
    @pulumi.getter(name="clusterExternalIp")
    def cluster_external_ip(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_external_ip")

    @cluster_external_ip.setter
    def cluster_external_ip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_external_ip", value)

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_name")

    @cluster_name.setter
    def cluster_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_name", value)

    @property
    @pulumi.getter(name="clusterSize")
    def cluster_size(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "cluster_size")

    @cluster_size.setter
    def cluster_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cluster_size", value)

    @property
    @pulumi.getter(name="clusterStatus")
    def cluster_status(self) -> Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']]:
        return pulumi.get(self, "cluster_status")

    @cluster_status.setter
    def cluster_status(self, value: Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']]):
        pulumi.set(self, "cluster_status", value)

    @property
    @pulumi.getter(name="commonNetworkSettings")
    def common_network_settings(self) -> Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']]:
        return pulumi.get(self, "common_network_settings")

    @common_network_settings.setter
    def common_network_settings(self, value: Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']]):
        pulumi.set(self, "common_network_settings", value)

    @property
    @pulumi.getter(name="hypervisorIsoDetails")
    def hypervisor_iso_details(self) -> Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]:
        return pulumi.get(self, "hypervisor_iso_details")

    @hypervisor_iso_details.setter
    def hypervisor_iso_details(self, value: Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]):
        pulumi.set(self, "hypervisor_iso_details", value)

    @property
    @pulumi.getter(name="imageClusterUuid")
    def image_cluster_uuid(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "image_cluster_uuid")

    @image_cluster_uuid.setter
    def image_cluster_uuid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image_cluster_uuid", value)

    @property
    @pulumi.getter(name="nodeLists")
    def node_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]]:
        return pulumi.get(self, "node_lists")

    @node_lists.setter
    def node_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]]):
        pulumi.set(self, "node_lists", value)

    @property
    @pulumi.getter(name="redundancyFactor")
    def redundancy_factor(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "redundancy_factor")

    @redundancy_factor.setter
    def redundancy_factor(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "redundancy_factor", value)

    @property
    @pulumi.getter(name="skipClusterCreation")
    def skip_cluster_creation(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "skip_cluster_creation")

    @skip_cluster_creation.setter
    def skip_cluster_creation(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "skip_cluster_creation", value)

    @property
    @pulumi.getter(name="storageNodeCount")
    def storage_node_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "storage_node_count")

    @storage_node_count.setter
    def storage_node_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "storage_node_count", value)

    @property
    @pulumi.getter
    def timezone(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "timezone")

    @timezone.setter
    def timezone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "timezone", value)


@pulumi.input_type
class _FoundationCentralImageClusterState:
    def __init__(__self__, *,
                 aos_package_sha256sum: Optional[pulumi.Input[str]] = None,
                 aos_package_url: Optional[pulumi.Input[str]] = None,
                 archived: Optional[pulumi.Input[bool]] = None,
                 cluster_external_ip: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 cluster_size: Optional[pulumi.Input[int]] = None,
                 cluster_status: Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']] = None,
                 common_network_settings: Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']] = None,
                 created_timestamp: Optional[pulumi.Input[str]] = None,
                 current_time: Optional[pulumi.Input[str]] = None,
                 destroyed: Optional[pulumi.Input[bool]] = None,
                 foundation_init_configs: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterFoundationInitConfigArgs']]]] = None,
                 foundation_init_node_uuid: Optional[pulumi.Input[str]] = None,
                 hypervisor_iso_details: Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']] = None,
                 image_cluster_uuid: Optional[pulumi.Input[str]] = None,
                 imaged_cluster_uuid: Optional[pulumi.Input[str]] = None,
                 imaged_node_uuid_lists: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 node_lists: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]] = None,
                 redundancy_factor: Optional[pulumi.Input[int]] = None,
                 skip_cluster_creation: Optional[pulumi.Input[bool]] = None,
                 storage_node_count: Optional[pulumi.Input[int]] = None,
                 timezone: Optional[pulumi.Input[str]] = None,
                 workflow_type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering FoundationCentralImageCluster resources.
        """
        if aos_package_sha256sum is not None:
            pulumi.set(__self__, "aos_package_sha256sum", aos_package_sha256sum)
        if aos_package_url is not None:
            pulumi.set(__self__, "aos_package_url", aos_package_url)
        if archived is not None:
            pulumi.set(__self__, "archived", archived)
        if cluster_external_ip is not None:
            pulumi.set(__self__, "cluster_external_ip", cluster_external_ip)
        if cluster_name is not None:
            pulumi.set(__self__, "cluster_name", cluster_name)
        if cluster_size is not None:
            pulumi.set(__self__, "cluster_size", cluster_size)
        if cluster_status is not None:
            pulumi.set(__self__, "cluster_status", cluster_status)
        if common_network_settings is not None:
            pulumi.set(__self__, "common_network_settings", common_network_settings)
        if created_timestamp is not None:
            pulumi.set(__self__, "created_timestamp", created_timestamp)
        if current_time is not None:
            pulumi.set(__self__, "current_time", current_time)
        if destroyed is not None:
            pulumi.set(__self__, "destroyed", destroyed)
        if foundation_init_configs is not None:
            pulumi.set(__self__, "foundation_init_configs", foundation_init_configs)
        if foundation_init_node_uuid is not None:
            pulumi.set(__self__, "foundation_init_node_uuid", foundation_init_node_uuid)
        if hypervisor_iso_details is not None:
            pulumi.set(__self__, "hypervisor_iso_details", hypervisor_iso_details)
        if image_cluster_uuid is not None:
            pulumi.set(__self__, "image_cluster_uuid", image_cluster_uuid)
        if imaged_cluster_uuid is not None:
            pulumi.set(__self__, "imaged_cluster_uuid", imaged_cluster_uuid)
        if imaged_node_uuid_lists is not None:
            pulumi.set(__self__, "imaged_node_uuid_lists", imaged_node_uuid_lists)
        if node_lists is not None:
            pulumi.set(__self__, "node_lists", node_lists)
        if redundancy_factor is not None:
            pulumi.set(__self__, "redundancy_factor", redundancy_factor)
        if skip_cluster_creation is not None:
            pulumi.set(__self__, "skip_cluster_creation", skip_cluster_creation)
        if storage_node_count is not None:
            pulumi.set(__self__, "storage_node_count", storage_node_count)
        if timezone is not None:
            pulumi.set(__self__, "timezone", timezone)
        if workflow_type is not None:
            pulumi.set(__self__, "workflow_type", workflow_type)

    @property
    @pulumi.getter(name="aosPackageSha256sum")
    def aos_package_sha256sum(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "aos_package_sha256sum")

    @aos_package_sha256sum.setter
    def aos_package_sha256sum(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aos_package_sha256sum", value)

    @property
    @pulumi.getter(name="aosPackageUrl")
    def aos_package_url(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "aos_package_url")

    @aos_package_url.setter
    def aos_package_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "aos_package_url", value)

    @property
    @pulumi.getter
    def archived(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "archived")

    @archived.setter
    def archived(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "archived", value)

    @property
    @pulumi.getter(name="clusterExternalIp")
    def cluster_external_ip(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_external_ip")

    @cluster_external_ip.setter
    def cluster_external_ip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_external_ip", value)

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_name")

    @cluster_name.setter
    def cluster_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_name", value)

    @property
    @pulumi.getter(name="clusterSize")
    def cluster_size(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "cluster_size")

    @cluster_size.setter
    def cluster_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cluster_size", value)

    @property
    @pulumi.getter(name="clusterStatus")
    def cluster_status(self) -> Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']]:
        return pulumi.get(self, "cluster_status")

    @cluster_status.setter
    def cluster_status(self, value: Optional[pulumi.Input['FoundationCentralImageClusterClusterStatusArgs']]):
        pulumi.set(self, "cluster_status", value)

    @property
    @pulumi.getter(name="commonNetworkSettings")
    def common_network_settings(self) -> Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']]:
        return pulumi.get(self, "common_network_settings")

    @common_network_settings.setter
    def common_network_settings(self, value: Optional[pulumi.Input['FoundationCentralImageClusterCommonNetworkSettingsArgs']]):
        pulumi.set(self, "common_network_settings", value)

    @property
    @pulumi.getter(name="createdTimestamp")
    def created_timestamp(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "created_timestamp")

    @created_timestamp.setter
    def created_timestamp(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_timestamp", value)

    @property
    @pulumi.getter(name="currentTime")
    def current_time(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "current_time")

    @current_time.setter
    def current_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "current_time", value)

    @property
    @pulumi.getter
    def destroyed(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "destroyed")

    @destroyed.setter
    def destroyed(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "destroyed", value)

    @property
    @pulumi.getter(name="foundationInitConfigs")
    def foundation_init_configs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterFoundationInitConfigArgs']]]]:
        return pulumi.get(self, "foundation_init_configs")

    @foundation_init_configs.setter
    def foundation_init_configs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterFoundationInitConfigArgs']]]]):
        pulumi.set(self, "foundation_init_configs", value)

    @property
    @pulumi.getter(name="foundationInitNodeUuid")
    def foundation_init_node_uuid(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "foundation_init_node_uuid")

    @foundation_init_node_uuid.setter
    def foundation_init_node_uuid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "foundation_init_node_uuid", value)

    @property
    @pulumi.getter(name="hypervisorIsoDetails")
    def hypervisor_iso_details(self) -> Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]:
        return pulumi.get(self, "hypervisor_iso_details")

    @hypervisor_iso_details.setter
    def hypervisor_iso_details(self, value: Optional[pulumi.Input['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]):
        pulumi.set(self, "hypervisor_iso_details", value)

    @property
    @pulumi.getter(name="imageClusterUuid")
    def image_cluster_uuid(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "image_cluster_uuid")

    @image_cluster_uuid.setter
    def image_cluster_uuid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image_cluster_uuid", value)

    @property
    @pulumi.getter(name="imagedClusterUuid")
    def imaged_cluster_uuid(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "imaged_cluster_uuid")

    @imaged_cluster_uuid.setter
    def imaged_cluster_uuid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "imaged_cluster_uuid", value)

    @property
    @pulumi.getter(name="imagedNodeUuidLists")
    def imaged_node_uuid_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "imaged_node_uuid_lists")

    @imaged_node_uuid_lists.setter
    def imaged_node_uuid_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "imaged_node_uuid_lists", value)

    @property
    @pulumi.getter(name="nodeLists")
    def node_lists(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]]:
        return pulumi.get(self, "node_lists")

    @node_lists.setter
    def node_lists(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FoundationCentralImageClusterNodeListArgs']]]]):
        pulumi.set(self, "node_lists", value)

    @property
    @pulumi.getter(name="redundancyFactor")
    def redundancy_factor(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "redundancy_factor")

    @redundancy_factor.setter
    def redundancy_factor(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "redundancy_factor", value)

    @property
    @pulumi.getter(name="skipClusterCreation")
    def skip_cluster_creation(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "skip_cluster_creation")

    @skip_cluster_creation.setter
    def skip_cluster_creation(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "skip_cluster_creation", value)

    @property
    @pulumi.getter(name="storageNodeCount")
    def storage_node_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "storage_node_count")

    @storage_node_count.setter
    def storage_node_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "storage_node_count", value)

    @property
    @pulumi.getter
    def timezone(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "timezone")

    @timezone.setter
    def timezone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "timezone", value)

    @property
    @pulumi.getter(name="workflowType")
    def workflow_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "workflow_type")

    @workflow_type.setter
    def workflow_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "workflow_type", value)


class FoundationCentralImageCluster(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aos_package_sha256sum: Optional[pulumi.Input[str]] = None,
                 aos_package_url: Optional[pulumi.Input[str]] = None,
                 cluster_external_ip: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 cluster_size: Optional[pulumi.Input[int]] = None,
                 cluster_status: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterClusterStatusArgs']]] = None,
                 common_network_settings: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterCommonNetworkSettingsArgs']]] = None,
                 hypervisor_iso_details: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]] = None,
                 image_cluster_uuid: Optional[pulumi.Input[str]] = None,
                 node_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterNodeListArgs']]]]] = None,
                 redundancy_factor: Optional[pulumi.Input[int]] = None,
                 skip_cluster_creation: Optional[pulumi.Input[bool]] = None,
                 storage_node_count: Optional[pulumi.Input[int]] = None,
                 timezone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a FoundationCentralImageCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[FoundationCentralImageClusterArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a FoundationCentralImageCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param FoundationCentralImageClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FoundationCentralImageClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aos_package_sha256sum: Optional[pulumi.Input[str]] = None,
                 aos_package_url: Optional[pulumi.Input[str]] = None,
                 cluster_external_ip: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 cluster_size: Optional[pulumi.Input[int]] = None,
                 cluster_status: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterClusterStatusArgs']]] = None,
                 common_network_settings: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterCommonNetworkSettingsArgs']]] = None,
                 hypervisor_iso_details: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]] = None,
                 image_cluster_uuid: Optional[pulumi.Input[str]] = None,
                 node_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterNodeListArgs']]]]] = None,
                 redundancy_factor: Optional[pulumi.Input[int]] = None,
                 skip_cluster_creation: Optional[pulumi.Input[bool]] = None,
                 storage_node_count: Optional[pulumi.Input[int]] = None,
                 timezone: Optional[pulumi.Input[str]] = None,
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
            __props__ = FoundationCentralImageClusterArgs.__new__(FoundationCentralImageClusterArgs)

            __props__.__dict__["aos_package_sha256sum"] = aos_package_sha256sum
            __props__.__dict__["aos_package_url"] = aos_package_url
            __props__.__dict__["cluster_external_ip"] = cluster_external_ip
            __props__.__dict__["cluster_name"] = cluster_name
            __props__.__dict__["cluster_size"] = cluster_size
            __props__.__dict__["cluster_status"] = cluster_status
            __props__.__dict__["common_network_settings"] = common_network_settings
            __props__.__dict__["hypervisor_iso_details"] = hypervisor_iso_details
            __props__.__dict__["image_cluster_uuid"] = image_cluster_uuid
            __props__.__dict__["node_lists"] = node_lists
            __props__.__dict__["redundancy_factor"] = redundancy_factor
            __props__.__dict__["skip_cluster_creation"] = skip_cluster_creation
            __props__.__dict__["storage_node_count"] = storage_node_count
            __props__.__dict__["timezone"] = timezone
            __props__.__dict__["archived"] = None
            __props__.__dict__["created_timestamp"] = None
            __props__.__dict__["current_time"] = None
            __props__.__dict__["destroyed"] = None
            __props__.__dict__["foundation_init_configs"] = None
            __props__.__dict__["foundation_init_node_uuid"] = None
            __props__.__dict__["imaged_cluster_uuid"] = None
            __props__.__dict__["imaged_node_uuid_lists"] = None
            __props__.__dict__["workflow_type"] = None
        super(FoundationCentralImageCluster, __self__).__init__(
            'nutanix:index/foundationCentralImageCluster:FoundationCentralImageCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            aos_package_sha256sum: Optional[pulumi.Input[str]] = None,
            aos_package_url: Optional[pulumi.Input[str]] = None,
            archived: Optional[pulumi.Input[bool]] = None,
            cluster_external_ip: Optional[pulumi.Input[str]] = None,
            cluster_name: Optional[pulumi.Input[str]] = None,
            cluster_size: Optional[pulumi.Input[int]] = None,
            cluster_status: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterClusterStatusArgs']]] = None,
            common_network_settings: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterCommonNetworkSettingsArgs']]] = None,
            created_timestamp: Optional[pulumi.Input[str]] = None,
            current_time: Optional[pulumi.Input[str]] = None,
            destroyed: Optional[pulumi.Input[bool]] = None,
            foundation_init_configs: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterFoundationInitConfigArgs']]]]] = None,
            foundation_init_node_uuid: Optional[pulumi.Input[str]] = None,
            hypervisor_iso_details: Optional[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterHypervisorIsoDetailsArgs']]] = None,
            image_cluster_uuid: Optional[pulumi.Input[str]] = None,
            imaged_cluster_uuid: Optional[pulumi.Input[str]] = None,
            imaged_node_uuid_lists: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            node_lists: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FoundationCentralImageClusterNodeListArgs']]]]] = None,
            redundancy_factor: Optional[pulumi.Input[int]] = None,
            skip_cluster_creation: Optional[pulumi.Input[bool]] = None,
            storage_node_count: Optional[pulumi.Input[int]] = None,
            timezone: Optional[pulumi.Input[str]] = None,
            workflow_type: Optional[pulumi.Input[str]] = None) -> 'FoundationCentralImageCluster':
        """
        Get an existing FoundationCentralImageCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FoundationCentralImageClusterState.__new__(_FoundationCentralImageClusterState)

        __props__.__dict__["aos_package_sha256sum"] = aos_package_sha256sum
        __props__.__dict__["aos_package_url"] = aos_package_url
        __props__.__dict__["archived"] = archived
        __props__.__dict__["cluster_external_ip"] = cluster_external_ip
        __props__.__dict__["cluster_name"] = cluster_name
        __props__.__dict__["cluster_size"] = cluster_size
        __props__.__dict__["cluster_status"] = cluster_status
        __props__.__dict__["common_network_settings"] = common_network_settings
        __props__.__dict__["created_timestamp"] = created_timestamp
        __props__.__dict__["current_time"] = current_time
        __props__.__dict__["destroyed"] = destroyed
        __props__.__dict__["foundation_init_configs"] = foundation_init_configs
        __props__.__dict__["foundation_init_node_uuid"] = foundation_init_node_uuid
        __props__.__dict__["hypervisor_iso_details"] = hypervisor_iso_details
        __props__.__dict__["image_cluster_uuid"] = image_cluster_uuid
        __props__.__dict__["imaged_cluster_uuid"] = imaged_cluster_uuid
        __props__.__dict__["imaged_node_uuid_lists"] = imaged_node_uuid_lists
        __props__.__dict__["node_lists"] = node_lists
        __props__.__dict__["redundancy_factor"] = redundancy_factor
        __props__.__dict__["skip_cluster_creation"] = skip_cluster_creation
        __props__.__dict__["storage_node_count"] = storage_node_count
        __props__.__dict__["timezone"] = timezone
        __props__.__dict__["workflow_type"] = workflow_type
        return FoundationCentralImageCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aosPackageSha256sum")
    def aos_package_sha256sum(self) -> pulumi.Output[str]:
        return pulumi.get(self, "aos_package_sha256sum")

    @property
    @pulumi.getter(name="aosPackageUrl")
    def aos_package_url(self) -> pulumi.Output[str]:
        return pulumi.get(self, "aos_package_url")

    @property
    @pulumi.getter
    def archived(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "archived")

    @property
    @pulumi.getter(name="clusterExternalIp")
    def cluster_external_ip(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cluster_external_ip")

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cluster_name")

    @property
    @pulumi.getter(name="clusterSize")
    def cluster_size(self) -> pulumi.Output[int]:
        return pulumi.get(self, "cluster_size")

    @property
    @pulumi.getter(name="clusterStatus")
    def cluster_status(self) -> pulumi.Output['outputs.FoundationCentralImageClusterClusterStatus']:
        return pulumi.get(self, "cluster_status")

    @property
    @pulumi.getter(name="commonNetworkSettings")
    def common_network_settings(self) -> pulumi.Output['outputs.FoundationCentralImageClusterCommonNetworkSettings']:
        return pulumi.get(self, "common_network_settings")

    @property
    @pulumi.getter(name="createdTimestamp")
    def created_timestamp(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_timestamp")

    @property
    @pulumi.getter(name="currentTime")
    def current_time(self) -> pulumi.Output[str]:
        return pulumi.get(self, "current_time")

    @property
    @pulumi.getter
    def destroyed(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "destroyed")

    @property
    @pulumi.getter(name="foundationInitConfigs")
    def foundation_init_configs(self) -> pulumi.Output[Sequence['outputs.FoundationCentralImageClusterFoundationInitConfig']]:
        return pulumi.get(self, "foundation_init_configs")

    @property
    @pulumi.getter(name="foundationInitNodeUuid")
    def foundation_init_node_uuid(self) -> pulumi.Output[str]:
        return pulumi.get(self, "foundation_init_node_uuid")

    @property
    @pulumi.getter(name="hypervisorIsoDetails")
    def hypervisor_iso_details(self) -> pulumi.Output['outputs.FoundationCentralImageClusterHypervisorIsoDetails']:
        return pulumi.get(self, "hypervisor_iso_details")

    @property
    @pulumi.getter(name="imageClusterUuid")
    def image_cluster_uuid(self) -> pulumi.Output[str]:
        return pulumi.get(self, "image_cluster_uuid")

    @property
    @pulumi.getter(name="imagedClusterUuid")
    def imaged_cluster_uuid(self) -> pulumi.Output[str]:
        return pulumi.get(self, "imaged_cluster_uuid")

    @property
    @pulumi.getter(name="imagedNodeUuidLists")
    def imaged_node_uuid_lists(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "imaged_node_uuid_lists")

    @property
    @pulumi.getter(name="nodeLists")
    def node_lists(self) -> pulumi.Output[Sequence['outputs.FoundationCentralImageClusterNodeList']]:
        return pulumi.get(self, "node_lists")

    @property
    @pulumi.getter(name="redundancyFactor")
    def redundancy_factor(self) -> pulumi.Output[int]:
        return pulumi.get(self, "redundancy_factor")

    @property
    @pulumi.getter(name="skipClusterCreation")
    def skip_cluster_creation(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "skip_cluster_creation")

    @property
    @pulumi.getter(name="storageNodeCount")
    def storage_node_count(self) -> pulumi.Output[int]:
        return pulumi.get(self, "storage_node_count")

    @property
    @pulumi.getter
    def timezone(self) -> pulumi.Output[str]:
        return pulumi.get(self, "timezone")

    @property
    @pulumi.getter(name="workflowType")
    def workflow_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "workflow_type")
