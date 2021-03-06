// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes Karbon private registry entry
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := nutanix.LookupKarbonPrivateRegistry(ctx, &GetKarbonPrivateRegistryArgs{
// 			ClusterId: "<YOUR-CLUSTER-ID>",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupKarbonPrivateRegistry(ctx *pulumi.Context, args *LookupKarbonPrivateRegistryArgs, opts ...pulumi.InvokeOption) (*LookupKarbonPrivateRegistryResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupKarbonPrivateRegistryResult
	err := ctx.Invoke("nutanix:index/getKarbonPrivateRegistry:getKarbonPrivateRegistry", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKarbonPrivateRegistry.
type LookupKarbonPrivateRegistryArgs struct {
	PrivateRegistryId   *string `pulumi:"privateRegistryId"`
	PrivateRegistryName *string `pulumi:"privateRegistryName"`
}

// A collection of values returned by getKarbonPrivateRegistry.
type LookupKarbonPrivateRegistryResult struct {
	Endpoint string `pulumi:"endpoint"`
	// The provider-assigned unique ID for this managed resource.
	Id                  string  `pulumi:"id"`
	Name                string  `pulumi:"name"`
	PrivateRegistryId   *string `pulumi:"privateRegistryId"`
	PrivateRegistryName *string `pulumi:"privateRegistryName"`
	Uuid                string  `pulumi:"uuid"`
}

func LookupKarbonPrivateRegistryOutput(ctx *pulumi.Context, args LookupKarbonPrivateRegistryOutputArgs, opts ...pulumi.InvokeOption) LookupKarbonPrivateRegistryResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupKarbonPrivateRegistryResult, error) {
			args := v.(LookupKarbonPrivateRegistryArgs)
			r, err := LookupKarbonPrivateRegistry(ctx, &args, opts...)
			var s LookupKarbonPrivateRegistryResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupKarbonPrivateRegistryResultOutput)
}

// A collection of arguments for invoking getKarbonPrivateRegistry.
type LookupKarbonPrivateRegistryOutputArgs struct {
	PrivateRegistryId   pulumi.StringPtrInput `pulumi:"privateRegistryId"`
	PrivateRegistryName pulumi.StringPtrInput `pulumi:"privateRegistryName"`
}

func (LookupKarbonPrivateRegistryOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKarbonPrivateRegistryArgs)(nil)).Elem()
}

// A collection of values returned by getKarbonPrivateRegistry.
type LookupKarbonPrivateRegistryResultOutput struct{ *pulumi.OutputState }

func (LookupKarbonPrivateRegistryResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupKarbonPrivateRegistryResult)(nil)).Elem()
}

func (o LookupKarbonPrivateRegistryResultOutput) ToLookupKarbonPrivateRegistryResultOutput() LookupKarbonPrivateRegistryResultOutput {
	return o
}

func (o LookupKarbonPrivateRegistryResultOutput) ToLookupKarbonPrivateRegistryResultOutputWithContext(ctx context.Context) LookupKarbonPrivateRegistryResultOutput {
	return o
}

func (o LookupKarbonPrivateRegistryResultOutput) Endpoint() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) string { return v.Endpoint }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupKarbonPrivateRegistryResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupKarbonPrivateRegistryResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupKarbonPrivateRegistryResultOutput) PrivateRegistryId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) *string { return v.PrivateRegistryId }).(pulumi.StringPtrOutput)
}

func (o LookupKarbonPrivateRegistryResultOutput) PrivateRegistryName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) *string { return v.PrivateRegistryName }).(pulumi.StringPtrOutput)
}

func (o LookupKarbonPrivateRegistryResultOutput) Uuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupKarbonPrivateRegistryResult) string { return v.Uuid }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupKarbonPrivateRegistryResultOutput{})
}
