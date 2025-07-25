// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class GetVmRecoveryPointInfoV2DiskRecoveryPointArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// External identifier of the disk.
        /// </summary>
        [Input("diskExtId", required: true)]
        public string DiskExtId { get; set; } = null!;

        /// <summary>
        /// External identifier of the disk recovery point.
        /// </summary>
        [Input("diskRecoveryPointExtId", required: true)]
        public string DiskRecoveryPointExtId { get; set; } = null!;

        public GetVmRecoveryPointInfoV2DiskRecoveryPointArgs()
        {
        }
        public static new GetVmRecoveryPointInfoV2DiskRecoveryPointArgs Empty => new GetVmRecoveryPointInfoV2DiskRecoveryPointArgs();
    }
}
