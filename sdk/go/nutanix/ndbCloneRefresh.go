// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"errors"
	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to perform the refresh clone of database based on the input parameters.
//
// ## Example Usage
//
// ### resource to refresh clone with snapshot id
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
//			_, err := nutanix.NewNdbCloneRefresh(ctx, "acctest-managed", &nutanix.NdbCloneRefreshArgs{
//				CloneId:    pulumi.String("{{ clone_id }}"),
//				SnapshotId: pulumi.String("{{ snapshot_id }}"),
//				Timezone:   pulumi.String("Asia/Calcutta"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type NdbCloneRefresh struct {
	pulumi.CustomResourceState

	// clone id
	CloneId pulumi.StringOutput `pulumi:"cloneId"`
	// snapshot id where clone has to be refreshed
	SnapshotId pulumi.StringPtrOutput `pulumi:"snapshotId"`
	// timezone. Default is Asia/Calcutta.
	//
	// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
	Timezone          pulumi.StringPtrOutput `pulumi:"timezone"`
	UserPitrTimestamp pulumi.StringPtrOutput `pulumi:"userPitrTimestamp"`
}

// NewNdbCloneRefresh registers a new resource with the given unique name, arguments, and options.
func NewNdbCloneRefresh(ctx *pulumi.Context,
	name string, args *NdbCloneRefreshArgs, opts ...pulumi.ResourceOption) (*NdbCloneRefresh, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CloneId == nil {
		return nil, errors.New("invalid value for required argument 'CloneId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource NdbCloneRefresh
	err := ctx.RegisterResource("nutanix:index/ndbCloneRefresh:NdbCloneRefresh", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNdbCloneRefresh gets an existing NdbCloneRefresh resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNdbCloneRefresh(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NdbCloneRefreshState, opts ...pulumi.ResourceOption) (*NdbCloneRefresh, error) {
	var resource NdbCloneRefresh
	err := ctx.ReadResource("nutanix:index/ndbCloneRefresh:NdbCloneRefresh", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NdbCloneRefresh resources.
type ndbCloneRefreshState struct {
	// clone id
	CloneId *string `pulumi:"cloneId"`
	// snapshot id where clone has to be refreshed
	SnapshotId *string `pulumi:"snapshotId"`
	// timezone. Default is Asia/Calcutta.
	//
	// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
	Timezone          *string `pulumi:"timezone"`
	UserPitrTimestamp *string `pulumi:"userPitrTimestamp"`
}

type NdbCloneRefreshState struct {
	// clone id
	CloneId pulumi.StringPtrInput
	// snapshot id where clone has to be refreshed
	SnapshotId pulumi.StringPtrInput
	// timezone. Default is Asia/Calcutta.
	//
	// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
	Timezone          pulumi.StringPtrInput
	UserPitrTimestamp pulumi.StringPtrInput
}

func (NdbCloneRefreshState) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbCloneRefreshState)(nil)).Elem()
}

type ndbCloneRefreshArgs struct {
	// clone id
	CloneId string `pulumi:"cloneId"`
	// snapshot id where clone has to be refreshed
	SnapshotId *string `pulumi:"snapshotId"`
	// timezone. Default is Asia/Calcutta.
	//
	// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
	Timezone          *string `pulumi:"timezone"`
	UserPitrTimestamp *string `pulumi:"userPitrTimestamp"`
}

// The set of arguments for constructing a NdbCloneRefresh resource.
type NdbCloneRefreshArgs struct {
	// clone id
	CloneId pulumi.StringInput
	// snapshot id where clone has to be refreshed
	SnapshotId pulumi.StringPtrInput
	// timezone. Default is Asia/Calcutta.
	//
	// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
	Timezone          pulumi.StringPtrInput
	UserPitrTimestamp pulumi.StringPtrInput
}

func (NdbCloneRefreshArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbCloneRefreshArgs)(nil)).Elem()
}

type NdbCloneRefreshInput interface {
	pulumi.Input

	ToNdbCloneRefreshOutput() NdbCloneRefreshOutput
	ToNdbCloneRefreshOutputWithContext(ctx context.Context) NdbCloneRefreshOutput
}

func (*NdbCloneRefresh) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbCloneRefresh)(nil)).Elem()
}

func (i *NdbCloneRefresh) ToNdbCloneRefreshOutput() NdbCloneRefreshOutput {
	return i.ToNdbCloneRefreshOutputWithContext(context.Background())
}

func (i *NdbCloneRefresh) ToNdbCloneRefreshOutputWithContext(ctx context.Context) NdbCloneRefreshOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneRefreshOutput)
}

// NdbCloneRefreshArrayInput is an input type that accepts NdbCloneRefreshArray and NdbCloneRefreshArrayOutput values.
// You can construct a concrete instance of `NdbCloneRefreshArrayInput` via:
//
//	NdbCloneRefreshArray{ NdbCloneRefreshArgs{...} }
type NdbCloneRefreshArrayInput interface {
	pulumi.Input

	ToNdbCloneRefreshArrayOutput() NdbCloneRefreshArrayOutput
	ToNdbCloneRefreshArrayOutputWithContext(context.Context) NdbCloneRefreshArrayOutput
}

type NdbCloneRefreshArray []NdbCloneRefreshInput

