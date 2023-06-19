using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public enum CurrencyType
        {
            Coin,
            Banknote
        }

        public interface ICurrency
        {
            string GetName();
            decimal GetValue();
            decimal GetVolume();
        }

        public struct Coin: ICurrency
        {
            public string Name { get; set; }
            public decimal Value { get; set; }
            public decimal Radius { get; set; }
            public decimal Height { get; set; }

            public string GetName()
            { return Name; }
            public decimal GetValue()
            {
                return Value;
            }
            public decimal GetVolume()
            {
                decimal volume = (decimal)(Math.PI * Math.Pow((double)Radius, 2) * (double)Height);
                return volume;
            }
        
        }

        public struct Banknote : ICurrency
        {
            public string Name { get; set; }
            public decimal Value { get; set; }

            public decimal Width { get; set; }
            public decimal Length { get; set; }
            public decimal Height { get; set; }

            public string GetName()
            { return Name; }
            public decimal GetValue()
            {
                return Value;
            }
            public decimal GetVolume()
            {
                decimal volume = Width*Length*Height;
                return volume;
            }

        }

        Coin beskurus = new Coin()
        {
            Name = "5 Kuruş",
            Value = 0.5m,
            Radius = 1.5m,
            Height = 1.0m
        };

        Coin onkurus = new Coin()
        {
            Name = "10 Kuruş",
            Value = 0.10m,
            Radius = 1.5m,
            Height = 1.0m
        };

        Coin yirmibeskurus = new Coin()
        {
            Name = "25 Kuruş",
            Value = 0.25m,
            Radius = 1.5m,
            Height = 1.0m
        };
        Coin ellikurus = new Coin()
        {
            Name = "50 Kuruş",
            Value = 0.50m,
            Radius = 1.5m,
            Height = 1.0m
        };
        Coin birtl = new Coin()
        {
            Name = "1 TL",
            Value = 1,
            Radius = 1.5m,
            Height = 1.0m
        };

        Banknote bestl = new Banknote()
        {
            Name = "5 TL",
            Value = 5,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };
        Banknote ontl = new Banknote()
        {
            Name = "10 TL",
            Value = 10,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };
        Banknote yirmitl = new Banknote()
        {
            Name = "20 TL",
            Value = 20,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };
        Banknote ellitl = new Banknote()
        {
            Name = "50 TL",
            Value = 50,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };
        Banknote yuztl = new Banknote()
        {
            Name = "100 TL",
            Value = 100,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };
        Banknote ikiyuztl = new Banknote()
        {
            Name = "200 TL",
            Value = 200,
            Width = 7.0m,
            Length = 15.0m,
            Height = 0.1m
        };

        public class PiggyBank
        {
            public decimal totalVolume;
            public decimal maxVolume;
            public List<ICurrency> currencies;

            public PiggyBank(decimal maxVolume)
            {
                this.maxVolume = maxVolume;
                totalVolume = 0;
                currencies = new List<ICurrency>();
            }

            public void AddCurrency(ICurrency currency)
            {
                decimal currencyVolume = currency.GetVolume();
                decimal extraVolume = currencyVolume * (decimal)(0.25 + (new Random().NextDouble() * 0.5));
                decimal totalCurrencyVolume = currencyVolume + extraVolume;

                if (totalVolume + totalCurrencyVolume > maxVolume)
                {
                    throw new Exception("Kumbara hacmi dolmuştur.");

                }

                currencies.Add(currency);
                totalVolume += totalCurrencyVolume;
            }

            public List<ICurrency> Break()
            {
                List<ICurrency> result = new List<ICurrency>(currencies);
                
                currencies.Clear();
                totalVolume = 0;

                return result;

            }

            public void Shake()
            {
                foreach (var currency in currencies)
                {
                    decimal currencyVolume = currency.GetVolume();
                    decimal minExtraVolume = currencyVolume * (25/100);

                    if(currencyVolume>minExtraVolume)
                    {
                        decimal extraVolume = currencyVolume * (decimal)(0.25 + (new Random().NextDouble() * 0.75)) ;
                        decimal totalCurrencyVolume = currencyVolume + extraVolume;
                        totalVolume -= currencyVolume;
                        totalVolume += totalCurrencyVolume;
                    }
                    
                    
                }
            }

        }
        
        PiggyBank piggybank = new PiggyBank(500);
        private void btnEkle_Click(object sender, EventArgs e)
        {
            PiggyBank piggybank = new PiggyBank(500);
            try
            {
                if (cbSecPara.SelectedItem.ToString() != null)
                {

                    if (cbSecPara.SelectedItem.ToString().Contains("TL") && chbKatla.Checked == false)
                    {
                        MessageBox.Show("Katlamadan atamazsınız!");
                        throw new Exception();
                    }

                    if (cbSecPara.SelectedItem.ToString().Contains("Kuruş") && chbKatla.Checked == true)
                    {
                        MessageBox.Show("Bozuk para katlanamaz.");
                        throw new Exception();
                    }

                    if (cbSecPara.SelectedItem == null)
                    {
                        MessageBox.Show("Boş seçim yaptınız!");
                        throw new Exception();
                    }

                    if (cbSecPara.SelectedItem.ToString()=="5 Kuruş")
                    {
                        piggybank.AddCurrency(beskurus);
                        MessageBox.Show("5 kuruş eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "10 Kuruş")
                    {
                        piggybank.AddCurrency(onkurus);
                        MessageBox.Show("10 kuruş eklendi");
                    }

                    if (cbSecPara.SelectedItem.ToString() == "25 Kuruş")
                    {
                        piggybank.AddCurrency(yirmibeskurus);
                        MessageBox.Show("25 kuruş eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "50 Kuruş")
                    {
                        piggybank.AddCurrency(ellikurus);
                        MessageBox.Show("50 kuruş eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "1 TL")
                    {
                        piggybank.AddCurrency(birtl);
                        MessageBox.Show("1 TL eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "5 TL")
                    {
                        piggybank.AddCurrency(bestl);
                        MessageBox.Show("5 TL eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "10 TL")
                    {
                        piggybank.AddCurrency(ontl);
                        MessageBox.Show("10 TL eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "20 TL")
                    {
                        piggybank.AddCurrency(yirmitl);
                        MessageBox.Show("20 TL eklendi");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "50 TL")
                    {
                        piggybank.AddCurrency(ellitl);
                        MessageBox.Show("50 TL");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "100 TL")
                    {
                        piggybank.AddCurrency(yuztl);
                        MessageBox.Show("100 TL");
                    }
                    if (cbSecPara.SelectedItem.ToString() == "200 TL")
                    {
                        piggybank.AddCurrency(ikiyuztl);
                        MessageBox.Show("200 TL eklendi");
                    }
                } 
            }
            catch
            {
                
            }

        }

        private void btnAcKumbara_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<ICurrency> brokenCurrencies= piggybank.Break();
            count = count + 1;
            MessageBox.Show("Kumbara acildi");
            if (count == 3)
            {
                throw new Exception("kumbara 3. kez birleşmez");
            }
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {            
            piggybank.Shake();            
        }
    }
}
