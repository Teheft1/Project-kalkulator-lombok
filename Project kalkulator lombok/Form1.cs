using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_kalkulator_lombok
{
    public partial class Kalkulator : Form
    {
        double value = 0;
        double a;
        string ops = "";
        bool op_pressed = false;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if (Hasil.Text == "0" || op_pressed)
                Hasil.Clear();

            op_pressed = false;

            Button b = (Button)sender;
            
            Hasil.Text = Hasil.Text +  b.Text;
        }

        private void kurang_click(object sender, EventArgs e)
        {
            Hasil.Text = Hasil.Text.Remove(Hasil.Text.Length - 1, 1);
            if (Hasil.Text == "")
                Hasil.Text = "0";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Hasil.Clear();
            Hasil.Text = "0";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "+": Hasil.Text = (value + Double.Parse(Hasil.Text)).ToString();
                    op_pressed = false;
                    break;
                case "-": Hasil.Text = (value - Double.Parse(Hasil.Text)).ToString();
                    op_pressed = false;
                    break;
                case "*": Hasil.Text = (value * Double.Parse(Hasil.Text)).ToString();
                    op_pressed = false;
                    break;
                case "/": Hasil.Text = (value / Double.Parse(Hasil.Text)).ToString();
                    op_pressed = false;
                    break;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            ops = b.Text;
            
            op_pressed = true;
            value = Double.Parse(Hasil.Text);

            op_pressed = true;

            Hasil.Clear();
        }
    }
}
