namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pcd_GetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basicWebDataSet = new WindowsFormsApp1.BasicWebDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.BasicWebDataSetTableAdapters.UsersTableAdapter();
            this.pcd_GetUsersTableAdapter = new WindowsFormsApp1.BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sưaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.basicWebDataSet1 = new WindowsFormsApp1.BasicWebDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.UserID,
            this.UserName,
            this.PassWord,
            this.Email,
            this.Tel,
            this.Disabled});
            this.dataGridView1.DataSource = this.pcd_GetUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // STT
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle4;
            this.STT.FillWeight = 41.17647F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.FillWeight = 109.8039F;
            this.UserID.HeaderText = "Mã nhân viên ";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 109.8039F;
            this.UserName.HeaderText = "Tên nhân viên";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.FillWeight = 109.8039F;
            this.PassWord.HeaderText = "Mật khẩu ";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 109.8039F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.FillWeight = 109.8039F;
            this.Tel.HeaderText = "Số điện thoại";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            // 
            // Disabled
            // 
            this.Disabled.DataPropertyName = "Disabled";
            this.Disabled.FillWeight = 109.8039F;
            this.Disabled.HeaderText = "Không hiển thị";
            this.Disabled.MinimumWidth = 6;
            this.Disabled.Name = "Disabled";
            this.Disabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Disabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pcd_GetUsersBindingSource
            // 
            this.pcd_GetUsersBindingSource.DataMember = "pcd_GetUsers";
            this.pcd_GetUsersBindingSource.DataSource = this.basicWebDataSet;
            this.pcd_GetUsersBindingSource.CurrentChanged += new System.EventHandler(this.pcd_GetUsersBindingSource_CurrentChanged);
            // 
            // basicWebDataSet
            // 
            this.basicWebDataSet.DataSetName = "BasicWebDataSet";
            this.basicWebDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.basicWebDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pcd_GetUsersTableAdapter
            // 
            this.pcd_GetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(0, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trợ giúp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.ContextMenuStrip = this.ContextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(616, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thực hiện";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sưaToolStripMenuItem,
            this.xemToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            this.ContextMenuStrip1.Text = "Thực hiện";
            this.ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.thêmToolStripMenuItem.Text = "Thêm ";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sưaToolStripMenuItem
            // 
            this.sưaToolStripMenuItem.Name = "sưaToolStripMenuItem";
            this.sưaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sưaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.sưaToolStripMenuItem.Text = "Sửa";
            this.sưaToolStripMenuItem.Click += new System.EventHandler(this.sưaToolStripMenuItem_Click);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xemToolStripMenuItem.Text = "Xem";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(721, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Đóng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // basicWebDataSet1
            // 
            this.basicWebDataSet1.DataSetName = "BasicWebDataSet";
            this.basicWebDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Danh mục người sử dụng chương trình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BasicWebDataSet basicWebDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BasicWebDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource pcd_GetUsersBindingSource;
        private BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter pcd_GetUsersTableAdapter;
        private BasicWebDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sưaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disabled;
        private BasicWebDataSet basicWebDataSet1;
    }
}

