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

    public sealed class TemplateV2TemplateVersionSpecVmSpecOwnershipInfoGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("owners")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecOwnershipInfoOwnerGetArgs>? _owners;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecOwnershipInfoOwnerGetArgs> Owners
        {
            get => _owners ?? (_owners = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecOwnershipInfoOwnerGetArgs>());
            set => _owners = value;
        }

        public TemplateV2TemplateVersionSpecVmSpecOwnershipInfoGetArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecOwnershipInfoGetArgs Empty => new TemplateV2TemplateVersionSpecVmSpecOwnershipInfoGetArgs();
    }
}
