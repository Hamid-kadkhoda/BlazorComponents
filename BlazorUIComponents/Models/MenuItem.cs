using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUIComponents.Models
{
    public class MenuItem
    {
        public string? Label { get; set; }

        public string? Routerlink { get; set; }

        public string? Style { get; set; }

        public string? StyleClass { get; set; }

        public EventHandler? Command { get; set; }

        public List<MenuItem>? Items { get; set; }
    }
}
