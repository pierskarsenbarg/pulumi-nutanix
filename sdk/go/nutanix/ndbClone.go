// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nutanix

import (
	"context"
	"reflect"

	"errors"
	"github.com/pierskarsenbarg/pulumi-nutanix/sdk/go/nutanix/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to perform the clone of database instance based on the input parameters.
//
// ## resource for cloning using Point in time given time machine name
//
//	resource "NdbClone" "name" {
//	    timeMachineName = "test-pg-inst"
//	    name = "test-inst-tf-check"
//	    nxClusterId = "{{ nx_Cluster_id }}"
//	    sshPublicKey = "{{ sshkey }}"
//	    user_pitr_timestamp=  "{{ pointInTime }}"
//	    timeZone = "Asia/Calcutta"
//	    createDbserver = true
//	    computeProfileId = "{{ computeProfileId }}"
//	    networkProfileId ="{{ networkProfileId }}"
//	    databaseParameterProfileId =  "{{ databseProfileId }}"
//	    nodes{
//	        vm_name= "testVmClone"
//	        computeProfileId = "{{ computeProfileId }}"
//	        networkProfileId ="{{ networkProfileId }}"
//	        nxClusterId = "{{ nx_Cluster_id }}"
//	    }
//	    postgresql_info{
//	        vm_name="testVmClone"
//	        db_password= "pass"
//	    }
//	}
type NdbClone struct {
	pulumi.CustomResourceState

	// if any action arguments is required
	Actionarguments NdbCloneActionargumentArrayOutput `pulumi:"actionarguments"`
	// cloned or not
	Clone pulumi.BoolOutput `pulumi:"clone"`
	// clone will be clustered or not
	Clustered pulumi.BoolPtrOutput `pulumi:"clustered"`
	// specify the compute profile id
	ComputeProfileId pulumi.StringPtrOutput `pulumi:"computeProfileId"`
	// create new dbserver
	CreateDbserver pulumi.BoolPtrOutput `pulumi:"createDbserver"`
	// database cluster type
	DatabaseClusterType pulumi.StringOutput `pulumi:"databaseClusterType"`
	// database name
	DatabaseName pulumi.StringOutput `pulumi:"databaseName"`
	// database nodes associated with database instance
	DatabaseNodes NdbCloneDatabaseNodeArrayOutput `pulumi:"databaseNodes"`
	// specify the database parameter profile id
	DatabaseParameterProfileId pulumi.StringPtrOutput `pulumi:"databaseParameterProfileId"`
	// date created for clone
	DateCreated pulumi.StringOutput `pulumi:"dateCreated"`
	// last modified date for clone
	DateModified pulumi.StringOutput `pulumi:"dateModified"`
	// dbserver cluster id
	DbserverClusterId pulumi.StringPtrOutput `pulumi:"dbserverClusterId"`
	// Specify if you want to create a database server. This value can be set to true or false as required.
	DbserverId pulumi.StringPtrOutput `pulumi:"dbserverId"`
	// dbserver logical cluster
	DbserverLogicalCluster pulumi.StringMapOutput `pulumi:"dbserverLogicalCluster"`
	// dbserver logical cluster id
	DbserverLogicalClusterId pulumi.StringPtrOutput `pulumi:"dbserverLogicalClusterId"`
	// - (Optional) Delete the database clone from the VM. Default value is true
	Delete pulumi.BoolPtrOutput `pulumi:"delete"`
	// - (Optional) Delete the logical cluster. Default is true
	DeleteLogicalCluster pulumi.BoolPtrOutput `pulumi:"deleteLogicalCluster"`
	// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
	DeleteTimeMachine pulumi.BoolPtrOutput `pulumi:"deleteTimeMachine"`
	// database instance description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// - (Optional) Force delete of instance. Default is false
	Forced pulumi.BoolPtrOutput `pulumi:"forced"`
	// info of clone
	Infos NdbCloneInfoArrayOutput `pulumi:"infos"`
	// latest snapshot
	LatestSnapshot pulumi.BoolPtrOutput `pulumi:"latestSnapshot"`
	// LCM Config contains the expiry details and refresh details
	LcmConfigs NdbCloneLcmConfigArrayOutput `pulumi:"lcmConfigs"`
	// linked databases within database instance
	LinkedDatabases NdbCloneLinkedDatabaseArrayOutput `pulumi:"linkedDatabases"`
	// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
	Metric pulumi.StringMapOutput `pulumi:"metric"`
	// database instance name
	Name pulumi.StringOutput `pulumi:"name"`
	// specify the network profile id
	NetworkProfileId pulumi.StringPtrOutput `pulumi:"networkProfileId"`
	// Node count. Default is 1 for single instance
	NodeCount pulumi.IntPtrOutput `pulumi:"nodeCount"`
	// Nodes contain info about dbservers vm
	Nodes NdbCloneNodeArrayOutput `pulumi:"nodes"`
	// cluster id on where clone will be present
	NxClusterId      pulumi.StringOutput `pulumi:"nxClusterId"`
	ParentDatabaseId pulumi.StringOutput `pulumi:"parentDatabaseId"`
	// postgresql info for the clone
	PostgresqlInfos NdbClonePostgresqlInfoArrayOutput `pulumi:"postgresqlInfos"`
	// List of all the properties
	Properties NdbClonePropertyArrayOutput `pulumi:"properties"`
	// - (Optional) Unregister the database clone from NDB. Default value is false
	Remove pulumi.BoolPtrOutput `pulumi:"remove"`
	// remove logical cluster. Default value is false
	RemoveLogicalCluster pulumi.BoolPtrOutput `pulumi:"removeLogicalCluster"`
	// snapshot id from where clone is created
	SnapshotId pulumi.StringPtrOutput `pulumi:"snapshotId"`
	// - (Optional) Soft remove. Default will be false
	SoftRemove pulumi.BoolPtrOutput `pulumi:"softRemove"`
	// ssh public key
	SshPublicKey pulumi.StringPtrOutput `pulumi:"sshPublicKey"`
	// status of clone
	Status pulumi.StringOutput `pulumi:"status"`
	// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
	Tags NdbCloneTagArrayOutput `pulumi:"tags"`
	// time machine id
	TimeMachineId pulumi.StringPtrOutput `pulumi:"timeMachineId"`
	// time machine name
	TimeMachineName pulumi.StringPtrOutput         `pulumi:"timeMachineName"`
	TimeMachines    NdbCloneTimeMachineArrayOutput `pulumi:"timeMachines"`
	// timezone
	TimeZone pulumi.StringOutput `pulumi:"timeZone"`
	// type of clone
	Type pulumi.StringOutput `pulumi:"type"`
	// point in time for clone to be created
	UserPitrTimestamp pulumi.StringPtrOutput `pulumi:"userPitrTimestamp"`
	// vm password
	VmPassword pulumi.StringPtrOutput `pulumi:"vmPassword"`
}

// NewNdbClone registers a new resource with the given unique name, arguments, and options.
func NewNdbClone(ctx *pulumi.Context,
	name string, args *NdbCloneArgs, opts ...pulumi.ResourceOption) (*NdbClone, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Nodes == nil {
		return nil, errors.New("invalid value for required argument 'Nodes'")
	}
	if args.NxClusterId == nil {
		return nil, errors.New("invalid value for required argument 'NxClusterId'")
	}
	if args.SshPublicKey != nil {
		args.SshPublicKey = pulumi.ToSecret(args.SshPublicKey).(pulumi.StringPtrInput)
	}
	if args.VmPassword != nil {
		args.VmPassword = pulumi.ToSecret(args.VmPassword).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"sshPublicKey",
		"vmPassword",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource NdbClone
	err := ctx.RegisterResource("nutanix:index/ndbClone:NdbClone", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNdbClone gets an existing NdbClone resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNdbClone(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NdbCloneState, opts ...pulumi.ResourceOption) (*NdbClone, error) {
	var resource NdbClone
	err := ctx.ReadResource("nutanix:index/ndbClone:NdbClone", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NdbClone resources.
type ndbCloneState struct {
	// if any action arguments is required
	Actionarguments []NdbCloneActionargument `pulumi:"actionarguments"`
	// cloned or not
	Clone *bool `pulumi:"clone"`
	// clone will be clustered or not
	Clustered *bool `pulumi:"clustered"`
	// specify the compute profile id
	ComputeProfileId *string `pulumi:"computeProfileId"`
	// create new dbserver
	CreateDbserver *bool `pulumi:"createDbserver"`
	// database cluster type
	DatabaseClusterType *string `pulumi:"databaseClusterType"`
	// database name
	DatabaseName *string `pulumi:"databaseName"`
	// database nodes associated with database instance
	DatabaseNodes []NdbCloneDatabaseNode `pulumi:"databaseNodes"`
	// specify the database parameter profile id
	DatabaseParameterProfileId *string `pulumi:"databaseParameterProfileId"`
	// date created for clone
	DateCreated *string `pulumi:"dateCreated"`
	// last modified date for clone
	DateModified *string `pulumi:"dateModified"`
	// dbserver cluster id
	DbserverClusterId *string `pulumi:"dbserverClusterId"`
	// Specify if you want to create a database server. This value can be set to true or false as required.
	DbserverId *string `pulumi:"dbserverId"`
	// dbserver logical cluster
	DbserverLogicalCluster map[string]string `pulumi:"dbserverLogicalCluster"`
	// dbserver logical cluster id
	DbserverLogicalClusterId *string `pulumi:"dbserverLogicalClusterId"`
	// - (Optional) Delete the database clone from the VM. Default value is true
	Delete *bool `pulumi:"delete"`
	// - (Optional) Delete the logical cluster. Default is true
	DeleteLogicalCluster *bool `pulumi:"deleteLogicalCluster"`
	// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
	DeleteTimeMachine *bool `pulumi:"deleteTimeMachine"`
	// database instance description
	Description *string `pulumi:"description"`
	// - (Optional) Force delete of instance. Default is false
	Forced *bool `pulumi:"forced"`
	// info of clone
	Infos []NdbCloneInfo `pulumi:"infos"`
	// latest snapshot
	LatestSnapshot *bool `pulumi:"latestSnapshot"`
	// LCM Config contains the expiry details and refresh details
	LcmConfigs []NdbCloneLcmConfig `pulumi:"lcmConfigs"`
	// linked databases within database instance
	LinkedDatabases []NdbCloneLinkedDatabase `pulumi:"linkedDatabases"`
	// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
	Metric map[string]string `pulumi:"metric"`
	// database instance name
	Name *string `pulumi:"name"`
	// specify the network profile id
	NetworkProfileId *string `pulumi:"networkProfileId"`
	// Node count. Default is 1 for single instance
	NodeCount *int `pulumi:"nodeCount"`
	// Nodes contain info about dbservers vm
	Nodes []NdbCloneNode `pulumi:"nodes"`
	// cluster id on where clone will be present
	NxClusterId      *string `pulumi:"nxClusterId"`
	ParentDatabaseId *string `pulumi:"parentDatabaseId"`
	// postgresql info for the clone
	PostgresqlInfos []NdbClonePostgresqlInfo `pulumi:"postgresqlInfos"`
	// List of all the properties
	Properties []NdbCloneProperty `pulumi:"properties"`
	// - (Optional) Unregister the database clone from NDB. Default value is false
	Remove *bool `pulumi:"remove"`
	// remove logical cluster. Default value is false
	RemoveLogicalCluster *bool `pulumi:"removeLogicalCluster"`
	// snapshot id from where clone is created
	SnapshotId *string `pulumi:"snapshotId"`
	// - (Optional) Soft remove. Default will be false
	SoftRemove *bool `pulumi:"softRemove"`
	// ssh public key
	SshPublicKey *string `pulumi:"sshPublicKey"`
	// status of clone
	Status *string `pulumi:"status"`
	// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
	Tags []NdbCloneTag `pulumi:"tags"`
	// time machine id
	TimeMachineId *string `pulumi:"timeMachineId"`
	// time machine name
	TimeMachineName *string               `pulumi:"timeMachineName"`
	TimeMachines    []NdbCloneTimeMachine `pulumi:"timeMachines"`
	// timezone
	TimeZone *string `pulumi:"timeZone"`
	// type of clone
	Type *string `pulumi:"type"`
	// point in time for clone to be created
	UserPitrTimestamp *string `pulumi:"userPitrTimestamp"`
	// vm password
	VmPassword *string `pulumi:"vmPassword"`
}

type NdbCloneState struct {
	// if any action arguments is required
	Actionarguments NdbCloneActionargumentArrayInput
	// cloned or not
	Clone pulumi.BoolPtrInput
	// clone will be clustered or not
	Clustered pulumi.BoolPtrInput
	// specify the compute profile id
	ComputeProfileId pulumi.StringPtrInput
	// create new dbserver
	CreateDbserver pulumi.BoolPtrInput
	// database cluster type
	DatabaseClusterType pulumi.StringPtrInput
	// database name
	DatabaseName pulumi.StringPtrInput
	// database nodes associated with database instance
	DatabaseNodes NdbCloneDatabaseNodeArrayInput
	// specify the database parameter profile id
	DatabaseParameterProfileId pulumi.StringPtrInput
	// date created for clone
	DateCreated pulumi.StringPtrInput
	// last modified date for clone
	DateModified pulumi.StringPtrInput
	// dbserver cluster id
	DbserverClusterId pulumi.StringPtrInput
	// Specify if you want to create a database server. This value can be set to true or false as required.
	DbserverId pulumi.StringPtrInput
	// dbserver logical cluster
	DbserverLogicalCluster pulumi.StringMapInput
	// dbserver logical cluster id
	DbserverLogicalClusterId pulumi.StringPtrInput
	// - (Optional) Delete the database clone from the VM. Default value is true
	Delete pulumi.BoolPtrInput
	// - (Optional) Delete the logical cluster. Default is true
	DeleteLogicalCluster pulumi.BoolPtrInput
	// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
	DeleteTimeMachine pulumi.BoolPtrInput
	// database instance description
	Description pulumi.StringPtrInput
	// - (Optional) Force delete of instance. Default is false
	Forced pulumi.BoolPtrInput
	// info of clone
	Infos NdbCloneInfoArrayInput
	// latest snapshot
	LatestSnapshot pulumi.BoolPtrInput
	// LCM Config contains the expiry details and refresh details
	LcmConfigs NdbCloneLcmConfigArrayInput
	// linked databases within database instance
	LinkedDatabases NdbCloneLinkedDatabaseArrayInput
	// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
	Metric pulumi.StringMapInput
	// database instance name
	Name pulumi.StringPtrInput
	// specify the network profile id
	NetworkProfileId pulumi.StringPtrInput
	// Node count. Default is 1 for single instance
	NodeCount pulumi.IntPtrInput
	// Nodes contain info about dbservers vm
	Nodes NdbCloneNodeArrayInput
	// cluster id on where clone will be present
	NxClusterId      pulumi.StringPtrInput
	ParentDatabaseId pulumi.StringPtrInput
	// postgresql info for the clone
	PostgresqlInfos NdbClonePostgresqlInfoArrayInput
	// List of all the properties
	Properties NdbClonePropertyArrayInput
	// - (Optional) Unregister the database clone from NDB. Default value is false
	Remove pulumi.BoolPtrInput
	// remove logical cluster. Default value is false
	RemoveLogicalCluster pulumi.BoolPtrInput
	// snapshot id from where clone is created
	SnapshotId pulumi.StringPtrInput
	// - (Optional) Soft remove. Default will be false
	SoftRemove pulumi.BoolPtrInput
	// ssh public key
	SshPublicKey pulumi.StringPtrInput
	// status of clone
	Status pulumi.StringPtrInput
	// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
	Tags NdbCloneTagArrayInput
	// time machine id
	TimeMachineId pulumi.StringPtrInput
	// time machine name
	TimeMachineName pulumi.StringPtrInput
	TimeMachines    NdbCloneTimeMachineArrayInput
	// timezone
	TimeZone pulumi.StringPtrInput
	// type of clone
	Type pulumi.StringPtrInput
	// point in time for clone to be created
	UserPitrTimestamp pulumi.StringPtrInput
	// vm password
	VmPassword pulumi.StringPtrInput
}

func (NdbCloneState) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbCloneState)(nil)).Elem()
}

type ndbCloneArgs struct {
	// if any action arguments is required
	Actionarguments []NdbCloneActionargument `pulumi:"actionarguments"`
	// clone will be clustered or not
	Clustered *bool `pulumi:"clustered"`
	// specify the compute profile id
	ComputeProfileId *string `pulumi:"computeProfileId"`
	// create new dbserver
	CreateDbserver *bool `pulumi:"createDbserver"`
	// specify the database parameter profile id
	DatabaseParameterProfileId *string `pulumi:"databaseParameterProfileId"`
	// dbserver cluster id
	DbserverClusterId *string `pulumi:"dbserverClusterId"`
	// Specify if you want to create a database server. This value can be set to true or false as required.
	DbserverId *string `pulumi:"dbserverId"`
	// dbserver logical cluster id
	DbserverLogicalClusterId *string `pulumi:"dbserverLogicalClusterId"`
	// - (Optional) Delete the database clone from the VM. Default value is true
	Delete *bool `pulumi:"delete"`
	// - (Optional) Delete the logical cluster. Default is true
	DeleteLogicalCluster *bool `pulumi:"deleteLogicalCluster"`
	// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
	DeleteTimeMachine *bool `pulumi:"deleteTimeMachine"`
	// database instance description
	Description *string `pulumi:"description"`
	// - (Optional) Force delete of instance. Default is false
	Forced *bool `pulumi:"forced"`
	// latest snapshot
	LatestSnapshot *bool `pulumi:"latestSnapshot"`
	// LCM Config contains the expiry details and refresh details
	LcmConfigs []NdbCloneLcmConfig `pulumi:"lcmConfigs"`
	// database instance name
	Name *string `pulumi:"name"`
	// specify the network profile id
	NetworkProfileId *string `pulumi:"networkProfileId"`
	// Node count. Default is 1 for single instance
	NodeCount *int `pulumi:"nodeCount"`
	// Nodes contain info about dbservers vm
	Nodes []NdbCloneNode `pulumi:"nodes"`
	// cluster id on where clone will be present
	NxClusterId string `pulumi:"nxClusterId"`
	// postgresql info for the clone
	PostgresqlInfos []NdbClonePostgresqlInfo `pulumi:"postgresqlInfos"`
	// - (Optional) Unregister the database clone from NDB. Default value is false
	Remove *bool `pulumi:"remove"`
	// remove logical cluster. Default value is false
	RemoveLogicalCluster *bool `pulumi:"removeLogicalCluster"`
	// snapshot id from where clone is created
	SnapshotId *string `pulumi:"snapshotId"`
	// - (Optional) Soft remove. Default will be false
	SoftRemove *bool `pulumi:"softRemove"`
	// ssh public key
	SshPublicKey *string `pulumi:"sshPublicKey"`
	// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
	Tags []NdbCloneTag `pulumi:"tags"`
	// time machine id
	TimeMachineId *string `pulumi:"timeMachineId"`
	// time machine name
	TimeMachineName *string `pulumi:"timeMachineName"`
	// timezone
	TimeZone *string `pulumi:"timeZone"`
	// point in time for clone to be created
	UserPitrTimestamp *string `pulumi:"userPitrTimestamp"`
	// vm password
	VmPassword *string `pulumi:"vmPassword"`
}

// The set of arguments for constructing a NdbClone resource.
type NdbCloneArgs struct {
	// if any action arguments is required
	Actionarguments NdbCloneActionargumentArrayInput
	// clone will be clustered or not
	Clustered pulumi.BoolPtrInput
	// specify the compute profile id
	ComputeProfileId pulumi.StringPtrInput
	// create new dbserver
	CreateDbserver pulumi.BoolPtrInput
	// specify the database parameter profile id
	DatabaseParameterProfileId pulumi.StringPtrInput
	// dbserver cluster id
	DbserverClusterId pulumi.StringPtrInput
	// Specify if you want to create a database server. This value can be set to true or false as required.
	DbserverId pulumi.StringPtrInput
	// dbserver logical cluster id
	DbserverLogicalClusterId pulumi.StringPtrInput
	// - (Optional) Delete the database clone from the VM. Default value is true
	Delete pulumi.BoolPtrInput
	// - (Optional) Delete the logical cluster. Default is true
	DeleteLogicalCluster pulumi.BoolPtrInput
	// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
	DeleteTimeMachine pulumi.BoolPtrInput
	// database instance description
	Description pulumi.StringPtrInput
	// - (Optional) Force delete of instance. Default is false
	Forced pulumi.BoolPtrInput
	// latest snapshot
	LatestSnapshot pulumi.BoolPtrInput
	// LCM Config contains the expiry details and refresh details
	LcmConfigs NdbCloneLcmConfigArrayInput
	// database instance name
	Name pulumi.StringPtrInput
	// specify the network profile id
	NetworkProfileId pulumi.StringPtrInput
	// Node count. Default is 1 for single instance
	NodeCount pulumi.IntPtrInput
	// Nodes contain info about dbservers vm
	Nodes NdbCloneNodeArrayInput
	// cluster id on where clone will be present
	NxClusterId pulumi.StringInput
	// postgresql info for the clone
	PostgresqlInfos NdbClonePostgresqlInfoArrayInput
	// - (Optional) Unregister the database clone from NDB. Default value is false
	Remove pulumi.BoolPtrInput
	// remove logical cluster. Default value is false
	RemoveLogicalCluster pulumi.BoolPtrInput
	// snapshot id from where clone is created
	SnapshotId pulumi.StringPtrInput
	// - (Optional) Soft remove. Default will be false
	SoftRemove pulumi.BoolPtrInput
	// ssh public key
	SshPublicKey pulumi.StringPtrInput
	// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
	Tags NdbCloneTagArrayInput
	// time machine id
	TimeMachineId pulumi.StringPtrInput
	// time machine name
	TimeMachineName pulumi.StringPtrInput
	// timezone
	TimeZone pulumi.StringPtrInput
	// point in time for clone to be created
	UserPitrTimestamp pulumi.StringPtrInput
	// vm password
	VmPassword pulumi.StringPtrInput
}

func (NdbCloneArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ndbCloneArgs)(nil)).Elem()
}

type NdbCloneInput interface {
	pulumi.Input

	ToNdbCloneOutput() NdbCloneOutput
	ToNdbCloneOutputWithContext(ctx context.Context) NdbCloneOutput
}

func (*NdbClone) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbClone)(nil)).Elem()
}

