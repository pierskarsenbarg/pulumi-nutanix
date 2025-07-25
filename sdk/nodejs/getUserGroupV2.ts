// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve a user group based on the External Identifier of the User Group.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_ug = nutanix.getUserGroupV2({
 *     extId: "a2a8650a-358a-4791-90c9-7a8b6e2989d6",
 * });
 * ```
 */
export function getUserGroupV2(args: GetUserGroupV2Args, opts?: pulumi.InvokeOptions): Promise<GetUserGroupV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getUserGroupV2:getUserGroupV2", {
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getUserGroupV2.
 */
export interface GetUserGroupV2Args {
    /**
     * - (Required) The External Identifier of the User Group.
     */
    extId: string;
}

/**
 * A collection of values returned by getUserGroupV2.
 */
export interface GetUserGroupV2Result {
    /**
     * - User or Service who created the User Group.
     */
    readonly createdBy: string;
    /**
     * - Creation time of the User Group.
     */
    readonly createdTime: string;
    /**
     * - Identifier for the User Group in the form of a distinguished name.
     */
    readonly distinguishedName: string;
    /**
     * The External Identifier of the User Group.
     */
    readonly extId: string;
    /**
     * - Type of the User Group. LDAP (User Group belonging to a Directory Service (Open LDAP/AD)),  SAML (User Group belonging to a SAML IDP.)
     */
    readonly groupType: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * - Identifier of the IDP for the User Group.
     */
    readonly idpId: string;
    /**
     * - Last updated time of the User Group.
     */
    readonly lastUpdatedTime: string;
    /**
     * - Common Name of the User Group.
     */
    readonly name: string;
}
/**
 * Provides a datasource to retrieve a user group based on the External Identifier of the User Group.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const get_ug = nutanix.getUserGroupV2({
 *     extId: "a2a8650a-358a-4791-90c9-7a8b6e2989d6",
 * });
 * ```
 */
export function getUserGroupV2Output(args: GetUserGroupV2OutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetUserGroupV2Result> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getUserGroupV2:getUserGroupV2", {
        "extId": args.extId,
    }, opts);
}

/**
 * A collection of arguments for invoking getUserGroupV2.
 */
export interface GetUserGroupV2OutputArgs {
    /**
     * - (Required) The External Identifier of the User Group.
     */
    extId: pulumi.Input<string>;
}
