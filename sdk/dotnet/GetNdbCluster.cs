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
    public static class GetNdbCluster
    {
        /// <summary>
        /// Describes a cluster in Nutanix Database Service
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
        ///     var c1 = Nutanix.GetNdbCluster.Invoke(new()
        ///     {
        ///         ClusterName = "&lt;era-cluster-name&gt;",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cluster"] = c1,
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Task<GetNdbClusterResult> InvokeAsync(GetNdbClusterArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNdbClusterResult>("nutanix:index/getNdbCluster:getNdbCluster", args ?? new GetNdbClusterArgs(), options.WithDefaults());

        /// <summary>
        /// Describes a cluster in Nutanix Database Service
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
        ///     var c1 = Nutanix.GetNdbCluster.Invoke(new()
        ///     {
        ///         ClusterName = "&lt;era-cluster-name&gt;",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cluster"] = c1,
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbClusterResult> Invoke(GetNdbClusterInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbClusterResult>("nutanix:index/getNdbCluster:getNdbCluster", args ?? new GetNdbClusterInvokeArgs(), options.WithDefaults());

        /// <summary>
        /// Describes a cluster in Nutanix Database Service
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
        ///     var c1 = Nutanix.GetNdbCluster.Invoke(new()
        ///     {
        ///         ClusterName = "&lt;era-cluster-name&gt;",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["cluster"] = c1,
        ///     };
        /// });
        /// ```
        /// </summary>
        public static Output<GetNdbClusterResult> Invoke(GetNdbClusterInvokeArgs args, InvokeOutputOptions options)
            => global::Pulumi.Deployment.Instance.Invoke<GetNdbClusterResult>("nutanix:index/getNdbCluster:getNdbCluster", args ?? new GetNdbClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNdbClusterArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of cluster
        /// </summary>
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        /// <summary>
        /// and `cluster_id` are mutually exclusive.
        /// </summary>
        [Input("clusterName")]
        public string? ClusterName { get; set; }

        public GetNdbClusterArgs()
        {
        }
        public static new GetNdbClusterArgs Empty => new GetNdbClusterArgs();
    }

    public sealed class GetNdbClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of cluster
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// and `cluster_id` are mutually exclusive.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        public GetNdbClusterInvokeArgs()
        {
        }
        public static new GetNdbClusterInvokeArgs Empty => new GetNdbClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetNdbClusterResult
    {
        /// <summary>
        /// - cloud info
        /// </summary>
        public readonly string CloudInfo;
        /// <summary>
        /// - cloud type
        /// </summary>
        public readonly string CloudType;
        public readonly string? ClusterId;
        public readonly string? ClusterName;
        /// <summary>
        /// - creation date
        /// </summary>
        public readonly string DateCreated;
        /// <summary>
        /// - date modified
        /// </summary>
        public readonly string DateModified;
        /// <summary>
        /// - description
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// - no. of entities related
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbClusterEntityCountResult> EntityCounts;
        /// <summary>
        /// - fqdn
        /// </summary>
        public readonly string Fqdns;
        /// <summary>
        /// - if healthy status
        /// </summary>
        public readonly bool Healthy;
        /// <summary>
        /// - hypervisor type
        /// </summary>
        public readonly string HypervisorType;
        /// <summary>
        /// - hypervisor version
        /// </summary>
        public readonly string HypervisorVersion;
        /// <summary>
        /// - id of cluster
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// - IP address
        /// </summary>
        public readonly ImmutableArray<string> IpAddresses;
        /// <summary>
        /// - NA
        /// </summary>
        public readonly string ManagementServerInfo;
        /// <summary>
        /// - name of cluster
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// - nutanix cluster uuid
        /// </summary>
        public readonly string NxClusterUuid;
        /// <summary>
        /// - owner UUID
        /// </summary>
        public readonly string OwnerId;
        /// <summary>
        /// - password
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// - list of properties
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbClusterPropertyResult> Properties;
        /// <summary>
        /// - NA
        /// </summary>
        public readonly int ReferenceCount;
        /// <summary>
        /// - resource related consumption info
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNdbClusterResourceConfigResult> ResourceConfigs;
        /// <summary>
        /// - current status
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// - unique name of cluster
        /// </summary>
        public readonly string UniqueName;
        /// <summary>
        /// - username
        /// </summary>
        public readonly string Username;
        /// <summary>
        /// - version
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetNdbClusterResult(
            string cloudInfo,

            string cloudType,

            string? clusterId,

            string? clusterName,

            string dateCreated,

            string dateModified,

            string description,

            ImmutableArray<Outputs.GetNdbClusterEntityCountResult> entityCounts,

            string fqdns,

            bool healthy,

            string hypervisorType,

            string hypervisorVersion,

            string id,

            ImmutableArray<string> ipAddresses,

            string managementServerInfo,

            string name,

            string nxClusterUuid,

            string ownerId,

            string password,

            ImmutableArray<Outputs.GetNdbClusterPropertyResult> properties,

            int referenceCount,

            ImmutableArray<Outputs.GetNdbClusterResourceConfigResult> resourceConfigs,

            string status,

            string uniqueName,

            string username,

            string version)
        {
            CloudInfo = cloudInfo;
            CloudType = cloudType;
            ClusterId = clusterId;
            ClusterName = clusterName;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Description = description;
            EntityCounts = entityCounts;
            Fqdns = fqdns;
            Healthy = healthy;
            HypervisorType = hypervisorType;
            HypervisorVersion = hypervisorVersion;
            Id = id;
            IpAddresses = ipAddresses;
            ManagementServerInfo = managementServerInfo;
            Name = name;
            NxClusterUuid = nxClusterUuid;
            OwnerId = ownerId;
            Password = password;
            Properties = properties;
            ReferenceCount = referenceCount;
            ResourceConfigs = resourceConfigs;
            Status = status;
            UniqueName = uniqueName;
            Username = username;
            Version = version;
        }
    }
}
