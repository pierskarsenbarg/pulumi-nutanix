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
    public static class GetProtectionRules
    {
        /// <summary>
        /// Describes Protection Rules
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
        ///     var protectionRules = Nutanix.GetProtectionRules.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetProtectionRulesResult> InvokeAsync(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProtectionRulesResult>("nutanix:index/getProtectionRules:getProtectionRules", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// Describes Protection Rules
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
        ///     var protectionRules = Nutanix.GetProtectionRules.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetProtectionRulesResult> Invoke(InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProtectionRulesResult>("nutanix:index/getProtectionRules:getProtectionRules", InvokeArgs.Empty, options.WithDefaults());

        /// <summary>
        /// Describes Protection Rules
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
        ///     var protectionRules = Nutanix.GetProtectionRules.Invoke();
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetProtectionRulesResult> Invoke(InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetProtectionRulesResult>("nutanix:index/getProtectionRules:getProtectionRules", InvokeArgs.Empty, options.WithDefaults());
    }


    [OutputType]
    public sealed class GetProtectionRulesResult
    {
        /// <summary>
        /// version of the API
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// List of Protection Rules
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProtectionRulesEntityResult> Entities;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetProtectionRulesResult(
            string apiVersion,

            ImmutableArray<Outputs.GetProtectionRulesEntityResult> entities,

            string id)
        {
            ApiVersion = apiVersion;
            Entities = entities;
            Id = id;
        }
    }
}
