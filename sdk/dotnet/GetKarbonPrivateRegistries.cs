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
    public static class GetKarbonPrivateRegistries
    {
        /// <summary>
        /// Describes a List of Karbon private registry entry
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
        ///         var registry = Output.Create(Nutanix.GetKarbonPrivateRegistries.InvokeAsync(
        ///         {
        ///             { "clusterId", "&lt;YOUR-CLUSTER-ID&gt;" },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetKarbonPrivateRegistriesResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKarbonPrivateRegistriesResult>("nutanix:index/getKarbonPrivateRegistries:getKarbonPrivateRegistries", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetKarbonPrivateRegistriesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetKarbonPrivateRegistriesPrivateRegistryResult> PrivateRegistries;

        [OutputConstructor]
        private GetKarbonPrivateRegistriesResult(
            string id,

            ImmutableArray<Outputs.GetKarbonPrivateRegistriesPrivateRegistryResult> privateRegistries)
        {
            Id = id;
            PrivateRegistries = privateRegistries;
        }
    }
}