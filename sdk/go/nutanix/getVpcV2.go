// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a datasource to retrieve VPC with vpcUuid .
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
//			_, err := nutanix.LookupVpcV2(ctx, &nutanix.LookupVpcV2Args{
//				ExtId: "8a938cc5-282b-48c4-81be-de22de145d07",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupVpcV2(ctx *pulumi.Context, args *LookupVpcV2Args, opts ...pulumi.InvokeOption) (*LookupVpcV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupVpcV2Result
	err := ctx.Invoke("nutanix:index/getVpcV2:getVpcV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcV2.
type LookupVpcV2Args struct {
	// vpc UUID
	ExtId string `pulumi:"extId"`
}

// A collection of values returned by getVpcV2.
type LookupVpcV2Result struct {
	// List of DHCP options to be configured.
	CommonDhcpOptions []GetVpcV2CommonDhcpOption `pulumi:"commonDhcpOptions"`
	// Description of the VPC.
	Description string `pulumi:"description"`
	ExtId       string `pulumi:"extId"`
	// External routing domain associated with this route table
	ExternalRoutingDomainReference string `pulumi:"externalRoutingDomainReference"`
	// List of external subnets that the VPC is attached to.
	ExternalSubnets []GetVpcV2ExternalSubnet `pulumi:"externalSubnets"`
	// CIDR blocks from the VPC which can talk externally without performing NAT. This is applicable when connecting to external subnets which have disabled NAT.
	ExternallyRoutablePrefixes []GetVpcV2ExternallyRoutablePrefix `pulumi:"externallyRoutablePrefixes"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
	Links []GetVpcV2Link `pulumi:"links"`
	// Metadata associated with this resource.
	Metadatas []GetVpcV2Metadata `pulumi:"metadatas"`
	// Name of the VPC.
	Name string `pulumi:"name"`
	// List of IP Addresses used for SNAT.
	SnatIps []GetVpcV2SnatIp `pulumi:"snatIps"`
	// A globally unique identifier that represents the tenant that owns this entity.
	TenantId string `pulumi:"tenantId"`
	// Type of VPC.
	VpcType string `pulumi:"vpcType"`
}

func LookupVpcV2Output(ctx *pulumi.Context, args LookupVpcV2OutputArgs, opts ...pulumi.InvokeOption) LookupVpcV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupVpcV2ResultOutput, error) {
			args := v.(LookupVpcV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getVpcV2:getVpcV2", args, LookupVpcV2ResultOutput{}, options).(LookupVpcV2ResultOutput), nil
		}).(LookupVpcV2ResultOutput)
}

// A collection of arguments for invoking getVpcV2.
type LookupVpcV2OutputArgs struct {
	// vpc UUID
	ExtId pulumi.StringInput `pulumi:"extId"`
}

func (LookupVpcV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcV2Args)(nil)).Elem()
}

// A collection of values returned by getVpcV2.
type LookupVpcV2ResultOutput struct{ *pulumi.OutputState }

func (LookupVpcV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupVpcV2Result)(nil)).Elem()
}

func (o LookupVpcV2ResultOutput) ToLookupVpcV2ResultOutput() LookupVpcV2ResultOutput {
	return o
}

func (o LookupVpcV2ResultOutput) ToLookupVpcV2ResultOutputWithContext(ctx context.Context) LookupVpcV2ResultOutput {
	return o
}

// List of DHCP options to be configured.
func (o LookupVpcV2ResultOutput) CommonDhcpOptions() GetVpcV2CommonDhcpOptionArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2CommonDhcpOption { return v.CommonDhcpOptions }).(GetVpcV2CommonDhcpOptionArrayOutput)
}

// Description of the VPC.
func (o LookupVpcV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupVpcV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// External routing domain associated with this route table
func (o LookupVpcV2ResultOutput) ExternalRoutingDomainReference() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.ExternalRoutingDomainReference }).(pulumi.StringOutput)
}

// List of external subnets that the VPC is attached to.
func (o LookupVpcV2ResultOutput) ExternalSubnets() GetVpcV2ExternalSubnetArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2ExternalSubnet { return v.ExternalSubnets }).(GetVpcV2ExternalSubnetArrayOutput)
}

// CIDR blocks from the VPC which can talk externally without performing NAT. This is applicable when connecting to external subnets which have disabled NAT.
func (o LookupVpcV2ResultOutput) ExternallyRoutablePrefixes() GetVpcV2ExternallyRoutablePrefixArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2ExternallyRoutablePrefix { return v.ExternallyRoutablePrefixes }).(GetVpcV2ExternallyRoutablePrefixArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupVpcV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
func (o LookupVpcV2ResultOutput) Links() GetVpcV2LinkArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2Link { return v.Links }).(GetVpcV2LinkArrayOutput)
}

// Metadata associated with this resource.
func (o LookupVpcV2ResultOutput) Metadatas() GetVpcV2MetadataArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2Metadata { return v.Metadatas }).(GetVpcV2MetadataArrayOutput)
}

// Name of the VPC.
func (o LookupVpcV2ResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.Name }).(pulumi.StringOutput)
}

// List of IP Addresses used for SNAT.
func (o LookupVpcV2ResultOutput) SnatIps() GetVpcV2SnatIpArrayOutput {
	return o.ApplyT(func(v LookupVpcV2Result) []GetVpcV2SnatIp { return v.SnatIps }).(GetVpcV2SnatIpArrayOutput)
}

// A globally unique identifier that represents the tenant that owns this entity.
func (o LookupVpcV2ResultOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.TenantId }).(pulumi.StringOutput)
}

// Type of VPC.
func (o LookupVpcV2ResultOutput) VpcType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupVpcV2Result) string { return v.VpcType }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupVpcV2ResultOutput{})
}
