// *** WARNING: this file was generated by pulumi-language-dotnet. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Nutanix.Outputs
{

    [OutputType]
    public sealed class GetFoundationCentralImagedNodesListImagedNodeResult
    {
        /// <summary>
        /// AOS version currently installed on the node.
        /// </summary>
        public readonly string AosVersion;
        /// <summary>
        /// API key used to register the node.
        /// </summary>
        public readonly string ApiKeyUuid;
        /// <summary>
        /// Specifies whether the node is available for cluster creation.
        /// </summary>
        public readonly bool Available;
        /// <summary>
        /// Serial number of the block to which the node belongs.
        /// </summary>
        public readonly string BlockSerial;
        /// <summary>
        /// Time when the node was discovered in Foundation Central.
        /// </summary>
        public readonly string CreatedTimestamp;
        /// <summary>
        /// Current time of Foundation Central.
        /// </summary>
        public readonly string CurrentTime;
        /// <summary>
        /// gateway of the cvm.
        /// </summary>
        public readonly string CvmGateway;
        /// <summary>
        /// IP address of the cvm.
        /// </summary>
        public readonly string CvmIp;
        /// <summary>
        /// IPv6 address of the cvm.
        /// </summary>
        public readonly string CvmIpv6;
        /// <summary>
        /// netmask of the cvm.
        /// </summary>
        public readonly string CvmNetmask;
        /// <summary>
        /// Denotes whether the CVM is up or not on this node.
        /// </summary>
        public readonly bool CvmUp;
        /// <summary>
        /// Node UUID from the node's cvm.
        /// </summary>
        public readonly string CvmUuid;
        /// <summary>
        /// Vlan tag of the cvm, if the cvm is on a vlan.
        /// </summary>
        public readonly int CvmVlanId;
        /// <summary>
        /// Foundation version installed on the node.
        /// </summary>
        public readonly string FoundationVersion;
        /// <summary>
        /// Hardware attributes json of the node.
        /// </summary>
        public readonly ImmutableDictionary<string, string> HardwareAttributes;
        /// <summary>
        /// gateway of the hypervisor.
        /// </summary>
        public readonly string HypervisorGateway;
        /// <summary>
        /// Name of the hypervisor host.
        /// </summary>
        public readonly string HypervisorHostname;
        /// <summary>
        /// IP address of the hypervisor.
        /// </summary>
        public readonly string HypervisorIp;
        /// <summary>
        /// netmask of the hypervisor.
        /// </summary>
        public readonly string HypervisorNetmask;
        /// <summary>
        /// Hypervisor type currently installed on the node. Must be one of {kvm, esx, hyperv}.
        /// </summary>
        public readonly string HypervisorType;
        /// <summary>
        /// Version of the hypervisor currently installed on the node.
        /// </summary>
        public readonly string HypervisorVersion;
        /// <summary>
        /// UUID of the cluster to which the node belongs, if any.
        /// </summary>
        public readonly string ImagedClusterUuid;
        /// <summary>
        /// UUID of the node.
        /// </summary>
        public readonly string ImagedNodeUuid;
        /// <summary>
        /// gateway of the ipmi.
        /// </summary>
        public readonly string IpmiGateway;
        /// <summary>
        /// IP address of the ipmi.
        /// </summary>
        public readonly string IpmiIp;
        /// <summary>
        /// netmask of the ipmi.
        /// </summary>
        public readonly string IpmiNetmask;
        /// <summary>
        /// Name of the cvm interface having ipv6 address.
        /// </summary>
        public readonly string Ipv6Interface;
        /// <summary>
        /// List of timestamps when the node has sent heartbeats to Foundation Central.
        /// </summary>
        public readonly ImmutableArray<string> LatestHbTsLists;
        /// <summary>
        /// Model of the node.
        /// </summary>
        public readonly string Model;
        /// <summary>
        /// Position of the node in the block.
        /// </summary>
        public readonly string NodePosition;
        /// <summary>
        /// Serial number of the node.
        /// </summary>
        public readonly string NodeSerial;
        /// <summary>
        /// Specifies whether the node is discovering, available or unavailable for cluster creation.
        /// </summary>
        public readonly string NodeState;
        /// <summary>
        /// Specifies the type of node - on-prem, AWS, GCP etc.
        /// </summary>
        public readonly string NodeType;
        /// <summary>
        /// Version of the node used for CAS.
        /// </summary>
        public readonly int ObjectVersion;
        public readonly ImmutableArray<string> SupportedFeatures;

        [OutputConstructor]
        private GetFoundationCentralImagedNodesListImagedNodeResult(
            string aosVersion,

            string apiKeyUuid,

            bool available,

            string blockSerial,

            string createdTimestamp,

            string currentTime,

            string cvmGateway,

            string cvmIp,

            string cvmIpv6,

            string cvmNetmask,

            bool cvmUp,

            string cvmUuid,

            int cvmVlanId,

            string foundationVersion,

            ImmutableDictionary<string, string> hardwareAttributes,

            string hypervisorGateway,

            string hypervisorHostname,

            string hypervisorIp,

            string hypervisorNetmask,

            string hypervisorType,

            string hypervisorVersion,

            string imagedClusterUuid,

            string imagedNodeUuid,

            string ipmiGateway,

            string ipmiIp,

            string ipmiNetmask,

            string ipv6Interface,

            ImmutableArray<string> latestHbTsLists,

            string model,

            string nodePosition,

            string nodeSerial,

            string nodeState,

            string nodeType,

            int objectVersion,

            ImmutableArray<string> supportedFeatures)
        {
            AosVersion = aosVersion;
            ApiKeyUuid = apiKeyUuid;
            Available = available;
            BlockSerial = blockSerial;
            CreatedTimestamp = createdTimestamp;
            CurrentTime = currentTime;
            CvmGateway = cvmGateway;
            CvmIp = cvmIp;
            CvmIpv6 = cvmIpv6;
            CvmNetmask = cvmNetmask;
            CvmUp = cvmUp;
            CvmUuid = cvmUuid;
            CvmVlanId = cvmVlanId;
            FoundationVersion = foundationVersion;
            HardwareAttributes = hardwareAttributes;
            HypervisorGateway = hypervisorGateway;
            HypervisorHostname = hypervisorHostname;
            HypervisorIp = hypervisorIp;
            HypervisorNetmask = hypervisorNetmask;
            HypervisorType = hypervisorType;
            HypervisorVersion = hypervisorVersion;
            ImagedClusterUuid = imagedClusterUuid;
            ImagedNodeUuid = imagedNodeUuid;
            IpmiGateway = ipmiGateway;
            IpmiIp = ipmiIp;
            IpmiNetmask = ipmiNetmask;
            Ipv6Interface = ipv6Interface;
            LatestHbTsLists = latestHbTsLists;
            Model = model;
            NodePosition = nodePosition;
            NodeSerial = nodeSerial;
            NodeState = nodeState;
            NodeType = nodeType;
            ObjectVersion = objectVersion;
            SupportedFeatures = supportedFeatures;
        }
    }
}
