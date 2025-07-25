// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Describes a time machine present in Nutanix Database Service
 */
export function getNdbTimeMachine(args?: GetNdbTimeMachineArgs, opts?: pulumi.InvokeOptions): Promise<GetNdbTimeMachineResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getNdbTimeMachine:getNdbTimeMachine", {
        "tags": args.tags,
        "timeMachineId": args.timeMachineId,
        "timeMachineName": args.timeMachineName,
    }, opts);
}

/**
 * A collection of arguments for invoking getNdbTimeMachine.
 */
export interface GetNdbTimeMachineArgs {
    /**
     * tags
     */
    tags?: inputs.GetNdbTimeMachineTag[];
    /**
     * time machine id
     */
    timeMachineId?: string;
    /**
     * time machine name
     */
    timeMachineName?: string;
}

/**
 * A collection of values returned by getNdbTimeMachine.
 */
export interface GetNdbTimeMachineResult {
    /**
     * access level to time machines
     */
    readonly accessLevel: string;
    /**
     * category of time machine
     */
    readonly category: string;
    /**
     * clone time machine or not
     */
    readonly clone: boolean;
    /**
     * clone info
     */
    readonly clones: string;
    /**
     * clustered or not
     */
    readonly clustered: boolean;
    /**
     * database info
     */
    readonly database: string;
    /**
     * database id
     */
    readonly databaseId: string;
    /**
     * date created
     */
    readonly dateCreated: string;
    /**
     * date modified
     */
    readonly dateModified: string;
    /**
     * time machine description
     */
    readonly description: string;
    /**
     * ea status of time machine
     */
    readonly eaStatus: string;
    /**
     * time machine id
     */
    readonly id: string;
    readonly internal: boolean;
    /**
     * Metric info
     */
    readonly metric: string;
    /**
     * time machine name
     */
    readonly name: string;
    readonly ownerId: string;
    /**
     * properties of time machines
     */
    readonly properties: outputs.GetNdbTimeMachineProperty[];
    /**
     * schedule id
     */
    readonly scheduleId: string;
    /**
     * schedule info
     */
    readonly schedules: outputs.GetNdbTimeMachineSchedule[];
    /**
     * scope
     */
    readonly scope: string;
    /**
     * sla id
     */
    readonly slaId: string;
    /**
     * sla update in progress
     */
    readonly slaUpdateInProgress: boolean;
    /**
     * sla update metadata
     */
    readonly slaUpdateMetadata: string;
    /**
     * sla info
     */
    readonly slas: outputs.GetNdbTimeMachineSla[];
    /**
     * source clusters
     */
    readonly sourceNxClusters: string[];
    /**
     * status of time machine
     */
    readonly status: string;
    /**
     * tags
     */
    readonly tags: outputs.GetNdbTimeMachineTag[];
    readonly timeMachineId?: string;
    readonly timeMachineName?: string;
    /**
     * type of time machine
     */
    readonly type: string;
}
/**
 * Describes a time machine present in Nutanix Database Service
 */
export function getNdbTimeMachineOutput(args?: GetNdbTimeMachineOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetNdbTimeMachineResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getNdbTimeMachine:getNdbTimeMachine", {
        "tags": args.tags,
        "timeMachineId": args.timeMachineId,
        "timeMachineName": args.timeMachineName,
    }, opts);
}

/**
 * A collection of arguments for invoking getNdbTimeMachine.
 */
export interface GetNdbTimeMachineOutputArgs {
    /**
     * tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.GetNdbTimeMachineTagArgs>[]>;
    /**
     * time machine id
     */
    timeMachineId?: pulumi.Input<string>;
    /**
     * time machine name
     */
    timeMachineName?: pulumi.Input<string>;
}
