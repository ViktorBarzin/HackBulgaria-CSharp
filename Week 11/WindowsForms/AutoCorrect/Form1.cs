using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCorrect
{
    using System.IO;

    public partial class Form1 : Form
    {
        private StringBuilder inputWord = new StringBuilder();
        private StringBuilder inputText = new StringBuilder();
        private readonly Dictionary<string, int> wordsSet = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(@"..\..\wordsEn.txt"))
            {
                string wordToAdd = sr.ReadLine();
                while (wordToAdd != null)
                {
                    this.wordsSet.Add(wordToAdd, 0);
                    wordToAdd = sr.ReadLine();
                }

                this.wordsSet.OrderBy(x => x.Key).ThenBy(y => y.Value);
            }
        }

        private void TextTyped(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Enter)
            {
                string[] text = this.inputText.ToString().Split(' ');
                this.inputWord = new StringBuilder(text[text.Length - 1]);
                if (!this.wordsSet.ContainsKey(this.inputWord.ToString()))
                {
                    List<string> words = this.wordsSet.Keys.ToList();

                    int len = this.wordsSet.Keys.Count;
                    for (int i = 0; i < len; i++)
                    {
                        this.wordsSet[words[i]] = WordDistance(words[i], inputWord.ToString());
                    }

                    int wordDistance = this.wordsSet.Values.Min();
                    var resWord = this.wordsSet.FirstOrDefault(x => x.Value == wordDistance).Key;
                    this.inputText = this.inputText.Replace(this.inputWord.ToString(), resWord);
                    this.textBoxInput.Text = this.inputText.ToString();
                    this.textBoxInput.Select(this.inputText.Length, 0);
                }
            }
            else
            {
                this.inputWord.Append(e.KeyChar);
            }

            this.inputText.Append(e.KeyChar);
        }

        private static int WordDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
