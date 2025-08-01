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

    public sealed class NdbRegisterDatabaseTimeMachineInfoSlaDetailPrimarySlaGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("nxClusterIds")]
        private InputList<string>? _nxClusterIds;
        public InputList<string> NxClusterIds
        {
            get => _nxClusterIds ?? (_nxClusterIds = new InputList<string>());
            set => _nxClusterIds = value;
        }

        /// <summary>
        /// description of SLA ID.
        /// </summary>
        [Input("slaId", required: true)]
        public Input<string> SlaId { get; set; } = null!;

        public NdbRegisterDatabaseTimeMachineInfoSlaDetailPrimarySlaGetArgs()
        {
        }
        public static new NdbRegisterDatabaseTimeMachineInfoSlaDetailPrimarySlaGetArgs Empty => new NdbRegisterDatabaseTimeMachineInfoSlaDetailPrimarySlaGetArgs();
    }
}
