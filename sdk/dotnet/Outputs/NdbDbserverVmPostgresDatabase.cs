// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
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
    public sealed class NdbDbserverVmPostgresDatabase
    {
        public readonly string? ClientPublicKey;
        public readonly string VmName;

        [OutputConstructor]
        private NdbDbserverVmPostgresDatabase(
            string? clientPublicKey,

            string vmName)
        {
            ClientPublicKey = clientPublicKey;
            VmName = vmName;
        }
    }
}