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
    public sealed class GetProjectAcpContextFilterListEntityFilterExpressionListResult
    {
        /// <summary>
        /// - (Optional)  The LHS of the filter expression - the entity type.
        /// </summary>
        public readonly string LeftHandSideEntityType;
        /// <summary>
        /// - (Required) The operator in the filter expression.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// - (Required) The right hand side (RHS) of an scope expression.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectAcpContextFilterListEntityFilterExpressionListRightHandSideResult> RightHandSides;

        [OutputConstructor]
        private GetProjectAcpContextFilterListEntityFilterExpressionListResult(
            string leftHandSideEntityType,

            string @operator,

            ImmutableArray<Outputs.GetProjectAcpContextFilterListEntityFilterExpressionListRightHandSideResult> rightHandSides)
        {
            LeftHandSideEntityType = leftHandSideEntityType;
            Operator = @operator;
            RightHandSides = rightHandSides;
        }
    }
}
