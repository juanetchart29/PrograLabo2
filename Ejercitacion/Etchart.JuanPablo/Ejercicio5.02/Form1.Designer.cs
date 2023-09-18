namespace Ejercicio5._02
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
            textBox1 = new TextBox();
            lblNumero = new Label();
            lstTabla = new ListBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 23);
            textBox1.TabIndex = 0;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(68, 82);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(114, 21);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Ingrese un número: ";
            lblNumero.UseCompatibleTextRendering = true;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(50, 124);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(258, 244);
            lstTabla.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(131, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lstTabla);
            Controls.Add(lblNumero);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyPress += ApretarEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblNumero;
        private ListBox lstTabla;
        private Button btnLimpiar;
    }
}