func (i *NdbClone) ToNdbCloneOutput() NdbCloneOutput {
	return i.ToNdbCloneOutputWithContext(context.Background())
}

func (i *NdbClone) ToNdbCloneOutputWithContext(ctx context.Context) NdbCloneOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneOutput)
}

// NdbCloneArrayInput is an input type that accepts NdbCloneArray and NdbCloneArrayOutput values.
// You can construct a concrete instance of `NdbCloneArrayInput` via:
//
//	NdbCloneArray{ NdbCloneArgs{...} }
type NdbCloneArrayInput interface {
	pulumi.Input

	ToNdbCloneArrayOutput() NdbCloneArrayOutput
	ToNdbCloneArrayOutputWithContext(context.Context) NdbCloneArrayOutput
}

type NdbCloneArray []NdbCloneInput

func (NdbCloneArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbClone)(nil)).Elem()
}

func (i NdbCloneArray) ToNdbCloneArrayOutput() NdbCloneArrayOutput {
	return i.ToNdbCloneArrayOutputWithContext(context.Background())
}

func (i NdbCloneArray) ToNdbCloneArrayOutputWithContext(ctx context.Context) NdbCloneArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneArrayOutput)
}

// NdbCloneMapInput is an input type that accepts NdbCloneMap and NdbCloneMapOutput values.
// You can construct a concrete instance of `NdbCloneMapInput` via:
//
//	NdbCloneMap{ "key": NdbCloneArgs{...} }
type NdbCloneMapInput interface {
	pulumi.Input

	ToNdbCloneMapOutput() NdbCloneMapOutput
	ToNdbCloneMapOutputWithContext(context.Context) NdbCloneMapOutput
}

