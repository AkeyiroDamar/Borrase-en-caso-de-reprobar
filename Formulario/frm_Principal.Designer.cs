namespace Formulario
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_Superior = new System.Windows.Forms.Panel();
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.menu_Botones = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_EOP = new System.Windows.Forms.Button();
            this.btn_EOQ_DESC = new System.Windows.Forms.Button();
            this.btn_EOQ_CON = new System.Windows.Forms.Button();
            this.btn_EOQ_SIN = new System.Windows.Forms.Button();
            this.menu_Cuerpo = new System.Windows.Forms.Panel();
            this.menu_Superior.SuspendLayout();
            this.menu_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Superior
            // 
            this.menu_Superior.BackColor = System.Drawing.Color.Gray;
            this.menu_Superior.Controls.Add(this.lbl_Subtitulo);
            this.menu_Superior.Controls.Add(this.lbl_Titulo);
            this.menu_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Superior.Location = new System.Drawing.Point(0, 0);
            this.menu_Superior.Name = "menu_Superior";
            this.menu_Superior.Size = new System.Drawing.Size(800, 50);
            this.menu_Superior.TabIndex = 1;
            this.menu_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastrar);
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(0, 27);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(800, 23);
            this.lbl_Subtitulo.TabIndex = 1;
            this.lbl_Subtitulo.Text = "\"\"";
            this.lbl_Subtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Subtitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastrar);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(800, 27);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Investigacion de Operaciones";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arrastrar);
            // 
            // menu_Botones
            // 
            this.menu_Botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu_Botones.Controls.Add(this.btn_Salir);
            this.menu_Botones.Controls.Add(this.btn_EOP);
            this.menu_Botones.Controls.Add(this.btn_EOQ_DESC);
            this.menu_Botones.Controls.Add(this.btn_EOQ_CON);
            this.menu_Botones.Controls.Add(this.btn_EOQ_SIN);
            this.menu_Botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_Botones.Location = new System.Drawing.Point(0, 50);
            this.menu_Botones.Name = "menu_Botones";
            this.menu_Botones.Size = new System.Drawing.Size(100, 400);
            this.menu_Botones.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(0, 360);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(100, 40);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_EOP
            // 
            this.btn_EOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_EOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EOP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EOP.Location = new System.Drawing.Point(0, 120);
            this.btn_EOP.Name = "btn_EOP";
            this.btn_EOP.Size = new System.Drawing.Size(100, 40);
            this.btn_EOP.TabIndex = 3;
            this.btn_EOP.Text = "EOP";
            this.btn_EOP.UseVisualStyleBackColor = false;
            this.btn_EOP.Click += new System.EventHandler(this.btn_EOP_Click);
            // 
            // btn_EOQ_DESC
            // 
            this.btn_EOQ_DESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_EOQ_DESC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EOQ_DESC.Enabled = false;
            this.btn_EOQ_DESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EOQ_DESC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EOQ_DESC.Location = new System.Drawing.Point(0, 80);
            this.btn_EOQ_DESC.Name = "btn_EOQ_DESC";
            this.btn_EOQ_DESC.Size = new System.Drawing.Size(100, 40);
            this.btn_EOQ_DESC.TabIndex = 2;
            this.btn_EOQ_DESC.Text = "EOQ Con Descuento";
            this.btn_EOQ_DESC.UseVisualStyleBackColor = false;
            this.btn_EOQ_DESC.Click += new System.EventHandler(this.btn_EOQ_DESC_Click);
            // 
            // btn_EOQ_CON
            // 
            this.btn_EOQ_CON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_EOQ_CON.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EOQ_CON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EOQ_CON.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EOQ_CON.Location = new System.Drawing.Point(0, 40);
            this.btn_EOQ_CON.Name = "btn_EOQ_CON";
            this.btn_EOQ_CON.Size = new System.Drawing.Size(100, 40);
            this.btn_EOQ_CON.TabIndex = 1;
            this.btn_EOQ_CON.Text = "EOQ Con Deficit";
            this.btn_EOQ_CON.UseVisualStyleBackColor = false;
            this.btn_EOQ_CON.Click += new System.EventHandler(this.btn_EOQ_CON_Click);
            // 
            // btn_EOQ_SIN
            // 
            this.btn_EOQ_SIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_EOQ_SIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EOQ_SIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EOQ_SIN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EOQ_SIN.Location = new System.Drawing.Point(0, 0);
            this.btn_EOQ_SIN.Name = "btn_EOQ_SIN";
            this.btn_EOQ_SIN.Size = new System.Drawing.Size(100, 40);
            this.btn_EOQ_SIN.TabIndex = 0;
            this.btn_EOQ_SIN.Text = "EOQ Sin Deficit";
            this.btn_EOQ_SIN.UseVisualStyleBackColor = false;
            this.btn_EOQ_SIN.Click += new System.EventHandler(this.btn_EOQ_SIN_Click);
            // 
            // menu_Cuerpo
            // 
            this.menu_Cuerpo.BackColor = System.Drawing.Color.Silver;
            this.menu_Cuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_Cuerpo.Location = new System.Drawing.Point(100, 50);
            this.menu_Cuerpo.Name = "menu_Cuerpo";
            this.menu_Cuerpo.Size = new System.Drawing.Size(700, 400);
            this.menu_Cuerpo.TabIndex = 2;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu_Cuerpo);
            this.Controls.Add(this.menu_Botones);
            this.Controls.Add(this.menu_Superior);
            this.Name = "frm_Principal";
            this.Text = "Form1";
            this.menu_Superior.ResumeLayout(false);
            this.menu_Botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_Superior;
        private System.Windows.Forms.Panel menu_Botones;
        private System.Windows.Forms.Panel menu_Cuerpo;
        private System.Windows.Forms.Button btn_EOP;
        private System.Windows.Forms.Button btn_EOQ_DESC;
        private System.Windows.Forms.Button btn_EOQ_CON;
        private System.Windows.Forms.Button btn_EOQ_SIN;
        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Salir;
    }
}

