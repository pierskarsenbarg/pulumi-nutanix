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

    public sealed class NdbClusterEntityCountEngineCountMysqlDatabaseArgs : global::Pulumi.ResourceArgs
    {
        [Input("profiles")]
        private InputList<Inputs.NdbClusterEntityCountEngineCountMysqlDatabaseProfileArgs>? _profiles;
        public InputList<Inputs.NdbClusterEntityCountEngineCountMysqlDatabaseProfileArgs> Profiles
        {
            get => _profiles ?? (_profiles = new InputList<Inputs.NdbClusterEntityCountEngineCountMysqlDatabaseProfileArgs>());
            set => _profiles = value;
        }

        [Input("timeMachines")]
        public Input<int>? TimeMachines { get; set; }

        public NdbClusterEntityCountEngineCountMysqlDatabaseArgs()
        {
        }
        public static new NdbClusterEntityCountEngineCountMysqlDatabaseArgs Empty => new NdbClusterEntityCountEngineCountMysqlDatabaseArgs();
    }
}