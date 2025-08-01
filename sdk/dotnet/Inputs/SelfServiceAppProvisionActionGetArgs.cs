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

    public sealed class SelfServiceAppProvisionActionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// description of the action
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// name of action.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// UUID of the action.
        /// </summary>
        [Input("uuid")]
        public Input<string>? Uuid { get; set; }

        public SelfServiceAppProvisionActionGetArgs()
        {
        }
        public static new SelfServiceAppProvisionActionGetArgs Empty => new SelfServiceAppProvisionActionGetArgs();
    }
}
