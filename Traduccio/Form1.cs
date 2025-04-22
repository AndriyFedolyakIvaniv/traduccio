using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Traduccio
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            // Aquí es pot forçar un idioma per defecte si vols:
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            InitializeComponent();
            InitializeLanguageComboBox();

        }

        private void InitializeLanguageComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Català");
            comboBox1.Items.Add("Español");
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Français");
            comboBox1.Items.Add("Deutsch");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedLanguage = "";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Català":
                    selectedLanguage = "ca-ES";
                    break;
                case "Español":
                    selectedLanguage = "es-ES";
                    break;
                case "English":
                    selectedLanguage = "en-US";
                    break;
                case "Français":
                    selectedLanguage = "fr-FR";
                    break;
                case "Deutsch":
                    selectedLanguage = "de";
                    break;
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}