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
	tfbridgetokens "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge/tokens"
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
		Publisher: "Piers Karsenbarg",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "https://raw.githubusercontent.com/pierskarsenbarg/pulumi-nutanix/main/docs/nutanix-logo.png",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "github://api.github.com/pierskarsenbarg/pulumi-nutanix",
		Description:       "A Pulumi package for creating and managing nutanix cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "nutanix", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://github.com/pierskarsenbarg/pulumi-nutanix",
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
			"nutanix_foundation_central_api_keys": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationCentralApiKeys"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_api_key.html.markdown",
				},
			},
			"nutanix_foundation_central_image_cluster": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "FoundationCentralImageCluster"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_image_cluster.html.markdown",
				},
			},
			"nutanix_karbon_worker_nodepool": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "KarbonWorkerNodepool"),
				Docs: &tfbridge.DocInfo{
					Source: "karbon_cluster_worker_nodepool.html.markdown",
				},
			},
			"nutanix_ndb_dbserver_vm": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbDbserverVm"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_dbservervm.html.markdown",
				},
			},
			"nutanix_ndb_linked_databases": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbLinkedDatabases"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_ndb_profile": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbProfile"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_profiles.html.markdown",
				},
			},
			"nutanix_ndb_register_dbserver": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbRegisterDbserver"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_dbservervm_register.html.markdown",
				},
			},
			"nutanix_ndb_scale_database": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbScaleDatabase"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_database_scale.html.markdown",
				},
			},
			"nutanix_ndb_software_version_profile": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbSoftwareVersionProfile"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_software_profile_version.html.markdown",
				},
			},
			"nutanix_ndb_stretched_vlan": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbStretchedVlan"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_stretched_vlans.html.markdown",
				},
			},
			"nutanix_ndb_tms_cluster": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "NdbTmsCluster"),
				Docs: &tfbridge.DocInfo{
					Source: "ndb_time_machine_cluster.html.markdown",
				},
			},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"nutanix_assert_helper": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAssertHelper"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
			"nutanix_foundation_central_api_keys": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralApiKeys"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_get_api_key.html.markdown",
				},
			},
			"nutanix_foundation_central_cluster_details": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralClusterDetails"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_imaged_cluster_details.html.markdown",
				},
			},
			"nutanix_foundation_central_imaged_clusters_list": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralImagedClustersList"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_list_all_imaged_clusters.html.markdown",
				},
			},
			"nutanix_foundation_central_imaged_nodes_list": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralImagedNodesList"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_list_all_imaged_nodes.html.markdown",
				},
			},
			"nutanix_foundation_central_list_api_keys": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getFoundationCentralListApiKeys"),
				Docs: &tfbridge.DocInfo{
					Source: "foundation_central_list_all_api_keys.html.markdown",
				},
			},
			"nutanix_ndb_tms_capability": {
				Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getNdbTmsCapability"),
				Docs: &tfbridge.DocInfo{
					Markdown: []byte(" "), // no upstream docs
				},
			},
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
			"nutanix_karbon_cluster_kubeconfig": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getKarbonClusterKubeConfig")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node":            "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime":            "^2.0.0",
				"@types/google-protobuf": "^3.15.12",
			},
			PackageName: "@pierskarsenbarg/nutanix",
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			// Overlay: &tfbridge.OverlayInfo{},
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

	prov.MustComputeTokens(tfbridgetokens.SingleModule("nutanix_", mainMod,
		tfbridgetokens.MakeStandard(mainPkg)))

	prov.SetAutonaming(255, "-")

	return prov
}
