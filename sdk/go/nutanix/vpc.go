// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides Nutanix resource to create VPC.
//
// ## Example Usage
// ### vpc creation with external subnet name
//
// ```go
// package main
//
// import (
// 	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := nutanix.NewVpc(ctx, "vpc", &nutanix.VpcArgs{
// 			CommonDomainNameServerIpLists: VpcCommonDomainNameServerIpListArray{
// 				&VpcCommonDomainNameServerIpListArgs{
// 					Ip: pulumi.String("8.8.8.8"),
// 				},
// 				&VpcCommonDomainNameServerIpListArgs{
// 					Ip: pulumi.String("8.8.8.9"),
// 				},
// 			},
// 			ExternalSubnetReferenceNames: pulumi.StringArray{
// 				pulumi.String("test-Ext1"),
// 				pulumi.String("test-ext2"),
// 			},
// 			ExternallyRoutablePrefixLists: VpcExternallyRoutablePrefixListArray{
// 				&VpcExternallyRoutablePrefixListArgs{
// 					Ip:           pulumi.String("192.43.0.0"),
// 					PrefixLength: pulumi.Int(16),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ### vpc creation with external subnet uuid
//
// ```go
// package main
//
// import (
// 	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := nutanix.NewVpc(ctx, "vpc", &nutanix.VpcArgs{
// 			CommonDomainNameServerIpLists: VpcCommonDomainNameServerIpListArray{
// 				&VpcCommonDomainNameServerIpListArgs{
// 					Ip: pulumi.String("8.8.8.8"),
// 				},
// 			},
// 			ExternalSubnetReferenceUuids: pulumi.StringArray{
// 				pulumi.String("<subnet_uuid>"),
// 			},
// 			ExternallyRoutablePrefixLists: VpcExternallyRoutablePrefixListArray{
// 				&VpcExternallyRoutablePrefixListArgs{
// 					Ip:           pulumi.String("192.43.0.0"),
// 					PrefixLength: pulumi.Int(16),
// 				},
// 				&VpcExternallyRoutablePrefixListArgs{
// 					Ip:           pulumi.String("192.42.0.0"),
// 					PrefixLength: pulumi.Int(16),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Vpc struct {
	pulumi.CustomResourceState

	// The version of the API.
	ApiVersion pulumi.StringOutput `pulumi:"apiVersion"`
	// List of domain name server IPs.
	CommonDomainNameServerIpLists VpcCommonDomainNameServerIpListArrayOutput `pulumi:"commonDomainNameServerIpLists"`
	// Status of List of external subnets attached to this VPC
	ExternalSubnetListStatuses VpcExternalSubnetListStatusArrayOutput `pulumi:"externalSubnetListStatuses"`
	// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
	ExternalSubnetReferenceNames pulumi.StringArrayOutput `pulumi:"externalSubnetReferenceNames"`
	// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
	ExternalSubnetReferenceUuids pulumi.StringArrayOutput `pulumi:"externalSubnetReferenceUuids"`
	// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
	ExternallyRoutablePrefixLists VpcExternallyRoutablePrefixListArrayOutput `pulumi:"externallyRoutablePrefixLists"`
	// The vpc kind metadata.
	Metadata pulumi.StringMapOutput `pulumi:"metadata"`
	// The name for the VPC.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewVpc registers a new resource with the given unique name, arguments, and options.
