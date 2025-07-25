// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"errors"
	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type VmNetworkDeviceMigrateV2 struct {
	pulumi.CustomResourceState

	ExtId       pulumi.StringOutput                          `pulumi:"extId"`
	IpAddresses VmNetworkDeviceMigrateV2IpAddressArrayOutput `pulumi:"ipAddresses"`
	MigrateType pulumi.StringOutput                          `pulumi:"migrateType"`
	Subnets     VmNetworkDeviceMigrateV2SubnetArrayOutput    `pulumi:"subnets"`
	VmExtId     pulumi.StringOutput                          `pulumi:"vmExtId"`
}

// NewVmNetworkDeviceMigrateV2 registers a new resource with the given unique name, arguments, and options.
func NewVmNetworkDeviceMigrateV2(ctx *pulumi.Context,
	name string, args *VmNetworkDeviceMigrateV2Args, opts ...pulumi.ResourceOption) (*VmNetworkDeviceMigrateV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ExtId == nil {
		return nil, errors.New("invalid value for required argument 'ExtId'")
	}
	if args.MigrateType == nil {
		return nil, errors.New("invalid value for required argument 'MigrateType'")
	}
	if args.Subnets == nil {
		return nil, errors.New("invalid value for required argument 'Subnets'")
	}
	if args.VmExtId == nil {
		return nil, errors.New("invalid value for required argument 'VmExtId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource VmNetworkDeviceMigrateV2
	err := ctx.RegisterResource("nutanix:index/vmNetworkDeviceMigrateV2:VmNetworkDeviceMigrateV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVmNetworkDeviceMigrateV2 gets an existing VmNetworkDeviceMigrateV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVmNetworkDeviceMigrateV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VmNetworkDeviceMigrateV2State, opts ...pulumi.ResourceOption) (*VmNetworkDeviceMigrateV2, error) {
	var resource VmNetworkDeviceMigrateV2
	err := ctx.ReadResource("nutanix:index/vmNetworkDeviceMigrateV2:VmNetworkDeviceMigrateV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VmNetworkDeviceMigrateV2 resources.
type vmNetworkDeviceMigrateV2State struct {
	ExtId       *string                             `pulumi:"extId"`
	IpAddresses []VmNetworkDeviceMigrateV2IpAddress `pulumi:"ipAddresses"`
	MigrateType *string                             `pulumi:"migrateType"`
	Subnets     []VmNetworkDeviceMigrateV2Subnet    `pulumi:"subnets"`
	VmExtId     *string                             `pulumi:"vmExtId"`
}

type VmNetworkDeviceMigrateV2State struct {
	ExtId       pulumi.StringPtrInput
	IpAddresses VmNetworkDeviceMigrateV2IpAddressArrayInput
	MigrateType pulumi.StringPtrInput
	Subnets     VmNetworkDeviceMigrateV2SubnetArrayInput
	VmExtId     pulumi.StringPtrInput
}

func (VmNetworkDeviceMigrateV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*vmNetworkDeviceMigrateV2State)(nil)).Elem()
}

type vmNetworkDeviceMigrateV2Args struct {
	ExtId       string                              `pulumi:"extId"`
	IpAddresses []VmNetworkDeviceMigrateV2IpAddress `pulumi:"ipAddresses"`
	MigrateType string                              `pulumi:"migrateType"`
	Subnets     []VmNetworkDeviceMigrateV2Subnet    `pulumi:"subnets"`
	VmExtId     string                              `pulumi:"vmExtId"`
}

// The set of arguments for constructing a VmNetworkDeviceMigrateV2 resource.
type VmNetworkDeviceMigrateV2Args struct {
	ExtId       pulumi.StringInput
	IpAddresses VmNetworkDeviceMigrateV2IpAddressArrayInput
	MigrateType pulumi.StringInput
	Subnets     VmNetworkDeviceMigrateV2SubnetArrayInput
	VmExtId     pulumi.StringInput
}

func (VmNetworkDeviceMigrateV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*vmNetworkDeviceMigrateV2Args)(nil)).Elem()
}

type VmNetworkDeviceMigrateV2Input interface {
	pulumi.Input

	ToVmNetworkDeviceMigrateV2Output() VmNetworkDeviceMigrateV2Output
	ToVmNetworkDeviceMigrateV2OutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2Output
}

func (*VmNetworkDeviceMigrateV2) ElementType() reflect.Type {
	return reflect.TypeOf((**VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (i *VmNetworkDeviceMigrateV2) ToVmNetworkDeviceMigrateV2Output() VmNetworkDeviceMigrateV2Output {
	return i.ToVmNetworkDeviceMigrateV2OutputWithContext(context.Background())
}

func (i *VmNetworkDeviceMigrateV2) ToVmNetworkDeviceMigrateV2OutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(VmNetworkDeviceMigrateV2Output)
}

// VmNetworkDeviceMigrateV2ArrayInput is an input type that accepts VmNetworkDeviceMigrateV2Array and VmNetworkDeviceMigrateV2ArrayOutput values.
// You can construct a concrete instance of `VmNetworkDeviceMigrateV2ArrayInput` via:
//
//	VmNetworkDeviceMigrateV2Array{ VmNetworkDeviceMigrateV2Args{...} }
type VmNetworkDeviceMigrateV2ArrayInput interface {
	pulumi.Input

	ToVmNetworkDeviceMigrateV2ArrayOutput() VmNetworkDeviceMigrateV2ArrayOutput
	ToVmNetworkDeviceMigrateV2ArrayOutputWithContext(context.Context) VmNetworkDeviceMigrateV2ArrayOutput
}

type VmNetworkDeviceMigrateV2Array []VmNetworkDeviceMigrateV2Input

func (VmNetworkDeviceMigrateV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (i VmNetworkDeviceMigrateV2Array) ToVmNetworkDeviceMigrateV2ArrayOutput() VmNetworkDeviceMigrateV2ArrayOutput {
	return i.ToVmNetworkDeviceMigrateV2ArrayOutputWithContext(context.Background())
}

func (i VmNetworkDeviceMigrateV2Array) ToVmNetworkDeviceMigrateV2ArrayOutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VmNetworkDeviceMigrateV2ArrayOutput)
}

// VmNetworkDeviceMigrateV2MapInput is an input type that accepts VmNetworkDeviceMigrateV2Map and VmNetworkDeviceMigrateV2MapOutput values.
// You can construct a concrete instance of `VmNetworkDeviceMigrateV2MapInput` via:
//
//	VmNetworkDeviceMigrateV2Map{ "key": VmNetworkDeviceMigrateV2Args{...} }
type VmNetworkDeviceMigrateV2MapInput interface {
	pulumi.Input

	ToVmNetworkDeviceMigrateV2MapOutput() VmNetworkDeviceMigrateV2MapOutput
	ToVmNetworkDeviceMigrateV2MapOutputWithContext(context.Context) VmNetworkDeviceMigrateV2MapOutput
}

type VmNetworkDeviceMigrateV2Map map[string]VmNetworkDeviceMigrateV2Input

func (VmNetworkDeviceMigrateV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (i VmNetworkDeviceMigrateV2Map) ToVmNetworkDeviceMigrateV2MapOutput() VmNetworkDeviceMigrateV2MapOutput {
	return i.ToVmNetworkDeviceMigrateV2MapOutputWithContext(context.Background())
}

func (i VmNetworkDeviceMigrateV2Map) ToVmNetworkDeviceMigrateV2MapOutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VmNetworkDeviceMigrateV2MapOutput)
}

type VmNetworkDeviceMigrateV2Output struct{ *pulumi.OutputState }

func (VmNetworkDeviceMigrateV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (o VmNetworkDeviceMigrateV2Output) ToVmNetworkDeviceMigrateV2Output() VmNetworkDeviceMigrateV2Output {
	return o
}

func (o VmNetworkDeviceMigrateV2Output) ToVmNetworkDeviceMigrateV2OutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2Output {
	return o
}

func (o VmNetworkDeviceMigrateV2Output) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *VmNetworkDeviceMigrateV2) pulumi.StringOutput { return v.ExtId }).(pulumi.StringOutput)
}

