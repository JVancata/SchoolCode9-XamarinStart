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
        public string Diakritika(string s)
        {
            //string a = "AABB";
            var dict = new Dictionary<char, char> { { 'ě', 'e' }, { 'š', 's' }, { 'č', 'c' }, { 'ř', 'r' }, { 'ž', 'z' }, { 'ý', 'y' }, { 'á', 'a' }, { 'í', 'i' }, { 'é', 'e' }, { 'ů', 'u' }, { 'ú', 'u' } };

            s = new string(s.ToCharArray().Select(c => dict.ContainsKey(c) ? dict[c] : c).ToArray());
            return s;
        }
        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        public string Rozjet(string s)
        {
            string output = RemoveWhitespace(s).ToLower();

            return output;
        }
        public void checkPalindrome(string input)
        {
            string newString = Diakritika(Reverse(Rozjet(input)));
            string zadano = Diakritika(Rozjet(input));
            if(zadano == newString)
            {
                Matched = true;
            }
            else
            {
                Matched = false;
            }
            Intro.Text = "Reverse: "+newString+"\n"+"Normal:"+zadano;
            /*int a = input.Length-1;
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
            }*/
            Vypis.Text = Matched ? "Tohle je palindrom, bro" : "Tohle neni palindrom, bro";
        }
        void Okay_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
            checkPalindrome(e.NewTextValue);
        }
    }
}
