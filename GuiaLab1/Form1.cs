namespace GuiaLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaEnlazadaTickets Lista = new ListaEnlazadaTickets();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool rect = Lista.insertarNodo(new Nodo(txtCodigo.Text, txtDescripcion.Text, txtPrioridad.Text));
            if (rect == true)
            {
                MessageBox.Show("Ticket Registrado Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error código duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCodigo.Focus();
            txtDescripcion.Focus();
            txtPrioridad.Focus();
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrioridad.Text = "";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            if (!Lista.mostrarLista(lstLista))
            {
                MessageBox.Show("Lista esta vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
