// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Provides a datasource to retrieve a user group based on the input parameters.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * //Retrieve by UUID
 * const usergroup = pulumi.output(nutanix.getUserGroup({
 *     userGroupId: "dd30a856-8e72-4158-b716-98455ceda220",
 * }));
 * //Retrieve by Name
 * const usergroupbyname = pulumi.output(nutanix.getUserGroup({
 *     userGroupName: "example-group-1",
 * }));
 * //Retrieve by Distinguished Name
 * const test = pulumi.output(nutanix.getUserGroup({
 *     userGroupDistinguishedName: "cn=example-group-1,cn=users,dc=ntnxlab,dc=local",
 * }));
 * ```
 */
export function getUserGroup(args?: GetUserGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetUserGroupResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getUserGroup:getUserGroup", {
        "categories": args.categories,
        "ownerReference": args.ownerReference,
        "projectReference": args.projectReference,
        "userGroupDistinguishedName": args.userGroupDistinguishedName,
        "userGroupId": args.userGroupId,
        "userGroupName": args.userGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getUserGroup.
 */
export interface GetUserGroupArgs {
    categories?: inputs.GetUserGroupCategory[];
    ownerReference?: {[key: string]: string};
    projectReference?: {[key: string]: string};
    /**
     * The distinguished name for the user group
     */
    userGroupDistinguishedName?: string;
    userGroupId?: string;
    userGroupName?: string;
}

/**
 * A collection of values returned by getUserGroup.
 */
export interface GetUserGroupResult {
    readonly accessControlPolicyReferenceLists: outputs.GetUserGroupAccessControlPolicyReferenceList[];
    /**
     * The version of the API.
     * * `metadata`: - The user group kind metadata.
     * * `categories`: - The Distinguished Categories for the user group.
     * * `ownerReference`: - The reference to a user.
     * * `projectReference`: - The Distinguished The reference to a project.
     * * `userGroupType`: - The type of the user group.
     * * `displayName`: - The display name of the user group.
     * * `directoryServiceUserGroup`: - A Directory Service User Group.
     * * `projectReferenceList`: - A list of projects the user is part of. See #reference for more details.
     * * `accessControlPolicyReferenceList`: - List of ACP references. See #reference for more details.
     * * `state`: - The state of the entity.
     */
    readonly apiVersion: string;
    readonly categories: outputs.GetUserGroupCategory[];
    readonly directoryServiceUserGroups: outputs.GetUserGroupDirectoryServiceUserGroup[];
    readonly displayName: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly metadata: {[key: string]: string};
    readonly ownerReference: {[key: string]: string};
    readonly projectReference?: {[key: string]: string};
    readonly projectReferenceLists: outputs.GetUserGroupProjectReferenceList[];
    readonly state: string;
    readonly userGroupDistinguishedName?: string;
    readonly userGroupId?: string;
    readonly userGroupName?: string;
    readonly userGroupType: string;
}

export function getUserGroupOutput(args?: GetUserGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetUserGroupResult> {
    return pulumi.output(args).apply(a => getUserGroup(a, opts))
}

/**
 * A collection of arguments for invoking getUserGroup.
 */
export interface GetUserGroupOutputArgs {
    categories?: pulumi.Input<pulumi.Input<inputs.GetUserGroupCategoryArgs>[]>;
    ownerReference?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    projectReference?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The distinguished name for the user group
     */
    userGroupDistinguishedName?: pulumi.Input<string>;
    userGroupId?: pulumi.Input<string>;
    userGroupName?: pulumi.Input<string>;
}