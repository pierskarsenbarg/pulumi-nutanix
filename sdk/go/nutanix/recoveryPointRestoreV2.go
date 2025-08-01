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

// This operation Restore a recovery point identified by {extId}.
// A comma separated list of the created VM and volume group external identifiers can be found in the task completion details under the keys `vmExtIds` and `volumeGroupExtIds` respectively.
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
//			// restore RP
//			_, err := nutanix.NewRecoveryPointRestoreV2(ctx, "rp-restore", &nutanix.RecoveryPointRestoreV2Args{
//				ClusterExtId: pulumi.String("1cefd0f5-6d38-4c9b-a07c-bdd2db004224"),
//				ExtId:        pulumi.String("150a7ed0-9d05-4f35-a060-16dac4c835d0"),
//				VmRecoveryPointRestoreOverrides: nutanix.RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArray{
//					&nutanix.RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArgs{
//						VmRecoveryPointExtId: pulumi.String("1cefd0f5-6d38-4c9b-a07c-bdd2db004224"),
//					},
//				},
//				VolumeGroupRecoveryPointRestoreOverrides: nutanix.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArray{
//					&nutanix.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArgs{
//						VolumeGroupOverrideSpecs: nutanix.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideVolumeGroupOverrideSpecArray{
//							&nutanix.RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideVolumeGroupOverrideSpecArgs{
//								Name: pulumi.String("vg_restored"),
//							},
//						},
//						VolumeGroupRecoveryPointExtId: pulumi.String("8a938cc5-282b-48c4-81be-de22de145d07"),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type RecoveryPointRestoreV2 struct {
	pulumi.CustomResourceState

	// -(Required) External identifier of the cluster.
	ClusterExtId pulumi.StringOutput `pulumi:"clusterExtId"`
	// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
	ExtId pulumi.StringOutput `pulumi:"extId"`
	// - List of external identifiers of the created(restored) VMs.
	VmExtIds pulumi.StringArrayOutput `pulumi:"vmExtIds"`
	// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VmRecoveryPointRestoreOverrides RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayOutput `pulumi:"vmRecoveryPointRestoreOverrides"`
	// - List of external identifiers of the created(restored) volume groups.
	VolumeGroupExtIds pulumi.StringArrayOutput `pulumi:"volumeGroupExtIds"`
	// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VolumeGroupRecoveryPointRestoreOverrides RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayOutput `pulumi:"volumeGroupRecoveryPointRestoreOverrides"`
}

// NewRecoveryPointRestoreV2 registers a new resource with the given unique name, arguments, and options.
func NewRecoveryPointRestoreV2(ctx *pulumi.Context,
	name string, args *RecoveryPointRestoreV2Args, opts ...pulumi.ResourceOption) (*RecoveryPointRestoreV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterExtId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterExtId'")
	}
	if args.ExtId == nil {
		return nil, errors.New("invalid value for required argument 'ExtId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RecoveryPointRestoreV2
	err := ctx.RegisterResource("nutanix:index/recoveryPointRestoreV2:RecoveryPointRestoreV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRecoveryPointRestoreV2 gets an existing RecoveryPointRestoreV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRecoveryPointRestoreV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RecoveryPointRestoreV2State, opts ...pulumi.ResourceOption) (*RecoveryPointRestoreV2, error) {
	var resource RecoveryPointRestoreV2
	err := ctx.ReadResource("nutanix:index/recoveryPointRestoreV2:RecoveryPointRestoreV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RecoveryPointRestoreV2 resources.
type recoveryPointRestoreV2State struct {
	// -(Required) External identifier of the cluster.
	ClusterExtId *string `pulumi:"clusterExtId"`
	// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
	ExtId *string `pulumi:"extId"`
	// - List of external identifiers of the created(restored) VMs.
	VmExtIds []string `pulumi:"vmExtIds"`
	// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VmRecoveryPointRestoreOverrides []RecoveryPointRestoreV2VmRecoveryPointRestoreOverride `pulumi:"vmRecoveryPointRestoreOverrides"`
	// - List of external identifiers of the created(restored) volume groups.
	VolumeGroupExtIds []string `pulumi:"volumeGroupExtIds"`
	// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VolumeGroupRecoveryPointRestoreOverrides []RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverride `pulumi:"volumeGroupRecoveryPointRestoreOverrides"`
}

type RecoveryPointRestoreV2State struct {
	// -(Required) External identifier of the cluster.
	ClusterExtId pulumi.StringPtrInput
	// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
	ExtId pulumi.StringPtrInput
	// - List of external identifiers of the created(restored) VMs.
	VmExtIds pulumi.StringArrayInput
	// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VmRecoveryPointRestoreOverrides RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayInput
	// - List of external identifiers of the created(restored) volume groups.
	VolumeGroupExtIds pulumi.StringArrayInput
	// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VolumeGroupRecoveryPointRestoreOverrides RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayInput
}

func (RecoveryPointRestoreV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*recoveryPointRestoreV2State)(nil)).Elem()
}

type recoveryPointRestoreV2Args struct {
	// -(Required) External identifier of the cluster.
	ClusterExtId string `pulumi:"clusterExtId"`
	// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
	ExtId string `pulumi:"extId"`
	// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VmRecoveryPointRestoreOverrides []RecoveryPointRestoreV2VmRecoveryPointRestoreOverride `pulumi:"vmRecoveryPointRestoreOverrides"`
	// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VolumeGroupRecoveryPointRestoreOverrides []RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverride `pulumi:"volumeGroupRecoveryPointRestoreOverrides"`
}

// The set of arguments for constructing a RecoveryPointRestoreV2 resource.
type RecoveryPointRestoreV2Args struct {
	// -(Required) External identifier of the cluster.
	ClusterExtId pulumi.StringInput
	// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
	ExtId pulumi.StringInput
	// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VmRecoveryPointRestoreOverrides RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayInput
	// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
	VolumeGroupRecoveryPointRestoreOverrides RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayInput
}

func (RecoveryPointRestoreV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*recoveryPointRestoreV2Args)(nil)).Elem()
}

