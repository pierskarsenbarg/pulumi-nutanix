// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

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
// 	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi-nutanix/sdk/go/nutanix"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		subnet, err := nutanix.NewSubnet(ctx, "subnet", &nutanix.SubnetArgs{
// 			ClusterUuid:      pulumi.String("<YOUR_CLUSTER_ID>"),
// 			Description:      pulumi.String("Description of my unit test VLAN"),
// 			VlanId:           pulumi.Int(31),
// 			SubnetType:       pulumi.String("VLAN"),
// 			SubnetIp:         pulumi.String("10.250.140.0"),
// 			DefaultGatewayIp: pulumi.String("10.250.140.1"),
// 			PrefixLength:     pulumi.Int(24),
// 			DhcpOptions: pulumi.StringMap{
// 				"boot_file_name":   pulumi.String("bootfile"),
// 				"domain_name":      pulumi.String("nutanix"),
// 				"tftp_server_name": pulumi.String("10.250.140.200"),
// 			},
// 			DhcpDomainNameServerLists: pulumi.StringArray{
// 				pulumi.String("8.8.8.8"),
// 				pulumi.String("4.2.2.2"),
// 			},
// 			DhcpDomainSearchLists: pulumi.StringArray{
// 				pulumi.String("terraform.nutanix.com"),
// 				pulumi.String("terraform.unit.test.com"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		projectTest, err := nutanix.NewProject(ctx, "projectTest", &nutanix.ProjectArgs{
// 			Description: pulumi.String("This is my project"),
// 			Categories: ProjectCategoryArray{
// 				&ProjectCategoryArgs{
// 					Name:  pulumi.String("Environment"),
// 					Value: pulumi.String("Staging"),
// 				},
// 			},
// 			ResourceDomain: &ProjectResourceDomainArgs{
// 				Resources: ProjectResourceDomainResourceArray{
// 					&ProjectResourceDomainResourceArgs{
// 						Limit:        pulumi.Int(4),
// 						ResourceType: pulumi.String("STORAGE"),
// 					},
// 				},
// 			},
// 			DefaultSubnetReference: &ProjectDefaultSubnetReferenceArgs{
// 				Uuid: subnet.Metadata.ApplyT(func(metadata map[string]string) (string, error) {
// 					return metadata.Uuid, nil
// 				}).(pulumi.StringOutput),
// 			},
// 			ApiVersion: pulumi.String("3.1"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_ = nutanix.LookupProjectOutput(ctx, GetProjectOutputArgs{
// 			ProjectId: projectTest.ID(),
// 		}, nil)
// 		return nil
// 	})
// }
// ```
func LookupProject(ctx *pulumi.Context, args *LookupProjectArgs, opts ...pulumi.InvokeOption) (*LookupProjectResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupProjectResult
	err := ctx.Invoke("nutanix:index/getProject:getProject", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProject.
type LookupProjectArgs struct {
	Categories []GetProjectCategory `pulumi:"categories"`
	// List of directory service user groups. These groups are not managed by Nutanix.
	// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
	// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
	// * `external_user_group_reference_list.#.name` - The name of a user_group
	ExternalUserGroupReferenceLists []GetProjectExternalUserGroupReferenceList `pulumi:"externalUserGroupReferenceLists"`
	ProjectId                       *string                                    `pulumi:"projectId"`
	ProjectName                     *string                                    `pulumi:"projectName"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists []GetProjectSubnetReferenceList `pulumi:"subnetReferenceLists"`
	// List of users in the project.
	// * `user_reference_list.#.kind` - The kind name. Default value is `user`
	// * `user_reference_list.#.uuid` - The UUID of a user
	// * `user_reference_list.#.name` - The name of a user.
	UserReferenceLists []GetProjectUserReferenceList `pulumi:"userReferenceLists"`
}

// A collection of values returned by getProject.
type LookupProjectResult struct {
	// List of accounts associated with the project.
	// * `account_reference_list.#.kind` - The kind name. Default value is `account`
	// * `account_reference_list.#.uuid` - The UUID of an account.
	// * `account_reference_list.#.name` - The name of an account.
	AccountReferenceLists []GetProjectAccountReferenceList `pulumi:"accountReferenceLists"`
	ApiVersion            string                           `pulumi:"apiVersion"`
	Categories            []GetProjectCategory             `pulumi:"categories"`
	// Reference to a subnet.
	// * `default_subnet_reference.kind` - The kind name. Default value is `subnet`
	// * `default_subnet_reference.uuid` - The UUID of a subnet.
	// * `default_subnet_reference.name` - The name of a subnet.
	DefaultSubnetReference map[string]string `pulumi:"defaultSubnetReference"`
	Description            string            `pulumi:"description"`
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
	Name             string                     `pulumi:"name"`
	OwnerReference   map[string]string          `pulumi:"ownerReference"`
	ProjectId        *string                    `pulumi:"projectId"`
	ProjectName      *string                    `pulumi:"projectName"`
	ProjectReference map[string]string          `pulumi:"projectReference"`
	ResourceDomains  []GetProjectResourceDomain `pulumi:"resourceDomains"`
	State            string                     `pulumi:"state"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists []GetProjectSubnetReferenceList `pulumi:"subnetReferenceLists"`
	// List of users in the project.
	// * `user_reference_list.#.kind` - The kind name. Default value is `user`
	// * `user_reference_list.#.uuid` - The UUID of a user
	// * `user_reference_list.#.name` - The name of a user.
	UserReferenceLists []GetProjectUserReferenceList `pulumi:"userReferenceLists"`
}

func LookupProjectOutput(ctx *pulumi.Context, args LookupProjectOutputArgs, opts ...pulumi.InvokeOption) LookupProjectResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupProjectResult, error) {
			args := v.(LookupProjectArgs)
			r, err := LookupProject(ctx, &args, opts...)
			var s LookupProjectResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupProjectResultOutput)
}

