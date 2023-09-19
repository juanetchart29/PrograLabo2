namespace Ejercicio5._04
{
    public partial class Form1 : Form
    {
        public List<int> lista = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;
            bool ok = int.TryParse(this.inputInt.Text, out numero);
            
            lista.Add(numero);
            this.listBox.Items.Add(numero);

            this.inputInt.Text = string.Empty;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lista.Sort();
            if(this.rbtnDescendente.Checked)
            {
                lista.Reverse();
            }
           
            listBox.Items.Clear();
            foreach(int num in lista)
            {
                listBox.Items.Add(num);
            }
        }



    }
}

// para limpiar todos los elemenots foreach(Control control in this.controls){
//  control.text = "";
//}