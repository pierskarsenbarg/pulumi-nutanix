// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a Role.
func LookupRole(ctx *pulumi.Context, args *LookupRoleArgs, opts ...pulumi.InvokeOption) (*LookupRoleResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupRoleResult
	err := ctx.Invoke("nutanix:index/getRole:getRole", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRole.
type LookupRoleArgs struct {
	Categories []GetRoleCategory `pulumi:"categories"`
	RoleId     *string           `pulumi:"roleId"`
	RoleName   *string           `pulumi:"roleName"`
}

// A collection of values returned by getRole.
type LookupRoleResult struct {
	// The version of the API.
	// * `state`: - The state of the role.
	ApiVersion  string            `pulumi:"apiVersion"`
	Categories  []GetRoleCategory `pulumi:"categories"`
	Description string            `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id                       string                           `pulumi:"id"`
	Metadata                 map[string]string                `pulumi:"metadata"`
	Name                     string                           `pulumi:"name"`
	OwnerReference           map[string]string                `pulumi:"ownerReference"`
	PermissionReferenceLists []GetRolePermissionReferenceList `pulumi:"permissionReferenceLists"`
	ProjectReference         map[string]string                `pulumi:"projectReference"`
	RoleId                   *string                          `pulumi:"roleId"`
	RoleName                 *string                          `pulumi:"roleName"`
	State                    string                           `pulumi:"state"`
}

func LookupRoleOutput(ctx *pulumi.Context, args LookupRoleOutputArgs, opts ...pulumi.InvokeOption) LookupRoleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRoleResult, error) {
			args := v.(LookupRoleArgs)
			r, err := LookupRole(ctx, &args, opts...)
			var s LookupRoleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRoleResultOutput)
}

// A collection of arguments for invoking getRole.
type LookupRoleOutputArgs struct {
	Categories GetRoleCategoryArrayInput `pulumi:"categories"`
	RoleId     pulumi.StringPtrInput     `pulumi:"roleId"`
	RoleName   pulumi.StringPtrInput     `pulumi:"roleName"`
}

func (LookupRoleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRoleArgs)(nil)).Elem()
}

// A collection of values returned by getRole.
type LookupRoleResultOutput struct{ *pulumi.OutputState }

func (LookupRoleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRoleResult)(nil)).Elem()
}

func (o LookupRoleResultOutput) ToLookupRoleResultOutput() LookupRoleResultOutput {
	return o
}

func (o LookupRoleResultOutput) ToLookupRoleResultOutputWithContext(ctx context.Context) LookupRoleResultOutput {
	return o
}

// The version of the API.
// * `state`: - The state of the role.
func (o LookupRoleResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupRoleResultOutput) Categories() GetRoleCategoryArrayOutput {
	return o.ApplyT(func(v LookupRoleResult) []GetRoleCategory { return v.Categories }).(GetRoleCategoryArrayOutput)
}

func (o LookupRoleResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupRoleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupRoleResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupRoleResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o LookupRoleResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupRoleResultOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupRoleResult) map[string]string { return v.OwnerReference }).(pulumi.StringMapOutput)
}

func (o LookupRoleResultOutput) PermissionReferenceLists() GetRolePermissionReferenceListArrayOutput {
	return o.ApplyT(func(v LookupRoleResult) []GetRolePermissionReferenceList { return v.PermissionReferenceLists }).(GetRolePermissionReferenceListArrayOutput)
}

func (o LookupRoleResultOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupRoleResult) map[string]string { return v.ProjectReference }).(pulumi.StringMapOutput)
}

func (o LookupRoleResultOutput) RoleId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRoleResult) *string { return v.RoleId }).(pulumi.StringPtrOutput)
}

func (o LookupRoleResultOutput) RoleName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRoleResult) *string { return v.RoleName }).(pulumi.StringPtrOutput)
}

func (o LookupRoleResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRoleResult) string { return v.State }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRoleResultOutput{})
}