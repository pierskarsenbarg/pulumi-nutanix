// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a Network security rule
//
// > NOTE: The use of networkSecurityRule is only applicable in AHV clusters and requires Microsegmentation to be enabled. This feature is a function of the Flow product and requires a Flow license. For more information on Flow and Microsegmentation please visit https://www.nutanix.com/products/flow
//
// ## Example Usage
//
// ### Isolate Development VMs From Production VMs And Get Its Information)
//
// ```go
// package main
//
// import (
//
//	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			isolation, err := nutanix.NewNetworkSecurityRule(ctx, "isolation", &nutanix.NetworkSecurityRuleArgs{
//				Description:         pulumi.String("Isolation Rule Example"),
//				IsolationRuleAction: pulumi.String("APPLY"),
//				IsolationRuleFirstEntityFilterKindLists: pulumi.StringArray{
//					pulumi.String("vm"),
//				},
//				IsolationRuleFirstEntityFilterParams: nutanix.NetworkSecurityRuleIsolationRuleFirstEntityFilterParamArray{
//					&nutanix.NetworkSecurityRuleIsolationRuleFirstEntityFilterParamArgs{
//						Name: pulumi.String("Environment"),
//						Values: pulumi.StringArray{
//							pulumi.String("Dev"),
//						},
//					},
//				},
//				IsolationRuleFirstEntityFilterType: pulumi.String("CATEGORIES_MATCH_ALL"),
//				IsolationRuleSecondEntityFilterKindLists: pulumi.StringArray{
//					pulumi.String("vm"),
//				},
//				IsolationRuleSecondEntityFilterParams: nutanix.NetworkSecurityRuleIsolationRuleSecondEntityFilterParamArray{
//					&nutanix.NetworkSecurityRuleIsolationRuleSecondEntityFilterParamArgs{
//						Name: pulumi.String("Environment"),
//						Values: pulumi.StringArray{
//							pulumi.String("Production"),
//						},
//					},
//				},
//				IsolationRuleSecondEntityFilterType: pulumi.String("CATEGORIES_MATCH_ALL"),
//			})
//			if err != nil {
//				return err
//			}
//			_ = nutanix.LookupNetworkSecurityRuleOutput(ctx, nutanix.GetNetworkSecurityRuleOutputArgs{
//				NetworkSecurityRuleId: isolation.ID(),
//			}, nil)
//			return nil
//		})
//	}
//
// ```
func LookupNetworkSecurityRule(ctx *pulumi.Context, args *LookupNetworkSecurityRuleArgs, opts ...pulumi.InvokeOption) (*LookupNetworkSecurityRuleResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupNetworkSecurityRuleResult
	err := ctx.Invoke("nutanix:index/getNetworkSecurityRule:getNetworkSecurityRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getNetworkSecurityRule.
type LookupNetworkSecurityRuleArgs struct {
	// Categories for the network_security_rule.
	Categories []GetNetworkSecurityRuleCategory `pulumi:"categories"`
	// Represents network security rule UUID
	NetworkSecurityRuleId string `pulumi:"networkSecurityRuleId"`
}

// A collection of values returned by getNetworkSecurityRule.
type LookupNetworkSecurityRuleResult struct {
	// - These rules govern what flows are allowed. Target group is a required attribute. Empty inboundAllowList will not anything into target group. Empty outboundAllowList will allow everything from target group.
	AdRuleAction string `pulumi:"adRuleAction"`
	// The set of categories that matching VMs need to have.
	AdRuleInboundAllowLists  []GetNetworkSecurityRuleAdRuleInboundAllowList  `pulumi:"adRuleInboundAllowLists"`
	AdRuleOutboundAllowLists []GetNetworkSecurityRuleAdRuleOutboundAllowList `pulumi:"adRuleOutboundAllowLists"`
	// - Default policy for communication within target group.
	AdRuleTargetGroupDefaultInternalPolicy string `pulumi:"adRuleTargetGroupDefaultInternalPolicy"`
	// - List of kinds associated with this filter.
	AdRuleTargetGroupFilterKindLists []string `pulumi:"adRuleTargetGroupFilterKindLists"`
	// - A list of category key and list of values.
	AdRuleTargetGroupFilterParams []GetNetworkSecurityRuleAdRuleTargetGroupFilterParam `pulumi:"adRuleTargetGroupFilterParams"`
	// - The type of the filter being used.
	AdRuleTargetGroupFilterType string `pulumi:"adRuleTargetGroupFilterType"`
	// - Way to identify the object for which rule is applied.
	AdRuleTargetGroupPeerSpecificationType string `pulumi:"adRuleTargetGroupPeerSpecificationType"`
	AllowIpv6Traffic                       bool   `pulumi:"allowIpv6Traffic"`
	ApiVersion                             string `pulumi:"apiVersion"`
	// - These rules govern what flows are allowed. Target group is a required attribute. Empty inboundAllowList will not anything into target group. Empty outboundAllowList will allow everything from target group.
	AppRuleAction             string                                           `pulumi:"appRuleAction"`
	AppRuleInboundAllowLists  []GetNetworkSecurityRuleAppRuleInboundAllowList  `pulumi:"appRuleInboundAllowLists"`
	AppRuleOutboundAllowLists []GetNetworkSecurityRuleAppRuleOutboundAllowList `pulumi:"appRuleOutboundAllowLists"`
	// - Default policy for communication within target group.
	AppRuleTargetGroupDefaultInternalPolicy string `pulumi:"appRuleTargetGroupDefaultInternalPolicy"`
	// - List of kinds associated with this filter.
	AppRuleTargetGroupFilterKindLists []string `pulumi:"appRuleTargetGroupFilterKindLists"`
	// - A list of category key and list of values.
	AppRuleTargetGroupFilterParams []GetNetworkSecurityRuleAppRuleTargetGroupFilterParam `pulumi:"appRuleTargetGroupFilterParams"`
	// - The type of the filter being used.
	AppRuleTargetGroupFilterType string `pulumi:"appRuleTargetGroupFilterType"`
	// - Way to identify the object for which rule is applied.
	AppRuleTargetGroupPeerSpecificationType string `pulumi:"appRuleTargetGroupPeerSpecificationType"`
	// Categories for the network_security_rule.
	Categories []GetNetworkSecurityRuleCategory `pulumi:"categories"`
	// A description for network_security_rule.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id                    string `pulumi:"id"`
	IsPolicyHitlogEnabled bool   `pulumi:"isPolicyHitlogEnabled"`
	// - These rules are used for environmental isolation.
	IsolationRuleAction string `pulumi:"isolationRuleAction"`
	// - List of kinds associated with this filter.
	IsolationRuleFirstEntityFilterKindLists []string `pulumi:"isolationRuleFirstEntityFilterKindLists"`
	// - A list of category key and list of values.
	IsolationRuleFirstEntityFilterParams []GetNetworkSecurityRuleIsolationRuleFirstEntityFilterParam `pulumi:"isolationRuleFirstEntityFilterParams"`
	// - The type of the filter being used.
	IsolationRuleFirstEntityFilterType string `pulumi:"isolationRuleFirstEntityFilterType"`
	// - List of kinds associated with this filter.
	IsolationRuleSecondEntityFilterKindLists []string `pulumi:"isolationRuleSecondEntityFilterKindLists"`
	// - A list of category key and list of values.
	IsolationRuleSecondEntityFilterParams []GetNetworkSecurityRuleIsolationRuleSecondEntityFilterParam `pulumi:"isolationRuleSecondEntityFilterParams"`
	// - The type of the filter being used.
	IsolationRuleSecondEntityFilterType string            `pulumi:"isolationRuleSecondEntityFilterType"`
	Metadata                            map[string]string `pulumi:"metadata"`
	// - the name.
	Name string `pulumi:"name"`
	// (Required) The ID for the rule you want to retrieve.
	NetworkSecurityRuleId string `pulumi:"networkSecurityRuleId"`
	// The reference to a user.
	OwnerReference map[string]string `pulumi:"ownerReference"`
	// The reference to a project.
	ProjectReference map[string]string `pulumi:"projectReference"`
	// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inboundAllowList will not allow anything into target group. Empty outboundAllowList will allow everything from target group.
	QuarantineRuleAction             string                                                  `pulumi:"quarantineRuleAction"`
	QuarantineRuleInboundAllowLists  []GetNetworkSecurityRuleQuarantineRuleInboundAllowList  `pulumi:"quarantineRuleInboundAllowLists"`
	QuarantineRuleOutboundAllowLists []GetNetworkSecurityRuleQuarantineRuleOutboundAllowList `pulumi:"quarantineRuleOutboundAllowLists"`
	// - Default policy for communication within target group.
	QuarantineRuleTargetGroupDefaultInternalPolicy string `pulumi:"quarantineRuleTargetGroupDefaultInternalPolicy"`
	// - List of kinds associated with this filter.
	QuarantineRuleTargetGroupFilterKindLists []string `pulumi:"quarantineRuleTargetGroupFilterKindLists"`
	// - A list of category key and list of values.
	QuarantineRuleTargetGroupFilterParams []GetNetworkSecurityRuleQuarantineRuleTargetGroupFilterParam `pulumi:"quarantineRuleTargetGroupFilterParams"`
	// - The type of the filter being used.
	QuarantineRuleTargetGroupFilterType string `pulumi:"quarantineRuleTargetGroupFilterType"`
	// - Way to identify the object for which rule is applied.
	QuarantineRuleTargetGroupPeerSpecificationType string `pulumi:"quarantineRuleTargetGroupPeerSpecificationType"`
}

func LookupNetworkSecurityRuleOutput(ctx *pulumi.Context, args LookupNetworkSecurityRuleOutputArgs, opts ...pulumi.InvokeOption) LookupNetworkSecurityRuleResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupNetworkSecurityRuleResultOutput, error) {
			args := v.(LookupNetworkSecurityRuleArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getNetworkSecurityRule:getNetworkSecurityRule", args, LookupNetworkSecurityRuleResultOutput{}, options).(LookupNetworkSecurityRuleResultOutput), nil
		}).(LookupNetworkSecurityRuleResultOutput)
}

