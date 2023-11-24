// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Certmanager.V1
{

    /// <summary>
    /// Use the Akamai DNS zone management API to manage DNS01 challenge records.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecAcmeSolversDns01Akamai
    {
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef AccessTokenSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef ClientSecretSecretRef;
        /// <summary>
        /// A reference to a specific 'key' within a Secret resource. In some instances, `key` is a required field.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef ClientTokenSecretRef;
        public readonly string ServiceConsumerDomain;

        [OutputConstructor]
        private IssuerSpecAcmeSolversDns01Akamai(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiAccessTokenSecretRef accessTokenSecretRef,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiClientSecretSecretRef clientSecretSecretRef,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AkamaiClientTokenSecretRef clientTokenSecretRef,

            string serviceConsumerDomain)
        {
            AccessTokenSecretRef = accessTokenSecretRef;
            ClientSecretSecretRef = clientSecretSecretRef;
            ClientTokenSecretRef = clientTokenSecretRef;
            ServiceConsumerDomain = serviceConsumerDomain;
        }
    }
}
