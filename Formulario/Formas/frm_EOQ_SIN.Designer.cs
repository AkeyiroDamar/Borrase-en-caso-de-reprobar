namespace Formulario
{
    partial class frm_EOQ_SIN
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
            this.txt_c = new System.Windows.Forms.TextBox();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.lbl_Kosto = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.lbl_Demanda = new System.Windows.Forms.Label();
            this.lbl_L = new System.Windows.Forms.Label();
            this.txt_L = new System.Windows.Forms.TextBox();
            this.lbl_Q = new System.Windows.Forms.Label();
            this.lbl_t = new System.Windows.Forms.Label();
            this.lbl_TCUQ = new System.Windows.Forms.Label();
            this.lbl_Reorden = new System.Windows.Forms.Label();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.txt_t = new System.Windows.Forms.TextBox();
            this.txt_TCUQ = new System.Windows.Forms.TextBox();
            this.txt_Reorden = new System.Windows.Forms.TextBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(277, 64);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 26);
            this.txt_c.TabIndex = 1;
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Costo.Location = new System.Drawing.Point(153, 67);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(118, 19);
            this.lbl_Costo.TabIndex = 21;
            this.lbl_Costo.Text = "Costo unitario (c):";
            // 
            // txt_h
            // 
            this.txt_h.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_h.Location = new System.Drawing.Point(277, 96);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 26);
            this.txt_h.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Costo de almacenamiento (h):";
            // 
            // txt_k
            // 
            this.txt_k.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_k.Location = new System.Drawing.Point(277, 32);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(100, 26);
            this.txt_k.TabIndex = 0;
            // 
            // lbl_Kosto
            // 
            this.lbl_Kosto.AutoSize = true;
            this.lbl_Kosto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kosto.Location = new System.Drawing.Point(149, 35);
            this.lbl_Kosto.Name = "lbl_Kosto";
            this.lbl_Kosto.Size = new System.Drawing.Size(122, 19);
            this.lbl_Kosto.TabIndex = 25;
            this.lbl_Kosto.Text = "Costo por lote (k):";
            // 
            // txt_d
            // 
            this.txt_d.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_d.Location = new System.Drawing.Point(277, 128);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 26);
            this.txt_d.TabIndex = 3;
            // 
            // lbl_Demanda
            // 
            this.lbl_Demanda.AutoSize = true;
            this.lbl_Demanda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Demanda.Location = new System.Drawing.Point(179, 131);
            this.lbl_Demanda.Name = "lbl_Demanda";
            this.lbl_Demanda.Size = new System.Drawing.Size(92, 19);
            this.lbl_Demanda.TabIndex = 27;
            this.lbl_Demanda.Text = "Demanda (d):";
            // 
            // lbl_L
            // 
            this.lbl_L.AutoSize = true;
            this.lbl_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_L.Location = new System.Drawing.Point(240, 163);
            this.lbl_L.Name = "lbl_L";
            this.lbl_L.Size = new System.Drawing.Size(31, 19);
            this.lbl_L.TabIndex = 29;
            this.lbl_L.Text = "(L):";
            // 
            // txt_L
            // 
            this.txt_L.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L.Location = new System.Drawing.Point(277, 160);
            this.txt_L.Name = "txt_L";
            this.txt_L.Size = new System.Drawing.Size(100, 26);
            this.txt_L.TabIndex = 4;
            // 
            // lbl_Q
            // 
            this.lbl_Q.AutoSize = true;
            this.lbl_Q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Q.Location = new System.Drawing.Point(283, 256);
            this.lbl_Q.Name = "lbl_Q";
            this.lbl_Q.Size = new System.Drawing.Size(42, 19);
            this.lbl_Q.TabIndex = 31;
            this.lbl_Q.Text = "(Q*):";
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t.Location = new System.Drawing.Point(291, 288);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(34, 19);
            this.lbl_t.TabIndex = 32;
            this.lbl_t.Text = "(t*):";
            // 
            // lbl_TCUQ
            // 
            this.lbl_TCUQ.AutoSize = true;
            this.lbl_TCUQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TCUQ.Location = new System.Drawing.Point(242, 320);
            this.lbl_TCUQ.Name = "lbl_TCUQ";
            this.lbl_TCUQ.Size = new System.Drawing.Size(83, 19);
            this.lbl_TCUQ.TabIndex = 33;
            this.lbl_TCUQ.Text = "(TCU(Q*)):";
            // 
            // lbl_Reorden
            // 
            this.lbl_Reorden.AutoSize = true;
            this.lbl_Reorden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reorden.Location = new System.Drawing.Point(261, 352);
            this.lbl_Reorden.Name = "lbl_Reorden";
            this.lbl_Reorden.Size = new System.Drawing.Size(64, 19);
            this.lbl_Reorden.TabIndex = 34;
            this.lbl_Reorden.Text = "Reorden:";
            // 
            // txt_Q
            // 
            this.txt_Q.Enabled = false;
            this.txt_Q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Q.Location = new System.Drawing.Point(331, 253);
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.Size = new System.Drawing.Size(100, 26);
            this.txt_Q.TabIndex = 35;
            // 
            // txt_t
            // 
            this.txt_t.Enabled = false;
            this.txt_t.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_t.Location = new System.Drawing.Point(331, 285);
            this.txt_t.Name = "txt_t";
            this.txt_t.Size = new System.Drawing.Size(100, 26);
            this.txt_t.TabIndex = 36;
            // 
            // txt_TCUQ
            // 
            this.txt_TCUQ.Enabled = false;
            this.txt_TCUQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TCUQ.Location = new System.Drawing.Point(331, 317);
            this.txt_TCUQ.Name = "txt_TCUQ";
            this.txt_TCUQ.Size = new System.Drawing.Size(100, 26);
            this.txt_TCUQ.TabIndex = 37;
            // 
            // txt_Reorden
            // 
            this.txt_Reorden.Enabled = false;
            this.txt_Reorden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reorden.Location = new System.Drawing.Point(331, 349);
            this.txt_Reorden.Name = "txt_Reorden";
            this.txt_Reorden.Size = new System.Drawing.Size(100, 26);
            this.txt_Reorden.TabIndex = 38;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.Location = new System.Drawing.Point(440, 153);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(98, 33);
            this.btn_Borrar.TabIndex = 6;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(440, 114);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(98, 33);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_EOQ_SIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Reorden);
            this.Controls.Add(this.txt_TCUQ);
            this.Controls.Add(this.txt_t);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.lbl_Reorden);
            this.Controls.Add(this.lbl_TCUQ);
            this.Controls.Add(this.lbl_t);
            this.Controls.Add(this.lbl_Q);
            this.Controls.Add(this.txt_L);
            this.Controls.Add(this.lbl_L);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.lbl_Demanda);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.lbl_Kosto);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.lbl_Costo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EOQ_SIN";
            this.Text = "EOQ sin Deficit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label lbl_Costo;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Label lbl_Kosto;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label lbl_Demanda;
        private System.Windows.Forms.Label lbl_L;
        private System.Windows.Forms.TextBox txt_L;
        private System.Windows.Forms.Label lbl_Q;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.Label lbl_TCUQ;
        private System.Windows.Forms.Label lbl_Reorden;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.TextBox txt_t;
        private System.Windows.Forms.TextBox txt_TCUQ;
        private System.Windows.Forms.TextBox txt_Reorden;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Calcular;
    }
}