using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargaClientes();
            cargaVehiculos();
        }

        void cargaClientes()
        {
            cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());

        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray());

        }

        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validar

            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;    

            GlobalVar.concesionario
                .RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);


        }
    }
}
