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

    public sealed class TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("imageReferences")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceImageReferenceGetArgs>? _imageReferences;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceImageReferenceGetArgs> ImageReferences
        {
            get => _imageReferences ?? (_imageReferences = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceImageReferenceGetArgs>());
            set => _imageReferences = value;
        }

        [Input("vmDiskReferences")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs>? _vmDiskReferences;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs> VmDiskReferences
        {
            get => _vmDiskReferences ?? (_vmDiskReferences = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceVmDiskReferenceGetArgs>());
            set => _vmDiskReferences = value;
        }

        public TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceGetArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceGetArgs Empty => new TemplateV2TemplateVersionSpecVmSpecCdRomBackingInfoDataSourceReferenceGetArgs();
    }
}
