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
    /// A reference to a service account that will be used to request a bound token (also known as "projected token"). Compared to using "secretRef", using this field means that you don't rely on statically bound tokens. To use this field, you must configure an RBAC rule to let cert-manager request a token.
    /// </summary>
    public class IssuerSpecVaultAuthKubernetesServiceAccountRefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the ServiceAccount used to request a token.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public IssuerSpecVaultAuthKubernetesServiceAccountRefArgs()
        {
        }
        public static new IssuerSpecVaultAuthKubernetesServiceAccountRefArgs Empty => new IssuerSpecVaultAuthKubernetesServiceAccountRefArgs();
    }
}
