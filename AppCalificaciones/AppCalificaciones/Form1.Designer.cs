namespace AppCalificaciones
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(250, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(250, 122);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(85, 16);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(250, 160);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(75, 16);
            this.lblN1.TabIndex = 2;
            this.lblN1.Text = "Primer nota";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(250, 389);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(69, 16);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Resultado";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(251, 279);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(75, 16);
            this.lblN4.TabIndex = 4;
            this.lblN4.Text = "Cuarta nota";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(250, 242);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(76, 16);
            this.lblN3.TabIndex = 5;
            this.lblN3.Text = "Tercer nota";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(250, 201);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(91, 16);
            this.lblN2.TabIndex = 6;
            this.lblN2.Text = "Segunda nota";
            this.lblN2.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(374, 327);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 31);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPromedio.Location = new System.Drawing.Point(374, 383);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(112, 22);
            this.txtPromedio.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(374, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(374, 122);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(112, 22);
            this.txtIdentificacion.TabIndex = 10;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(374, 160);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(112, 22);
            this.txtN1.TabIndex = 11;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(374, 201);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(112, 22);
            this.txtN2.TabIndex = 12;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(374, 242);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(112, 22);
            this.txtN3.TabIndex = 13;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(374, 279);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(112, 22);
            this.txtN4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
    }
}

