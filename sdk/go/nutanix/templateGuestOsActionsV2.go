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

// Performs Guest OS actions on given template. It Initiates, Completes and Cancels the Guest OS operation.
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
//			_, err := nutanix.NewTemplateGuestOsActionsV2(ctx, "example-1", &nutanix.TemplateGuestOsActionsV2Args{
//				Action:    pulumi.String("initiate"),
//				ExtId:     pulumi.String("ab520e1d-4950-1db1-917f-a9e2ea35b8e3"),
//				VersionId: pulumi.String("c2c249b0-98a0-43fa-9ff6-dcde578d3936"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = nutanix.NewTemplateGuestOsActionsV2(ctx, "example-2", &nutanix.TemplateGuestOsActionsV2Args{
//				Action:             pulumi.String("complete"),
//				ExtId:              pulumi.String("8a938cc5-282b-48c4-81be-de22de145d07"),
//				IsActiveVersion:    pulumi.String("true"),
//				VersionDescription: pulumi.String("version desc"),
//				VersionName:        pulumi.String("version_name"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = nutanix.NewTemplateGuestOsActionsV2(ctx, "example-3", &nutanix.TemplateGuestOsActionsV2Args{
//				Action: pulumi.String("cancel"),
//				ExtId:  pulumi.String("1cefd0f5-6d38-4c9b-a07c-bdd2db004224"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type TemplateGuestOsActionsV2 struct {
	pulumi.CustomResourceState

	// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
	Action pulumi.StringOutput `pulumi:"action"`
	// The identifier of a Template.
	ExtId pulumi.StringOutput `pulumi:"extId"`
	// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
	//
	// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
	IsActiveVersion pulumi.StringPtrOutput `pulumi:"isActiveVersion"`
	// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
	VersionDescription pulumi.StringPtrOutput `pulumi:"versionDescription"`
	// The identifier of a Template Version. Only applicable with `Initiate` action.
	VersionId pulumi.StringPtrOutput `pulumi:"versionId"`
	// The user defined name of a Template Version. Only applicable with `complete` action.
	VersionName pulumi.StringPtrOutput `pulumi:"versionName"`
}

// NewTemplateGuestOsActionsV2 registers a new resource with the given unique name, arguments, and options.
func NewTemplateGuestOsActionsV2(ctx *pulumi.Context,
	name string, args *TemplateGuestOsActionsV2Args, opts ...pulumi.ResourceOption) (*TemplateGuestOsActionsV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Action == nil {
		return nil, errors.New("invalid value for required argument 'Action'")
	}
	if args.ExtId == nil {
		return nil, errors.New("invalid value for required argument 'ExtId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TemplateGuestOsActionsV2
	err := ctx.RegisterResource("nutanix:index/templateGuestOsActionsV2:TemplateGuestOsActionsV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTemplateGuestOsActionsV2 gets an existing TemplateGuestOsActionsV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTemplateGuestOsActionsV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TemplateGuestOsActionsV2State, opts ...pulumi.ResourceOption) (*TemplateGuestOsActionsV2, error) {
	var resource TemplateGuestOsActionsV2
	err := ctx.ReadResource("nutanix:index/templateGuestOsActionsV2:TemplateGuestOsActionsV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TemplateGuestOsActionsV2 resources.
type templateGuestOsActionsV2State struct {
	// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
	Action *string `pulumi:"action"`
	// The identifier of a Template.
	ExtId *string `pulumi:"extId"`
	// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
	//
	// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
	IsActiveVersion *string `pulumi:"isActiveVersion"`
	// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
	VersionDescription *string `pulumi:"versionDescription"`
	// The identifier of a Template Version. Only applicable with `Initiate` action.
	VersionId *string `pulumi:"versionId"`
	// The user defined name of a Template Version. Only applicable with `complete` action.
	VersionName *string `pulumi:"versionName"`
}

type TemplateGuestOsActionsV2State struct {
	// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
	Action pulumi.StringPtrInput
	// The identifier of a Template.
	ExtId pulumi.StringPtrInput
	// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
	//
	// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
	IsActiveVersion pulumi.StringPtrInput
	// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
	VersionDescription pulumi.StringPtrInput
	// The identifier of a Template Version. Only applicable with `Initiate` action.
	VersionId pulumi.StringPtrInput
	// The user defined name of a Template Version. Only applicable with `complete` action.
	VersionName pulumi.StringPtrInput
}

func (TemplateGuestOsActionsV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*templateGuestOsActionsV2State)(nil)).Elem()
}

type templateGuestOsActionsV2Args struct {
	// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
	Action string `pulumi:"action"`
	// The identifier of a Template.
	ExtId string `pulumi:"extId"`
	// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
	//
	// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
	IsActiveVersion *string `pulumi:"isActiveVersion"`
	// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
	VersionDescription *string `pulumi:"versionDescription"`
	// The identifier of a Template Version. Only applicable with `Initiate` action.
	VersionId *string `pulumi:"versionId"`
	// The user defined name of a Template Version. Only applicable with `complete` action.
	VersionName *string `pulumi:"versionName"`
}

// The set of arguments for constructing a TemplateGuestOsActionsV2 resource.
type TemplateGuestOsActionsV2Args struct {
	// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
	Action pulumi.StringInput
	// The identifier of a Template.
	ExtId pulumi.StringInput
	// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
	//
	// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
	// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
	IsActiveVersion pulumi.StringPtrInput
	// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
	VersionDescription pulumi.StringPtrInput
	// The identifier of a Template Version. Only applicable with `Initiate` action.
	VersionId pulumi.StringPtrInput
	// The user defined name of a Template Version. Only applicable with `complete` action.
	VersionName pulumi.StringPtrInput
}

func (TemplateGuestOsActionsV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*templateGuestOsActionsV2Args)(nil)).Elem()
}

type TemplateGuestOsActionsV2Input interface {
	pulumi.Input

	ToTemplateGuestOsActionsV2Output() TemplateGuestOsActionsV2Output
	ToTemplateGuestOsActionsV2OutputWithContext(ctx context.Context) TemplateGuestOsActionsV2Output
}

func (*TemplateGuestOsActionsV2) ElementType() reflect.Type {
	return reflect.TypeOf((**TemplateGuestOsActionsV2)(nil)).Elem()
}

func (i *TemplateGuestOsActionsV2) ToTemplateGuestOsActionsV2Output() TemplateGuestOsActionsV2Output {
	return i.ToTemplateGuestOsActionsV2OutputWithContext(context.Background())
}

func (i *TemplateGuestOsActionsV2) ToTemplateGuestOsActionsV2OutputWithContext(ctx context.Context) TemplateGuestOsActionsV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateGuestOsActionsV2Output)
}

