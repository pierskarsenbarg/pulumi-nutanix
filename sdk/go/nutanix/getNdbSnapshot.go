// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes the snapshot present in Nutanix Database Service
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
//			_, err := nutanix.GetNdbSnapshot(ctx, &nutanix.GetNdbSnapshotArgs{
//				Filters: []nutanix.GetNdbSnapshotFilter{
//					{
//						LoadReplicatedChildSnapshots: pulumi.StringRef("true"),
//					},
//				},
//				SnapshotId: "{{ snapshot_id }}",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func GetNdbSnapshot(ctx *pulumi.Context, args *GetNdbSnapshotArgs, opts ...pulumi.InvokeOption) (*GetNdbSnapshotResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetNdbSnapshotResult
	err := ctx.Invoke("nutanix:index/getNdbSnapshot:getNdbSnapshot", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getNdbSnapshot.
type GetNdbSnapshotArgs struct {
	// Filters will fetch the snapshot details as per input
	Filters []GetNdbSnapshotFilter `pulumi:"filters"`
	// Snapshot ID to be given
	SnapshotId string `pulumi:"snapshotId"`
	// tags
	Tags []GetNdbSnapshotTag `pulumi:"tags"`
}

// A collection of values returned by getNdbSnapshot.
type GetNdbSnapshotResult struct {
	// App info version
	AppInfoVersion string `pulumi:"appInfoVersion"`
	// Applicable types
	ApplicableTypes []string `pulumi:"applicableTypes"`
	// database node id
	DatabaseNodeId string `pulumi:"databaseNodeId"`
	// database snapshot
	DatabaseSnapshot bool `pulumi:"databaseSnapshot"`
	// created date
	DateCreated string `pulumi:"dateCreated"`
	// modified date
	DateModified string `pulumi:"dateModified"`
	// dbserver id
	DbserverId string `pulumi:"dbserverId"`
	// dbserver ip
	DbserverIp string `pulumi:"dbserverIp"`
	// dbserver name
	DbserverName string `pulumi:"dbserverName"`
	// dbserver storage metadata version
	DbserverStorageMetadataVersion int `pulumi:"dbserverStorageMetadataVersion"`
	// description of snapshot
	Description string                 `pulumi:"description"`
	Filters     []GetNdbSnapshotFilter `pulumi:"filters"`
	// from timestamp
	FromTimestamp string `pulumi:"fromTimestamp"`
	// name of snapshot
	Id string `pulumi:"id"`
	// LCM config
	LcmConfigs []GetNdbSnapshotLcmConfig `pulumi:"lcmConfigs"`
	Name       string                    `pulumi:"name"`
	// nx cluster id
	NxClusterId string `pulumi:"nxClusterId"`
	// parent snapshot
	ParentSnapshot bool `pulumi:"parentSnapshot"`
	// parent snapshot id
	ParentSnapshotId string `pulumi:"parentSnapshotId"`
	// processed
	Processed bool `pulumi:"processed"`
	// properties
	Properties []GetNdbSnapshotProperty `pulumi:"properties"`
	// protection domain
	ProtectionDomainId string `pulumi:"protectionDomainId"`
	// replicated snapshots
	ReplicatedSnapshots    []string `pulumi:"replicatedSnapshots"`
	Santized               bool     `pulumi:"santized"`
	SantizedFromSnapshotId string   `pulumi:"santizedFromSnapshotId"`
	SantizedSnapshots      string   `pulumi:"santizedSnapshots"`
	// snapshot family
	SnapshotFamily string `pulumi:"snapshotFamily"`
	SnapshotId     string `pulumi:"snapshotId"`
	// snapshot size
	SnapshotSize float64 `pulumi:"snapshotSize"`
	// snapshot timeStamp
	SnapshotTimestamp string `pulumi:"snapshotTimestamp"`
	// snapshot timestamp date
	SnapshotTimestampDate int `pulumi:"snapshotTimestampDate"`
	// snapshot uuid
	SnapshotUuid string `pulumi:"snapshotUuid"`
	// software database snapshot
	SoftwareDatabaseSnapshot bool `pulumi:"softwareDatabaseSnapshot"`
	// software snapshot
	SoftwareSnapshot string `pulumi:"softwareSnapshot"`
	// software snapshot id
	SoftwareSnapshotId string `pulumi:"softwareSnapshotId"`
	// status
	Status string `pulumi:"status"`
	// tags
	Tags          []GetNdbSnapshotTag `pulumi:"tags"`
	TimeMachineId string              `pulumi:"timeMachineId"`
	// timezone
	Timezone string `pulumi:"timezone"`
	// to timestamp
	ToTimestamp string `pulumi:"toTimestamp"`
	// type
	Type string `pulumi:"type"`
}

func GetNdbSnapshotOutput(ctx *pulumi.Context, args GetNdbSnapshotOutputArgs, opts ...pulumi.InvokeOption) GetNdbSnapshotResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetNdbSnapshotResult, error) {
			args := v.(GetNdbSnapshotArgs)
			r, err := GetNdbSnapshot(ctx, &args, opts...)
			var s GetNdbSnapshotResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetNdbSnapshotResultOutput)
}

