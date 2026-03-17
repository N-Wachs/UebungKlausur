namespace WinFormsApp69
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
            button_Bestätigung = new Button();
            textBox_Eingabe = new TextBox();
            label_Begrüßung = new Label();
            SuspendLayout();
            // 
            // button_Bestätigung
            // 
            button_Bestätigung.Font = new Font("Comic Sans MS", 15.75F);
            button_Bestätigung.Location = new Point(474, 152);
            button_Bestätigung.Name = "button_Bestätigung";
            button_Bestätigung.Size = new Size(132, 59);
            button_Bestätigung.TabIndex = 0;
            button_Bestätigung.Text = "Bestätigen";
            button_Bestätigung.UseVisualStyleBackColor = true;
            button_Bestätigung.Click += button_Bestätigung_Click;
            // 
            // textBox_Eingabe
            // 
            textBox_Eingabe.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Eingabe.Location = new Point(102, 164);
            textBox_Eingabe.Name = "textBox_Eingabe";
            textBox_Eingabe.Size = new Size(262, 37);
            textBox_Eingabe.TabIndex = 1;
            // 
            // label_Begrüßung
            // 
            label_Begrüßung.AutoSize = true;
            label_Begrüßung.Font = new Font("Comic Sans MS", 15.75F);
            label_Begrüßung.Location = new Point(262, 59);
            label_Begrüßung.Name = "label_Begrüßung";
            label_Begrüßung.Size = new Size(114, 29);
            label_Begrüßung.TabIndex = 2;
            label_Begrüßung.Text = "Hallo Halil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Begrüßung);
            Controls.Add(textBox_Eingabe);
            Controls.Add(button_Bestätigung);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Bestätigung;
        private TextBox textBox_Eingabe;
        private Label label_Begrüßung;
    }
}
