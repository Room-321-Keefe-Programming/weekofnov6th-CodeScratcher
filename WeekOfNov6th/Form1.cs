using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            float toConvert1;

            if (!float.TryParse(txtInput1.Text, out _) && !float.TryParse(txtInput2.Text, out _))
            {
                rtbOutput.Text = "Please enter a valid number";
                return;
            }

            if (float.TryParse(txtInput1.Text, out toConvert1))
            {
                if (rdoTempConverter1.Checked)
                {
                    rtbOutput.Text += $"Input 1 to Fahrenheit: {toConvert1 * (9f/5f) + 32}\n";
                }
                else if (rdoTempConverter2.Checked)
                {
                    rtbOutput.Text += $"Input 1 to Celsius: {(toConvert1 - 32) * (5f/9f)}\n";
                }
            }

            float toConvert2;
            if (float.TryParse(txtInput2.Text, out toConvert2))
            {
                if (rdoTempConverter1.Checked)
                {
                    rtbOutput.Text += $"Input 2 to Fahrenheit: {toConvert2 * (9f / 5f) + 32}\n";
                }
                else if (rdoTempConverter2.Checked)
                {
                    rtbOutput.Text += $"Input 2 to Celsius: {(toConvert2 - 32) * (5f / 9f)}\n";
                }
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtInput1.Text, out _) && !float.TryParse(txtInput2.Text, out _))
            {
                rtbOutput.Text = "Please enter a valid number";
                return;
            }

            float[] coefficients = { 149.798f, 0.9314f, 0.8073f, 4.9056f };

            rtbOutput.Text = "";

            float coefficient = coefficients[(int)Math.Floor(cmbMoneyConverter.SelectedIndex / 2f)];

            if (cmbMoneyConverter.SelectedIndex % 2 == 1)
            {
                coefficient = 1f / coefficient;
            }

            float toConvert1;
            if (float.TryParse(txtInput1.Text, out toConvert1))
            {
                rtbOutput.Text += $"Input 1 converted: {Math.Round(toConvert1 * coefficient, 2)}\n";
            }

            float toConvert2;
            if (float.TryParse(txtInput2.Text, out toConvert2))
            { 
                rtbOutput.Text += $"Input 2 converted: {Math.Round(toConvert2 * coefficient, 2)}\n";
            }
        }

        private void btnDistance1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtInput1.Text, out _) && !float.TryParse(txtInput2.Text, out _))
            {
                rtbOutput.Text = "Please enter a valid number";
                return;
            }

            rtbOutput.Text = "";

            List<(float, string)> coefficients = new List<(float, string)>();
            if (chkMileToKilo.Checked)
            {
                coefficients.Add((1.60934f, "from miles to kilometers"));
            }
            if (chkMeterToInch.Checked)
            {
                coefficients.Add((1f/0.0254f, "from meters to inch"));
            }

            foreach ((float, string) coefficient in coefficients) { 
                float toConvert1;
                if (float.TryParse(txtInput1.Text, out toConvert1))
                {
                    rtbOutput.Text += $"Input 1 converted {coefficient.Item2}: {Math.Round(toConvert1 * coefficient.Item1, 2)}\n";
                }

                float toConvert2;
                if (float.TryParse(txtInput2.Text, out toConvert2))
                {
                    rtbOutput.Text += $"Input 2 converted {coefficient.Item2}: {Math.Round(toConvert2 * coefficient.Item1, 2)}\n";
                }
            }
        }

        private void btnDistance2_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtInput1.Text, out _) && !float.TryParse(txtInput2.Text, out _))
            {
                rtbOutput.Text = "Please enter a valid number";
                return;
            }

            rtbOutput.Text = "";

            List<(float, string)> coefficients = new List<(float, string)>();
            if (chkKiloToMiles.Checked)
            {
                coefficients.Add((1f/1.60934f, "from kilometers to miles"));
            }
            if (chkInchToMeter.Checked)
            {
                coefficients.Add((0.0254f, "from inches to meters"));
            }

            foreach ((float, string) coefficient in coefficients)
            {
                float toConvert1;
                if (float.TryParse(txtInput1.Text, out toConvert1))
                {
                    rtbOutput.Text += $"Input 1 converted {coefficient.Item2}: {Math.Round(toConvert1 * coefficient.Item1, 2)}\n";
                }

                float toConvert2;
                if (float.TryParse(txtInput2.Text, out toConvert2))
                {
                    rtbOutput.Text += $"Input 2 converted {coefficient.Item2}: {Math.Round(toConvert2 * coefficient.Item1, 2)}\n";
                }
            }
        }

        private void btnArrays_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

            for (int i = 0; i < alphabet.Length; i++)
            {
                if ("AEIOU".Contains(alphabet[i]))
                {
                    rtbOutput.Text += alphabet[i];
                }
                else
                {
                    rtbOutput.Text += alphabet[i].ToString().ToLower();
                }
            }

            rtbOutput.Text += "\n";

            int j = alphabet.Length - 1;

            bool uppercase = true;
            int counter = 1;

            while (j >= 0)
            {
                if (uppercase)
                {
                    rtbOutput.Text += alphabet[j];
                }
                else
                {
                    rtbOutput.Text += alphabet[j].ToString().ToLower();
                }

                if (counter == 5)
                {
                    uppercase = !uppercase;
                    rtbOutput.Text += ",";
                    counter = 1;
                }
                else
                {
                    counter++;
                }



                j--;
            }   
        }
    }
}
