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

// > - The Pc Deploy V2 resource is an action-only resource that supports creating actions. The update and delete operations have no effect. To run it again, destroy and reapply the resource.
// > - We need to increase the timeout for deploying the PC resource because the deployment takes longer than the default timeout allows for the operation to complete.
//
// Deploys a Prism Central using the provided details. Prism Central Size, Network Config are mandatory fields to deploy Prism Central. The response from this endpoint contains the URL in the task object location header that can be used to track the request status.
type PcDeployV2 struct {
	pulumi.CustomResourceState

	// -(Required) Domain manager (Prism Central) cluster configuration details.
	Config PcDeployV2ConfigOutput `pulumi:"config"`
	// -(Required) Domain manager (Prism Central) network configuration details.
	Network PcDeployV2NetworkOutput `pulumi:"network"`
	// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
	ShouldEnableHighAvailability pulumi.BoolPtrOutput `pulumi:"shouldEnableHighAvailability"`
}

// NewPcDeployV2 registers a new resource with the given unique name, arguments, and options.
func NewPcDeployV2(ctx *pulumi.Context,
	name string, args *PcDeployV2Args, opts ...pulumi.ResourceOption) (*PcDeployV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Config == nil {
		return nil, errors.New("invalid value for required argument 'Config'")
	}
	if args.Network == nil {
		return nil, errors.New("invalid value for required argument 'Network'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PcDeployV2
	err := ctx.RegisterResource("nutanix:index/pcDeployV2:PcDeployV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPcDeployV2 gets an existing PcDeployV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPcDeployV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PcDeployV2State, opts ...pulumi.ResourceOption) (*PcDeployV2, error) {
	var resource PcDeployV2
	err := ctx.ReadResource("nutanix:index/pcDeployV2:PcDeployV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PcDeployV2 resources.
type pcDeployV2State struct {
	// -(Required) Domain manager (Prism Central) cluster configuration details.
	Config *PcDeployV2Config `pulumi:"config"`
	// -(Required) Domain manager (Prism Central) network configuration details.
	Network *PcDeployV2Network `pulumi:"network"`
	// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
	ShouldEnableHighAvailability *bool `pulumi:"shouldEnableHighAvailability"`
}

type PcDeployV2State struct {
	// -(Required) Domain manager (Prism Central) cluster configuration details.
	Config PcDeployV2ConfigPtrInput
	// -(Required) Domain manager (Prism Central) network configuration details.
	Network PcDeployV2NetworkPtrInput
	// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
	ShouldEnableHighAvailability pulumi.BoolPtrInput
}

func (PcDeployV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*pcDeployV2State)(nil)).Elem()
}

type pcDeployV2Args struct {
	// -(Required) Domain manager (Prism Central) cluster configuration details.
	Config PcDeployV2Config `pulumi:"config"`
	// -(Required) Domain manager (Prism Central) network configuration details.
	Network PcDeployV2Network `pulumi:"network"`
	// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
	ShouldEnableHighAvailability *bool `pulumi:"shouldEnableHighAvailability"`
}

// The set of arguments for constructing a PcDeployV2 resource.
type PcDeployV2Args struct {
	// -(Required) Domain manager (Prism Central) cluster configuration details.
	Config PcDeployV2ConfigInput
	// -(Required) Domain manager (Prism Central) network configuration details.
	Network PcDeployV2NetworkInput
	// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
	ShouldEnableHighAvailability pulumi.BoolPtrInput
}

func (PcDeployV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*pcDeployV2Args)(nil)).Elem()
}

type PcDeployV2Input interface {
	pulumi.Input

	ToPcDeployV2Output() PcDeployV2Output
	ToPcDeployV2OutputWithContext(ctx context.Context) PcDeployV2Output
}

func (*PcDeployV2) ElementType() reflect.Type {
	return reflect.TypeOf((**PcDeployV2)(nil)).Elem()
}

func (i *PcDeployV2) ToPcDeployV2Output() PcDeployV2Output {
	return i.ToPcDeployV2OutputWithContext(context.Background())
}

func (i *PcDeployV2) ToPcDeployV2OutputWithContext(ctx context.Context) PcDeployV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(PcDeployV2Output)
}

// PcDeployV2ArrayInput is an input type that accepts PcDeployV2Array and PcDeployV2ArrayOutput values.
// You can construct a concrete instance of `PcDeployV2ArrayInput` via:
//
//	PcDeployV2Array{ PcDeployV2Args{...} }
type PcDeployV2ArrayInput interface {
	pulumi.Input

	ToPcDeployV2ArrayOutput() PcDeployV2ArrayOutput
	ToPcDeployV2ArrayOutputWithContext(context.Context) PcDeployV2ArrayOutput
}

