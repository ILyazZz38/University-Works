using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ClientsContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppContext db = new AppContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // создание и добавление моделей
                Client Petrovich = new Client { orgName = "Microsoft" , adress = "USA", cheff = "Bill Gates"};
                Client Silvestr_Andreevich = new Client { orgName = "Yandex",  adress = "Russia", cheff = "Himself"};
                db.Clients.AddRange(Petrovich, Silvestr_Andreevich);

                Contract buy = new Contract { date = DateTime.Now, clientId = 64938574639, sum = 450000, client = Silvestr_Andreevich };
                Contract sell = new Contract { date = DateTime.Now, clientId = 64938574639, sum = 780000, client = Silvestr_Andreevich };
                Contract rent = new Contract { date = DateTime.Now, clientId = 6497574639, sum = 40000, client = Petrovich };
                db.Contracts.AddRange(buy, sell, rent);
                db.SaveChanges();

                var Contracts = db.Contracts.Include(u => u.client).ToList();
                foreach (Contract contract in Contracts)
                    Console.WriteLine($"{contract.clientId} - {contract.sum} - {contract.date} - {contract.client?.orgName}");

                var Clients = db.Clients.Include(c => c.Contracts).ToList();
                foreach (Client client in Clients)
                {
                    Console.WriteLine($"\n Компания: {client.orgName}");
                    Console.WriteLine($"\n Адресс: {client.adress}");
                    Console.WriteLine($"\n Шэф: {client.cheff}");
                    foreach (Contract contract in client.Contracts)
                    {
                        Console.WriteLine($"{contract.clientId} - {contract.sum} - {contract.date}");
                    }
                }
            }
        }
    }
}
