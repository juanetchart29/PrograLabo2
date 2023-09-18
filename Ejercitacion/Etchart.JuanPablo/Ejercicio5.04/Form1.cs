namespace Ejercicio5._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.textBox1.Text);
        }

    }
}

// para limpiar todos los elemenots foreach(Control control in this.controls){
//  control.text = "";
//}