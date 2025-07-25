// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// List images owned by Prism Central along with the image details like name, description, type, etc. This operation supports filtering, sorting, selection & pagination.
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
//			_, err := nutanix.LookupImagesV2(ctx, &nutanix.LookupImagesV2Args{}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = nutanix.LookupImagesV2(ctx, &nutanix.LookupImagesV2Args{
//				Filter: pulumi.StringRef("startswith(name,'image_name')"),
//				Limit:  pulumi.IntRef(10),
//				Page:   pulumi.IntRef(0),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
//
// ## Images
//
// The `images` object is a list of all images. Each image has the following attributes:
//
// * `extId`: A globally unique identifier of an instance that is suitable for external consumption.
// * `name`: The user defined name of an image.
// * `description`: The user defined description of an image.
// * `type`: The type of an image.
// * `checksum`: The checksum of an image.
// * `sizeBytes`: The size in bytes of an image file.
// * `source`: The source of an image. It can be a VM disk or a URL.
// * `categoryExtIds`: List of category external identifiers for an image.
// * `clusterLocationExtIds`: List of cluster external identifiers where the image is located.
// * `createTime`: Create time of an image.
// * `lastUpdateTime`: Last update time of an image.
// * `ownerExtId`: External identifier of the owner of the image
// * `placementPolicyStatus`: Status of an image placement policy.
//
// ### source
// * `extId`: The external identifier of VM Disk.
// * `url`: The URL for creating an image.
// * `basicAuth`: Basic authentication credentials for image source HTTP/S URL.
// * `basic_auth.username`: Username for basic authentication.
// * `basic_auth.password`: Password for basic authentication.
//
// ### placementPolicyStatus
// * `placementPolicyExtId`: Image placement policy external identifier.
// * `complianceStatus`: Compliance status for a placement policy.
// * `enforcementMode`: Indicates whether the placement policy enforcement is ongoing or has failed.
// * `policyClusterExtIds`: List of cluster external identifiers of the image location for the enforced placement policy.
// * `enforcedClusterExtIds`: List of cluster external identifiers for the enforced placement policy.
// * `conflictingPolicyExtIds`: List of image placement policy external identifier that conflict with the current one.
//
// See detailed information in [Nutanix List Images V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Images)
func LookupImagesV2(ctx *pulumi.Context, args *LookupImagesV2Args, opts ...pulumi.InvokeOption) (*LookupImagesV2Result, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupImagesV2Result
	err := ctx.Invoke("nutanix:index/getImagesV2:getImagesV2", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getImagesV2.
type LookupImagesV2Args struct {
	// A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
	// - description
	// - name
	// - sizeBytes
	// - type
	Filter *string `pulumi:"filter"`
	// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
	Limit *int `pulumi:"limit"`
	// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
	// - description
	// - lastUpdateTime
	// - name
	// - sizeBytes
	// - type
	OrderBy *string `pulumi:"orderBy"`
	// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
	Page *int `pulumi:"page"`
	// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. The select can be applied to the following fields:
	// - categoryExtIds
	// - clusterLocationExtIds
	// - createTime
	// - description
	// - extId
	// - lastUpdateTime
	// - links
	// - name
	// - ownerExtId
	// - sizeBytes
	// - tenantId
	// - type
	Select *string `pulumi:"select"`
}

// A collection of values returned by getImagesV2.
type LookupImagesV2Result struct {
	Filter *string `pulumi:"filter"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// List of all images
	Images  []GetImagesV2Image `pulumi:"images"`
	Limit   *int               `pulumi:"limit"`
	OrderBy *string            `pulumi:"orderBy"`
	Page    *int               `pulumi:"page"`
	Select  *string            `pulumi:"select"`
}

func LookupImagesV2Output(ctx *pulumi.Context, args LookupImagesV2OutputArgs, opts ...pulumi.InvokeOption) LookupImagesV2ResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupImagesV2ResultOutput, error) {
			args := v.(LookupImagesV2Args)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getImagesV2:getImagesV2", args, LookupImagesV2ResultOutput{}, options).(LookupImagesV2ResultOutput), nil
		}).(LookupImagesV2ResultOutput)
}

// A collection of arguments for invoking getImagesV2.
type LookupImagesV2OutputArgs struct {
	// A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
	// - description
	// - name
	// - sizeBytes
	// - type
	Filter pulumi.StringPtrInput `pulumi:"filter"`
	// A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
	Limit pulumi.IntPtrInput `pulumi:"limit"`
	// A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
	// - description
	// - lastUpdateTime
	// - name
	// - sizeBytes
	// - type
	OrderBy pulumi.StringPtrInput `pulumi:"orderBy"`
	// A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
	Page pulumi.IntPtrInput `pulumi:"page"`
	// A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. The select can be applied to the following fields:
	// - categoryExtIds
	// - clusterLocationExtIds
	// - createTime
	// - description
	// - extId
	// - lastUpdateTime
	// - links
	// - name
	// - ownerExtId
	// - sizeBytes
	// - tenantId
	// - type
	Select pulumi.StringPtrInput `pulumi:"select"`
}

func (LookupImagesV2OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupImagesV2Args)(nil)).Elem()
}

// A collection of values returned by getImagesV2.
type LookupImagesV2ResultOutput struct{ *pulumi.OutputState }

func (LookupImagesV2ResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupImagesV2Result)(nil)).Elem()
}

func (o LookupImagesV2ResultOutput) ToLookupImagesV2ResultOutput() LookupImagesV2ResultOutput {
	return o
}

func (o LookupImagesV2ResultOutput) ToLookupImagesV2ResultOutputWithContext(ctx context.Context) LookupImagesV2ResultOutput {
	return o
}

func (o LookupImagesV2ResultOutput) Filter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupImagesV2Result) *string { return v.Filter }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupImagesV2ResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImagesV2Result) string { return v.Id }).(pulumi.StringOutput)
}

// List of all images
func (o LookupImagesV2ResultOutput) Images() GetImagesV2ImageArrayOutput {
	return o.ApplyT(func(v LookupImagesV2Result) []GetImagesV2Image { return v.Images }).(GetImagesV2ImageArrayOutput)
}

func (o LookupImagesV2ResultOutput) Limit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupImagesV2Result) *int { return v.Limit }).(pulumi.IntPtrOutput)
}

func (o LookupImagesV2ResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupImagesV2Result) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o LookupImagesV2ResultOutput) Page() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupImagesV2Result) *int { return v.Page }).(pulumi.IntPtrOutput)
}

func (o LookupImagesV2ResultOutput) Select() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupImagesV2Result) *string { return v.Select }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupImagesV2ResultOutput{})
}
