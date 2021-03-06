// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create an access control policy based on the input parameters.
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
// 		_, err := nutanix.NewAccessControlPolicy(ctx, "test", &nutanix.AccessControlPolicyArgs{
// 			ContextFilterLists: AccessControlPolicyContextFilterListArray{
// 				&AccessControlPolicyContextFilterListArgs{
// 					EntityFilterExpressionLists: AccessControlPolicyContextFilterListEntityFilterExpressionListArray{
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("cluster"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								UuidList: []string{
// 									"00058ef8-c31c-f0bc-0000-000000007b23",
// 								},
// 							},
// 						},
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("image"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								Collection: pulumi.String("ALL"),
// 							},
// 						},
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("category"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								Collection: pulumi.String("ALL"),
// 							},
// 						},
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("marketplace_item"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								Collection: pulumi.String("SELF_OWNED"),
// 							},
// 						},
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("app_task"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								Collection: pulumi.String("SELF_OWNED"),
// 							},
// 						},
// 						&AccessControlPolicyContextFilterListEntityFilterExpressionListArgs{
// 							LeftHandSideEntityType: pulumi.String("app_variable"),
// 							Operator:               pulumi.String("IN"),
// 							RightHandSide: &AccessControlPolicyContextFilterListEntityFilterExpressionListRightHandSideArgs{
// 								Collection: pulumi.String("SELF_OWNED"),
// 							},
// 						},
// 					},
// 				},
// 			},
// 			Description: pulumi.String("DESCRIPTION OF THE ACCESS CONTROL POLICY"),
// 			RoleReference: &AccessControlPolicyRoleReferenceArgs{
// 				Kind: pulumi.String("role"),
// 				Uuid: pulumi.String("UUID of role"),
// 			},
// 			UserReferenceLists: AccessControlPolicyUserReferenceListArray{
// 				&AccessControlPolicyUserReferenceListArgs{
// 					Name: pulumi.String("admin"),
// 					Uuid: pulumi.String("UUID of User existent"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type AccessControlPolicy struct {
	pulumi.CustomResourceState

	// The version of the API.
	// * `state`: - The state of the Access Control Policy.
	ApiVersion              pulumi.StringOutput                                  `pulumi:"apiVersion"`
	Categories              AccessControlPolicyCategoryArrayOutput               `pulumi:"categories"`
	ContextFilterLists      AccessControlPolicyContextFilterListArrayOutput      `pulumi:"contextFilterLists"`
	Description             pulumi.StringOutput                                  `pulumi:"description"`
	Metadata                pulumi.StringMapOutput                               `pulumi:"metadata"`
	Name                    pulumi.StringOutput                                  `pulumi:"name"`
	OwnerReference          AccessControlPolicyOwnerReferenceOutput              `pulumi:"ownerReference"`
	RoleReference           AccessControlPolicyRoleReferenceOutput               `pulumi:"roleReference"`
	State                   pulumi.StringOutput                                  `pulumi:"state"`
	UserGroupReferenceLists AccessControlPolicyUserGroupReferenceListArrayOutput `pulumi:"userGroupReferenceLists"`
	UserReferenceLists      AccessControlPolicyUserReferenceListArrayOutput      `pulumi:"userReferenceLists"`
}

// NewAccessControlPolicy registers a new resource with the given unique name, arguments, and options.
func NewAccessControlPolicy(ctx *pulumi.Context,
	name string, args *AccessControlPolicyArgs, opts ...pulumi.ResourceOption) (*AccessControlPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RoleReference == nil {
		return nil, errors.New("invalid value for required argument 'RoleReference'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource AccessControlPolicy
	err := ctx.RegisterResource("nutanix:index/accessControlPolicy:AccessControlPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccessControlPolicy gets an existing AccessControlPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccessControlPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccessControlPolicyState, opts ...pulumi.ResourceOption) (*AccessControlPolicy, error) {
	var resource AccessControlPolicy
	err := ctx.ReadResource("nutanix:index/accessControlPolicy:AccessControlPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AccessControlPolicy resources.
type accessControlPolicyState struct {
	// The version of the API.
	// * `state`: - The state of the Access Control Policy.
	ApiVersion              *string                                     `pulumi:"apiVersion"`
	Categories              []AccessControlPolicyCategory               `pulumi:"categories"`
	ContextFilterLists      []AccessControlPolicyContextFilterList      `pulumi:"contextFilterLists"`
	Description             *string                                     `pulumi:"description"`
	Metadata                map[string]string                           `pulumi:"metadata"`
	Name                    *string                                     `pulumi:"name"`
	OwnerReference          *AccessControlPolicyOwnerReference          `pulumi:"ownerReference"`
	RoleReference           *AccessControlPolicyRoleReference           `pulumi:"roleReference"`
	State                   *string                                     `pulumi:"state"`
	UserGroupReferenceLists []AccessControlPolicyUserGroupReferenceList `pulumi:"userGroupReferenceLists"`
	UserReferenceLists      []AccessControlPolicyUserReferenceList      `pulumi:"userReferenceLists"`
}

type AccessControlPolicyState struct {
	// The version of the API.
	// * `state`: - The state of the Access Control Policy.
	ApiVersion              pulumi.StringPtrInput
	Categories              AccessControlPolicyCategoryArrayInput
	ContextFilterLists      AccessControlPolicyContextFilterListArrayInput
	Description             pulumi.StringPtrInput
	Metadata                pulumi.StringMapInput
	Name                    pulumi.StringPtrInput
	OwnerReference          AccessControlPolicyOwnerReferencePtrInput
	RoleReference           AccessControlPolicyRoleReferencePtrInput
	State                   pulumi.StringPtrInput
	UserGroupReferenceLists AccessControlPolicyUserGroupReferenceListArrayInput
	UserReferenceLists      AccessControlPolicyUserReferenceListArrayInput
}

func (AccessControlPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*accessControlPolicyState)(nil)).Elem()
}

type accessControlPolicyArgs struct {
	Categories              []AccessControlPolicyCategory               `pulumi:"categories"`
	ContextFilterLists      []AccessControlPolicyContextFilterList      `pulumi:"contextFilterLists"`
	Description             *string                                     `pulumi:"description"`
	Name                    *string                                     `pulumi:"name"`
	OwnerReference          *AccessControlPolicyOwnerReference          `pulumi:"ownerReference"`
	RoleReference           AccessControlPolicyRoleReference            `pulumi:"roleReference"`
	UserGroupReferenceLists []AccessControlPolicyUserGroupReferenceList `pulumi:"userGroupReferenceLists"`
	UserReferenceLists      []AccessControlPolicyUserReferenceList      `pulumi:"userReferenceLists"`
}

// The set of arguments for constructing a AccessControlPolicy resource.
type AccessControlPolicyArgs struct {
	Categories              AccessControlPolicyCategoryArrayInput
	ContextFilterLists      AccessControlPolicyContextFilterListArrayInput
	Description             pulumi.StringPtrInput
	Name                    pulumi.StringPtrInput
	OwnerReference          AccessControlPolicyOwnerReferencePtrInput
	RoleReference           AccessControlPolicyRoleReferenceInput
	UserGroupReferenceLists AccessControlPolicyUserGroupReferenceListArrayInput
	UserReferenceLists      AccessControlPolicyUserReferenceListArrayInput
}

func (AccessControlPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accessControlPolicyArgs)(nil)).Elem()
}

type AccessControlPolicyInput interface {
	pulumi.Input

	ToAccessControlPolicyOutput() AccessControlPolicyOutput
	ToAccessControlPolicyOutputWithContext(ctx context.Context) AccessControlPolicyOutput
}

func (*AccessControlPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessControlPolicy)(nil)).Elem()
}

func (i *AccessControlPolicy) ToAccessControlPolicyOutput() AccessControlPolicyOutput {
	return i.ToAccessControlPolicyOutputWithContext(context.Background())
}

func (i *AccessControlPolicy) ToAccessControlPolicyOutputWithContext(ctx context.Context) AccessControlPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessControlPolicyOutput)
}

// AccessControlPolicyArrayInput is an input type that accepts AccessControlPolicyArray and AccessControlPolicyArrayOutput values.
// You can construct a concrete instance of `AccessControlPolicyArrayInput` via:
//
//          AccessControlPolicyArray{ AccessControlPolicyArgs{...} }
type AccessControlPolicyArrayInput interface {
	pulumi.Input

	ToAccessControlPolicyArrayOutput() AccessControlPolicyArrayOutput
	ToAccessControlPolicyArrayOutputWithContext(context.Context) AccessControlPolicyArrayOutput
}

type AccessControlPolicyArray []AccessControlPolicyInput

func (AccessControlPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccessControlPolicy)(nil)).Elem()
}

