// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describe a Nutanix Protection Rule and its values (if it has them).
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
//			protectionRuleTest, err := nutanix.NewProtectionRule(ctx, "protectionRuleTest", &nutanix.ProtectionRuleArgs{
//				Description: pulumi.String("test"),
//				OrderedAvailabilityZoneLists: nutanix.ProtectionRuleOrderedAvailabilityZoneListArray{
//					&nutanix.ProtectionRuleOrderedAvailabilityZoneListArgs{
//						AvailabilityZoneUrl: pulumi.String("ab788130-0820-4d07-a1b5-b0ba4d3a42asd"),
//					},
//				},
//				AvailabilityZoneConnectivityLists: nutanix.ProtectionRuleAvailabilityZoneConnectivityListArray{
//					&nutanix.ProtectionRuleAvailabilityZoneConnectivityListArgs{
//						SnapshotScheduleLists: nutanix.ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListArray{
//							&nutanix.ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListArgs{
//								RecoveryPointObjectiveSecs: pulumi.Int(3600),
//								SnapshotType:               pulumi.String("CRASH_CONSISTENT"),
//								LocalSnapshotRetentionPolicy: &nutanix.ProtectionRuleAvailabilityZoneConnectivityListSnapshotScheduleListLocalSnapshotRetentionPolicyArgs{
//									NumSnapshots: pulumi.Int(1),
//								},
//							},
//						},
//					},
//				},
//				CategoryFilter: &nutanix.ProtectionRuleCategoryFilterArgs{
//					Params: nutanix.ProtectionRuleCategoryFilterParamArray{
//						&nutanix.ProtectionRuleCategoryFilterParamArgs{
//							Name: pulumi.String("Environment"),
//							Values: pulumi.StringArray{
//								pulumi.String("Dev"),
//							},
//						},
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_ = nutanix.LookupProtectionRuleOutput(ctx, nutanix.GetProtectionRuleOutputArgs{
//				ProtectionRuleId: protectionRuleTest.ID(),
//			}, nil)
//			return nil
//		})
//	}
//
// ```
func LookupProtectionRule(ctx *pulumi.Context, args *LookupProtectionRuleArgs, opts ...pulumi.InvokeOption) (*LookupProtectionRuleResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupProtectionRuleResult
	err := ctx.Invoke("nutanix:index/getProtectionRule:getProtectionRule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProtectionRule.
type LookupProtectionRuleArgs struct {
	Categories []GetProtectionRuleCategory `pulumi:"categories"`
	// - (Required) The `id` of the protection rule.
	ProtectionRuleId   *string `pulumi:"protectionRuleId"`
	ProtectionRuleName *string `pulumi:"protectionRuleName"`
}

// A collection of values returned by getProtectionRule.
type LookupProtectionRuleResult struct {
	ApiVersion string `pulumi:"apiVersion"`
	// (Required) This encodes the datapipes between various availability zones and\nthe backup policy of the pipes.
	// * `availability_zone_connectivity_list.destination_availability_zone_index` - (Optional/Computed) Index of the availability zone.
	// * `availability_zone_connectivity_list.source_availability_zone_index` - (Optional/Computed) Index of the availability zone.
	// * `availability_zone_connectivity_list.snapshot_schedule_list` - (Optional/Computed) Snapshot schedules for the pair of the availability zones.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.recovery_point_objective_secs` - (Required) "A recovery point objective (RPO) is the maximum acceptable amount of data loss.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy` - (Optional/Computed) This describes the snapshot retention policy for this availability zone.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.num_snapshots` - (Optional/Computed) Number of snapshots need to be retained.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.rollup_retention_policy_multiple` - (Optional/Computed) Multiplier to 'snapshot_interval_type'.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.rollup_retention_policy_snapshot_interval_type` - (Optional/Computed)
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.auto_suspend_timeout_secs` - (Optional/Computed) Auto suspend timeout in case of connection failure between the sites.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.snapshot_type` - (Optional/Computed) Crash consistent or Application Consistent snapshot.
	// * `availability_zone_connectivity_list.snapshot_schedule_list.#.remote_snapshot_retention_policy` - (Optional/Computed) This describes the snapshot retention policy for this availability zone.
	AvailabilityZoneConnectivityLists []GetProtectionRuleAvailabilityZoneConnectivityList `pulumi:"availabilityZoneConnectivityLists"`
	Categories                        []GetProtectionRuleCategory                         `pulumi:"categories"`
	// (Optional/Computed)
	// * `category_filter.0.type` - (Optional/Computed) The type of the filter being used.
	// * `category_filter.0.kind_list` - (Optional/Computed) List of kinds associated with this filter.
	// * `category_filter.0.params` - (Optional/Computed) A list of category key and list of values.
	CategoryFilters []GetProtectionRuleCategoryFilter `pulumi:"categoryFilters"`
	// A description for protection rule.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id       string            `pulumi:"id"`
	Metadata map[string]string `pulumi:"metadata"`
	// (Optional) the name.
	Name string `pulumi:"name"`
	// (Required) A list of availability zones, each of which, receives a replica\nof the data for the entities protected by this protection rule.
	// * `ordered_availability_zone_list.#.cluster_uuid` - (Optional/Computed) UUID of specific cluster to which we will be replicating.
	// * `ordered_availability_zone_list.#.availability_zone_url` - (Optional/Computed) The FQDN or IP address of the availability zone.
	OrderedAvailabilityZoneLists []GetProtectionRuleOrderedAvailabilityZoneList `pulumi:"orderedAvailabilityZoneLists"`
	OwnerReferences              []GetProtectionRuleOwnerReference              `pulumi:"ownerReferences"`
	ProjectReferences            []GetProtectionRuleProjectReference            `pulumi:"projectReferences"`
	ProtectionRuleId             *string                                        `pulumi:"protectionRuleId"`
	ProtectionRuleName           *string                                        `pulumi:"protectionRuleName"`
	StartTime                    string                                         `pulumi:"startTime"`
	State                        string                                         `pulumi:"state"`
}

func LookupProtectionRuleOutput(ctx *pulumi.Context, args LookupProtectionRuleOutputArgs, opts ...pulumi.InvokeOption) LookupProtectionRuleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupProtectionRuleResult, error) {
			args := v.(LookupProtectionRuleArgs)
			r, err := LookupProtectionRule(ctx, &args, opts...)
			var s LookupProtectionRuleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupProtectionRuleResultOutput)
}

// A collection of arguments for invoking getProtectionRule.
type LookupProtectionRuleOutputArgs struct {
	Categories GetProtectionRuleCategoryArrayInput `pulumi:"categories"`
	// - (Required) The `id` of the protection rule.
	ProtectionRuleId   pulumi.StringPtrInput `pulumi:"protectionRuleId"`
	ProtectionRuleName pulumi.StringPtrInput `pulumi:"protectionRuleName"`
}

func (LookupProtectionRuleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProtectionRuleArgs)(nil)).Elem()
}

