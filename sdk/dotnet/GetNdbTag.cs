// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetNdbTag
    {
        /// <summary>
        /// Describes a tag in Nutanix Database Service
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tag = Nutanix.GetNdbTag.Invoke(new()
        ///     {
        ///         Id = "{{ tag id }}",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetNdbTagResult> InvokeAsync(GetNdbTagArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNdbTagResult>("nutanix:index/getNdbTag:getNdbTag", args ?? new GetNdbTagArgs(), options.WithDefaults());

        /// <summary>
        /// Describes a tag in Nutanix Database Service
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tag = Nutanix.GetNdbTag.Invoke(new()
        ///     {
        ///         Id = "{{ tag id }}",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbTagResult> Invoke(GetNdbTagInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbTagResult>("nutanix:index/getNdbTag:getNdbTag", args ?? new GetNdbTagInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNdbTagArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// tag id. Conflicts with  name.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// tag name. Conflicts with id.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetNdbTagArgs()
        {
        }
        public static new GetNdbTagArgs Empty => new GetNdbTagArgs();
    }

    public sealed class GetNdbTagInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// tag id. Conflicts with  name.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// tag name. Conflicts with id.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetNdbTagInvokeArgs()
        {
        }
        public static new GetNdbTagInvokeArgs Empty => new GetNdbTagInvokeArgs();
    }


    [OutputType]
    public sealed class GetNdbTagResult
    {
        /// <summary>
        /// date created of the tag
        /// </summary>
        public readonly string DateCreated;
        /// <summary>
        /// modified date of tha tag
        /// </summary>
        public readonly string DateModified;
        /// <summary>
        /// description for the tag
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// entity for the tag to be associated with.
        /// </summary>
        public readonly string EntityType;
        public readonly string Id;
        /// <summary>
        /// name for the tag
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// owner id of the tag
        /// </summary>
        public readonly string Owner;
        /// <summary>
        /// tag value for entities.
        /// </summary>
        public readonly bool Required;
        /// <summary>
        /// Status of the tag
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// value for the tag
        /// </summary>
        public readonly int Values;

        [OutputConstructor]
        private GetNdbTagResult(
            string dateCreated,

            string dateModified,

            string description,

            string entityType,

            string id,

            string name,

            string owner,

            bool required,

            string status,

            int values)
        {
            DateCreated = dateCreated;
            DateModified = dateModified;
            Description = description;
            EntityType = entityType;
            Id = id;
            Name = name;
            Owner = owner;
            Required = required;
            Status = status;
            Values = values;
        }
    }
}