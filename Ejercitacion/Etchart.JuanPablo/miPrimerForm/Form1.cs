namespace miPrimerForm;

public partial class Button_HI : Form
{
    public Button_HI()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("vamaaaa");
        this.btnSaludar.Text = "Bienvenido wiliwonka";
    }
}