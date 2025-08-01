// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes snapshot policies present in a blueprint. Environment containing snapshot policy must be added in blueprint for this data source to work.
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
//			_, err := nutanix.GetSelfServiceSnapshotPolicyList(ctx, &nutanix.GetSelfServiceSnapshotPolicyListArgs{
//				BpName: pulumi.StringRef("NAME OF BLUEPRINT"),
//				Length: 250,
//				Offset: 0,
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetSelfServiceSnapshotPolicyList(ctx *pulumi.Context, args *GetSelfServiceSnapshotPolicyListArgs, opts ...pulumi.InvokeOption) (*GetSelfServiceSnapshotPolicyListResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSelfServiceSnapshotPolicyListResult
	err := ctx.Invoke("nutanix:index/getSelfServiceSnapshotPolicyList:getSelfServiceSnapshotPolicyList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSelfServiceSnapshotPolicyList.
type GetSelfServiceSnapshotPolicyListArgs struct {
	// - (Optional) The UUID of the blueprint for which snapshot policies should be listed.
	BpName *string `pulumi:"bpName"`
	// - (Optional) The name of the blueprint for which snapshot policies should be listed.
	//
	// Both (`bpName` and `bpUuid`) are optional but atleast one of them to be provided for this data source to work.
	BpUuid *string `pulumi:"bpUuid"`
	// - (Required) The number of snapshot policy records to return.
	Length int `pulumi:"length"`
	// - (Required) The index of the first snapshot policy to return Used for pagination. Default value: 0
	Offset int `pulumi:"offset"`
}

// A collection of values returned by getSelfServiceSnapshotPolicyList.
type GetSelfServiceSnapshotPolicyListResult struct {
	BpName *string `pulumi:"bpName"`
	BpUuid *string `pulumi:"bpUuid"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// - (Required) The number of snapshot policy records to return.
	Length int `pulumi:"length"`
	// - (Required) The index of the first snapshot policy to return Used for pagination. Default value: 0
	Offset      int                                          `pulumi:"offset"`
	PolicyLists []GetSelfServiceSnapshotPolicyListPolicyList `pulumi:"policyLists"`
}

func GetSelfServiceSnapshotPolicyListOutput(ctx *pulumi.Context, args GetSelfServiceSnapshotPolicyListOutputArgs, opts ...pulumi.InvokeOption) GetSelfServiceSnapshotPolicyListResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetSelfServiceSnapshotPolicyListResultOutput, error) {
			args := v.(GetSelfServiceSnapshotPolicyListArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getSelfServiceSnapshotPolicyList:getSelfServiceSnapshotPolicyList", args, GetSelfServiceSnapshotPolicyListResultOutput{}, options).(GetSelfServiceSnapshotPolicyListResultOutput), nil
		}).(GetSelfServiceSnapshotPolicyListResultOutput)
}

// A collection of arguments for invoking getSelfServiceSnapshotPolicyList.
type GetSelfServiceSnapshotPolicyListOutputArgs struct {
	// - (Optional) The UUID of the blueprint for which snapshot policies should be listed.
	BpName pulumi.StringPtrInput `pulumi:"bpName"`
	// - (Optional) The name of the blueprint for which snapshot policies should be listed.
	//
	// Both (`bpName` and `bpUuid`) are optional but atleast one of them to be provided for this data source to work.
	BpUuid pulumi.StringPtrInput `pulumi:"bpUuid"`
	// - (Required) The number of snapshot policy records to return.
	Length pulumi.IntInput `pulumi:"length"`
	// - (Required) The index of the first snapshot policy to return Used for pagination. Default value: 0
	Offset pulumi.IntInput `pulumi:"offset"`
}

func (GetSelfServiceSnapshotPolicyListOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSelfServiceSnapshotPolicyListArgs)(nil)).Elem()
}

// A collection of values returned by getSelfServiceSnapshotPolicyList.
type GetSelfServiceSnapshotPolicyListResultOutput struct{ *pulumi.OutputState }

func (GetSelfServiceSnapshotPolicyListResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSelfServiceSnapshotPolicyListResult)(nil)).Elem()
}

func (o GetSelfServiceSnapshotPolicyListResultOutput) ToGetSelfServiceSnapshotPolicyListResultOutput() GetSelfServiceSnapshotPolicyListResultOutput {
	return o
}

func (o GetSelfServiceSnapshotPolicyListResultOutput) ToGetSelfServiceSnapshotPolicyListResultOutputWithContext(ctx context.Context) GetSelfServiceSnapshotPolicyListResultOutput {
	return o
}

func (o GetSelfServiceSnapshotPolicyListResultOutput) BpName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) *string { return v.BpName }).(pulumi.StringPtrOutput)
}

func (o GetSelfServiceSnapshotPolicyListResultOutput) BpUuid() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) *string { return v.BpUuid }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSelfServiceSnapshotPolicyListResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) string { return v.Id }).(pulumi.StringOutput)
}

// - (Required) The number of snapshot policy records to return.
func (o GetSelfServiceSnapshotPolicyListResultOutput) Length() pulumi.IntOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) int { return v.Length }).(pulumi.IntOutput)
}

// - (Required) The index of the first snapshot policy to return Used for pagination. Default value: 0
func (o GetSelfServiceSnapshotPolicyListResultOutput) Offset() pulumi.IntOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) int { return v.Offset }).(pulumi.IntOutput)
}

func (o GetSelfServiceSnapshotPolicyListResultOutput) PolicyLists() GetSelfServiceSnapshotPolicyListPolicyListArrayOutput {
	return o.ApplyT(func(v GetSelfServiceSnapshotPolicyListResult) []GetSelfServiceSnapshotPolicyListPolicyList {
		return v.PolicyLists
	}).(GetSelfServiceSnapshotPolicyListPolicyListArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSelfServiceSnapshotPolicyListResultOutput{})
}
