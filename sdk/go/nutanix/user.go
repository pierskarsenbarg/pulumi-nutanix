// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a user based on the input parameters.
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
// 		_, err := nutanix.NewUser(ctx, "user", &nutanix.UserArgs{
// 			DirectoryServiceUser: &UserDirectoryServiceUserArgs{
// 				DirectoryServiceReference: &UserDirectoryServiceUserDirectoryServiceReferenceArgs{
// 					Uuid: pulumi.String("<directory-service-uuid>"),
// 				},
// 				UserPrincipalName: pulumi.String("test-user@ntnxlab.local"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
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
// 		_, err := nutanix.NewUser(ctx, "user", &nutanix.UserArgs{
// 			IdentityProviderUser: &UserIdentityProviderUserArgs{
// 				IdentityProviderReference: &UserIdentityProviderUserIdentityProviderReferenceArgs{
// 					Uuid: pulumi.String("<identity-provider-uuid>"),
// 				},
// 				Username: pulumi.String("username"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type User struct {
	pulumi.CustomResourceState

	AccessControlPolicyReferenceLists UserAccessControlPolicyReferenceListArrayOutput `pulumi:"accessControlPolicyReferenceLists"`
	// The version of the API.
	// * `state`: - The state of the entity.
	// * `name`: - The name of the user.
	// * `userType`: - The name of the user.
	// * `displayName`: - The display name of the user (common name) provided by the directory service.
	// * `projectReferenceList`: - A list of projects the user is part of. See #reference for more details.
	// * `accessControlPolicyReferenceList`: - List of ACP references. See #reference for more details.
	ApiVersion            pulumi.StringOutput                 `pulumi:"apiVersion"`
	Categories            UserCategoryArrayOutput             `pulumi:"categories"`
	DirectoryServiceUser  UserDirectoryServiceUserOutput      `pulumi:"directoryServiceUser"`
	DisplayName           pulumi.StringOutput                 `pulumi:"displayName"`
	IdentityProviderUser  UserIdentityProviderUserOutput      `pulumi:"identityProviderUser"`
	Metadata              pulumi.StringMapOutput              `pulumi:"metadata"`
	Name                  pulumi.StringOutput                 `pulumi:"name"`
	OwnerReference        pulumi.StringMapOutput              `pulumi:"ownerReference"`
	ProjectReference      pulumi.StringMapOutput              `pulumi:"projectReference"`
	ProjectReferenceLists UserProjectReferenceListArrayOutput `pulumi:"projectReferenceLists"`
	State                 pulumi.StringOutput                 `pulumi:"state"`
	UserType              pulumi.StringOutput                 `pulumi:"userType"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil {
		args = &UserArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource User
	err := ctx.RegisterResource("nutanix:index/user:User", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserState, opts ...pulumi.ResourceOption) (*User, error) {
	var resource User
	err := ctx.ReadResource("nutanix:index/user:User", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering User resources.
type userState struct {
	AccessControlPolicyReferenceLists []UserAccessControlPolicyReferenceList `pulumi:"accessControlPolicyReferenceLists"`
	// The version of the API.
	// * `state`: - The state of the entity.
	// * `name`: - The name of the user.
	// * `userType`: - The name of the user.
	// * `displayName`: - The display name of the user (common name) provided by the directory service.
	// * `projectReferenceList`: - A list of projects the user is part of. See #reference for more details.
	// * `accessControlPolicyReferenceList`: - List of ACP references. See #reference for more details.
	ApiVersion            *string                    `pulumi:"apiVersion"`
	Categories            []UserCategory             `pulumi:"categories"`
	DirectoryServiceUser  *UserDirectoryServiceUser  `pulumi:"directoryServiceUser"`
	DisplayName           *string                    `pulumi:"displayName"`
	IdentityProviderUser  *UserIdentityProviderUser  `pulumi:"identityProviderUser"`
	Metadata              map[string]string          `pulumi:"metadata"`
	Name                  *string                    `pulumi:"name"`
	OwnerReference        map[string]string          `pulumi:"ownerReference"`
	ProjectReference      map[string]string          `pulumi:"projectReference"`
	ProjectReferenceLists []UserProjectReferenceList `pulumi:"projectReferenceLists"`
	State                 *string                    `pulumi:"state"`
	UserType              *string                    `pulumi:"userType"`
}

type UserState struct {
	AccessControlPolicyReferenceLists UserAccessControlPolicyReferenceListArrayInput
	// The version of the API.
	// * `state`: - The state of the entity.
	// * `name`: - The name of the user.
	// * `userType`: - The name of the user.
	// * `displayName`: - The display name of the user (common name) provided by the directory service.
	// * `projectReferenceList`: - A list of projects the user is part of. See #reference for more details.
	// * `accessControlPolicyReferenceList`: - List of ACP references. See #reference for more details.
	ApiVersion            pulumi.StringPtrInput
	Categories            UserCategoryArrayInput
	DirectoryServiceUser  UserDirectoryServiceUserPtrInput
	DisplayName           pulumi.StringPtrInput
	IdentityProviderUser  UserIdentityProviderUserPtrInput
	Metadata              pulumi.StringMapInput
	Name                  pulumi.StringPtrInput
	OwnerReference        pulumi.StringMapInput
	ProjectReference      pulumi.StringMapInput
	ProjectReferenceLists UserProjectReferenceListArrayInput
	State                 pulumi.StringPtrInput
	UserType              pulumi.StringPtrInput
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	Categories           []UserCategory            `pulumi:"categories"`
	DirectoryServiceUser *UserDirectoryServiceUser `pulumi:"directoryServiceUser"`
	IdentityProviderUser *UserIdentityProviderUser `pulumi:"identityProviderUser"`
	OwnerReference       map[string]string         `pulumi:"ownerReference"`
	ProjectReference     map[string]string         `pulumi:"projectReference"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	Categories           UserCategoryArrayInput
	DirectoryServiceUser UserDirectoryServiceUserPtrInput
	IdentityProviderUser UserIdentityProviderUserPtrInput
	OwnerReference       pulumi.StringMapInput
	ProjectReference     pulumi.StringMapInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}