// A collection of arguments for invoking getNetworkSecurityRule.
type LookupNetworkSecurityRuleOutputArgs struct {
	// Categories for the network_security_rule.
	Categories GetNetworkSecurityRuleCategoryArrayInput `pulumi:"categories"`
	// Represents network security rule UUID
	NetworkSecurityRuleId pulumi.StringInput `pulumi:"networkSecurityRuleId"`
}

func (LookupNetworkSecurityRuleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupNetworkSecurityRuleArgs)(nil)).Elem()
}

// A collection of values returned by getNetworkSecurityRule.
type LookupNetworkSecurityRuleResultOutput struct{ *pulumi.OutputState }

func (LookupNetworkSecurityRuleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupNetworkSecurityRuleResult)(nil)).Elem()
}

func (o LookupNetworkSecurityRuleResultOutput) ToLookupNetworkSecurityRuleResultOutput() LookupNetworkSecurityRuleResultOutput {
	return o
}

func (o LookupNetworkSecurityRuleResultOutput) ToLookupNetworkSecurityRuleResultOutputWithContext(ctx context.Context) LookupNetworkSecurityRuleResultOutput {
	return o
}

// - These rules govern what flows are allowed. Target group is a required attribute. Empty inboundAllowList will not anything into target group. Empty outboundAllowList will allow everything from target group.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleAction() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AdRuleAction }).(pulumi.StringOutput)
}

