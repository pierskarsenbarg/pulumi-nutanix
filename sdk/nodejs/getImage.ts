// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Describes a Image
 */
export function getImage(args?: GetImageArgs, opts?: pulumi.InvokeOptions): Promise<GetImageResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("nutanix:index/getImage:getImage", {
        "categories": args.categories,
        "imageId": args.imageId,
        "imageName": args.imageName,
    }, opts);
}

/**
 * A collection of arguments for invoking getImage.
 */
export interface GetImageArgs {
    /**
     * - Categories for the image.
     */
    categories?: inputs.GetImageCategory[];
    /**
     * Represents image UUID
     */
    imageId?: string;
    /**
     * Represents image name
     */
    imageName?: string;
}

/**
 * A collection of values returned by getImage.
 */
export interface GetImageResult {
    readonly apiVersion: string;
    /**
     * - The supported CPU architecture for a disk image.
     */
    readonly architecture: string;
    /**
     * - The reference to a availability_zone.
     */
    readonly availabilityZoneReference: {[key: string]: string};
    /**
     * - Categories for the image.
     */
    readonly categories: outputs.GetImageCategory[];
    /**
     * - Checksum of the image. The checksum is used for image validation if the image has a source specified. For images that do not have their source specified the checksum is generated by the image service.
     */
    readonly checksum: {[key: string]: string};
    readonly clusterName: string;
    readonly clusterReferences: outputs.GetImageClusterReference[];
    readonly clusterUuid: string;
    readonly currentClusterReferenceLists: outputs.GetImageCurrentClusterReferenceList[];
    /**
     * - Reference to a data source.
     */
    readonly dataSourceReferences: outputs.GetImageDataSourceReference[];
    /**
     * - A description for image.
     */
    readonly description: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly imageId?: string;
    readonly imageName?: string;
    /**
     * - The type of image.
     */
    readonly imageType: string;
    /**
     * - The image kind metadata.
     */
    readonly metadata: {[key: string]: string};
    /**
     * - the name.
     */
    readonly name: string;
    /**
     * - The reference to a user.
     */
    readonly ownerReference: {[key: string]: string};
    /**
     * - The reference to a project.
     */
    readonly projectReference: {[key: string]: string};
    /**
     * - List of URIs where the raw image data can be accessed.
     */
    readonly retrievalUriLists: string[];
    /**
     * - The size of the image in bytes.
     */
    readonly sizeBytes: number;
    /**
     * - The source URI points at the location of the source image which is used to create/update image.
     */
    readonly sourceUri: string;
    /**
     * - The state of the image.
     */
    readonly state: string;
    /**
     * - The image version.
     */
    readonly version: {[key: string]: string};
}
/**
 * Describes a Image
 */
export function getImageOutput(args?: GetImageOutputArgs, opts?: pulumi.InvokeOutputOptions): pulumi.Output<GetImageResult> {
    args = args || {};
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("nutanix:index/getImage:getImage", {
        "categories": args.categories,
        "imageId": args.imageId,
        "imageName": args.imageName,
    }, opts);
}

/**
 * A collection of arguments for invoking getImage.
 */
export interface GetImageOutputArgs {
    /**
     * - Categories for the image.
     */
    categories?: pulumi.Input<pulumi.Input<inputs.GetImageCategoryArgs>[]>;
    /**
     * Represents image UUID
     */
    imageId?: pulumi.Input<string>;
    /**
     * Represents image name
     */
    imageName?: pulumi.Input<string>;
}
