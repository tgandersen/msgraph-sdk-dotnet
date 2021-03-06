// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagementAgentType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagementAgentType
    {
    
        /// <summary>
        /// eas
        /// </summary>
        Eas = 1,
	
        /// <summary>
        /// mdm
        /// </summary>
        Mdm = 2,
	
        /// <summary>
        /// eas Mdm
        /// </summary>
        EasMdm = 3,
	
        /// <summary>
        /// intune Client
        /// </summary>
        IntuneClient = 4,
	
        /// <summary>
        /// eas Intune Client
        /// </summary>
        EasIntuneClient = 5,
	
        /// <summary>
        /// configuration Manager Client
        /// </summary>
        ConfigurationManagerClient = 8,
	
        /// <summary>
        /// configuration Manager Client Mdm
        /// </summary>
        ConfigurationManagerClientMdm = 10,
	
        /// <summary>
        /// configuration Manager Client Mdm Eas
        /// </summary>
        ConfigurationManagerClientMdmEas = 11,
	
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 16,
	
        /// <summary>
        /// jamf
        /// </summary>
        Jamf = 32,
	
        /// <summary>
        /// google Cloud Device Policy Controller
        /// </summary>
        GoogleCloudDevicePolicyController = 64,
	
    }
}
