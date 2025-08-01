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

    public sealed class VirtualMachineCategoryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Required) The name for the vm.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// - value of the key.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public VirtualMachineCategoryArgs()
        {
        }
        public static new VirtualMachineCategoryArgs Empty => new VirtualMachineCategoryArgs();
    }
}