type NdbCloneMap map[string]NdbCloneInput

func (NdbCloneMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbClone)(nil)).Elem()
}

func (i NdbCloneMap) ToNdbCloneMapOutput() NdbCloneMapOutput {
	return i.ToNdbCloneMapOutputWithContext(context.Background())
}

func (i NdbCloneMap) ToNdbCloneMapOutputWithContext(ctx context.Context) NdbCloneMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NdbCloneMapOutput)
}

type NdbCloneOutput struct{ *pulumi.OutputState }

func (NdbCloneOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NdbClone)(nil)).Elem()
}

func (o NdbCloneOutput) ToNdbCloneOutput() NdbCloneOutput {
	return o
}

func (o NdbCloneOutput) ToNdbCloneOutputWithContext(ctx context.Context) NdbCloneOutput {
	return o
}

// if any action arguments is required
func (o NdbCloneOutput) Actionarguments() NdbCloneActionargumentArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneActionargumentArrayOutput { return v.Actionarguments }).(NdbCloneActionargumentArrayOutput)
}

// cloned or not
func (o NdbCloneOutput) Clone() pulumi.BoolOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolOutput { return v.Clone }).(pulumi.BoolOutput)
}

// clone will be clustered or not
func (o NdbCloneOutput) Clustered() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.Clustered }).(pulumi.BoolPtrOutput)
}

