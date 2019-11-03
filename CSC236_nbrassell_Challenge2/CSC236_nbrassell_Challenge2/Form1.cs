using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_nbrassell_Challenge2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            bool skip = false; //Flag for if the word should not be translated bc it has a symbol or number in it
            bool cap = false; //Flag for if word is capitalized
            int location = -1;
            string symbolsAndNumbers = "@#$%^&*()|\\/=-+_`~<>[]{}1234567890";
            string startVowels = "AEIOU";
            string vowels = "AEIOUY";
            string punctuation = ".,?!:;";
            string newWord = "";
            string output = "";
            string[] inputList = txtInput.Text.Split();
            foreach (var word in inputList)
            {
                //Check to see if word has a symbol or number in it
                foreach (var letter in word)
                {
                    if (symbolsAndNumbers.Contains(letter.ToString()))
                    {
                        skip = true;
                        break;
                    }
                    else
                        skip = false;
                }
                //Adds the word to the output w/o translating and skips rest of the loop
                if (skip)
                {
                    output += word + " ";
                    continue;
                }
                //Checks if first letter is capital
                if (Convert.ToInt32(word[0]) > 64 && Convert.ToInt32(word[0]) < 91)
                    cap = true;
                else
                    cap = false;
                //Checks if the word starts with a vowel
                if (startVowels.Contains(word[0].ToString().ToUpper()))
                {
                    //Checks to see if there is punctiation and makes sure that it is accounted for in the translation
                    if (punctuation.Contains(word[word.Length - 1].ToString()))
                    {
                        newWord = word.Substring(0, (word.Length - 1)) + "way" + word[word.Length - 1] + " ";
                    }
                    else
                    {
                        newWord = word + "way" + " ";
                    }
                    //Capitializes first letter if needed
                    if(cap)
                    {
                        newWord = newWord.ToLower();
                        newWord = newWord.Substring(0, 1).ToUpper() + newWord.Substring(1, newWord.Length - 1);
                    }
                    output += newWord;
                }
                else
                {
                    //Loop through to find first vowel, i starts at 1 bc already know that the 0th place is not a vowel
                    for (int i = 1; i < word.Length; i++)
                    {
                        if(vowels.Contains(word[i].ToString().ToUpper()))
                        {
                            location = i;
                            break;
                        }
                    }
                    //Checks to see if there is punctiation and makes sure that it is accounted for in the translation
                    if (punctuation.Contains(word[word.Length - 1].ToString()))
                    {
                        newWord = word.Substring(location, word.Length - location - 1) + word.Substring(0, location)
                            + "ay" + word[word.Length - 1] + " ";
                    }
                    else
                    {
                        newWord = word.Substring(location, word.Length - location) + word.Substring(0, location)
                            + "ay" + " ";
                    }
                    //Capitializes first letter if needed
                    if (cap)
                    {
                        newWord = newWord.ToLower();
                        newWord = newWord.Substring(0, 1).ToUpper() + newWord.Substring(1, newWord.Length - 1);
                    }
                    output += newWord;
                }
            }
            txtOutput.Text = output;
        }
    }
}
