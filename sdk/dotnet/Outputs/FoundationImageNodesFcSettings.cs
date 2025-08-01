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
    public sealed class FoundationImageNodesFcSettings
    {
        /// <summary>
        /// - Foundation Central metadata which will be transferred to the newly imaged node.
        /// * `fc_metadata.fc_ip` :- IP address of foundation central.
        /// * `fc_metadata.api_key` :- api_key which the node uses to register itself with foundation central.
        /// </summary>
        public readonly Outputs.FoundationImageNodesFcSettingsFcMetadata FcMetadata;
        /// <summary>
        /// - If this attribute is set to True, FC workflow will be invoked.
        /// </summary>
        public readonly bool FoundationCentral;

        [OutputConstructor]
        private FoundationImageNodesFcSettings(
            Outputs.FoundationImageNodesFcSettingsFcMetadata fcMetadata,

            bool foundationCentral)
        {
            FcMetadata = fcMetadata;
            FoundationCentral = foundationCentral;
        }
    }
}
