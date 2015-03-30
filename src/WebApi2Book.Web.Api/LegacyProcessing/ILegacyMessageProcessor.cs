using System.Xml.Linq;

namespace WebApi2Book.Web.Api.LegacyProcessing
{
    public interface ILegacyMessageProcessor
    {
        LegacyResponse ProcessLegacyMessage(XDocument request);
    }
}