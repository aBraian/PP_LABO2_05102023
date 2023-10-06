namespace Calculadora_Braian_Acosta
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            rdbOctal = new RadioButton();
            lblPrimerOperando = new Label();
            lblOperacion = new Label();
            lblSegundoOperando = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema = new GroupBox();
            lblHistorial = new Label();
            lstHistorial = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(38, 50);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(132, 27);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(6, 46);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(117, 31);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(139, 46);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(117, 31);
            rdbDecimal.TabIndex = 2;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // rdbOctal
            // 
            rdbOctal.AutoSize = true;
            rdbOctal.Location = new Point(280, 46);
            rdbOctal.Name = "rdbOctal";
            rdbOctal.Size = new Size(93, 31);
            rdbOctal.TabIndex = 3;
            rdbOctal.TabStop = true;
            rdbOctal.Text = "Octal";
            rdbOctal.UseVisualStyleBackColor = true;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Location = new Point(38, 326);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(204, 27);
            lblPrimerOperando.TabIndex = 4;
            lblPrimerOperando.Text = "Primer operando:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(280, 326);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(132, 27);
            lblOperacion.TabIndex = 5;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Location = new Point(480, 326);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(216, 27);
            lblSegundoOperando.TabIndex = 6;
            lblSegundoOperando.Text = "Segundo operando:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(38, 385);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(204, 31);
            txtPrimerOperando.TabIndex = 7;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(480, 385);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(204, 31);
            txtSegundoOperando.TabIndex = 8;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(280, 381);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(151, 35);
            cmbOperacion.TabIndex = 9;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(81, 450);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(150, 50);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(278, 450);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 50);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(478, 450);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 50);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbOctal);
            grpSistema.Location = new Point(193, 137);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(400, 100);
            grpSistema.TabIndex = 13;
            grpSistema.TabStop = false;
            grpSistema.Text = "Operar en:";
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(829, 50);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(120, 27);
            lblHistorial.TabIndex = 14;
            lblHistorial.Text = "Historial";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 27;
            lstHistorial.Location = new Point(725, 118);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(308, 382);
            lstHistorial.TabIndex = 15;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 553);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Braian Acosta";
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private RadioButton rdbOctal;
        private Label lblPrimerOperando;
        private Label lblOperacion;
        private Label lblSegundoOperando;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private GroupBox grpSistema;
        private Label lblHistorial;
        private ListBox lstHistorial;
    }
}