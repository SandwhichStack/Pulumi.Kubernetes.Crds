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
    /// An ACMEChallengeSolver describes how to solve ACME challenges for the issuer it is part of. A selector may be provided to use different solving strategies for different DNS names. Only one of HTTP01 or DNS01 must be provided.
    /// </summary>
    [OutputType]
    public sealed class IssuerSpecAcmeSolvers
    {
        /// <summary>
        /// Configures cert-manager to attempt to complete authorizations by performing the DNS01 challenge flow.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01 Dns01;
        /// <summary>
        /// Configures cert-manager to attempt to complete authorizations by performing the HTTP01 challenge flow. It is not possible to obtain certificates for wildcard domain names (e.g. `*.example.com`) using the HTTP01 challenge mechanism.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversHttp01 Http01;
        /// <summary>
        /// Selector selects a set of DNSNames on the Certificate resource that should be solved using this challenge solver. If not specified, the solver will be treated as the 'default' solver with the lowest priority, i.e. if any other solver has a more specific match, it will be used instead.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversSelector Selector;

        [OutputConstructor]
        private IssuerSpecAcmeSolvers(
            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversDns01 dns01,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversHttp01 http01,

            Pulumi.Kubernetes.Types.Outputs.Certmanager.V1.IssuerSpecAcmeSolversSelector selector)
        {
            Dns01 = dns01;
            Http01 = http01;
            Selector = selector;
        }
    }
}
