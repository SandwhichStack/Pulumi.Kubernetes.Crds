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
    /// Use the Microsoft Azure DNS API to manage DNS01 challenge records.
    /// </summary>
    public class IssuerSpecAcmeSolversDns01AzureDNSArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// if both this and ClientSecret are left unset MSI will be used
        /// </summary>
        [Input("clientID")]
        public Input<string>? ClientID { get; set; }

        /// <summary>
        /// if both this and ClientID are left unset MSI will be used
        /// </summary>
        [Input("clientSecretSecretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AzureDNSClientSecretSecretRefArgs>? ClientSecretSecretRef { get; set; }

        /// <summary>
        /// name of the Azure environment (default AzurePublicCloud)
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// name of the DNS zone that should be used
        /// </summary>
        [Input("hostedZoneName")]
        public Input<string>? HostedZoneName { get; set; }

        /// <summary>
        /// managed identity configuration, can not be used at the same time as clientID, clientSecretSecretRef or tenantID
        /// </summary>
        [Input("managedIdentity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.IssuerSpecAcmeSolversDns01AzureDNSManagedIdentityArgs>? ManagedIdentity { get; set; }

        /// <summary>
        /// resource group the DNS zone is located in
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// ID of the Azure subscription
        /// </summary>
        [Input("subscriptionID", required: true)]
        public Input<string> SubscriptionID { get; set; } = null!;

        /// <summary>
        /// when specifying ClientID and ClientSecret then this field is also needed
        /// </summary>
        [Input("tenantID")]
        public Input<string>? TenantID { get; set; }

        public IssuerSpecAcmeSolversDns01AzureDNSArgs()
        {
        }
        public static new IssuerSpecAcmeSolversDns01AzureDNSArgs Empty => new IssuerSpecAcmeSolversDns01AzureDNSArgs();
    }
}
