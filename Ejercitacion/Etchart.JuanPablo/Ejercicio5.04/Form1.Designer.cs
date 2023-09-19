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
            inputInt = new TextBox();
            gbListaNumeros = new GroupBox();
            listBox = new ListBox();
            bgOrden = new GroupBox();
            btnOrdenar = new Button();
            rbtnDescendente = new RadioButton();
            rbtnAscender = new RadioButton();
            button1 = new Button();
            gbInput.SuspendLayout();
            gbListaNumeros.SuspendLayout();
            bgOrden.SuspendLayout();
            SuspendLayout();
            // 
            // gbInput
            // 
            gbInput.Controls.Add(btnAgregar);
            gbInput.Controls.Add(inputInt);
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
            // inputInt
            // 
            inputInt.Location = new Point(24, 54);
            inputInt.Name = "inputInt";
            inputInt.Size = new Size(153, 23);
            inputInt.TabIndex = 0;
            // 
            // gbListaNumeros
            // 
            gbListaNumeros.Controls.Add(listBox);
            gbListaNumeros.Location = new Point(400, 137);
            gbListaNumeros.Name = "gbListaNumeros";
            gbListaNumeros.Size = new Size(232, 318);
            gbListaNumeros.TabIndex = 1;
            gbListaNumeros.TabStop = false;
            gbListaNumeros.Text = "Lista de números";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(34, 41);
            listBox.Name = "listBox";
            listBox.Size = new Size(167, 244);
            listBox.TabIndex = 0;
            // 
            // bgOrden
            // 
            bgOrden.Controls.Add(btnOrdenar);
            bgOrden.Controls.Add(rbtnDescendente);
            bgOrden.Controls.Add(rbtnAscender);
            bgOrden.Location = new Point(43, 300);
            bgOrden.Name = "bgOrden";
            bgOrden.Size = new Size(322, 155);
            bgOrden.TabIndex = 2;
            bgOrden.TabStop = false;
            bgOrden.Text = "Orden";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(220, 76);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
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
            // button1
            // 
            button1.Location = new Point(67, 479);
            button1.Name = "button1";
            button1.Size = new Size(271, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 571);
            Controls.Add(button1);
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
        private TextBox inputInt;
        private ListBox listBox;
        private Button btnOrdenar;
        private RadioButton rbtnDescendente;
        private RadioButton rbtnAscender;
        private Button button1;
    }
}