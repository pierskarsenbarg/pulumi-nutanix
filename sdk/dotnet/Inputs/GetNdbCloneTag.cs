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

    public sealed class GetNdbCloneTagArgs : global::Pulumi.InvokeArgs
    {
        [Input("entityId", required: true)]
        public string EntityId { get; set; } = null!;

        [Input("entityType", required: true)]
        public string EntityType { get; set; } = null!;

        [Input("tagId", required: true)]
        public string TagId { get; set; } = null!;

        [Input("tagName", required: true)]
        public string TagName { get; set; } = null!;

        [Input("value", required: true)]
        public string Value { get; set; } = null!;

        public GetNdbCloneTagArgs()
        {
        }
        public static new GetNdbCloneTagArgs Empty => new GetNdbCloneTagArgs();
    }
}
