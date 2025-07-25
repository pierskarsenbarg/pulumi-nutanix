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

    public sealed class NdbScaleDatabaseInfoBpgConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("bpgDbParams")]
        private InputList<Inputs.NdbScaleDatabaseInfoBpgConfigBpgDbParamArgs>? _bpgDbParams;
        public InputList<Inputs.NdbScaleDatabaseInfoBpgConfigBpgDbParamArgs> BpgDbParams
        {
            get => _bpgDbParams ?? (_bpgDbParams = new InputList<Inputs.NdbScaleDatabaseInfoBpgConfigBpgDbParamArgs>());
            set => _bpgDbParams = value;
        }

        [Input("storages")]
        private InputList<Inputs.NdbScaleDatabaseInfoBpgConfigStorageArgs>? _storages;
        public InputList<Inputs.NdbScaleDatabaseInfoBpgConfigStorageArgs> Storages
        {
            get => _storages ?? (_storages = new InputList<Inputs.NdbScaleDatabaseInfoBpgConfigStorageArgs>());
            set => _storages = value;
        }

        [Input("vmProperties")]
        private InputList<Inputs.NdbScaleDatabaseInfoBpgConfigVmPropertyArgs>? _vmProperties;
        public InputList<Inputs.NdbScaleDatabaseInfoBpgConfigVmPropertyArgs> VmProperties
        {
            get => _vmProperties ?? (_vmProperties = new InputList<Inputs.NdbScaleDatabaseInfoBpgConfigVmPropertyArgs>());
            set => _vmProperties = value;
        }

        public NdbScaleDatabaseInfoBpgConfigArgs()
        {
        }
        public static new NdbScaleDatabaseInfoBpgConfigArgs Empty => new NdbScaleDatabaseInfoBpgConfigArgs();
    }
}
