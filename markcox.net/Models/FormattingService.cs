using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markcox.net.Models
{
    public class FormattingService
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("D");
        }
    }
}
