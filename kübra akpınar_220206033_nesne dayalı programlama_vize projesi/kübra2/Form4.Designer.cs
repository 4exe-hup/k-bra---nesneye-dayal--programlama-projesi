namespace kübra2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 0;
            label1.Text = "SİZİN İÇİN HAZIR";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 132);
            button1.Name = "button1";
            button1.Size = new Size(250, 150);
            button1.TabIndex = 1;
            button1.Text = "SU MİKTARI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(268, 132);
            button2.Name = "button2";
            button2.Size = new Size(250, 150);
            button2.TabIndex = 2;
            button2.Text = "KALORİ MIKTARI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(524, 132);
            button3.Name = "button3";
            button3.Size = new Size(250, 150);
            button3.TabIndex = 3;
            button3.Text = "KİLO İLE BOY UYUMU";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 288);
            button4.Name = "button4";
            button4.Size = new Size(250, 150);
            button4.TabIndex = 4;
            button4.Text = "ÖĞÜNLER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(268, 288);
            button5.Name = "button5";
            button5.Size = new Size(250, 150);
            button5.TabIndex = 5;
            button5.Text = "DİYET";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(524, 288);
            button6.Name = "button6";
            button6.Size = new Size(250, 150);
            button6.TabIndex = 6;
            button6.Text = "SPOR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}