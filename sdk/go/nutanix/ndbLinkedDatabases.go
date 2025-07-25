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

type NdbLinkedDatabases struct {
	pulumi.CustomResourceState

	DatabaseId             pulumi.StringOutput               `pulumi:"databaseId"`
	DatabaseName           pulumi.StringPtrOutput            `pulumi:"databaseName"`
	DatabaseStatus         pulumi.StringOutput               `pulumi:"databaseStatus"`
	DateCreated            pulumi.StringOutput               `pulumi:"dateCreated"`
	DateModified           pulumi.StringOutput               `pulumi:"dateModified"`
	Description            pulumi.StringOutput               `pulumi:"description"`
	Infos                  NdbLinkedDatabasesInfoArrayOutput `pulumi:"infos"`
	Metric                 pulumi.StringMapOutput            `pulumi:"metric"`
	Name                   pulumi.StringOutput               `pulumi:"name"`
	ParentDatabaseId       pulumi.StringOutput               `pulumi:"parentDatabaseId"`
	ParentLinkedDatabaseId pulumi.StringOutput               `pulumi:"parentLinkedDatabaseId"`
	SnapshotId             pulumi.StringOutput               `pulumi:"snapshotId"`
	Status                 pulumi.StringOutput               `pulumi:"status"`
	Timezone               pulumi.StringOutput               `pulumi:"timezone"`
}

// NewNdbLinkedDatabases registers a new resource with the given unique name, arguments, and options.
func NewNdbLinkedDatabases(ctx *pulumi.Context,
	name string, args *NdbLinkedDatabasesArgs, opts ...pulumi.ResourceOption) (*NdbLinkedDatabases, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatabaseId == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource NdbLinkedDatabases
	err := ctx.RegisterResource("nutanix:index/ndbLinkedDatabases:NdbLinkedDatabases", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNdbLinkedDatabases gets an existing NdbLinkedDatabases resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNdbLinkedDatabases(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NdbLinkedDatabasesState, opts ...pulumi.ResourceOption) (*NdbLinkedDatabases, error) {
	var resource NdbLinkedDatabases
	err := ctx.ReadResource("nutanix:index/ndbLinkedDatabases:NdbLinkedDatabases", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NdbLinkedDatabases resources.
type ndbLinkedDatabasesState struct {
	DatabaseId             *string                  `pulumi:"databaseId"`
	DatabaseName           *string                  `pulumi:"databaseName"`
	DatabaseStatus         *string                  `pulumi:"databaseStatus"`
	DateCreated            *string                  `pulumi:"dateCreated"`
	DateModified           *string                  `pulumi:"dateModified"`
	Description            *string                  `pulumi:"description"`
	Infos                  []NdbLinkedDatabasesInfo `pulumi:"infos"`
	Metric                 map[string]string        `pulumi:"metric"`
	Name                   *string                  `pulumi:"name"`
	ParentDatabaseId       *string                  `pulumi:"parentDatabaseId"`
	ParentLinkedDatabaseId *string                  `pulumi:"parentLinkedDatabaseId"`
	SnapshotId             *string                  `pulumi:"snapshotId"`
	Status                 *string                  `pulumi:"status"`
	Timezone               *string                  `pulumi:"timezone"`
}

type NdbLinkedDatabasesState struct {
	DatabaseId             pulumi.StringPtrInput
	DatabaseName           pulumi.StringPtrInput
	DatabaseStatus         pulumi.StringPtrInput
	DateCreated            pulumi.StringPtrInput
	DateModified           pulumi.StringPtrInput
	Description            pulumi.StringPtrInput
	Infos                  NdbLinkedDatabasesInfoArrayInput
	Metric                 pulumi.StringMapInput
	Name                   pulumi.StringPtrInput
	ParentDatabaseId       pulumi.StringPtrInput
	ParentLinkedDatabaseId pulumi.StringPtrInput
	SnapshotId             pulumi.StringPtrInput
	Status                 pulumi.StringPtrInput
	Timezone               pulumi.StringPtrInput
}

func (NdbLinkedDatabasesState) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbLinkedDatabasesState)(nil)).Elem()
}

type ndbLinkedDatabasesArgs struct {
	DatabaseId   string  `pulumi:"databaseId"`
	DatabaseName *string `pulumi:"databaseName"`
}

// The set of arguments for constructing a NdbLinkedDatabases resource.
type NdbLinkedDatabasesArgs struct {
	DatabaseId   pulumi.StringInput
	DatabaseName pulumi.StringPtrInput
}

func (NdbLinkedDatabasesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbLinkedDatabasesArgs)(nil)).Elem()
}

