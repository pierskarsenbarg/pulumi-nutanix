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

    public sealed class NdbClusterEntityCountEngineCountMariadbDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("profiles")]
        private InputList<Inputs.NdbClusterEntityCountEngineCountMariadbDatabaseProfileGetArgs>? _profiles;
        public InputList<Inputs.NdbClusterEntityCountEngineCountMariadbDatabaseProfileGetArgs> Profiles
        {
            get => _profiles ?? (_profiles = new InputList<Inputs.NdbClusterEntityCountEngineCountMariadbDatabaseProfileGetArgs>());
            set => _profiles = value;
        }

        [Input("timeMachines")]
        public Input<int>? TimeMachines { get; set; }

        public NdbClusterEntityCountEngineCountMariadbDatabaseGetArgs()
        {
        }
        public static new NdbClusterEntityCountEngineCountMariadbDatabaseGetArgs Empty => new NdbClusterEntityCountEngineCountMariadbDatabaseGetArgs();
    }
}
