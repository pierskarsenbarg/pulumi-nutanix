// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Describes a list of hypervisor isos image file details present in foundation vm
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nutanix from "@pulumi/nutanix";
 *
 * const hypervisorIsos = pulumi.output(nutanix.getFoundationHypervisorIsos());
 * ```
 * ## Note
 *
 * * This data source only lists .iso files details.
 *
 * See detailed information in [Nutanix Foundation Hypervisor Isos](https://www.nutanix.dev/api_references/foundation/#/b3A6MjIyMjM0MDE-list-hypervisor-images-available-in-foundation).
 */
export function getFoundationHypervisorIsos(opts?: pulumi.InvokeOptions): Promise<GetFoundationHypervisorIsosResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("nutanix:index/getFoundationHypervisorIsos:getFoundationHypervisorIsos", {
    }, opts);
}

/**
 * A collection of values returned by getFoundationHypervisorIsos.
 */
export interface GetFoundationHypervisorIsosResult {
    readonly esxes: outputs.GetFoundationHypervisorIsosEsx[];
    readonly hypervs: outputs.GetFoundationHypervisorIsosHyperv[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly kvms: outputs.GetFoundationHypervisorIsosKvm[];
    readonly linuxes: outputs.GetFoundationHypervisorIsosLinux[];
    readonly xens: outputs.GetFoundationHypervisorIsosXen[];
}