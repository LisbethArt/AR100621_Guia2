namespace G2_Ejercicio_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncender
            // 
            resources.ApplyResources(this.btnEncender, "btnEncender");
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApagar
            // 
            resources.ApplyResources(this.btnApagar, "btnApagar");
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnLlamar
            // 
            resources.ApplyResources(this.btnLlamar, "btnLlamar");
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnEnviarMensaje
            // 
            resources.ApplyResources(this.btnEnviarMensaje, "btnEnviarMensaje");
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // txtMensaje
            // 
            resources.ApplyResources(this.txtMensaje, "txtMensaje");
            this.txtMensaje.Name = "txtMensaje";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

