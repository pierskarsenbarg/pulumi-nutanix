// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func LookupServiceGroup(ctx *pulumi.Context, args *LookupServiceGroupArgs, opts ...pulumi.InvokeOption) (*LookupServiceGroupResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupServiceGroupResult
	err := ctx.Invoke("nutanix:index/getServiceGroup:getServiceGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getServiceGroup.
type LookupServiceGroupArgs struct {
	Uuid string `pulumi:"uuid"`
}

// A collection of values returned by getServiceGroup.
type LookupServiceGroupResult struct {
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id              string                       `pulumi:"id"`
	IsSystemDefined bool                         `pulumi:"isSystemDefined"`
	Name            string                       `pulumi:"name"`
	ServiceLists    []GetServiceGroupServiceList `pulumi:"serviceLists"`
	Uuid            string                       `pulumi:"uuid"`
}

func LookupServiceGroupOutput(ctx *pulumi.Context, args LookupServiceGroupOutputArgs, opts ...pulumi.InvokeOption) LookupServiceGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupServiceGroupResult, error) {
			args := v.(LookupServiceGroupArgs)
			r, err := LookupServiceGroup(ctx, &args, opts...)
			var s LookupServiceGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupServiceGroupResultOutput)
}

// A collection of arguments for invoking getServiceGroup.
type LookupServiceGroupOutputArgs struct {
	Uuid pulumi.StringInput `pulumi:"uuid"`
}

func (LookupServiceGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceGroupArgs)(nil)).Elem()
}

// A collection of values returned by getServiceGroup.
type LookupServiceGroupResultOutput struct{ *pulumi.OutputState }

func (LookupServiceGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupServiceGroupResult)(nil)).Elem()
}

func (o LookupServiceGroupResultOutput) ToLookupServiceGroupResultOutput() LookupServiceGroupResultOutput {
	return o
}

func (o LookupServiceGroupResultOutput) ToLookupServiceGroupResultOutputWithContext(ctx context.Context) LookupServiceGroupResultOutput {
	return o
}

func (o LookupServiceGroupResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupServiceGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupServiceGroupResultOutput) IsSystemDefined() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) bool { return v.IsSystemDefined }).(pulumi.BoolOutput)
}

func (o LookupServiceGroupResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupServiceGroupResultOutput) ServiceLists() GetServiceGroupServiceListArrayOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) []GetServiceGroupServiceList { return v.ServiceLists }).(GetServiceGroupServiceListArrayOutput)
}

func (o LookupServiceGroupResultOutput) Uuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupServiceGroupResult) string { return v.Uuid }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupServiceGroupResultOutput{})
}