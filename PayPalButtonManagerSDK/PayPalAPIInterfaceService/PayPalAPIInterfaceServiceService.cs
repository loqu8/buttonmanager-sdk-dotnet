using System;
using System.Collections.Generic;
using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.SOAP;
using PayPal.PayPalAPIInterfaceService.Model;
using System.Threading.Tasks;

namespace PayPal.PayPalAPIInterfaceService 
{
	public partial class PayPalAPIInterfaceServiceService : BasePayPalService 
	{

		/// <summary>
		/// Service Version
		/// </summary>
		private const string ServiceVersion = "98.0";

		/// <summary>
		/// Service Name
		/// </summary>
		private const string ServiceName = "PayPalAPIInterfaceService";
		
		/// <summary>
		/// SDK Name
		/// </summary>
		private const string SDKName = "buttonmanager-dotnet-sdk";
	
		/// <summary>
		/// SDK Version
		/// </summary>
		private const string SDKVersion = "2.5.103";

		/// <summary>
		/// Default constructor for loading configuration from *.Config file
		/// </summary>
		public PayPalAPIInterfaceServiceService() : base() {}
		
		/// <summary>
		/// constructor for passing in a dynamic configuration object
		/// </summary>
		public PayPalAPIInterfaceServiceService(Dictionary<string, string> config) : base(config) {}

	    public Dictionary<string, string> Config
	    {
	        get { return this.config;  }
	    }
	
