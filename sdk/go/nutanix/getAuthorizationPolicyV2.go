// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupAuthorizationPolicyV2(ctx *pulumi.Context, args *LookupAuthorizationPolicyV2Args, opts ...pulumi.InvokeOption) (*LookupAuthorizationPolicyV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupAuthorizationPolicyV2Result
	err := ctx.Invoke("nutanix:index/getAuthorizationPolicyV2:getAuthorizationPolicyV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAuthorizationPolicyV2.
type LookupAuthorizationPolicyV2Args struct {
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getAuthorizationPolicyV2.
type LookupAuthorizationPolicyV2Result struct {
	AuthorizationPolicyType string                           `pulumi:"authorizationPolicyType"`
	ClientName              string                           `pulumi:"clientName"`
	CreatedBy               string                           `pulumi:"createdBy"`
	CreatedTime             string                           `pulumi:"createdTime"`
	Description             string                           `pulumi:"description"`
	DisplayName             string                           `pulumi:"displayName"`
	Entities                []GetAuthorizationPolicyV2Entity `pulumi:"entities"`
	ExtId                   string                           `pulumi:"extId"`
	// The provider-assigned unique ID for this managed resource.
	Id              string                             `pulumi:"id"`
	Identities      []GetAuthorizationPolicyV2Identity `pulumi:"identities"`
	IsSystemDefined bool                               `pulumi:"isSystemDefined"`
	LastUpdatedTime string                             `pulumi:"lastUpdatedTime"`
	Role            string                             `pulumi:"role"`
}

func LookupAuthorizationPolicyV2Output(ctx *pulumi.Context, args LookupAuthorizationPolicyV2OutputArgs, opts ...pulumi.InvokeOption) LookupAuthorizationPolicyV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupAuthorizationPolicyV2ResultOutput, error) {
			args := v.(LookupAuthorizationPolicyV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getAuthorizationPolicyV2:getAuthorizationPolicyV2", args, LookupAuthorizationPolicyV2ResultOutput{}, options).(LookupAuthorizationPolicyV2ResultOutput), nil
		}).(LookupAuthorizationPolicyV2ResultOutput)
}

// A collection of arguments for invoking getAuthorizationPolicyV2.
type LookupAuthorizationPolicyV2OutputArgs struct {
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (LookupAuthorizationPolicyV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAuthorizationPolicyV2Args)(nil)).Elem()
}

// A collection of values returned by getAuthorizationPolicyV2.
type LookupAuthorizationPolicyV2ResultOutput struct{ *pulumi.OutputState }

func (LookupAuthorizationPolicyV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupAuthorizationPolicyV2Result)(nil)).Elem()
}

func (o LookupAuthorizationPolicyV2ResultOutput) ToLookupAuthorizationPolicyV2ResultOutput() LookupAuthorizationPolicyV2ResultOutput {
	return o
}

func (o LookupAuthorizationPolicyV2ResultOutput) ToLookupAuthorizationPolicyV2ResultOutputWithContext(ctx context.Context) LookupAuthorizationPolicyV2ResultOutput {
	return o
}

func (o LookupAuthorizationPolicyV2ResultOutput) AuthorizationPolicyType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.AuthorizationPolicyType }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) ClientName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.ClientName }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) CreatedBy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.CreatedBy }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.CreatedTime }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.DisplayName }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) Entities() GetAuthorizationPolicyV2EntityArrayOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) []GetAuthorizationPolicyV2Entity { return v.Entities }).(GetAuthorizationPolicyV2EntityArrayOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupAuthorizationPolicyV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) Identities() GetAuthorizationPolicyV2IdentityArrayOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) []GetAuthorizationPolicyV2Identity { return v.Identities }).(GetAuthorizationPolicyV2IdentityArrayOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) IsSystemDefined() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) bool { return v.IsSystemDefined }).(pulumi.BoolOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) LastUpdatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.LastUpdatedTime }).(pulumi.StringOutput)
}

func (o LookupAuthorizationPolicyV2ResultOutput) Role() pulumi.StringOutput {
	return o.ApplyT(func(v LookupAuthorizationPolicyV2Result) string { return v.Role }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupAuthorizationPolicyV2ResultOutput{})
}
