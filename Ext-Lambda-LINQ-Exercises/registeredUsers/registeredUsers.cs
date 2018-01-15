﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Record
{
    class Records
    {
        public int id;
        public DateTime date;

        public Records(int id, DateTime date)
        {
            this.id = id;
            this.date = date;
        }
    }

    class RegisteredUsers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, Records>();
            int id = 0;
            while (input != "end")
            {
                string[] inputTokens =
                    input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                DateTime date = DateTime.ParseExact(inputTokens[1], "dd/MM/yyyy", null);

                data.Add(name, new Records(id++, date));
                input = Console.ReadLine();
            }

            var orderedData = data
                .OrderBy(r => r.Value.date)
                .ThenByDescending(r => r.Value.id)
                .Take(5)
                .OrderByDescending(r => r.Value.date);

            foreach (var record in orderedData)
            {
                Console.WriteLine(record.Key);
            }
        }
    }
}

