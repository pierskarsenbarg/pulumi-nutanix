// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a Nutanix Karbon Registry resource to Create a private registry entry in Karbon.
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
// 		_, err := nutanix.LookupKarbonPrivateRegistry(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		_, err = nutanix.NewKarbonPrivateRegistry(ctx, "registry", nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type KarbonPrivateRegistry struct {
	pulumi.CustomResourceState

	Cert     pulumi.StringPtrOutput `pulumi:"cert"`
	Endpoint pulumi.StringOutput    `pulumi:"endpoint"`
	Name     pulumi.StringOutput    `pulumi:"name"`
	Password pulumi.StringPtrOutput `pulumi:"password"`
	Port     pulumi.IntOutput       `pulumi:"port"`
	Url      pulumi.StringOutput    `pulumi:"url"`
	Username pulumi.StringPtrOutput `pulumi:"username"`
}

// NewKarbonPrivateRegistry registers a new resource with the given unique name, arguments, and options.
func NewKarbonPrivateRegistry(ctx *pulumi.Context,
	name string, args *KarbonPrivateRegistryArgs, opts ...pulumi.ResourceOption) (*KarbonPrivateRegistry, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Port == nil {
		return nil, errors.New("invalid value for required argument 'Port'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource KarbonPrivateRegistry
	err := ctx.RegisterResource("nutanix:index/karbonPrivateRegistry:KarbonPrivateRegistry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetKarbonPrivateRegistry gets an existing KarbonPrivateRegistry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKarbonPrivateRegistry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *KarbonPrivateRegistryState, opts ...pulumi.ResourceOption) (*KarbonPrivateRegistry, error) {
	var resource KarbonPrivateRegistry
	err := ctx.ReadResource("nutanix:index/karbonPrivateRegistry:KarbonPrivateRegistry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering KarbonPrivateRegistry resources.
type karbonPrivateRegistryState struct {
	Cert     *string `pulumi:"cert"`
	Endpoint *string `pulumi:"endpoint"`
	Name     *string `pulumi:"name"`
	Password *string `pulumi:"password"`
	Port     *int    `pulumi:"port"`
	Url      *string `pulumi:"url"`
	Username *string `pulumi:"username"`
}

type KarbonPrivateRegistryState struct {
	Cert     pulumi.StringPtrInput
	Endpoint pulumi.StringPtrInput
	Name     pulumi.StringPtrInput
	Password pulumi.StringPtrInput
	Port     pulumi.IntPtrInput
	Url      pulumi.StringPtrInput
	Username pulumi.StringPtrInput
}

func (KarbonPrivateRegistryState) ElementType() reflect.Type {
	return reflect.TypeOf((*karbonPrivateRegistryState)(nil)).Elem()
}

type karbonPrivateRegistryArgs struct {
	Cert     *string `pulumi:"cert"`
	Name     *string `pulumi:"name"`
	Password *string `pulumi:"password"`
	Port     int     `pulumi:"port"`
	Url      string  `pulumi:"url"`
	Username *string `pulumi:"username"`
}

// The set of arguments for constructing a KarbonPrivateRegistry resource.
type KarbonPrivateRegistryArgs struct {
	Cert     pulumi.StringPtrInput
	Name     pulumi.StringPtrInput
	Password pulumi.StringPtrInput
	Port     pulumi.IntInput
	Url      pulumi.StringInput
	Username pulumi.StringPtrInput
}

func (KarbonPrivateRegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*karbonPrivateRegistryArgs)(nil)).Elem()
}

type KarbonPrivateRegistryInput interface {
	pulumi.Input

	ToKarbonPrivateRegistryOutput() KarbonPrivateRegistryOutput
	ToKarbonPrivateRegistryOutputWithContext(ctx context.Context) KarbonPrivateRegistryOutput
}

func (*KarbonPrivateRegistry) ElementType() reflect.Type {
	return reflect.TypeOf((**KarbonPrivateRegistry)(nil)).Elem()
}

func (i *KarbonPrivateRegistry) ToKarbonPrivateRegistryOutput() KarbonPrivateRegistryOutput {
	return i.ToKarbonPrivateRegistryOutputWithContext(context.Background())
}

func (i *KarbonPrivateRegistry) ToKarbonPrivateRegistryOutputWithContext(ctx context.Context) KarbonPrivateRegistryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KarbonPrivateRegistryOutput)
}

// KarbonPrivateRegistryArrayInput is an input type that accepts KarbonPrivateRegistryArray and KarbonPrivateRegistryArrayOutput values.
// You can construct a concrete instance of `KarbonPrivateRegistryArrayInput` via:
//
//          KarbonPrivateRegistryArray{ KarbonPrivateRegistryArgs{...} }
type KarbonPrivateRegistryArrayInput interface {
	pulumi.Input

	ToKarbonPrivateRegistryArrayOutput() KarbonPrivateRegistryArrayOutput
	ToKarbonPrivateRegistryArrayOutputWithContext(context.Context) KarbonPrivateRegistryArrayOutput
}

type KarbonPrivateRegistryArray []KarbonPrivateRegistryInput

func (KarbonPrivateRegistryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*KarbonPrivateRegistry)(nil)).Elem()
}

func (i KarbonPrivateRegistryArray) ToKarbonPrivateRegistryArrayOutput() KarbonPrivateRegistryArrayOutput {
	return i.ToKarbonPrivateRegistryArrayOutputWithContext(context.Background())
}

