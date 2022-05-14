using System.Linq;
using System.Net;

namespace Gatlin.Utils.Net
{
    /// <summary>
    /// 网络相关 
    /// </summary>
    public class NetCore
    {
        public static string GetIP()
        {
            var ipArr = Dns.GetHostAddresses(Dns.GetHostName());
            return ipArr?.FirstOrDefault()?.ToString();
        }
    }
}