type UserInput interface {
	pulumi.Input

	ToUserOutput() UserOutput
	ToUserOutputWithContext(ctx context.Context) UserOutput
}

func (*User) ElementType() reflect.Type {
	return reflect.TypeOf((**User)(nil)).Elem()
}

func (i *User) ToUserOutput() UserOutput {
	return i.ToUserOutputWithContext(context.Background())
}

func (i *User) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserOutput)
}

// UserArrayInput is an input type that accepts UserArray and UserArrayOutput values.
// You can construct a concrete instance of `UserArrayInput` via:
//
//          UserArray{ UserArgs{...} }
type UserArrayInput interface {
	pulumi.Input

	ToUserArrayOutput() UserArrayOutput
	ToUserArrayOutputWithContext(context.Context) UserArrayOutput
}

type UserArray []UserInput

func (UserArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*User)(nil)).Elem()
}

func (i UserArray) ToUserArrayOutput() UserArrayOutput {
	return i.ToUserArrayOutputWithContext(context.Background())
}

func (i UserArray) ToUserArrayOutputWithContext(ctx context.Context) UserArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserArrayOutput)
}

// UserMapInput is an input type that accepts UserMap and UserMapOutput values.
// You can construct a concrete instance of `UserMapInput` via:
//
//          UserMap{ "key": UserArgs{...} }
type UserMapInput interface {
	pulumi.Input

	ToUserMapOutput() UserMapOutput
	ToUserMapOutputWithContext(context.Context) UserMapOutput
}

type UserMap map[string]UserInput

func (UserMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*User)(nil)).Elem()
}

func (i UserMap) ToUserMapOutput() UserMapOutput {
	return i.ToUserMapOutputWithContext(context.Background())
}

func (i UserMap) ToUserMapOutputWithContext(ctx context.Context) UserMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserMapOutput)
}

type UserOutput struct{ *pulumi.OutputState }