// The set of categories that matching VMs need to have.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleInboundAllowLists() GetNetworkSecurityRuleAdRuleInboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAdRuleInboundAllowList {
		return v.AdRuleInboundAllowLists
	}).(GetNetworkSecurityRuleAdRuleInboundAllowListArrayOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) AdRuleOutboundAllowLists() GetNetworkSecurityRuleAdRuleOutboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAdRuleOutboundAllowList {
		return v.AdRuleOutboundAllowLists
	}).(GetNetworkSecurityRuleAdRuleOutboundAllowListArrayOutput)
}

// - Default policy for communication within target group.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleTargetGroupDefaultInternalPolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AdRuleTargetGroupDefaultInternalPolicy }).(pulumi.StringOutput)
}

// - List of kinds associated with this filter.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleTargetGroupFilterKindLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []string { return v.AdRuleTargetGroupFilterKindLists }).(pulumi.StringArrayOutput)
}

// - A list of category key and list of values.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleTargetGroupFilterParams() GetNetworkSecurityRuleAdRuleTargetGroupFilterParamArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAdRuleTargetGroupFilterParam {
		return v.AdRuleTargetGroupFilterParams
	}).(GetNetworkSecurityRuleAdRuleTargetGroupFilterParamArrayOutput)
}

