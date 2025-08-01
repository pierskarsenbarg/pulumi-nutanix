// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a list of roles.
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
//			_, err := nutanix.GetRoles(ctx, &nutanix.GetRolesArgs{}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetRoles(ctx *pulumi.Context, args *GetRolesArgs, opts ...pulumi.InvokeOption) (*GetRolesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRolesResult
	err := ctx.Invoke("nutanix:index/getRoles:getRoles", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRoles.
type GetRolesArgs struct {
	// - The role kind metadata.
	Metadatas []GetRolesMetadata `pulumi:"metadatas"`
}

// A collection of values returned by getRoles.
type GetRolesResult struct {
	// The version of the API.
	ApiVersion string `pulumi:"apiVersion"`
	// List of Roles
	Entities []GetRolesEntity `pulumi:"entities"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// - The role kind metadata.
	Metadatas []GetRolesMetadata `pulumi:"metadatas"`
}

func GetRolesOutput(ctx *pulumi.Context, args GetRolesOutputArgs, opts ...pulumi.InvokeOption) GetRolesResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetRolesResultOutput, error) {
			args := v.(GetRolesArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getRoles:getRoles", args, GetRolesResultOutput{}, options).(GetRolesResultOutput), nil
		}).(GetRolesResultOutput)
}

// A collection of arguments for invoking getRoles.
type GetRolesOutputArgs struct {
	// - The role kind metadata.
	Metadatas GetRolesMetadataArrayInput `pulumi:"metadatas"`
}

func (GetRolesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRolesArgs)(nil)).Elem()
}

// A collection of values returned by getRoles.
type GetRolesResultOutput struct{ *pulumi.OutputState }

func (GetRolesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRolesResult)(nil)).Elem()
}

func (o GetRolesResultOutput) ToGetRolesResultOutput() GetRolesResultOutput {
	return o
}

func (o GetRolesResultOutput) ToGetRolesResultOutputWithContext(ctx context.Context) GetRolesResultOutput {
	return o
}

// The version of the API.
func (o GetRolesResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v GetRolesResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// List of Roles
func (o GetRolesResultOutput) Entities() GetRolesEntityArrayOutput {
	return o.ApplyT(func(v GetRolesResult) []GetRolesEntity { return v.Entities }).(GetRolesEntityArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRolesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRolesResult) string { return v.Id }).(pulumi.StringOutput)
}

// - The role kind metadata.
func (o GetRolesResultOutput) Metadatas() GetRolesMetadataArrayOutput {
	return o.ApplyT(func(v GetRolesResult) []GetRolesMetadata { return v.Metadatas }).(GetRolesMetadataArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRolesResultOutput{})
}
