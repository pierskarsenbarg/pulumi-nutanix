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

    public sealed class FloatingIpV2AssociationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("privateIpAssociations")]
        private InputList<Inputs.FloatingIpV2AssociationPrivateIpAssociationGetArgs>? _privateIpAssociations;

        /// <summary>
        /// Association of Floating IP with private IP
        /// - `private_ip_association.vpc_reference`: (Required) VPC in which the private IP exists.
        /// - `private_ip_association.private_ip`: (Required) An unique address that identifies a device on the internet or a local network in IPv4 or IPv6 format.
        /// </summary>
        public InputList<Inputs.FloatingIpV2AssociationPrivateIpAssociationGetArgs> PrivateIpAssociations
        {
            get => _privateIpAssociations ?? (_privateIpAssociations = new InputList<Inputs.FloatingIpV2AssociationPrivateIpAssociationGetArgs>());
            set => _privateIpAssociations = value;
        }

        [Input("vmNicAssociations")]
        private InputList<Inputs.FloatingIpV2AssociationVmNicAssociationGetArgs>? _vmNicAssociations;

        /// <summary>
        /// Association of Floating IP with nic
        /// - `vm_nic_association.vm_nic_reference`: (Required) VM NIC reference.
        /// - `vm_nic_association.vpc_reference`: (Optional) VPC reference to which the VM NIC subnet belongs.
        /// </summary>
        public InputList<Inputs.FloatingIpV2AssociationVmNicAssociationGetArgs> VmNicAssociations
        {
            get => _vmNicAssociations ?? (_vmNicAssociations = new InputList<Inputs.FloatingIpV2AssociationVmNicAssociationGetArgs>());
            set => _vmNicAssociations = value;
        }

        public FloatingIpV2AssociationGetArgs()
        {
        }
        public static new FloatingIpV2AssociationGetArgs Empty => new FloatingIpV2AssociationGetArgs();
    }
}