// - The type of the filter being used.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleTargetGroupFilterType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AdRuleTargetGroupFilterType }).(pulumi.StringOutput)
}

// - Way to identify the object for which rule is applied.
func (o LookupNetworkSecurityRuleResultOutput) AdRuleTargetGroupPeerSpecificationType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AdRuleTargetGroupPeerSpecificationType }).(pulumi.StringOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) AllowIpv6Traffic() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) bool { return v.AllowIpv6Traffic }).(pulumi.BoolOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// - These rules govern what flows are allowed. Target group is a required attribute. Empty inboundAllowList will not anything into target group. Empty outboundAllowList will allow everything from target group.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleAction() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AppRuleAction }).(pulumi.StringOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) AppRuleInboundAllowLists() GetNetworkSecurityRuleAppRuleInboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAppRuleInboundAllowList {
		return v.AppRuleInboundAllowLists
	}).(GetNetworkSecurityRuleAppRuleInboundAllowListArrayOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) AppRuleOutboundAllowLists() GetNetworkSecurityRuleAppRuleOutboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAppRuleOutboundAllowList {
		return v.AppRuleOutboundAllowLists
	}).(GetNetworkSecurityRuleAppRuleOutboundAllowListArrayOutput)
}

// - Default policy for communication within target group.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleTargetGroupDefaultInternalPolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AppRuleTargetGroupDefaultInternalPolicy }).(pulumi.StringOutput)
}

// - List of kinds associated with this filter.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleTargetGroupFilterKindLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []string { return v.AppRuleTargetGroupFilterKindLists }).(pulumi.StringArrayOutput)
}

// - A list of category key and list of values.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleTargetGroupFilterParams() GetNetworkSecurityRuleAppRuleTargetGroupFilterParamArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleAppRuleTargetGroupFilterParam {
		return v.AppRuleTargetGroupFilterParams
	}).(GetNetworkSecurityRuleAppRuleTargetGroupFilterParamArrayOutput)
}

// - The type of the filter being used.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleTargetGroupFilterType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AppRuleTargetGroupFilterType }).(pulumi.StringOutput)
}

// - Way to identify the object for which rule is applied.
func (o LookupNetworkSecurityRuleResultOutput) AppRuleTargetGroupPeerSpecificationType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.AppRuleTargetGroupPeerSpecificationType }).(pulumi.StringOutput)
}

// Categories for the network_security_rule.
func (o LookupNetworkSecurityRuleResultOutput) Categories() GetNetworkSecurityRuleCategoryArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleCategory { return v.Categories }).(GetNetworkSecurityRuleCategoryArrayOutput)
}

// A description for network_security_rule.
func (o LookupNetworkSecurityRuleResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupNetworkSecurityRuleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) IsPolicyHitlogEnabled() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) bool { return v.IsPolicyHitlogEnabled }).(pulumi.BoolOutput)
}

// - These rules are used for environmental isolation.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleAction() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.IsolationRuleAction }).(pulumi.StringOutput)
}

// - List of kinds associated with this filter.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleFirstEntityFilterKindLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []string { return v.IsolationRuleFirstEntityFilterKindLists }).(pulumi.StringArrayOutput)
}

