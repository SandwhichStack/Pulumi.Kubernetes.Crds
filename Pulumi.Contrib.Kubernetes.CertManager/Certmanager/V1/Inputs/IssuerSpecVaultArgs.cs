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
    /// Vault configures this issuer to sign certificates using a HashiCorp Vault PKI backend.
    /// </summary>
    public class IssuerSpecVaultArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Auth configures how cert-manager authenticates with the Vault server.
        /// </summary>
        [Input("auth", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecVaultAuthArgs> Auth { get; set; } = null!;

        /// <summary>
        /// Base64-encoded bundle of PEM CAs which will be used to validate the certificate chain presented by Vault. Only used if using HTTPS to connect to Vault and ignored for HTTP connections. Mutually exclusive with CABundleSecretRef. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection.
        /// </summary>
        [Input("caBundle")]
        public Input<string>? CaBundle { get; set; }

        /// <summary>
        /// Reference to a Secret containing a bundle of PEM-encoded CAs to use when verifying the certificate chain presented by Vault when using HTTPS. Mutually exclusive with CABundle. If neither CABundle nor CABundleSecretRef are defined, the certificate bundle in the cert-manager controller container is used to validate the TLS connection. If no key for the Secret is specified, cert-manager will default to 'ca.crt'.
        /// </summary>
        [Input("caBundleSecretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecVaultCaBundleSecretRefArgs>? CaBundleSecretRef { get; set; }

        /// <summary>
        /// Name of the vault namespace. Namespaces is a set of features within Vault Enterprise that allows Vault environments to support Secure Multi-tenancy. e.g: "ns1" More about namespaces can be found here https://www.vaultproject.io/docs/enterprise/namespaces
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Path is the mount path of the Vault PKI backend's `sign` endpoint, e.g: "my_pki_mount/sign/my-role-name".
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// Server is the connection address for the Vault server, e.g: "https://vault.example.com:8200".
        /// </summary>
        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        public IssuerSpecVaultArgs()
        {
        }
        public static new IssuerSpecVaultArgs Empty => new IssuerSpecVaultArgs();
    }
}