func (i KarbonPrivateRegistryArray) ToKarbonPrivateRegistryArrayOutputWithContext(ctx context.Context) KarbonPrivateRegistryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KarbonPrivateRegistryArrayOutput)
}

// KarbonPrivateRegistryMapInput is an input type that accepts KarbonPrivateRegistryMap and KarbonPrivateRegistryMapOutput values.
// You can construct a concrete instance of `KarbonPrivateRegistryMapInput` via:
//
//          KarbonPrivateRegistryMap{ "key": KarbonPrivateRegistryArgs{...} }
type KarbonPrivateRegistryMapInput interface {
	pulumi.Input

	ToKarbonPrivateRegistryMapOutput() KarbonPrivateRegistryMapOutput
	ToKarbonPrivateRegistryMapOutputWithContext(context.Context) KarbonPrivateRegistryMapOutput
}

type KarbonPrivateRegistryMap map[string]KarbonPrivateRegistryInput

func (KarbonPrivateRegistryMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*KarbonPrivateRegistry)(nil)).Elem()
}

func (i KarbonPrivateRegistryMap) ToKarbonPrivateRegistryMapOutput() KarbonPrivateRegistryMapOutput {
	return i.ToKarbonPrivateRegistryMapOutputWithContext(context.Background())
}

func (i KarbonPrivateRegistryMap) ToKarbonPrivateRegistryMapOutputWithContext(ctx context.Context) KarbonPrivateRegistryMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(KarbonPrivateRegistryMapOutput)
}

type KarbonPrivateRegistryOutput struct{ *pulumi.OutputState }

func (KarbonPrivateRegistryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**KarbonPrivateRegistry)(nil)).Elem()
}

func (o KarbonPrivateRegistryOutput) ToKarbonPrivateRegistryOutput() KarbonPrivateRegistryOutput {
	return o
}

func (o KarbonPrivateRegistryOutput) ToKarbonPrivateRegistryOutputWithContext(ctx context.Context) KarbonPrivateRegistryOutput {
	return o
}

func (o KarbonPrivateRegistryOutput) Cert() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringPtrOutput { return v.Cert }).(pulumi.StringPtrOutput)
}

func (o KarbonPrivateRegistryOutput) Endpoint() pulumi.StringOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringOutput { return v.Endpoint }).(pulumi.StringOutput)
}

func (o KarbonPrivateRegistryOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o KarbonPrivateRegistryOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringPtrOutput { return v.Password }).(pulumi.StringPtrOutput)
}

func (o KarbonPrivateRegistryOutput) Port() pulumi.IntOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.IntOutput { return v.Port }).(pulumi.IntOutput)
}

func (o KarbonPrivateRegistryOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

func (o KarbonPrivateRegistryOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *KarbonPrivateRegistry) pulumi.StringPtrOutput { return v.Username }).(pulumi.StringPtrOutput)
}

type KarbonPrivateRegistryArrayOutput struct{ *pulumi.OutputState }

func (KarbonPrivateRegistryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*KarbonPrivateRegistry)(nil)).Elem()
}

func (o KarbonPrivateRegistryArrayOutput) ToKarbonPrivateRegistryArrayOutput() KarbonPrivateRegistryArrayOutput {
	return o
}

func (o KarbonPrivateRegistryArrayOutput) ToKarbonPrivateRegistryArrayOutputWithContext(ctx context.Context) KarbonPrivateRegistryArrayOutput {
	return o
}

func (o KarbonPrivateRegistryArrayOutput) Index(i pulumi.IntInput) KarbonPrivateRegistryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *KarbonPrivateRegistry {
		return vs[0].([]*KarbonPrivateRegistry)[vs[1].(int)]
	}).(KarbonPrivateRegistryOutput)
}

type KarbonPrivateRegistryMapOutput struct{ *pulumi.OutputState }

func (KarbonPrivateRegistryMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*KarbonPrivateRegistry)(nil)).Elem()
}

func (o KarbonPrivateRegistryMapOutput) ToKarbonPrivateRegistryMapOutput() KarbonPrivateRegistryMapOutput {
	return o
}

func (o KarbonPrivateRegistryMapOutput) ToKarbonPrivateRegistryMapOutputWithContext(ctx context.Context) KarbonPrivateRegistryMapOutput {
	return o
}

func (o KarbonPrivateRegistryMapOutput) MapIndex(k pulumi.StringInput) KarbonPrivateRegistryOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *KarbonPrivateRegistry {
		return vs[0].(map[string]*KarbonPrivateRegistry)[vs[1].(string)]
	}).(KarbonPrivateRegistryOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*KarbonPrivateRegistryInput)(nil)).Elem(), &KarbonPrivateRegistry{})
	pulumi.RegisterInputType(reflect.TypeOf((*KarbonPrivateRegistryArrayInput)(nil)).Elem(), KarbonPrivateRegistryArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*KarbonPrivateRegistryMapInput)(nil)).Elem(), KarbonPrivateRegistryMap{})
	pulumi.RegisterOutputType(KarbonPrivateRegistryOutput{})
	pulumi.RegisterOutputType(KarbonPrivateRegistryArrayOutput{})
	pulumi.RegisterOutputType(KarbonPrivateRegistryMapOutput{})
}