func (i AccessControlPolicyArray) ToAccessControlPolicyArrayOutput() AccessControlPolicyArrayOutput {
	return i.ToAccessControlPolicyArrayOutputWithContext(context.Background())
}

func (i AccessControlPolicyArray) ToAccessControlPolicyArrayOutputWithContext(ctx context.Context) AccessControlPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessControlPolicyArrayOutput)
}

// AccessControlPolicyMapInput is an input type that accepts AccessControlPolicyMap and AccessControlPolicyMapOutput values.
// You can construct a concrete instance of `AccessControlPolicyMapInput` via:
//
//          AccessControlPolicyMap{ "key": AccessControlPolicyArgs{...} }
type AccessControlPolicyMapInput interface {
	pulumi.Input

	ToAccessControlPolicyMapOutput() AccessControlPolicyMapOutput
	ToAccessControlPolicyMapOutputWithContext(context.Context) AccessControlPolicyMapOutput
}

type AccessControlPolicyMap map[string]AccessControlPolicyInput

func (AccessControlPolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccessControlPolicy)(nil)).Elem()
}

func (i AccessControlPolicyMap) ToAccessControlPolicyMapOutput() AccessControlPolicyMapOutput {
	return i.ToAccessControlPolicyMapOutputWithContext(context.Background())
}

