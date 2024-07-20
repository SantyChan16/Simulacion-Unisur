namespace Simulacion
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
            lbl_title = new Label();
            btn_calculate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 91);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 48);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(72, 28);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(433, 32);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "¿Cuantos lazamientos quieres hacer?";
            // 
            // btn_calculate
            // 
            btn_calculate.BackColor = SystemColors.ButtonHighlight;
            btn_calculate.ForeColor = Color.Black;
            btn_calculate.Location = new Point(204, 169);
            btn_calculate.Margin = new Padding(3, 4, 3, 4);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(153, 67);
            btn_calculate.TabIndex = 3;
            btn_calculate.Text = "Calcular";
            btn_calculate.UseVisualStyleBackColor = false;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 311);
            Controls.Add(btn_calculate);
            Controls.Add(lbl_title);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbl_title;
        private Button btn_calculate;
    }
}
