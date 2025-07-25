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
    public sealed class ServiceGroupServiceListIcmpTypeCodeList
    {
        /// <summary>
        /// - (Optional) Code as text
        /// </summary>
        public readonly string? Code;
        /// <summary>
        /// - (Optional) Type as text
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ServiceGroupServiceListIcmpTypeCodeList(
            string? code,

            string? type)
        {
            Code = code;
            Type = type;
        }
    }
}
