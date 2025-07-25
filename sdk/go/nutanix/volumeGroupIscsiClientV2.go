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

// Attaches iSCSI initiator to a Volume Group identified by {extId}.
type VolumeGroupIscsiClientV2 struct {
	pulumi.CustomResourceState

	// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
	AttachmentSite pulumi.StringPtrOutput `pulumi:"attachmentSite"`
	// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
	ClientSecret pulumi.StringPtrOutput `pulumi:"clientSecret"`
	// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
	EnabledAuthentications pulumi.StringPtrOutput `pulumi:"enabledAuthentications"`
	// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
	ExtId pulumi.StringOutput `pulumi:"extId"`
	// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
	IscsiInitiatorName pulumi.StringPtrOutput `pulumi:"iscsiInitiatorName"`
	// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
	IscsiInitiatorNetworkIds VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayOutput `pulumi:"iscsiInitiatorNetworkIds"`
	// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
	NumVirtualTargets pulumi.IntPtrOutput `pulumi:"numVirtualTargets"`
	// -(Required) The external identifier of the volume group.
	VgExtId pulumi.StringOutput `pulumi:"vgExtId"`
}

// NewVolumeGroupIscsiClientV2 registers a new resource with the given unique name, arguments, and options.
func NewVolumeGroupIscsiClientV2(ctx *pulumi.Context,
	name string, args *VolumeGroupIscsiClientV2Args, opts ...pulumi.ResourceOption) (*VolumeGroupIscsiClientV2, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.VgExtId == nil {
		return nil, errors.New("invalid value for required argument 'VgExtId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource VolumeGroupIscsiClientV2
	err := ctx.RegisterResource("nutanix:index/volumeGroupIscsiClientV2:VolumeGroupIscsiClientV2", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVolumeGroupIscsiClientV2 gets an existing VolumeGroupIscsiClientV2 resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVolumeGroupIscsiClientV2(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VolumeGroupIscsiClientV2State, opts ...pulumi.ResourceOption) (*VolumeGroupIscsiClientV2, error) {
	var resource VolumeGroupIscsiClientV2
	err := ctx.ReadResource("nutanix:index/volumeGroupIscsiClientV2:VolumeGroupIscsiClientV2", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VolumeGroupIscsiClientV2 resources.
type volumeGroupIscsiClientV2State struct {
	// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
	AttachmentSite *string `pulumi:"attachmentSite"`
	// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
	ClientSecret *string `pulumi:"clientSecret"`
	// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
	EnabledAuthentications *string `pulumi:"enabledAuthentications"`
	// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
	ExtId *string `pulumi:"extId"`
	// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
	IscsiInitiatorName *string `pulumi:"iscsiInitiatorName"`
	// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
	IscsiInitiatorNetworkIds []VolumeGroupIscsiClientV2IscsiInitiatorNetworkId `pulumi:"iscsiInitiatorNetworkIds"`
	// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
	NumVirtualTargets *int `pulumi:"numVirtualTargets"`
	// -(Required) The external identifier of the volume group.
	VgExtId *string `pulumi:"vgExtId"`
}

type VolumeGroupIscsiClientV2State struct {
	// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
	AttachmentSite pulumi.StringPtrInput
	// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
	ClientSecret pulumi.StringPtrInput
	// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
	EnabledAuthentications pulumi.StringPtrInput
	// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
	ExtId pulumi.StringPtrInput
	// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
	IscsiInitiatorName pulumi.StringPtrInput
	// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
	IscsiInitiatorNetworkIds VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayInput
	// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
	NumVirtualTargets pulumi.IntPtrInput
	// -(Required) The external identifier of the volume group.
	VgExtId pulumi.StringPtrInput
}

func (VolumeGroupIscsiClientV2State) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeGroupIscsiClientV2State)(nil)).Elem()
}

type volumeGroupIscsiClientV2Args struct {
	// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
	AttachmentSite *string `pulumi:"attachmentSite"`
	// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
	ClientSecret *string `pulumi:"clientSecret"`
	// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
	EnabledAuthentications *string `pulumi:"enabledAuthentications"`
	// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
	ExtId *string `pulumi:"extId"`
	// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
	IscsiInitiatorName *string `pulumi:"iscsiInitiatorName"`
	// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
	IscsiInitiatorNetworkIds []VolumeGroupIscsiClientV2IscsiInitiatorNetworkId `pulumi:"iscsiInitiatorNetworkIds"`
	// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
	NumVirtualTargets *int `pulumi:"numVirtualTargets"`
	// -(Required) The external identifier of the volume group.
	VgExtId string `pulumi:"vgExtId"`
}

// The set of arguments for constructing a VolumeGroupIscsiClientV2 resource.
type VolumeGroupIscsiClientV2Args struct {
	// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
	AttachmentSite pulumi.StringPtrInput
	// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
	ClientSecret pulumi.StringPtrInput
	// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
	EnabledAuthentications pulumi.StringPtrInput
	// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
	ExtId pulumi.StringPtrInput
	// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
	IscsiInitiatorName pulumi.StringPtrInput
	// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
	IscsiInitiatorNetworkIds VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayInput
	// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
	NumVirtualTargets pulumi.IntPtrInput
	// -(Required) The external identifier of the volume group.
	VgExtId pulumi.StringInput
}

func (VolumeGroupIscsiClientV2Args) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeGroupIscsiClientV2Args)(nil)).Elem()
}