func (o VmNetworkDeviceMigrateV2Output) IpAddresses() VmNetworkDeviceMigrateV2IpAddressArrayOutput {
	return o.ApplyT(func(v *VmNetworkDeviceMigrateV2) VmNetworkDeviceMigrateV2IpAddressArrayOutput { return v.IpAddresses }).(VmNetworkDeviceMigrateV2IpAddressArrayOutput)
}

func (o VmNetworkDeviceMigrateV2Output) MigrateType() pulumi.StringOutput {
	return o.ApplyT(func(v *VmNetworkDeviceMigrateV2) pulumi.StringOutput { return v.MigrateType }).(pulumi.StringOutput)
}

func (o VmNetworkDeviceMigrateV2Output) Subnets() VmNetworkDeviceMigrateV2SubnetArrayOutput {
	return o.ApplyT(func(v *VmNetworkDeviceMigrateV2) VmNetworkDeviceMigrateV2SubnetArrayOutput { return v.Subnets }).(VmNetworkDeviceMigrateV2SubnetArrayOutput)
}

func (o VmNetworkDeviceMigrateV2Output) VmExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *VmNetworkDeviceMigrateV2) pulumi.StringOutput { return v.VmExtId }).(pulumi.StringOutput)
}

type VmNetworkDeviceMigrateV2ArrayOutput struct{ *pulumi.OutputState }

