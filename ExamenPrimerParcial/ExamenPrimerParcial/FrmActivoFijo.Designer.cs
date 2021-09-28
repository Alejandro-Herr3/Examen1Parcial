namespace ExamenPrimerParcial
{
    partial class FrmActivoFijo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoActivo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nudValorResidual = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDepreciacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbTipoDepreciacion);
            this.groupBox1.Controls.Add(this.cmbTipoActivo);
            this.groupBox1.Controls.Add(this.nudValorResidual);
            this.groupBox1.Controls.Add(this.nudValor);
            this.groupBox1.Controls.Add(this.dtpFechaAdquisicion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Activos Fijos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripcion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Adquisicion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Activo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 105);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 79);
            this.txtDescripcion.TabIndex = 1;
            // 
            // dtpFechaAdquisicion
            // 
            this.dtpFechaAdquisicion.Location = new System.Drawing.Point(113, 241);
            this.dtpFechaAdquisicion.Name = "dtpFechaAdquisicion";
            this.dtpFechaAdquisicion.Size = new System.Drawing.Size(280, 20);
            this.dtpFechaAdquisicion.TabIndex = 2;
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(113, 190);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(280, 20);
            this.nudValor.TabIndex = 3;
            // 
            // cmbTipoActivo
            // 
            this.cmbTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoActivo.FormattingEnabled = true;
            this.cmbTipoActivo.Location = new System.Drawing.Point(113, 267);
            this.cmbTipoActivo.Name = "cmbTipoActivo";
            this.cmbTipoActivo.Size = new System.Drawing.Size(280, 21);
            this.cmbTipoActivo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nudValorResidual
            // 
            this.nudValorResidual.DecimalPlaces = 2;
            this.nudValorResidual.Location = new System.Drawing.Point(113, 216);
            this.nudValorResidual.Name = "nudValorResidual";
            this.nudValorResidual.Size = new System.Drawing.Size(280, 20);
            this.nudValorResidual.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor residual:";
            // 
            // cmbTipoDepreciacion
            // 
            this.cmbTipoDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDepreciacion.FormattingEnabled = true;
            this.cmbTipoDepreciacion.Location = new System.Drawing.Point(113, 294);
            this.cmbTipoDepreciacion.Name = "cmbTipoDepreciacion";
            this.cmbTipoDepreciacion.Size = new System.Drawing.Size(280, 21);
            this.cmbTipoDepreciacion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo Depreciacion: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(280, 20);
            this.txtId.TabIndex = 1;
            // 
            // FrmActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 369);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActivoFijo";
            this.Text = "FrmActivoFijo";
            this.Load += new System.EventHandler(this.FrmActivoFijo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTipoActivo;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.DateTimePicker dtpFechaAdquisicion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValorResidual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoDepreciacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
    }
}