func (NdbCloneRefreshArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbCloneRefresh)(nil)).Elem()
}

func (i NdbCloneRefreshArray) ToNdbCloneRefreshArrayOutput() NdbCloneRefreshArrayOutput {
	return i.ToNdbCloneRefreshArrayOutputWithContext(context.Background())
}

func (i NdbCloneRefreshArray) ToNdbCloneRefreshArrayOutputWithContext(ctx context.Context) NdbCloneRefreshArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneRefreshArrayOutput)
}

// NdbCloneRefreshMapInput is an input type that accepts NdbCloneRefreshMap and NdbCloneRefreshMapOutput values.
// You can construct a concrete instance of `NdbCloneRefreshMapInput` via:
//
//	NdbCloneRefreshMap{ "key": NdbCloneRefreshArgs{...} }
type NdbCloneRefreshMapInput interface {
	pulumi.Input

	ToNdbCloneRefreshMapOutput() NdbCloneRefreshMapOutput
	ToNdbCloneRefreshMapOutputWithContext(context.Context) NdbCloneRefreshMapOutput
}

type NdbCloneRefreshMap map[string]NdbCloneRefreshInput

func (NdbCloneRefreshMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbCloneRefresh)(nil)).Elem()
}

func (i NdbCloneRefreshMap) ToNdbCloneRefreshMapOutput() NdbCloneRefreshMapOutput {
	return i.ToNdbCloneRefreshMapOutputWithContext(context.Background())
}

func (i NdbCloneRefreshMap) ToNdbCloneRefreshMapOutputWithContext(ctx context.Context) NdbCloneRefreshMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneRefreshMapOutput)
}

type NdbCloneRefreshOutput struct{ *pulumi.OutputState }

func (NdbCloneRefreshOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbCloneRefresh)(nil)).Elem()
}

func (o NdbCloneRefreshOutput) ToNdbCloneRefreshOutput() NdbCloneRefreshOutput {
	return o
}

func (o NdbCloneRefreshOutput) ToNdbCloneRefreshOutputWithContext(ctx context.Context) NdbCloneRefreshOutput {
	return o
}

// clone id
func (o NdbCloneRefreshOutput) CloneId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbCloneRefresh) pulumi.StringOutput { return v.CloneId }).(pulumi.StringOutput)
}

// snapshot id where clone has to be refreshed
func (o NdbCloneRefreshOutput) SnapshotId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbCloneRefresh) pulumi.StringPtrOutput { return v.SnapshotId }).(pulumi.StringPtrOutput)
}

// timezone. Default is Asia/Calcutta.
//
// See detailed information in [NDB Clone Refresh](https://www.nutanix.dev/api_references/ndb/#/d4e53fff274fa-start-refresh-operation-for-the-given-clone).
func (o NdbCloneRefreshOutput) Timezone() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbCloneRefresh) pulumi.StringPtrOutput { return v.Timezone }).(pulumi.StringPtrOutput)
}

func (o NdbCloneRefreshOutput) UserPitrTimestamp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbCloneRefresh) pulumi.StringPtrOutput { return v.UserPitrTimestamp }).(pulumi.StringPtrOutput)
}

type NdbCloneRefreshArrayOutput struct{ *pulumi.OutputState }

func (NdbCloneRefreshArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbCloneRefresh)(nil)).Elem()
}

func (o NdbCloneRefreshArrayOutput) ToNdbCloneRefreshArrayOutput() NdbCloneRefreshArrayOutput {
	return o
}

func (o NdbCloneRefreshArrayOutput) ToNdbCloneRefreshArrayOutputWithContext(ctx context.Context) NdbCloneRefreshArrayOutput {
	return o
}

func (o NdbCloneRefreshArrayOutput) Index(i pulumi.IntInput) NdbCloneRefreshOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NdbCloneRefresh {
		return vs[0].([]*NdbCloneRefresh)[vs[1].(int)]
	}).(NdbCloneRefreshOutput)
}

type NdbCloneRefreshMapOutput struct{ *pulumi.OutputState }

func (NdbCloneRefreshMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbCloneRefresh)(nil)).Elem()
}

func (o NdbCloneRefreshMapOutput) ToNdbCloneRefreshMapOutput() NdbCloneRefreshMapOutput {
	return o
}

func (o NdbCloneRefreshMapOutput) ToNdbCloneRefreshMapOutputWithContext(ctx context.Context) NdbCloneRefreshMapOutput {
	return o
}

func (o NdbCloneRefreshMapOutput) MapIndex(k pulumi.StringInput) NdbCloneRefreshOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NdbCloneRefresh {
		return vs[0].(map[string]*NdbCloneRefresh)[vs[1].(string)]
	}).(NdbCloneRefreshOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneRefreshInput)(nil)).Elem(), &NdbCloneRefresh{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneRefreshArrayInput)(nil)).Elem(), NdbCloneRefreshArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneRefreshMapInput)(nil)).Elem(), NdbCloneRefreshMap{})
	pulumi.RegisterOutputType(NdbCloneRefreshOutput{})
	pulumi.RegisterOutputType(NdbCloneRefreshArrayOutput{})
	pulumi.RegisterOutputType(NdbCloneRefreshMapOutput{})
}