// specify the compute profile id
func (o NdbCloneOutput) ComputeProfileId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.ComputeProfileId }).(pulumi.StringPtrOutput)
}

// create new dbserver
func (o NdbCloneOutput) CreateDbserver() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.CreateDbserver }).(pulumi.BoolPtrOutput)
}

// database cluster type
func (o NdbCloneOutput) DatabaseClusterType() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.DatabaseClusterType }).(pulumi.StringOutput)
}

// database name
func (o NdbCloneOutput) DatabaseName() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.DatabaseName }).(pulumi.StringOutput)
}

// database nodes associated with database instance
func (o NdbCloneOutput) DatabaseNodes() NdbCloneDatabaseNodeArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneDatabaseNodeArrayOutput { return v.DatabaseNodes }).(NdbCloneDatabaseNodeArrayOutput)
}

// specify the database parameter profile id
func (o NdbCloneOutput) DatabaseParameterProfileId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.DatabaseParameterProfileId }).(pulumi.StringPtrOutput)
}

// date created for clone
func (o NdbCloneOutput) DateCreated() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.DateCreated }).(pulumi.StringOutput)
}

// last modified date for clone
func (o NdbCloneOutput) DateModified() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.DateModified }).(pulumi.StringOutput)
}

// dbserver cluster id
func (o NdbCloneOutput) DbserverClusterId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.DbserverClusterId }).(pulumi.StringPtrOutput)
}