type PcDeployV2Array []PcDeployV2Input

func (PcDeployV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PcDeployV2)(nil)).Elem()
}

func (i PcDeployV2Array) ToPcDeployV2ArrayOutput() PcDeployV2ArrayOutput {
	return i.ToPcDeployV2ArrayOutputWithContext(context.Background())
}

func (i PcDeployV2Array) ToPcDeployV2ArrayOutputWithContext(ctx context.Context) PcDeployV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PcDeployV2ArrayOutput)
}

// PcDeployV2MapInput is an input type that accepts PcDeployV2Map and PcDeployV2MapOutput values.
// You can construct a concrete instance of `PcDeployV2MapInput` via:
//
//	PcDeployV2Map{ "key": PcDeployV2Args{...} }
type PcDeployV2MapInput interface {
	pulumi.Input

	ToPcDeployV2MapOutput() PcDeployV2MapOutput
	ToPcDeployV2MapOutputWithContext(context.Context) PcDeployV2MapOutput
}

type PcDeployV2Map map[string]PcDeployV2Input

func (PcDeployV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PcDeployV2)(nil)).Elem()
}

func (i PcDeployV2Map) ToPcDeployV2MapOutput() PcDeployV2MapOutput {
	return i.ToPcDeployV2MapOutputWithContext(context.Background())
}

func (i PcDeployV2Map) ToPcDeployV2MapOutputWithContext(ctx context.Context) PcDeployV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PcDeployV2MapOutput)
}

type PcDeployV2Output struct{ *pulumi.OutputState }

func (PcDeployV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**PcDeployV2)(nil)).Elem()
}

func (o PcDeployV2Output) ToPcDeployV2Output() PcDeployV2Output {
	return o
}

func (o PcDeployV2Output) ToPcDeployV2OutputWithContext(ctx context.Context) PcDeployV2Output {
	return o
}

// -(Required) Domain manager (Prism Central) cluster configuration details.
func (o PcDeployV2Output) Config() PcDeployV2ConfigOutput {
	return o.ApplyT(func(v *PcDeployV2) PcDeployV2ConfigOutput { return v.Config }).(PcDeployV2ConfigOutput)
}

// -(Required) Domain manager (Prism Central) network configuration details.
func (o PcDeployV2Output) Network() PcDeployV2NetworkOutput {
	return o.ApplyT(func(v *PcDeployV2) PcDeployV2NetworkOutput { return v.Network }).(PcDeployV2NetworkOutput)
}

// -(Optional) This configuration enables Prism Central to be deployed in scale-out mode. Default is `false`.
func (o PcDeployV2Output) ShouldEnableHighAvailability() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *PcDeployV2) pulumi.BoolPtrOutput { return v.ShouldEnableHighAvailability }).(pulumi.BoolPtrOutput)
}

type PcDeployV2ArrayOutput struct{ *pulumi.OutputState }

func (PcDeployV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PcDeployV2)(nil)).Elem()
}

func (o PcDeployV2ArrayOutput) ToPcDeployV2ArrayOutput() PcDeployV2ArrayOutput {
	return o
}

func (o PcDeployV2ArrayOutput) ToPcDeployV2ArrayOutputWithContext(ctx context.Context) PcDeployV2ArrayOutput {
	return o
}

func (o PcDeployV2ArrayOutput) Index(i pulumi.IntInput) PcDeployV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PcDeployV2 {
		return vs[0].([]*PcDeployV2)[vs[1].(int)]
	}).(PcDeployV2Output)
}

type PcDeployV2MapOutput struct{ *pulumi.OutputState }

func (PcDeployV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PcDeployV2)(nil)).Elem()
}

func (o PcDeployV2MapOutput) ToPcDeployV2MapOutput() PcDeployV2MapOutput {
	return o
}

func (o PcDeployV2MapOutput) ToPcDeployV2MapOutputWithContext(ctx context.Context) PcDeployV2MapOutput {
	return o
}

func (o PcDeployV2MapOutput) MapIndex(k pulumi.StringInput) PcDeployV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PcDeployV2 {
		return vs[0].(map[string]*PcDeployV2)[vs[1].(string)]
	}).(PcDeployV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PcDeployV2Input)(nil)).Elem(), &PcDeployV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*PcDeployV2ArrayInput)(nil)).Elem(), PcDeployV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*PcDeployV2MapInput)(nil)).Elem(), PcDeployV2Map{})
	pulumi.RegisterOutputType(PcDeployV2Output{})
	pulumi.RegisterOutputType(PcDeployV2ArrayOutput{})
	pulumi.RegisterOutputType(PcDeployV2MapOutput{})
}
