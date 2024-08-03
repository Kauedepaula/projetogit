namespace Projeto_Git
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txValor1.Text);
            var2 = int.Parse(txValor2.Text);

            total = var1 + var2;

            lblResultado.Text = total.ToString();
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txValor1.Text);
            var2 = int.Parse(txValor2.Text);

            total = var1 * var2;

            lblResultado.Text = total.ToString();
        }

        private void btnsubtrai_Click(object sender, EventArgs e)
        {
            int var1, var2, total;
            var1 = int.Parse(txValor1.Text);
            var2 = int.Parse(txValor2.Text);

            total = var1 - var2;

            lblResultado.Text = total.ToString();
        }
    }
}
