using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockSimulator
{
    public class Company
    {
        private string[] companyNames = File.ReadAllLines("company names.txt");
        public Company init()
        {
            var random = new Random();
            this.initialPrice = random.Next(1, 10000)/100;
            this.currentPrice = initialPrice;
            this.ChangeValue = 0;
            this.CompanyName = companyNames[random.Next(companyNames.Length)];
            this.numBought = 0;
            return this;
        }
        public Company Buy(int value)
        {
            this.numBought += value;
            return this;
        }
        public Company nextTurn(float change)
        {
            this.currentPrice += currentPrice * change;
            return this;
        }
        public string CompanyName { get; set; }

        private int numBought;

        public float currentPrice { get; set; }
        public float initialPrice { get; private set; }
        public float ChangeValue { get; set; }
    }
}
