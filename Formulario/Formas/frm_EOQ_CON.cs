using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frm_EOQ_CON : Form
    {
        public frm_EOQ_CON()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double d = double.Parse(txt_d.Text);
            double c = double.Parse(txt_c.Text);
            double h = double.Parse(txt_h.Text);
            double p = double.Parse(txt_p.Text);
            double k;
            if (ckb_Habilitar.Checked == true)
            {
                double l = double.Parse(txt_l.Text);
                k = l * c;
            }
            else
            {
                k = double.Parse(txt_k.Text);
            }

            double temp1 = (2 * d * k) / h;
            double temp2 = (p + h) / p;
            double temp3 = p / (p + h);
            double Q = Math.Sqrt(temp1) * Math.Sqrt(temp2);
            double S = Math.Sqrt(temp1) * Math.Sqrt(temp3);
            double t = Q / d;
            temp1 = (d * k) / Q;
            temp2 = d * c;
            temp3 = (h * Math.Pow(S, 2)) / (2 * Q);
            double temp4 = (p * Math.Pow((Q - S), 2)) / (2 * Q);
            double Total = temp1 + temp2 + temp3 + temp4;
            double Faltante = Q - S;
            double Tiempo = p / (p + h);

            txt_Q.Text = Q.ToString();
            txt_t.Text = t.ToString();
            txt_S.Text = S.ToString();
            txt_Tiempo.Text = Tiempo.ToString();
            txt_Faltante.Text = Faltante.ToString();
            txt_Total.Text = Total.ToString();
        }

        private void ckb_Habilitar_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_Habilitar.Checked == true)
            {
                txt_l.Enabled = true;
                txt_k.Enabled = false;
                txt_k.Clear();
            }
            else
            {
                txt_k.Enabled = true;
                txt_l.Enabled = false;
                txt_l.Clear();
            }
        }
    }
}
