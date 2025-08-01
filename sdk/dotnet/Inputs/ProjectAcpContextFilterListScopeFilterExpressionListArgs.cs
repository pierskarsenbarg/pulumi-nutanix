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

    public sealed class ProjectAcpContextFilterListScopeFilterExpressionListArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// - (Optional)  The LHS of the filter expression - the scope type.
        /// </summary>
        [Input("leftHandSide", required: true)]
        public Input<string> LeftHandSide { get; set; } = null!;

        /// <summary>
        /// - (Required) The operator in the filter expression.
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        /// <summary>
        /// - (Required) The right hand side (RHS) of an scope expression.
        /// </summary>
        [Input("rightHandSide", required: true)]
        public Input<Inputs.ProjectAcpContextFilterListScopeFilterExpressionListRightHandSideArgs> RightHandSide { get; set; } = null!;

        public ProjectAcpContextFilterListScopeFilterExpressionListArgs()
        {
        }
        public static new ProjectAcpContextFilterListScopeFilterExpressionListArgs Empty => new ProjectAcpContextFilterListScopeFilterExpressionListArgs();
    }
}
