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

    public sealed class TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("imageReferences")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceImageReferenceGetArgs>? _imageReferences;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceImageReferenceGetArgs> ImageReferences
        {
            get => _imageReferences ?? (_imageReferences = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceImageReferenceGetArgs>());
            set => _imageReferences = value;
        }

        [Input("vmDiskReferences")]
        private InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceGetArgs>? _vmDiskReferences;
        public InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceGetArgs> VmDiskReferences
        {
            get => _vmDiskReferences ?? (_vmDiskReferences = new InputList<Inputs.TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceVmDiskReferenceGetArgs>());
            set => _vmDiskReferences = value;
        }

        public TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceGetArgs()
        {
        }
        public static new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceGetArgs Empty => new TemplateV2TemplateVersionSpecVmSpecDiskBackingInfoVmDiskDataSourceReferenceGetArgs();
    }
}
