using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace assignment1
{
    public partial class MainGroup : Form
    {
        public MainGroup()
        {
            InitializeComponent();
        }

        private void SeePhotoCheckBox_CheckedChanged(object sender, EventArgs e) // called on photo check box click
        {
            if (SeePhotoCheckBox.Checked)
            {
                pictureBox.Visible = true; // Tests if the photo checkbox is clicked, if it is it will make the photo visable
            }
            else
            {
                pictureBox.Visible = false; // if not clicked it will make sure the picture is invisable
            }
        }

        private static decimal ConvertMoney(decimal amount, string fromCurrency, string toCurrency) // called under convert_click
        {
            Decimal rateFrom = FindRate(fromCurrency); // finds from rate given a string of currency
            Decimal rateTo = FindRate(toCurrency); // finds to rate given a string of currency

            return Math.Round(amount * rateTo / rateFrom, 2); // returns convertion via computing formula and rounding to 2dp
        }

        private void ConvertClick(object sender, EventArgs e) // called on convert button clicked
        {
            string from = FindFrom(); // finds from currency and to currencies using functions below
            string to = FindTo();
            string time = DateTime.Now.ToShortDateString() + Environment.NewLine + DateTime.Now.ToShortTimeString(); // finds whole needed time in a local variable using date time data type
            Decimal num = ConvertMoney(amountInput.Value, from, to); // calls convertMoney with data source from form and functions below

            helloNameLabel.Text = "Hello " + nameTextBox.Text; // gathers all the computed data and displays it for user
            conversionOutputLabel.Text = "Your " + amountInput.Value + " " + from + " can convert to " + num + " " + to + " at " + time;
        }

        private string FindFrom()
        {
            Dictionary<string, bool> fromDict = new Dictionary<string, bool>() // computes from currency
            {
                {"American Dollars", fromUSD.Checked},
                {"Austratian Dollars", fromAUD.Checked}, // defines dictionary to sort through to compute which item is checked
                {"New Zealand Dollars", fromNZD.Checked},
                {"Canadian Dollars", fromCAD.Checked},
                {"Euros", fromEUR.Checked},
                {"United Arab Emirates Dirham", fromAED.Checked},
                {"Indian Rupee", fromINR.Checked},
                {"Chinese Yuan", fromRMB.Checked},
                {"Japanese Yen", fromYEN.Checked}
            };
            foreach (var entry in fromDict) // loops through dictionary
            {
                if (entry.Value) // checks if the entry is true (will mean a button is clicked, and only one button can be clicked)
                {
                    return entry.Key; // if entry is true it will return the type of currency for that checked button
                }
            }
            return ""; // empty return for theoretically unreachable code
        }

        private string FindTo()
        {
            Dictionary<string, bool> toDict = new Dictionary<string, bool>() // computes to currency in exact same fashion as above with to checks instead of from checks
            {
                {"American Dollars", toUSD.Checked},
                {"Austratian Dollars", toAUD.Checked}, // defines dictionary to sort through to compute which item is checked
                {"New Zealand Dollars", toNZD.Checked},
                {"Canadian Dollars", toCAD.Checked},
                {"Euros", toEUR.Checked},
                {"United Arab Emirates Dirham", toAED.Checked},
                {"Indian Rupee", toINR.Checked},
                {"Chinese Yuan", toRMB.Checked},
                {"Japanese Yen", toYEN.Checked}
            };
            foreach (var entry in toDict) // loops through dictionary
            {
                if (entry.Value) // checks if the entry is true (will mean a button is clicked, and only one button can be clicked)
                {
                    return entry.Key; // if entry is true it will return the type of currency for that checked button
                }
            }
            return ""; // empty return for theoretically unreachable code
        }
        private static Decimal FindRate(string key)
        {
            Dictionary<string, Decimal> fromDict = new Dictionary<string, Decimal>() // computes rate in similiar fashion to above, but takes string input and return decimal
            {
                {"American Dollars", .73M},
                {"Austratian Dollars", .93M}, // defines dictionary to sort through currencies for rate
                {"New Zealand Dollars", 1},
                {"Canadian Dollars", .94M},
                {"Euros", .59M},
                {"United Arab Emirates Dirham", 2.69M},
                {"Indian Rupee", 47.51M},
                {"Chinese Yuan", 4.63M},
                {"Japanese Yen", 77.98M}
            };
            foreach (var entry in fromDict) // loops through dictionary
            {
                if (entry.Key == key) // checks if country is the country given (key)
                {
                    return entry.Value; // if above statement is true, it will return the rate (value)
                }
            }
            return 0M; // empty return for theoretically unreachable code
        }

        private void Timer_Tick(object sender, EventArgs e) // every set interval (1000) will set time to the below
        { // sets time to datatime variable time, now function call, converted to longtimestring/longdatestring with a new line between 
            dateLabel.Text = DateTime.Now.ToLongDateString() + Environment.NewLine + DateTime.Now.ToLongTimeString();
        }
    }
}
