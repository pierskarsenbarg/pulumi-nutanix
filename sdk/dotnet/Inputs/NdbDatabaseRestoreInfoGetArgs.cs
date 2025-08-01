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

    public sealed class NdbDatabaseRestoreInfoGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("bpgConfigs")]
        private InputList<Inputs.NdbDatabaseRestoreInfoBpgConfigGetArgs>? _bpgConfigs;
        public InputList<Inputs.NdbDatabaseRestoreInfoBpgConfigGetArgs> BpgConfigs
        {
            get => _bpgConfigs ?? (_bpgConfigs = new InputList<Inputs.NdbDatabaseRestoreInfoBpgConfigGetArgs>());
            set => _bpgConfigs = value;
        }

        [Input("secureInfo")]
        private InputMap<string>? _secureInfo;
        public InputMap<string> SecureInfo
        {
            get => _secureInfo ?? (_secureInfo = new InputMap<string>());
            set => _secureInfo = value;
        }

        public NdbDatabaseRestoreInfoGetArgs()
        {
        }
        public static new NdbDatabaseRestoreInfoGetArgs Empty => new NdbDatabaseRestoreInfoGetArgs();
    }
}
