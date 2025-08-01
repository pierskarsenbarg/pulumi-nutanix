// Code generated by pulumi-language-go DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describe a Nutanix Project and its values (if it has them).
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
//			subnet, err := nutanix.NewSubnet(ctx, "subnet", &nutanix.SubnetArgs{
//				ClusterUuid:      pulumi.String("<YOUR_CLUSTER_ID>"),
//				Description:      pulumi.String("Description of my unit test VLAN"),
//				VlanId:           pulumi.Int(31),
//				SubnetType:       pulumi.String("VLAN"),
//				SubnetIp:         pulumi.String("10.250.140.0"),
//				DefaultGatewayIp: pulumi.String("10.250.140.1"),
//				PrefixLength:     pulumi.Int(24),
//				DhcpOptions: pulumi.StringMap{
//					"boot_file_name":   pulumi.String("bootfile"),
//					"domain_name":      pulumi.String("nutanix"),
//					"tftp_server_name": pulumi.String("10.250.140.200"),
//				},
//				DhcpDomainNameServerLists: pulumi.StringArray{
//					pulumi.String("8.8.8.8"),
//					pulumi.String("4.2.2.2"),
//				},
//				DhcpDomainSearchLists: pulumi.StringArray{
//					pulumi.String("terraform.nutanix.com"),
//					pulumi.String("terraform.unit.test.com"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			projectTest, err := nutanix.NewProject(ctx, "projectTest", &nutanix.ProjectArgs{
//				Description: pulumi.String("This is my project"),
//				Categories: nutanix.ProjectCategoryArray{
//					&nutanix.ProjectCategoryArgs{
//						Name:  pulumi.String("Environment"),
//						Value: pulumi.String("Staging"),
//					},
//				},
//				ResourceDomain: &nutanix.ProjectResourceDomainArgs{
//					Resources: nutanix.ProjectResourceDomainResourceArray{
//						&nutanix.ProjectResourceDomainResourceArgs{
//							Limit:        pulumi.Int(4),
//							ResourceType: pulumi.String("STORAGE"),
//						},
//					},
//				},
//				DefaultSubnetReference: &nutanix.ProjectDefaultSubnetReferenceArgs{
//					Uuid: subnet.Metadata.ApplyT(func(metadata map[string]string) (string, error) {
//						return metadata.Uuid, nil
//					}).(pulumi.StringOutput),
//				},
//				ApiVersion: pulumi.String("3.1"),
//			})
//			if err != nil {
//				return err
//			}
//			_ = nutanix.LookupProjectOutput(ctx, nutanix.GetProjectOutputArgs{
//				ProjectId: projectTest.ID(),
//			}, nil)
//			return nil
//		})
//	}
//
// ```
func LookupProject(ctx *pulumi.Context, args *LookupProjectArgs, opts ...pulumi.InvokeOption) (*LookupProjectResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupProjectResult
	err := ctx.Invoke("nutanix:index/getProject:getProject", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProject.
type LookupProjectArgs struct {
	// - (Optional) The category values represented as a dictionary of key > list of values.
	Categories []GetProjectCategory `pulumi:"categories"`
	// List of directory service user groups. These groups are not managed by Nutanix.
	// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
	// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
	// * `external_user_group_reference_list.#.name` - The name of a user_group
	ExternalUserGroupReferenceLists []GetProjectExternalUserGroupReferenceList `pulumi:"externalUserGroupReferenceLists"`
	// - (Required) The `id` of the project.
	ProjectId   *string `pulumi:"projectId"`
	ProjectName *string `pulumi:"projectName"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists []GetProjectSubnetReferenceList `pulumi:"subnetReferenceLists"`
	// List of Reference of users.
	UserReferenceLists []GetProjectUserReferenceList `pulumi:"userReferenceLists"`
}

// A collection of values returned by getProject.
type LookupProjectResult struct {
	// List of accounts associated with the project.
	// * `account_reference_list.#.kind` - The kind name. Default value is `account`
	// * `account_reference_list.#.uuid` - The UUID of an account.
	// * `account_reference_list.#.name` - The name of an account.
	AccountReferenceLists []GetProjectAccountReferenceList `pulumi:"accountReferenceLists"`
	Acps                  []GetProjectAcp                  `pulumi:"acps"`
	ApiVersion            string                           `pulumi:"apiVersion"`
	// - (Optional) The category values represented as a dictionary of key > list of values.
	Categories []GetProjectCategory `pulumi:"categories"`
	// (Optional/Computed) List of clusters associated with the project..
	// * `cluster_reference_list.#.kind` - (Optional) The kind name. Default value is `cluster`
	// * `cluster_reference_list.#.uuid` - (Required) The UUID of a cluster
	// * `cluster_reference_list.#.name` - (Optional/Computed) The name of a cluster.
	ClusterReferenceLists []GetProjectClusterReferenceList `pulumi:"clusterReferenceLists"`
	// (Optional/Computed) Reference to a environment.
	DefaultEnvironmentReferences []GetProjectDefaultEnvironmentReference `pulumi:"defaultEnvironmentReferences"`
	// Reference to a subnet.
	DefaultSubnetReference map[string]string `pulumi:"defaultSubnetReference"`
	// Description of ACP
	Description string `pulumi:"description"`
	// List of environments associated with the project.
	// * `environment_reference_list.#.kind` - The kind name. Default value is `environment`
	// * `environment_reference_list.#.uuid` - The UUID of an environment.
	// * `environment_reference_list.#.name` - The name of an environment.
	EnvironmentReferenceLists []GetProjectEnvironmentReferenceList `pulumi:"environmentReferenceLists"`
	// List of external networks associated with the project.
	// * `external_network_list.#.uuid` - The UUID of a network.
	// * `external_network_list.#.name` - The name of a network.
	ExternalNetworkLists []GetProjectExternalNetworkList `pulumi:"externalNetworkLists"`
	// List of directory service user groups. These groups are not managed by Nutanix.
	// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
	// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
	// * `external_user_group_reference_list.#.name` - The name of a user_group
	ExternalUserGroupReferenceLists []GetProjectExternalUserGroupReferenceList `pulumi:"externalUserGroupReferenceLists"`
	// The provider-assigned unique ID for this managed resource.
	Id        string            `pulumi:"id"`
	IsDefault bool              `pulumi:"isDefault"`
	Metadata  map[string]string `pulumi:"metadata"`
	// the name.
	Name             string            `pulumi:"name"`
	OwnerReference   map[string]string `pulumi:"ownerReference"`
	ProjectId        *string           `pulumi:"projectId"`
	ProjectName      *string           `pulumi:"projectName"`
	ProjectReference map[string]string `pulumi:"projectReference"`
	// The status for a resource domain (limits and values)
	ResourceDomains []GetProjectResourceDomain `pulumi:"resourceDomains"`
	State           string                     `pulumi:"state"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists []GetProjectSubnetReferenceList `pulumi:"subnetReferenceLists"`
	// (Optional/Computed) List of tunnels associated with the project.
	// * `tunnel_reference_list.#.kind` - (Optional) The kind name. Default value is `tunnel`
	// * `tunnel_reference_list.#.uuid` - (Required) The UUID of a tunnel
	// * `tunnel_reference_list.#.name` - (Optional/Computed) The name of a tunnel.
	TunnelReferenceLists []GetProjectTunnelReferenceList `pulumi:"tunnelReferenceLists"`
	// List of Reference of users.
	UserReferenceLists []GetProjectUserReferenceList `pulumi:"userReferenceLists"`
	// (Optional/Computed) List of VPCs associated with the project..
	// * `vpc_reference_list.#.kind` - (Optional) The kind name. Default value is `vpc`
	// * `vpc_reference_list.#.uuid` - (Required) The UUID of a vpc
	// * `vpc_reference_list.#.name` - (Optional/Computed) The name of a vpc.
	VpcReferenceLists []GetProjectVpcReferenceList `pulumi:"vpcReferenceLists"`
}

func LookupProjectOutput(ctx *pulumi.Context, args LookupProjectOutputArgs, opts ...pulumi.InvokeOption) LookupProjectResultOutput {
	return pulumi.ToOutputWithContext(ctx.Context(), args).
		ApplyT(func(v interface{}) (LookupProjectResultOutput, error) {
			args := v.(LookupProjectArgs)
			options := pulumi.InvokeOutputOptions{InvokeOptions: internal.PkgInvokeDefaultOpts(opts)}
			return ctx.InvokeOutput("nutanix:index/getProject:getProject", args, LookupProjectResultOutput{}, options).(LookupProjectResultOutput), nil
		}).(LookupProjectResultOutput)
}

// A collection of arguments for invoking getProject.
type LookupProjectOutputArgs struct {
	// - (Optional) The category values represented as a dictionary of key > list of values.
	Categories GetProjectCategoryArrayInput `pulumi:"categories"`
	// List of directory service user groups. These groups are not managed by Nutanix.
	// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
	// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
	// * `external_user_group_reference_list.#.name` - The name of a user_group
	ExternalUserGroupReferenceLists GetProjectExternalUserGroupReferenceListArrayInput `pulumi:"externalUserGroupReferenceLists"`
	// - (Required) The `id` of the project.
	ProjectId   pulumi.StringPtrInput `pulumi:"projectId"`
	ProjectName pulumi.StringPtrInput `pulumi:"projectName"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists GetProjectSubnetReferenceListArrayInput `pulumi:"subnetReferenceLists"`
	// List of Reference of users.
	UserReferenceLists GetProjectUserReferenceListArrayInput `pulumi:"userReferenceLists"`
}

func (LookupProjectOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProjectArgs)(nil)).Elem()
}

// A collection of values returned by getProject.
type LookupProjectResultOutput struct{ *pulumi.OutputState }

func (LookupProjectResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupProjectResult)(nil)).Elem()
}

func (o LookupProjectResultOutput) ToLookupProjectResultOutput() LookupProjectResultOutput {
	return o
}

func (o LookupProjectResultOutput) ToLookupProjectResultOutputWithContext(ctx context.Context) LookupProjectResultOutput {
	return o
}

// List of accounts associated with the project.
// * `account_reference_list.#.kind` - The kind name. Default value is `account`
// * `account_reference_list.#.uuid` - The UUID of an account.
// * `account_reference_list.#.name` - The name of an account.
func (o LookupProjectResultOutput) AccountReferenceLists() GetProjectAccountReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectAccountReferenceList { return v.AccountReferenceLists }).(GetProjectAccountReferenceListArrayOutput)
}

func (o LookupProjectResultOutput) Acps() GetProjectAcpArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectAcp { return v.Acps }).(GetProjectAcpArrayOutput)
}

