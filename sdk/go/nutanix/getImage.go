// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a Image
func LookupImage(ctx *pulumi.Context, args *LookupImageArgs, opts ...pulumi.InvokeOption) (*LookupImageResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupImageResult
	err := ctx.Invoke("nutanix:index/getImage:getImage", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getImage.
type LookupImageArgs struct {
	Categories []GetImageCategory `pulumi:"categories"`
	ImageId    *string            `pulumi:"imageId"`
	ImageName  *string            `pulumi:"imageName"`
}

// A collection of values returned by getImage.
type LookupImageResult struct {
	ApiVersion                   string                                `pulumi:"apiVersion"`
	Architecture                 string                                `pulumi:"architecture"`
	AvailabilityZoneReference    map[string]string                     `pulumi:"availabilityZoneReference"`
	Categories                   []GetImageCategory                    `pulumi:"categories"`
	Checksum                     map[string]string                     `pulumi:"checksum"`
	ClusterName                  string                                `pulumi:"clusterName"`
	ClusterReferences            []GetImageClusterReference            `pulumi:"clusterReferences"`
	ClusterUuid                  string                                `pulumi:"clusterUuid"`
	CurrentClusterReferenceLists []GetImageCurrentClusterReferenceList `pulumi:"currentClusterReferenceLists"`
	Description                  string                                `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id                string            `pulumi:"id"`
	ImageId           *string           `pulumi:"imageId"`
	ImageName         *string           `pulumi:"imageName"`
	ImageType         string            `pulumi:"imageType"`
	Metadata          map[string]string `pulumi:"metadata"`
	Name              string            `pulumi:"name"`
	OwnerReference    map[string]string `pulumi:"ownerReference"`
	ProjectReference  map[string]string `pulumi:"projectReference"`
	RetrievalUriLists []string          `pulumi:"retrievalUriLists"`
	SizeBytes         int               `pulumi:"sizeBytes"`
	SourceUri         string            `pulumi:"sourceUri"`
	State             string            `pulumi:"state"`
	Version           map[string]string `pulumi:"version"`
}

func LookupImageOutput(ctx *pulumi.Context, args LookupImageOutputArgs, opts ...pulumi.InvokeOption) LookupImageResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupImageResult, error) {
			args := v.(LookupImageArgs)
			r, err := LookupImage(ctx, &args, opts...)
			var s LookupImageResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupImageResultOutput)
}

// A collection of arguments for invoking getImage.
type LookupImageOutputArgs struct {
	Categories GetImageCategoryArrayInput `pulumi:"categories"`
	ImageId    pulumi.StringPtrInput      `pulumi:"imageId"`
	ImageName  pulumi.StringPtrInput      `pulumi:"imageName"`
}

func (LookupImageOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupImageArgs)(nil)).Elem()
}

// A collection of values returned by getImage.
type LookupImageResultOutput struct{ *pulumi.OutputState }

func (LookupImageResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupImageResult)(nil)).Elem()
}

func (o LookupImageResultOutput) ToLookupImageResultOutput() LookupImageResultOutput {
	return o
}

func (o LookupImageResultOutput) ToLookupImageResultOutputWithContext(ctx context.Context) LookupImageResultOutput {
	return o
}

func (o LookupImageResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) Architecture() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.Architecture }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) AvailabilityZoneReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.AvailabilityZoneReference }).(pulumi.StringMapOutput)
}

func (o LookupImageResultOutput) Categories() GetImageCategoryArrayOutput {
	return o.ApplyT(func(v LookupImageResult) []GetImageCategory { return v.Categories }).(GetImageCategoryArrayOutput)
}

func (o LookupImageResultOutput) Checksum() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.Checksum }).(pulumi.StringMapOutput)
}

func (o LookupImageResultOutput) ClusterName() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.ClusterName }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) ClusterReferences() GetImageClusterReferenceArrayOutput {
	return o.ApplyT(func(v LookupImageResult) []GetImageClusterReference { return v.ClusterReferences }).(GetImageClusterReferenceArrayOutput)
}

func (o LookupImageResultOutput) ClusterUuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.ClusterUuid }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) CurrentClusterReferenceLists() GetImageCurrentClusterReferenceListArrayOutput {
	return o.ApplyT(func(v LookupImageResult) []GetImageCurrentClusterReferenceList { return v.CurrentClusterReferenceLists }).(GetImageCurrentClusterReferenceListArrayOutput)
}

func (o LookupImageResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupImageResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) ImageId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupImageResult) *string { return v.ImageId }).(pulumi.StringPtrOutput)
}

func (o LookupImageResultOutput) ImageName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupImageResult) *string { return v.ImageName }).(pulumi.StringPtrOutput)
}

func (o LookupImageResultOutput) ImageType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.ImageType }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

func (o LookupImageResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.OwnerReference }).(pulumi.StringMapOutput)
}

func (o LookupImageResultOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.ProjectReference }).(pulumi.StringMapOutput)
}

func (o LookupImageResultOutput) RetrievalUriLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupImageResult) []string { return v.RetrievalUriLists }).(pulumi.StringArrayOutput)
}

func (o LookupImageResultOutput) SizeBytes() pulumi.IntOutput {
	return o.ApplyT(func(v LookupImageResult) int { return v.SizeBytes }).(pulumi.IntOutput)
}

func (o LookupImageResultOutput) SourceUri() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.SourceUri }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupImageResult) string { return v.State }).(pulumi.StringOutput)
}

func (o LookupImageResultOutput) Version() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupImageResult) map[string]string { return v.Version }).(pulumi.StringMapOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupImageResultOutput{})
}