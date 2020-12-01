namespace RandomPasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.panel_Fill = new System.Windows.Forms.Panel();
            this.txt_TotalCombinations = new System.Windows.Forms.TextBox();
            this.lbl_TotalCombinations = new System.Windows.Forms.Label();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.txt_RandomPassword = new System.Windows.Forms.RichTextBox();
            this.panel_Top.SuspendLayout();
            this.panel_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Title.Location = new System.Drawing.Point(233, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(331, 29);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Random Password Generator";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.AutoSize = true;
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Controls.Add(this.lbl_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(800, 63);
            this.panel_Top.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Close.Location = new System.Drawing.Point(752, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(45, 28);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(274, 271);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(250, 51);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate random password";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // panel_Fill
            // 
            this.panel_Fill.Controls.Add(this.txt_RandomPassword);
            this.panel_Fill.Controls.Add(this.txt_TotalCombinations);
            this.panel_Fill.Controls.Add(this.lbl_TotalCombinations);
            this.panel_Fill.Controls.Add(this.lbl_Subtitle);
            this.panel_Fill.Controls.Add(this.btn_Generate);
            this.panel_Fill.Location = new System.Drawing.Point(0, 63);
            this.panel_Fill.Name = "panel_Fill";
            this.panel_Fill.Size = new System.Drawing.Size(800, 387);
            this.panel_Fill.TabIndex = 1;
            // 
            // txt_TotalCombinations
            // 
            this.txt_TotalCombinations.Location = new System.Drawing.Point(424, 239);
            this.txt_TotalCombinations.Name = "txt_TotalCombinations";
            this.txt_TotalCombinations.Size = new System.Drawing.Size(80, 20);
            this.txt_TotalCombinations.TabIndex = 5;
            this.txt_TotalCombinations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_TotalCombinations
            // 
            this.lbl_TotalCombinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalCombinations.AutoSize = true;
            this.lbl_TotalCombinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_TotalCombinations.Location = new System.Drawing.Point(290, 240);
            this.lbl_TotalCombinations.Name = "lbl_TotalCombinations";
            this.lbl_TotalCombinations.Size = new System.Drawing.Size(131, 17);
            this.lbl_TotalCombinations.TabIndex = 4;
            this.lbl_TotalCombinations.Text = "Total combinations:";
            this.lbl_TotalCombinations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Subtitle.Location = new System.Drawing.Point(301, 30);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(200, 24);
            this.lbl_Subtitle.TabIndex = 3;
            this.lbl_Subtitle.Text = "Your new password is:";
            this.lbl_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_RandomPassword
            // 
            this.txt_RandomPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RandomPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_RandomPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_RandomPassword.Location = new System.Drawing.Point(190, 127);
            this.txt_RandomPassword.Multiline = false;
            this.txt_RandomPassword.Name = "txt_RandomPassword";
            this.txt_RandomPassword.ReadOnly = true;
            this.txt_RandomPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_RandomPassword.Size = new System.Drawing.Size(416, 39);
            this.txt_RandomPassword.TabIndex = 6;
            this.txt_RandomPassword.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Fill);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Fill.ResumeLayout(false);
            this.panel_Fill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Panel panel_Fill;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.TextBox txt_TotalCombinations;
        private System.Windows.Forms.Label lbl_TotalCombinations;
        private System.Windows.Forms.RichTextBox txt_RandomPassword;
    }
}

