// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class FoundationIpmiConfig extends pulumi.CustomResource {
    /**
     * Get an existing FoundationIpmiConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FoundationIpmiConfigState, opts?: pulumi.CustomResourceOptions): FoundationIpmiConfig {
        return new FoundationIpmiConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/foundationIpmiConfig:FoundationIpmiConfig';

    /**
     * Returns true if the given object is an instance of FoundationIpmiConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FoundationIpmiConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FoundationIpmiConfig.__pulumiType;
    }

    public readonly blocks!: pulumi.Output<outputs.FoundationIpmiConfigBlock[]>;
    public readonly ipmiGateway!: pulumi.Output<string>;
    public readonly ipmiNetmask!: pulumi.Output<string>;
    public readonly ipmiPassword!: pulumi.Output<string>;
    public readonly ipmiUser!: pulumi.Output<string>;

    /**
     * Create a FoundationIpmiConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FoundationIpmiConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FoundationIpmiConfigArgs | FoundationIpmiConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FoundationIpmiConfigState | undefined;
            resourceInputs["blocks"] = state ? state.blocks : undefined;
            resourceInputs["ipmiGateway"] = state ? state.ipmiGateway : undefined;
            resourceInputs["ipmiNetmask"] = state ? state.ipmiNetmask : undefined;
            resourceInputs["ipmiPassword"] = state ? state.ipmiPassword : undefined;
            resourceInputs["ipmiUser"] = state ? state.ipmiUser : undefined;
        } else {
            const args = argsOrState as FoundationIpmiConfigArgs | undefined;
            if ((!args || args.blocks === undefined) && !opts.urn) {
                throw new Error("Missing required property 'blocks'");
            }
            if ((!args || args.ipmiGateway === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipmiGateway'");
            }
            if ((!args || args.ipmiNetmask === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipmiNetmask'");
            }
            if ((!args || args.ipmiPassword === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipmiPassword'");
            }
            if ((!args || args.ipmiUser === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipmiUser'");
            }
            resourceInputs["blocks"] = args ? args.blocks : undefined;
            resourceInputs["ipmiGateway"] = args ? args.ipmiGateway : undefined;
            resourceInputs["ipmiNetmask"] = args ? args.ipmiNetmask : undefined;
            resourceInputs["ipmiPassword"] = args ? args.ipmiPassword : undefined;
            resourceInputs["ipmiUser"] = args ? args.ipmiUser : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FoundationIpmiConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FoundationIpmiConfig resources.
 */
export interface FoundationIpmiConfigState {
    blocks?: pulumi.Input<pulumi.Input<inputs.FoundationIpmiConfigBlock>[]>;
    ipmiGateway?: pulumi.Input<string>;
    ipmiNetmask?: pulumi.Input<string>;
    ipmiPassword?: pulumi.Input<string>;
    ipmiUser?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FoundationIpmiConfig resource.
 */
export interface FoundationIpmiConfigArgs {
    blocks: pulumi.Input<pulumi.Input<inputs.FoundationIpmiConfigBlock>[]>;
    ipmiGateway: pulumi.Input<string>;
    ipmiNetmask: pulumi.Input<string>;
    ipmiPassword: pulumi.Input<string>;
    ipmiUser: pulumi.Input<string>;
}