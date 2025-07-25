// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a resource to create stretched vlans based on the input parameters.
 *
 * ## Example Usage
 *
 * ### resource to add stretched vlan in NDB
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const name = new nutanix.NdbStretchedVlan("name", {
 *     description: "vlan desc updated",
 *     type: "Static",
 *     vlanIds: [
 *         "{{ vlan_id_1 }}",
 *         "{{ vlan_id_2 }}",
 *     ],
 * });
 * ```
 *
 * ### resource to update the strteched vlan with new gateway and subnet mask
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pierskarsenbarg/nutanix";
 *
 * const name = new nutanix.NdbStretchedVlan("name", {
 *     description: "vlan desc updated",
 *     metadata: {
 *         gateway: "{{ gateway of vlans }}",
 *         subnetMask: "{{ subnet mask of vlans }}",
 *     },
 *     type: "Static",
 *     vlanIds: [
 *         "{{ vlan_id_1 }}",
 *         "{{ vlan_id_2 }}",
 *     ],
 * });
 * ```
 */
export class NdbStretchedVlan extends pulumi.CustomResource {
    /**
     * Get an existing NdbStretchedVlan resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NdbStretchedVlanState, opts?: pulumi.CustomResourceOptions): NdbStretchedVlan {
        return new NdbStretchedVlan(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nutanix:index/ndbStretchedVlan:NdbStretchedVlan';

    /**
     * Returns true if the given object is an instance of NdbStretchedVlan.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NdbStretchedVlan {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NdbStretchedVlan.__pulumiType;
    }

    /**
     * Description of stretched vlan
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Update the stretched VLAN Gateway and Subnet Mask IP address
     * * `metadata.gateway`: Update the gateway of stretched vlan
     * * `metadata.subnet_mask`: Update the subnetMask of stretched vlan
     */
    public readonly metadata!: pulumi.Output<outputs.NdbStretchedVlanMetadata>;
    /**
     * name for the stretched VLAN
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * type of vlan. static VLANs that are managed in NDB can be added to a stretched VLAN.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * list of vlan ids to be added in NDB
     */
    public readonly vlanIds!: pulumi.Output<string[]>;
    /**
     * properties of vlans
     */
    public /*out*/ readonly vlansLists!: pulumi.Output<outputs.NdbStretchedVlanVlansList[]>;

    /**
     * Create a NdbStretchedVlan resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NdbStretchedVlanArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NdbStretchedVlanArgs | NdbStretchedVlanState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NdbStretchedVlanState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["vlanIds"] = state ? state.vlanIds : undefined;
            resourceInputs["vlansLists"] = state ? state.vlansLists : undefined;
        } else {
            const args = argsOrState as NdbStretchedVlanArgs | undefined;
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.vlanIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vlanIds'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["vlanIds"] = args ? args.vlanIds : undefined;
            resourceInputs["vlansLists"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(NdbStretchedVlan.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NdbStretchedVlan resources.
 */
export interface NdbStretchedVlanState {
    /**
     * Description of stretched vlan
     */
    description?: pulumi.Input<string>;
    /**
     * Update the stretched VLAN Gateway and Subnet Mask IP address
     * * `metadata.gateway`: Update the gateway of stretched vlan
     * * `metadata.subnet_mask`: Update the subnetMask of stretched vlan
     */
    metadata?: pulumi.Input<inputs.NdbStretchedVlanMetadata>;
    /**
     * name for the stretched VLAN
     */
    name?: pulumi.Input<string>;
    /**
     * type of vlan. static VLANs that are managed in NDB can be added to a stretched VLAN.
     */
    type?: pulumi.Input<string>;
    /**
     * list of vlan ids to be added in NDB
     */
    vlanIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * properties of vlans
     */
    vlansLists?: pulumi.Input<pulumi.Input<inputs.NdbStretchedVlanVlansList>[]>;
}

/**
 * The set of arguments for constructing a NdbStretchedVlan resource.
 */
export interface NdbStretchedVlanArgs {
    /**
     * Description of stretched vlan
     */
    description?: pulumi.Input<string>;
    /**
     * Update the stretched VLAN Gateway and Subnet Mask IP address
     * * `metadata.gateway`: Update the gateway of stretched vlan
     * * `metadata.subnet_mask`: Update the subnetMask of stretched vlan
     */
    metadata?: pulumi.Input<inputs.NdbStretchedVlanMetadata>;
    /**
     * name for the stretched VLAN
     */
    name?: pulumi.Input<string>;
    /**
     * type of vlan. static VLANs that are managed in NDB can be added to a stretched VLAN.
     */
    type: pulumi.Input<string>;
    /**
     * list of vlan ids to be added in NDB
     */
    vlanIds: pulumi.Input<pulumi.Input<string>[]>;
}