// A collection of arguments for invoking getProject.
type LookupProjectOutputArgs struct {
	Categories GetProjectCategoryArrayInput `pulumi:"categories"`
	// List of directory service user groups. These groups are not managed by Nutanix.
	// * `external_user_group_reference_list.#.kind` - The kind name. Default value is `userGroup`
	// * `external_user_group_reference_list.#.uuid` - The UUID of a userGroup
	// * `external_user_group_reference_list.#.name` - The name of a user_group
	ExternalUserGroupReferenceLists GetProjectExternalUserGroupReferenceListArrayInput `pulumi:"externalUserGroupReferenceLists"`
	ProjectId                       pulumi.StringPtrInput                              `pulumi:"projectId"`
	ProjectName                     pulumi.StringPtrInput                              `pulumi:"projectName"`
	// List of subnets for the project.
	// * `subnet_reference_list.#.kind` - The kind name. Default value is `subnet`
	// * `subnet_reference_list.#.uuid` - The UUID of a subnet
	// * `subnet_reference_list.#.name` - The name of a subnet.
	SubnetReferenceLists GetProjectSubnetReferenceListArrayInput `pulumi:"subnetReferenceLists"`
	// List of users in the project.
	// * `user_reference_list.#.kind` - The kind name. Default value is `user`
	// * `user_reference_list.#.uuid` - The UUID of a user
	// * `user_reference_list.#.name` - The name of a user.
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

func (o LookupProjectResultOutput) ApiVersion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupProjectResult) string { return v.ApiVersion }).(pulumi.StringOutput)
}

func (o LookupProjectResultOutput) Categories() GetProjectCategoryArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectCategory { return v.Categories }).(GetProjectCategoryArrayOutput)
}

// Reference to a subnet.
// * `default_subnet_reference.kind` - The kind name. Default value is `subnet`
// * `default_subnet_reference.uuid` - The UUID of a subnet.
// * `default_subnet_reference.name` - The name of a subnet.
func (o LookupProjectResultOutput) DefaultSubnetReference() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupProjectResult) map[string]string { return v.DefaultSubnetReference }).(pulumi.StringMapOutput)
}

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

// List of users in the project.
// * `user_reference_list.#.kind` - The kind name. Default value is `user`
// * `user_reference_list.#.uuid` - The UUID of a user
// * `user_reference_list.#.name` - The name of a user.
func (o LookupProjectResultOutput) UserReferenceLists() GetProjectUserReferenceListArrayOutput {
	return o.ApplyT(func(v LookupProjectResult) []GetProjectUserReferenceList { return v.UserReferenceLists }).(GetProjectUserReferenceListArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupProjectResultOutput{})
}