type RecoveryPointRestoreV2Input interface {
	pulumi.Input

	ToRecoveryPointRestoreV2Output() RecoveryPointRestoreV2Output
	ToRecoveryPointRestoreV2OutputWithContext(ctx context.Context) RecoveryPointRestoreV2Output
}

func (*RecoveryPointRestoreV2) ElementType() reflect.Type {
	return reflect.TypeOf((**RecoveryPointRestoreV2)(nil)).Elem()
}

func (i *RecoveryPointRestoreV2) ToRecoveryPointRestoreV2Output() RecoveryPointRestoreV2Output {
	return i.ToRecoveryPointRestoreV2OutputWithContext(context.Background())
}

func (i *RecoveryPointRestoreV2) ToRecoveryPointRestoreV2OutputWithContext(ctx context.Context) RecoveryPointRestoreV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(RecoveryPointRestoreV2Output)
}

// RecoveryPointRestoreV2ArrayInput is an input type that accepts RecoveryPointRestoreV2Array and RecoveryPointRestoreV2ArrayOutput values.
// You can construct a concrete instance of `RecoveryPointRestoreV2ArrayInput` via:
//
//	RecoveryPointRestoreV2Array{ RecoveryPointRestoreV2Args{...} }
type RecoveryPointRestoreV2ArrayInput interface {
	pulumi.Input

	ToRecoveryPointRestoreV2ArrayOutput() RecoveryPointRestoreV2ArrayOutput
	ToRecoveryPointRestoreV2ArrayOutputWithContext(context.Context) RecoveryPointRestoreV2ArrayOutput
}

type RecoveryPointRestoreV2Array []RecoveryPointRestoreV2Input

func (RecoveryPointRestoreV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RecoveryPointRestoreV2)(nil)).Elem()
}

func (i RecoveryPointRestoreV2Array) ToRecoveryPointRestoreV2ArrayOutput() RecoveryPointRestoreV2ArrayOutput {
	return i.ToRecoveryPointRestoreV2ArrayOutputWithContext(context.Background())
}

func (i RecoveryPointRestoreV2Array) ToRecoveryPointRestoreV2ArrayOutputWithContext(ctx context.Context) RecoveryPointRestoreV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecoveryPointRestoreV2ArrayOutput)
}

// RecoveryPointRestoreV2MapInput is an input type that accepts RecoveryPointRestoreV2Map and RecoveryPointRestoreV2MapOutput values.
// You can construct a concrete instance of `RecoveryPointRestoreV2MapInput` via:
//
//	RecoveryPointRestoreV2Map{ "key": RecoveryPointRestoreV2Args{...} }
type RecoveryPointRestoreV2MapInput interface {
	pulumi.Input

	ToRecoveryPointRestoreV2MapOutput() RecoveryPointRestoreV2MapOutput
	ToRecoveryPointRestoreV2MapOutputWithContext(context.Context) RecoveryPointRestoreV2MapOutput
}

type RecoveryPointRestoreV2Map map[string]RecoveryPointRestoreV2Input

func (RecoveryPointRestoreV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RecoveryPointRestoreV2)(nil)).Elem()
}

func (i RecoveryPointRestoreV2Map) ToRecoveryPointRestoreV2MapOutput() RecoveryPointRestoreV2MapOutput {
	return i.ToRecoveryPointRestoreV2MapOutputWithContext(context.Background())
}

func (i RecoveryPointRestoreV2Map) ToRecoveryPointRestoreV2MapOutputWithContext(ctx context.Context) RecoveryPointRestoreV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecoveryPointRestoreV2MapOutput)
}

