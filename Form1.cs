using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Enigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rotor r1 = new Rotor();
        Rotor r2 = new Rotor();
        Rotor r3 = new Rotor();

        
        public int lenght;
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)//buchstaben
        {
            lenght = richTextBox1.TextLength;
            r1.i = lenght;
            r1.i++;
            int n = r1.i;
            if (r1.i == 25)
            {
                r1.i = 0;
            }
            Button_reset();
            Rotor.Rotorstellung2(n);
            

            switch (e.KeyValue)
            {
                case 65:
                    button1.BackColor = Color.Yellow;
                    break;

                case 66:
                    button2.BackColor = Color.Yellow;
                    break;

                case 67:
                    button3.BackColor = Color.Yellow;
                    break;

                case 68:
                    button4.BackColor = Color.Yellow;
                    break;

                case 69:
                    button5.BackColor = Color.Yellow;
                    break;

                case 70:
                    button6.BackColor = Color.Yellow;
                    break;

                case 71:
                    button7.BackColor = Color.Yellow;
                    break;

                case 72:
                    button8.BackColor = Color.Yellow;
                    break;

                case 73:
                    button9.BackColor = Color.Yellow;
                    break;

                case 74:
                    button10.BackColor = Color.Yellow;
                    break;

                case 75:
                    button11.BackColor = Color.Yellow;
                    break;

                case 76:
                    button12.BackColor = Color.Yellow;
                    break;

                case 77:
                    button13.BackColor = Color.Yellow;
                    break;

                case 78:
                    button14.BackColor = Color.Yellow;
                    break;

                case 79:
                    button15.BackColor = Color.Yellow;
                    break;

                case 80:
                    button16.BackColor = Color.Yellow;
                    break;

                case 81:
                    button17.BackColor = Color.Yellow;
                    break;

                case 82:
                    button18.BackColor = Color.Yellow;
                    break;

                case 83:
                    button19.BackColor = Color.Yellow;
                    break;

                case 84:
                    button20.BackColor = Color.Yellow;
                    break;

                case 85:
                    button21.BackColor = Color.Yellow;
                    break;

                case 86:
                    button22.BackColor = Color.Yellow;
                    break;

                case 87:
                    button23.BackColor = Color.Yellow;
                    break;

                case 88:
                    button24.BackColor = Color.Yellow;
                    break;

                case 89:
                    button25.BackColor = Color.Yellow;
                    break;

                case 90:
                    button26.BackColor = Color.Yellow;
                    break;
                

                default:
                    break;
            }

            textBox4.Text = Convert.ToString(r1.i);
            textBox3.Text = Rotor.Rotorstellung2(n);

        }
        private void Button_reset()
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;
            button11.BackColor = Color.Transparent;
            button12.BackColor = Color.Transparent;
            button13.BackColor = Color.Transparent;
            button14.BackColor = Color.Transparent;
            button15.BackColor = Color.Transparent;
            button16.BackColor = Color.Transparent;
            button17.BackColor = Color.Transparent;
            button18.BackColor = Color.Transparent;
            button19.BackColor = Color.Transparent;
            button20.BackColor = Color.Transparent;
            button21.BackColor = Color.Transparent;
            button22.BackColor = Color.Transparent;
            button23.BackColor = Color.Transparent;
            button24.BackColor = Color.Transparent;
            button25.BackColor = Color.Transparent;
            button26.BackColor = Color.Transparent;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)//Zeichen
        {
            lenght = richTextBox1.TextLength;
            r1.i = lenght;
            int n = (int)e.KeyChar;
            
            switch (n)
            {
                //Zeichen
                case 48:
                    button16.BackColor = Color.Yellow;
                    break;

                case 49:
                    button17.BackColor = Color.Yellow;
                    break;

                case 50:
                    button23.BackColor = Color.Yellow;
                    break;

                case 51:
                    button5.BackColor = Color.Yellow;
                    break;

                case 52:
                    button18.BackColor = Color.Yellow;
                    break;

                case 53:
                    button20.BackColor = Color.Yellow;
                    break;

                case 54:
                    button26.BackColor = Color.Yellow;
                    break;

                case 55:
                    button21.BackColor = Color.Yellow;
                    break;

                case 56:
                    button9.BackColor = Color.Yellow;
                    break;

                case 57:
                    button15.BackColor = Color.Yellow;
                    break;

                case 37:
                    button1.BackColor = Color.Yellow;
                    break;

                case 44:
                    button19.BackColor = Color.Yellow;
                    break;

                case 58:
                    button4.BackColor = Color.Yellow;
                    break;

                case 167:
                    button6.BackColor = Color.Yellow;
                    break;

                case 47:
                    button7.BackColor = Color.Yellow;
                    break;

                case 63:
                    button8.BackColor = Color.Yellow;
                    break;

                case 38:
                    button10.BackColor = Color.Yellow;
                    break;

                case 181:
                    button11.BackColor = Color.Yellow;
                    break;

                case 95:
                    button25.BackColor = Color.Yellow;
                    break;

                case 43:
                    button24.BackColor = Color.Yellow;
                    break;

                case 59:
                    button3.BackColor = Color.Yellow;
                    break;

                case 40:
                    button22.BackColor = Color.Yellow;
                    break;

                case 41:
                    button2.BackColor = Color.Yellow;
                    break;

                case 61:
                    button14.BackColor = Color.Yellow;
                    break;

                case 46:
                    button13.BackColor = Color.Yellow;
                    break;

                case 39:
                    button12.BackColor = Color.Yellow;
                    break;


                default:
                    break;
            }

            r1.i++;

        }

    }
}
