// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class VolumeGroupV2DiskDiskStorageFeatureFlashMode
    {
        /// <summary>
        /// - Indicates whether the flash mode is enabled for the Volume Group Disk.
        /// 
        /// See detailed information in [Nutanix Create Volume Group V4](https://developers.nutanix.com/api-reference?namespace=volumes&amp;version=v4.0#tag/VolumeGroups/operation/createVolumeGroup).
        /// </summary>
        public readonly bool? IsEnabled;

        [OutputConstructor]
        private VolumeGroupV2DiskDiskStorageFeatureFlashMode(bool? isEnabled)
        {
            IsEnabled = isEnabled;
        }
    }
}