type VolumeGroupIscsiClientV2Input interface {
	pulumi.Input

	ToVolumeGroupIscsiClientV2Output() VolumeGroupIscsiClientV2Output
	ToVolumeGroupIscsiClientV2OutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2Output
}

func (*VolumeGroupIscsiClientV2) ElementType() reflect.Type {
	return reflect.TypeOf((**VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (i *VolumeGroupIscsiClientV2) ToVolumeGroupIscsiClientV2Output() VolumeGroupIscsiClientV2Output {
	return i.ToVolumeGroupIscsiClientV2OutputWithContext(context.Background())
}

func (i *VolumeGroupIscsiClientV2) ToVolumeGroupIscsiClientV2OutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2Output {
	return pulumi.ToOutputWithContext(ctx, i).(VolumeGroupIscsiClientV2Output)
}

// VolumeGroupIscsiClientV2ArrayInput is an input type that accepts VolumeGroupIscsiClientV2Array and VolumeGroupIscsiClientV2ArrayOutput values.
// You can construct a concrete instance of `VolumeGroupIscsiClientV2ArrayInput` via:
//
//	VolumeGroupIscsiClientV2Array{ VolumeGroupIscsiClientV2Args{...} }
type VolumeGroupIscsiClientV2ArrayInput interface {
	pulumi.Input

	ToVolumeGroupIscsiClientV2ArrayOutput() VolumeGroupIscsiClientV2ArrayOutput
	ToVolumeGroupIscsiClientV2ArrayOutputWithContext(context.Context) VolumeGroupIscsiClientV2ArrayOutput
}

type VolumeGroupIscsiClientV2Array []VolumeGroupIscsiClientV2Input

func (VolumeGroupIscsiClientV2Array) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (i VolumeGroupIscsiClientV2Array) ToVolumeGroupIscsiClientV2ArrayOutput() VolumeGroupIscsiClientV2ArrayOutput {
	return i.ToVolumeGroupIscsiClientV2ArrayOutputWithContext(context.Background())
}

func (i VolumeGroupIscsiClientV2Array) ToVolumeGroupIscsiClientV2ArrayOutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2ArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumeGroupIscsiClientV2ArrayOutput)
}

// VolumeGroupIscsiClientV2MapInput is an input type that accepts VolumeGroupIscsiClientV2Map and VolumeGroupIscsiClientV2MapOutput values.
// You can construct a concrete instance of `VolumeGroupIscsiClientV2MapInput` via:
//
//	VolumeGroupIscsiClientV2Map{ "key": VolumeGroupIscsiClientV2Args{...} }
type VolumeGroupIscsiClientV2MapInput interface {
	pulumi.Input

	ToVolumeGroupIscsiClientV2MapOutput() VolumeGroupIscsiClientV2MapOutput
	ToVolumeGroupIscsiClientV2MapOutputWithContext(context.Context) VolumeGroupIscsiClientV2MapOutput
}

type VolumeGroupIscsiClientV2Map map[string]VolumeGroupIscsiClientV2Input

func (VolumeGroupIscsiClientV2Map) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (i VolumeGroupIscsiClientV2Map) ToVolumeGroupIscsiClientV2MapOutput() VolumeGroupIscsiClientV2MapOutput {
	return i.ToVolumeGroupIscsiClientV2MapOutputWithContext(context.Background())
}

func (i VolumeGroupIscsiClientV2Map) ToVolumeGroupIscsiClientV2MapOutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2MapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumeGroupIscsiClientV2MapOutput)
}

type VolumeGroupIscsiClientV2Output struct{ *pulumi.OutputState }

func (VolumeGroupIscsiClientV2Output) ElementType() reflect.Type {
	return reflect.TypeOf((**VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (o VolumeGroupIscsiClientV2Output) ToVolumeGroupIscsiClientV2Output() VolumeGroupIscsiClientV2Output {
	return o
}

func (o VolumeGroupIscsiClientV2Output) ToVolumeGroupIscsiClientV2OutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2Output {
	return o
}

// -(Optional) The site where the Volume Group attach operation should be processed. This is an optional field. This field may only be set if Metro DR has been configured for this Volume Group. Valid values are SECONDARY, PRIMARY.
func (o VolumeGroupIscsiClientV2Output) AttachmentSite() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringPtrOutput { return v.AttachmentSite }).(pulumi.StringPtrOutput)
}

// -(Optional) iSCSI initiator client secret in case of CHAP authentication. This field should not be provided in case the authentication type is not set to CHAP.
func (o VolumeGroupIscsiClientV2Output) ClientSecret() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringPtrOutput { return v.ClientSecret }).(pulumi.StringPtrOutput)
}

