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
    public sealed class NdbCloneTimeMachineProperty
    {
        /// <summary>
        /// database instance description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// database instance name
        /// </summary>
        public readonly string? Name;
        public readonly string? RefId;
        public readonly bool? Secure;
        public readonly string? Value;

        [OutputConstructor]
        private NdbCloneTimeMachineProperty(
            string? description,

            string? name,

            string? refId,

            bool? secure,

            string? value)
        {
            Description = description;
            Name = name;
            RefId = refId;
            Secure = secure;
            Value = value;
        }
    }
}