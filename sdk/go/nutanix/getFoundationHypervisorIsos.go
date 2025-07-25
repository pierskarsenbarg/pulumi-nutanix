// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a list of hypervisor isos image file details present in foundation vm
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
//			_, err := nutanix.GetFoundationHypervisorIsos(ctx, map[string]interface{}{}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Note
//
// * This data source only lists .iso files details.
//
// See detailed information in [Nutanix Foundation Hypervisor Isos](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjM0MDE-list-hypervisor-images-available-in-foundation).
func GetFoundationHypervisorIsos(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetFoundationHypervisorIsosResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetFoundationHypervisorIsosResult
	err := ctx.Invoke("nutanix:index/getFoundationHypervisorIsos:getFoundationHypervisorIsos", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getFoundationHypervisorIsos.
type GetFoundationHypervisorIsosResult struct {
	// List of esx isos and theirdetails present in foundation vm
	Esxes []GetFoundationHypervisorIsosEsx `pulumi:"esxes"`
	// List of hyperv isos and their details present in foundation vm
	Hypervs []GetFoundationHypervisorIsosHyperv `pulumi:"hypervs"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// List of kvm isos and their details present in foundation vm
	Kvms []GetFoundationHypervisorIsosKvm `pulumi:"kvms"`
	// List of linux isos and their details present in foundation vm
	Linuxes []GetFoundationHypervisorIsosLinux `pulumi:"linuxes"`
	// List of esx isos and theirdetails present in foundation vm
	Xens []GetFoundationHypervisorIsosXen `pulumi:"xens"`
}

func GetFoundationHypervisorIsosOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetFoundationHypervisorIsosResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetFoundationHypervisorIsosResultOutput, error) {
		options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
		return ctx.InvokeOutput("nutanix:index/getFoundationHypervisorIsos:getFoundationHypervisorIsos", nil, GetFoundationHypervisorIsosResultOutput{}, options).(GetFoundationHypervisorIsosResultOutput), nil
	}).(GetFoundationHypervisorIsosResultOutput)
}

// A collection of values returned by getFoundationHypervisorIsos.
type GetFoundationHypervisorIsosResultOutput struct{ *pulumi.OutputState }

func (GetFoundationHypervisorIsosResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFoundationHypervisorIsosResult)(nil)).Elem()
}

func (o GetFoundationHypervisorIsosResultOutput) ToGetFoundationHypervisorIsosResultOutput() GetFoundationHypervisorIsosResultOutput {
	return o
}

func (o GetFoundationHypervisorIsosResultOutput) ToGetFoundationHypervisorIsosResultOutputWithContext(ctx context.Context) GetFoundationHypervisorIsosResultOutput {
	return o
}

// List of esx isos and theirdetails present in foundation vm
func (o GetFoundationHypervisorIsosResultOutput) Esxes() GetFoundationHypervisorIsosEsxArrayOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) []GetFoundationHypervisorIsosEsx { return v.Esxes }).(GetFoundationHypervisorIsosEsxArrayOutput)
}

// List of hyperv isos and their details present in foundation vm
func (o GetFoundationHypervisorIsosResultOutput) Hypervs() GetFoundationHypervisorIsosHypervArrayOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) []GetFoundationHypervisorIsosHyperv { return v.Hypervs }).(GetFoundationHypervisorIsosHypervArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFoundationHypervisorIsosResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) string { return v.Id }).(pulumi.StringOutput)
}

// List of kvm isos and their details present in foundation vm
func (o GetFoundationHypervisorIsosResultOutput) Kvms() GetFoundationHypervisorIsosKvmArrayOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) []GetFoundationHypervisorIsosKvm { return v.Kvms }).(GetFoundationHypervisorIsosKvmArrayOutput)
}

// List of linux isos and their details present in foundation vm
func (o GetFoundationHypervisorIsosResultOutput) Linuxes() GetFoundationHypervisorIsosLinuxArrayOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) []GetFoundationHypervisorIsosLinux { return v.Linuxes }).(GetFoundationHypervisorIsosLinuxArrayOutput)
}

// List of esx isos and theirdetails present in foundation vm
func (o GetFoundationHypervisorIsosResultOutput) Xens() GetFoundationHypervisorIsosXenArrayOutput {
	return o.ApplyT(func(v GetFoundationHypervisorIsosResult) []GetFoundationHypervisorIsosXen { return v.Xens }).(GetFoundationHypervisorIsosXenArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFoundationHypervisorIsosResultOutput{})
}
