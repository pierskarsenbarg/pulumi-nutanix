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
    public static class GetNdbMaintenanceWindows
    {
        /// <summary>
        /// List of maintenance windows in Nutanix Database Service
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
        ///     var windows = Nutanix.GetNdbMaintenanceWindows.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetNdbMaintenanceWindowsResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNdbMaintenanceWindowsResult>("nutanix:index/getNdbMaintenanceWindows:getNdbMaintenanceWindows", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// List of maintenance windows in Nutanix Database Service
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
        ///     var windows = Nutanix.GetNdbMaintenanceWindows.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbMaintenanceWindowsResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbMaintenanceWindowsResult>("nutanix:index/getNdbMaintenanceWindows:getNdbMaintenanceWindows", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetNdbMaintenanceWindowsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// List of maintenance windows
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbMaintenanceWindowsMaintenanceWindowResult> MaintenanceWindows;

        [OutputConstructor]
        private GetNdbMaintenanceWindowsResult(
            string id,

            ImmutableArray<Outputs.GetNdbMaintenanceWindowsMaintenanceWindowResult> maintenanceWindows)
        {
            Id = id;
            MaintenanceWindows = maintenanceWindows;
        }
    }
}