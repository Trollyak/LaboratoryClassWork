using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Country[] countries = new Country[]
           {
                new Country("Россия","Евразия",17125191),
                new Country("Австралия","Австралия",7692024),
                new Country("США","Северная Америка",9826675)

           };
        public class Country
        {
            public string Name { get; set; }
            public string Cont { get; set; }
            public double Square { get; set; }
            public Country() { }
            public Country(string name, string cont, float square)
            {
                Name = name;
                Cont = cont;
                Square = square;
            }
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(textBox4.Text);
                textBox3.Text = countries[index].Name;
                textBox2.Text = countries[index].Cont;
                textBox1.Text = countries[index].Square.ToString();
            }
            catch
            {
                MessageBox.Show("Введено неверное значение");
            }
            
        }
    }
}
