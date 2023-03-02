namespace WindowsForms
{
    partial class Frm_HelloWorld
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
            Lbl_Titulo = new Label();
            Btn_Sair = new Button();
            SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Lbl_Titulo.Location = new Point(12, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(308, 40);
            Lbl_Titulo.TabIndex = 0;
            Lbl_Titulo.Text = ".NET Windows Forms";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(713, 415);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Sair);
            Controls.Add(Lbl_Titulo);
            Name = "Frm_HelloWorld";
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Titulo;
        private Button Btn_Sair;
    }
}