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
    public static class GetFoundationHypervisorIsos
    {
        /// <summary>
        /// Describes a list of hypervisor isos image file details present in foundation vm
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
        ///         var hypervisorIsos = Output.Create(Nutanix.GetFoundationHypervisorIsos.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// ## Note
        /// 
        /// * This data source only lists .iso files details.
        /// 
        /// See detailed information in [Nutanix Foundation Hypervisor Isos](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjM0MDE-list-hypervisor-images-available-in-foundation).
        /// </summary>
        public static Task<GetFoundationHypervisorIsosResult> InvokeAsync(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFoundationHypervisorIsosResult>("nutanix:index/getFoundationHypervisorIsos:getFoundationHypervisorIsos", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetFoundationHypervisorIsosResult
    {
        public readonly ImmutableArray<Outputs.GetFoundationHypervisorIsosEsxResult> Esxes;
        public readonly ImmutableArray<Outputs.GetFoundationHypervisorIsosHypervResult> Hypervs;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetFoundationHypervisorIsosKvmResult> Kvms;
        public readonly ImmutableArray<Outputs.GetFoundationHypervisorIsosLinuxResult> Linuxes;
        public readonly ImmutableArray<Outputs.GetFoundationHypervisorIsosXenResult> Xens;

        [OutputConstructor]
        private GetFoundationHypervisorIsosResult(
            ImmutableArray<Outputs.GetFoundationHypervisorIsosEsxResult> esxes,

            ImmutableArray<Outputs.GetFoundationHypervisorIsosHypervResult> hypervs,

            string id,

            ImmutableArray<Outputs.GetFoundationHypervisorIsosKvmResult> kvms,

            ImmutableArray<Outputs.GetFoundationHypervisorIsosLinuxResult> linuxes,

            ImmutableArray<Outputs.GetFoundationHypervisorIsosXenResult> xens)
        {
            Esxes = esxes;
            Hypervs = hypervs;
            Id = id;
            Kvms = kvms;
            Linuxes = linuxes;
            Xens = xens;
        }
    }
}