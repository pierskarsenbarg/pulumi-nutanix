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

    public sealed class PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customKeyValues")]
        private InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueGetArgs>? _customKeyValues;
        public InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueGetArgs> CustomKeyValues
        {
            get => _customKeyValues ?? (_customKeyValues = new InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptCustomKeyValueGetArgs>());
            set => _customKeyValues = value;
        }

        [Input("userDatas")]
        private InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs>? _userDatas;
        public InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs> UserDatas
        {
            get => _userDatas ?? (_userDatas = new InputList<Inputs.PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptUserDataGetArgs>());
            set => _userDatas = value;
        }

        public PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs()
        {
        }
        public static new PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs Empty => new PcRestoreV2DomainManagerConfigBootstrapConfigCloudInitConfigCloudInitScriptGetArgs();
    }
}
