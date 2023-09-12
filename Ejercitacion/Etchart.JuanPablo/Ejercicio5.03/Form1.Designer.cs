namespace Ejercicio5._03
{
    partial class Form1
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
            Informacion = new GroupBox();
            total = new Label();
            descuento = new Label();
            importe = new Label();
            inputImporte = new TextBox();
            inputTotal = new TextBox();
            inputDescuento = new TextBox();
            btnLimpiar = new Button();
            btnAceptar = new Button();
            Informacion.SuspendLayout();
            SuspendLayout();
            // 
            // Informacion
            // 
            Informacion.Controls.Add(total);
            Informacion.Controls.Add(descuento);
            Informacion.Controls.Add(importe);
            Informacion.Controls.Add(inputImporte);
            Informacion.Controls.Add(inputTotal);
            Informacion.Controls.Add(inputDescuento);
            Informacion.Controls.Add(btnLimpiar);
            Informacion.Controls.Add(btnAceptar);
            Informacion.Location = new Point(133, 118);
            Informacion.Name = "Informacion";
            Informacion.Size = new Size(435, 348);
            Informacion.TabIndex = 0;
            Informacion.TabStop = false;
            Informacion.Text = "Información";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(133, 213);
            total.Name = "total";
            total.Size = new Size(80, 15);
            total.TabIndex = 7;
            total.Text = "Total a pagar:";
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Location = new Point(119, 143);
            descuento.Name = "descuento";
            descuento.Size = new Size(109, 15);
            descuento.TabIndex = 6;
            descuento.Text = "Descuento recibido";
            // 
            // importe
            // 
            importe.AutoSize = true;
            importe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            importe.Location = new Point(38, 68);
            importe.Name = "importe";
            importe.Size = new Size(220, 21);
            importe.TabIndex = 5;
            importe.Text = "Ingrese el importe a cobrar:";
            // 
            // inputImporte
            // 
            inputImporte.Location = new Point(295, 70);
            inputImporte.Name = "inputImporte";
            inputImporte.Size = new Size(100, 23);
            inputImporte.TabIndex = 4;
            // 
            // inputTotal
            // 
            inputTotal.Location = new Point(312, 205);
            inputTotal.Name = "inputTotal";
            inputTotal.ReadOnly = true;
            inputTotal.Size = new Size(100, 23);
            inputTotal.TabIndex = 3;
            // 
            // inputDescuento
            // 
            inputDescuento.Location = new Point(312, 135);
            inputDescuento.Name = "inputDescuento";
            inputDescuento.ReadOnly = true;
            inputDescuento.Size = new Size(100, 23);
            inputDescuento.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(295, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(53, 262);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(91, 32);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 563);
            Controls.Add(Informacion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Informacion.ResumeLayout(false);
            Informacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Informacion;
        private Label total;
        private Label descuento;
        private Label importe;
        private TextBox inputImporte;
        private TextBox inputTotal;
        private TextBox inputDescuento;
        private Button btnLimpiar;
        private Button btnAceptar;
    }
}