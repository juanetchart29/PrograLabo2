using System.Text;
using System.Text.RegularExpressions;

namespace Ejercicio5._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ApretarEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                AsignarTabla();
            }
        }

        private void AsignarTabla()
        {
            this.lstTabla.Items.Clear();
            if (this.textBox1.Text == string.Empty) { MessageBox.Show("escribi un numero gil"); }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    this.lstTabla.Items.Add($"{this.textBox1.Text} x {i} = {i * int.Parse(textBox1.Text)} ");
                }
            }

        }
        private void LimpiarText()
        {
            foreach (Control control in this.Controls)
            {
                if (control is not Button && control is not Label)
                {
                    control.Text = string.Empty;
                    
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarText();
            this.lstTabla.Items.Clear();
        }


    }
}