// A collection of arguments for invoking getNdbSnapshot.
type GetNdbSnapshotOutputArgs struct {
	// Filters will fetch the snapshot details as per input
	Filters GetNdbSnapshotFilterArrayInput `pulumi:"filters"`
	// Snapshot ID to be given
	SnapshotId pulumi.StringInput `pulumi:"snapshotId"`
	// tags
	Tags GetNdbSnapshotTagArrayInput `pulumi:"tags"`
}

func (GetNdbSnapshotOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNdbSnapshotArgs)(nil)).Elem()
}

// A collection of values returned by getNdbSnapshot.
type GetNdbSnapshotResultOutput struct{ *pulumi.OutputState }

func (GetNdbSnapshotResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetNdbSnapshotResult)(nil)).Elem()
}

func (o GetNdbSnapshotResultOutput) ToGetNdbSnapshotResultOutput() GetNdbSnapshotResultOutput {
	return o
}

func (o GetNdbSnapshotResultOutput) ToGetNdbSnapshotResultOutputWithContext(ctx context.Context) GetNdbSnapshotResultOutput {
	return o
}

// App info version
func (o GetNdbSnapshotResultOutput) AppInfoVersion() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.AppInfoVersion }).(pulumi.StringOutput)
}

// Applicable types
func (o GetNdbSnapshotResultOutput) ApplicableTypes() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []string { return v.ApplicableTypes }).(pulumi.StringArrayOutput)
}

// database node id
func (o GetNdbSnapshotResultOutput) DatabaseNodeId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DatabaseNodeId }).(pulumi.StringOutput)
}

// database snapshot
func (o GetNdbSnapshotResultOutput) DatabaseSnapshot() pulumi.BoolOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) bool { return v.DatabaseSnapshot }).(pulumi.BoolOutput)
}

// created date
func (o GetNdbSnapshotResultOutput) DateCreated() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DateCreated }).(pulumi.StringOutput)
}

// modified date
func (o GetNdbSnapshotResultOutput) DateModified() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DateModified }).(pulumi.StringOutput)
}

// dbserver id
func (o GetNdbSnapshotResultOutput) DbserverId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DbserverId }).(pulumi.StringOutput)
}

// dbserver ip
func (o GetNdbSnapshotResultOutput) DbserverIp() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DbserverIp }).(pulumi.StringOutput)
}

// dbserver name
func (o GetNdbSnapshotResultOutput) DbserverName() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.DbserverName }).(pulumi.StringOutput)
}

// dbserver storage metadata version
func (o GetNdbSnapshotResultOutput) DbserverStorageMetadataVersion() pulumi.IntOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) int { return v.DbserverStorageMetadataVersion }).(pulumi.IntOutput)
}

// description of snapshot
func (o GetNdbSnapshotResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o GetNdbSnapshotResultOutput) Filters() GetNdbSnapshotFilterArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []GetNdbSnapshotFilter { return v.Filters }).(GetNdbSnapshotFilterArrayOutput)
}

// from timestamp
func (o GetNdbSnapshotResultOutput) FromTimestamp() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.FromTimestamp }).(pulumi.StringOutput)
}

// name of snapshot
func (o GetNdbSnapshotResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Id }).(pulumi.StringOutput)
}

// LCM config
func (o GetNdbSnapshotResultOutput) LcmConfigs() GetNdbSnapshotLcmConfigArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []GetNdbSnapshotLcmConfig { return v.LcmConfigs }).(GetNdbSnapshotLcmConfigArrayOutput)
}

