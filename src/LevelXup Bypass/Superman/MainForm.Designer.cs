using System;
namespace Superman
{
	// Token: 0x02000011 RID: 17
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000619C File Offset: 0x0000439C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000061CC File Offset: 0x000043CC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Elipse_0 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl_0 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Minimized = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.LOOPCH = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.DEVICEID = new Guna.UI2.WinForms.Guna2CheckBox();
            this.status = new System.Windows.Forms.Label();
            this.IPADVIEW = new Guna.UI2.WinForms.Guna2CheckBox();
            this.RECOIL = new Guna.UI2.WinForms.Guna2CheckBox();
            this.LOOPEX = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ProcID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.HEADSHOT = new Guna.UI2.WinForms.Guna2CheckBox();
            this.VisibibleCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GAGA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Musicon = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.MusicOff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Expire = new System.Windows.Forms.Label();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1.SuspendLayout();
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
            // Minimized
            // 
            this.Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimized.Animated = true;
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            this.Minimized.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimized.FillColor = System.Drawing.Color.Transparent;
            this.Minimized.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Minimized.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Minimized.HoverState.Parent = this.Minimized;
            this.Minimized.IconColor = System.Drawing.Color.Transparent;
            this.Minimized.Location = new System.Drawing.Point(378, 42);
            this.Minimized.Name = "Minimized";
            this.Minimized.PressedColor = System.Drawing.Color.Transparent;
            this.Minimized.ShadowDecoration.Parent = this.Minimized;
            this.Minimized.Size = new System.Drawing.Size(17, 13);
            this.Minimized.TabIndex = 22;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(86, 443);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(218, 48);
            this.guna2GradientTileButton1.TabIndex = 29;
            this.guna2GradientTileButton1.Text = "START BYPASS";
            //this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // LOOPCH
            // 
            this.LOOPCH.Animated = true;
            this.LOOPCH.AutoSize = true;
            this.LOOPCH.BackColor = System.Drawing.Color.Transparent;
            this.LOOPCH.CheckedState.BorderThickness = 0;
            this.LOOPCH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LOOPCH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LOOPCH.CheckedState.InnerOffset = -7;
            this.LOOPCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOOPCH.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOOPCH.ForeColor = System.Drawing.Color.Silver;
            this.LOOPCH.Location = new System.Drawing.Point(380, 95);
            this.LOOPCH.Name = "LOOPCH";
            this.LOOPCH.Size = new System.Drawing.Size(107, 20);
            this.LOOPCH.TabIndex = 42;
            this.LOOPCH.Text = "LOOP 7.1{Ch}";
            this.LOOPCH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LOOPCH.UncheckedState.BorderThickness = 2;
            this.LOOPCH.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LOOPCH.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LOOPCH.UseVisualStyleBackColor = false;
            this.LOOPCH.Visible = false;
            this.LOOPCH.CheckedChanged += new System.EventHandler(this.LOOPCH_CheckedChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Animated = true;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderColor = System.Drawing.Color.Red;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FillColor = System.Drawing.Color.Black;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox1.FocusedState.ForeColor = System.Drawing.Color.Yellow;
            this.ComboBox1.FocusedState.Parent = this.ComboBox1;
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ComboBox1.HoverState.Parent = this.ComboBox1;
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Items.AddRange(new object[] {
            "GLOBAL",
            "KOREA",
            "TAIWAN",
            "VIETNAM",
            "INDIA"});
            this.ComboBox1.ItemsAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.ItemsAppearance.ForeColor = System.Drawing.Color.Silver;
            this.ComboBox1.ItemsAppearance.Parent = this.ComboBox1;
            this.ComboBox1.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComboBox1.Location = new System.Drawing.Point(112, 325);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.ShadowDecoration.BorderRadius = 20;
            this.ComboBox1.ShadowDecoration.Depth = 6;
            this.ComboBox1.ShadowDecoration.Parent = this.ComboBox1;
            this.ComboBox1.Size = new System.Drawing.Size(157, 36);
            this.ComboBox1.TabIndex = 43;
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.CheckedState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.CustomImages.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton2.HoverState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(78, 514);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.ShadowDecoration.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(226, 45);
            this.guna2GradientTileButton2.TabIndex = 44;
            this.guna2GradientTileButton2.Text = "SAFE EXIT";
            this.guna2GradientTileButton2.Click += new System.EventHandler(this.guna2GradientTileButton2_Click);
            // 
            // DEVICEID
            // 
            this.DEVICEID.Animated = true;
            this.DEVICEID.AutoSize = true;
            this.DEVICEID.BackColor = System.Drawing.Color.Transparent;
            this.DEVICEID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DEVICEID.CheckedState.BorderRadius = 2;
            this.DEVICEID.CheckedState.BorderThickness = 0;
            this.DEVICEID.CheckedState.FillColor = System.Drawing.Color.Red;
            this.DEVICEID.FlatAppearance.BorderSize = 0;
            this.DEVICEID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DEVICEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEVICEID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DEVICEID.Location = new System.Drawing.Point(198, 399);
            this.DEVICEID.Name = "DEVICEID";
            this.DEVICEID.Size = new System.Drawing.Size(13, 12);
            this.DEVICEID.TabIndex = 45;
            this.DEVICEID.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.DEVICEID.UncheckedState.BorderRadius = 2;
            this.DEVICEID.UncheckedState.BorderThickness = 1;
            this.DEVICEID.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.DEVICEID.UseVisualStyleBackColor = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Silver;
            this.status.Location = new System.Drawing.Point(118, 38);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(151, 16);
            this.status.TabIndex = 47;
            this.status.Text = "Welcome LevelXup Bypass";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // IPADVIEW
            // 
            this.IPADVIEW.Animated = true;
            this.IPADVIEW.AutoSize = true;
            this.IPADVIEW.BackColor = System.Drawing.Color.Transparent;
            this.IPADVIEW.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IPADVIEW.CheckedState.BorderRadius = 2;
            this.IPADVIEW.CheckedState.BorderThickness = 0;
            this.IPADVIEW.CheckedState.FillColor = System.Drawing.Color.Red;
            this.IPADVIEW.FlatAppearance.BorderSize = 0;
            this.IPADVIEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPADVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPADVIEW.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IPADVIEW.Location = new System.Drawing.Point(118, 399);
            this.IPADVIEW.Name = "IPADVIEW";
            this.IPADVIEW.Size = new System.Drawing.Size(13, 12);
            this.IPADVIEW.TabIndex = 48;
            this.IPADVIEW.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.IPADVIEW.UncheckedState.BorderRadius = 2;
            this.IPADVIEW.UncheckedState.BorderThickness = 1;
            this.IPADVIEW.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.IPADVIEW.UseVisualStyleBackColor = false;
            this.IPADVIEW.CheckedChanged += new System.EventHandler(this.IPADVIEW_CheckedChanged);
            // 
            // RECOIL
            // 
            this.RECOIL.Animated = true;
            this.RECOIL.AutoSize = true;
            this.RECOIL.BackColor = System.Drawing.Color.Transparent;
            this.RECOIL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RECOIL.CheckedState.BorderRadius = 2;
            this.RECOIL.CheckedState.BorderThickness = 0;
            this.RECOIL.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.RECOIL.FlatAppearance.BorderSize = 0;
            this.RECOIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RECOIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECOIL.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RECOIL.Location = new System.Drawing.Point(10, 7);
            this.RECOIL.Name = "RECOIL";
            this.RECOIL.Size = new System.Drawing.Size(91, 17);
            this.RECOIL.TabIndex = 49;
            this.RECOIL.Text = "NO RECOIL";
            this.RECOIL.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.RECOIL.UncheckedState.BorderRadius = 2;
            this.RECOIL.UncheckedState.BorderThickness = 1;
            this.RECOIL.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.RECOIL.UseVisualStyleBackColor = false;
            this.RECOIL.Visible = false;
            this.RECOIL.CheckedChanged += new System.EventHandler(this.RECOIL_CheckedChanged);
            // 
            // LOOPEX
            // 
            this.LOOPEX.Animated = true;
            this.LOOPEX.AutoSize = true;
            this.LOOPEX.BackColor = System.Drawing.Color.Transparent;
            this.LOOPEX.CheckedState.BorderThickness = 0;
            this.LOOPEX.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOOPEX.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOOPEX.CheckedState.InnerOffset = -7;
            this.LOOPEX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LOOPEX.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOOPEX.ForeColor = System.Drawing.Color.Transparent;
            this.LOOPEX.Location = new System.Drawing.Point(134, 87);
            this.LOOPEX.Name = "LOOPEX";
            this.LOOPEX.Size = new System.Drawing.Size(13, 12);
            this.LOOPEX.TabIndex = 50;
            this.LOOPEX.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LOOPEX.UncheckedState.BorderThickness = 2;
            this.LOOPEX.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LOOPEX.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.LOOPEX.UseVisualStyleBackColor = false;
            this.LOOPEX.Visible = false;
            this.LOOPEX.CheckedChanged += new System.EventHandler(this.LOOPEX_CheckedChanged);
            // 
            // ProcID
            // 
            this.ProcID.AutoSize = true;
            this.ProcID.Location = new System.Drawing.Point(11, 87);
            this.ProcID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProcID.Name = "ProcID";
            this.ProcID.Size = new System.Drawing.Size(49, 13);
            this.ProcID.TabIndex = 55;
            this.ProcID.Text = "ProcFind";
            this.ProcID.Visible = false;
            this.ProcID.Click += new System.EventHandler(this.ProcID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.guna2CheckBox2);
            this.groupBox1.Controls.Add(this.guna2CheckBox1);
            this.groupBox1.Controls.Add(this.HEADSHOT);
            this.groupBox1.Controls.Add(this.VisibibleCheck);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(8, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 70);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memory";
            this.groupBox1.Visible = false;
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.Animated = true;
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.guna2CheckBox2.FlatAppearance.BorderSize = 0;
            this.guna2CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guna2CheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2CheckBox2.Location = new System.Drawing.Point(113, 42);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(83, 17);
            this.guna2CheckBox2.TabIndex = 51;
            this.guna2CheckBox2.Text = "SLOW MO";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2CheckBox2.UseVisualStyleBackColor = false;
            this.guna2CheckBox2.Visible = false;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.guna2CheckBox1.FlatAppearance.BorderSize = 0;
            this.guna2CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2CheckBox1.Location = new System.Drawing.Point(6, 42);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(86, 17);
            this.guna2CheckBox1.TabIndex = 50;
            this.guna2CheckBox1.Text = "FIX FLASH";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.guna2CheckBox1.UseVisualStyleBackColor = false;
            this.guna2CheckBox1.Visible = false;
            // 
            // HEADSHOT
            // 
            this.HEADSHOT.Animated = true;
            this.HEADSHOT.AutoSize = true;
            this.HEADSHOT.BackColor = System.Drawing.Color.Transparent;
            this.HEADSHOT.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HEADSHOT.CheckedState.BorderRadius = 2;
            this.HEADSHOT.CheckedState.BorderThickness = 0;
            this.HEADSHOT.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.HEADSHOT.FlatAppearance.BorderSize = 0;
            this.HEADSHOT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HEADSHOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEADSHOT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.HEADSHOT.Location = new System.Drawing.Point(113, 19);
            this.HEADSHOT.Name = "HEADSHOT";
            this.HEADSHOT.Size = new System.Drawing.Size(112, 17);
            this.HEADSHOT.TabIndex = 48;
            this.HEADSHOT.Text = "0% HEADSHOT";
            this.HEADSHOT.UncheckedState.BorderColor = System.Drawing.Color.Gray;
            this.HEADSHOT.UncheckedState.BorderRadius = 2;
            this.HEADSHOT.UncheckedState.BorderThickness = 1;
            this.HEADSHOT.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.HEADSHOT.UseVisualStyleBackColor = false;
            this.HEADSHOT.Visible = false;
            // 
            // VisibibleCheck
            // 
            this.VisibibleCheck.Animated = true;
            this.VisibibleCheck.AutoSize = true;
            this.VisibibleCheck.BackColor = System.Drawing.Color.Transparent;
            this.VisibibleCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.VisibibleCheck.CheckedState.BorderRadius = 2;
            this.VisibibleCheck.CheckedState.BorderThickness = 0;
            this.VisibibleCheck.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.VisibibleCheck.FlatAppearance.BorderSize = 0;
            this.VisibibleCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VisibibleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisibibleCheck.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.VisibibleCheck.Location = new System.Drawing.Point(242, 35);
            this.VisibibleCheck.Name = "VisibibleCheck";
            this.VisibibleCheck.Size = new System.Drawing.Size(13, 12);
            this.VisibibleCheck.TabIndex = 60;
            this.VisibibleCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.VisibibleCheck.UncheckedState.BorderRadius = 2;
            this.VisibibleCheck.UncheckedState.BorderThickness = 1;
            this.VisibibleCheck.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.VisibibleCheck.UseVisualStyleBackColor = false;
            this.VisibibleCheck.Visible = false;
            // 
            // GAGA
            // 
            this.GAGA.Animated = true;
            this.GAGA.AutoSize = true;
            this.GAGA.BackColor = System.Drawing.Color.Transparent;
            this.GAGA.CheckedState.BorderThickness = 0;
            this.GAGA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GAGA.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GAGA.CheckedState.InnerOffset = -7;
            this.GAGA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GAGA.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAGA.ForeColor = System.Drawing.Color.Transparent;
            this.GAGA.Location = new System.Drawing.Point(134, 110);
            this.GAGA.Name = "GAGA";
            this.GAGA.Size = new System.Drawing.Size(13, 12);
            this.GAGA.TabIndex = 59;
            this.GAGA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GAGA.UncheckedState.BorderThickness = 2;
            this.GAGA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.GAGA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.GAGA.UseVisualStyleBackColor = false;
            this.GAGA.Visible = false;
            // 
            // Musicon
            // 
            this.Musicon.BackColor = System.Drawing.Color.Transparent;
            this.Musicon.CheckedState.Parent = this.Musicon;
            this.Musicon.CustomImages.Parent = this.Musicon;
            this.Musicon.FillColor = System.Drawing.Color.Transparent;
            this.Musicon.FillColor2 = System.Drawing.Color.Transparent;
            this.Musicon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Musicon.ForeColor = System.Drawing.Color.Transparent;
            this.Musicon.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musicon.HoverState.Parent = this.Musicon;
            this.Musicon.Location = new System.Drawing.Point(646, 37);
            this.Musicon.Name = "Musicon";
            this.Musicon.ShadowDecoration.Parent = this.Musicon;
            this.Musicon.Size = new System.Drawing.Size(15, 10);
            this.Musicon.TabIndex = 61;
            this.Musicon.Text = "START BYPASS";
            this.Musicon.Click += new System.EventHandler(this.Musicon_Click);
            // 
            // MusicOff
            // 
            this.MusicOff.BackColor = System.Drawing.Color.Transparent;
            this.MusicOff.CheckedState.Parent = this.MusicOff;
            this.MusicOff.CustomImages.Parent = this.MusicOff;
            this.MusicOff.FillColor = System.Drawing.Color.Transparent;
            this.MusicOff.FillColor2 = System.Drawing.Color.Transparent;
            this.MusicOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MusicOff.ForeColor = System.Drawing.Color.Transparent;
            this.MusicOff.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicOff.HoverState.Parent = this.MusicOff;
            this.MusicOff.Location = new System.Drawing.Point(676, 34);
            this.MusicOff.Name = "MusicOff";
            this.MusicOff.ShadowDecoration.Parent = this.MusicOff;
            this.MusicOff.Size = new System.Drawing.Size(16, 12);
            this.MusicOff.TabIndex = 62;
            this.MusicOff.Text = "START BYPASS";
            this.MusicOff.Click += new System.EventHandler(this.MusicOff_Click);
            // 
            // Expire
            // 
            this.Expire.AutoSize = true;
            this.Expire.BackColor = System.Drawing.Color.Transparent;
            this.Expire.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expire.ForeColor = System.Drawing.Color.Red;
            this.Expire.Location = new System.Drawing.Point(322, 648);
            this.Expire.Name = "Expire";
            this.Expire.Size = new System.Drawing.Size(38, 13);
            this.Expire.TabIndex = 63;
            this.Expire.Text = "Expire";
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitControlBox.FillColor = System.Drawing.Color.Gray;
            this.exitControlBox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(365, 4);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(30, 20);
            this.exitControlBox.TabIndex = 64;
            this.exitControlBox.Click += new System.EventHandler(this.exitControlBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 664);
            this.Controls.Add(this.exitControlBox);
            this.Controls.Add(this.Expire);
            this.Controls.Add(this.MusicOff);
            this.Controls.Add(this.Musicon);
            this.Controls.Add(this.GAGA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.ProcID);
            this.Controls.Add(this.LOOPEX);
            this.Controls.Add(this.RECOIL);
            this.Controls.Add(this.IPADVIEW);
            this.Controls.Add(this.status);
            this.Controls.Add(this.DEVICEID);
            this.Controls.Add(this.guna2GradientTileButton2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.LOOPCH);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000075 RID: 117
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x04000076 RID: 118
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse_0;

		// Token: 0x04000077 RID: 119
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl_0;

		// Token: 0x04000078 RID: 120
		private global::Guna.UI2.WinForms.Guna2ControlBox Minimized;

		// Token: 0x04000079 RID: 121
		private global::Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;

		// Token: 0x0400007A RID: 122
		private global::Guna.UI2.WinForms.Guna2RadioButton LOOPCH;

		// Token: 0x0400007B RID: 123
		private global::Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;

		// Token: 0x0400007C RID: 124
		private global::Guna.UI2.WinForms.Guna2CheckBox DEVICEID;

		// Token: 0x0400007D RID: 125
		private global::Guna.UI2.WinForms.Guna2CheckBox RECOIL;

		// Token: 0x0400007E RID: 126
		private global::Guna.UI2.WinForms.Guna2CheckBox IPADVIEW;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label status;

		// Token: 0x04000080 RID: 128
		private global::Guna.UI2.WinForms.Guna2RadioButton LOOPEX;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label ProcID;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000083 RID: 131
		private global::Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;

		// Token: 0x04000084 RID: 132
		private global::Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;

		// Token: 0x04000085 RID: 133
		private global::Guna.UI2.WinForms.Guna2CheckBox HEADSHOT;

		// Token: 0x04000086 RID: 134
		private global::Guna.UI2.WinForms.Guna2RadioButton GAGA;

		// Token: 0x04000087 RID: 135
		private global::Guna.UI2.WinForms.Guna2CheckBox VisibibleCheck;

		// Token: 0x04000088 RID: 136
		private global::Guna.UI2.WinForms.Guna2GradientTileButton Musicon;

		// Token: 0x04000089 RID: 137
		private global::Guna.UI2.WinForms.Guna2GradientTileButton MusicOff;

		// Token: 0x0400008A RID: 138
		private global::Guna.UI2.WinForms.Guna2ComboBox ComboBox1;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label Expire;

		// Token: 0x0400008C RID: 140
		private global::Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private System.ComponentModel.IContainer components;
    }
}