// Specify if you want to create a database server. This value can be set to true or false as required.
func (o NdbCloneOutput) DbserverId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.DbserverId }).(pulumi.StringPtrOutput)
}

// dbserver logical cluster
func (o NdbCloneOutput) DbserverLogicalCluster() pulumi.StringMapOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringMapOutput { return v.DbserverLogicalCluster }).(pulumi.StringMapOutput)
}

// dbserver logical cluster id
func (o NdbCloneOutput) DbserverLogicalClusterId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.DbserverLogicalClusterId }).(pulumi.StringPtrOutput)
}

// - (Optional) Delete the database clone from the VM. Default value is true
func (o NdbCloneOutput) Delete() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.Delete }).(pulumi.BoolPtrOutput)
}

// - (Optional) Delete the logical cluster. Default is true
func (o NdbCloneOutput) DeleteLogicalCluster() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.DeleteLogicalCluster }).(pulumi.BoolPtrOutput)
}

// - (Optional) Delete the database's Time Machine (snapshots/logs) from the NDB. Default value is true
func (o NdbCloneOutput) DeleteTimeMachine() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.DeleteTimeMachine }).(pulumi.BoolPtrOutput)
}

// database instance description
func (o NdbCloneOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// - (Optional) Force delete of instance. Default is false
func (o NdbCloneOutput) Forced() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.Forced }).(pulumi.BoolPtrOutput)
}

