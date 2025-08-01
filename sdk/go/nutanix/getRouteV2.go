// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides Nutanix datasource Get Route for the specified {extId}.
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
//			_, err := nutanix.GetRouteV2(ctx, &nutanix.GetRouteV2Args{
//				ExtId:           "7f66e20f-67f4-473f-96bb-c4fcfd487f16",
//				RouteTableExtId: "a8fe48c4-f0d3-49c7-a017-efc30dd8fb2b",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetRouteV2(ctx *pulumi.Context, args *GetRouteV2Args, opts ...pulumi.InvokeOption) (*GetRouteV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRouteV2Result
	err := ctx.Invoke("nutanix:index/getRouteV2:getRouteV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRouteV2.
type GetRouteV2Args struct {
	// Route UUID.
	ExtId string `pulumi:"extId"`
	// Route table UUID
	RouteTableExtId string `pulumi:"routeTableExtId"`
}

// A collection of values returned by getRouteV2.
type GetRouteV2Result struct {
	// BGP session description.
	Description string `pulumi:"description"`
	// Destination IP Subnet Configuration.
	Destinations []GetRouteV2Destination `pulumi:"destinations"`
	// Route UUID
	ExtId string `pulumi:"extId"`
	// External routing domain associated with this route table.
	ExternalRoutingDomainReference string `pulumi:"externalRoutingDomainReference"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Indicates whether the route is active in the forwarding plane.
	IsActive bool `pulumi:"isActive"`
	// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
	Links []GetRouteV2Link `pulumi:"links"`
	// Metadata associated with this resource.
	Metadatas []GetRouteV2Metadata `pulumi:"metadatas"`
	// Route name.
	Name string `pulumi:"name"`
	// Route nexthop.
	NextHops []GetRouteV2NextHop `pulumi:"nextHops"`
	// Route priority. A higher value implies greater preference is assigned to the route.
	Priority        int    `pulumi:"priority"`
	RouteTableExtId string `pulumi:"routeTableExtId"`
	// Route table reference.
	RouteTableReference string `pulumi:"routeTableReference"`
	// Route type. Acceptable values are "STATIC", "LOCAL", "DYNAMIC"
	RouteType string `pulumi:"routeType"`
	// A globally unique identifier that represents the tenant that owns this entity
	TenantId string `pulumi:"tenantId"`
	// VPC reference.
	VpcReference string `pulumi:"vpcReference"`
}

func GetRouteV2Output(ctx *pulumi.Context, args GetRouteV2OutputArgs, opts ...pulumi.InvokeOption) GetRouteV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (GetRouteV2ResultOutput, error) {
			args := v.(GetRouteV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getRouteV2:getRouteV2", args, GetRouteV2ResultOutput{}, options).(GetRouteV2ResultOutput), nil
		}).(GetRouteV2ResultOutput)
}

// A collection of arguments for invoking getRouteV2.
type GetRouteV2OutputArgs struct {
	// Route UUID.
	ExtId pulumi.StringInput `pulumi:"extId"`
	// Route table UUID
	RouteTableExtId pulumi.StringInput `pulumi:"routeTableExtId"`
}

func (GetRouteV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRouteV2Args)(nil)).Elem()
}

// A collection of values returned by getRouteV2.
type GetRouteV2ResultOutput struct{ *pulumi.OutputState }

func (GetRouteV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRouteV2Result)(nil)).Elem()
}

func (o GetRouteV2ResultOutput) ToGetRouteV2ResultOutput() GetRouteV2ResultOutput {
	return o
}

func (o GetRouteV2ResultOutput) ToGetRouteV2ResultOutputWithContext(ctx context.Context) GetRouteV2ResultOutput {
	return o
}

// BGP session description.
func (o GetRouteV2ResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.Description }).(pulumi.StringOutput)
}

// Destination IP Subnet Configuration.
func (o GetRouteV2ResultOutput) Destinations() GetRouteV2DestinationArrayOutput {
	return o.ApplyT(func(v GetRouteV2Result) []GetRouteV2Destination { return v.Destinations }).(GetRouteV2DestinationArrayOutput)
}

// Route UUID
func (o GetRouteV2ResultOutput) ExtId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.ExtId }).(pulumi.StringOutput)
}

// External routing domain associated with this route table.
func (o GetRouteV2ResultOutput) ExternalRoutingDomainReference() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.ExternalRoutingDomainReference }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRouteV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// Indicates whether the route is active in the forwarding plane.
func (o GetRouteV2ResultOutput) IsActive() pulumi.BoolOutput {
	return o.ApplyT(func(v GetRouteV2Result) bool { return v.IsActive }).(pulumi.BoolOutput)
}

// A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
func (o GetRouteV2ResultOutput) Links() GetRouteV2LinkArrayOutput {
	return o.ApplyT(func(v GetRouteV2Result) []GetRouteV2Link { return v.Links }).(GetRouteV2LinkArrayOutput)
}

// Metadata associated with this resource.
func (o GetRouteV2ResultOutput) Metadatas() GetRouteV2MetadataArrayOutput {
	return o.ApplyT(func(v GetRouteV2Result) []GetRouteV2Metadata { return v.Metadatas }).(GetRouteV2MetadataArrayOutput)
}

// Route name.
func (o GetRouteV2ResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.Name }).(pulumi.StringOutput)
}

// Route nexthop.
func (o GetRouteV2ResultOutput) NextHops() GetRouteV2NextHopArrayOutput {
	return o.ApplyT(func(v GetRouteV2Result) []GetRouteV2NextHop { return v.NextHops }).(GetRouteV2NextHopArrayOutput)
}

// Route priority. A higher value implies greater preference is assigned to the route.
func (o GetRouteV2ResultOutput) Priority() pulumi.IntOutput {
	return o.ApplyT(func(v GetRouteV2Result) int { return v.Priority }).(pulumi.IntOutput)
}

func (o GetRouteV2ResultOutput) RouteTableExtId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.RouteTableExtId }).(pulumi.StringOutput)
}

// Route table reference.
func (o GetRouteV2ResultOutput) RouteTableReference() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.RouteTableReference }).(pulumi.StringOutput)
}

// Route type. Acceptable values are "STATIC", "LOCAL", "DYNAMIC"
func (o GetRouteV2ResultOutput) RouteType() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.RouteType }).(pulumi.StringOutput)
}

// A globally unique identifier that represents the tenant that owns this entity
func (o GetRouteV2ResultOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.TenantId }).(pulumi.StringOutput)
}

// VPC reference.
func (o GetRouteV2ResultOutput) VpcReference() pulumi.StringOutput {
	return o.ApplyT(func(v GetRouteV2Result) string { return v.VpcReference }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRouteV2ResultOutput{})
}