func NewVpc(ctx *pulumi.Context,
	name string, args *VpcArgs, opts ...pulumi.ResourceOption) (*Vpc, error) {
	if args == nil {
		args = &VpcArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource Vpc
	err := ctx.RegisterResource("nutanix:index/vpc:Vpc", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpc gets an existing Vpc resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpc(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpcState, opts ...pulumi.ResourceOption) (*Vpc, error) {
	var resource Vpc
	err := ctx.ReadResource("nutanix:index/vpc:Vpc", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Vpc resources.
type vpcState struct {
	// The version of the API.
	ApiVersion *string `pulumi:"apiVersion"`
	// List of domain name server IPs.
	CommonDomainNameServerIpLists []VpcCommonDomainNameServerIpList `pulumi:"commonDomainNameServerIpLists"`
	// Status of List of external subnets attached to this VPC
	ExternalSubnetListStatuses []VpcExternalSubnetListStatus `pulumi:"externalSubnetListStatuses"`
	// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
	ExternalSubnetReferenceNames []string `pulumi:"externalSubnetReferenceNames"`
	// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
	ExternalSubnetReferenceUuids []string `pulumi:"externalSubnetReferenceUuids"`
	// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
	ExternallyRoutablePrefixLists []VpcExternallyRoutablePrefixList `pulumi:"externallyRoutablePrefixLists"`
	// The vpc kind metadata.
	Metadata map[string]string `pulumi:"metadata"`
	// The name for the VPC.
	Name *string `pulumi:"name"`
}

type VpcState struct {
	// The version of the API.
	ApiVersion pulumi.StringPtrInput
	// List of domain name server IPs.
	CommonDomainNameServerIpLists VpcCommonDomainNameServerIpListArrayInput
	// Status of List of external subnets attached to this VPC
	ExternalSubnetListStatuses VpcExternalSubnetListStatusArrayInput
	// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
	ExternalSubnetReferenceNames pulumi.StringArrayInput
	// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
	ExternalSubnetReferenceUuids pulumi.StringArrayInput
	// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
	ExternallyRoutablePrefixLists VpcExternallyRoutablePrefixListArrayInput
	// The vpc kind metadata.
	Metadata pulumi.StringMapInput
	// The name for the VPC.
	Name pulumi.StringPtrInput
}

func (VpcState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcState)(nil)).Elem()
}

type vpcArgs struct {
	// The version of the API.
	ApiVersion *string `pulumi:"apiVersion"`
	// List of domain name server IPs.
	CommonDomainNameServerIpLists []VpcCommonDomainNameServerIpList `pulumi:"commonDomainNameServerIpLists"`
	// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
	ExternalSubnetReferenceNames []string `pulumi:"externalSubnetReferenceNames"`
	// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
	ExternalSubnetReferenceUuids []string `pulumi:"externalSubnetReferenceUuids"`
	// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
	ExternallyRoutablePrefixLists []VpcExternallyRoutablePrefixList `pulumi:"externallyRoutablePrefixLists"`
	// The name for the VPC.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a Vpc resource.
type VpcArgs struct {
	// The version of the API.
	ApiVersion pulumi.StringPtrInput
	// List of domain name server IPs.
	CommonDomainNameServerIpLists VpcCommonDomainNameServerIpListArrayInput
	// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
	ExternalSubnetReferenceNames pulumi.StringArrayInput
	// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
	ExternalSubnetReferenceUuids pulumi.StringArrayInput
	// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
	ExternallyRoutablePrefixLists VpcExternallyRoutablePrefixListArrayInput
	// The name for the VPC.
	Name pulumi.StringPtrInput
}

func (VpcArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcArgs)(nil)).Elem()
}

type VpcInput interface {
	pulumi.Input

	ToVpcOutput() VpcOutput
	ToVpcOutputWithContext(ctx context.Context) VpcOutput
}

func (*Vpc) ElementType() reflect.Type {
	return reflect.TypeOf((**Vpc)(nil)).Elem()
}

func (i *Vpc) ToVpcOutput() VpcOutput {
	return i.ToVpcOutputWithContext(context.Background())
}

func (i *Vpc) ToVpcOutputWithContext(ctx context.Context) VpcOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcOutput)
}

// VpcArrayInput is an input type that accepts VpcArray and VpcArrayOutput values.
// You can construct a concrete instance of `VpcArrayInput` via:
//
//          VpcArray{ VpcArgs{...} }
type VpcArrayInput interface {
	pulumi.Input

	ToVpcArrayOutput() VpcArrayOutput
	ToVpcArrayOutputWithContext(context.Context) VpcArrayOutput
}

type VpcArray []VpcInput

func (VpcArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Vpc)(nil)).Elem()
}

func (i VpcArray) ToVpcArrayOutput() VpcArrayOutput {
	return i.ToVpcArrayOutputWithContext(context.Background())
}

func (i VpcArray) ToVpcArrayOutputWithContext(ctx context.Context) VpcArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcArrayOutput)
}

// VpcMapInput is an input type that accepts VpcMap and VpcMapOutput values.
// You can construct a concrete instance of `VpcMapInput` via:
//
//          VpcMap{ "key": VpcArgs{...} }
type VpcMapInput interface {
	pulumi.Input

	ToVpcMapOutput() VpcMapOutput
	ToVpcMapOutputWithContext(context.Context) VpcMapOutput
}

