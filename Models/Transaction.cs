namespace Support_Bank.Models
{
    public class Transaction
    {
        public string Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Narrative { get; set; }
        public double Amount { get; set; }

        public Transaction(string[] cells)
        {
            Date = cells[0];
            From = cells[1];
            To = cells[2];
            Narrative = cells[3];

            double.TryParse(cells[4], out var amount);
            Amount = amount;
        }
    }
}