// -(Optional) (Optional) The authentication type enabled for the Volume Group. This is an optional field. If omitted, authentication is not configured for the Volume Group. If this is set to CHAP, the target/client secret must be provided. Valid values are CHAP, NONE
func (o VolumeGroupIscsiClientV2Output) EnabledAuthentications() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringPtrOutput { return v.EnabledAuthentications }).(pulumi.StringPtrOutput)
}

// -(Required) A globally unique identifier of an instance that is suitable for external consumption.
func (o VolumeGroupIscsiClientV2Output) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringOutput { return v.ExtId }).(pulumi.StringOutput)
}

// -iSCSI initiator name. During the attach operation, exactly one of iscsiInitiatorName and iscsiInitiatorNetworkId must be specified. This field is immutable.
func (o VolumeGroupIscsiClientV2Output) IscsiInitiatorName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringPtrOutput { return v.IscsiInitiatorName }).(pulumi.StringPtrOutput)
}

// - An unique address that identifies a device on the internet or a local network in IPv4/IPv6 format or a Fully Qualified Domain Name.
func (o VolumeGroupIscsiClientV2Output) IscsiInitiatorNetworkIds() VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayOutput {
		return v.IscsiInitiatorNetworkIds
	}).(VolumeGroupIscsiClientV2IscsiInitiatorNetworkIdArrayOutput)
}

// -(Optional) Number of virtual targets generated for the iSCSI target. This field is immutable.
func (o VolumeGroupIscsiClientV2Output) NumVirtualTargets() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.IntPtrOutput { return v.NumVirtualTargets }).(pulumi.IntPtrOutput)
}

// -(Required) The external identifier of the volume group.
func (o VolumeGroupIscsiClientV2Output) VgExtId() pulumi.StringOutput {
	return o.ApplyT(func(v *VolumeGroupIscsiClientV2) pulumi.StringOutput { return v.VgExtId }).(pulumi.StringOutput)
}

type VolumeGroupIscsiClientV2ArrayOutput struct{ *pulumi.OutputState }

func (VolumeGroupIscsiClientV2ArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (o VolumeGroupIscsiClientV2ArrayOutput) ToVolumeGroupIscsiClientV2ArrayOutput() VolumeGroupIscsiClientV2ArrayOutput {
	return o
}

func (o VolumeGroupIscsiClientV2ArrayOutput) ToVolumeGroupIscsiClientV2ArrayOutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2ArrayOutput {
	return o
}

func (o VolumeGroupIscsiClientV2ArrayOutput) Index(i pulumi.IntInput) VolumeGroupIscsiClientV2Output {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *VolumeGroupIscsiClientV2 {
		return vs[0].([]*VolumeGroupIscsiClientV2)[vs[1].(int)]
	}).(VolumeGroupIscsiClientV2Output)
}

type VolumeGroupIscsiClientV2MapOutput struct{ *pulumi.OutputState }

func (VolumeGroupIscsiClientV2MapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*VolumeGroupIscsiClientV2)(nil)).Elem()
}

func (o VolumeGroupIscsiClientV2MapOutput) ToVolumeGroupIscsiClientV2MapOutput() VolumeGroupIscsiClientV2MapOutput {
	return o
}

func (o VolumeGroupIscsiClientV2MapOutput) ToVolumeGroupIscsiClientV2MapOutputWithContext(ctx context.Context) VolumeGroupIscsiClientV2MapOutput {
	return o
}

func (o VolumeGroupIscsiClientV2MapOutput) MapIndex(k pulumi.StringInput) VolumeGroupIscsiClientV2Output {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *VolumeGroupIscsiClientV2 {
		return vs[0].(map[string]*VolumeGroupIscsiClientV2)[vs[1].(string)]
	}).(VolumeGroupIscsiClientV2Output)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VolumeGroupIscsiClientV2Input)(nil)).Elem(), &VolumeGroupIscsiClientV2{})
	pulumi.RegisterInputType(reflect.TypeOf((*VolumeGroupIscsiClientV2ArrayInput)(nil)).Elem(), VolumeGroupIscsiClientV2Array{})
	pulumi.RegisterInputType(reflect.TypeOf((*VolumeGroupIscsiClientV2MapInput)(nil)).Elem(), VolumeGroupIscsiClientV2Map{})
	pulumi.RegisterOutputType(VolumeGroupIscsiClientV2Output{})
	pulumi.RegisterOutputType(VolumeGroupIscsiClientV2ArrayOutput{})
	pulumi.RegisterOutputType(VolumeGroupIscsiClientV2MapOutput{})
}
