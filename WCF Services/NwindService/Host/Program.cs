using NwindService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(NorthWindService));
                host.Opened += new EventHandler((o, a) =>
                {
                    Console.WriteLine("Felicidades se alojó tu servicio");
                    foreach (var item in host.Description.Endpoints)
                    {
                        Console.WriteLine(item.ListenUri);
                    }
                });
                host.Open();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Falló el alojamiento del servicio: {0}", ex);
            }

            Console.ReadLine();
        }
    }
}
