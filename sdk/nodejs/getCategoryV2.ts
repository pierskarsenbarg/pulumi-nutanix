// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Fetch a category
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_category = nutanix.getCategoryV2({
 *     extId: "85e68112-5b2b-4220-bc8d-e529e4bf420e",
 * });
 * ```
 */
export function getCategoryV2(args: GetCategoryV2Args, opts?: pulumi.InvokeOptions): Promise<GetCategoryV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getCategoryV2:getCategoryV2", {
        "expand": args.expand,
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCategoryV2.
 */
export interface GetCategoryV2Args {
    /**
     * A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby. The following expansion keys are supported:
     * - associations
     * - detailedAssociations
     */
    expand?: string;
    /**
     * The extID for the category.
     */
    extId: string;
}

/**
 * A collection of values returned by getCategoryV2.
 */
export interface GetCategoryV2Result {
    /**
     * This field gives basic information about resources that are associated to the category.
     */
    readonly associations: outputs.GetCategoryV2Association[];
    /**
     * A string consisting of the description of the category as defined by the user.
     */
    readonly description: string;
    /**
     * This field gives detailed information about resources that are associated to the category.
     */
    readonly detailedAssociations: outputs.GetCategoryV2DetailedAssociation[];
    readonly expand?: string;
    readonly extId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The key of a category when it is represented in key:value format.
     */
    readonly key: string;
    /**
     * A HATEOAS style link for the response. Each link contains a user-friendly name identifying the link and an address for retrieving the particular resource.
     */
    readonly links: outputs.GetCategoryV2Link[];
    /**
     * This field contains the UUID of a user who owns the category.
     */
    readonly ownerUuid: string;
    /**
     * A globally unique identifier that represents the tenant that owns this entity.
     */
    readonly tenantId: string;
    /**
     * Denotes the type of a category.
     * There are three types of categories: SYSTEM, INTERNAL, and USER.
     */
    readonly type: string;
    /**
     * The value of a category when it is represented in key:value format
     */
    readonly value: string;
}
/**
 * Fetch a category
 *
 * ## Example
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_category = nutanix.getCategoryV2({
 *     extId: "85e68112-5b2b-4220-bc8d-e529e4bf420e",
 * });
 * ```
 */
export function getCategoryV2Output(args: GetCategoryV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetCategoryV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getCategoryV2:getCategoryV2", {
        "expand": args.expand,
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCategoryV2.
 */
export interface GetCategoryV2OutputArgs {
    /**
     * A URL query parameter that allows clients to request related resources when a resource that satisfies a particular request is retrieved. Each expanded item is evaluated relative to the entity containing the property being expanded. Other query options can be applied to an expanded property by appending a semicolon-separated list of query options, enclosed in parentheses, to the property name. Permissible system query options are \$filter, \$select and \$orderby. The following expansion keys are supported:
     * - associations
     * - detailedAssociations
     */
    expand?: pulumi.Input<string>;
    /**
     * The extID for the category.
     */
    extId: pulumi.Input<string>;
}
