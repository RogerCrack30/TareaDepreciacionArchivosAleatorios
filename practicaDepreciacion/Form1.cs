using AppCore.IServices;
using Domain.Entities;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Form1 : Form
    {
        IActivoServices activoServices;
  
        private int SelecionarId;
     
        public Form1(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }

       

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

     
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txvalor.Text) || String.IsNullOrEmpty(txutil.Text) || String.IsNullOrEmpty(txvalorr.Text))
            {
              
                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txvalor.Text = "";
            this.txvalorr.Text = "";
            this.txutil.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(SelecionarId.ToString());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }

        
        private void txvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txvalorr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txutil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void nuevoActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txvalor.Text),
                    ValorResidual = double.Parse(txvalorr.Text),
                    VidaUtil = int.Parse(txutil.Text)
                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }

        private void borrarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo()
            {
                Id = (int)numericUpDown1.Value
            };
            numericUpDown1.Value = 0;
            activoServices.Delete(activo);
            dataGridView1.DataSource = null;
            limpiar();
            dataGridView1.DataSource = activoServices.Read();
        }

        private void actualizarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool verficar = verificar();
                if (verficar == false)
                {
                    MessageBox.Show("Tienes que llenar todo los cuadros del formulario");

                }
                else
                {
                    Activo activo = new Activo()
                    {
                        Nombre = txtNombre.Text,
                        Valor = double.Parse(txvalor.Text),
                        ValorResidual = double.Parse(txvalorr.Text),
                        VidaUtil = int.Parse(txutil.Text),
                        Id = (int)numericUpDown1.Value
                    };
                    activoServices.Update(activo);
                    dataGridView1.DataSource = null;
                    limpiar();
                    dataGridView1.DataSource = activoServices.Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirDeLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
