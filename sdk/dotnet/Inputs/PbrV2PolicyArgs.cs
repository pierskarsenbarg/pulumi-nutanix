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

    public sealed class PbrV2PolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("isBidirectional")]
        public Input<bool>? IsBidirectional { get; set; }

        [Input("policyActions", required: true)]
        private InputList<Inputs.PbrV2PolicyPolicyActionArgs>? _policyActions;
        public InputList<Inputs.PbrV2PolicyPolicyActionArgs> PolicyActions
        {
            get => _policyActions ?? (_policyActions = new InputList<Inputs.PbrV2PolicyPolicyActionArgs>());
            set => _policyActions = value;
        }

        [Input("policyMatches", required: true)]
        private InputList<Inputs.PbrV2PolicyPolicyMatchArgs>? _policyMatches;
        public InputList<Inputs.PbrV2PolicyPolicyMatchArgs> PolicyMatches
        {
            get => _policyMatches ?? (_policyMatches = new InputList<Inputs.PbrV2PolicyPolicyMatchArgs>());
            set => _policyMatches = value;
        }

        public PbrV2PolicyArgs()
        {
        }
        public static new PbrV2PolicyArgs Empty => new PbrV2PolicyArgs();
    }
}
