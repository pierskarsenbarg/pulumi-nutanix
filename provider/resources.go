// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package nutanix

import (
	"fmt"
	"path/filepath"

	"github.com/pierskarsenbarg/pulumi-nutanix/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"github.com/terraform-providers/terraform-provider-nutanix/nutanix"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "nutanix"
	// modules:
	mainMod = "index" // the nutanix module
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(nutanix.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "nutanix",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "Nutanix",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "Pulumi",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "https://github.com/pierskarsenbarg/pulumi-nutanix/releases/download/v${VERSION}",
		Description:       "A Pulumi package for creating and managing nutanix cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "nutanix", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://www.pulumi.com",
		Repository: "https://github.com/pierskarsenbarg/pulumi-nutanix",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			"nutanix_access_control_policy": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "AccessControlPolicy")},
			"nutanix_address_group":         {Tok: tfbridge.MakeResource(mainPkg, mainMod, "AddressGroup")},
			"nutanix_category_key":          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "CategoryKey")},
			"nutanix_category_value":        {Tok: tfbridge.MakeResource(mainPkg, mainMod, "CategoryValue")},
			"nutanix_floating_ip":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "FloatingIp")},
			"nutanix_foundation_central_api_keys": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationCentralApiKeys"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_image_cluster": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationCentralImageCluster")},
			"nutanix_foundation_image":                 {Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationImage")},
			"nutanix_foundation_image_nodes":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationImageNodes")},
			"nutanix_foundation_ipmi_config":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationIpmiConfig")},
			"nutanix_image":                            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Image")},
			"nutanix_karbon_cluster":                   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "KarbonCluster")},
			"nutanix_karbon_private_registry":          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "KarbonPrivateRegistry")},
			"nutanix_network_security_rule":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "NetworkSecurityRule")},
			"nutanix_pbr":                              {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Pbr")},
			"nutanix_project":                          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Project")},
			"nutanix_protection_rule":                  {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ProtectionRule")},
			"nutanix_recovery_plan":                    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "RecoveryPlan")},
			"nutanix_role":                             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Role")},
			"nutanix_service_group":                    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ServiceGroup")},
			"nutanix_static_routes":                    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "StaticRoutes")},
			"nutanix_subnet":                           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Subnet")},
			"nutanix_user":                             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "User")},
			"nutanix_virtual_machine":                  {Tok: tfbridge.MakeResource(mainPkg, mainMod, "VirtualMachine")},
			"nutanix_vpc":                              {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Vpc")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"nutanix_access_control_policies": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAccessControlPolicies")},
			"nutanix_access_control_policy":   {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAccessControlPolicy")},
			"nutanix_address_group":           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAddressGroup")},
			"nutanix_address_groups":          {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAddressGroups")},
			"nutanix_assert_helper": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAssertHelper"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_category_key": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getCategoryKey")},
			"nutanix_cluster":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getCluster")},
			"nutanix_clusters":     {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getClusters")},
			"nutanix_floating_ip":  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFloatingIp")},
			"nutanix_floating_ips": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFloatingIps")},
			"nutanix_foundation_central_api_keys": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralApiKeys"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_cluster_details": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralClusterDetails"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_imaged_clusters_list": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralImagedClustersList"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_imaged_node_details": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralImagedNodeDetails")},
			"nutanix_foundation_central_imaged_nodes_list": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralImagedNodesList"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_list_api_keys": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralListApiKeys"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_discover_nodes":       {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationDiscoverNodes")},
			"nutanix_foundation_hypervisor_isos":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationHypervisorIsos")},
			"nutanix_foundation_node_network_details": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationNodeNetworkDetails")},
			"nutanix_foundation_nos_packages":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationNodPackages")},
			"nutanix_host":                            {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getHost")},
			"nutanix_hosts":                           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getHosts")},
			"nutanix_image":                           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getImage")},
			"nutanix_karbon_cluster":                  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonCluster")},
			"nutanix_karbon_cluster_kubeconfig":       {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonClusterKubeConfig")},
			"nutanix_karbon_cluster_ssh":              {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonClusterSsh")},
			"nutanix_karbon_clusters":                 {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonClusters")},
			"nutanix_karbon_private_registries":       {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonPrivateRegistries")},
			"nutanix_karbon_private_registry":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonPrivateRegistry")},
			"nutanix_network_security_rule":           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getNetworkSecurityRule")},
			"nutanix_pbr":                             {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getPbr")},
			"nutanix_pbrs":                            {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getPbrs")},
			"nutanix_permission":                      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getPermission")},
			"nutanix_permissions":                     {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getPermissions")},
			"nutanix_project":                         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getProject")},
			"nutanix_projects":                        {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getProjects")},
			"nutanix_protection_rule":                 {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getProtectionRule")},
			"nutanix_protection_rules":                {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getProtectionRules")},
			"nutanix_recovery_plan":                   {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRecoveryPlan")},
			"nutanix_recovery_plans":                  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRecoveryPlans")},
			"nutanix_role":                            {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRole")},
			"nutanix_roles":                           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getRoles")},
			"nutanix_service_group": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getServiceGroup"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_service_groups": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getServiceGroups"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_static_routes":   {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getStaticRoutes")},
			"nutanix_subnet":          {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getSubnet")},
			"nutanix_subnets":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getSubnets")},
			"nutanix_user":            {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUser")},
			"nutanix_users":           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUsers")},
			"nutanix_user_group":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUserGroup")},
			"nutanix_user_groups":     {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getUserGroups")},
			"nutanix_virtual_machine": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getVirtualMachine")},
			"nutanix_vpc":             {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getVpc")},
			"nutanix_vpcs":            {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getVpcs")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@pierskarsenbarg/pulumi-nutanix",
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pierskarsenbarg/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "PiersKarsenbarg",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
