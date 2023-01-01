using System.Linq;
using System.Security.Cryptography;

namespace PwdGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string lowercases = "abcdefghijklmnopqrstuvwxyz";
        private const string uppercases = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string numbers = "1234567890";
        private const string specials = "=+*#%&@.,!?^'-_|§";
        private const string extras = "<>()[]{}~£$€/\\\":;";
        private const string similar = "Il1O05S2Z";

        private string charpool = String.Empty;
        static List<string> symbolSet = new List<string>();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            symbolSet = new List<string>();
            if (cbLowercase.Checked) symbolSet.Add(lowercases);
            if (cbUppercase.Checked) symbolSet.Add(uppercases);
            if (cbNumbers.Checked)   symbolSet.Add(numbers);
            if (cbSpecials.Checked)  symbolSet.Add(specials);

            if (symbolSet.Count == 0)
            {
                tbPasswords.Text = "Nothing to do!";
                return;
            }

            charpool = String.Join(null, symbolSet);
            symbolSet.Add(charpool);

            if (cbDissimilar.Checked)
            {
                symbolSet = symbolSet.Select(x => new string(x.Except(similar).ToArray())).ToList();
                charpool = new string(charpool.Except(similar).ToArray());
            }

            //int upperbound = charpool.Length - 1;
            string[] pwds = new string[(int)numPasswords.Value];
            for (int p = 0; p < numPasswords.Value; p++)
            {
                //for (int i = 0; i < numChars.Value; i++)
                //{
                //    pwds[p] += charpool[RandomNumberGenerator.GetInt32(upperbound)];
                //}
                pwds[p] = GeneratePassword((int)numChars.Value);
            }

            tbPasswords.Text = String.Join(Environment.NewLine, pwds);
        }

        private static string GeneratePassword(int length)
        {
            var minLength = symbolSet.Count - 1;

            int[] usesRemaining = Enumerable.Repeat(1, symbolSet.Count).ToArray();
            usesRemaining[minLength] = length - minLength;
            
            var password = new char[length];
            for (int ii = 0; ii < length; ii++)
            {
                int set = RandomNumberGenerator.GetInt32(symbolSet.Count);
                if (usesRemaining[set] > 0)
                {
                    usesRemaining[set]--;
                    password[ii] = symbolSet[set][RandomNumberGenerator.GetInt32(symbolSet[set].Length)];
                }
                else ii--;
            }
            return new string(password);
        }

        private static void Shuffle<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = RandomNumberGenerator.GetInt32(i, array.Length); // Don't select from the entire array on subsequent loops
                T temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }

        private void llCopyToClipboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(tbPasswords.Text);
        }
    }
}