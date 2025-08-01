// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Query the Volume Group identified by {extId}.
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
//			_, err := nutanix.LookupVolumeGroupV2(ctx, &nutanix.LookupVolumeGroupV2Args{
//				ExtId: "d09aeec9-5bb7-4bfd-9717-a051178f6e7c",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupVolumeGroupV2(ctx *pulumi.Context, args *LookupVolumeGroupV2Args, opts ...pulumi.InvokeOption) (*LookupVolumeGroupV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupVolumeGroupV2Result
	err := ctx.Invoke("nutanix:index/getVolumeGroupV2:getVolumeGroupV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVolumeGroupV2.
type LookupVolumeGroupV2Args struct {
	// - A globally unique identifier of an instance that is suitable for external consumption.
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getVolumeGroupV2.
type LookupVolumeGroupV2Result struct {
	// - The UUID of the cluster that will host the Volume Group.
	ClusterReference string `pulumi:"clusterReference"`
	// - Service/user who created this Volume Group.
	CreatedBy string `pulumi:"createdBy"`
	// - Volume Group description. This is an optional field.
	Description string `pulumi:"description"`
	// - The authentication type enabled for the Volume Group.
	EnabledAuthentications string `pulumi:"enabledAuthentications"`
	// - A globally unique identifier of an instance that is suitable for external consumption.
	ExtId string `pulumi:"extId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// - Indicates whether the Volume Group is meant to be hidden or not.
	IsHidden bool `pulumi:"isHidden"`
	// - iSCSI specific settings for the Volume Group.
	IscsiFeatures []GetVolumeGroupV2IscsiFeature `pulumi:"iscsiFeatures"`
	// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
	Links []GetVolumeGroupV2Link `pulumi:"links"`
	// -(Required) Volume Group name. This is an optional field.
	Name string `pulumi:"name"`
	// - Indicates whether the Volume Group can be shared across multiple iSCSI initiators. The mode cannot be changed from SHARED to NOT_SHARED on a Volume Group with multiple attachments. Similarly, a Volume Group cannot be associated with more than one attachment as long as it is in exclusive mode. This is an optional field. Valid values are SHARED, NOT_SHARED
	SharingStatus string `pulumi:"sharingStatus"`
	// - Indicates whether to enable Volume Group load balancing for VM attachments. This cannot be enabled if there are iSCSI client attachments already associated with the Volume Group, and vice-versa. This is an optional field.
	ShouldLoadBalanceVmAttachments bool `pulumi:"shouldLoadBalanceVmAttachments"`
	// - Storage optimization features which must be enabled on the Volume Group.
	StorageFeatures []GetVolumeGroupV2StorageFeature `pulumi:"storageFeatures"`
	// - Name of the external client target that will be visible and accessible to the client.
	TargetName string `pulumi:"targetName"`
	// - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
	TenantId string `pulumi:"tenantId"`
	// - Expected usage type for the Volume Group. This is an indicative hint on how the caller will consume the Volume Group.  Valid values are BACKUP_TARGET, INTERNAL, TEMPORARY, USER
	UsageType string `pulumi:"usageType"`
}

func LookupVolumeGroupV2Output(ctx *pulumi.Context, args LookupVolumeGroupV2OutputArgs, opts ...pulumi.InvokeOption) LookupVolumeGroupV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupVolumeGroupV2ResultOutput, error) {
			args := v.(LookupVolumeGroupV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getVolumeGroupV2:getVolumeGroupV2", args, LookupVolumeGroupV2ResultOutput{}, options).(LookupVolumeGroupV2ResultOutput), nil
		}).(LookupVolumeGroupV2ResultOutput)
}

// A collection of arguments for invoking getVolumeGroupV2.
type LookupVolumeGroupV2OutputArgs struct {
	// - A globally unique identifier of an instance that is suitable for external consumption.
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (LookupVolumeGroupV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVolumeGroupV2Args)(nil)).Elem()
}

// A collection of values returned by getVolumeGroupV2.
type LookupVolumeGroupV2ResultOutput struct{ *pulumi.OutputState }

func (LookupVolumeGroupV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVolumeGroupV2Result)(nil)).Elem()
}

func (o LookupVolumeGroupV2ResultOutput) ToLookupVolumeGroupV2ResultOutput() LookupVolumeGroupV2ResultOutput {
	return o
}

func (o LookupVolumeGroupV2ResultOutput) ToLookupVolumeGroupV2ResultOutputWithContext(ctx context.Context) LookupVolumeGroupV2ResultOutput {
	return o
}

// - The UUID of the cluster that will host the Volume Group.
func (o LookupVolumeGroupV2ResultOutput) ClusterReference() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.ClusterReference }).(pulumi.StringOutput)
}

// - Service/user who created this Volume Group.
func (o LookupVolumeGroupV2ResultOutput) CreatedBy() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.CreatedBy }).(pulumi.StringOutput)
}

// - Volume Group description. This is an optional field.
func (o LookupVolumeGroupV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.Description }).(pulumi.StringOutput)
}

// - The authentication type enabled for the Volume Group.
func (o LookupVolumeGroupV2ResultOutput) EnabledAuthentications() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.EnabledAuthentications }).(pulumi.StringOutput)
}

// - A globally unique identifier of an instance that is suitable for external consumption.
func (o LookupVolumeGroupV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVolumeGroupV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// - Indicates whether the Volume Group is meant to be hidden or not.
func (o LookupVolumeGroupV2ResultOutput) IsHidden() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) bool { return v.IsHidden }).(pulumi.BoolOutput)
}

// - iSCSI specific settings for the Volume Group.
func (o LookupVolumeGroupV2ResultOutput) IscsiFeatures() GetVolumeGroupV2IscsiFeatureArrayOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) []GetVolumeGroupV2IscsiFeature { return v.IscsiFeatures }).(GetVolumeGroupV2IscsiFeatureArrayOutput)
}

// - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
func (o LookupVolumeGroupV2ResultOutput) Links() GetVolumeGroupV2LinkArrayOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) []GetVolumeGroupV2Link { return v.Links }).(GetVolumeGroupV2LinkArrayOutput)
}

// -(Required) Volume Group name. This is an optional field.
func (o LookupVolumeGroupV2ResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.Name }).(pulumi.StringOutput)
}

// - Indicates whether the Volume Group can be shared across multiple iSCSI initiators. The mode cannot be changed from SHARED to NOT_SHARED on a Volume Group with multiple attachments. Similarly, a Volume Group cannot be associated with more than one attachment as long as it is in exclusive mode. This is an optional field. Valid values are SHARED, NOT_SHARED
func (o LookupVolumeGroupV2ResultOutput) SharingStatus() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.SharingStatus }).(pulumi.StringOutput)
}

// - Indicates whether to enable Volume Group load balancing for VM attachments. This cannot be enabled if there are iSCSI client attachments already associated with the Volume Group, and vice-versa. This is an optional field.
func (o LookupVolumeGroupV2ResultOutput) ShouldLoadBalanceVmAttachments() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) bool { return v.ShouldLoadBalanceVmAttachments }).(pulumi.BoolOutput)
}

// - Storage optimization features which must be enabled on the Volume Group.
func (o LookupVolumeGroupV2ResultOutput) StorageFeatures() GetVolumeGroupV2StorageFeatureArrayOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) []GetVolumeGroupV2StorageFeature { return v.StorageFeatures }).(GetVolumeGroupV2StorageFeatureArrayOutput)
}

// - Name of the external client target that will be visible and accessible to the client.
func (o LookupVolumeGroupV2ResultOutput) TargetName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.TargetName }).(pulumi.StringOutput)
}

// - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
func (o LookupVolumeGroupV2ResultOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.TenantId }).(pulumi.StringOutput)
}

// - Expected usage type for the Volume Group. This is an indicative hint on how the caller will consume the Volume Group.  Valid values are BACKUP_TARGET, INTERNAL, TEMPORARY, USER
func (o LookupVolumeGroupV2ResultOutput) UsageType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVolumeGroupV2Result) string { return v.UsageType }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVolumeGroupV2ResultOutput{})
}
