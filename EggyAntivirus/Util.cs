using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EggyAntivirus
{
    class Util
    {
        public static string GetAscii(string asc)
        {
            string ascp = asc.Replace(' ', '+');
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://artii.herokuapp.com/make?text={ascp}");
            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public static string GetMD5(string file)
        {
            var md5 = MD5.Create();
            var stream = File.OpenRead(file);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}
