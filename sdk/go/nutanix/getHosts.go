// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a list of hosts
func GetHosts(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetHostsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetHostsResult
	err := ctx.Invoke("nutanix:index/getHosts:getHosts", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getHosts.
type GetHostsResult struct {
	// The API version.
	ApiVersion string `pulumi:"apiVersion"`
	// List of Hosts
	Entities []GetHostsEntity `pulumi:"entities"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}

func GetHostsOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetHostsResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetHostsResultOutput, error) {
		options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
		return ctx.InvokeOutput("nutanix:index/getHosts:getHosts", nil, GetHostsResultOutput{}, options).(GetHostsResultOutput), nil
	}).(GetHostsResultOutput)
}

// A collection of values returned by getHosts.
type GetHostsResultOutput struct{ *pulumi.OutputState }

func (GetHostsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetHostsResult)(nil)).Elem()
}

func (o GetHostsResultOutput) ToGetHostsResultOutput() GetHostsResultOutput {
	return o
}

func (o GetHostsResultOutput) ToGetHostsResultOutputWithContext(ctx context.Context) GetHostsResultOutput {
	return o
}

// The API version.
func (o GetHostsResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v GetHostsResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// List of Hosts
func (o GetHostsResultOutput) Entities() GetHostsEntityArrayOutput {
	return o.ApplyT(func(v GetHostsResult) []GetHostsEntity { return v.Entities }).(GetHostsEntityArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetHostsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetHostsResult) string { return v.Id }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetHostsResultOutput{})
}
