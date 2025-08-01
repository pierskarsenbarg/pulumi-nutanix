// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve all Directory Service(s).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_active_directory = nutanix.getDirectoryServiceV2({
 *     extId: "8a938cc5-282b-48c4-81be-de22de145d07",
 * });
 * ```
 */
export function getDirectoryServiceV2(args: GetDirectoryServiceV2Args, opts?: pulumi.InvokeOptions): Promise<GetDirectoryServiceV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getDirectoryServiceV2:getDirectoryServiceV2", {
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getDirectoryServiceV2.
 */
export interface GetDirectoryServiceV2Args {
    /**
     * -(Required) External identifier of the Directory Service.
     */
    extId: string;
}

/**
 * A collection of values returned by getDirectoryServiceV2.
 */
export interface GetDirectoryServiceV2Result {
    /**
     * - User or Service who created the Directory Service.
     */
    readonly createdBy: string;
    /**
     * - Creation time of the Directory Service.
     */
    readonly createdTime: string;
    /**
     * - Type of Directory Service, Supported values are: "ACTIVE_DIRECTORY" (Directory Service type is Active Directory.) and "OPEN_LDAP" (Directory Service type is Open LDAP.)
     */
    readonly directoryType: string;
    /**
     * - Domain name for the Directory Service.
     */
    readonly domainName: string;
    /**
     * - A globally unique identifier of an instance that is suitable for external consumption.
     */
    readonly extId: string;
    /**
     * - Group membership search type for the Directory Service. Supported values are: "NON_RECURSIVE" (Doesn't search recursively within groups.) and "RECURSIVE" (Searches recursively within groups.)
     */
    readonly groupSearchType: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * - Last updated time of the Directory Service.
     */
    readonly lastUpdatedTime: string;
    /**
     * - Name for the Directory Service.
     */
    readonly name: string;
    /**
     * - Configuration for OpenLDAP Directory Service.
     */
    readonly openLdapConfigurations: outputs.GetDirectoryServiceV2OpenLdapConfiguration[];
    /**
     * - Secondary URL for the Directory Service.
     */
    readonly secondaryUrls: string[];
    /**
     * - Information of Service account to connect to the Directory Service.
     */
    readonly serviceAccounts: outputs.GetDirectoryServiceV2ServiceAccount[];
    /**
     * - URL for the Directory Service.
     */
    readonly url: string;
    /**
     * - List of allowed User Groups for the Directory Service.
     */
    readonly whiteListedGroups: string[];
}
/**
 * Provides a datasource to retrieve all Directory Service(s).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_active_directory = nutanix.getDirectoryServiceV2({
 *     extId: "8a938cc5-282b-48c4-81be-de22de145d07",
 * });
 * ```
 */
export function getDirectoryServiceV2Output(args: GetDirectoryServiceV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetDirectoryServiceV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getDirectoryServiceV2:getDirectoryServiceV2", {
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getDirectoryServiceV2.
 */
export interface GetDirectoryServiceV2OutputArgs {
    /**
     * -(Required) External identifier of the Directory Service.
     */
    extId: pulumi.Input<string>;
}
