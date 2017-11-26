namespace DataGridExample
{
	partial class QuickViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickViewer));
			this.dataGridMembers = new Tekla.Structures.Dialog.UIControls.DataGrid();
			this.labelDataGrid = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.cmbBoxMember = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtBoxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridMembers
			// 
			this.dataGridMembers.AllowUserToAddRows = false;
			this.dataGridMembers.AllowUserToDeleteRows = false;
			this.dataGridMembers.AllowUserToOrderColumns = true;
			this.dataGridMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridMembers.BackgroundColor = System.Drawing.Color.White;
			this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMembers.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridMembers.Location = new System.Drawing.Point(12, 150);
			this.dataGridMembers.Name = "dataGridMembers";
			this.dataGridMembers.ReadOnly = true;
			this.dataGridMembers.RowTemplate.Height = 24;
			this.dataGridMembers.Size = new System.Drawing.Size(750, 429);
			this.dataGridMembers.TabIndex = 1;
			this.dataGridMembers.SelectionChanged += new System.EventHandler(this.dataGridMembers_SelectionChanged);
			// 
			// labelDataGrid
			// 
			this.labelDataGrid.AutoSize = true;
			this.labelDataGrid.Location = new System.Drawing.Point(12, 100);
			this.labelDataGrid.Name = "labelDataGrid";
			this.labelDataGrid.Size = new System.Drawing.Size(100, 17);
			this.labelDataGrid.TabIndex = 2;
			this.labelDataGrid.Text = "Member Name";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(657, 111);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(105, 33);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// cmbBoxMember
			// 
			this.cmbBoxMember.FormattingEnabled = true;
			this.cmbBoxMember.Location = new System.Drawing.Point(12, 120);
			this.cmbBoxMember.Name = "cmbBoxMember";
			this.cmbBoxMember.Size = new System.Drawing.Size(175, 24);
			this.cmbBoxMember.TabIndex = 4;
			this.cmbBoxMember.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMember_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(233, 19);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(20);
			this.pictureBox1.Size = new System.Drawing.Size(256, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// txtBoxSearch
			// 
			this.txtBoxSearch.Location = new System.Drawing.Point(233, 120);
			this.txtBoxSearch.Name = "txtBoxSearch";
			this.txtBoxSearch.Size = new System.Drawing.Size(256, 22);
			this.txtBoxSearch.TabIndex = 6;
			this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(233, 99);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(152, 17);
			this.lblSearch.TabIndex = 7;
			this.lblSearch.Text = "Search Assembly Mark";
			// 
			// QuickViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 591);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.txtBoxSearch);
			this.Controls.Add(this.cmbBoxMember);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelDataGrid);
			this.Controls.Add(this.dataGridMembers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "QuickViewer";
			this.Text = "Quick Viewer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Tekla.Structures.Dialog.UIControls.DataGrid dataGridMembers;
		private System.Windows.Forms.Label labelDataGrid;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.ComboBox cmbBoxMember;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtBoxSearch;
		private System.Windows.Forms.Label lblSearch;
	}
}

