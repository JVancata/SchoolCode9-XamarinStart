using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private bool Matched = false;
        public MainPage()
        {
            InitializeComponent();
        }
        public void checkPalindrome(string input)
        {
            int a = input.Length-1;
            for (int i = 0; i < a-1; i++)
            {
                if(input[i] == input[a])
                {
                    Matched = true;
                }
                else
                {
                    Matched = false;
                }
                
                Vypis.Text = Matched ? "Tohle je palindrom, bro" : "Tohle neni palindrom, bro";
                a--;
            }
        }
        void Okay_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
    }
}
