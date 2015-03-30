using System.Xml.Linq;

namespace WebApi2Book.Web.Api.LegacyProcessing
{
    public interface ILegacyMessageParser
    {
        XElement GetOperationElement(XDocument soapRequest);
        XElement GetOperationElement(XElement soapBody);
    }
}