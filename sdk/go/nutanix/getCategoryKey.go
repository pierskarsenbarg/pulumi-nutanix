// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describe a Nutanix Category Key and its values (if it has them).
func LookupCategoryKey(ctx *pulumi.Context, args *LookupCategoryKeyArgs, opts ...pulumi.InvokeOption) (*LookupCategoryKeyResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupCategoryKeyResult
	err := ctx.Invoke("nutanix:index/getCategoryKey:getCategoryKey", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCategoryKey.
type LookupCategoryKeyArgs struct {
	Name string `pulumi:"name"`
}

// A collection of values returned by getCategoryKey.
type LookupCategoryKeyResult struct {
	// The version of the API.
	// * `values`: - A list of the values from this category key (if it has them).
	ApiVersion  string `pulumi:"apiVersion"`
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id            string   `pulumi:"id"`
	Name          string   `pulumi:"name"`
	SystemDefined bool     `pulumi:"systemDefined"`
	Values        []string `pulumi:"values"`
}

func LookupCategoryKeyOutput(ctx *pulumi.Context, args LookupCategoryKeyOutputArgs, opts ...pulumi.InvokeOption) LookupCategoryKeyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupCategoryKeyResult, error) {
			args := v.(LookupCategoryKeyArgs)
			r, err := LookupCategoryKey(ctx, &args, opts...)
			var s LookupCategoryKeyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupCategoryKeyResultOutput)
}

// A collection of arguments for invoking getCategoryKey.
type LookupCategoryKeyOutputArgs struct {
	Name pulumi.StringInput `pulumi:"name"`
}

func (LookupCategoryKeyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCategoryKeyArgs)(nil)).Elem()
}

// A collection of values returned by getCategoryKey.
type LookupCategoryKeyResultOutput struct{ *pulumi.OutputState }

func (LookupCategoryKeyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCategoryKeyResult)(nil)).Elem()
}

func (o LookupCategoryKeyResultOutput) ToLookupCategoryKeyResultOutput() LookupCategoryKeyResultOutput {
	return o
}

func (o LookupCategoryKeyResultOutput) ToLookupCategoryKeyResultOutputWithContext(ctx context.Context) LookupCategoryKeyResultOutput {
	return o
}

// The version of the API.
// * `values`: - A list of the values from this category key (if it has them).
func (o LookupCategoryKeyResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupCategoryKeyResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupCategoryKeyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupCategoryKeyResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupCategoryKeyResultOutput) SystemDefined() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) bool { return v.SystemDefined }).(pulumi.BoolOutput)
}

func (o LookupCategoryKeyResultOutput) Values() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupCategoryKeyResult) []string { return v.Values }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupCategoryKeyResultOutput{})
}