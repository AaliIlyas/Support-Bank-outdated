using Support_Bank.Models;
using System;
using System.IO;
using System.Linq;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "./support-bank-resources/Transactions2014.csv";
            var lines = File.ReadAllLines(path);

            var transactions = lines.Select(line => new Transaction(line.Split(",")));

            foreach (var t in transactions)
            {
                Console.WriteLine($"Date: {t.Date}, from: {t.From}, to: {t.To}, reason: {t.Narrative} amount: {t.Amount}");
            }
        }
    }
}
