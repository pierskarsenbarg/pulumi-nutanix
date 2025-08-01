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

    public sealed class NdbCloneDatabaseNodeTagGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("entityId")]
        public Input<string>? EntityId { get; set; }

        [Input("entityType")]
        public Input<string>? EntityType { get; set; }

        [Input("tagId")]
        public Input<string>? TagId { get; set; }

        [Input("tagName")]
        public Input<string>? TagName { get; set; }

        /// <summary>
        /// - (Required) value for argument
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public NdbCloneDatabaseNodeTagGetArgs()
        {
        }
        public static new NdbCloneDatabaseNodeTagGetArgs Empty => new NdbCloneDatabaseNodeTagGetArgs();
    }
}
