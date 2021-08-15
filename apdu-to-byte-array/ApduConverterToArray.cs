using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApduToByteArray
{
    public partial class ApduConverterToArray : Form
    {
        public ApduConverterToArray()
        {
            InitializeComponent();
        }

        private void OnButtonConvertClicked(object sender, EventArgs e)
        {
            rtbApduArray.Clear();

            string apdu = rtbApdu.Text.Trim().Replace(" ", "");
            StringBuilder apduArray = new();
            apduArray.AppendLine("var apdu = new byte[]");
            apduArray.AppendLine("{");

            List<string> apduInParts = SplitInParts(apdu, partLength: 2).ToList();

            int apduInPartLength = apduInParts.Count();
            for (int indexPart = 0; indexPart < apduInPartLength; indexPart++)
            {
                string apduPart = apduInParts[indexPart];

                if (indexPart < apduInPartLength - 1)
                {
                    apduPart += ",";
                }

                apduArray.AppendLine($"\t0x{apduPart}");
            }

            apduArray.AppendLine("};");

            rtbApduArray.Text = apduArray.ToString();
        }

        private void OnButtonCopyClicked(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbApduArray.Text);
        }

        private static IEnumerable<string> SplitInParts(string text, int partLength)
        {
            for (var i = 0; i < text.Length; i += partLength)
            {
                yield return text.Substring(i, Math.Min(partLength, text.Length - i));
            }
        }
    }
}
