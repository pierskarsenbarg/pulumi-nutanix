// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix
{
    public static class GetNdbTimeMachines
    {
        /// <summary>
        /// List all time machines present in Nutanix Database Service
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
        ///     var tms = Nutanix.GetNdbTimeMachines.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetNdbTimeMachinesResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNdbTimeMachinesResult>("nutanix:index/getNdbTimeMachines:getNdbTimeMachines", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// List all time machines present in Nutanix Database Service
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
        ///     var tms = Nutanix.GetNdbTimeMachines.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbTimeMachinesResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbTimeMachinesResult>("nutanix:index/getNdbTimeMachines:getNdbTimeMachines", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// List all time machines present in Nutanix Database Service
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
        ///     var tms = Nutanix.GetNdbTimeMachines.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbTimeMachinesResult> Invoke(InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbTimeMachinesResult>("nutanix:index/getNdbTimeMachines:getNdbTimeMachines", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetNdbTimeMachinesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetNdbTimeMachinesTimeMachineResult> TimeMachines;

        [OutputConstructor]
        private GetNdbTimeMachinesResult(
            string id,

            ImmutableArray<Outputs.GetNdbTimeMachinesTimeMachineResult> timeMachines)
        {
            Id = id;
            TimeMachines = timeMachines;
        }
    }
}
