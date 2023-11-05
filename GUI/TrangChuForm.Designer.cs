namespace GUI
{
    partial class TrangChuForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(0, 79, 111);
            guna2Panel1.Controls.Add(guna2Panel2);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(219, 861);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.Controls.Add(iconButton1);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Dock = DockStyle.Top;
            guna2Panel2.Location = new Point(0, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(219, 100);
            guna2Panel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(166, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 50);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(iconButton3);
            guna2Panel3.Controls.Add(iconButton2);
            guna2Panel3.CustomizableEdges = customizableEdges5;
            guna2Panel3.Dock = DockStyle.Top;
            guna2Panel3.Location = new Point(219, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel3.Size = new Size(1205, 25);
            guna2Panel3.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(13, 184, 217);
            iconButton3.Dock = DockStyle.Right;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.Location = new Point(1115, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(45, 25);
            iconButton3.TabIndex = 8;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += MinimizeButton_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(255, 94, 132);
            iconButton2.Dock = DockStyle.Right;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.Location = new Point(1160, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(45, 25);
            iconButton2.TabIndex = 7;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += CloseButton_Click;
            // 
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1424, 861);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "TrangChuForm";
            Text = "TrangChuForm";
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}