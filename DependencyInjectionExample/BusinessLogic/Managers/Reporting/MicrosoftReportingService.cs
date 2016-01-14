using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Managers
{
    public class MicrosoftReportingService : IReportingService
    {
        public string GetReportText()
        {
            return "This is Microsoft Reporting Service.";
        }
    }
}
