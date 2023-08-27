namespace Superman
{
	// Token: 0x0200001B RID: 27
	public partial class LoginForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x000099E8 File Offset: 0x00007BE8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009A18 File Offset: 0x00007C18
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Elipse_0 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl_0 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.license = new Guna.UI2.WinForms.Guna2TextBox();
            this.LOGINBUTTON = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2Elipse_0
            // 
            this.guna2Elipse_0.TargetControl = this;
            // 
            // guna2DragControl_0
            // 
            this.guna2DragControl_0.TargetControl = this;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderColor = System.Drawing.Color.Transparent;
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Exit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.IconColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(267, 22);
            this.Exit.Name = "Exit";
            this.Exit.PressedColor = System.Drawing.Color.Transparent;
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(17, 16);
            this.Exit.TabIndex = 32;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // license
            // 
            this.license.Animated = true;
            this.license.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.license.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.license.DefaultText = "";
            this.license.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.license.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.license.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.license.DisabledState.Parent = this.license;
            this.license.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.license.FillColor = System.Drawing.Color.Black;
            this.license.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.license.FocusedState.Parent = this.license;
            this.license.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.license.HoverState.Parent = this.license;
            this.license.Location = new System.Drawing.Point(51, 247);
            this.license.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.license.Name = "license";
            this.license.PasswordChar = '\0';
            this.license.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.license.PlaceholderText = "PASTE YOUR KEY HERE";
            this.license.SelectedText = "";
            this.license.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.license.ShadowDecoration.Parent = this.license;
            this.license.Size = new System.Drawing.Size(201, 15);
            this.license.TabIndex = 35;
            this.license.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LOGINBUTTON
            // 
            this.LOGINBUTTON.BackColor = System.Drawing.Color.Transparent;
            this.LOGINBUTTON.CheckedState.Parent = this.LOGINBUTTON;
            this.LOGINBUTTON.CustomImages.Parent = this.LOGINBUTTON;
            this.LOGINBUTTON.FillColor = System.Drawing.Color.Transparent;
            this.LOGINBUTTON.FillColor2 = System.Drawing.Color.Transparent;
            this.LOGINBUTTON.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LOGINBUTTON.ForeColor = System.Drawing.Color.Transparent;
            this.LOGINBUTTON.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGINBUTTON.HoverState.Parent = this.LOGINBUTTON;
            this.LOGINBUTTON.Location = new System.Drawing.Point(84, 283);
            this.LOGINBUTTON.Name = "LOGINBUTTON";
            this.LOGINBUTTON.ShadowDecoration.Parent = this.LOGINBUTTON;
            this.LOGINBUTTON.Size = new System.Drawing.Size(124, 24);
            this.LOGINBUTTON.TabIndex = 38;
            this.LOGINBUTTON.Text = "LOGINBYPASS";
            this.LOGINBUTTON.Click += new System.EventHandler(this.LOGINBUTTON_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Location = new System.Drawing.Point(267, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(17, 16);
            this.guna2ControlBox1.TabIndex = 39;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 470);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.LOGINBUTTON);
            this.Controls.Add(this.license);
            this.Controls.Add(this.Exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

		}

		// Token: 0x040000DC RID: 220
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x040000DD RID: 221
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse_0;

		// Token: 0x040000DE RID: 222
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl_0;

		// Token: 0x040000DF RID: 223
		private global::Guna.UI2.WinForms.Guna2ControlBox Exit;

		// Token: 0x040000E0 RID: 224
		private global::Guna.UI2.WinForms.Guna2TextBox license;

		// Token: 0x040000E1 RID: 225
		private global::Guna.UI2.WinForms.Guna2GradientTileButton LOGINBUTTON;

		// Token: 0x040000E2 RID: 226
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.ComponentModel.IContainer components;
    }
}
