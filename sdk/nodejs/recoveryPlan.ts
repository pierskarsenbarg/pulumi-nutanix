// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Nutanix Recovery Plan resource to Create a Recovery Plan.
 */
export class RecoveryPlan extends pulumi.CustomResource {
    /**
     * Get an existing RecoveryPlan resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RecoveryPlanState, opts?: pulumi.CustomResourceOptions): RecoveryPlan {
        return new RecoveryPlan(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/recoveryPlan:RecoveryPlan';

    /**
     * Returns true if the given object is an instance of RecoveryPlan.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RecoveryPlan {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RecoveryPlan.__pulumiType;
    }

    public /*out*/ readonly apiVersion!: pulumi.Output<string>;
    public readonly categories!: pulumi.Output<outputs.RecoveryPlanCategory[]>;
    /**
     * A description for Recovery Plan.
     */
    public readonly description!: pulumi.Output<string>;
    public /*out*/ readonly metadata!: pulumi.Output<{[key: string]: string}>;
    /**
     * The name for the Recovery Plan.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly ownerReference!: pulumi.Output<outputs.RecoveryPlanOwnerReference>;
    public readonly parameters!: pulumi.Output<outputs.RecoveryPlanParameters>;
    public readonly projectReference!: pulumi.Output<outputs.RecoveryPlanProjectReference>;
    public readonly stageLists!: pulumi.Output<outputs.RecoveryPlanStageList[]>;
    public /*out*/ readonly state!: pulumi.Output<string>;

    /**
     * Create a RecoveryPlan resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RecoveryPlanArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RecoveryPlanArgs | RecoveryPlanState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RecoveryPlanState | undefined;
            resourceInputs["apiVersion"] = state ? state.apiVersion : undefined;
            resourceInputs["categories"] = state ? state.categories : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["ownerReference"] = state ? state.ownerReference : undefined;
            resourceInputs["parameters"] = state ? state.parameters : undefined;
            resourceInputs["projectReference"] = state ? state.projectReference : undefined;
            resourceInputs["stageLists"] = state ? state.stageLists : undefined;
            resourceInputs["state"] = state ? state.state : undefined;
        } else {
            const args = argsOrState as RecoveryPlanArgs | undefined;
            if ((!args || args.parameters === undefined) && !opts.urn) {
                throw new Error("Missing required property 'parameters'");
            }
            if ((!args || args.stageLists === undefined) && !opts.urn) {
                throw new Error("Missing required property 'stageLists'");
            }
            resourceInputs["categories"] = args ? args.categories : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["ownerReference"] = args ? args.ownerReference : undefined;
            resourceInputs["parameters"] = args ? args.parameters : undefined;
            resourceInputs["projectReference"] = args ? args.projectReference : undefined;
            resourceInputs["stageLists"] = args ? args.stageLists : undefined;
            resourceInputs["apiVersion"] = undefined /*out*/;
            resourceInputs["metadata"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RecoveryPlan.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RecoveryPlan resources.
 */
export interface RecoveryPlanState {
    apiVersion?: pulumi.Input<string>;
    categories?: pulumi.Input<pulumi.Input<inputs.RecoveryPlanCategory>[]>;
    /**
     * A description for Recovery Plan.
     */
    description?: pulumi.Input<string>;
    metadata?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name for the Recovery Plan.
     */
    name?: pulumi.Input<string>;
    ownerReference?: pulumi.Input<inputs.RecoveryPlanOwnerReference>;
    parameters?: pulumi.Input<inputs.RecoveryPlanParameters>;
    projectReference?: pulumi.Input<inputs.RecoveryPlanProjectReference>;
    stageLists?: pulumi.Input<pulumi.Input<inputs.RecoveryPlanStageList>[]>;
    state?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RecoveryPlan resource.
 */
export interface RecoveryPlanArgs {
    categories?: pulumi.Input<pulumi.Input<inputs.RecoveryPlanCategory>[]>;
    /**
     * A description for Recovery Plan.
     */
    description?: pulumi.Input<string>;
    /**
     * The name for the Recovery Plan.
     */
    name?: pulumi.Input<string>;
    ownerReference?: pulumi.Input<inputs.RecoveryPlanOwnerReference>;
    parameters: pulumi.Input<inputs.RecoveryPlanParameters>;
    projectReference?: pulumi.Input<inputs.RecoveryPlanProjectReference>;
    stageLists: pulumi.Input<pulumi.Input<inputs.RecoveryPlanStageList>[]>;
}