// A collection of values returned by getProtectionRule.
type LookupProtectionRuleResultOutput struct{ *pulumi.OutputState }

func (LookupProtectionRuleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProtectionRuleResult)(nil)).Elem()
}

func (o LookupProtectionRuleResultOutput) ToLookupProtectionRuleResultOutput() LookupProtectionRuleResultOutput {
	return o
}

func (o LookupProtectionRuleResultOutput) ToLookupProtectionRuleResultOutputWithContext(ctx context.Context) LookupProtectionRuleResultOutput {
	return o
}

func (o LookupProtectionRuleResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// (Required) This encodes the datapipes between various availability zones and\nthe backup policy of the pipes.
// * `availability_zone_connectivity_list.destination_availability_zone_index` - (Optional/Computed) Index of the availability zone.
// * `availability_zone_connectivity_list.source_availability_zone_index` - (Optional/Computed) Index of the availability zone.
// * `availability_zone_connectivity_list.snapshot_schedule_list` - (Optional/Computed) Snapshot schedules for the pair of the availability zones.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.recovery_point_objective_secs` - (Required) "A recovery point objective (RPO) is the maximum acceptable amount of data loss.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy` - (Optional/Computed) This describes the snapshot retention policy for this availability zone.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.num_snapshots` - (Optional/Computed) Number of snapshots need to be retained.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.rollup_retention_policy_multiple` - (Optional/Computed) Multiplier to 'snapshot_interval_type'.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.local_snapshot_retention_policy.0.rollup_retention_policy_snapshot_interval_type` - (Optional/Computed)
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.auto_suspend_timeout_secs` - (Optional/Computed) Auto suspend timeout in case of connection failure between the sites.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.snapshot_type` - (Optional/Computed) Crash consistent or Application Consistent snapshot.
// * `availability_zone_connectivity_list.snapshot_schedule_list.#.remote_snapshot_retention_policy` - (Optional/Computed) This describes the snapshot retention policy for this availability zone.
func (o LookupProtectionRuleResultOutput) AvailabilityZoneConnectivityLists() GetProtectionRuleAvailabilityZoneConnectivityListArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleAvailabilityZoneConnectivityList {
		return v.AvailabilityZoneConnectivityLists
	}).(GetProtectionRuleAvailabilityZoneConnectivityListArrayOutput)
}

