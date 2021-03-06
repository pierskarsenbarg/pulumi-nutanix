// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a address group based on the input parameters.
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
// 		_, err := nutanix.NewAddressGroup(ctx, "testAddress", &nutanix.AddressGroupArgs{
// 			Description: pulumi.String("test address groups resource"),
// 			IpAddressBlockLists: AddressGroupIpAddressBlockListArray{
// 				&AddressGroupIpAddressBlockListArgs{
// 					Ip:           pulumi.String("10.0.0.0"),
// 					PrefixLength: pulumi.Int(24),
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
type AddressGroup struct {
	pulumi.CustomResourceState

	AddressGroupString  pulumi.StringOutput                       `pulumi:"addressGroupString"`
	Description         pulumi.StringPtrOutput                    `pulumi:"description"`
	IpAddressBlockLists AddressGroupIpAddressBlockListArrayOutput `pulumi:"ipAddressBlockLists"`
	Name                pulumi.StringOutput                       `pulumi:"name"`
}

// NewAddressGroup registers a new resource with the given unique name, arguments, and options.
func NewAddressGroup(ctx *pulumi.Context,
	name string, args *AddressGroupArgs, opts ...pulumi.ResourceOption) (*AddressGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.IpAddressBlockLists == nil {
		return nil, errors.New("invalid value for required argument 'IpAddressBlockLists'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource AddressGroup
	err := ctx.RegisterResource("nutanix:index/addressGroup:AddressGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAddressGroup gets an existing AddressGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddressGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AddressGroupState, opts ...pulumi.ResourceOption) (*AddressGroup, error) {
	var resource AddressGroup
	err := ctx.ReadResource("nutanix:index/addressGroup:AddressGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AddressGroup resources.
type addressGroupState struct {
	AddressGroupString  *string                          `pulumi:"addressGroupString"`
	Description         *string                          `pulumi:"description"`
	IpAddressBlockLists []AddressGroupIpAddressBlockList `pulumi:"ipAddressBlockLists"`
	Name                *string                          `pulumi:"name"`
}

type AddressGroupState struct {
	AddressGroupString  pulumi.StringPtrInput
	Description         pulumi.StringPtrInput
	IpAddressBlockLists AddressGroupIpAddressBlockListArrayInput
	Name                pulumi.StringPtrInput
}

func (AddressGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*addressGroupState)(nil)).Elem()
}

type addressGroupArgs struct {
	Description         *string                          `pulumi:"description"`
	IpAddressBlockLists []AddressGroupIpAddressBlockList `pulumi:"ipAddressBlockLists"`
	Name                *string                          `pulumi:"name"`
}

// The set of arguments for constructing a AddressGroup resource.
type AddressGroupArgs struct {
	Description         pulumi.StringPtrInput
	IpAddressBlockLists AddressGroupIpAddressBlockListArrayInput
	Name                pulumi.StringPtrInput
}

func (AddressGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*addressGroupArgs)(nil)).Elem()
}

type AddressGroupInput interface {
	pulumi.Input

	ToAddressGroupOutput() AddressGroupOutput
	ToAddressGroupOutputWithContext(ctx context.Context) AddressGroupOutput
}

func (*AddressGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**AddressGroup)(nil)).Elem()
}

func (i *AddressGroup) ToAddressGroupOutput() AddressGroupOutput {
	return i.ToAddressGroupOutputWithContext(context.Background())
}

func (i *AddressGroup) ToAddressGroupOutputWithContext(ctx context.Context) AddressGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressGroupOutput)
}

// AddressGroupArrayInput is an input type that accepts AddressGroupArray and AddressGroupArrayOutput values.
// You can construct a concrete instance of `AddressGroupArrayInput` via:
//
//          AddressGroupArray{ AddressGroupArgs{...} }
type AddressGroupArrayInput interface {
	pulumi.Input

	ToAddressGroupArrayOutput() AddressGroupArrayOutput
	ToAddressGroupArrayOutputWithContext(context.Context) AddressGroupArrayOutput
}

type AddressGroupArray []AddressGroupInput

