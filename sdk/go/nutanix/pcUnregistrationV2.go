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

// Unregister a registered remote cluster from the local cluster. This process is asynchronous, creating an un-registration task and returning its UUID.
type PcUnregistrationV2 struct {
	pulumi.CustomResourceState

	// -(Required) Cluster UUID of a remote cluster.
	//
	// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
	ExtId pulumi.StringOutput `pulumi:"extId"`
	// -(Required) The external identifier of the domain manager (Prism Central) resource
	PcExtId pulumi.StringOutput `pulumi:"pcExtId"`
}

// NewPcUnregistrationV2 registers a new resource with the given unique name, arguments, and options.
func NewPcUnregistrationV2(ctx *pulumi.Context,
	name string, args *PcUnregistrationV2Args, opts ...pulumi.ResourceOption) (*PcUnregistrationV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ExtId == nil {
		return nil, errors.New("invalid value for required argument 'ExtId'")
	}
	if args.PcExtId == nil {
		return nil, errors.New("invalid value for required argument 'PcExtId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PcUnregistrationV2
	err := ctx.RegisterResource("nutanix:index/pcUnregistrationV2:PcUnregistrationV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPcUnregistrationV2 gets an existing PcUnregistrationV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPcUnregistrationV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PcUnregistrationV2State, opts ...pulumi.ResourceOption) (*PcUnregistrationV2, error) {
	var resource PcUnregistrationV2
	err := ctx.ReadResource("nutanix:index/pcUnregistrationV2:PcUnregistrationV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PcUnregistrationV2 resources.
type pcUnregistrationV2State struct {
	// -(Required) Cluster UUID of a remote cluster.
	//
	// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
	ExtId *string `pulumi:"extId"`
	// -(Required) The external identifier of the domain manager (Prism Central) resource
	PcExtId *string `pulumi:"pcExtId"`
}

type PcUnregistrationV2State struct {
	// -(Required) Cluster UUID of a remote cluster.
	//
	// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
	ExtId pulumi.StringPtrInput
	// -(Required) The external identifier of the domain manager (Prism Central) resource
	PcExtId pulumi.StringPtrInput
}

func (PcUnregistrationV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*pcUnregistrationV2State)(nil)).Elem()
}

type pcUnregistrationV2Args struct {
	// -(Required) Cluster UUID of a remote cluster.
	//
	// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
	ExtId string `pulumi:"extId"`
	// -(Required) The external identifier of the domain manager (Prism Central) resource
	PcExtId string `pulumi:"pcExtId"`
}

// The set of arguments for constructing a PcUnregistrationV2 resource.
type PcUnregistrationV2Args struct {
	// -(Required) Cluster UUID of a remote cluster.
	//
	// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
	ExtId pulumi.StringInput
	// -(Required) The external identifier of the domain manager (Prism Central) resource
	PcExtId pulumi.StringInput
}

func (PcUnregistrationV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*pcUnregistrationV2Args)(nil)).Elem()
}

type PcUnregistrationV2Input interface {
	pulumi.Input

	ToPcUnregistrationV2Output() PcUnregistrationV2Output
	ToPcUnregistrationV2OutputWithContext(ctx context.Context) PcUnregistrationV2Output
}

func (*PcUnregistrationV2) ElementType() reflect.Type {
	return reflect.TypeOf((**PcUnregistrationV2)(nil)).Elem()
}

func (i *PcUnregistrationV2) ToPcUnregistrationV2Output() PcUnregistrationV2Output {
	return i.ToPcUnregistrationV2OutputWithContext(context.Background())
}

func (i *PcUnregistrationV2) ToPcUnregistrationV2OutputWithContext(ctx context.Context) PcUnregistrationV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(PcUnregistrationV2Output)
}

// PcUnregistrationV2ArrayInput is an input type that accepts PcUnregistrationV2Array and PcUnregistrationV2ArrayOutput values.
// You can construct a concrete instance of `PcUnregistrationV2ArrayInput` via:
//
//	PcUnregistrationV2Array{ PcUnregistrationV2Args{...} }
type PcUnregistrationV2ArrayInput interface {
	pulumi.Input

	ToPcUnregistrationV2ArrayOutput() PcUnregistrationV2ArrayOutput
	ToPcUnregistrationV2ArrayOutputWithContext(context.Context) PcUnregistrationV2ArrayOutput
}

type PcUnregistrationV2Array []PcUnregistrationV2Input

func (PcUnregistrationV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PcUnregistrationV2)(nil)).Elem()
}

