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

    public sealed class NdbRegisterDatabaseLcmConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("expiryDetails")]
        private InputList<Inputs.NdbRegisterDatabaseLcmConfigExpiryDetailArgs>? _expiryDetails;
        public InputList<Inputs.NdbRegisterDatabaseLcmConfigExpiryDetailArgs> ExpiryDetails
        {
            get => _expiryDetails ?? (_expiryDetails = new InputList<Inputs.NdbRegisterDatabaseLcmConfigExpiryDetailArgs>());
            set => _expiryDetails = value;
        }

        [Input("postDeleteCommands")]
        private InputList<Inputs.NdbRegisterDatabaseLcmConfigPostDeleteCommandArgs>? _postDeleteCommands;
        public InputList<Inputs.NdbRegisterDatabaseLcmConfigPostDeleteCommandArgs> PostDeleteCommands
        {
            get => _postDeleteCommands ?? (_postDeleteCommands = new InputList<Inputs.NdbRegisterDatabaseLcmConfigPostDeleteCommandArgs>());
            set => _postDeleteCommands = value;
        }

        [Input("preDeleteCommands")]
        private InputList<Inputs.NdbRegisterDatabaseLcmConfigPreDeleteCommandArgs>? _preDeleteCommands;
        public InputList<Inputs.NdbRegisterDatabaseLcmConfigPreDeleteCommandArgs> PreDeleteCommands
        {
            get => _preDeleteCommands ?? (_preDeleteCommands = new InputList<Inputs.NdbRegisterDatabaseLcmConfigPreDeleteCommandArgs>());
            set => _preDeleteCommands = value;
        }

        [Input("refreshDetails")]
        private InputList<Inputs.NdbRegisterDatabaseLcmConfigRefreshDetailArgs>? _refreshDetails;
        public InputList<Inputs.NdbRegisterDatabaseLcmConfigRefreshDetailArgs> RefreshDetails
        {
            get => _refreshDetails ?? (_refreshDetails = new InputList<Inputs.NdbRegisterDatabaseLcmConfigRefreshDetailArgs>());
            set => _refreshDetails = value;
        }

        public NdbRegisterDatabaseLcmConfigArgs()
        {
        }
        public static new NdbRegisterDatabaseLcmConfigArgs Empty => new NdbRegisterDatabaseLcmConfigArgs();
    }
}
