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
    public partial class frm_EOQ_SIN : Form
    {
        public frm_EOQ_SIN()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double k = double.Parse(txt_k.Text);
            double c = double.Parse(txt_k.Text);
            double h = double.Parse(txt_h.Text);
            double d = double.Parse(txt_d.Text);
            double L = double.Parse(txt_L.Text);

            double temp = 2 * d * k;
            double temp0 = temp / h;
            double Q = Math.Sqrt(temp0);
            double t = Q / d;
            double temp1 = (d * k) / Q;
            double temp2 = d * c;
            double temp3 = (h * Q) / 2;
            double TCUQ = temp1 + temp2 + temp3;
            double Reorden;
            if (L < t)
            {
                Reorden = L * d;
            }
            else
            {
                double n = L / t;
                n = Math.Truncate(n);
                double Le = L - (n * t);
                Reorden = Le * d;
            }
            txt_Q.Text = Q.ToString();
            txt_t.Text = t.ToString();
            txt_TCUQ.Text = TCUQ.ToString();
            txt_Reorden.Text = Reorden.ToString();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }
    }
}
