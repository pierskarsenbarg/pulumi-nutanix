// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Lists backup targets (cluster or object store) configured for a given domain manager.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const example = nutanix.getPcBackupTargetsV2({
 *     domainManagerExtId: "75dde184-3a0e-4f59-a185-03ca1efead17",
 * });
 * ```
 *
 * ## Backup Targets
 *
 * The `backupTargets` argument supports the following:
 *
 * - `tenantId`: - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
 * - `extId`: - A globally unique identifier of an instance that is suitable for external consumption.
 * - `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
 * - `location`: - Location of the backup target. For example, a cluster or an object store endpoint, such as AWS s3.
 * - `lastSyncTime`: - Represents the time when the domain manager was last synchronized or copied its configuration data to the backup target. This field is updated every 30 minutes.
 * - `isBackupPaused`: - Whether the backup is paused on the given cluster or not.
 * - `backupPauseReason`: - Specifies a reason why the backup might have paused. This will be empty if the isBackupPaused field is false.
 *
 * ### Location
 *
 * The location argument exports the following:
 *
 * - `clusterLocation`: - A boolean value indicating whether to enable lockdown mode for a cluster.
 * - `objectStoreLocation`: - Currently representing the build information to be used for the cluster creation.
 *
 * #### Cluster Location
 *
 * The `clusterLocation` argument exports the following:
 *
 * - `config`: - Cluster reference of the remote cluster to be connected.
 *
 * ##### Config
 *
 * The `config` argument exports the following:
 *
 * - `extId`: - Cluster UUID of a remote cluster.
 * - `name`: - Name of the cluster.
 *
 * #### Object Store Location
 *
 * The `objectStoreLocation` argument exports the following:
 *
 * - `providerConfig`: -(Required) The base model of S3 object store endpoint where domain manager is backed up.
 * - `backupPolicy`: -(Optional) Backup policy for the object store provided.
 *
 * ##### Provider Config
 *
 * The `providerConfig` argument exports the following:
 *
 * - `bucketName`: - The bucket name of the object store endpoint where backup data of domain manager is to be stored.
 * - `region`: - The region name of the object store endpoint where backup data of domain manager is stored. Default is `us-east-1`.
 * - `credentials`: - Secret credentials model for the object store containing access key ID and secret access key.
 *
 * ###### Credentials
 *
 * The `credentials` argument exports the following:
 *
 * - `accessKeyId`: - Access key ID for the object store provided for backup target.
 * - `secretAccessKey`: - Secret access key for the object store provided for backup target.
 *
 * ##### Backup Policy
 *
 * The `backupPolicy` argument exports the following:
 *
 * - `rpoInMinutes`: - RPO interval in minutes at which the backup will be taken. The Value should be in the range of 60 to 1440.
 *
 * See detailed information in [Nutanix List Backup Targets ](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/listBackupTargets).
 */
export function getPcBackupTargetsV2(args: GetPcBackupTargetsV2Args, opts?: pulumi.InvokeOptions): Promise<GetPcBackupTargetsV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getPcBackupTargetsV2:getPcBackupTargetsV2", {
        "domainManagerExtId": args.domainManagerExtId,
    }, opts);
}

/**
 * A collection of arguments for invoking getPcBackupTargetsV2.
 */
export interface GetPcBackupTargetsV2Args {
    /**
     * -(Required) A unique identifier for the domain manager.
     */
    domainManagerExtId: string;
}

/**
 * A collection of values returned by getPcBackupTargetsV2.
 */
export interface GetPcBackupTargetsV2Result {
    /**
     * - A list of backup target entities.
     */
    readonly backupTargets: outputs.GetPcBackupTargetsV2BackupTarget[];
    readonly domainManagerExtId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
/**
 * Lists backup targets (cluster or object store) configured for a given domain manager.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const example = nutanix.getPcBackupTargetsV2({
 *     domainManagerExtId: "75dde184-3a0e-4f59-a185-03ca1efead17",
 * });
 * ```
 *
 * ## Backup Targets
 *
 * The `backupTargets` argument supports the following:
 *
 * - `tenantId`: - A globally unique identifier that represents the tenant that owns this entity. The system automatically assigns it, and it and is immutable from an API consumer perspective (some use cases may cause this Id to change - For instance, a use case may require the transfer of ownership of the entity, but these cases are handled automatically on the server).
 * - `extId`: - A globally unique identifier of an instance that is suitable for external consumption.
 * - `links`: - A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
 * - `location`: - Location of the backup target. For example, a cluster or an object store endpoint, such as AWS s3.
 * - `lastSyncTime`: - Represents the time when the domain manager was last synchronized or copied its configuration data to the backup target. This field is updated every 30 minutes.
 * - `isBackupPaused`: - Whether the backup is paused on the given cluster or not.
 * - `backupPauseReason`: - Specifies a reason why the backup might have paused. This will be empty if the isBackupPaused field is false.
 *
 * ### Location
 *
 * The location argument exports the following:
 *
 * - `clusterLocation`: - A boolean value indicating whether to enable lockdown mode for a cluster.
 * - `objectStoreLocation`: - Currently representing the build information to be used for the cluster creation.
 *
 * #### Cluster Location
 *
 * The `clusterLocation` argument exports the following:
 *
 * - `config`: - Cluster reference of the remote cluster to be connected.
 *
 * ##### Config
 *
 * The `config` argument exports the following:
 *
 * - `extId`: - Cluster UUID of a remote cluster.
 * - `name`: - Name of the cluster.
 *
 * #### Object Store Location
 *
 * The `objectStoreLocation` argument exports the following:
 *
 * - `providerConfig`: -(Required) The base model of S3 object store endpoint where domain manager is backed up.
 * - `backupPolicy`: -(Optional) Backup policy for the object store provided.
 *
 * ##### Provider Config
 *
 * The `providerConfig` argument exports the following:
 *
 * - `bucketName`: - The bucket name of the object store endpoint where backup data of domain manager is to be stored.
 * - `region`: - The region name of the object store endpoint where backup data of domain manager is stored. Default is `us-east-1`.
 * - `credentials`: - Secret credentials model for the object store containing access key ID and secret access key.
 *
 * ###### Credentials
 *
 * The `credentials` argument exports the following:
 *
 * - `accessKeyId`: - Access key ID for the object store provided for backup target.
 * - `secretAccessKey`: - Secret access key for the object store provided for backup target.
 *
 * ##### Backup Policy
 *
 * The `backupPolicy` argument exports the following:
 *
 * - `rpoInMinutes`: - RPO interval in minutes at which the backup will be taken. The Value should be in the range of 60 to 1440.
 *
 * See detailed information in [Nutanix List Backup Targets ](https://developers.nutanix.com/api-reference?namespace=prism&version=v4.0#tag/DomainManager/operation/listBackupTargets).
 */
export function getPcBackupTargetsV2Output(args: GetPcBackupTargetsV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetPcBackupTargetsV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getPcBackupTargetsV2:getPcBackupTargetsV2", {
        "domainManagerExtId": args.domainManagerExtId,
    }, opts);
}

/**
 * A collection of arguments for invoking getPcBackupTargetsV2.
 */
export interface GetPcBackupTargetsV2OutputArgs {
    /**
     * -(Required) A unique identifier for the domain manager.
     */
    domainManagerExtId: pulumi.Input<string>;
}