// TemplateGuestOsActionsV2ArrayInput is an input type that accepts TemplateGuestOsActionsV2Array and TemplateGuestOsActionsV2ArrayOutput values.
// You can construct a concrete instance of `TemplateGuestOsActionsV2ArrayInput` via:
//
//	TemplateGuestOsActionsV2Array{ TemplateGuestOsActionsV2Args{...} }
type TemplateGuestOsActionsV2ArrayInput interface {
	pulumi.Input

	ToTemplateGuestOsActionsV2ArrayOutput() TemplateGuestOsActionsV2ArrayOutput
	ToTemplateGuestOsActionsV2ArrayOutputWithContext(context.Context) TemplateGuestOsActionsV2ArrayOutput
}

type TemplateGuestOsActionsV2Array []TemplateGuestOsActionsV2Input

func (TemplateGuestOsActionsV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TemplateGuestOsActionsV2)(nil)).Elem()
}

func (i TemplateGuestOsActionsV2Array) ToTemplateGuestOsActionsV2ArrayOutput() TemplateGuestOsActionsV2ArrayOutput {
	return i.ToTemplateGuestOsActionsV2ArrayOutputWithContext(context.Background())
}

func (i TemplateGuestOsActionsV2Array) ToTemplateGuestOsActionsV2ArrayOutputWithContext(ctx context.Context) TemplateGuestOsActionsV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateGuestOsActionsV2ArrayOutput)
}

// TemplateGuestOsActionsV2MapInput is an input type that accepts TemplateGuestOsActionsV2Map and TemplateGuestOsActionsV2MapOutput values.
// You can construct a concrete instance of `TemplateGuestOsActionsV2MapInput` via:
//
//	TemplateGuestOsActionsV2Map{ "key": TemplateGuestOsActionsV2Args{...} }
type TemplateGuestOsActionsV2MapInput interface {
	pulumi.Input

	ToTemplateGuestOsActionsV2MapOutput() TemplateGuestOsActionsV2MapOutput
	ToTemplateGuestOsActionsV2MapOutputWithContext(context.Context) TemplateGuestOsActionsV2MapOutput
}

type TemplateGuestOsActionsV2Map map[string]TemplateGuestOsActionsV2Input

func (TemplateGuestOsActionsV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TemplateGuestOsActionsV2)(nil)).Elem()
}

func (i TemplateGuestOsActionsV2Map) ToTemplateGuestOsActionsV2MapOutput() TemplateGuestOsActionsV2MapOutput {
	return i.ToTemplateGuestOsActionsV2MapOutputWithContext(context.Background())
}

func (i TemplateGuestOsActionsV2Map) ToTemplateGuestOsActionsV2MapOutputWithContext(ctx context.Context) TemplateGuestOsActionsV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateGuestOsActionsV2MapOutput)
}

type TemplateGuestOsActionsV2Output struct{ *pulumi.OutputState }

