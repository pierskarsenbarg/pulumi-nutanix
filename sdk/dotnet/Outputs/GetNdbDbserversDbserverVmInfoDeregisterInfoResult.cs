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
    public sealed class GetNdbDbserversDbserverVmInfoDeregisterInfoResult
    {
        public readonly string Message;
        public readonly ImmutableArray<string> Operations;

        [OutputConstructor]
        private GetNdbDbserversDbserverVmInfoDeregisterInfoResult(
            string message,

            ImmutableArray<string> operations)
        {
            Message = message;
            Operations = operations;
        }
    }
}
