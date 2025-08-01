// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes Karbon Clusters
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
//			_, err := nutanix.GetKarbonClusters(ctx, map[string]interface{}{}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetKarbonClusters(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetKarbonClustersResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetKarbonClustersResult
	err := ctx.Invoke("nutanix:index/getKarbonClusters:getKarbonClusters", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getKarbonClusters.
type GetKarbonClustersResult struct {
	Clusters []GetKarbonClustersCluster `pulumi:"clusters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}

func GetKarbonClustersOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetKarbonClustersResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetKarbonClustersResultOutput, error) {
		options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
		return ctx.InvokeOutput("nutanix:index/getKarbonClusters:getKarbonClusters", nil, GetKarbonClustersResultOutput{}, options).(GetKarbonClustersResultOutput), nil
	}).(GetKarbonClustersResultOutput)
}

// A collection of values returned by getKarbonClusters.
type GetKarbonClustersResultOutput struct{ *pulumi.OutputState }

func (GetKarbonClustersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetKarbonClustersResult)(nil)).Elem()
}

func (o GetKarbonClustersResultOutput) ToGetKarbonClustersResultOutput() GetKarbonClustersResultOutput {
	return o
}

func (o GetKarbonClustersResultOutput) ToGetKarbonClustersResultOutputWithContext(ctx context.Context) GetKarbonClustersResultOutput {
	return o
}

func (o GetKarbonClustersResultOutput) Clusters() GetKarbonClustersClusterArrayOutput {
	return o.ApplyT(func(v GetKarbonClustersResult) []GetKarbonClustersCluster { return v.Clusters }).(GetKarbonClustersClusterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetKarbonClustersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetKarbonClustersResult) string { return v.Id }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetKarbonClustersResultOutput{})
}
