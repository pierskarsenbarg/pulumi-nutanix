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

    public sealed class NdbClonePropertyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// database instance name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// - (Required) value for argument
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public NdbClonePropertyArgs()
        {
        }
        public static new NdbClonePropertyArgs Empty => new NdbClonePropertyArgs();
    }
}