func (o LookupProjectResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

// - (Optional) The category values represented as a dictionary of key > list of values.
func (o LookupProjectResultOutput) Categories() GetProjectCategoryArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectCategory { return v.Categories }).(GetProjectCategoryArrayOutput)
}

// (Optional/Computed) List of clusters associated with the project..
// * `cluster_reference_list.#.kind` - (Optional) The kind name. Default value is `cluster`
// * `cluster_reference_list.#.uuid` - (Required) The UUID of a cluster
// * `cluster_reference_list.#.name` - (Optional/Computed) The name of a cluster.
func (o LookupProjectResultOutput) ClusterReferenceLists() GetProjectClusterReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectClusterReferenceList { return v.ClusterReferenceLists }).(GetProjectClusterReferenceListArrayOutput)
}

// (Optional/Computed) Reference to a environment.
func (o LookupProjectResultOutput) DefaultEnvironmentReferences() GetProjectDefaultEnvironmentReferenceArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectDefaultEnvironmentReference {
		return v.DefaultEnvironmentReferences
	}).(GetProjectDefaultEnvironmentReferenceArrayOutput)
}

// Reference to a subnet.
func (o LookupProjectResultOutput) DefaultSubnetReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProjectResult) map[string]string { return v.DefaultSubnetReference }).(pulumi.StringMapOutput)
}