func (TemplateGuestOsActionsV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**TemplateGuestOsActionsV2)(nil)).Elem()
}

func (o TemplateGuestOsActionsV2Output) ToTemplateGuestOsActionsV2Output() TemplateGuestOsActionsV2Output {
	return o
}

func (o TemplateGuestOsActionsV2Output) ToTemplateGuestOsActionsV2OutputWithContext(ctx context.Context) TemplateGuestOsActionsV2Output {
	return o
}

// Actions to be performed. Acceptable values are "initiate", "complete", "cancel" .
func (o TemplateGuestOsActionsV2Output) Action() pulumi.StringOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringOutput { return v.Action }).(pulumi.StringOutput)
}

// The identifier of a Template.
func (o TemplateGuestOsActionsV2Output) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringOutput { return v.ExtId }).(pulumi.StringOutput)
}

// Specify whether to mark the Template Version as active or not. The newly created Version during Template Creation, Updating or Guest OS Updating is set to Active by default unless specified otherwise. Default is true. Only applicable with `complete` action.
//
// See detailed information in [Nutanix Template Guest OS Action Initiate V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/initiateGuestUpdate).
// See detailed information in [Nutanix Template Guest OS Action Complete V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/completeGuestUpdate).
// See detailed information in [Nutanix Template Guest OS Action Cancel V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Templates/operation/cancelGuestUpdate).
func (o TemplateGuestOsActionsV2Output) IsActiveVersion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringPtrOutput { return v.IsActiveVersion }).(pulumi.StringPtrOutput)
}

// The user defined description of a Template Version. (Required) Only applicable with `complete` action.
func (o TemplateGuestOsActionsV2Output) VersionDescription() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringPtrOutput { return v.VersionDescription }).(pulumi.StringPtrOutput)
}

// The identifier of a Template Version. Only applicable with `Initiate` action.
func (o TemplateGuestOsActionsV2Output) VersionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringPtrOutput { return v.VersionId }).(pulumi.StringPtrOutput)
}

// The user defined name of a Template Version. Only applicable with `complete` action.
func (o TemplateGuestOsActionsV2Output) VersionName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TemplateGuestOsActionsV2) pulumi.StringPtrOutput { return v.VersionName }).(pulumi.StringPtrOutput)
}

type TemplateGuestOsActionsV2ArrayOutput struct{ *pulumi.OutputState }

func (TemplateGuestOsActionsV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TemplateGuestOsActionsV2)(nil)).Elem()
}

func (o TemplateGuestOsActionsV2ArrayOutput) ToTemplateGuestOsActionsV2ArrayOutput() TemplateGuestOsActionsV2ArrayOutput {
	return o
}

func (o TemplateGuestOsActionsV2ArrayOutput) ToTemplateGuestOsActionsV2ArrayOutputWithContext(ctx context.Context) TemplateGuestOsActionsV2ArrayOutput {
	return o
}

func (o TemplateGuestOsActionsV2ArrayOutput) Index(i pulumi.IntInput) TemplateGuestOsActionsV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TemplateGuestOsActionsV2 {
		return vs[0].([]*TemplateGuestOsActionsV2)[vs[1].(int)]
	}).(TemplateGuestOsActionsV2Output)
}

type TemplateGuestOsActionsV2MapOutput struct{ *pulumi.OutputState }

func (TemplateGuestOsActionsV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TemplateGuestOsActionsV2)(nil)).Elem()
}

func (o TemplateGuestOsActionsV2MapOutput) ToTemplateGuestOsActionsV2MapOutput() TemplateGuestOsActionsV2MapOutput {
	return o
}

func (o TemplateGuestOsActionsV2MapOutput) ToTemplateGuestOsActionsV2MapOutputWithContext(ctx context.Context) TemplateGuestOsActionsV2MapOutput {
	return o
}

func (o TemplateGuestOsActionsV2MapOutput) MapIndex(k pulumi.StringInput) TemplateGuestOsActionsV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TemplateGuestOsActionsV2 {
		return vs[0].(map[string]*TemplateGuestOsActionsV2)[vs[1].(string)]
	}).(TemplateGuestOsActionsV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TemplateGuestOsActionsV2Input)(nil)).Elem(), &TemplateGuestOsActionsV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*TemplateGuestOsActionsV2ArrayInput)(nil)).Elem(), TemplateGuestOsActionsV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*TemplateGuestOsActionsV2MapInput)(nil)).Elem(), TemplateGuestOsActionsV2Map{})
	pulumi.RegisterOutputType(TemplateGuestOsActionsV2Output{})
	pulumi.RegisterOutputType(TemplateGuestOsActionsV2ArrayOutput{})
	pulumi.RegisterOutputType(TemplateGuestOsActionsV2MapOutput{})
}
