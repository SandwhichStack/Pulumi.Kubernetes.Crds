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
    /// Reference to the issuer responsible for issuing the certificate. If the issuer is namespace-scoped, it must be in the same namespace as the Certificate. If the issuer is cluster-scoped, it can be used from any namespace. 
    ///  The `name` field of the reference must always be specified.
    /// </summary>
    public class CertificateSpecIssuerRefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Group of the resource being referred to.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        /// <summary>
        /// Kind of the resource being referred to.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of the resource being referred to.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public CertificateSpecIssuerRefArgs()
        {
        }
        public static new CertificateSpecIssuerRefArgs Empty => new CertificateSpecIssuerRefArgs();
    }
}
