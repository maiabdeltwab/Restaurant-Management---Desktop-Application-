
namespace Restaurant_Management.View
{
    partial class PullAmountForm
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
            this.PullBtn = new Guna.UI.WinForms.GunaButton();
            this.AmountLbl = new Guna.UI.WinForms.GunaLabel();
            this.AmountText = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // PullBtn
            // 
            this.PullBtn.Animated = true;
            this.PullBtn.AnimationHoverSpeed = 0.07F;
            this.PullBtn.AnimationSpeed = 0.03F;
            this.PullBtn.BackColor = System.Drawing.Color.Transparent;
            this.PullBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.PullBtn.BorderColor = System.Drawing.Color.Black;
            this.PullBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PullBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PullBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullBtn.ForeColor = System.Drawing.Color.White;
            this.PullBtn.Image = null;
            this.PullBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PullBtn.Location = new System.Drawing.Point(401, 135);
            this.PullBtn.Name = "PullBtn";
            this.PullBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.PullBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PullBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PullBtn.OnHoverImage = null;
            this.PullBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PullBtn.Radius = 2;
            this.PullBtn.Size = new System.Drawing.Size(135, 44);
            this.PullBtn.TabIndex = 21;
            this.PullBtn.Text = "Pull";
            this.PullBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PullBtn.Click += new System.EventHandler(this.PullBtn_Click);
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AmountLbl.Location = new System.Drawing.Point(63, 48);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(57, 23);
            this.AmountLbl.TabIndex = 23;
            this.AmountLbl.Text = "Count";
            // 
            // AmountText
            // 
            this.AmountText.BaseColor = System.Drawing.Color.White;
            this.AmountText.BorderColor = System.Drawing.Color.Silver;
            this.AmountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountText.FocusedBaseColor = System.Drawing.Color.White;
            this.AmountText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.AmountText.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(47)))));
            this.AmountText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AmountText.ForeColor = System.Drawing.Color.Black;
            this.AmountText.Location = new System.Drawing.Point(66, 75);
            this.AmountText.Name = "AmountText";
            this.AmountText.PasswordChar = '\0';
            this.AmountText.SelectedText = "";
            this.AmountText.Size = new System.Drawing.Size(470, 41);
            this.AmountText.TabIndex = 22;
            this.AmountText.TextChanged += new System.EventHandler(this.CurrentAmountText_TextChanged);
            // 
            // PullAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(610, 237);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.PullBtn);
            this.Name = "PullAmountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pull Amount";
            this.Load += new System.EventHandler(this.PullAmountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton PullBtn;
        private Guna.UI.WinForms.GunaLabel AmountLbl;
        private Guna.UI.WinForms.GunaTextBox AmountText;
    }
}