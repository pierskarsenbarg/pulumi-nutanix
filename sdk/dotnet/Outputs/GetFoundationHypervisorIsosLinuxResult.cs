// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class GetFoundationHypervisorIsosLinuxResult
    {
        public readonly string Filename;
        public readonly bool Supported;

        [OutputConstructor]
        private GetFoundationHypervisorIsosLinuxResult(
            string filename,

            bool supported)
        {
            Filename = filename;
            Supported = supported;
        }
    }
}
