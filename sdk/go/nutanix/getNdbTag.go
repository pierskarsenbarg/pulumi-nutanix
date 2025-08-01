// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a tag in Nutanix Database Service
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
//			_, err := nutanix.LookupNdbTag(ctx, &nutanix.LookupNdbTagArgs{
//				Id: pulumi.StringRef("{{ tag id }}"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupNdbTag(ctx *pulumi.Context, args *LookupNdbTagArgs, opts ...pulumi.InvokeOption) (*LookupNdbTagResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupNdbTagResult
	err := ctx.Invoke("nutanix:index/getNdbTag:getNdbTag", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getNdbTag.
type LookupNdbTagArgs struct {
	// tag id. Conflicts with  name.
	Id *string `pulumi:"id"`
	// tag name. Conflicts with id.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getNdbTag.
type LookupNdbTagResult struct {
	// date created of the tag
	DateCreated string `pulumi:"dateCreated"`
	// modified date of tha tag
	DateModified string `pulumi:"dateModified"`
	// description for the tag
	Description string `pulumi:"description"`
	// entity for the tag to be associated with.
	EntityType string `pulumi:"entityType"`
	Id         string `pulumi:"id"`
	// name for the tag
	Name string `pulumi:"name"`
	// owner id of the tag
	Owner string `pulumi:"owner"`
	// tag value for entities.
	Required bool `pulumi:"required"`
	// Status of the tag
	Status string `pulumi:"status"`
	// value for the tag
	Values int `pulumi:"values"`
}

func LookupNdbTagOutput(ctx *pulumi.Context, args LookupNdbTagOutputArgs, opts ...pulumi.InvokeOption) LookupNdbTagResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupNdbTagResultOutput, error) {
			args := v.(LookupNdbTagArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getNdbTag:getNdbTag", args, LookupNdbTagResultOutput{}, options).(LookupNdbTagResultOutput), nil
		}).(LookupNdbTagResultOutput)
}

// A collection of arguments for invoking getNdbTag.
type LookupNdbTagOutputArgs struct {
	// tag id. Conflicts with  name.
	Id pulumi.StringPtrInput `pulumi:"id"`
	// tag name. Conflicts with id.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupNdbTagOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupNdbTagArgs)(nil)).Elem()
}

// A collection of values returned by getNdbTag.
type LookupNdbTagResultOutput struct{ *pulumi.OutputState }

func (LookupNdbTagResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupNdbTagResult)(nil)).Elem()
}

func (o LookupNdbTagResultOutput) ToLookupNdbTagResultOutput() LookupNdbTagResultOutput {
	return o
}

func (o LookupNdbTagResultOutput) ToLookupNdbTagResultOutputWithContext(ctx context.Context) LookupNdbTagResultOutput {
	return o
}

// date created of the tag
func (o LookupNdbTagResultOutput) DateCreated() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.DateCreated }).(pulumi.StringOutput)
}

// modified date of tha tag
func (o LookupNdbTagResultOutput) DateModified() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.DateModified }).(pulumi.StringOutput)
}

// description for the tag
func (o LookupNdbTagResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.Description }).(pulumi.StringOutput)
}

// entity for the tag to be associated with.
func (o LookupNdbTagResultOutput) EntityType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.EntityType }).(pulumi.StringOutput)
}

func (o LookupNdbTagResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.Id }).(pulumi.StringOutput)
}

// name for the tag
func (o LookupNdbTagResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.Name }).(pulumi.StringOutput)
}

// owner id of the tag
func (o LookupNdbTagResultOutput) Owner() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.Owner }).(pulumi.StringOutput)
}

// tag value for entities.
func (o LookupNdbTagResultOutput) Required() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupNdbTagResult) bool { return v.Required }).(pulumi.BoolOutput)
}

// Status of the tag
func (o LookupNdbTagResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupNdbTagResult) string { return v.Status }).(pulumi.StringOutput)
}

// value for the tag
func (o LookupNdbTagResultOutput) Values() pulumi.IntOutput {
	return o.ApplyT(func(v LookupNdbTagResult) int { return v.Values }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupNdbTagResultOutput{})
}
