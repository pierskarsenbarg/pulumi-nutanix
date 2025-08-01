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

    public sealed class FoundationImageNodesTestsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - Whether NCC checks should run.
        /// </summary>
        [Input("runNcc")]
        public Input<bool>? RunNcc { get; set; }

        /// <summary>
        /// - Whether system checks should run.
        /// </summary>
        [Input("runSyscheck")]
        public Input<bool>? RunSyscheck { get; set; }

        public FoundationImageNodesTestsGetArgs()
        {
        }
        public static new FoundationImageNodesTestsGetArgs Empty => new FoundationImageNodesTestsGetArgs();
    }
}