// info of clone
func (o NdbCloneOutput) Infos() NdbCloneInfoArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneInfoArrayOutput { return v.Infos }).(NdbCloneInfoArrayOutput)
}

// latest snapshot
func (o NdbCloneOutput) LatestSnapshot() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.LatestSnapshot }).(pulumi.BoolPtrOutput)
}

// LCM Config contains the expiry details and refresh details
func (o NdbCloneOutput) LcmConfigs() NdbCloneLcmConfigArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneLcmConfigArrayOutput { return v.LcmConfigs }).(NdbCloneLcmConfigArrayOutput)
}

// linked databases within database instance
func (o NdbCloneOutput) LinkedDatabases() NdbCloneLinkedDatabaseArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneLinkedDatabaseArrayOutput { return v.LinkedDatabases }).(NdbCloneLinkedDatabaseArrayOutput)
}

// Stores storage info regarding size, allocatedSize, usedSize and unit of calculation that seems to have been fetched from PRISM.
func (o NdbCloneOutput) Metric() pulumi.StringMapOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringMapOutput { return v.Metric }).(pulumi.StringMapOutput)
}

// database instance name
func (o NdbCloneOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// specify the network profile id
func (o NdbCloneOutput) NetworkProfileId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.NetworkProfileId }).(pulumi.StringPtrOutput)
}