// Description of ACP
func (o LookupProjectResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.Description }).(pulumi.StringOutput)
}

// List of environments associated with the project.
// * `environment_reference_list.#.kind` - The kind name. Default value is `environment`
// * `environment_reference_list.#.uuid` - The UUID of an environment.
// * `environment_reference_list.#.name` - The name of an environment.
func (o LookupProjectResultOutput) EnvironmentReferenceLists() GetProjectEnvironmentReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectEnvironmentReferenceList { return v.EnvironmentReferenceLists }).(GetProjectEnvironmentReferenceListArrayOutput)
}

// List of external networks associated with the project.
// * `external_network_list.#.uuid` - The UUID of a network.
// * `external_network_list.#.name` - The name of a network.
func (o LookupProjectResultOutput) ExternalNetworkLists() GetProjectExternalNetworkListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectExternalNetworkList { return v.ExternalNetworkLists }).(GetProjectExternalNetworkListArrayOutput)
}

// List of directory service user groups. These groups are not managed by Nutanix.
// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
// * `external_user_group_reference_list.#.name` - The name of a user_group
func (o LookupProjectResultOutput) ExternalUserGroupReferenceLists() GetProjectExternalUserGroupReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectExternalUserGroupReferenceList {
		return v.ExternalUserGroupReferenceLists
	}).(GetProjectExternalUserGroupReferenceListArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupProjectResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupProjectResultOutput) IsDefault() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupProjectResult) bool { return v.IsDefault }).(pulumi.BoolOutput)
}

