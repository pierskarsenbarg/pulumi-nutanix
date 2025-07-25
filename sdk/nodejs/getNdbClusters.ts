// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * List all clusters in Nutanix Database Service
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const clusters = nutanix.getNdbClusters({});
 * export const clustersOp = clusters;
 * ```
 *
 * ## clusters
 *
 * The following attributes are exported for each cluster:
 *
 * * `id`: - id of cluster
 * * `name`: - name of cluster
 * * `uniqueName`: - unique name of cluster
 * * `ipAddresses`: - IP address
 * * `fqdns`: - fqdn
 * * `nxClusterUuid`: - nutanix cluster uuid
 * * `description`: - description
 * * `cloudType`: - cloud type
 * * `dateCreated`: - creation date
 * * `dateModified`: - date modified
 * * `version`: - version
 * * `ownerId`: - owner UUID
 * * `status`: - current status
 * * `hypervisorType`: - hypervisor type
 * * `hypervisorVersion`: - hypervisor version
 * * `properties`: - list of properties
 * * `referenceCount`: - NA
 * * `username`: - username
 * * `password`: - password
 * * `cloudInfo`: - cloud info
 * * `resourceConfig`: - resource related consumption info
 * * `managementServerInfo`: - NA
 * * `entityCounts`: - no. of entities related
 * * `healthy`: - if healthy status
 *
 * See detailed information in [NDB Clusters](https://www.nutanix.dev/api_references/ndb/#/b00cac8329db1-get-a-list-of-all-clusters).
 */
export function getNdbClusters(opts?: pulumi.InvokeOptions): Promise<GetNdbClustersResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getNdbClusters:getNdbClusters", {
    }, opts);
}

/**
 * A collection of values returned by getNdbClusters.
 */
export interface GetNdbClustersResult {
    /**
     * list of clusters
     */
    readonly clusters: outputs.GetNdbClustersCluster[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
/**
 * List all clusters in Nutanix Database Service
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const clusters = nutanix.getNdbClusters({});
 * export const clustersOp = clusters;
 * ```
 *
 * ## clusters
 *
 * The following attributes are exported for each cluster:
 *
 * * `id`: - id of cluster
 * * `name`: - name of cluster
 * * `uniqueName`: - unique name of cluster
 * * `ipAddresses`: - IP address
 * * `fqdns`: - fqdn
 * * `nxClusterUuid`: - nutanix cluster uuid
 * * `description`: - description
 * * `cloudType`: - cloud type
 * * `dateCreated`: - creation date
 * * `dateModified`: - date modified
 * * `version`: - version
 * * `ownerId`: - owner UUID
 * * `status`: - current status
 * * `hypervisorType`: - hypervisor type
 * * `hypervisorVersion`: - hypervisor version
 * * `properties`: - list of properties
 * * `referenceCount`: - NA
 * * `username`: - username
 * * `password`: - password
 * * `cloudInfo`: - cloud info
 * * `resourceConfig`: - resource related consumption info
 * * `managementServerInfo`: - NA
 * * `entityCounts`: - no. of entities related
 * * `healthy`: - if healthy status
 *
 * See detailed information in [NDB Clusters](https://www.nutanix.dev/api_references/ndb/#/b00cac8329db1-get-a-list-of-all-clusters).
 */
export function getNdbClustersOutput(opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetNdbClustersResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getNdbClusters:getNdbClusters", {
    }, opts);
}