// Node count. Default is 1 for single instance
func (o NdbCloneOutput) NodeCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.IntPtrOutput { return v.NodeCount }).(pulumi.IntPtrOutput)
}

// Nodes contain info about dbservers vm
func (o NdbCloneOutput) Nodes() NdbCloneNodeArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneNodeArrayOutput { return v.Nodes }).(NdbCloneNodeArrayOutput)
}

// cluster id on where clone will be present
func (o NdbCloneOutput) NxClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.NxClusterId }).(pulumi.StringOutput)
}

func (o NdbCloneOutput) ParentDatabaseId() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.ParentDatabaseId }).(pulumi.StringOutput)
}

// postgresql info for the clone
func (o NdbCloneOutput) PostgresqlInfos() NdbClonePostgresqlInfoArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbClonePostgresqlInfoArrayOutput { return v.PostgresqlInfos }).(NdbClonePostgresqlInfoArrayOutput)
}

// List of all the properties
func (o NdbCloneOutput) Properties() NdbClonePropertyArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbClonePropertyArrayOutput { return v.Properties }).(NdbClonePropertyArrayOutput)
}

// - (Optional) Unregister the database clone from NDB. Default value is false
func (o NdbCloneOutput) Remove() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.Remove }).(pulumi.BoolPtrOutput)
}

