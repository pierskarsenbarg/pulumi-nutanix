// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Inputs
{

    public sealed class NdbScaleDatabaseLcmConfigPreDeleteCommandArgs : global::Pulumi.ResourceArgs
    {
        [Input("command")]
        public Input<string>? Command { get; set; }

        public NdbScaleDatabaseLcmConfigPreDeleteCommandArgs()
        {
        }
        public static new NdbScaleDatabaseLcmConfigPreDeleteCommandArgs Empty => new NdbScaleDatabaseLcmConfigPreDeleteCommandArgs();
    }
}