func (VmNetworkDeviceMigrateV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (o VmNetworkDeviceMigrateV2ArrayOutput) ToVmNetworkDeviceMigrateV2ArrayOutput() VmNetworkDeviceMigrateV2ArrayOutput {
	return o
}

func (o VmNetworkDeviceMigrateV2ArrayOutput) ToVmNetworkDeviceMigrateV2ArrayOutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2ArrayOutput {
	return o
}

func (o VmNetworkDeviceMigrateV2ArrayOutput) Index(i pulumi.IntInput) VmNetworkDeviceMigrateV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *VmNetworkDeviceMigrateV2 {
		return vs[0].([]*VmNetworkDeviceMigrateV2)[vs[1].(int)]
	}).(VmNetworkDeviceMigrateV2Output)
}

type VmNetworkDeviceMigrateV2MapOutput struct{ *pulumi.OutputState }

func (VmNetworkDeviceMigrateV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VmNetworkDeviceMigrateV2)(nil)).Elem()
}

func (o VmNetworkDeviceMigrateV2MapOutput) ToVmNetworkDeviceMigrateV2MapOutput() VmNetworkDeviceMigrateV2MapOutput {
	return o
}

func (o VmNetworkDeviceMigrateV2MapOutput) ToVmNetworkDeviceMigrateV2MapOutputWithContext(ctx context.Context) VmNetworkDeviceMigrateV2MapOutput {
	return o
}

func (o VmNetworkDeviceMigrateV2MapOutput) MapIndex(k pulumi.StringInput) VmNetworkDeviceMigrateV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *VmNetworkDeviceMigrateV2 {
		return vs[0].(map[string]*VmNetworkDeviceMigrateV2)[vs[1].(string)]
	}).(VmNetworkDeviceMigrateV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VmNetworkDeviceMigrateV2Input)(nil)).Elem(), &VmNetworkDeviceMigrateV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*VmNetworkDeviceMigrateV2ArrayInput)(nil)).Elem(), VmNetworkDeviceMigrateV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*VmNetworkDeviceMigrateV2MapInput)(nil)).Elem(), VmNetworkDeviceMigrateV2Map{})
	pulumi.RegisterOutputType(VmNetworkDeviceMigrateV2Output{})
	pulumi.RegisterOutputType(VmNetworkDeviceMigrateV2ArrayOutput{})
	pulumi.RegisterOutputType(VmNetworkDeviceMigrateV2MapOutput{})
}
