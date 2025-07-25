// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Describes a list of nos (aos) packages present in foundation vm
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const nosPackages = nutanix.getFoundationNosPackages({});
 * ```
 *
 * ## Note
 *
 * * This data source only lists .tar file names.
 *
 * See detailed information in [Nutanix Foundation Nos Packages](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjMzODg-get-list-of-aos-packages-available-in-foundation).
 */
export function getFoundationNosPackages(opts?: pulumi.InvokeOptions): Promise<GetFoundationNosPackagesResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getFoundationNosPackages:getFoundationNosPackages", {
    }, opts);
}

/**
 * A collection of values returned by getFoundationNosPackages.
 */
export interface GetFoundationNosPackagesResult {
    /**
     * List of nos packages file names present in foundation vm
     */
    readonly entities: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
/**
 * Describes a list of nos (aos) packages present in foundation vm
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const nosPackages = nutanix.getFoundationNosPackages({});
 * ```
 *
 * ## Note
 *
 * * This data source only lists .tar file names.
 *
 * See detailed information in [Nutanix Foundation Nos Packages](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjMzODg-get-list-of-aos-packages-available-in-foundation).
 */
export function getFoundationNosPackagesOutput(opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetFoundationNosPackagesResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getFoundationNosPackages:getFoundationNosPackages", {
    }, opts);
}
