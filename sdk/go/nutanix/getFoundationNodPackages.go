// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a list of nos (aos) packages present in foundation vm
//
// ## Example Usage
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
//			_, err := nutanix.GetFoundationNodPackages(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// ## Note
//
// * This data source only lists .tar file names.
//
// See detailed information in [Nutanix Foundation Nos Packages](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjMzODg-get-list-of-aos-packages-available-in-foundation).
func GetFoundationNodPackages(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetFoundationNodPackagesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetFoundationNodPackagesResult
	err := ctx.Invoke("nutanix:index/getFoundationNodPackages:getFoundationNodPackages", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getFoundationNodPackages.
type GetFoundationNodPackagesResult struct {
	// List of nos packages file names present in foundation vm
	Entities []string `pulumi:"entities"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}

func GetFoundationNodPackagesOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetFoundationNodPackagesResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetFoundationNodPackagesResult, error) {
		r, err := GetFoundationNodPackages(ctx, opts...)
		var s GetFoundationNodPackagesResult
		if r != nil {
			s = *r
		}
		return s, err
	}).(GetFoundationNodPackagesResultOutput)
}

// A collection of values returned by getFoundationNodPackages.
type GetFoundationNodPackagesResultOutput struct{ *pulumi.OutputState }

func (GetFoundationNodPackagesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoundationNodPackagesResult)(nil)).Elem()
}

func (o GetFoundationNodPackagesResultOutput) ToGetFoundationNodPackagesResultOutput() GetFoundationNodPackagesResultOutput {
	return o
}

func (o GetFoundationNodPackagesResultOutput) ToGetFoundationNodPackagesResultOutputWithContext(ctx context.Context) GetFoundationNodPackagesResultOutput {
	return o
}

// List of nos packages file names present in foundation vm
func (o GetFoundationNodPackagesResultOutput) Entities() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetFoundationNodPackagesResult) []string { return v.Entities }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFoundationNodPackagesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoundationNodPackagesResult) string { return v.Id }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFoundationNodPackagesResultOutput{})
}