func (o LookupProjectResultOutput) Metadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProjectResult) map[string]string { return v.Metadata }).(pulumi.StringMapOutput)
}

// the name.
func (o LookupProjectResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.Name }).(pulumi.StringOutput)
}

func (o LookupProjectResultOutput) OwnerReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProjectResult) map[string]string { return v.OwnerReference }).(pulumi.StringMapOutput)
}

func (o LookupProjectResultOutput) ProjectId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProjectResult) *string { return v.ProjectId }).(pulumi.StringPtrOutput)
}

func (o LookupProjectResultOutput) ProjectName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupProjectResult) *string { return v.ProjectName }).(pulumi.StringPtrOutput)
}

func (o LookupProjectResultOutput) ProjectReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProjectResult) map[string]string { return v.ProjectReference }).(pulumi.StringMapOutput)
}

// The status for a resource domain (limits and values)
func (o LookupProjectResultOutput) ResourceDomains() GetProjectResourceDomainArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectResourceDomain { return v.ResourceDomains }).(GetProjectResourceDomainArrayOutput)
}

func (o LookupProjectResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.State }).(pulumi.StringOutput)
}

// List of subnets for the project.
// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
// * `subnet_reference_list.#.uuid` - The UUID of a subnet
// * `subnet_reference_list.#.name` - The name of a subnet.
func (o LookupProjectResultOutput) SubnetReferenceLists() GetProjectSubnetReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectSubnetReferenceList { return v.SubnetReferenceLists }).(GetProjectSubnetReferenceListArrayOutput)
}

// (Optional/Computed) List of tunnels associated with the project.
// * `tunnel_reference_list.#.kind` - (Optional) The kind name. Default value is `tunnel`
// * `tunnel_reference_list.#.uuid` - (Required) The UUID of a tunnel
// * `tunnel_reference_list.#.name` - (Optional/Computed) The name of a tunnel.
func (o LookupProjectResultOutput) TunnelReferenceLists() GetProjectTunnelReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectTunnelReferenceList { return v.TunnelReferenceLists }).(GetProjectTunnelReferenceListArrayOutput)
}

// List of Reference of users.
func (o LookupProjectResultOutput) UserReferenceLists() GetProjectUserReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectUserReferenceList { return v.UserReferenceLists }).(GetProjectUserReferenceListArrayOutput)
}

// (Optional/Computed) List of VPCs associated with the project..
// * `vpc_reference_list.#.kind` - (Optional) The kind name. Default value is `vpc`
// * `vpc_reference_list.#.uuid` - (Required) The UUID of a vpc
// * `vpc_reference_list.#.name` - (Optional/Computed) The name of a vpc.
func (o LookupProjectResultOutput) VpcReferenceLists() GetProjectVpcReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectVpcReferenceList { return v.VpcReferenceLists }).(GetProjectVpcReferenceListArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupProjectResultOutput{})
}
