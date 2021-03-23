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
    public partial class frm_EOP : Form
    {
        public frm_EOP()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double P,R,p,r,Cp,C,Ch,t,I;
            t = double.Parse(txt_Tiempo.Text);
            C = double.Parse(txt_C.Text);
            Cp = double.Parse(txt_Cp.Text);

            if (ckb_I.Checked == true)
            {
                I = double.Parse(txt_I.Text);
                I = I / 100;
                Ch = C * I;
                txt_Ch.Text = Ch.ToString();
            }
            else
            {
                Ch = double.Parse(txt_Ch.Text);
            }
            if (ckb_Pmin.Checked == true)
            {
                p = double.Parse(txt_Pmin.Text);
                P = p * t;
                txt_P.Text = P.ToString();
            }
            else
            {
                P = double.Parse(txt_P.Text);
                p = P / t;
                txt_Pmin.Text = p.ToString();

            }
            if (ckb_Rmin.Checked == true)
            {
                r = double.Parse(txt_Rmin.Text);
                R = r * t;
                txt_R.Text = R.ToString();
            }
            else
            {
                R = double.Parse(txt_R.Text);
                r = R / t;
                txt_Rmin.Text = r.ToString();
            }

            double temp1 = 2 * R * Cp;
            double temp2 = Ch * (1 - (r / p));
            double temp3 = temp1 / temp2;
            double temp4 = temp1 * temp2;

            double Qo = Math.Sqrt(temp3);
            double TICo = Math.Sqrt(temp4);

            txt_Qo.Text = Qo.ToString();
            txt_TICo.Text = TICo.ToString();

            btn_Calcular.Enabled = false;
        }

        private void ckb_Pmin_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_Pmin.Checked == true)
            {
                txt_P.Enabled = false;
                txt_P.Text = "";
                txt_Pmin.Enabled = true;
            }
            else
            {
                txt_P.Enabled = true;
                txt_Pmin.Enabled = false;
                txt_Pmin.Text = "";
            }
        }

        private void ckb_Rmin_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_Rmin.Checked == true)
            {
                txt_R.Enabled = false;
                txt_R.Text = "";
                txt_Rmin.Enabled = true;
            }
            else
            {
                txt_R.Enabled = true;
                txt_Rmin.Enabled = false;
                txt_Rmin.Text = "";
            }
        }

        private void ckb_I_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_I.Checked == true)
            {
                txt_Ch.Enabled = false;
                txt_Ch.Text = "";
                txt_I.Enabled = true;
            }
            else
            {
                txt_Ch.Enabled = true;
                txt_I.Enabled = false;
                txt_I.Text = "";
            }
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
            btn_Calcular.Enabled = true;
        }
    }
}
