namespace Aplicatie
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.refreshBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.txtNrLicense = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.dgvAdmin);
            this.panel1.Controls.Add(this.txtLoc);
            this.panel1.Controls.Add(this.refreshBTN);
            this.panel1.Controls.Add(this.editBTN);
            this.panel1.Controls.Add(this.addBTN);
            this.panel1.Controls.Add(this.deleteBTN);
            this.panel1.Controls.Add(this.txtNrLicense);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(204, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 547);
            this.panel1.TabIndex = 0;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.NrLicense,
            this.Locality});
            this.dgvAdmin.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAdmin.Location = new System.Drawing.Point(480, 114);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(662, 372);
            this.dgvAdmin.TabIndex = 30;
            this.dgvAdmin.DoubleClick += new System.EventHandler(this.dgvAdmin_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // NrLicense
            // 
            this.NrLicense.DataPropertyName = "NrLicense";
            this.NrLicense.HeaderText = "NrLicense";
            this.NrLicense.MinimumWidth = 6;
            this.NrLicense.Name = "NrLicense";
            this.NrLicense.ReadOnly = true;
            this.NrLicense.Width = 125;
            // 
            // Locality
            // 
            this.Locality.DataPropertyName = "Locality";
            this.Locality.HeaderText = "Locality";
            this.Locality.MinimumWidth = 6;
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            this.Locality.Width = 125;
            // 
            // txtLoc
            // 
            this.txtLoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLoc.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLoc.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLoc.HintText = "";
            this.txtLoc.isPassword = false;
            this.txtLoc.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLoc.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLoc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLoc.LineThickness = 3;
            this.txtLoc.Location = new System.Drawing.Point(185, 277);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(251, 44);
            this.txtLoc.TabIndex = 29;
            this.txtLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // refreshBTN
            // 
            this.refreshBTN.BackColor = System.Drawing.SystemColors.Control;
            this.refreshBTN.FlatAppearance.BorderSize = 0;
            this.refreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBTN.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold);
            this.refreshBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.refreshBTN.Location = new System.Drawing.Point(72, 440);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(118, 39);
            this.refreshBTN.TabIndex = 28;
            this.refreshBTN.Text = "REFRESH";
            this.refreshBTN.UseVisualStyleBackColor = false;
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.SystemColors.Control;
            this.editBTN.FlatAppearance.BorderSize = 0;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.editBTN.Location = new System.Drawing.Point(312, 377);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(124, 40);
            this.editBTN.TabIndex = 24;
            this.editBTN.Text = "EDIT";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.SystemColors.Control;
            this.addBTN.FlatAppearance.BorderSize = 0;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addBTN.Location = new System.Drawing.Point(70, 377);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(120, 40);
            this.addBTN.TabIndex = 23;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteBTN.Location = new System.Drawing.Point(312, 439);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(124, 40);
            this.deleteBTN.TabIndex = 22;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // txtNrLicense
            // 
            this.txtNrLicense.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNrLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNrLicense.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNrLicense.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.HintText = "";
            this.txtNrLicense.isPassword = false;
            this.txtNrLicense.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNrLicense.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtNrLicense.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNrLicense.LineThickness = 3;
            this.txtNrLicense.Location = new System.Drawing.Point(185, 221);
            this.txtNrLicense.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrLicense.Name = "txtNrLicense";
            this.txtNrLicense.Size = new System.Drawing.Size(251, 44);
            this.txtNrLicense.TabIndex = 19;
            this.txtNrLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(37, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "LOCALITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(37, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "NR. LICENSE";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLName.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtLName.HintText = "";
            this.txtLName.isPassword = false;
            this.txtLName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLName.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtLName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLName.LineThickness = 3;
            this.txtLName.Location = new System.Drawing.Point(185, 169);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(251, 44);
            this.txtLName.TabIndex = 15;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFName.HintForeColor = System.Drawing.SystemColors.Control;
            this.txtFName.HintText = "";
            this.txtFName.isPassword = false;
            this.txtFName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFName.LineIdleColor = System.Drawing.SystemColors.Control;
            this.txtFName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFName.LineThickness = 3;
            this.txtFName.Location = new System.Drawing.Point(185, 114);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(251, 44);
            this.txtFName.TabIndex = 4;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(37, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "LAST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "FIRST NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(458, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "PILOT APPLICATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(228, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 37);
            this.label5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(51, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pilot";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(27, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Airport";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(1373, -5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button8.Location = new System.Drawing.Point(51, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 47);
            this.button8.TabIndex = 4;
            this.button8.Text = "Flight";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 622);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNrLicense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLName;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button refreshBTN;
        private System.Windows.Forms.Button button8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLoc;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
    }
}