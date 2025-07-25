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

    public sealed class NdbCloneLcmConfigDatabaseLcmConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("expiryDetails")]
        private InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigExpiryDetailArgs>? _expiryDetails;
        public InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigExpiryDetailArgs> ExpiryDetails
        {
            get => _expiryDetails ?? (_expiryDetails = new InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigExpiryDetailArgs>());
            set => _expiryDetails = value;
        }

        [Input("refreshDetails")]
        private InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigRefreshDetailArgs>? _refreshDetails;
        public InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigRefreshDetailArgs> RefreshDetails
        {
            get => _refreshDetails ?? (_refreshDetails = new InputList<Inputs.NdbCloneLcmConfigDatabaseLcmConfigRefreshDetailArgs>());
            set => _refreshDetails = value;
        }

        public NdbCloneLcmConfigDatabaseLcmConfigArgs()
        {
        }
        public static new NdbCloneLcmConfigDatabaseLcmConfigArgs Empty => new NdbCloneLcmConfigDatabaseLcmConfigArgs();
    }
}
