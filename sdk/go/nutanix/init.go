// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "nutanix:index/accessControlPolicy:AccessControlPolicy":
		r = &AccessControlPolicy{}
	case "nutanix:index/addressGroup:AddressGroup":
		r = &AddressGroup{}
	case "nutanix:index/categoryKey:CategoryKey":
		r = &CategoryKey{}
	case "nutanix:index/categoryValue:CategoryValue":
		r = &CategoryValue{}
	case "nutanix:index/floatingIp:FloatingIp":
		r = &FloatingIp{}
	case "nutanix:index/foundationCentralApiKeys:FoundationCentralApiKeys":
		r = &FoundationCentralApiKeys{}
	case "nutanix:index/foundationCentralImageCluster:FoundationCentralImageCluster":
		r = &FoundationCentralImageCluster{}
	case "nutanix:index/foundationImage:FoundationImage":
		r = &FoundationImage{}
	case "nutanix:index/foundationImageNodes:FoundationImageNodes":
		r = &FoundationImageNodes{}
	case "nutanix:index/foundationIpmiConfig:FoundationIpmiConfig":
		r = &FoundationIpmiConfig{}
	case "nutanix:index/image:Image":
		r = &Image{}
	case "nutanix:index/karbonCluster:KarbonCluster":
		r = &KarbonCluster{}
	case "nutanix:index/karbonPrivateRegistry:KarbonPrivateRegistry":
		r = &KarbonPrivateRegistry{}
	case "nutanix:index/networkSecurityRule:NetworkSecurityRule":
		r = &NetworkSecurityRule{}
	case "nutanix:index/pbr:Pbr":
		r = &Pbr{}
	case "nutanix:index/project:Project":
		r = &Project{}
	case "nutanix:index/protectionRule:ProtectionRule":
		r = &ProtectionRule{}
	case "nutanix:index/recoveryPlan:RecoveryPlan":
		r = &RecoveryPlan{}
	case "nutanix:index/role:Role":
		r = &Role{}
	case "nutanix:index/serviceGroup:ServiceGroup":
		r = &ServiceGroup{}
	case "nutanix:index/staticRoutes:StaticRoutes":
		r = &StaticRoutes{}
	case "nutanix:index/subnet:Subnet":
		r = &Subnet{}
	case "nutanix:index/user:User":
		r = &User{}
	case "nutanix:index/virtualMachine:VirtualMachine":
		r = &VirtualMachine{}
	case "nutanix:index/vpc:Vpc":
		r = &Vpc{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

type pkg struct {
	version semver.Version
}

func (p *pkg) Version() semver.Version {
	return p.version
}

func (p *pkg) ConstructProvider(ctx *pulumi.Context, name, typ, urn string) (pulumi.ProviderResource, error) {
	if typ != "pulumi:providers:nutanix" {
		return nil, fmt.Errorf("unknown provider type: %s", typ)
	}

	r := &Provider{}
	err := ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return r, err
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/accessControlPolicy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/addressGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/categoryKey",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/categoryValue",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/floatingIp",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/foundationCentralApiKeys",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/foundationCentralImageCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/foundationImage",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/foundationImageNodes",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/foundationIpmiConfig",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/image",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/karbonCluster",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/karbonPrivateRegistry",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/networkSecurityRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/pbr",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/project",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/protectionRule",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/recoveryPlan",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/role",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/serviceGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/staticRoutes",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/subnet",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/user",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/virtualMachine",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nutanix",
		"index/vpc",
		&module{version},
	)
	pulumi.RegisterResourcePackage(
		"nutanix",
		&pkg{version},
	)
}
