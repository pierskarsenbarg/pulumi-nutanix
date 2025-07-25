// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Fetch a category
//
// ## Example
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
//			_, err := nutanix.LookupCategoryV2(ctx, &nutanix.LookupCategoryV2Args{
//				ExtId: "85e68112-5b2b-4220-bc8d-e529e4bf420e",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupCategoryV2(ctx *pulumi.Context, args *LookupCategoryV2Args, opts ...pulumi.InvokeOption) (*LookupCategoryV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupCategoryV2Result
	err := ctx.Invoke("nutanix:index/getCategoryV2:getCategoryV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getCategoryV2.
type LookupCategoryV2Args struct {
	// A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby. The following expansion keys are supported:
	// - associations
	// - detailedAssociations
	Expand *string `pulumi:"expand"`
	// The extID for the category.
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getCategoryV2.
type LookupCategoryV2Result struct {
	// This field gives basic information about resources that are associated to the category.
	Associations []GetCategoryV2Association `pulumi:"associations"`
	// A string consisting of the description of the category as defined by the user.
	Description string `pulumi:"description"`
	// This field gives detailed information about resources that are associated to the category.
	DetailedAssociations []GetCategoryV2DetailedAssociation `pulumi:"detailedAssociations"`
	Expand               *string                            `pulumi:"expand"`
	ExtId                string                             `pulumi:"extId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The key of a category when it is represented in key:value format.
	Key string `pulumi:"key"`
	// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
	Links []GetCategoryV2Link `pulumi:"links"`
	// This field contains the UUID of a user who owns the category.
	OwnerUuid string `pulumi:"ownerUuid"`
	// A globally unique identifier that represents the tenant that owns this entity.
	TenantId string `pulumi:"tenantId"`
	// Denotes the type of a category.
	// There are three types of categories: SYSTEM, INTERNAL, and USER.
	Type string `pulumi:"type"`
	// The value of a category when it is represented in key:value format
	Value string `pulumi:"value"`
}

func LookupCategoryV2Output(ctx *pulumi.Context, args LookupCategoryV2OutputArgs, opts ...pulumi.InvokeOption) LookupCategoryV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupCategoryV2ResultOutput, error) {
			args := v.(LookupCategoryV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getCategoryV2:getCategoryV2", args, LookupCategoryV2ResultOutput{}, options).(LookupCategoryV2ResultOutput), nil
		}).(LookupCategoryV2ResultOutput)
}

// A collection of arguments for invoking getCategoryV2.
type LookupCategoryV2OutputArgs struct {
	// A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby. The following expansion keys are supported:
	// - associations
	// - detailedAssociations
	Expand pulumi.StringPtrInput `pulumi:"expand"`
	// The extID for the category.
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (LookupCategoryV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCategoryV2Args)(nil)).Elem()
}

// A collection of values returned by getCategoryV2.
type LookupCategoryV2ResultOutput struct{ *pulumi.OutputState }

func (LookupCategoryV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCategoryV2Result)(nil)).Elem()
}

func (o LookupCategoryV2ResultOutput) ToLookupCategoryV2ResultOutput() LookupCategoryV2ResultOutput {
	return o
}

func (o LookupCategoryV2ResultOutput) ToLookupCategoryV2ResultOutputWithContext(ctx context.Context) LookupCategoryV2ResultOutput {
	return o
}

// This field gives basic information about resources that are associated to the category.
func (o LookupCategoryV2ResultOutput) Associations() GetCategoryV2AssociationArrayOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) []GetCategoryV2Association { return v.Associations }).(GetCategoryV2AssociationArrayOutput)
}

// A string consisting of the description of the category as defined by the user.
func (o LookupCategoryV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.Description }).(pulumi.StringOutput)
}

// This field gives detailed information about resources that are associated to the category.
func (o LookupCategoryV2ResultOutput) DetailedAssociations() GetCategoryV2DetailedAssociationArrayOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) []GetCategoryV2DetailedAssociation { return v.DetailedAssociations }).(GetCategoryV2DetailedAssociationArrayOutput)
}

func (o LookupCategoryV2ResultOutput) Expand() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) *string { return v.Expand }).(pulumi.StringPtrOutput)
}

func (o LookupCategoryV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupCategoryV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// The key of a category when it is represented in key:value format.
func (o LookupCategoryV2ResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.Key }).(pulumi.StringOutput)
}

// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
func (o LookupCategoryV2ResultOutput) Links() GetCategoryV2LinkArrayOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) []GetCategoryV2Link { return v.Links }).(GetCategoryV2LinkArrayOutput)
}

// This field contains the UUID of a user who owns the category.
func (o LookupCategoryV2ResultOutput) OwnerUuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.OwnerUuid }).(pulumi.StringOutput)
}

// A globally unique identifier that represents the tenant that owns this entity.
func (o LookupCategoryV2ResultOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.TenantId }).(pulumi.StringOutput)
}

// Denotes the type of a category.
// There are three types of categories: SYSTEM, INTERNAL, and USER.
func (o LookupCategoryV2ResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.Type }).(pulumi.StringOutput)
}

// The value of a category when it is represented in key:value format
func (o LookupCategoryV2ResultOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCategoryV2Result) string { return v.Value }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupCategoryV2ResultOutput{})
}
