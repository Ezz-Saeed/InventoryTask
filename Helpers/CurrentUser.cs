using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTask.Helpers
{
    public class CurrentUser
    {
        public static string Username { get; set; } = string.Empty;
        public static List<string> Roles { get; set; } = new();
    }
}
