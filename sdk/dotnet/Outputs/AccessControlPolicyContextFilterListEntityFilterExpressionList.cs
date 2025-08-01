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
    public sealed class AccessControlPolicyContextFilterListEntityFilterExpressionList
    {
        /// <summary>
        /// - (Optional)  The LHS of the filter expression - the entity type.
        /// </summary>
        public readonly string? LeftHandSideEntityType;
        /// <summary>
        /// - (Required) The operator in the filter expression.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// - (Required) The right hand side (RHS) of an scope expression.
        /// </summary>
        public readonly Outputs.AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSide RightHandSide;

        [OutputConstructor]
        private AccessControlPolicyContextFilterListEntityFilterExpressionList(
            string? leftHandSideEntityType,

            string @operator,

            Outputs.AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSide rightHandSide)
        {
            LeftHandSideEntityType = leftHandSideEntityType;
            Operator = @operator;
            RightHandSide = rightHandSide;
        }
    }
}
