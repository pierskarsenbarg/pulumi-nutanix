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

    public sealed class LcmPrechecksV2EntityUpdateSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// UUID of the LCM entity.
        /// </summary>
        [Input("entityUuid", required: true)]
        public Input<string> EntityUuid { get; set; } = null!;

        /// <summary>
        /// Version to upgrade to.
        /// 
        /// See detailed information in [Nutanix LCM Prechecks v4](https://developers.nutanix.com/api-reference?namespace=lifecycle&amp;version=v4.0#tag/Prechecks/operation/performPrechecks)
        /// </summary>
        [Input("toVersion", required: true)]
        public Input<string> ToVersion { get; set; } = null!;

        public LcmPrechecksV2EntityUpdateSpecArgs()
        {
        }
        public static new LcmPrechecksV2EntityUpdateSpecArgs Empty => new LcmPrechecksV2EntityUpdateSpecArgs();
    }
}