// - A list of category key and list of values.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleFirstEntityFilterParams() GetNetworkSecurityRuleIsolationRuleFirstEntityFilterParamArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleIsolationRuleFirstEntityFilterParam {
		return v.IsolationRuleFirstEntityFilterParams
	}).(GetNetworkSecurityRuleIsolationRuleFirstEntityFilterParamArrayOutput)
}

// - The type of the filter being used.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleFirstEntityFilterType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.IsolationRuleFirstEntityFilterType }).(pulumi.StringOutput)
}

// - List of kinds associated with this filter.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleSecondEntityFilterKindLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []string { return v.IsolationRuleSecondEntityFilterKindLists }).(pulumi.StringArrayOutput)
}

// - A list of category key and list of values.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleSecondEntityFilterParams() GetNetworkSecurityRuleIsolationRuleSecondEntityFilterParamArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleIsolationRuleSecondEntityFilterParam {
		return v.IsolationRuleSecondEntityFilterParams
	}).(GetNetworkSecurityRuleIsolationRuleSecondEntityFilterParamArrayOutput)
}

// - The type of the filter being used.
func (o LookupNetworkSecurityRuleResultOutput) IsolationRuleSecondEntityFilterType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.IsolationRuleSecondEntityFilterType }).(pulumi.StringOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

// - the name.
func (o LookupNetworkSecurityRuleResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.Name }).(pulumi.StringOutput)
}

// (Required) The ID for the rule you want to retrieve.
func (o LookupNetworkSecurityRuleResultOutput) NetworkSecurityRuleId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.NetworkSecurityRuleId }).(pulumi.StringOutput)
}

// The reference to a user.
func (o LookupNetworkSecurityRuleResultOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) map[string]string { return v.OwnerReference }).(pulumi.StringMapOutput)
}

// The reference to a project.
func (o LookupNetworkSecurityRuleResultOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) map[string]string { return v.ProjectReference }).(pulumi.StringMapOutput)
}

// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inboundAllowList will not allow anything into target group. Empty outboundAllowList will allow everything from target group.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleAction() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.QuarantineRuleAction }).(pulumi.StringOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleInboundAllowLists() GetNetworkSecurityRuleQuarantineRuleInboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleQuarantineRuleInboundAllowList {
		return v.QuarantineRuleInboundAllowLists
	}).(GetNetworkSecurityRuleQuarantineRuleInboundAllowListArrayOutput)
}

func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleOutboundAllowLists() GetNetworkSecurityRuleQuarantineRuleOutboundAllowListArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleQuarantineRuleOutboundAllowList {
		return v.QuarantineRuleOutboundAllowLists
	}).(GetNetworkSecurityRuleQuarantineRuleOutboundAllowListArrayOutput)
}

// - Default policy for communication within target group.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleTargetGroupDefaultInternalPolicy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string {
		return v.QuarantineRuleTargetGroupDefaultInternalPolicy
	}).(pulumi.StringOutput)
}

// - List of kinds associated with this filter.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleTargetGroupFilterKindLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []string { return v.QuarantineRuleTargetGroupFilterKindLists }).(pulumi.StringArrayOutput)
}

// - A list of category key and list of values.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleTargetGroupFilterParams() GetNetworkSecurityRuleQuarantineRuleTargetGroupFilterParamArrayOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) []GetNetworkSecurityRuleQuarantineRuleTargetGroupFilterParam {
		return v.QuarantineRuleTargetGroupFilterParams
	}).(GetNetworkSecurityRuleQuarantineRuleTargetGroupFilterParamArrayOutput)
}

// - The type of the filter being used.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleTargetGroupFilterType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string { return v.QuarantineRuleTargetGroupFilterType }).(pulumi.StringOutput)
}

// - Way to identify the object for which rule is applied.
func (o LookupNetworkSecurityRuleResultOutput) QuarantineRuleTargetGroupPeerSpecificationType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNetworkSecurityRuleResult) string {
		return v.QuarantineRuleTargetGroupPeerSpecificationType
	}).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupNetworkSecurityRuleResultOutput{})
}
