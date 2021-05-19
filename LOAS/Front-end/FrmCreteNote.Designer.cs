
namespace Front_end
{
    partial class FrmCreteNote
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
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.Lb_Receptor = new System.Windows.Forms.Label();
            this.Lb_Emisor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rTextMensaje = new System.Windows.Forms.RichTextBox();
            this.Lb_Mensaje = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.Lb_Despedida = new System.Windows.Forms.Label();
            this.cmbExpediente = new System.Windows.Forms.ComboBox();
            this.Lb_ = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReceptor
            // 
            this.txtReceptor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtReceptor.Location = new System.Drawing.Point(125, 56);
            this.txtReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(368, 20);
            this.txtReceptor.TabIndex = 2;
            // 
            // txtEmisor
            // 
            this.txtEmisor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEmisor.Location = new System.Drawing.Point(125, 28);
            this.txtEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(368, 20);
            this.txtEmisor.TabIndex = 1;
            // 
            // Lb_Receptor
            // 
            this.Lb_Receptor.AutoSize = true;
            this.Lb_Receptor.Enabled = false;
            this.Lb_Receptor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Receptor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Receptor.Location = new System.Drawing.Point(24, 59);
            this.Lb_Receptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Receptor.Name = "Lb_Receptor";
            this.Lb_Receptor.Size = new System.Drawing.Size(67, 17);
            this.Lb_Receptor.TabIndex = 7;
            this.Lb_Receptor.Text = "Receptor";
            // 
            // Lb_Emisor
            // 
            this.Lb_Emisor.AutoSize = true;
            this.Lb_Emisor.Enabled = false;
            this.Lb_Emisor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Emisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Emisor.Location = new System.Drawing.Point(24, 28);
            this.Lb_Emisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Emisor.Name = "Lb_Emisor";
            this.Lb_Emisor.Size = new System.Drawing.Size(49, 17);
            this.Lb_Emisor.TabIndex = 6;
            this.Lb_Emisor.Text = "Emisor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(59, 457);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(226, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rTextMensaje
            // 
            this.rTextMensaje.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rTextMensaje.Location = new System.Drawing.Point(59, 153);
            this.rTextMensaje.Name = "rTextMensaje";
            this.rTextMensaje.Size = new System.Drawing.Size(669, 169);
            this.rTextMensaje.TabIndex = 3;
            this.rTextMensaje.Text = "";
            // 
            // Lb_Mensaje
            // 
            this.Lb_Mensaje.AutoSize = true;
            this.Lb_Mensaje.Enabled = false;
            this.Lb_Mensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Mensaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Mensaje.Location = new System.Drawing.Point(72, 124);
            this.Lb_Mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Mensaje.Name = "Lb_Mensaje";
            this.Lb_Mensaje.Size = new System.Drawing.Size(60, 17);
            this.Lb_Mensaje.TabIndex = 8;
            this.Lb_Mensaje.Text = "Mensaje";
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(497, 457);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(231, 43);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Sin otro particular, saludo a ud. Atentamente.-",
            "Sin mas que agregar, Saludos a ud. Atemtamente.-"});
            this.cmbTipo.Location = new System.Drawing.Point(337, 366);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(368, 21);
            this.cmbTipo.TabIndex = 36;
            // 
            // Lb_Despedida
            // 
            this.Lb_Despedida.AutoSize = true;
            this.Lb_Despedida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Despedida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_Despedida.Location = new System.Drawing.Point(250, 369);
            this.Lb_Despedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Despedida.Name = "Lb_Despedida";
            this.Lb_Despedida.Size = new System.Drawing.Size(78, 17);
            this.Lb_Despedida.TabIndex = 35;
            this.Lb_Despedida.Text = "Despedida";
            // 
            // cmbExpediente
            // 
            this.cmbExpediente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cmbExpediente.FormattingEnabled = true;
            this.cmbExpediente.Items.AddRange(new object[] {
            "Sin otro particular, saludo a ud. Atentamente.-",
            "Sin mas que agregar, Saludos a ud. Atemtamente.-"});
            this.cmbExpediente.Location = new System.Drawing.Point(562, 49);
            this.cmbExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbExpediente.Name = "cmbExpediente";
            this.cmbExpediente.Size = new System.Drawing.Size(162, 21);
            this.cmbExpediente.TabIndex = 38;
            // 
            // Lb_
            // 
            this.Lb_.AutoSize = true;
            this.Lb_.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_.Location = new System.Drawing.Point(570, 28);
            this.Lb_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_.Name = "Lb_";
            this.Lb_.Size = new System.Drawing.Size(135, 17);
            this.Lb_.TabIndex = 37;
            this.Lb_.Text = "Numero Expediente";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtReferencia.Location = new System.Drawing.Point(125, 84);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(368, 20);
            this.txtReferencia.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ref.:";
            // 
            // FrmCreteNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbExpediente);
            this.Controls.Add(this.Lb_);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.Lb_Despedida);
            this.Controls.Add(this.Lb_Mensaje);
            this.Controls.Add(this.rTextMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.Lb_Receptor);
            this.Controls.Add(this.Lb_Emisor);
            this.Name = "FrmCreteNote";
            this.Text = "Crear Nueva Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceptor;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.Label Lb_Receptor;
        private System.Windows.Forms.Label Lb_Emisor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox rTextMensaje;
        private System.Windows.Forms.Label Lb_Mensaje;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label Lb_Despedida;
        private System.Windows.Forms.ComboBox cmbExpediente;
        private System.Windows.Forms.Label Lb_;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label2;
    }
}