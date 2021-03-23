namespace Formulario
{
    partial class frm_EOP
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
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_Cp = new System.Windows.Forms.TextBox();
            this.txt_Rmin = new System.Windows.Forms.TextBox();
            this.txt_Pmin = new System.Windows.Forms.TextBox();
            this.txt_R = new System.Windows.Forms.TextBox();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_Cp = new System.Windows.Forms.Label();
            this.lbl_Rmin = new System.Windows.Forms.Label();
            this.lbl_Pmin = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.lbl_P = new System.Windows.Forms.Label();
            this.lbl_Ch = new System.Windows.Forms.Label();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.lbl_I = new System.Windows.Forms.Label();
            this.lbl_Qo = new System.Windows.Forms.Label();
            this.txt_Ch = new System.Windows.Forms.TextBox();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.txt_I = new System.Windows.Forms.TextBox();
            this.txt_Qo = new System.Windows.Forms.TextBox();
            this.txt_TICo = new System.Windows.Forms.TextBox();
            this.lbl_TICo = new System.Windows.Forms.Label();
            this.ckb_Pmin = new System.Windows.Forms.CheckBox();
            this.ckb_Rmin = new System.Windows.Forms.CheckBox();
            this.ckb_I = new System.Windows.Forms.CheckBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_C
            // 
            this.txt_C.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.Location = new System.Drawing.Point(262, 173);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(100, 26);
            this.txt_C.TabIndex = 23;
            // 
            // txt_Cp
            // 
            this.txt_Cp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cp.Location = new System.Drawing.Point(262, 141);
            this.txt_Cp.Name = "txt_Cp";
            this.txt_Cp.Size = new System.Drawing.Size(100, 26);
            this.txt_Cp.TabIndex = 22;
            // 
            // txt_Rmin
            // 
            this.txt_Rmin.Enabled = false;
            this.txt_Rmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Rmin.Location = new System.Drawing.Point(262, 109);
            this.txt_Rmin.Name = "txt_Rmin";
            this.txt_Rmin.Size = new System.Drawing.Size(100, 26);
            this.txt_Rmin.TabIndex = 21;
            // 
            // txt_Pmin
            // 
            this.txt_Pmin.Enabled = false;
            this.txt_Pmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pmin.Location = new System.Drawing.Point(262, 77);
            this.txt_Pmin.Name = "txt_Pmin";
            this.txt_Pmin.Size = new System.Drawing.Size(100, 26);
            this.txt_Pmin.TabIndex = 20;
            // 
            // txt_R
            // 
            this.txt_R.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_R.Location = new System.Drawing.Point(262, 44);
            this.txt_R.Name = "txt_R";
            this.txt_R.Size = new System.Drawing.Size(100, 26);
            this.txt_R.TabIndex = 19;
            // 
            // txt_P
            // 
            this.txt_P.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P.Location = new System.Drawing.Point(262, 12);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(100, 26);
            this.txt_P.TabIndex = 18;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_C.Location = new System.Drawing.Point(101, 176);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(155, 19);
            this.lbl_C.TabIndex = 17;
            this.lbl_C.Text = "Costo del producto (C):";
            // 
            // lbl_Cp
            // 
            this.lbl_Cp.AutoSize = true;
            this.lbl_Cp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cp.Location = new System.Drawing.Point(106, 144);
            this.lbl_Cp.Name = "lbl_Cp";
            this.lbl_Cp.Size = new System.Drawing.Size(150, 19);
            this.lbl_Cp.TabIndex = 16;
            this.lbl_Cp.Text = "Costo del pedido (Cp):";
            // 
            // lbl_Rmin
            // 
            this.lbl_Rmin.AutoSize = true;
            this.lbl_Rmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rmin.Location = new System.Drawing.Point(130, 112);
            this.lbl_Rmin.Name = "lbl_Rmin";
            this.lbl_Rmin.Size = new System.Drawing.Size(126, 19);
            this.lbl_Rmin.TabIndex = 15;
            this.lbl_Rmin.Text = "Demanda diaria (r):";
            // 
            // lbl_Pmin
            // 
            this.lbl_Pmin.AutoSize = true;
            this.lbl_Pmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pmin.Location = new System.Drawing.Point(116, 80);
            this.lbl_Pmin.Name = "lbl_Pmin";
            this.lbl_Pmin.Size = new System.Drawing.Size(140, 19);
            this.lbl_Pmin.TabIndex = 14;
            this.lbl_Pmin.Text = "Produccion diaria (p):";
            // 
            // lbl_R
            // 
            this.lbl_R.AutoSize = true;
            this.lbl_R.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_R.Location = new System.Drawing.Point(127, 47);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(129, 19);
            this.lbl_R.TabIndex = 13;
            this.lbl_R.Text = "Demanda anual (R):";
            // 
            // lbl_P
            // 
            this.lbl_P.AutoSize = true;
            this.lbl_P.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P.Location = new System.Drawing.Point(117, 15);
            this.lbl_P.Name = "lbl_P";
            this.lbl_P.Size = new System.Drawing.Size(139, 19);
            this.lbl_P.TabIndex = 12;
            this.lbl_P.Text = "Produccion anual (P):";
            // 
            // lbl_Ch
            // 
            this.lbl_Ch.AutoSize = true;
            this.lbl_Ch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ch.Location = new System.Drawing.Point(114, 208);
            this.lbl_Ch.Name = "lbl_Ch";
            this.lbl_Ch.Size = new System.Drawing.Size(142, 19);
            this.lbl_Ch.TabIndex = 24;
            this.lbl_Ch.Text = "Costo sostenido (Ch):";
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tiempo.Location = new System.Drawing.Point(111, 240);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(145, 19);
            this.lbl_Tiempo.TabIndex = 25;
            this.lbl_Tiempo.Text = "Tiempo de produccion";
            // 
            // lbl_I
            // 
            this.lbl_I.AutoSize = true;
            this.lbl_I.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_I.Location = new System.Drawing.Point(78, 272);
            this.lbl_I.Name = "lbl_I";
            this.lbl_I.Size = new System.Drawing.Size(178, 19);
            this.lbl_I.TabIndex = 26;
            this.lbl_I.Text = "Tasa de almacenamiento (I):";
            // 
            // lbl_Qo
            // 
            this.lbl_Qo.AutoSize = true;
            this.lbl_Qo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qo.Location = new System.Drawing.Point(208, 325);
            this.lbl_Qo.Name = "lbl_Qo";
            this.lbl_Qo.Size = new System.Drawing.Size(244, 19);
            this.lbl_Qo.TabIndex = 27;
            this.lbl_Qo.Text = "Lote de trabajo por cada pedido (Qo):";
            // 
            // txt_Ch
            // 
            this.txt_Ch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ch.Location = new System.Drawing.Point(262, 205);
            this.txt_Ch.Name = "txt_Ch";
            this.txt_Ch.Size = new System.Drawing.Size(100, 26);
            this.txt_Ch.TabIndex = 28;
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tiempo.Location = new System.Drawing.Point(262, 237);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(100, 26);
            this.txt_Tiempo.TabIndex = 29;
            // 
            // txt_I
            // 
            this.txt_I.Enabled = false;
            this.txt_I.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_I.Location = new System.Drawing.Point(262, 269);
            this.txt_I.Name = "txt_I";
            this.txt_I.Size = new System.Drawing.Size(100, 26);
            this.txt_I.TabIndex = 30;
            // 
            // txt_Qo
            // 
            this.txt_Qo.Enabled = false;
            this.txt_Qo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qo.Location = new System.Drawing.Point(458, 322);
            this.txt_Qo.Name = "txt_Qo";
            this.txt_Qo.ReadOnly = true;
            this.txt_Qo.Size = new System.Drawing.Size(100, 26);
            this.txt_Qo.TabIndex = 31;
            // 
            // txt_TICo
            // 
            this.txt_TICo.Enabled = false;
            this.txt_TICo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TICo.Location = new System.Drawing.Point(458, 354);
            this.txt_TICo.Name = "txt_TICo";
            this.txt_TICo.ReadOnly = true;
            this.txt_TICo.Size = new System.Drawing.Size(100, 26);
            this.txt_TICo.TabIndex = 32;
            // 
            // lbl_TICo
            // 
            this.lbl_TICo.AutoSize = true;
            this.lbl_TICo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TICo.Location = new System.Drawing.Point(322, 357);
            this.lbl_TICo.Name = "lbl_TICo";
            this.lbl_TICo.Size = new System.Drawing.Size(130, 19);
            this.lbl_TICo.TabIndex = 33;
            this.lbl_TICo.Text = "Costo Total (TICo):";
            // 
            // ckb_Pmin
            // 
            this.ckb_Pmin.AutoSize = true;
            this.ckb_Pmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Pmin.Location = new System.Drawing.Point(368, 82);
            this.ckb_Pmin.Name = "ckb_Pmin";
            this.ckb_Pmin.Size = new System.Drawing.Size(29, 19);
            this.ckb_Pmin.TabIndex = 36;
            this.ckb_Pmin.Text = " ";
            this.ckb_Pmin.UseVisualStyleBackColor = true;
            this.ckb_Pmin.CheckedChanged += new System.EventHandler(this.ckb_Pmin_CheckedChanged);
            // 
            // ckb_Rmin
            // 
            this.ckb_Rmin.AutoSize = true;
            this.ckb_Rmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Rmin.Location = new System.Drawing.Point(368, 114);
            this.ckb_Rmin.Name = "ckb_Rmin";
            this.ckb_Rmin.Size = new System.Drawing.Size(29, 19);
            this.ckb_Rmin.TabIndex = 37;
            this.ckb_Rmin.Text = " ";
            this.ckb_Rmin.UseVisualStyleBackColor = true;
            this.ckb_Rmin.CheckedChanged += new System.EventHandler(this.ckb_Rmin_CheckedChanged);
            // 
            // ckb_I
            // 
            this.ckb_I.AutoSize = true;
            this.ckb_I.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_I.Location = new System.Drawing.Point(368, 274);
            this.ckb_I.Name = "ckb_I";
            this.ckb_I.Size = new System.Drawing.Size(29, 19);
            this.ckb_I.TabIndex = 42;
            this.ckb_I.Text = " ";
            this.ckb_I.UseVisualStyleBackColor = true;
            this.ckb_I.CheckedChanged += new System.EventHandler(this.ckb_I_CheckedChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(458, 223);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(98, 33);
            this.btn_Calcular.TabIndex = 43;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.Location = new System.Drawing.Point(458, 262);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(98, 33);
            this.btn_Borrar.TabIndex = 44;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // frm_EOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.ckb_I);
            this.Controls.Add(this.ckb_Rmin);
            this.Controls.Add(this.ckb_Pmin);
            this.Controls.Add(this.lbl_TICo);
            this.Controls.Add(this.txt_TICo);
            this.Controls.Add(this.txt_Qo);
            this.Controls.Add(this.txt_I);
            this.Controls.Add(this.txt_Tiempo);
            this.Controls.Add(this.txt_Ch);
            this.Controls.Add(this.lbl_Qo);
            this.Controls.Add(this.lbl_I);
            this.Controls.Add(this.lbl_Tiempo);
            this.Controls.Add(this.lbl_Ch);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_Cp);
            this.Controls.Add(this.txt_Rmin);
            this.Controls.Add(this.txt_Pmin);
            this.Controls.Add(this.txt_R);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_Cp);
            this.Controls.Add(this.lbl_Rmin);
            this.Controls.Add(this.lbl_Pmin);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.lbl_P);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EOP";
            this.Text = "EOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_Cp;
        private System.Windows.Forms.TextBox txt_Rmin;
        private System.Windows.Forms.TextBox txt_Pmin;
        private System.Windows.Forms.TextBox txt_R;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_Cp;
        private System.Windows.Forms.Label lbl_Rmin;
        private System.Windows.Forms.Label lbl_Pmin;
        private System.Windows.Forms.Label lbl_R;
        private System.Windows.Forms.Label lbl_P;
        private System.Windows.Forms.Label lbl_Ch;
        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Label lbl_I;
        private System.Windows.Forms.Label lbl_Qo;
        private System.Windows.Forms.TextBox txt_Ch;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.TextBox txt_I;
        private System.Windows.Forms.TextBox txt_Qo;
        private System.Windows.Forms.TextBox txt_TICo;
        private System.Windows.Forms.Label lbl_TICo;
        private System.Windows.Forms.CheckBox ckb_Pmin;
        private System.Windows.Forms.CheckBox ckb_Rmin;
        private System.Windows.Forms.CheckBox ckb_I;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Borrar;
    }
}