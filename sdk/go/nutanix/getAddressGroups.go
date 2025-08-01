// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a datasource to retrieve list of address groups.
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
//			_, err := nutanix.GetAddressGroups(ctx, &nutanix.GetAddressGroupsArgs{}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetAddressGroups(ctx *pulumi.Context, args *GetAddressGroupsArgs, opts ...pulumi.InvokeOption) (*GetAddressGroupsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetAddressGroupsResult
	err := ctx.Invoke("nutanix:index/getAddressGroups:getAddressGroups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAddressGroups.
type GetAddressGroupsArgs struct {
	// - (Optional) Use metadata to specify filters
	Metadatas []GetAddressGroupsMetadata `pulumi:"metadatas"`
}

// A collection of values returned by getAddressGroups.
type GetAddressGroupsResult struct {
	// - (ReadOnly) List of address groups
	Entities []GetAddressGroupsEntity `pulumi:"entities"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// - (Optional) Use metadata to specify filters
	Metadatas []GetAddressGroupsMetadata `pulumi:"metadatas"`
}

func GetAddressGroupsOutput(ctx *pulumi.Context, args GetAddressGroupsOutputArgs, opts ...pulumi.InvokeOption) GetAddressGroupsResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetAddressGroupsResultOutput, error) {
			args := v.(GetAddressGroupsArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getAddressGroups:getAddressGroups", args, GetAddressGroupsResultOutput{}, options).(GetAddressGroupsResultOutput), nil
		}).(GetAddressGroupsResultOutput)
}

// A collection of arguments for invoking getAddressGroups.
type GetAddressGroupsOutputArgs struct {
	// - (Optional) Use metadata to specify filters
	Metadatas GetAddressGroupsMetadataArrayInput `pulumi:"metadatas"`
}

func (GetAddressGroupsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAddressGroupsArgs)(nil)).Elem()
}

// A collection of values returned by getAddressGroups.
type GetAddressGroupsResultOutput struct{ *pulumi.OutputState }

func (GetAddressGroupsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAddressGroupsResult)(nil)).Elem()
}

func (o GetAddressGroupsResultOutput) ToGetAddressGroupsResultOutput() GetAddressGroupsResultOutput {
	return o
}

func (o GetAddressGroupsResultOutput) ToGetAddressGroupsResultOutputWithContext(ctx context.Context) GetAddressGroupsResultOutput {
	return o
}

// - (ReadOnly) List of address groups
func (o GetAddressGroupsResultOutput) Entities() GetAddressGroupsEntityArrayOutput {
	return o.ApplyT(func(v GetAddressGroupsResult) []GetAddressGroupsEntity { return v.Entities }).(GetAddressGroupsEntityArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetAddressGroupsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetAddressGroupsResult) string { return v.Id }).(pulumi.StringOutput)
}

// - (Optional) Use metadata to specify filters
func (o GetAddressGroupsResultOutput) Metadatas() GetAddressGroupsMetadataArrayOutput {
	return o.ApplyT(func(v GetAddressGroupsResult) []GetAddressGroupsMetadata { return v.Metadatas }).(GetAddressGroupsMetadataArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetAddressGroupsResultOutput{})
}
