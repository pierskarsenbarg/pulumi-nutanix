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

    public sealed class NdbDatabaseInfoGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bpgConfigs")]
        private InputList<Inputs.NdbDatabaseInfoBpgConfigGetArgs>? _bpgConfigs;
        public InputList<Inputs.NdbDatabaseInfoBpgConfigGetArgs> BpgConfigs
        {
            get => _bpgConfigs ?? (_bpgConfigs = new InputList<Inputs.NdbDatabaseInfoBpgConfigGetArgs>());
            set => _bpgConfigs = value;
        }

        [Input("secureInfo")]
        private InputMap<string>? _secureInfo;
        public InputMap<string> SecureInfo
        {
            get => _secureInfo ?? (_secureInfo = new InputMap<string>());
            set => _secureInfo = value;
        }

        public NdbDatabaseInfoGetArgs()
        {
        }
        public static new NdbDatabaseInfoGetArgs Empty => new NdbDatabaseInfoGetArgs();
    }
}