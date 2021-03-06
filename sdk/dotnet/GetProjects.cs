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
    public static class GetProjects
    {
        /// <summary>
        /// Describes Projects
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Nutanix = Pulumi.Nutanix;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var projects = Output.Create(Nutanix.GetProjects.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProjectsResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProjectsResult>("nutanix:index/getProjects:getProjects", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetProjectsResult
    {
        public readonly string ApiVersion;
        public readonly ImmutableArray<Outputs.GetProjectsEntityResult> Entities;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetProjectsResult(
            string apiVersion,

            ImmutableArray<Outputs.GetProjectsEntityResult> entities,

            string id)
        {
            ApiVersion = apiVersion;
            Entities = entities;
            Id = id;
        }
    }
}
