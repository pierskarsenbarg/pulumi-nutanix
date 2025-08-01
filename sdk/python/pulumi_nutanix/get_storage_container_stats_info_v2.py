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
    'GetStorageContainerStatsInfoV2Result',
    'AwaitableGetStorageContainerStatsInfoV2Result',
    'get_storage_container_stats_info_v2',
    'get_storage_container_stats_info_v2_output',
]

@pulumi.output_type
class GetStorageContainerStatsInfoV2Result:
    """
    A collection of values returned by getStorageContainerStatsInfoV2.
    """
    def __init__(__self__, container_ext_id=None, controller_avg_io_latencyu_secs=None, controller_avg_read_io_latencyu_secs=None, controller_avg_write_io_latencyu_secs=None, controller_io_bandwidth_kbps=None, controller_num_iops=None, controller_num_read_iops=None, controller_num_write_iops=None, controller_read_io_bandwidth_kbps=None, controller_read_io_ratio_ppms=None, controller_write_io_bandwidth_kbps=None, controller_write_io_ratio_ppms=None, data_reduction_clone_saving_ratio_ppms=None, data_reduction_compression_saving_ratio_ppms=None, data_reduction_dedup_saving_ratio_ppms=None, data_reduction_erasure_coding_saving_ratio_ppms=None, data_reduction_overall_post_reduction_bytes=None, data_reduction_overall_pre_reduction_bytes=None, data_reduction_saved_bytes=None, data_reduction_saving_ratio_ppms=None, data_reduction_snapshot_saving_ratio_ppms=None, data_reduction_thin_provision_saving_ratio_ppms=None, data_reduction_total_saving_ratio_ppms=None, data_reduction_zero_write_savings_bytes=None, end_time=None, ext_id=None, healths=None, id=None, links=None, sampling_interval=None, start_time=None, stat_type=None, storage_actual_physical_usage_bytes=None, storage_capacity_bytes=None, storage_free_bytes=None, storage_replication_factors=None, storage_reserved_capacity_bytes=None, storage_tier_das_sata_usage_bytes=None, storage_tier_ssd_usage_bytes=None, storage_usage_bytes=None, tenant_id=None):
        if container_ext_id and not isinstance(container_ext_id, str):
            raise TypeError("Expected argument 'container_ext_id' to be a str")
        pulumi.set(__self__, "container_ext_id", container_ext_id)
        if controller_avg_io_latencyu_secs and not isinstance(controller_avg_io_latencyu_secs, list):
            raise TypeError("Expected argument 'controller_avg_io_latencyu_secs' to be a list")
        pulumi.set(__self__, "controller_avg_io_latencyu_secs", controller_avg_io_latencyu_secs)
        if controller_avg_read_io_latencyu_secs and not isinstance(controller_avg_read_io_latencyu_secs, list):
            raise TypeError("Expected argument 'controller_avg_read_io_latencyu_secs' to be a list")
        pulumi.set(__self__, "controller_avg_read_io_latencyu_secs", controller_avg_read_io_latencyu_secs)
        if controller_avg_write_io_latencyu_secs and not isinstance(controller_avg_write_io_latencyu_secs, list):
            raise TypeError("Expected argument 'controller_avg_write_io_latencyu_secs' to be a list")
        pulumi.set(__self__, "controller_avg_write_io_latencyu_secs", controller_avg_write_io_latencyu_secs)
        if controller_io_bandwidth_kbps and not isinstance(controller_io_bandwidth_kbps, list):
            raise TypeError("Expected argument 'controller_io_bandwidth_kbps' to be a list")
        pulumi.set(__self__, "controller_io_bandwidth_kbps", controller_io_bandwidth_kbps)
        if controller_num_iops and not isinstance(controller_num_iops, list):
            raise TypeError("Expected argument 'controller_num_iops' to be a list")
        pulumi.set(__self__, "controller_num_iops", controller_num_iops)
        if controller_num_read_iops and not isinstance(controller_num_read_iops, list):
            raise TypeError("Expected argument 'controller_num_read_iops' to be a list")
        pulumi.set(__self__, "controller_num_read_iops", controller_num_read_iops)
        if controller_num_write_iops and not isinstance(controller_num_write_iops, list):
            raise TypeError("Expected argument 'controller_num_write_iops' to be a list")
        pulumi.set(__self__, "controller_num_write_iops", controller_num_write_iops)
        if controller_read_io_bandwidth_kbps and not isinstance(controller_read_io_bandwidth_kbps, list):
            raise TypeError("Expected argument 'controller_read_io_bandwidth_kbps' to be a list")
        pulumi.set(__self__, "controller_read_io_bandwidth_kbps", controller_read_io_bandwidth_kbps)
        if controller_read_io_ratio_ppms and not isinstance(controller_read_io_ratio_ppms, list):
            raise TypeError("Expected argument 'controller_read_io_ratio_ppms' to be a list")
        pulumi.set(__self__, "controller_read_io_ratio_ppms", controller_read_io_ratio_ppms)
        if controller_write_io_bandwidth_kbps and not isinstance(controller_write_io_bandwidth_kbps, list):
            raise TypeError("Expected argument 'controller_write_io_bandwidth_kbps' to be a list")
        pulumi.set(__self__, "controller_write_io_bandwidth_kbps", controller_write_io_bandwidth_kbps)
        if controller_write_io_ratio_ppms and not isinstance(controller_write_io_ratio_ppms, list):
            raise TypeError("Expected argument 'controller_write_io_ratio_ppms' to be a list")
        pulumi.set(__self__, "controller_write_io_ratio_ppms", controller_write_io_ratio_ppms)
        if data_reduction_clone_saving_ratio_ppms and not isinstance(data_reduction_clone_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_clone_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_clone_saving_ratio_ppms", data_reduction_clone_saving_ratio_ppms)
        if data_reduction_compression_saving_ratio_ppms and not isinstance(data_reduction_compression_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_compression_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_compression_saving_ratio_ppms", data_reduction_compression_saving_ratio_ppms)
        if data_reduction_dedup_saving_ratio_ppms and not isinstance(data_reduction_dedup_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_dedup_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_dedup_saving_ratio_ppms", data_reduction_dedup_saving_ratio_ppms)
        if data_reduction_erasure_coding_saving_ratio_ppms and not isinstance(data_reduction_erasure_coding_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_erasure_coding_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_erasure_coding_saving_ratio_ppms", data_reduction_erasure_coding_saving_ratio_ppms)
        if data_reduction_overall_post_reduction_bytes and not isinstance(data_reduction_overall_post_reduction_bytes, list):
            raise TypeError("Expected argument 'data_reduction_overall_post_reduction_bytes' to be a list")
        pulumi.set(__self__, "data_reduction_overall_post_reduction_bytes", data_reduction_overall_post_reduction_bytes)
        if data_reduction_overall_pre_reduction_bytes and not isinstance(data_reduction_overall_pre_reduction_bytes, list):
            raise TypeError("Expected argument 'data_reduction_overall_pre_reduction_bytes' to be a list")
        pulumi.set(__self__, "data_reduction_overall_pre_reduction_bytes", data_reduction_overall_pre_reduction_bytes)
        if data_reduction_saved_bytes and not isinstance(data_reduction_saved_bytes, list):
            raise TypeError("Expected argument 'data_reduction_saved_bytes' to be a list")
        pulumi.set(__self__, "data_reduction_saved_bytes", data_reduction_saved_bytes)
        if data_reduction_saving_ratio_ppms and not isinstance(data_reduction_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_saving_ratio_ppms", data_reduction_saving_ratio_ppms)
        if data_reduction_snapshot_saving_ratio_ppms and not isinstance(data_reduction_snapshot_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_snapshot_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_snapshot_saving_ratio_ppms", data_reduction_snapshot_saving_ratio_ppms)
        if data_reduction_thin_provision_saving_ratio_ppms and not isinstance(data_reduction_thin_provision_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_thin_provision_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_thin_provision_saving_ratio_ppms", data_reduction_thin_provision_saving_ratio_ppms)
        if data_reduction_total_saving_ratio_ppms and not isinstance(data_reduction_total_saving_ratio_ppms, list):
            raise TypeError("Expected argument 'data_reduction_total_saving_ratio_ppms' to be a list")
        pulumi.set(__self__, "data_reduction_total_saving_ratio_ppms", data_reduction_total_saving_ratio_ppms)
        if data_reduction_zero_write_savings_bytes and not isinstance(data_reduction_zero_write_savings_bytes, list):
            raise TypeError("Expected argument 'data_reduction_zero_write_savings_bytes' to be a list")
        pulumi.set(__self__, "data_reduction_zero_write_savings_bytes", data_reduction_zero_write_savings_bytes)
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if ext_id and not isinstance(ext_id, str):
            raise TypeError("Expected argument 'ext_id' to be a str")
        pulumi.set(__self__, "ext_id", ext_id)
        if healths and not isinstance(healths, list):
            raise TypeError("Expected argument 'healths' to be a list")
        pulumi.set(__self__, "healths", healths)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if links and not isinstance(links, list):
            raise TypeError("Expected argument 'links' to be a list")
        pulumi.set(__self__, "links", links)
        if sampling_interval and not isinstance(sampling_interval, int):
            raise TypeError("Expected argument 'sampling_interval' to be a int")
        pulumi.set(__self__, "sampling_interval", sampling_interval)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)
        if stat_type and not isinstance(stat_type, str):
            raise TypeError("Expected argument 'stat_type' to be a str")
        pulumi.set(__self__, "stat_type", stat_type)
        if storage_actual_physical_usage_bytes and not isinstance(storage_actual_physical_usage_bytes, list):
            raise TypeError("Expected argument 'storage_actual_physical_usage_bytes' to be a list")
        pulumi.set(__self__, "storage_actual_physical_usage_bytes", storage_actual_physical_usage_bytes)
        if storage_capacity_bytes and not isinstance(storage_capacity_bytes, list):
            raise TypeError("Expected argument 'storage_capacity_bytes' to be a list")
        pulumi.set(__self__, "storage_capacity_bytes", storage_capacity_bytes)
        if storage_free_bytes and not isinstance(storage_free_bytes, list):
            raise TypeError("Expected argument 'storage_free_bytes' to be a list")
        pulumi.set(__self__, "storage_free_bytes", storage_free_bytes)
        if storage_replication_factors and not isinstance(storage_replication_factors, list):
            raise TypeError("Expected argument 'storage_replication_factors' to be a list")
        pulumi.set(__self__, "storage_replication_factors", storage_replication_factors)
        if storage_reserved_capacity_bytes and not isinstance(storage_reserved_capacity_bytes, list):
            raise TypeError("Expected argument 'storage_reserved_capacity_bytes' to be a list")
        pulumi.set(__self__, "storage_reserved_capacity_bytes", storage_reserved_capacity_bytes)
        if storage_tier_das_sata_usage_bytes and not isinstance(storage_tier_das_sata_usage_bytes, list):
            raise TypeError("Expected argument 'storage_tier_das_sata_usage_bytes' to be a list")
        pulumi.set(__self__, "storage_tier_das_sata_usage_bytes", storage_tier_das_sata_usage_bytes)
        if storage_tier_ssd_usage_bytes and not isinstance(storage_tier_ssd_usage_bytes, list):
            raise TypeError("Expected argument 'storage_tier_ssd_usage_bytes' to be a list")
        pulumi.set(__self__, "storage_tier_ssd_usage_bytes", storage_tier_ssd_usage_bytes)
        if storage_usage_bytes and not isinstance(storage_usage_bytes, list):
            raise TypeError("Expected argument 'storage_usage_bytes' to be a list")
        pulumi.set(__self__, "storage_usage_bytes", storage_usage_bytes)
        if tenant_id and not isinstance(tenant_id, str):
            raise TypeError("Expected argument 'tenant_id' to be a str")
        pulumi.set(__self__, "tenant_id", tenant_id)

    @property
    @pulumi.getter(name="containerExtId")
    def container_ext_id(self) -> builtins.str:
        return pulumi.get(self, "container_ext_id")

    @property
    @pulumi.getter(name="controllerAvgIoLatencyuSecs")
    def controller_avg_io_latencyu_secs(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerAvgIoLatencyuSecResult']:
        return pulumi.get(self, "controller_avg_io_latencyu_secs")

    @property
    @pulumi.getter(name="controllerAvgReadIoLatencyuSecs")
    def controller_avg_read_io_latencyu_secs(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerAvgReadIoLatencyuSecResult']:
        return pulumi.get(self, "controller_avg_read_io_latencyu_secs")

    @property
    @pulumi.getter(name="controllerAvgWriteIoLatencyuSecs")
    def controller_avg_write_io_latencyu_secs(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerAvgWriteIoLatencyuSecResult']:
        return pulumi.get(self, "controller_avg_write_io_latencyu_secs")

    @property
    @pulumi.getter(name="controllerIoBandwidthKbps")
    def controller_io_bandwidth_kbps(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerIoBandwidthKbpResult']:
        return pulumi.get(self, "controller_io_bandwidth_kbps")

    @property
    @pulumi.getter(name="controllerNumIops")
    def controller_num_iops(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerNumIopResult']:
        return pulumi.get(self, "controller_num_iops")

    @property
    @pulumi.getter(name="controllerNumReadIops")
    def controller_num_read_iops(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerNumReadIopResult']:
        return pulumi.get(self, "controller_num_read_iops")

    @property
    @pulumi.getter(name="controllerNumWriteIops")
    def controller_num_write_iops(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerNumWriteIopResult']:
        return pulumi.get(self, "controller_num_write_iops")

    @property
    @pulumi.getter(name="controllerReadIoBandwidthKbps")
    def controller_read_io_bandwidth_kbps(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerReadIoBandwidthKbpResult']:
        return pulumi.get(self, "controller_read_io_bandwidth_kbps")

    @property
    @pulumi.getter(name="controllerReadIoRatioPpms")
    def controller_read_io_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerReadIoRatioPpmResult']:
        return pulumi.get(self, "controller_read_io_ratio_ppms")

    @property
    @pulumi.getter(name="controllerWriteIoBandwidthKbps")
    def controller_write_io_bandwidth_kbps(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerWriteIoBandwidthKbpResult']:
        return pulumi.get(self, "controller_write_io_bandwidth_kbps")

    @property
    @pulumi.getter(name="controllerWriteIoRatioPpms")
    def controller_write_io_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2ControllerWriteIoRatioPpmResult']:
        return pulumi.get(self, "controller_write_io_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionCloneSavingRatioPpms")
    def data_reduction_clone_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionCloneSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_clone_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionCompressionSavingRatioPpms")
    def data_reduction_compression_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionCompressionSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_compression_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionDedupSavingRatioPpms")
    def data_reduction_dedup_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionDedupSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_dedup_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionErasureCodingSavingRatioPpms")
    def data_reduction_erasure_coding_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionErasureCodingSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_erasure_coding_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionOverallPostReductionBytes")
    def data_reduction_overall_post_reduction_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionOverallPostReductionByteResult']:
        return pulumi.get(self, "data_reduction_overall_post_reduction_bytes")

    @property
    @pulumi.getter(name="dataReductionOverallPreReductionBytes")
    def data_reduction_overall_pre_reduction_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionOverallPreReductionByteResult']:
        return pulumi.get(self, "data_reduction_overall_pre_reduction_bytes")

    @property
    @pulumi.getter(name="dataReductionSavedBytes")
    def data_reduction_saved_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionSavedByteResult']:
        return pulumi.get(self, "data_reduction_saved_bytes")

    @property
    @pulumi.getter(name="dataReductionSavingRatioPpms")
    def data_reduction_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionSnapshotSavingRatioPpms")
    def data_reduction_snapshot_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionSnapshotSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_snapshot_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionThinProvisionSavingRatioPpms")
    def data_reduction_thin_provision_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionThinProvisionSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_thin_provision_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionTotalSavingRatioPpms")
    def data_reduction_total_saving_ratio_ppms(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionTotalSavingRatioPpmResult']:
        return pulumi.get(self, "data_reduction_total_saving_ratio_ppms")

    @property
    @pulumi.getter(name="dataReductionZeroWriteSavingsBytes")
    def data_reduction_zero_write_savings_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2DataReductionZeroWriteSavingsByteResult']:
        return pulumi.get(self, "data_reduction_zero_write_savings_bytes")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> builtins.str:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="extId")
    def ext_id(self) -> builtins.str:
        return pulumi.get(self, "ext_id")

    @property
    @pulumi.getter
    def healths(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2HealthResult']:
        return pulumi.get(self, "healths")

    @property
    @pulumi.getter
    def id(self) -> builtins.str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def links(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2LinkResult']:
        return pulumi.get(self, "links")

    @property
    @pulumi.getter(name="samplingInterval")
    def sampling_interval(self) -> Optional[builtins.int]:
        return pulumi.get(self, "sampling_interval")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> builtins.str:
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter(name="statType")
    def stat_type(self) -> Optional[builtins.str]:
        return pulumi.get(self, "stat_type")

    @property
    @pulumi.getter(name="storageActualPhysicalUsageBytes")
    def storage_actual_physical_usage_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageActualPhysicalUsageByteResult']:
        return pulumi.get(self, "storage_actual_physical_usage_bytes")

    @property
    @pulumi.getter(name="storageCapacityBytes")
    def storage_capacity_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageCapacityByteResult']:
        return pulumi.get(self, "storage_capacity_bytes")

    @property
    @pulumi.getter(name="storageFreeBytes")
    def storage_free_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageFreeByteResult']:
        return pulumi.get(self, "storage_free_bytes")

    @property
    @pulumi.getter(name="storageReplicationFactors")
    def storage_replication_factors(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageReplicationFactorResult']:
        return pulumi.get(self, "storage_replication_factors")

    @property
    @pulumi.getter(name="storageReservedCapacityBytes")
    def storage_reserved_capacity_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageReservedCapacityByteResult']:
        return pulumi.get(self, "storage_reserved_capacity_bytes")

    @property
    @pulumi.getter(name="storageTierDasSataUsageBytes")
    def storage_tier_das_sata_usage_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageTierDasSataUsageByteResult']:
        return pulumi.get(self, "storage_tier_das_sata_usage_bytes")

    @property
    @pulumi.getter(name="storageTierSsdUsageBytes")
    def storage_tier_ssd_usage_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageTierSsdUsageByteResult']:
        return pulumi.get(self, "storage_tier_ssd_usage_bytes")

    @property
    @pulumi.getter(name="storageUsageBytes")
    def storage_usage_bytes(self) -> Sequence['outputs.GetStorageContainerStatsInfoV2StorageUsageByteResult']:
        return pulumi.get(self, "storage_usage_bytes")

    @property
    @pulumi.getter(name="tenantId")
    def tenant_id(self) -> builtins.str:
        return pulumi.get(self, "tenant_id")


class AwaitableGetStorageContainerStatsInfoV2Result(GetStorageContainerStatsInfoV2Result):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetStorageContainerStatsInfoV2Result(
            container_ext_id=self.container_ext_id,
            controller_avg_io_latencyu_secs=self.controller_avg_io_latencyu_secs,
            controller_avg_read_io_latencyu_secs=self.controller_avg_read_io_latencyu_secs,
            controller_avg_write_io_latencyu_secs=self.controller_avg_write_io_latencyu_secs,
            controller_io_bandwidth_kbps=self.controller_io_bandwidth_kbps,
            controller_num_iops=self.controller_num_iops,
            controller_num_read_iops=self.controller_num_read_iops,
            controller_num_write_iops=self.controller_num_write_iops,
            controller_read_io_bandwidth_kbps=self.controller_read_io_bandwidth_kbps,
            controller_read_io_ratio_ppms=self.controller_read_io_ratio_ppms,
            controller_write_io_bandwidth_kbps=self.controller_write_io_bandwidth_kbps,
            controller_write_io_ratio_ppms=self.controller_write_io_ratio_ppms,
            data_reduction_clone_saving_ratio_ppms=self.data_reduction_clone_saving_ratio_ppms,
            data_reduction_compression_saving_ratio_ppms=self.data_reduction_compression_saving_ratio_ppms,
            data_reduction_dedup_saving_ratio_ppms=self.data_reduction_dedup_saving_ratio_ppms,
            data_reduction_erasure_coding_saving_ratio_ppms=self.data_reduction_erasure_coding_saving_ratio_ppms,
            data_reduction_overall_post_reduction_bytes=self.data_reduction_overall_post_reduction_bytes,
            data_reduction_overall_pre_reduction_bytes=self.data_reduction_overall_pre_reduction_bytes,
            data_reduction_saved_bytes=self.data_reduction_saved_bytes,
            data_reduction_saving_ratio_ppms=self.data_reduction_saving_ratio_ppms,
            data_reduction_snapshot_saving_ratio_ppms=self.data_reduction_snapshot_saving_ratio_ppms,
            data_reduction_thin_provision_saving_ratio_ppms=self.data_reduction_thin_provision_saving_ratio_ppms,
            data_reduction_total_saving_ratio_ppms=self.data_reduction_total_saving_ratio_ppms,
            data_reduction_zero_write_savings_bytes=self.data_reduction_zero_write_savings_bytes,
            end_time=self.end_time,
            ext_id=self.ext_id,
            healths=self.healths,
            id=self.id,
            links=self.links,
            sampling_interval=self.sampling_interval,
            start_time=self.start_time,
            stat_type=self.stat_type,
            storage_actual_physical_usage_bytes=self.storage_actual_physical_usage_bytes,
            storage_capacity_bytes=self.storage_capacity_bytes,
            storage_free_bytes=self.storage_free_bytes,
            storage_replication_factors=self.storage_replication_factors,
            storage_reserved_capacity_bytes=self.storage_reserved_capacity_bytes,
            storage_tier_das_sata_usage_bytes=self.storage_tier_das_sata_usage_bytes,
            storage_tier_ssd_usage_bytes=self.storage_tier_ssd_usage_bytes,
            storage_usage_bytes=self.storage_usage_bytes,
            tenant_id=self.tenant_id)


def get_storage_container_stats_info_v2(end_time: Optional[builtins.str] = None,
                                        ext_id: Optional[builtins.str] = None,
                                        sampling_interval: Optional[builtins.int] = None,
                                        start_time: Optional[builtins.str] = None,
                                        stat_type: Optional[builtins.str] = None,
                                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetStorageContainerStatsInfoV2Result:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['endTime'] = end_time
    __args__['extId'] = ext_id
    __args__['samplingInterval'] = sampling_interval
    __args__['startTime'] = start_time
    __args__['statType'] = stat_type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nutanix:index/getStorageContainerStatsInfoV2:getStorageContainerStatsInfoV2', __args__, opts=opts, typ=GetStorageContainerStatsInfoV2Result).value

    return AwaitableGetStorageContainerStatsInfoV2Result(
        container_ext_id=pulumi.get(__ret__, 'container_ext_id'),
        controller_avg_io_latencyu_secs=pulumi.get(__ret__, 'controller_avg_io_latencyu_secs'),
        controller_avg_read_io_latencyu_secs=pulumi.get(__ret__, 'controller_avg_read_io_latencyu_secs'),
        controller_avg_write_io_latencyu_secs=pulumi.get(__ret__, 'controller_avg_write_io_latencyu_secs'),
        controller_io_bandwidth_kbps=pulumi.get(__ret__, 'controller_io_bandwidth_kbps'),
        controller_num_iops=pulumi.get(__ret__, 'controller_num_iops'),
        controller_num_read_iops=pulumi.get(__ret__, 'controller_num_read_iops'),
        controller_num_write_iops=pulumi.get(__ret__, 'controller_num_write_iops'),
        controller_read_io_bandwidth_kbps=pulumi.get(__ret__, 'controller_read_io_bandwidth_kbps'),
        controller_read_io_ratio_ppms=pulumi.get(__ret__, 'controller_read_io_ratio_ppms'),
        controller_write_io_bandwidth_kbps=pulumi.get(__ret__, 'controller_write_io_bandwidth_kbps'),
        controller_write_io_ratio_ppms=pulumi.get(__ret__, 'controller_write_io_ratio_ppms'),
        data_reduction_clone_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_clone_saving_ratio_ppms'),
        data_reduction_compression_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_compression_saving_ratio_ppms'),
        data_reduction_dedup_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_dedup_saving_ratio_ppms'),
        data_reduction_erasure_coding_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_erasure_coding_saving_ratio_ppms'),
        data_reduction_overall_post_reduction_bytes=pulumi.get(__ret__, 'data_reduction_overall_post_reduction_bytes'),
        data_reduction_overall_pre_reduction_bytes=pulumi.get(__ret__, 'data_reduction_overall_pre_reduction_bytes'),
        data_reduction_saved_bytes=pulumi.get(__ret__, 'data_reduction_saved_bytes'),
        data_reduction_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_saving_ratio_ppms'),
        data_reduction_snapshot_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_snapshot_saving_ratio_ppms'),
        data_reduction_thin_provision_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_thin_provision_saving_ratio_ppms'),
        data_reduction_total_saving_ratio_ppms=pulumi.get(__ret__, 'data_reduction_total_saving_ratio_ppms'),
        data_reduction_zero_write_savings_bytes=pulumi.get(__ret__, 'data_reduction_zero_write_savings_bytes'),
        end_time=pulumi.get(__ret__, 'end_time'),
        ext_id=pulumi.get(__ret__, 'ext_id'),
        healths=pulumi.get(__ret__, 'healths'),
        id=pulumi.get(__ret__, 'id'),
        links=pulumi.get(__ret__, 'links'),
        sampling_interval=pulumi.get(__ret__, 'sampling_interval'),
        start_time=pulumi.get(__ret__, 'start_time'),
        stat_type=pulumi.get(__ret__, 'stat_type'),
        storage_actual_physical_usage_bytes=pulumi.get(__ret__, 'storage_actual_physical_usage_bytes'),
        storage_capacity_bytes=pulumi.get(__ret__, 'storage_capacity_bytes'),
        storage_free_bytes=pulumi.get(__ret__, 'storage_free_bytes'),
        storage_replication_factors=pulumi.get(__ret__, 'storage_replication_factors'),
        storage_reserved_capacity_bytes=pulumi.get(__ret__, 'storage_reserved_capacity_bytes'),
        storage_tier_das_sata_usage_bytes=pulumi.get(__ret__, 'storage_tier_das_sata_usage_bytes'),
        storage_tier_ssd_usage_bytes=pulumi.get(__ret__, 'storage_tier_ssd_usage_bytes'),
        storage_usage_bytes=pulumi.get(__ret__, 'storage_usage_bytes'),
        tenant_id=pulumi.get(__ret__, 'tenant_id'))
def get_storage_container_stats_info_v2_output(end_time: Optional[pulumi.Input[builtins.str]] = None,
                                               ext_id: Optional[pulumi.Input[builtins.str]] = None,
                                               sampling_interval: Optional[pulumi.Input[Optional[builtins.int]]] = None,
                                               start_time: Optional[pulumi.Input[builtins.str]] = None,
                                               stat_type: Optional[pulumi.Input[Optional[builtins.str]]] = None,
                                               opts: Optional[Union[pulumi.InvokeOptions, pulumi.InvokeOutputOptions]] = None) -> pulumi.Output[GetStorageContainerStatsInfoV2Result]:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['endTime'] = end_time
    __args__['extId'] = ext_id
    __args__['samplingInterval'] = sampling_interval
    __args__['startTime'] = start_time
    __args__['statType'] = stat_type
    opts = pulumi.InvokeOutputOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke_output('nutanix:index/getStorageContainerStatsInfoV2:getStorageContainerStatsInfoV2', __args__, opts=opts, typ=GetStorageContainerStatsInfoV2Result)
    return __ret__.apply(lambda __response__: GetStorageContainerStatsInfoV2Result(
        container_ext_id=pulumi.get(__response__, 'container_ext_id'),
        controller_avg_io_latencyu_secs=pulumi.get(__response__, 'controller_avg_io_latencyu_secs'),
        controller_avg_read_io_latencyu_secs=pulumi.get(__response__, 'controller_avg_read_io_latencyu_secs'),
        controller_avg_write_io_latencyu_secs=pulumi.get(__response__, 'controller_avg_write_io_latencyu_secs'),
        controller_io_bandwidth_kbps=pulumi.get(__response__, 'controller_io_bandwidth_kbps'),
        controller_num_iops=pulumi.get(__response__, 'controller_num_iops'),
        controller_num_read_iops=pulumi.get(__response__, 'controller_num_read_iops'),
        controller_num_write_iops=pulumi.get(__response__, 'controller_num_write_iops'),
        controller_read_io_bandwidth_kbps=pulumi.get(__response__, 'controller_read_io_bandwidth_kbps'),
        controller_read_io_ratio_ppms=pulumi.get(__response__, 'controller_read_io_ratio_ppms'),
        controller_write_io_bandwidth_kbps=pulumi.get(__response__, 'controller_write_io_bandwidth_kbps'),
        controller_write_io_ratio_ppms=pulumi.get(__response__, 'controller_write_io_ratio_ppms'),
        data_reduction_clone_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_clone_saving_ratio_ppms'),
        data_reduction_compression_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_compression_saving_ratio_ppms'),
        data_reduction_dedup_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_dedup_saving_ratio_ppms'),
        data_reduction_erasure_coding_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_erasure_coding_saving_ratio_ppms'),
        data_reduction_overall_post_reduction_bytes=pulumi.get(__response__, 'data_reduction_overall_post_reduction_bytes'),
        data_reduction_overall_pre_reduction_bytes=pulumi.get(__response__, 'data_reduction_overall_pre_reduction_bytes'),
        data_reduction_saved_bytes=pulumi.get(__response__, 'data_reduction_saved_bytes'),
        data_reduction_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_saving_ratio_ppms'),
        data_reduction_snapshot_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_snapshot_saving_ratio_ppms'),
        data_reduction_thin_provision_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_thin_provision_saving_ratio_ppms'),
        data_reduction_total_saving_ratio_ppms=pulumi.get(__response__, 'data_reduction_total_saving_ratio_ppms'),
        data_reduction_zero_write_savings_bytes=pulumi.get(__response__, 'data_reduction_zero_write_savings_bytes'),
        end_time=pulumi.get(__response__, 'end_time'),
        ext_id=pulumi.get(__response__, 'ext_id'),
        healths=pulumi.get(__response__, 'healths'),
        id=pulumi.get(__response__, 'id'),
        links=pulumi.get(__response__, 'links'),
        sampling_interval=pulumi.get(__response__, 'sampling_interval'),
        start_time=pulumi.get(__response__, 'start_time'),
        stat_type=pulumi.get(__response__, 'stat_type'),
        storage_actual_physical_usage_bytes=pulumi.get(__response__, 'storage_actual_physical_usage_bytes'),
        storage_capacity_bytes=pulumi.get(__response__, 'storage_capacity_bytes'),
        storage_free_bytes=pulumi.get(__response__, 'storage_free_bytes'),
        storage_replication_factors=pulumi.get(__response__, 'storage_replication_factors'),
        storage_reserved_capacity_bytes=pulumi.get(__response__, 'storage_reserved_capacity_bytes'),
        storage_tier_das_sata_usage_bytes=pulumi.get(__response__, 'storage_tier_das_sata_usage_bytes'),
        storage_tier_ssd_usage_bytes=pulumi.get(__response__, 'storage_tier_ssd_usage_bytes'),
        storage_usage_bytes=pulumi.get(__response__, 'storage_usage_bytes'),
        tenant_id=pulumi.get(__response__, 'tenant_id')))