func (AddressGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddressGroup)(nil)).Elem()
}

func (i AddressGroupArray) ToAddressGroupArrayOutput() AddressGroupArrayOutput {
	return i.ToAddressGroupArrayOutputWithContext(context.Background())
}

func (i AddressGroupArray) ToAddressGroupArrayOutputWithContext(ctx context.Context) AddressGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressGroupArrayOutput)
}

// AddressGroupMapInput is an input type that accepts AddressGroupMap and AddressGroupMapOutput values.
// You can construct a concrete instance of `AddressGroupMapInput` via:
//
//          AddressGroupMap{ "key": AddressGroupArgs{...} }
type AddressGroupMapInput interface {
	pulumi.Input

	ToAddressGroupMapOutput() AddressGroupMapOutput
	ToAddressGroupMapOutputWithContext(context.Context) AddressGroupMapOutput
}

type AddressGroupMap map[string]AddressGroupInput

func (AddressGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddressGroup)(nil)).Elem()
}

func (i AddressGroupMap) ToAddressGroupMapOutput() AddressGroupMapOutput {
	return i.ToAddressGroupMapOutputWithContext(context.Background())
}

func (i AddressGroupMap) ToAddressGroupMapOutputWithContext(ctx context.Context) AddressGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddressGroupMapOutput)
}

type AddressGroupOutput struct{ *pulumi.OutputState }

func (AddressGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AddressGroup)(nil)).Elem()
}

func (o AddressGroupOutput) ToAddressGroupOutput() AddressGroupOutput {
	return o
}

func (o AddressGroupOutput) ToAddressGroupOutputWithContext(ctx context.Context) AddressGroupOutput {
	return o
}

func (o AddressGroupOutput) AddressGroupString() pulumi.StringOutput {
	return o.ApplyT(func(v *AddressGroup) pulumi.StringOutput { return v.AddressGroupString }).(pulumi.StringOutput)
}

func (o AddressGroupOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AddressGroup) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

func (o AddressGroupOutput) IpAddressBlockLists() AddressGroupIpAddressBlockListArrayOutput {
	return o.ApplyT(func(v *AddressGroup) AddressGroupIpAddressBlockListArrayOutput { return v.IpAddressBlockLists }).(AddressGroupIpAddressBlockListArrayOutput)
}

func (o AddressGroupOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AddressGroup) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type AddressGroupArrayOutput struct{ *pulumi.OutputState }

func (AddressGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddressGroup)(nil)).Elem()
}

func (o AddressGroupArrayOutput) ToAddressGroupArrayOutput() AddressGroupArrayOutput {
	return o
}

func (o AddressGroupArrayOutput) ToAddressGroupArrayOutputWithContext(ctx context.Context) AddressGroupArrayOutput {
	return o
}

func (o AddressGroupArrayOutput) Index(i pulumi.IntInput) AddressGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AddressGroup {
		return vs[0].([]*AddressGroup)[vs[1].(int)]
	}).(AddressGroupOutput)
}

type AddressGroupMapOutput struct{ *pulumi.OutputState }

func (AddressGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddressGroup)(nil)).Elem()
}

func (o AddressGroupMapOutput) ToAddressGroupMapOutput() AddressGroupMapOutput {
	return o
}

func (o AddressGroupMapOutput) ToAddressGroupMapOutputWithContext(ctx context.Context) AddressGroupMapOutput {
	return o
}

func (o AddressGroupMapOutput) MapIndex(k pulumi.StringInput) AddressGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AddressGroup {
		return vs[0].(map[string]*AddressGroup)[vs[1].(string)]
	}).(AddressGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AddressGroupInput)(nil)).Elem(), &AddressGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddressGroupArrayInput)(nil)).Elem(), AddressGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddressGroupMapInput)(nil)).Elem(), AddressGroupMap{})
	pulumi.RegisterOutputType(AddressGroupOutput{})
	pulumi.RegisterOutputType(AddressGroupArrayOutput{})
	pulumi.RegisterOutputType(AddressGroupMapOutput{})
}
