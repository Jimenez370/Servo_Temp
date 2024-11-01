namespace Servo_Temp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.lbConection = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.lbTemp = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite de temperatura";
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(100, 117);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(113, 22);
            this.tbLimTemp.TabIndex = 1;
            // 
            // lbConection
            // 
            this.lbConection.AutoSize = true;
            this.lbConection.Location = new System.Drawing.Point(121, 283);
            this.lbConection.Name = "lbConection";
            this.lbConection.Size = new System.Drawing.Size(83, 16);
            this.lbConection.TabIndex = 2;
            this.lbConection.Text = "Sin conexion";
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConectar.Location = new System.Drawing.Point(78, 321);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(135, 66);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(364, 321);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(152, 66);
            this.btndesconectar.TabIndex = 5;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(417, 123);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(14, 16);
            this.lbTemp.TabIndex = 6;
            this.lbTemp.Text = "0";
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(392, 84);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(85, 16);
            this.Temperatura.TabIndex = 7;
            this.Temperatura.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lbConection);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Label lbConection;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label Temperatura;
    }
}

