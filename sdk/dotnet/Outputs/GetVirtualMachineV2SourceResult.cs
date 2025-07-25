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
    public sealed class GetVirtualMachineV2SourceResult
    {
        /// <summary>
        /// Reference to an entity from which the VM should be cloned or created. Values are:
        /// - VM_RECOVERY_POINT: Reference to the recovery point entity from which the VM should be cloned or created.
        /// - VM: Reference to an entity from which the VM should be cloned or created.
        /// </summary>
        public readonly string EntityType;
        /// <summary>
        /// Represents virtual machine UUID
        /// </summary>
        public readonly string ExtId;

        [OutputConstructor]
        private GetVirtualMachineV2SourceResult(
            string entityType,

            string extId)
        {
            EntityType = entityType;
            ExtId = extId;
        }
    }
}