func (i AccessControlPolicyMap) ToAccessControlPolicyMapOutputWithContext(ctx context.Context) AccessControlPolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessControlPolicyMapOutput)
}

type AccessControlPolicyOutput struct{ *pulumi.OutputState }

func (AccessControlPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessControlPolicy)(nil)).Elem()
}

func (o AccessControlPolicyOutput) ToAccessControlPolicyOutput() AccessControlPolicyOutput {
	return o
}

func (o AccessControlPolicyOutput) ToAccessControlPolicyOutputWithContext(ctx context.Context) AccessControlPolicyOutput {
	return o
}

// The version of the API.
// * `state`: - The state of the Access Control Policy.
func (o AccessControlPolicyOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessControlPolicy) pulumi.StringOutput { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o AccessControlPolicyOutput) Categories() AccessControlPolicyCategoryArrayOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyCategoryArrayOutput { return v.Categories }).(AccessControlPolicyCategoryArrayOutput)
}

func (o AccessControlPolicyOutput) ContextFilterLists() AccessControlPolicyContextFilterListArrayOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyContextFilterListArrayOutput {
		return v.ContextFilterLists
	}).(AccessControlPolicyContextFilterListArrayOutput)
}

func (o AccessControlPolicyOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessControlPolicy) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

func (o AccessControlPolicyOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v *AccessControlPolicy) pulumi.StringMapOutput { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o AccessControlPolicyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessControlPolicy) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o AccessControlPolicyOutput) OwnerReference() AccessControlPolicyOwnerReferenceOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyOwnerReferenceOutput { return v.OwnerReference }).(AccessControlPolicyOwnerReferenceOutput)
}

func (o AccessControlPolicyOutput) RoleReference() AccessControlPolicyRoleReferenceOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyRoleReferenceOutput { return v.RoleReference }).(AccessControlPolicyRoleReferenceOutput)
}

func (o AccessControlPolicyOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *AccessControlPolicy) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

func (o AccessControlPolicyOutput) UserGroupReferenceLists() AccessControlPolicyUserGroupReferenceListArrayOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyUserGroupReferenceListArrayOutput {
		return v.UserGroupReferenceLists
	}).(AccessControlPolicyUserGroupReferenceListArrayOutput)
}

func (o AccessControlPolicyOutput) UserReferenceLists() AccessControlPolicyUserReferenceListArrayOutput {
	return o.ApplyT(func(v *AccessControlPolicy) AccessControlPolicyUserReferenceListArrayOutput {
		return v.UserReferenceLists
	}).(AccessControlPolicyUserReferenceListArrayOutput)
}

type AccessControlPolicyArrayOutput struct{ *pulumi.OutputState }

func (AccessControlPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccessControlPolicy)(nil)).Elem()
}

func (o AccessControlPolicyArrayOutput) ToAccessControlPolicyArrayOutput() AccessControlPolicyArrayOutput {
	return o
}

func (o AccessControlPolicyArrayOutput) ToAccessControlPolicyArrayOutputWithContext(ctx context.Context) AccessControlPolicyArrayOutput {
	return o
}

func (o AccessControlPolicyArrayOutput) Index(i pulumi.IntInput) AccessControlPolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AccessControlPolicy {
		return vs[0].([]*AccessControlPolicy)[vs[1].(int)]
	}).(AccessControlPolicyOutput)
}

type AccessControlPolicyMapOutput struct{ *pulumi.OutputState }

func (AccessControlPolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccessControlPolicy)(nil)).Elem()
}

func (o AccessControlPolicyMapOutput) ToAccessControlPolicyMapOutput() AccessControlPolicyMapOutput {
	return o
}

func (o AccessControlPolicyMapOutput) ToAccessControlPolicyMapOutputWithContext(ctx context.Context) AccessControlPolicyMapOutput {
	return o
}

func (o AccessControlPolicyMapOutput) MapIndex(k pulumi.StringInput) AccessControlPolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AccessControlPolicy {
		return vs[0].(map[string]*AccessControlPolicy)[vs[1].(string)]
	}).(AccessControlPolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AccessControlPolicyInput)(nil)).Elem(), &AccessControlPolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessControlPolicyArrayInput)(nil)).Elem(), AccessControlPolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessControlPolicyMapInput)(nil)).Elem(), AccessControlPolicyMap{})
	pulumi.RegisterOutputType(AccessControlPolicyOutput{})
	pulumi.RegisterOutputType(AccessControlPolicyArrayOutput{})
	pulumi.RegisterOutputType(AccessControlPolicyMapOutput{})
}
