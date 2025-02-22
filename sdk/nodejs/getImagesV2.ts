// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * List images owned by Prism Central along with the image details like name, description, type, etc. This operation supports filtering, sorting, selection & pagination.
 */
export function getImagesV2(args?: GetImagesV2Args, opts?: pulumi.InvokeOptions): Promise<GetImagesV2Result> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getImagesV2:getImagesV2", {
        "filter": args.filter,
        "limit": args.limit,
        "orderBy": args.orderBy,
        "page": args.page,
        "select": args.select,
    }, opts);
}

/**
 * A collection of arguments for invoking getImagesV2.
 */
export interface GetImagesV2Args {
    /**
     * A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
     */
    filter?: string;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: number;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
     */
    orderBy?: string;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: number;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
     */
    select?: string;
}

/**
 * A collection of values returned by getImagesV2.
 */
export interface GetImagesV2Result {
    /**
     * A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
     */
    readonly filter?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of all images
     */
    readonly images: outputs.GetImagesV2Image[];
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    readonly limit?: number;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
     */
    readonly orderBy?: string;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    readonly page?: number;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
     */
    readonly select?: string;
}
/**
 * List images owned by Prism Central along with the image details like name, description, type, etc. This operation supports filtering, sorting, selection & pagination.
 */
export function getImagesV2Output(args?: GetImagesV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetImagesV2Result> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getImagesV2:getImagesV2", {
        "filter": args.filter,
        "limit": args.limit,
        "orderBy": args.orderBy,
        "page": args.page,
        "select": args.select,
    }, opts);
}

/**
 * A collection of arguments for invoking getImagesV2.
 */
export interface GetImagesV2OutputArgs {
    /**
     * A URL query parameter that allows clients to filter a collection of resources. The expression specified with $filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the $filter must conform to the OData V4.01 URL conventions
     */
    filter?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default
     */
    orderBy?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the $select must conform to the OData V4.01 URL conventions.
     */
    select?: pulumi.Input<string>;
}
