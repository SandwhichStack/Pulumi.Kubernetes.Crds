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
    /// Kubernetes authenticates with Vault by passing the ServiceAccount token stored in the named Secret resource to the Vault server.
    /// </summary>
    public class ClusterIssuerSpecVaultAuthKubernetesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Vault mountPath here is the mount path to use when authenticating with Vault. For example, setting a value to `/v1/auth/foo`, will use the path `/v1/auth/foo/login` to authenticate with Vault. If unspecified, the default value "/v1/auth/kubernetes" will be used.
        /// </summary>
        [Input("mountPath")]
        public Input<string>? MountPath { get; set; }

        /// <summary>
        /// A required field containing the Vault Role to assume. A Role binds a Kubernetes ServiceAccount with a set of Vault policies.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The required Secret field containing a Kubernetes ServiceAccount JWT used for authenticating with Vault. Use of 'ambient credentials' is not supported.
        /// </summary>
        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.ClusterIssuerSpecVaultAuthKubernetesSecretRefArgs>? SecretRef { get; set; }

        /// <summary>
        /// A reference to a service account that will be used to request a bound token (also known as "projected token"). Compared to using "secretRef", using this field means that you don't rely on statically bound tokens. To use this field, you must configure an RBAC rule to let cert-manager request a token.
        /// </summary>
        [Input("serviceAccountRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.ClusterIssuerSpecVaultAuthKubernetesServiceAccountRefArgs>? ServiceAccountRef { get; set; }

        public ClusterIssuerSpecVaultAuthKubernetesArgs()
        {
        }
        public static new ClusterIssuerSpecVaultAuthKubernetesArgs Empty => new ClusterIssuerSpecVaultAuthKubernetesArgs();
    }
}