func (UserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**User)(nil)).Elem()
}

func (o UserOutput) ToUserOutput() UserOutput {
	return o
}

func (o UserOutput) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return o
}

func (o UserOutput) AccessControlPolicyReferenceLists() UserAccessControlPolicyReferenceListArrayOutput {
	return o.ApplyT(func(v *User) UserAccessControlPolicyReferenceListArrayOutput {
		return v.AccessControlPolicyReferenceLists
	}).(UserAccessControlPolicyReferenceListArrayOutput)
}

// The version of the API.
// * `state`: - The state of the entity.
// * `name`: - The name of the user.
// * `userType`: - The name of the user.
// * `displayName`: - The display name of the user (common name) provided by the directory service.
// * `projectReferenceList`: - A list of projects the user is part of. See #reference for more details.
// * `accessControlPolicyReferenceList`: - List of ACP references. See #reference for more details.
func (o UserOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *User) pulumi.StringOutput { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o UserOutput) Categories() UserCategoryArrayOutput {
	return o.ApplyT(func(v *User) UserCategoryArrayOutput { return v.Categories }).(UserCategoryArrayOutput)
}

func (o UserOutput) DirectoryServiceUser() UserDirectoryServiceUserOutput {
	return o.ApplyT(func(v *User) UserDirectoryServiceUserOutput { return v.DirectoryServiceUser }).(UserDirectoryServiceUserOutput)
}

func (o UserOutput) DisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v *User) pulumi.StringOutput { return v.DisplayName }).(pulumi.StringOutput)
}

func (o UserOutput) IdentityProviderUser() UserIdentityProviderUserOutput {
	return o.ApplyT(func(v *User) UserIdentityProviderUserOutput { return v.IdentityProviderUser }).(UserIdentityProviderUserOutput)
}

func (o UserOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v *User) pulumi.StringMapOutput { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o UserOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *User) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o UserOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v *User) pulumi.StringMapOutput { return v.OwnerReference }).(pulumi.StringMapOutput)
}

func (o UserOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v *User) pulumi.StringMapOutput { return v.ProjectReference }).(pulumi.StringMapOutput)
}

func (o UserOutput) ProjectReferenceLists() UserProjectReferenceListArrayOutput {
	return o.ApplyT(func(v *User) UserProjectReferenceListArrayOutput { return v.ProjectReferenceLists }).(UserProjectReferenceListArrayOutput)
}

func (o UserOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *User) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

func (o UserOutput) UserType() pulumi.StringOutput {
	return o.ApplyT(func(v *User) pulumi.StringOutput { return v.UserType }).(pulumi.StringOutput)
}

type UserArrayOutput struct{ *pulumi.OutputState }

func (UserArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*User)(nil)).Elem()
}

func (o UserArrayOutput) ToUserArrayOutput() UserArrayOutput {
	return o
}

func (o UserArrayOutput) ToUserArrayOutputWithContext(ctx context.Context) UserArrayOutput {
	return o
}

func (o UserArrayOutput) Index(i pulumi.IntInput) UserOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *User {
		return vs[0].([]*User)[vs[1].(int)]
	}).(UserOutput)
}

type UserMapOutput struct{ *pulumi.OutputState }

func (UserMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*User)(nil)).Elem()
}

func (o UserMapOutput) ToUserMapOutput() UserMapOutput {
	return o
}

func (o UserMapOutput) ToUserMapOutputWithContext(ctx context.Context) UserMapOutput {
	return o
}

func (o UserMapOutput) MapIndex(k pulumi.StringInput) UserOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *User {
		return vs[0].(map[string]*User)[vs[1].(string)]
	}).(UserOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*UserInput)(nil)).Elem(), &User{})
	pulumi.RegisterInputType(reflect.TypeOf((*UserArrayInput)(nil)).Elem(), UserArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*UserMapInput)(nil)).Elem(), UserMap{})
	pulumi.RegisterOutputType(UserOutput{})
	pulumi.RegisterOutputType(UserArrayOutput{})
	pulumi.RegisterOutputType(UserMapOutput{})
}