		private void setStandardParams(AbstractRequestType request) {
			if (request.Version == null)
			{
				request.Version = ServiceVersion;
			}
			if (request.ErrorLanguage != null && this.config.ContainsKey("languageCode"))
			{
				request.ErrorLanguage = config["languageCode"];
			}
		}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMCreateButtonReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMCreateButtonResponseType> BMCreateButtonAsync(BMCreateButtonReq bMCreateButtonReq, string apiUserName)
	 	{	 		
			setStandardParams(bMCreateButtonReq.BMCreateButtonRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMCreateButtonReq.ToXMLString(null, "BMCreateButtonReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMCreateButtonResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMCreateButtonResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMCreateButtonReq"></param>
	 	
	 	public async Task<BMCreateButtonResponseType> BMCreateButtonAsync(BMCreateButtonReq bMCreateButtonReq)
	 	{
	 		return await BMCreateButtonAsync(bMCreateButtonReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMCreateButtonReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMCreateButtonResponseType> BMCreateButtonAsync(BMCreateButtonReq bMCreateButtonReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMCreateButtonReq.BMCreateButtonRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMCreateButtonReq.ToXMLString(null, "BMCreateButtonReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMCreateButtonResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMCreateButtonResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMUpdateButtonReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMUpdateButtonResponseType> BMUpdateButtonAsync(BMUpdateButtonReq bMUpdateButtonReq, string apiUserName)
	 	{	 		
			setStandardParams(bMUpdateButtonReq.BMUpdateButtonRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMUpdateButtonReq.ToXMLString(null, "BMUpdateButtonReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMUpdateButtonResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMUpdateButtonResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMUpdateButtonReq"></param>
	 	
	 	public async Task<BMUpdateButtonResponseType> BMUpdateButtonAsync(BMUpdateButtonReq bMUpdateButtonReq)
	 	{
	 		return await BMUpdateButtonAsync(bMUpdateButtonReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMUpdateButtonReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMUpdateButtonResponseType> BMUpdateButtonAsync(BMUpdateButtonReq bMUpdateButtonReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMUpdateButtonReq.BMUpdateButtonRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMUpdateButtonReq.ToXMLString(null, "BMUpdateButtonReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMUpdateButtonResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMUpdateButtonResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMManageButtonStatusReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMManageButtonStatusResponseType> BMManageButtonStatusAsync(BMManageButtonStatusReq bMManageButtonStatusReq, string apiUserName)
	 	{	 		
			setStandardParams(bMManageButtonStatusReq.BMManageButtonStatusRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMManageButtonStatusReq.ToXMLString(null, "BMManageButtonStatusReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMManageButtonStatusResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMManageButtonStatusResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMManageButtonStatusReq"></param>
	 	
	 	public async Task<BMManageButtonStatusResponseType> BMManageButtonStatusAsync(BMManageButtonStatusReq bMManageButtonStatusReq)
	 	{
	 		return await BMManageButtonStatusAsync(bMManageButtonStatusReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMManageButtonStatusReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMManageButtonStatusResponseType> BMManageButtonStatusAsync(BMManageButtonStatusReq bMManageButtonStatusReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMManageButtonStatusReq.BMManageButtonStatusRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMManageButtonStatusReq.ToXMLString(null, "BMManageButtonStatusReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMManageButtonStatusResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMManageButtonStatusResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMGetButtonDetailsReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMGetButtonDetailsResponseType> BMGetButtonDetailsAsync(BMGetButtonDetailsReq bMGetButtonDetailsReq, string apiUserName)
	 	{	 		
			setStandardParams(bMGetButtonDetailsReq.BMGetButtonDetailsRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMGetButtonDetailsReq.ToXMLString(null, "BMGetButtonDetailsReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMGetButtonDetailsResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMGetButtonDetailsResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMGetButtonDetailsReq"></param>
	 	
	 	public async Task<BMGetButtonDetailsResponseType> BMGetButtonDetailsAsync(BMGetButtonDetailsReq bMGetButtonDetailsReq)
	 	{
	 		return await BMGetButtonDetailsAsync(bMGetButtonDetailsReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMGetButtonDetailsReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMGetButtonDetailsResponseType> BMGetButtonDetailsAsync(BMGetButtonDetailsReq bMGetButtonDetailsReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMGetButtonDetailsReq.BMGetButtonDetailsRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMGetButtonDetailsReq.ToXMLString(null, "BMGetButtonDetailsReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMGetButtonDetailsResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMGetButtonDetailsResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMSetInventoryReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMSetInventoryResponseType> BMSetInventoryAsync(BMSetInventoryReq bMSetInventoryReq, string apiUserName)
	 	{	 		
			setStandardParams(bMSetInventoryReq.BMSetInventoryRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMSetInventoryReq.ToXMLString(null, "BMSetInventoryReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMSetInventoryResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMSetInventoryResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMSetInventoryReq"></param>
	 	
	 	public async Task<BMSetInventoryResponseType> BMSetInventoryAsync(BMSetInventoryReq bMSetInventoryReq)
	 	{
	 		return await BMSetInventoryAsync(bMSetInventoryReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMSetInventoryReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMSetInventoryResponseType> BMSetInventoryAsync(BMSetInventoryReq bMSetInventoryReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMSetInventoryReq.BMSetInventoryRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMSetInventoryReq.ToXMLString(null, "BMSetInventoryReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMSetInventoryResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMSetInventoryResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMGetInventoryReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMGetInventoryResponseType> BMGetInventoryAsync(BMGetInventoryReq bMGetInventoryReq, string apiUserName)
	 	{	 		
			setStandardParams(bMGetInventoryReq.BMGetInventoryRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMGetInventoryReq.ToXMLString(null, "BMGetInventoryReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMGetInventoryResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMGetInventoryResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMGetInventoryReq"></param>
	 	
	 	public async Task<BMGetInventoryResponseType> BMGetInventoryAsync(BMGetInventoryReq bMGetInventoryReq)
	 	{
	 		return await BMGetInventoryAsync(bMGetInventoryReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMGetInventoryReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMGetInventoryResponseType> BMGetInventoryAsync(BMGetInventoryReq bMGetInventoryReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMGetInventoryReq.BMGetInventoryRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMGetInventoryReq.ToXMLString(null, "BMGetInventoryReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMGetInventoryResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMGetInventoryResponse']")
			);
			
	 	}

		/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMButtonSearchReq"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public async Task<BMButtonSearchResponseType> BMButtonSearchAsync(BMButtonSearchReq bMButtonSearchReq, string apiUserName)
	 	{	 		
			setStandardParams(bMButtonSearchReq.BMButtonSearchRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMButtonSearchReq.ToXMLString(null, "BMButtonSearchReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, apiUserName, getAccessToken(), getAccessTokenSecret());
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMButtonSearchResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMButtonSearchResponse']")
			);
			
	 	}
	 
	 	/// <summary> 
		/// 
	 	/// </summary>
		///<param name="bMButtonSearchReq"></param>
	 	
	 	public async Task<BMButtonSearchResponseType> BMButtonSearchAsync(BMButtonSearchReq bMButtonSearchReq)
	 	{
	 		return await BMButtonSearchAsync(bMButtonSearchReq,(string) null);
	 	}
	 	
	 	/// <summary>
		/// 
	 	/// </summary>
		///<param name="bMButtonSearchReq"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public async Task<BMButtonSearchResponseType> BMButtonSearchAsync(BMButtonSearchReq bMButtonSearchReq, ICredential credential)
	 	{	 			 		
			setStandardParams(bMButtonSearchReq.BMButtonSearchRequest);
			DefaultSOAPAPICallHandler defaultHandler = new DefaultSOAPAPICallHandler(this.config, bMButtonSearchReq.ToXMLString(null, "BMButtonSearchReq"), null, null);
			IAPICallPreHandler apiCallPreHandler = new MerchantAPICallPreHandler(this.config, defaultHandler, credential);
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((MerchantAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((MerchantAPICallPreHandler) apiCallPreHandler).PortName = "PayPalAPI";
			
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(await CallAsync(apiCallPreHandler));			
			return new BMButtonSearchResponseType(
				xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BMButtonSearchResponse']")
			);
			
	 	}
	}
}