func (o GetNdbSnapshotResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Name }).(pulumi.StringOutput)
}

// nx cluster id
func (o GetNdbSnapshotResultOutput) NxClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.NxClusterId }).(pulumi.StringOutput)
}

// parent snapshot
func (o GetNdbSnapshotResultOutput) ParentSnapshot() pulumi.BoolOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) bool { return v.ParentSnapshot }).(pulumi.BoolOutput)
}

// parent snapshot id
func (o GetNdbSnapshotResultOutput) ParentSnapshotId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.ParentSnapshotId }).(pulumi.StringOutput)
}

// processed
func (o GetNdbSnapshotResultOutput) Processed() pulumi.BoolOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) bool { return v.Processed }).(pulumi.BoolOutput)
}

// properties
func (o GetNdbSnapshotResultOutput) Properties() GetNdbSnapshotPropertyArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []GetNdbSnapshotProperty { return v.Properties }).(GetNdbSnapshotPropertyArrayOutput)
}

// protection domain
func (o GetNdbSnapshotResultOutput) ProtectionDomainId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.ProtectionDomainId }).(pulumi.StringOutput)
}

// replicated snapshots
func (o GetNdbSnapshotResultOutput) ReplicatedSnapshots() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []string { return v.ReplicatedSnapshots }).(pulumi.StringArrayOutput)
}

func (o GetNdbSnapshotResultOutput) Santized() pulumi.BoolOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) bool { return v.Santized }).(pulumi.BoolOutput)
}

func (o GetNdbSnapshotResultOutput) SantizedFromSnapshotId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SantizedFromSnapshotId }).(pulumi.StringOutput)
}

func (o GetNdbSnapshotResultOutput) SantizedSnapshots() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SantizedSnapshots }).(pulumi.StringOutput)
}

// snapshot family
func (o GetNdbSnapshotResultOutput) SnapshotFamily() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SnapshotFamily }).(pulumi.StringOutput)
}

func (o GetNdbSnapshotResultOutput) SnapshotId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SnapshotId }).(pulumi.StringOutput)
}

// snapshot size
func (o GetNdbSnapshotResultOutput) SnapshotSize() pulumi.Float64Output {
	return o.ApplyT(func(v GetNdbSnapshotResult) float64 { return v.SnapshotSize }).(pulumi.Float64Output)
}

// snapshot timeStamp
func (o GetNdbSnapshotResultOutput) SnapshotTimestamp() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SnapshotTimestamp }).(pulumi.StringOutput)
}

// snapshot timestamp date
func (o GetNdbSnapshotResultOutput) SnapshotTimestampDate() pulumi.IntOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) int { return v.SnapshotTimestampDate }).(pulumi.IntOutput)
}

// snapshot uuid
func (o GetNdbSnapshotResultOutput) SnapshotUuid() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SnapshotUuid }).(pulumi.StringOutput)
}

// software database snapshot
func (o GetNdbSnapshotResultOutput) SoftwareDatabaseSnapshot() pulumi.BoolOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) bool { return v.SoftwareDatabaseSnapshot }).(pulumi.BoolOutput)
}

// software snapshot
func (o GetNdbSnapshotResultOutput) SoftwareSnapshot() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SoftwareSnapshot }).(pulumi.StringOutput)
}

// software snapshot id
func (o GetNdbSnapshotResultOutput) SoftwareSnapshotId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.SoftwareSnapshotId }).(pulumi.StringOutput)
}

// status
func (o GetNdbSnapshotResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Status }).(pulumi.StringOutput)
}

// tags
func (o GetNdbSnapshotResultOutput) Tags() GetNdbSnapshotTagArrayOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) []GetNdbSnapshotTag { return v.Tags }).(GetNdbSnapshotTagArrayOutput)
}

func (o GetNdbSnapshotResultOutput) TimeMachineId() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.TimeMachineId }).(pulumi.StringOutput)
}

// timezone
func (o GetNdbSnapshotResultOutput) Timezone() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Timezone }).(pulumi.StringOutput)
}

// to timestamp
func (o GetNdbSnapshotResultOutput) ToTimestamp() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.ToTimestamp }).(pulumi.StringOutput)
}

// type
func (o GetNdbSnapshotResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v GetNdbSnapshotResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetNdbSnapshotResultOutput{})
}