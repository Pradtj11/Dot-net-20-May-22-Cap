using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://uploadimage12.table.core.windows.net"), "tblSample", new TableSharedKeyCredential("uploadimage12", "bz2exF4uErrsw9un91YzXBzhF2umhenkhbmzf+DRnRVG/i7tPtSE9RUiMoT9Eg8hr5Fa1NRQSO/j+AStrIH9rQ=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }

        }

    }
}
