// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a datasource to retrieve the floating IP for this extId.
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
//			_, err := nutanix.LookupFloatingIpV2(ctx, &nutanix.LookupFloatingIpV2Args{
//				ExtId: "cf1a7643-605e-4622-9f2a-b3fdccdbd072",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupFloatingIpV2(ctx *pulumi.Context, args *LookupFloatingIpV2Args, opts ...pulumi.InvokeOption) (*LookupFloatingIpV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupFloatingIpV2Result
	err := ctx.Invoke("nutanix:index/getFloatingIpV2:getFloatingIpV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFloatingIpV2.
type LookupFloatingIpV2Args struct {
	// Floating IP UUID
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getFloatingIpV2.
type LookupFloatingIpV2Result struct {
	// Association status of floating IP.
	AssociationStatus string `pulumi:"associationStatus"`
	// Association of the Floating IP with either NIC or Private IP
	Associations []GetFloatingIpV2Association `pulumi:"associations"`
	// Description for the Floating IP.
	Description string `pulumi:"description"`
	ExtId       string `pulumi:"extId"`
	// External subnet reference for the Floating IP to be allocated in on-prem only.
	ExternalSubnetReference string `pulumi:"externalSubnetReference"`
	// Networking common base object
	ExternalSubnets []GetFloatingIpV2ExternalSubnet `pulumi:"externalSubnets"`
	// Floating IP value in string
	FloatingIpValue string `pulumi:"floatingIpValue"`
	// Floating IP address.
	FloatingIps []GetFloatingIpV2FloatingIp `pulumi:"floatingIps"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
	Links []GetFloatingIpV2Link `pulumi:"links"`
	// Metadata associated with this resource.
	Metadatas []GetFloatingIpV2Metadata `pulumi:"metadatas"`
	// Name of the floating IP.
	Name string `pulumi:"name"`
	// Private IP value in string
	PrivateIp string `pulumi:"privateIp"`
	// A globally unique identifier that represents the tenant that owns this entity.
	TenantId string `pulumi:"tenantId"`
	// VM NIC reference.
	VmNicReference string `pulumi:"vmNicReference"`
	// Virtual NIC for projections
	VmNics []GetFloatingIpV2VmNic `pulumi:"vmNics"`
	// VPC reference UUID
	VpcReference string `pulumi:"vpcReference"`
	// Networking common base object
	Vpcs []GetFloatingIpV2Vpc `pulumi:"vpcs"`
}

func LookupFloatingIpV2Output(ctx *pulumi.Context, args LookupFloatingIpV2OutputArgs, opts ...pulumi.InvokeOption) LookupFloatingIpV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupFloatingIpV2ResultOutput, error) {
			args := v.(LookupFloatingIpV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getFloatingIpV2:getFloatingIpV2", args, LookupFloatingIpV2ResultOutput{}, options).(LookupFloatingIpV2ResultOutput), nil
		}).(LookupFloatingIpV2ResultOutput)
}

// A collection of arguments for invoking getFloatingIpV2.
type LookupFloatingIpV2OutputArgs struct {
	// Floating IP UUID
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (LookupFloatingIpV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFloatingIpV2Args)(nil)).Elem()
}

// A collection of values returned by getFloatingIpV2.
type LookupFloatingIpV2ResultOutput struct{ *pulumi.OutputState }

func (LookupFloatingIpV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFloatingIpV2Result)(nil)).Elem()
}

func (o LookupFloatingIpV2ResultOutput) ToLookupFloatingIpV2ResultOutput() LookupFloatingIpV2ResultOutput {
	return o
}

func (o LookupFloatingIpV2ResultOutput) ToLookupFloatingIpV2ResultOutputWithContext(ctx context.Context) LookupFloatingIpV2ResultOutput {
	return o
}

// Association status of floating IP.
func (o LookupFloatingIpV2ResultOutput) AssociationStatus() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.AssociationStatus }).(pulumi.StringOutput)
}

// Association of the Floating IP with either NIC or Private IP
func (o LookupFloatingIpV2ResultOutput) Associations() GetFloatingIpV2AssociationArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2Association { return v.Associations }).(GetFloatingIpV2AssociationArrayOutput)
}

// Description for the Floating IP.
func (o LookupFloatingIpV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupFloatingIpV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// External subnet reference for the Floating IP to be allocated in on-prem only.
func (o LookupFloatingIpV2ResultOutput) ExternalSubnetReference() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.ExternalSubnetReference }).(pulumi.StringOutput)
}

// Networking common base object
func (o LookupFloatingIpV2ResultOutput) ExternalSubnets() GetFloatingIpV2ExternalSubnetArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2ExternalSubnet { return v.ExternalSubnets }).(GetFloatingIpV2ExternalSubnetArrayOutput)
}

// Floating IP value in string
func (o LookupFloatingIpV2ResultOutput) FloatingIpValue() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.FloatingIpValue }).(pulumi.StringOutput)
}

// Floating IP address.
func (o LookupFloatingIpV2ResultOutput) FloatingIps() GetFloatingIpV2FloatingIpArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2FloatingIp { return v.FloatingIps }).(GetFloatingIpV2FloatingIpArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupFloatingIpV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
func (o LookupFloatingIpV2ResultOutput) Links() GetFloatingIpV2LinkArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2Link { return v.Links }).(GetFloatingIpV2LinkArrayOutput)
}

// Metadata associated with this resource.
func (o LookupFloatingIpV2ResultOutput) Metadatas() GetFloatingIpV2MetadataArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2Metadata { return v.Metadatas }).(GetFloatingIpV2MetadataArrayOutput)
}

// Name of the floating IP.
func (o LookupFloatingIpV2ResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.Name }).(pulumi.StringOutput)
}

// Private IP value in string
func (o LookupFloatingIpV2ResultOutput) PrivateIp() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.PrivateIp }).(pulumi.StringOutput)
}

// A globally unique identifier that represents the tenant that owns this entity.
func (o LookupFloatingIpV2ResultOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.TenantId }).(pulumi.StringOutput)
}

// VM NIC reference.
func (o LookupFloatingIpV2ResultOutput) VmNicReference() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.VmNicReference }).(pulumi.StringOutput)
}

// Virtual NIC for projections
func (o LookupFloatingIpV2ResultOutput) VmNics() GetFloatingIpV2VmNicArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2VmNic { return v.VmNics }).(GetFloatingIpV2VmNicArrayOutput)
}

// VPC reference UUID
func (o LookupFloatingIpV2ResultOutput) VpcReference() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) string { return v.VpcReference }).(pulumi.StringOutput)
}

// Networking common base object
func (o LookupFloatingIpV2ResultOutput) Vpcs() GetFloatingIpV2VpcArrayOutput {
	return o.ApplyT(func(v LookupFloatingIpV2Result) []GetFloatingIpV2Vpc { return v.Vpcs }).(GetFloatingIpV2VpcArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupFloatingIpV2ResultOutput{})
}
