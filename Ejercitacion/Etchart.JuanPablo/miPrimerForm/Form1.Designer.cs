namespace miPrimerForm
{
    partial class Button_HI
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
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Yu Gothic UI Light", 12F, FontStyle.Bold, GraphicsUnit.World);
            btnSaludar.Location = new Point(566, 290);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(110, 46);
            btnSaludar.TabIndex = 0;
            btnSaludar.Text = "Saludar ";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += button1_Click;
            // 
            // Button_HI
            // 
            AcceptButton = btnSaludar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 626);
            Controls.Add(btnSaludar);
            Name = "Button_HI";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaludar;

    }
}