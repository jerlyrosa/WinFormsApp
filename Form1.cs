namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalDebito_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          int totalD = 0; 
          int filas =  dgwContent.Rows.Add(txtCuenta.Text, txtNombreCuenta.Text);
            txtCuenta.Clear();
            txtNombreCuenta.Clear();
            if(comboBox1.SelectedItem.ToString() == "Debito")
            {
                dgwContent.Rows[filas].Cells[2].Value = txtMonto.Text;
                txtMonto.Clear();
                txtCuenta.Focus();
                foreach (DataGridViewRow row in dgwContent.Rows)

                {

                    totalD += Convert.ToInt32(row.Cells["Column3"].Value);
                }
                totalDebito.Text = Convert.ToString(totalD);


            }
            else
            {
                dgwContent.Rows[filas].Cells[3].Value = txtMonto.Text;
                txtMonto.Clear();
                txtCuenta.Focus();
                foreach (DataGridViewRow row in dgwContent.Rows)

                {

                    totalD += Convert.ToInt32(row.Cells["Column4"].Value);
                }
                totalCredito.Text = Convert.ToString(totalD);
            }


        }
    }
}