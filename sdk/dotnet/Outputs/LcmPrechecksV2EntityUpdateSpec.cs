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
    public sealed class LcmPrechecksV2EntityUpdateSpec
    {
        /// <summary>
        /// UUID of the LCM entity.
        /// </summary>
        public readonly string EntityUuid;
        /// <summary>
        /// Version to upgrade to.
        /// 
        /// See detailed information in [Nutanix LCM Prechecks v4](https://developers.nutanix.com/api-reference?namespace=lifecycle&amp;version=v4.0#tag/Prechecks/operation/performPrechecks)
        /// </summary>
        public readonly string ToVersion;

        [OutputConstructor]
        private LcmPrechecksV2EntityUpdateSpec(
            string entityUuid,

            string toVersion)
        {
            EntityUuid = entityUuid;
            ToVersion = toVersion;
        }
    }
}