// remove logical cluster. Default value is false
func (o NdbCloneOutput) RemoveLogicalCluster() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.RemoveLogicalCluster }).(pulumi.BoolPtrOutput)
}

// snapshot id from where clone is created
func (o NdbCloneOutput) SnapshotId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.SnapshotId }).(pulumi.StringPtrOutput)
}

// - (Optional) Soft remove. Default will be false
func (o NdbCloneOutput) SoftRemove() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.BoolPtrOutput { return v.SoftRemove }).(pulumi.BoolPtrOutput)
}

// ssh public key
func (o NdbCloneOutput) SshPublicKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.SshPublicKey }).(pulumi.StringPtrOutput)
}

// status of clone
func (o NdbCloneOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// allows you to assign metadata to entities (clones, time machines, databases, and database servers) by using tags.
func (o NdbCloneOutput) Tags() NdbCloneTagArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneTagArrayOutput { return v.Tags }).(NdbCloneTagArrayOutput)
}

// time machine id
func (o NdbCloneOutput) TimeMachineId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.TimeMachineId }).(pulumi.StringPtrOutput)
}

// time machine name
func (o NdbCloneOutput) TimeMachineName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.TimeMachineName }).(pulumi.StringPtrOutput)
}

func (o NdbCloneOutput) TimeMachines() NdbCloneTimeMachineArrayOutput {
	return o.ApplyT(func(v *NdbClone) NdbCloneTimeMachineArrayOutput { return v.TimeMachines }).(NdbCloneTimeMachineArrayOutput)
}

// timezone
func (o NdbCloneOutput) TimeZone() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.TimeZone }).(pulumi.StringOutput)
}

// type of clone
func (o NdbCloneOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

// point in time for clone to be created
func (o NdbCloneOutput) UserPitrTimestamp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.UserPitrTimestamp }).(pulumi.StringPtrOutput)
}

// vm password
func (o NdbCloneOutput) VmPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *NdbClone) pulumi.StringPtrOutput { return v.VmPassword }).(pulumi.StringPtrOutput)
}

type NdbCloneArrayOutput struct{ *pulumi.OutputState }

func (NdbCloneArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NdbClone)(nil)).Elem()
}

func (o NdbCloneArrayOutput) ToNdbCloneArrayOutput() NdbCloneArrayOutput {
	return o
}

func (o NdbCloneArrayOutput) ToNdbCloneArrayOutputWithContext(ctx context.Context) NdbCloneArrayOutput {
	return o
}

func (o NdbCloneArrayOutput) Index(i pulumi.IntInput) NdbCloneOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NdbClone {
		return vs[0].([]*NdbClone)[vs[1].(int)]
	}).(NdbCloneOutput)
}

type NdbCloneMapOutput struct{ *pulumi.OutputState }

func (NdbCloneMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NdbClone)(nil)).Elem()
}

func (o NdbCloneMapOutput) ToNdbCloneMapOutput() NdbCloneMapOutput {
	return o
}

func (o NdbCloneMapOutput) ToNdbCloneMapOutputWithContext(ctx context.Context) NdbCloneMapOutput {
	return o
}

func (o NdbCloneMapOutput) MapIndex(k pulumi.StringInput) NdbCloneOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NdbClone {
		return vs[0].(map[string]*NdbClone)[vs[1].(string)]
	}).(NdbCloneOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneInput)(nil)).Elem(), &NdbClone{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneArrayInput)(nil)).Elem(), NdbCloneArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NdbCloneMapInput)(nil)).Elem(), NdbCloneMap{})
	pulumi.RegisterOutputType(NdbCloneOutput{})
	pulumi.RegisterOutputType(NdbCloneArrayOutput{})
	pulumi.RegisterOutputType(NdbCloneMapOutput{})
}