func (i PcUnregistrationV2Array) ToPcUnregistrationV2ArrayOutput() PcUnregistrationV2ArrayOutput {
	return i.ToPcUnregistrationV2ArrayOutputWithContext(context.Background())
}

func (i PcUnregistrationV2Array) ToPcUnregistrationV2ArrayOutputWithContext(ctx context.Context) PcUnregistrationV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PcUnregistrationV2ArrayOutput)
}

// PcUnregistrationV2MapInput is an input type that accepts PcUnregistrationV2Map and PcUnregistrationV2MapOutput values.
// You can construct a concrete instance of `PcUnregistrationV2MapInput` via:
//
//	PcUnregistrationV2Map{ "key": PcUnregistrationV2Args{...} }
type PcUnregistrationV2MapInput interface {
	pulumi.Input

	ToPcUnregistrationV2MapOutput() PcUnregistrationV2MapOutput
	ToPcUnregistrationV2MapOutputWithContext(context.Context) PcUnregistrationV2MapOutput
}

type PcUnregistrationV2Map map[string]PcUnregistrationV2Input

func (PcUnregistrationV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PcUnregistrationV2)(nil)).Elem()
}

func (i PcUnregistrationV2Map) ToPcUnregistrationV2MapOutput() PcUnregistrationV2MapOutput {
	return i.ToPcUnregistrationV2MapOutputWithContext(context.Background())
}

func (i PcUnregistrationV2Map) ToPcUnregistrationV2MapOutputWithContext(ctx context.Context) PcUnregistrationV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PcUnregistrationV2MapOutput)
}

type PcUnregistrationV2Output struct{ *pulumi.OutputState }

func (PcUnregistrationV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**PcUnregistrationV2)(nil)).Elem()
}

func (o PcUnregistrationV2Output) ToPcUnregistrationV2Output() PcUnregistrationV2Output {
	return o
}

func (o PcUnregistrationV2Output) ToPcUnregistrationV2OutputWithContext(ctx context.Context) PcUnregistrationV2Output {
	return o
}

// -(Required) Cluster UUID of a remote cluster.
//
// See detailed information in [Nutanix PC Unregistration V4](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/unregister).
func (o PcUnregistrationV2Output) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *PcUnregistrationV2) pulumi.StringOutput { return v.ExtId }).(pulumi.StringOutput)
}

// -(Required) The external identifier of the domain manager (Prism Central) resource
func (o PcUnregistrationV2Output) PcExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *PcUnregistrationV2) pulumi.StringOutput { return v.PcExtId }).(pulumi.StringOutput)
}

type PcUnregistrationV2ArrayOutput struct{ *pulumi.OutputState }

func (PcUnregistrationV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PcUnregistrationV2)(nil)).Elem()
}

func (o PcUnregistrationV2ArrayOutput) ToPcUnregistrationV2ArrayOutput() PcUnregistrationV2ArrayOutput {
	return o
}

func (o PcUnregistrationV2ArrayOutput) ToPcUnregistrationV2ArrayOutputWithContext(ctx context.Context) PcUnregistrationV2ArrayOutput {
	return o
}

func (o PcUnregistrationV2ArrayOutput) Index(i pulumi.IntInput) PcUnregistrationV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PcUnregistrationV2 {
		return vs[0].([]*PcUnregistrationV2)[vs[1].(int)]
	}).(PcUnregistrationV2Output)
}

type PcUnregistrationV2MapOutput struct{ *pulumi.OutputState }

func (PcUnregistrationV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PcUnregistrationV2)(nil)).Elem()
}

func (o PcUnregistrationV2MapOutput) ToPcUnregistrationV2MapOutput() PcUnregistrationV2MapOutput {
	return o
}

func (o PcUnregistrationV2MapOutput) ToPcUnregistrationV2MapOutputWithContext(ctx context.Context) PcUnregistrationV2MapOutput {
	return o
}

func (o PcUnregistrationV2MapOutput) MapIndex(k pulumi.StringInput) PcUnregistrationV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PcUnregistrationV2 {
		return vs[0].(map[string]*PcUnregistrationV2)[vs[1].(string)]
	}).(PcUnregistrationV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PcUnregistrationV2Input)(nil)).Elem(), &PcUnregistrationV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*PcUnregistrationV2ArrayInput)(nil)).Elem(), PcUnregistrationV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*PcUnregistrationV2MapInput)(nil)).Elem(), PcUnregistrationV2Map{})
	pulumi.RegisterOutputType(PcUnregistrationV2Output{})
	pulumi.RegisterOutputType(PcUnregistrationV2ArrayOutput{})
	pulumi.RegisterOutputType(PcUnregistrationV2MapOutput{})
}