func (o LookupProtectionRuleResultOutput) Categories() GetProtectionRuleCategoryArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleCategory { return v.Categories }).(GetProtectionRuleCategoryArrayOutput)
}

// (Optional/Computed)
// * `category_filter.0.type` - (Optional/Computed) The type of the filter being used.
// * `category_filter.0.kind_list` - (Optional/Computed) List of kinds associated with this filter.
// * `category_filter.0.params` - (Optional/Computed) A list of category key and list of values.
func (o LookupProtectionRuleResultOutput) CategoryFilters() GetProtectionRuleCategoryFilterArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleCategoryFilter { return v.CategoryFilters }).(GetProtectionRuleCategoryFilterArrayOutput)
}

// A description for protection rule.
func (o LookupProtectionRuleResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.Description }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupProtectionRuleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupProtectionRuleResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

// (Optional) the name.
func (o LookupProtectionRuleResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.Name }).(pulumi.StringOutput)
}

// (Required) A list of availability zones, each of which, receives a replica\nof the data for the entities protected by this protection rule.
// * `ordered_availability_zone_list.#.cluster_uuid` - (Optional/Computed) UUID of specific cluster to which we will be replicating.
// * `ordered_availability_zone_list.#.availability_zone_url` - (Optional/Computed) The FQDN or IP address of the availability zone.
func (o LookupProtectionRuleResultOutput) OrderedAvailabilityZoneLists() GetProtectionRuleOrderedAvailabilityZoneListArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleOrderedAvailabilityZoneList {
		return v.OrderedAvailabilityZoneLists
	}).(GetProtectionRuleOrderedAvailabilityZoneListArrayOutput)
}

func (o LookupProtectionRuleResultOutput) OwnerReferences() GetProtectionRuleOwnerReferenceArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleOwnerReference { return v.OwnerReferences }).(GetProtectionRuleOwnerReferenceArrayOutput)
}

func (o LookupProtectionRuleResultOutput) ProjectReferences() GetProtectionRuleProjectReferenceArrayOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) []GetProtectionRuleProjectReference { return v.ProjectReferences }).(GetProtectionRuleProjectReferenceArrayOutput)
}

func (o LookupProtectionRuleResultOutput) ProtectionRuleId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) *string { return v.ProtectionRuleId }).(pulumi.StringPtrOutput)
}

func (o LookupProtectionRuleResultOutput) ProtectionRuleName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) *string { return v.ProtectionRuleName }).(pulumi.StringPtrOutput)
}

func (o LookupProtectionRuleResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func (o LookupProtectionRuleResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProtectionRuleResult) string { return v.State }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupProtectionRuleResultOutput{})
}