type NdbLinkedDatabasesInput interface {
	pulumi.Input

	ToNdbLinkedDatabasesOutput() NdbLinkedDatabasesOutput
	ToNdbLinkedDatabasesOutputWithContext(ctx context.Context) NdbLinkedDatabasesOutput
}

func (*NdbLinkedDatabases) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbLinkedDatabases)(nil)).Elem()
}

func (i *NdbLinkedDatabases) ToNdbLinkedDatabasesOutput() NdbLinkedDatabasesOutput {
	return i.ToNdbLinkedDatabasesOutputWithContext(context.Background())
}

func (i *NdbLinkedDatabases) ToNdbLinkedDatabasesOutputWithContext(ctx context.Context) NdbLinkedDatabasesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbLinkedDatabasesOutput)
}

// NdbLinkedDatabasesArrayInput is an input type that accepts NdbLinkedDatabasesArray and NdbLinkedDatabasesArrayOutput values.
// You can construct a concrete instance of `NdbLinkedDatabasesArrayInput` via:
//
//	NdbLinkedDatabasesArray{ NdbLinkedDatabasesArgs{...} }
type NdbLinkedDatabasesArrayInput interface {
	pulumi.Input

	ToNdbLinkedDatabasesArrayOutput() NdbLinkedDatabasesArrayOutput
	ToNdbLinkedDatabasesArrayOutputWithContext(context.Context) NdbLinkedDatabasesArrayOutput
}

type NdbLinkedDatabasesArray []NdbLinkedDatabasesInput

func (NdbLinkedDatabasesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbLinkedDatabases)(nil)).Elem()
}

func (i NdbLinkedDatabasesArray) ToNdbLinkedDatabasesArrayOutput() NdbLinkedDatabasesArrayOutput {
	return i.ToNdbLinkedDatabasesArrayOutputWithContext(context.Background())
}

func (i NdbLinkedDatabasesArray) ToNdbLinkedDatabasesArrayOutputWithContext(ctx context.Context) NdbLinkedDatabasesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbLinkedDatabasesArrayOutput)
}

// NdbLinkedDatabasesMapInput is an input type that accepts NdbLinkedDatabasesMap and NdbLinkedDatabasesMapOutput values.
// You can construct a concrete instance of `NdbLinkedDatabasesMapInput` via:
//
//	NdbLinkedDatabasesMap{ "key": NdbLinkedDatabasesArgs{...} }
type NdbLinkedDatabasesMapInput interface {
	pulumi.Input

	ToNdbLinkedDatabasesMapOutput() NdbLinkedDatabasesMapOutput
	ToNdbLinkedDatabasesMapOutputWithContext(context.Context) NdbLinkedDatabasesMapOutput
}

type NdbLinkedDatabasesMap map[string]NdbLinkedDatabasesInput

func (NdbLinkedDatabasesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbLinkedDatabases)(nil)).Elem()
}

func (i NdbLinkedDatabasesMap) ToNdbLinkedDatabasesMapOutput() NdbLinkedDatabasesMapOutput {
	return i.ToNdbLinkedDatabasesMapOutputWithContext(context.Background())
}

func (i NdbLinkedDatabasesMap) ToNdbLinkedDatabasesMapOutputWithContext(ctx context.Context) NdbLinkedDatabasesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbLinkedDatabasesMapOutput)
}

