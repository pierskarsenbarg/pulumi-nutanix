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

    public sealed class NdbLinkedDatabasesInfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("infos")]
        private InputList<Inputs.NdbLinkedDatabasesInfoInfoArgs>? _infos;
        public InputList<Inputs.NdbLinkedDatabasesInfoInfoArgs> Infos
        {
            get => _infos ?? (_infos = new InputList<Inputs.NdbLinkedDatabasesInfoInfoArgs>());
            set => _infos = value;
        }

        [Input("secureInfo")]
        private InputMap<string>? _secureInfo;
        public InputMap<string> SecureInfo
        {
            get => _secureInfo ?? (_secureInfo = new InputMap<string>());
            set => _secureInfo = value;
        }

        public NdbLinkedDatabasesInfoArgs()
        {
        }
        public static new NdbLinkedDatabasesInfoArgs Empty => new NdbLinkedDatabasesInfoArgs();
    }
}