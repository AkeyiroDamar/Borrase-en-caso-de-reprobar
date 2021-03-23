namespace Formulario
{
    partial class frm_EOQ_CON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.lbl_Perdida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.lbl_Kosto = new System.Windows.Forms.Label();
            this.lbl_Demanda = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_l = new System.Windows.Forms.Label();
            this.txt_l = new System.Windows.Forms.TextBox();
            this.lbl_Q = new System.Windows.Forms.Label();
            this.lbl_t = new System.Windows.Forms.Label();
            this.lbl_S = new System.Windows.Forms.Label();
            this.lbl_Faltante = new System.Windows.Forms.Label();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.txt_S = new System.Windows.Forms.TextBox();
            this.txt_Faltante = new System.Windows.Forms.TextBox();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.ckb_Habilitar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_p
            // 
            this.txt_p.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p.Location = new System.Drawing.Point(206, 193);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 26);
            this.txt_p.TabIndex = 22;
            // 
            // txt_h
            // 
            this.txt_h.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_h.Location = new System.Drawing.Point(206, 161);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 26);
            this.txt_h.TabIndex = 21;
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(206, 129);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 26);
            this.txt_c.TabIndex = 20;
            // 
            // txt_k
            // 
            this.txt_k.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k.Location = new System.Drawing.Point(206, 97);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 26);
            this.txt_k.TabIndex = 19;
            // 
            // txt_d
            // 
            this.txt_d.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_d.Location = new System.Drawing.Point(206, 65);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 26);
            this.txt_d.TabIndex = 18;
            // 
            // lbl_Perdida
            // 
            this.lbl_Perdida.AutoSize = true;
            this.lbl_Perdida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Perdida.Location = new System.Drawing.Point(119, 196);
            this.lbl_Perdida.Name = "lbl_Perdida";
            this.lbl_Perdida.Size = new System.Drawing.Size(81, 19);
            this.lbl_Perdida.TabIndex = 16;
            this.lbl_Perdida.Text = "Perdida (p):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Costo de almacenamiento (h):";
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Costo.Location = new System.Drawing.Point(82, 132);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(118, 19);
            this.lbl_Costo.TabIndex = 14;
            this.lbl_Costo.Text = "Costo unitario (c):";
            // 
            // lbl_Kosto
            // 
            this.lbl_Kosto.AutoSize = true;
            this.lbl_Kosto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kosto.Location = new System.Drawing.Point(78, 100);
            this.lbl_Kosto.Name = "lbl_Kosto";
            this.lbl_Kosto.Size = new System.Drawing.Size(122, 19);
            this.lbl_Kosto.TabIndex = 13;
            this.lbl_Kosto.Text = "Costo por lote (k):";
            // 
            // lbl_Demanda
            // 
            this.lbl_Demanda.AutoSize = true;
            this.lbl_Demanda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Demanda.Location = new System.Drawing.Point(108, 68);
            this.lbl_Demanda.Name = "lbl_Demanda";
            this.lbl_Demanda.Size = new System.Drawing.Size(92, 19);
            this.lbl_Demanda.TabIndex = 12;
            this.lbl_Demanda.Text = "Demanda (d):";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(218, 267);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 23;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_l
            // 
            this.lbl_l.AutoSize = true;
            this.lbl_l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l.Location = new System.Drawing.Point(143, 228);
            this.lbl_l.Name = "lbl_l";
            this.lbl_l.Size = new System.Drawing.Size(57, 19);
            this.lbl_l.TabIndex = 24;
            this.lbl_l.Text = "Tasa (l):";
            // 
            // txt_l
            // 
            this.txt_l.Enabled = false;
            this.txt_l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l.Location = new System.Drawing.Point(206, 225);
            this.txt_l.Name = "txt_l";
            this.txt_l.Size = new System.Drawing.Size(100, 26);
            this.txt_l.TabIndex = 25;
            // 
            // lbl_Q
            // 
            this.lbl_Q.AutoSize = true;
            this.lbl_Q.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Q.Location = new System.Drawing.Point(418, 68);
            this.lbl_Q.Name = "lbl_Q";
            this.lbl_Q.Size = new System.Drawing.Size(132, 19);
            this.lbl_Q.TabIndex = 26;
            this.lbl_Q.Text = "Cuanto pedir? (Q*):";
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_t.Location = new System.Drawing.Point(422, 100);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(128, 19);
            this.lbl_t.TabIndex = 27;
            this.lbl_t.Text = "Cuando pedir? (t*):";
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_S.Location = new System.Drawing.Point(210, 132);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(340, 19);
            this.lbl_S.TabIndex = 28;
            this.lbl_S.Text = "Nivel de inventario despues de recibir pedido Q* (S*):";
            // 
            // lbl_Faltante
            // 
            this.lbl_Faltante.AutoSize = true;
            this.lbl_Faltante.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Faltante.Location = new System.Drawing.Point(371, 164);
            this.lbl_Faltante.Name = "lbl_Faltante";
            this.lbl_Faltante.Size = new System.Drawing.Size(179, 19);
            this.lbl_Faltante.TabIndex = 29;
            this.lbl_Faltante.Text = "Faltante Maximo (Q* - S*):";
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Tiempo.Location = new System.Drawing.Point(260, 196);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(290, 19);
            this.lbl_Tiempo.TabIndex = 30;
            this.lbl_Tiempo.Text = "Fraccion de tiempo en que no existen faltantes:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbl_Total.Location = new System.Drawing.Point(471, 231);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(79, 19);
            this.lbl_Total.TabIndex = 31;
            this.lbl_Total.Text = "Costo total:";
            // 
            // txt_Q
            // 
            this.txt_Q.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Q.Location = new System.Drawing.Point(556, 65);
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.ReadOnly = true;
            this.txt_Q.Size = new System.Drawing.Size(100, 26);
            this.txt_Q.TabIndex = 32;
            // 
            // txt_t
            // 
            this.txt_t.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_t.Location = new System.Drawing.Point(556, 97);
            this.txt_t.Name = "txt_t";
            this.txt_t.ReadOnly = true;
            this.txt_t.Size = new System.Drawing.Size(100, 26);
            this.txt_t.TabIndex = 33;
            // 
            // txt_S
            // 
            this.txt_S.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_S.Location = new System.Drawing.Point(556, 129);
            this.txt_S.Name = "txt_S";
            this.txt_S.ReadOnly = true;
            this.txt_S.Size = new System.Drawing.Size(100, 26);
            this.txt_S.TabIndex = 34;
            // 
            // txt_Faltante
            // 
            this.txt_Faltante.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Faltante.Location = new System.Drawing.Point(556, 161);
            this.txt_Faltante.Name = "txt_Faltante";
            this.txt_Faltante.ReadOnly = true;
            this.txt_Faltante.Size = new System.Drawing.Size(100, 26);
            this.txt_Faltante.TabIndex = 35;
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Tiempo.Location = new System.Drawing.Point(556, 193);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.ReadOnly = true;
            this.txt_Tiempo.Size = new System.Drawing.Size(100, 26);
            this.txt_Tiempo.TabIndex = 36;
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Total.Location = new System.Drawing.Point(556, 228);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 26);
            this.txt_Total.TabIndex = 37;
            // 
            // ckb_Habilitar
            // 
            this.ckb_Habilitar.AutoSize = true;
            this.ckb_Habilitar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckb_Habilitar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ckb_Habilitar.Location = new System.Drawing.Point(58, 227);
            this.ckb_Habilitar.Name = "ckb_Habilitar";
            this.ckb_Habilitar.Size = new System.Drawing.Size(79, 23);
            this.ckb_Habilitar.TabIndex = 38;
            this.ckb_Habilitar.Text = "Habilitar";
            this.ckb_Habilitar.UseVisualStyleBackColor = true;
            this.ckb_Habilitar.CheckedChanged += new System.EventHandler(this.ckb_Habilitar_CheckedChanged);
            // 
            // frm_EOQ_CON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.ckb_Habilitar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Tiempo);
            this.Controls.Add(this.txt_Faltante);
            this.Controls.Add(this.txt_S);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Faltante);
            this.Controls.Add(this.lbl_t);
            this.Controls.Add(this.lbl_Q);
            this.Controls.Add(this.txt_l);
            this.Controls.Add(this.lbl_l);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.lbl_Perdida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Costo);
            this.Controls.Add(this.lbl_Kosto);
            this.Controls.Add(this.lbl_Demanda);
            this.Controls.Add(this.lbl_S);
            this.Controls.Add(this.lbl_Tiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EOQ_CON";
            this.Text = "EOQ con Deficit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label lbl_Perdida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Costo;
        private System.Windows.Forms.Label lbl_Kosto;
        private System.Windows.Forms.Label lbl_Demanda;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_l;
        private System.Windows.Forms.TextBox txt_l;
        private System.Windows.Forms.Label lbl_Q;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.Label lbl_Faltante;
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.TextBox txt_Faltante;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.CheckBox ckb_Habilitar;
    }
}