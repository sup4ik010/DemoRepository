using System;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoJson();
        }

        private static void DemoJson()
        {
            var path = ConfigurationManager.AppSettings["path"];
            var warrior = new Player(80.0, 80.0);
            Console.WriteLine(warrior.ToString());

            var json = new JavaScriptSerializer().Serialize(warrior);
            File.WriteAllText(path, json);
            var loadedData = new JavaScriptSerializer().Deserialize<Player>(File.ReadAllText(path));
            Console.WriteLine(loadedData.ToString());

            Console.ReadKey();
        }
    }
}
