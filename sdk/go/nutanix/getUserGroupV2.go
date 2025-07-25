// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a datasource to retrieve a user group based on the External Identifier of the User Group.
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
//			_, err := nutanix.GetUserGroupV2(ctx, &nutanix.GetUserGroupV2Args{
//				ExtId: "a2a8650a-358a-4791-90c9-7a8b6e2989d6",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetUserGroupV2(ctx *pulumi.Context, args *GetUserGroupV2Args, opts ...pulumi.InvokeOption) (*GetUserGroupV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetUserGroupV2Result
	err := ctx.Invoke("nutanix:index/getUserGroupV2:getUserGroupV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getUserGroupV2.
type GetUserGroupV2Args struct {
	// - (Required) The External Identifier of the User Group.
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getUserGroupV2.
type GetUserGroupV2Result struct {
	// - User or Service who created the User Group.
	CreatedBy string `pulumi:"createdBy"`
	// - Creation time of the User Group.
	CreatedTime string `pulumi:"createdTime"`
	// - Identifier for the User Group in the form of a distinguished name.
	DistinguishedName string `pulumi:"distinguishedName"`
	// The External Identifier of the User Group.
	ExtId string `pulumi:"extId"`
	// - Type of the User Group. LDAP (User Group belonging to a Directory Service (Open LDAP/AD)),  SAML (User Group belonging to a SAML IDP.)
	GroupType string `pulumi:"groupType"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// - Identifier of the IDP for the User Group.
	IdpId string `pulumi:"idpId"`
	// - Last updated time of the User Group.
	LastUpdatedTime string `pulumi:"lastUpdatedTime"`
	// - Common Name of the User Group.
	Name string `pulumi:"name"`
}

func GetUserGroupV2Output(ctx *pulumi.Context, args GetUserGroupV2OutputArgs, opts ...pulumi.InvokeOption) GetUserGroupV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetUserGroupV2ResultOutput, error) {
			args := v.(GetUserGroupV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getUserGroupV2:getUserGroupV2", args, GetUserGroupV2ResultOutput{}, options).(GetUserGroupV2ResultOutput), nil
		}).(GetUserGroupV2ResultOutput)
}

// A collection of arguments for invoking getUserGroupV2.
type GetUserGroupV2OutputArgs struct {
	// - (Required) The External Identifier of the User Group.
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (GetUserGroupV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUserGroupV2Args)(nil)).Elem()
}

// A collection of values returned by getUserGroupV2.
type GetUserGroupV2ResultOutput struct{ *pulumi.OutputState }

func (GetUserGroupV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetUserGroupV2Result)(nil)).Elem()
}

func (o GetUserGroupV2ResultOutput) ToGetUserGroupV2ResultOutput() GetUserGroupV2ResultOutput {
	return o
}

func (o GetUserGroupV2ResultOutput) ToGetUserGroupV2ResultOutputWithContext(ctx context.Context) GetUserGroupV2ResultOutput {
	return o
}

// - User or Service who created the User Group.
func (o GetUserGroupV2ResultOutput) CreatedBy() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.CreatedBy }).(pulumi.StringOutput)
}

// - Creation time of the User Group.
func (o GetUserGroupV2ResultOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.CreatedTime }).(pulumi.StringOutput)
}

// - Identifier for the User Group in the form of a distinguished name.
func (o GetUserGroupV2ResultOutput) DistinguishedName() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.DistinguishedName }).(pulumi.StringOutput)
}

// The External Identifier of the User Group.
func (o GetUserGroupV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// - Type of the User Group. LDAP (User Group belonging to a Directory Service (Open LDAP/AD)),  SAML (User Group belonging to a SAML IDP.)
func (o GetUserGroupV2ResultOutput) GroupType() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.GroupType }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetUserGroupV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// - Identifier of the IDP for the User Group.
func (o GetUserGroupV2ResultOutput) IdpId() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.IdpId }).(pulumi.StringOutput)
}

// - Last updated time of the User Group.
func (o GetUserGroupV2ResultOutput) LastUpdatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.LastUpdatedTime }).(pulumi.StringOutput)
}

// - Common Name of the User Group.
func (o GetUserGroupV2ResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetUserGroupV2Result) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetUserGroupV2ResultOutput{})
}
