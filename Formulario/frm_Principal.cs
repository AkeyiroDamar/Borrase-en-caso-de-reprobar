using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frm_Principal : Form
    {
        private Button btnCurrent;
        private Panel leftBorderBtn;
        private Form frmCurrent;
        public frm_Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 50);
            menu_Botones.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormularioSecundario(Form frmSecundario)
        {
            if (frmCurrent != null)
            {
                frmCurrent.Close();
            }
            frmCurrent = frmSecundario;
            //End
            frmSecundario.TopLevel = false;
            frmSecundario.FormBorderStyle = FormBorderStyle.None;
            frmSecundario.Dock = DockStyle.Fill;
            menu_Cuerpo.Controls.Add(frmSecundario);
            menu_Cuerpo.Tag = frmSecundario;
            frmSecundario.BringToFront();
            frmSecundario.Show();
            lbl_Subtitulo.Text = "Formulario de " + frmSecundario.Text;
        }

        private void btn_EOQ_SIN_Click(object sender, EventArgs e)
        {
            FormularioSecundario(new frm_EOQ_SIN());
        }

        private void btn_EOQ_CON_Click(object sender, EventArgs e)
        {
            FormularioSecundario(new frm_EOQ_CON());
        }

        private void btn_EOQ_DESC_Click(object sender, EventArgs e)
        {
            FormularioSecundario(new frm_EOQ_DESC());
        }

        private void btn_EOP_Click(object sender, EventArgs e)
        {
            FormularioSecundario(new frm_EOP());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Arrastrar(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
