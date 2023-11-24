// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1
{

    /// <summary>
    /// If specified, the pod's scheduling constraints
    /// </summary>
    public class IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        [Input("nodeAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityNodeAffinityArgs>? NodeAffinity { get; set; }

        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        [Input("podAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAffinityArgs>? PodAffinity { get; set; }

        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        [Input("podAntiAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityPodAntiAffinityArgs>? PodAntiAffinity { get; set; }

        public IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityArgs()
        {
        }
        public static new IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityArgs Empty => new IssuerSpecAcmeSolversHttp01IngressPodTemplateSpecAffinityArgs();
    }
}
