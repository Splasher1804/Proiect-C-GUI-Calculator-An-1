using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Calculator : Form
    {
        Double value = 0;
        String operatie = "";
        bool operatie_click  = false;

        public Calculator()
        { 
            InitializeComponent();
        }


        private void Butt1(object sender, EventArgs e)
        {
            if ((result.Text == "") || (operatie_click))
                result.Text= String.Empty;
            operatie_click = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!result.Text.Contains(","))
                    result.Text = result.Text + b.Text;
                     
            }
            else
            result.Text = result.Text + b.Text;
        }

        private void Egal(object sender, EventArgs e)
        {
            operatie_click = false;
            Live.Text = "";
            switch(operatie)
            {
                case "+": result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "x":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "sqrt":
                    result.Text = Math.Sqrt(value).ToString();
                    break;
                default:
                    break;
            }

            
            operatie = "";
           
        }

        private object sqrt(double value)
        {
            throw new NotImplementedException();
        }

        private void Sterge(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                Equal.PerformClick();
                operatie_click = true;
                operatie = b.Text;
                Live.Text = value + " " + operatie;
            }
            else
            {
                operatie = b.Text;
                value = Double.Parse(result.Text);
                operatie_click = true;
                Live.Text = value + " " + operatie;
            }
        }


        private void Stergetot(object sender, EventArgs e)
        {
            result.Text = String.Empty;
            value = 0;
            Live.Text = "";
        }

        private void Calculator_Keypress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "1":
                    butt1.PerformClick(); break;
                case "2":
                    butt2.PerformClick(); break;
                case "3":
                    butt3.PerformClick(); break;
                case "4":
                    butt4.PerformClick(); break;
                case "5":
                    butt6.PerformClick(); break;
                case "7":
                    butt7.PerformClick(); break;
                case "8":
                    butt8.PerformClick(); break;
                case "9":
                    butt9.PerformClick(); break;
                case "0":
                    butt0.PerformClick(); break;
                case ",":
                    Point.PerformClick(); break;
                case "=":
                    Equal.PerformClick(); break;
                case "13":
                    Equal.PerformClick(); break;
                case "+":
                    Plus.PerformClick(); break;
                case "-":
                    Minus.PerformClick(); break;
                case "x":
                    Ori.PerformClick(); break;
                case "/":
                    Impartit.PerformClick(); break;
                case "s":
                    Radical.PerformClick(); break;
                case "w":
                    Clear_Label.PerformClick(); break;
                case "q":
                    Del.PerformClick(); break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void result_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}