// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// List all time machines present in Nutanix Database Service
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
//			_, err := nutanix.GetNdbTimeMachines(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetNdbTimeMachines(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetNdbTimeMachinesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetNdbTimeMachinesResult
	err := ctx.Invoke("nutanix:index/getNdbTimeMachines:getNdbTimeMachines", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getNdbTimeMachines.
type GetNdbTimeMachinesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id           string                          `pulumi:"id"`
	TimeMachines []GetNdbTimeMachinesTimeMachine `pulumi:"timeMachines"`
}

func GetNdbTimeMachinesOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetNdbTimeMachinesResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetNdbTimeMachinesResult, error) {
		r, err := GetNdbTimeMachines(ctx, opts...)
		var s GetNdbTimeMachinesResult
		if r != nil {
			s = *r
		}
		return s, err
	}).(GetNdbTimeMachinesResultOutput)
}

// A collection of values returned by getNdbTimeMachines.
type GetNdbTimeMachinesResultOutput struct{ *pulumi.OutputState }

func (GetNdbTimeMachinesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNdbTimeMachinesResult)(nil)).Elem()
}

func (o GetNdbTimeMachinesResultOutput) ToGetNdbTimeMachinesResultOutput() GetNdbTimeMachinesResultOutput {
	return o
}

func (o GetNdbTimeMachinesResultOutput) ToGetNdbTimeMachinesResultOutputWithContext(ctx context.Context) GetNdbTimeMachinesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetNdbTimeMachinesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbTimeMachinesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetNdbTimeMachinesResultOutput) TimeMachines() GetNdbTimeMachinesTimeMachineArrayOutput {
	return o.ApplyT(func(v GetNdbTimeMachinesResult) []GetNdbTimeMachinesTimeMachine { return v.TimeMachines }).(GetNdbTimeMachinesTimeMachineArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetNdbTimeMachinesResultOutput{})
}