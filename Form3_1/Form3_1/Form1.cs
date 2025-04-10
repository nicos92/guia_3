using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSMessageBox;
using System.Text.RegularExpressions;

namespace Form3_1
{
    public partial class Form1 : Form
    {
        const string patterdouble = @"^\d{1,9}?$";
        

        public Form1()
        {
            InitializeComponent();
        }

        int MontoIngresado;
        int ValorProducto;
        int resto;

        int[] arrPesos = {  2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] arrCentavos = {  50, 25, 10, 5 };


        private List<TipoCambio> ListTipoCambio = new List<TipoCambio>();

        private void TbValorProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigitodouble(e);


        }
        private void TbMontoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoDigitoEntero(e);
            
        }


        private void IngresoDigitoEntero(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        /// <summary>
        /// deja ingresar numeros y comas
        /// </summary>
        /// <param name="e"> caracter a validar</param>
        private void IngresoDigitodouble(KeyPressEventArgs e)
        {
            string futurovalor = TbValorProducto.Text + e.KeyChar;

            if (Regex.IsMatch(futurovalor, patterdouble) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }




        }



        private void BtnCalcularVuelto_Click(object sender, EventArgs e)
        {
            ListTipoCambio.Clear();

            DialogResult dr = MessageBox.Show( "¿Estas seguro que querés hacer el cálculo?\nValor producto: ", "Cuenta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                TLPVuelto.SetColumn(Img, 0);
                TLPVuelto.SetRow(LvListaCambio, 1);
                LvListaCambio.Visible = true;
                resto = MontoIngresado - ValorProducto;

                LblTotalCambio.Text = "Cambio Total: $" + resto.ToString().Replace('.',',');
                LblTotalCambio.Visible = true;
                AgregarItemLista(resto);

                AgregarItemCambio();
            }




        }

        private void AgregarItemLista(int resto)
        {
            for (int i = 0; i < arrPesos.Length; i++)
            {
                if (resto >= arrPesos[i])
                {
                    
                    int resultado = resto / arrPesos[i];
                    if (resultado != 0)
                    {
                        resto = Convert.ToInt32(resto ) % Convert.ToInt32(arrPesos[i]);

                        TipoCambio tc = new TipoCambio();
                        tc.Tipo = arrPesos[i] > 10 ? "Billete de " : "Moneda de";
                        tc.Valor = "$" + arrPesos[i].ToString();
                        tc.Cantidad = resultado.ToString();

                        ListTipoCambio.Add(tc);
                    }
                }
            }
        }

        private void AgregarItemCambio()
        {
            LvListaCambio.Items.Clear();
            LvListaCambio.View = View.Details; // Establecer la vista a Detalles


            foreach (var item in ListTipoCambio)
            {


                ListViewItem lvi = new ListViewItem(item.Tipo);

                lvi.SubItems.Add(item.Valor);
                lvi.SubItems.Add(item.Cantidad);

                LvListaCambio.Items.Add(lvi);
            }
        }

        private void HabilitarBtnCalcular()
        {
            if (TbValorProducto.Text.Length == 0 || TbPagacon.Text.Length == 0)
            {
                BtnCalcularVuelto.Enabled = false;
            }

            if (TbValorProducto.Text.Length > 0 && TbPagacon.Text.Length > 0)
            {
                GuardarValores();
                BtnCalcularVuelto.Enabled = MontoIngresado>= ValorProducto;
            }
        }

       
        private void GuardarValores()
        {
           
            MontoIngresado = Convert.ToInt32(TbPagacon.Text.Replace(',', '.'));
            ValorProducto = Convert.ToInt32(TbValorProducto.Text.Replace(',', '.'));


        }


        private void TbMontoIngresado__TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCalcular();
        }

        private void TbValorProducto__TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCalcular();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TbValorProducto.Focus();
            TLPVuelto.SetColumn(Img, 1);
            
        }

        private void BtnCalcularVuelto_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnCalcularVuelto.Enabled)
            {
                BtnCalcularVuelto.FlatAppearance.BorderColor = ColoresARGB.White;
                BtnCalcularVuelto.BackColor = ColoresARGB.Primary;
                BtnCalcularVuelto.Font = new Font("Verdana", 12, FontStyle.Bold);
            }
            else
            {
                BtnCalcularVuelto.FlatAppearance.BorderColor = ColoresARGB.Black;

                BtnCalcularVuelto.BackColor = ColoresARGB.Secondary;
                BtnCalcularVuelto.Font = new Font("Verdana", 10, FontStyle.Regular);


            }
        }

        private void TbValorProducto_Enter(object sender, EventArgs e)
        {
            TbValorProducto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TbValorProducto_Leave(object sender, EventArgs e)
        {
            TbValorProducto.BorderStyle = BorderStyle.FixedSingle;

        }

        private void TbMontoIngresado_Enter(object sender, EventArgs e)
        {
            TbPagacon.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TbMontoIngresado_Leave(object sender, EventArgs e)
        {
            TbPagacon.BorderStyle = BorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TLPVuelto.SetRow(LvListaCambio, 0);
            LvListaCambio.Visible = false;
            TLPVuelto.SetColumn(Img, 1);
            TbValorProducto.Text = string.Empty;
            TbPagacon.Text = string.Empty;
            LblTotalCambio.Text = "Cambio Total:";
            TbValorProducto.Focus();
        }
    }
}