type NdbLinkedDatabasesOutput struct{ *pulumi.OutputState }

func (NdbLinkedDatabasesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbLinkedDatabases)(nil)).Elem()
}

func (o NdbLinkedDatabasesOutput) ToNdbLinkedDatabasesOutput() NdbLinkedDatabasesOutput {
	return o
}

func (o NdbLinkedDatabasesOutput) ToNdbLinkedDatabasesOutputWithContext(ctx context.Context) NdbLinkedDatabasesOutput {
	return o
}

func (o NdbLinkedDatabasesOutput) DatabaseId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.DatabaseId }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) DatabaseName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringPtrOutput { return v.DatabaseName }).(pulumi.StringPtrOutput)
}

func (o NdbLinkedDatabasesOutput) DatabaseStatus() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.DatabaseStatus }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) DateCreated() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.DateCreated }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) DateModified() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.DateModified }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) Infos() NdbLinkedDatabasesInfoArrayOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) NdbLinkedDatabasesInfoArrayOutput { return v.Infos }).(NdbLinkedDatabasesInfoArrayOutput)
}

func (o NdbLinkedDatabasesOutput) Metric() pulumi.StringMapOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringMapOutput { return v.Metric }).(pulumi.StringMapOutput)
}

func (o NdbLinkedDatabasesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) ParentDatabaseId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.ParentDatabaseId }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) ParentLinkedDatabaseId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.ParentLinkedDatabaseId }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) SnapshotId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.SnapshotId }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

func (o NdbLinkedDatabasesOutput) Timezone() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbLinkedDatabases) pulumi.StringOutput { return v.Timezone }).(pulumi.StringOutput)
}

type NdbLinkedDatabasesArrayOutput struct{ *pulumi.OutputState }

func (NdbLinkedDatabasesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbLinkedDatabases)(nil)).Elem()
}

func (o NdbLinkedDatabasesArrayOutput) ToNdbLinkedDatabasesArrayOutput() NdbLinkedDatabasesArrayOutput {
	return o
}

func (o NdbLinkedDatabasesArrayOutput) ToNdbLinkedDatabasesArrayOutputWithContext(ctx context.Context) NdbLinkedDatabasesArrayOutput {
	return o
}

func (o NdbLinkedDatabasesArrayOutput) Index(i pulumi.IntInput) NdbLinkedDatabasesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NdbLinkedDatabases {
		return vs[0].([]*NdbLinkedDatabases)[vs[1].(int)]
	}).(NdbLinkedDatabasesOutput)
}

type NdbLinkedDatabasesMapOutput struct{ *pulumi.OutputState }

func (NdbLinkedDatabasesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbLinkedDatabases)(nil)).Elem()
}

func (o NdbLinkedDatabasesMapOutput) ToNdbLinkedDatabasesMapOutput() NdbLinkedDatabasesMapOutput {
	return o
}

func (o NdbLinkedDatabasesMapOutput) ToNdbLinkedDatabasesMapOutputWithContext(ctx context.Context) NdbLinkedDatabasesMapOutput {
	return o
}

func (o NdbLinkedDatabasesMapOutput) MapIndex(k pulumi.StringInput) NdbLinkedDatabasesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NdbLinkedDatabases {
		return vs[0].(map[string]*NdbLinkedDatabases)[vs[1].(string)]
	}).(NdbLinkedDatabasesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NdbLinkedDatabasesInput)(nil)).Elem(), &NdbLinkedDatabases{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbLinkedDatabasesArrayInput)(nil)).Elem(), NdbLinkedDatabasesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbLinkedDatabasesMapInput)(nil)).Elem(), NdbLinkedDatabasesMap{})
	pulumi.RegisterOutputType(NdbLinkedDatabasesOutput{})
	pulumi.RegisterOutputType(NdbLinkedDatabasesArrayOutput{})
	pulumi.RegisterOutputType(NdbLinkedDatabasesMapOutput{})
}