type VpcMap map[string]VpcInput

func (VpcMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Vpc)(nil)).Elem()
}

func (i VpcMap) ToVpcMapOutput() VpcMapOutput {
	return i.ToVpcMapOutputWithContext(context.Background())
}

func (i VpcMap) ToVpcMapOutputWithContext(ctx context.Context) VpcMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VpcMapOutput)
}

type VpcOutput struct{ *pulumi.OutputState }

func (VpcOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Vpc)(nil)).Elem()
}

func (o VpcOutput) ToVpcOutput() VpcOutput {
	return o
}

func (o VpcOutput) ToVpcOutputWithContext(ctx context.Context) VpcOutput {
	return o
}

// The version of the API.
func (o VpcOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *Vpc) pulumi.StringOutput { return v.ApiVersion }).(pulumi.StringOutput)
}

// List of domain name server IPs.
func (o VpcOutput) CommonDomainNameServerIpLists() VpcCommonDomainNameServerIpListArrayOutput {
	return o.ApplyT(func(v *Vpc) VpcCommonDomainNameServerIpListArrayOutput { return v.CommonDomainNameServerIpLists }).(VpcCommonDomainNameServerIpListArrayOutput)
}

// Status of List of external subnets attached to this VPC
func (o VpcOutput) ExternalSubnetListStatuses() VpcExternalSubnetListStatusArrayOutput {
	return o.ApplyT(func(v *Vpc) VpcExternalSubnetListStatusArrayOutput { return v.ExternalSubnetListStatuses }).(VpcExternalSubnetListStatusArrayOutput)
}

// List of external subnets name attached to this VPC. Should not be used with external_subnet_reference_uuid.
func (o VpcOutput) ExternalSubnetReferenceNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Vpc) pulumi.StringArrayOutput { return v.ExternalSubnetReferenceNames }).(pulumi.StringArrayOutput)
}

// List of external subnets uuid attached to this VPC. Should not be used with external_subnet_reference_name.
func (o VpcOutput) ExternalSubnetReferenceUuids() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Vpc) pulumi.StringArrayOutput { return v.ExternalSubnetReferenceUuids }).(pulumi.StringArrayOutput)
}

// List Externally Routable IP Addresses. Required when external subnet with NoNAT is used.
func (o VpcOutput) ExternallyRoutablePrefixLists() VpcExternallyRoutablePrefixListArrayOutput {
	return o.ApplyT(func(v *Vpc) VpcExternallyRoutablePrefixListArrayOutput { return v.ExternallyRoutablePrefixLists }).(VpcExternallyRoutablePrefixListArrayOutput)
}

// The vpc kind metadata.
func (o VpcOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Vpc) pulumi.StringMapOutput { return v.Metadata }).(pulumi.StringMapOutput)
}

// The name for the VPC.
func (o VpcOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Vpc) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

type VpcArrayOutput struct{ *pulumi.OutputState }

func (VpcArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Vpc)(nil)).Elem()
}

func (o VpcArrayOutput) ToVpcArrayOutput() VpcArrayOutput {
	return o
}

func (o VpcArrayOutput) ToVpcArrayOutputWithContext(ctx context.Context) VpcArrayOutput {
	return o
}

func (o VpcArrayOutput) Index(i pulumi.IntInput) VpcOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Vpc {
		return vs[0].([]*Vpc)[vs[1].(int)]
	}).(VpcOutput)
}

type VpcMapOutput struct{ *pulumi.OutputState }

func (VpcMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Vpc)(nil)).Elem()
}

func (o VpcMapOutput) ToVpcMapOutput() VpcMapOutput {
	return o
}

func (o VpcMapOutput) ToVpcMapOutputWithContext(ctx context.Context) VpcMapOutput {
	return o
}

func (o VpcMapOutput) MapIndex(k pulumi.StringInput) VpcOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Vpc {
		return vs[0].(map[string]*Vpc)[vs[1].(string)]
	}).(VpcOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VpcInput)(nil)).Elem(), &Vpc{})
	pulumi.RegisterInputType(reflect.TypeOf((*VpcArrayInput)(nil)).Elem(), VpcArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*VpcMapInput)(nil)).Elem(), VpcMap{})
	pulumi.RegisterOutputType(VpcOutput{})
	pulumi.RegisterOutputType(VpcArrayOutput{})
	pulumi.RegisterOutputType(VpcMapOutput{})
}