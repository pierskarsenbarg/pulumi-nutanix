// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * List all the service Groups.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const recoveryPoints = nutanix.getRecoveryPointsV2({});
 * const example = nutanix.getRecoveryPointsV2({
 *     filter: "name eq 'recovery_point_001'",
 * });
 * ```
 */
export function getRecoveryPointsV2(args?: GetRecoveryPointsV2Args, opts?: pulumi.InvokeOptions): Promise<GetRecoveryPointsV2Result> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getRecoveryPointsV2:getRecoveryPointsV2", {
        "apply": args.apply,
        "clusterId": args.clusterId,
        "filter": args.filter,
        "limit": args.limit,
        "orderBy": args.orderBy,
        "page": args.page,
        "select": args.select,
    }, opts);
}

/**
 * A collection of arguments for invoking getRecoveryPointsV2.
 */
export interface GetRecoveryPointsV2Args {
    apply?: string;
    /**
     * Cluster type from which recovery points must be fetched.
     * * supported values:
     * * `AOS` (Default)
     * * `MST`
     */
    clusterId?: string;
    /**
     * A URL query parameter that allows clients to filter a collection of resources.
     * * The filter can be applied to the following fields:
     * * `creationTime`
     * * `extId`
     * * `locationAgnosticId`
     */
    filter?: string;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: number;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
     * * The orderby can be applied to the following fields:
     * * `creationTime`
     * * `expirationTime`
     */
    orderBy?: string;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: number;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions
     * * The select can be applied to the following fields:
     * * `creationTime`
     * * `expirationTime`
     * * `extId`
     */
    select?: string;
}

/**
 * A collection of values returned by getRecoveryPointsV2.
 */
export interface GetRecoveryPointsV2Result {
    readonly apply?: string;
    readonly clusterId?: string;
    readonly filter?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly limit?: number;
    readonly orderBy?: string;
    readonly page?: number;
    readonly recoveryPoints: outputs.GetRecoveryPointsV2RecoveryPoint[];
    readonly select?: string;
}
/**
 * List all the service Groups.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const recoveryPoints = nutanix.getRecoveryPointsV2({});
 * const example = nutanix.getRecoveryPointsV2({
 *     filter: "name eq 'recovery_point_001'",
 * });
 * ```
 */
export function getRecoveryPointsV2Output(args?: GetRecoveryPointsV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetRecoveryPointsV2Result> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getRecoveryPointsV2:getRecoveryPointsV2", {
        "apply": args.apply,
        "clusterId": args.clusterId,
        "filter": args.filter,
        "limit": args.limit,
        "orderBy": args.orderBy,
        "page": args.page,
        "select": args.select,
    }, opts);
}

/**
 * A collection of arguments for invoking getRecoveryPointsV2.
 */
export interface GetRecoveryPointsV2OutputArgs {
    apply?: pulumi.Input<string>;
    /**
     * Cluster type from which recovery points must be fetched.
     * * supported values:
     * * `AOS` (Default)
     * * `MST`
     */
    clusterId?: pulumi.Input<string>;
    /**
     * A URL query parameter that allows clients to filter a collection of resources.
     * * The filter can be applied to the following fields:
     * * `creationTime`
     * * `extId`
     * * `locationAgnosticId`
     */
    filter?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
     * * The orderby can be applied to the following fields:
     * * `creationTime`
     * * `expirationTime`
     */
    orderBy?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions
     * * The select can be applied to the following fields:
     * * `creationTime`
     * * `expirationTime`
     * * `extId`
     */
    select?: pulumi.Input<string>;
}
