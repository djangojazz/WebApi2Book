﻿using System.Xml.Linq;

namespace WebApi2Book.Web.Api.LegacyProcessing
{
    public class LegacyResponse
    {
        public XDocument Request { get; set; }

        public object ProcessingResult { get; set; }
    }
}