using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Domain.Configs
{
    public class AppSettingsConfig
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public string AllowedHosts { get; set; }
        public string EndPointAddress { get; set; }
    }
}
