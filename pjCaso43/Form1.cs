namespace pjCaso43
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los valores
            string alumno = txtAlumno.Text;
            int e1 = int.Parse(txtE1.Text);
            int e2 = int.Parse(txtE2.Text);
            int e3 = int.Parse(txtE3.Text);
            int e4 = int.Parse(txtE4.Text);
            //Determina la menor nota
            int menor;
            if (e1 < e2) menor = e1; else menor = e2;
            if (e3 < menor) menor = e3;
            if (e3 < menor) menor = e4;

            //calculando el promedio
            double promedio = (e1 + e2 + e3 + e4 - menor) / 3;

            //Determinando la condicion
            string condicion;
            if (promedio <= 12.49)
                condicion = "Desaprobado";
            else
                condicion = "Aprobado";

            //Imprimiendo los resultados
            ListViewItem fila = new ListViewItem(alumno);
            fila.SubItems.Add(e1.ToString());
            fila.SubItems.Add(e2.ToString());
            fila.SubItems.Add(e3.ToString());
            fila.SubItems.Add(e4.ToString());
            fila.SubItems.Add(menor.ToString());
            fila.SubItems.Add(promedio.ToString());
            fila.SubItems.Add(condicion);
            lvRegistro.Items.Add(fila);

            //Limpiando registro
            btnCancelar_Click(sender, e);
        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {
            if (txtAlumno.Text.Trim() == "")
            {
                epError.SetError(txtAlumno, "Ingrese el nombre del alumno..!!");
                txtAlumno.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE1_TextChanged(object sender, EventArgs e)
        {
            if (txtE1.Text.Trim() == "")
            {
                epError.SetError(txtE1, "Ingrese evaluacion 1...!!");
                txtE1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE2_TextChanged(object sender, EventArgs e)
        {
            if (txtE2.Text.Trim() == "")
            {
                epError.SetError(txtE2, "Ingrese evaluacion 2...!!");
                txtE2.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE3_TextChanged(object sender, EventArgs e)
        {
            if (txtE3.Text.Trim() == "")
            {
                epError.SetError(txtE3, "Ingrese evaluacion 3...!!");
                txtE3.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txtE4.Text.Trim() == "")
            {
                epError.SetError(txtE4, "Ingrese evaluacion 4...!!");
                txtE4.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtE1.Clear();
            txtE2.Clear();
            txtE3.Clear();
            txtE4.Clear();
            txtAlumno.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                "Promedio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}