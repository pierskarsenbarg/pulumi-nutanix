// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a datasource to retrieve static routes within VPCs given vpc_uuid.
func LookupStaticRoutes(ctx *pulumi.Context, args *LookupStaticRoutesArgs, opts ...pulumi.InvokeOption) (*LookupStaticRoutesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupStaticRoutesResult
	err := ctx.Invoke("nutanix:index/getStaticRoutes:getStaticRoutes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getStaticRoutes.
type LookupStaticRoutesArgs struct {
	VpcName *string `pulumi:"vpcName"`
	// vpc UUID
	VpcReferenceUuid *string `pulumi:"vpcReferenceUuid"`
}

// A collection of values returned by getStaticRoutes.
type LookupStaticRoutesResult struct {
	// API version
	ApiVersion string `pulumi:"apiVersion"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The vpcRouteTable kind metadata
	Metadata map[string]string `pulumi:"metadata"`
	// An intentful representation of a vpcRouteTable spec
	Specs []GetStaticRoutesSpec `pulumi:"specs"`
	// An intentful representation of a vpcRouteTable status
	Statuses         []GetStaticRoutesStatus `pulumi:"statuses"`
	VpcName          *string                 `pulumi:"vpcName"`
	VpcReferenceUuid *string                 `pulumi:"vpcReferenceUuid"`
}

func LookupStaticRoutesOutput(ctx *pulumi.Context, args LookupStaticRoutesOutputArgs, opts ...pulumi.InvokeOption) LookupStaticRoutesResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupStaticRoutesResultOutput, error) {
			args := v.(LookupStaticRoutesArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getStaticRoutes:getStaticRoutes", args, LookupStaticRoutesResultOutput{}, options).(LookupStaticRoutesResultOutput), nil
		}).(LookupStaticRoutesResultOutput)
}

// A collection of arguments for invoking getStaticRoutes.
type LookupStaticRoutesOutputArgs struct {
	VpcName pulumi.StringPtrInput `pulumi:"vpcName"`
	// vpc UUID
	VpcReferenceUuid pulumi.StringPtrInput `pulumi:"vpcReferenceUuid"`
}

func (LookupStaticRoutesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupStaticRoutesArgs)(nil)).Elem()
}

// A collection of values returned by getStaticRoutes.
type LookupStaticRoutesResultOutput struct{ *pulumi.OutputState }

func (LookupStaticRoutesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupStaticRoutesResult)(nil)).Elem()
}

func (o LookupStaticRoutesResultOutput) ToLookupStaticRoutesResultOutput() LookupStaticRoutesResultOutput {
	return o
}

func (o LookupStaticRoutesResultOutput) ToLookupStaticRoutesResultOutputWithContext(ctx context.Context) LookupStaticRoutesResultOutput {
	return o
}

// API version
func (o LookupStaticRoutesResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupStaticRoutesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) string { return v.Id }).(pulumi.StringOutput)
}

// The vpcRouteTable kind metadata
func (o LookupStaticRoutesResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

// An intentful representation of a vpcRouteTable spec
func (o LookupStaticRoutesResultOutput) Specs() GetStaticRoutesSpecArrayOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) []GetStaticRoutesSpec { return v.Specs }).(GetStaticRoutesSpecArrayOutput)
}

// An intentful representation of a vpcRouteTable status
func (o LookupStaticRoutesResultOutput) Statuses() GetStaticRoutesStatusArrayOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) []GetStaticRoutesStatus { return v.Statuses }).(GetStaticRoutesStatusArrayOutput)
}

func (o LookupStaticRoutesResultOutput) VpcName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) *string { return v.VpcName }).(pulumi.StringPtrOutput)
}

func (o LookupStaticRoutesResultOutput) VpcReferenceUuid() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupStaticRoutesResult) *string { return v.VpcReferenceUuid }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupStaticRoutesResultOutput{})
}
