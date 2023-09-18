namespace Ejercicio5._04
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
            gbInput = new GroupBox();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            gbListaNumeros = new GroupBox();
            lboxLista = new ListBox();
            bgOrden = new GroupBox();
            button1 = new Button();
            rbtnDescendente = new RadioButton();
            rbtnAscender = new RadioButton();
            gbInput.SuspendLayout();
            gbListaNumeros.SuspendLayout();
            bgOrden.SuspendLayout();
            SuspendLayout();
            // 
            // gbInput
            // 
            gbInput.Controls.Add(btnAgregar);
            gbInput.Controls.Add(textBox1);
            gbInput.Location = new Point(43, 137);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(322, 144);
            gbInput.TabIndex = 0;
            gbInput.TabStop = false;
            gbInput.Text = "Ingrese un nuevo número";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(220, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 0;
            // 
            // gbListaNumeros
            // 
            gbListaNumeros.Controls.Add(lboxLista);
            gbListaNumeros.Location = new Point(400, 137);
            gbListaNumeros.Name = "gbListaNumeros";
            gbListaNumeros.Size = new Size(232, 318);
            gbListaNumeros.TabIndex = 1;
            gbListaNumeros.TabStop = false;
            gbListaNumeros.Text = "Lista de números";
            // 
            // lboxLista
            // 
            lboxLista.FormattingEnabled = true;
            lboxLista.ItemHeight = 15;
            lboxLista.Location = new Point(34, 41);
            lboxLista.Name = "lboxLista";
            lboxLista.Size = new Size(167, 244);
            lboxLista.TabIndex = 0;
            // 
            // bgOrden
            // 
            bgOrden.Controls.Add(button1);
            bgOrden.Controls.Add(rbtnDescendente);
            bgOrden.Controls.Add(rbtnAscender);
            bgOrden.Location = new Point(43, 300);
            bgOrden.Name = "bgOrden";
            bgOrden.Size = new Size(322, 155);
            bgOrden.TabIndex = 2;
            bgOrden.TabStop = false;
            bgOrden.Text = "Orden";
            // 
            // button1
            // 
            button1.Location = new Point(220, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // rbtnDescendente
            // 
            rbtnDescendente.AutoSize = true;
            rbtnDescendente.Location = new Point(60, 103);
            rbtnDescendente.Name = "rbtnDescendente";
            rbtnDescendente.Size = new Size(93, 19);
            rbtnDescendente.TabIndex = 1;
            rbtnDescendente.TabStop = true;
            rbtnDescendente.Text = "Descendente";
            rbtnDescendente.TextAlign = ContentAlignment.TopRight;
            rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscender
            // 
            rbtnAscender.AutoSize = true;
            rbtnAscender.Location = new Point(60, 55);
            rbtnAscender.Name = "rbtnAscender";
            rbtnAscender.Size = new Size(87, 19);
            rbtnAscender.TabIndex = 0;
            rbtnAscender.TabStop = true;
            rbtnAscender.Text = "Ascendente";
            rbtnAscender.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 571);
            Controls.Add(bgOrden);
            Controls.Add(gbListaNumeros);
            Controls.Add(gbInput);
            Name = "Form1";
            Text = "Form1";
            gbInput.ResumeLayout(false);
            gbInput.PerformLayout();
            gbListaNumeros.ResumeLayout(false);
            bgOrden.ResumeLayout(false);
            bgOrden.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInput;
        private GroupBox gbListaNumeros;
        private GroupBox bgOrden;
        private Button btnAgregar;
        private TextBox textBox1;
        private ListBox lboxLista;
        private Button button1;
        private RadioButton rbtnDescendente;
        private RadioButton rbtnAscender;
    }
}