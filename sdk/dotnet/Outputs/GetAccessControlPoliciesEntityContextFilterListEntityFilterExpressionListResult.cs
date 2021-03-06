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
    public sealed class GetAccessControlPoliciesEntityContextFilterListEntityFilterExpressionListResult
    {
        public readonly string LeftHandSideEntityType;
        public readonly string Operator;
        public readonly ImmutableArray<Outputs.GetAccessControlPoliciesEntityContextFilterListEntityFilterExpressionListRightHandSideResult> RightHandSides;

        [OutputConstructor]
        private GetAccessControlPoliciesEntityContextFilterListEntityFilterExpressionListResult(
            string leftHandSideEntityType,

            string @operator,

            ImmutableArray<Outputs.GetAccessControlPoliciesEntityContextFilterListEntityFilterExpressionListRightHandSideResult> rightHandSides)
        {
            LeftHandSideEntityType = leftHandSideEntityType;
            Operator = @operator;
            RightHandSides = rightHandSides;
        }
    }
}
