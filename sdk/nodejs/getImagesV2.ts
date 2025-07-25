// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * List images owned by Prism Central along with the image details like name, description, type, etc. This operation supports filtering, sorting, selection & pagination.
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const list_images = nutanix.getImagesV2({});
 * const filtered_images = nutanix.getImagesV2({
 *     filter: "startswith(name,'image_name')",
 *     limit: 10,
 *     page: 0,
 * });
 * ```
 *
 * ## Images
 *
 * The `images` object is a list of all images. Each image has the following attributes:
 *
 * * `extId`: A globally unique identifier of an instance that is suitable for external consumption.
 * * `name`: The user defined name of an image.
 * * `description`: The user defined description of an image.
 * * `type`: The type of an image.
 * * `checksum`: The checksum of an image.
 * * `sizeBytes`: The size in bytes of an image file.
 * * `source`: The source of an image. It can be a VM disk or a URL.
 * * `categoryExtIds`: List of category external identifiers for an image.
 * * `clusterLocationExtIds`: List of cluster external identifiers where the image is located.
 * * `createTime`: Create time of an image.
 * * `lastUpdateTime`: Last update time of an image.
 * * `ownerExtId`: External identifier of the owner of the image
 * * `placementPolicyStatus`: Status of an image placement policy.
 *
 * ### source
 * * `extId`: The external identifier of VM Disk.
 * * `url`: The URL for creating an image.
 * * `basicAuth`: Basic authentication credentials for image source HTTP/S URL.
 * * `basic_auth.username`: Username for basic authentication.
 * * `basic_auth.password`: Password for basic authentication.
 *
 * ### placementPolicyStatus
 * * `placementPolicyExtId`: Image placement policy external identifier.
 * * `complianceStatus`: Compliance status for a placement policy.
 * * `enforcementMode`: Indicates whether the placement policy enforcement is ongoing or has failed.
 * * `policyClusterExtIds`: List of cluster external identifiers of the image location for the enforced placement policy.
 * * `enforcedClusterExtIds`: List of cluster external identifiers for the enforced placement policy.
 * * `conflictingPolicyExtIds`: List of image placement policy external identifier that conflict with the current one.
 *
 * See detailed information in [Nutanix List Images V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Images)
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
     * A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
     * - description
     * - name
     * - sizeBytes
     * - type
     */
    filter?: string;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: number;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
     * - description
     * - lastUpdateTime
     * - name
     * - sizeBytes
     * - type
     */
    orderBy?: string;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: number;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. The select can be applied to the following fields:
     * - categoryExtIds
     * - clusterLocationExtIds
     * - createTime
     * - description
     * - extId
     * - lastUpdateTime
     * - links
     * - name
     * - ownerExtId
     * - sizeBytes
     * - tenantId
     * - type
     */
    select?: string;
}

/**
 * A collection of values returned by getImagesV2.
 */
export interface GetImagesV2Result {
    readonly filter?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of all images
     */
    readonly images: outputs.GetImagesV2Image[];
    readonly limit?: number;
    readonly orderBy?: string;
    readonly page?: number;
    readonly select?: string;
}
/**
 * List images owned by Prism Central along with the image details like name, description, type, etc. This operation supports filtering, sorting, selection & pagination.
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const list_images = nutanix.getImagesV2({});
 * const filtered_images = nutanix.getImagesV2({
 *     filter: "startswith(name,'image_name')",
 *     limit: 10,
 *     page: 0,
 * });
 * ```
 *
 * ## Images
 *
 * The `images` object is a list of all images. Each image has the following attributes:
 *
 * * `extId`: A globally unique identifier of an instance that is suitable for external consumption.
 * * `name`: The user defined name of an image.
 * * `description`: The user defined description of an image.
 * * `type`: The type of an image.
 * * `checksum`: The checksum of an image.
 * * `sizeBytes`: The size in bytes of an image file.
 * * `source`: The source of an image. It can be a VM disk or a URL.
 * * `categoryExtIds`: List of category external identifiers for an image.
 * * `clusterLocationExtIds`: List of cluster external identifiers where the image is located.
 * * `createTime`: Create time of an image.
 * * `lastUpdateTime`: Last update time of an image.
 * * `ownerExtId`: External identifier of the owner of the image
 * * `placementPolicyStatus`: Status of an image placement policy.
 *
 * ### source
 * * `extId`: The external identifier of VM Disk.
 * * `url`: The URL for creating an image.
 * * `basicAuth`: Basic authentication credentials for image source HTTP/S URL.
 * * `basic_auth.username`: Username for basic authentication.
 * * `basic_auth.password`: Password for basic authentication.
 *
 * ### placementPolicyStatus
 * * `placementPolicyExtId`: Image placement policy external identifier.
 * * `complianceStatus`: Compliance status for a placement policy.
 * * `enforcementMode`: Indicates whether the placement policy enforcement is ongoing or has failed.
 * * `policyClusterExtIds`: List of cluster external identifiers of the image location for the enforced placement policy.
 * * `enforcedClusterExtIds`: List of cluster external identifiers for the enforced placement policy.
 * * `conflictingPolicyExtIds`: List of image placement policy external identifier that conflict with the current one.
 *
 * See detailed information in [Nutanix List Images V4](https://developers.nutanix.com/api-reference?namespace=vmm&version=v4.0#tag/Images)
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
     * A URL query parameter that allows clients to filter a collection of resources. The expression specified with \$filter is evaluated for each resource in the collection, and only items where the expression evaluates to true are included in the response. Expression specified with the \$filter must conform to the OData V4.01 URL conventions. For example, filter '\$filter=name eq 'karbon-ntnx-1.0' would filter the result on cluster name 'karbon-ntnx1.0', filter '\$filter=startswith(name, 'C')' would filter on cluster name starting with 'C'. The filter can be applied to the following fields:
     * - description
     * - name
     * - sizeBytes
     * - type
     */
    filter?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the total number of records returned in the result set. Must be a positive integer between 1 and 100. Any number out of this range will lead to a validation error. If the limit is not provided, a default value of 50 records will be returned in the result set.
     */
    limit?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to specify the sort criteria for the returned list of objects. Resources can be sorted in ascending order using asc or descending order using desc. If asc or desc are not specified, the resources will be sorted in ascending order by default. For example, '\$orderby=templateName desc' would get all templates sorted by templateName in descending order. The orderby can be applied to the following fields:
     * - description
     * - lastUpdateTime
     * - name
     * - sizeBytes
     * - type
     */
    orderBy?: pulumi.Input<string>;
    /**
     * A URL query parameter that specifies the page number of the result set. It must be a positive integer between 0 and the maximum number of pages that are available for that resource. Any number out of this range might lead to no results.
     */
    page?: pulumi.Input<number>;
    /**
     * A URL query parameter that allows clients to request a specific set of properties for each entity or complex type. Expression specified with the \$select must conform to the OData V4.01 URL conventions. If a \$select expression consists of a single select item that is an asterisk (i.e., *), then all properties on the matching resource will be returned. The select can be applied to the following fields:
     * - categoryExtIds
     * - clusterLocationExtIds
     * - createTime
     * - description
     * - extId
     * - lastUpdateTime
     * - links
     * - name
     * - ownerExtId
     * - sizeBytes
     * - tenantId
     * - type
     */
    select?: pulumi.Input<string>;
}
