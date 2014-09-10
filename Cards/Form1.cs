using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        readonly Random _random = new Random(); 
        private void button1_Click(object sender, EventArgs e)
        {
            var card = new Card((Suits) _random.Next(4), (Values) _random.Next(1,14)); 
            MessageBox.Show(card.Name); 
        }
    }
}
