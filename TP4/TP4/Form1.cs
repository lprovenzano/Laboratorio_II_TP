using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCorreo
{
	public partial class Form1 : Form
	{
		Correo c;

		public Form1()
		{
			InitializeComponent();
			c = new Correo();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtDireccion.Text.Length > 0 && txtID.MaskCompleted)
				{
					Paquete p = new Paquete(txtDireccion.Text, txtID.Text);
					p.InformaEstado += paq_InformaEstado;
					c = c + p;
					ActualizarEstados();
				}
				else
				{
					throw new TrackingIdRepetidoException("Debe completar los datos correctamente.");
				}
			}
			catch (TrackingIdRepetidoException exc)
			{
				MessageBox.Show(exc.Message, "Ups...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void paq_InformaEstado(object sender, EventArgs e)
		{
			if (this.InvokeRequired)
			{
				Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
				this.Invoke(d, new object[] { sender, e });
			}
			else
			{
				ActualizarEstados();
			}
		}

		private void ActualizarEstados()
		{
			listIngresado.Items.Clear();
			listViaje.Items.Clear();
			listEntregado.Items.Clear();

			foreach (Paquete item in c.Paquetes)
			{
				switch (item.Estado)
				{
					case Paquete.EEstado.Ingresado:
						listIngresado.Items.Add(item.MostrarDatos(item));
						break;
					case Paquete.EEstado.EnViaje:
						listViaje.Items.Add(item.MostrarDatos(item));
						break;
					case Paquete.EEstado.Entregado:
						listEntregado.Items.Add(item.MostrarDatos(item));
						break;
				}
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			c.FinEntregas();
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)c);
		}

		private void MostrarInformacion<T>(IMostrar<T> elemento)
		{
			string todosLosCorreos = c.MostrarDatos((IMostrar<List<Paquete>>)c);
			if (todosLosCorreos.Length > 0)
			{
				richMostrarTodos.Text = todosLosCorreos;
				todosLosCorreos.Guardar("salida.txt");
			}
			else
			{
				MessageBox.Show("Aún no se enviaron paquetes.", "Ups...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)c);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}
}
