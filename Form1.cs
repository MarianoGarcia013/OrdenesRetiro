using Ordenes2023.Datos;
using Ordenes2023.Datos.Implementaciones;
using Ordenes2023.Datos.Interfaz;
using Ordenes2023.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenes2023
{
    public partial class Ordenes : Form
    {
        OrdenRetiro nueva;
        OrdenesDAO DAO;
        public Ordenes()
        {
           InitializeComponent();
           DAO = new OrdenesDAO();
           nueva = new OrdenRetiro();          

        }
        private void Ordenes_Load(object sender, EventArgs e)
        {
            CargarCombo();
            limpiar();
        }

        private void CargarCombo()
        {
            DataTable tabla = DAO.ConsultarDB();
            cboMateriales.DataSource  = tabla;
            cboMateriales.ValueMember = tabla.Columns[0].ColumnName;
            cboMateriales.DisplayMember = tabla.Columns[1].ColumnName;
            cboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        public void limpiar()
        {
            dtpFecha.Value = DateTime.Now;
            txtResponsable.Text = string.Empty;
            cboMateriales.SelectedIndex = 0;
            nudCantidad.Value = 1;
        }

        private bool validar()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un responsable", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (string.IsNullOrEmpty(cboMateriales.Text))
            {
                valido = false;
                MessageBox.Show("Debe seleccionar un material por lo menos", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["NomMateriales"].Value.ToString().Equals(cboMateriales.Text))
                {
                    MessageBox.Show("Este material ya fue registrado", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                }
            }
            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                DataRowView item = (DataRowView)cboMateriales.SelectedItem;
                int codigo = Convert.ToInt32(item.Row.ItemArray[0]);
                string nombre = item.Row.ItemArray[1].ToString();
                double stock = Convert.ToDouble(item.Row.ItemArray[2]);
                Material m = new Material(codigo, nombre, stock);

                int cantidad = Convert.ToInt32(nudCantidad.Value);
                DetalleOrden detalle = new DetalleOrden(m, cantidad);
                nueva.AgregarDetalle(detalle);

                // Agrega una nueva fila al DataGridView con los datos del detalle
                dgvDetalles.Rows.Add(new object[] { detalle.material.codigo, detalle.material.nombre, detalle.cantidad });
            }
        }

        private void GrabarOrden()
        {
            nueva.fecha = dtpFecha.Value;
            nueva.responsable = txtResponsable.Text;
            if (DAO.EjecutarInsert(nueva))
            {
                MessageBox.Show("La orden fue cargada con exito", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("NO se pudo insertar la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar
            if (string.IsNullOrEmpty(txtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una orden de retiro!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Confirmar o Grabar
            GrabarOrden();
        }
        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