type RecoveryPointRestoreV2Output struct{ *pulumi.OutputState }

func (RecoveryPointRestoreV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**RecoveryPointRestoreV2)(nil)).Elem()
}

func (o RecoveryPointRestoreV2Output) ToRecoveryPointRestoreV2Output() RecoveryPointRestoreV2Output {
	return o
}

func (o RecoveryPointRestoreV2Output) ToRecoveryPointRestoreV2OutputWithContext(ctx context.Context) RecoveryPointRestoreV2Output {
	return o
}

// -(Required) External identifier of the cluster.
func (o RecoveryPointRestoreV2Output) ClusterExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) pulumi.StringOutput { return v.ClusterExtId }).(pulumi.StringOutput)
}

// -(Required) The external identifier that can be used to retrieve the recovery point using its URL.
func (o RecoveryPointRestoreV2Output) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) pulumi.StringOutput { return v.ExtId }).(pulumi.StringOutput)
}

// - List of external identifiers of the created(restored) VMs.
func (o RecoveryPointRestoreV2Output) VmExtIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) pulumi.StringArrayOutput { return v.VmExtIds }).(pulumi.StringArrayOutput)
}

// -(Optional) List of specifications to restore a specific VM recovery point(s) that are a part of the top-level recovery point. A specific VM recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
func (o RecoveryPointRestoreV2Output) VmRecoveryPointRestoreOverrides() RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayOutput {
		return v.VmRecoveryPointRestoreOverrides
	}).(RecoveryPointRestoreV2VmRecoveryPointRestoreOverrideArrayOutput)
}

// - List of external identifiers of the created(restored) volume groups.
func (o RecoveryPointRestoreV2Output) VolumeGroupExtIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) pulumi.StringArrayOutput { return v.VolumeGroupExtIds }).(pulumi.StringArrayOutput)
}

// -(Optional) List of specifications to restore a specific volume group recovery point(s) that are a part of the top-level recovery point. A specific volume group recovery point can be selected for restore by specifying its external identifier along with override specification (if any).
func (o RecoveryPointRestoreV2Output) VolumeGroupRecoveryPointRestoreOverrides() RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayOutput {
	return o.ApplyT(func(v *RecoveryPointRestoreV2) RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayOutput {
		return v.VolumeGroupRecoveryPointRestoreOverrides
	}).(RecoveryPointRestoreV2VolumeGroupRecoveryPointRestoreOverrideArrayOutput)
}

type RecoveryPointRestoreV2ArrayOutput struct{ *pulumi.OutputState }

func (RecoveryPointRestoreV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RecoveryPointRestoreV2)(nil)).Elem()
}

func (o RecoveryPointRestoreV2ArrayOutput) ToRecoveryPointRestoreV2ArrayOutput() RecoveryPointRestoreV2ArrayOutput {
	return o
}

func (o RecoveryPointRestoreV2ArrayOutput) ToRecoveryPointRestoreV2ArrayOutputWithContext(ctx context.Context) RecoveryPointRestoreV2ArrayOutput {
	return o
}

func (o RecoveryPointRestoreV2ArrayOutput) Index(i pulumi.IntInput) RecoveryPointRestoreV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RecoveryPointRestoreV2 {
		return vs[0].([]*RecoveryPointRestoreV2)[vs[1].(int)]
	}).(RecoveryPointRestoreV2Output)
}

type RecoveryPointRestoreV2MapOutput struct{ *pulumi.OutputState }

func (RecoveryPointRestoreV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RecoveryPointRestoreV2)(nil)).Elem()
}

func (o RecoveryPointRestoreV2MapOutput) ToRecoveryPointRestoreV2MapOutput() RecoveryPointRestoreV2MapOutput {
	return o
}

func (o RecoveryPointRestoreV2MapOutput) ToRecoveryPointRestoreV2MapOutputWithContext(ctx context.Context) RecoveryPointRestoreV2MapOutput {
	return o
}

func (o RecoveryPointRestoreV2MapOutput) MapIndex(k pulumi.StringInput) RecoveryPointRestoreV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RecoveryPointRestoreV2 {
		return vs[0].(map[string]*RecoveryPointRestoreV2)[vs[1].(string)]
	}).(RecoveryPointRestoreV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RecoveryPointRestoreV2Input)(nil)).Elem(), &RecoveryPointRestoreV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*RecoveryPointRestoreV2ArrayInput)(nil)).Elem(), RecoveryPointRestoreV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*RecoveryPointRestoreV2MapInput)(nil)).Elem(), RecoveryPointRestoreV2Map{})
	pulumi.RegisterOutputType(RecoveryPointRestoreV2Output{})
	pulumi.RegisterOutputType(RecoveryPointRestoreV2ArrayOutput{})
	pulumi.RegisterOutputType(RecoveryPointRestoreV2MapOutput{})
}
