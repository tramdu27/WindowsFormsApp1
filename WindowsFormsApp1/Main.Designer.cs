namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnAction = new C1.Win.C1Input.C1Button();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.pcd_GetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basicWebDataSet = new WindowsFormsApp1.BasicWebDataSet();
            this.tableAdapterManager = new WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
            this.MnInsert = new C1.Win.C1Command.C1CommandLink();
            this.c1Command2 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.View = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.c1TaskbarButton1 = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.pcd_GetUsersTableAdapter = new WindowsFormsApp1.BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1CommandHolder1.SetC1Command(this.btnAction, this.c1ContextMenu1);
            this.c1CommandHolder1.SetC1ContextMenu(this.btnAction, this.c1ContextMenu1);
            this.btnAction.Location = new System.Drawing.Point(566, 540);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Thực hiện";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.UseVisualStyleForeColor = true;
            // 
            // c1Button1
            // 
            this.c1CommandHolder1.SetC1Command(this.c1Button1, this.c1ContextMenu1);
            this.c1CommandHolder1.SetC1ContextMenu(this.c1Button1, this.c1ContextMenu1);
            this.c1Button1.Location = new System.Drawing.Point(556, 415);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(107, 23);
            this.c1Button1.TabIndex = 4;
            this.c1Button1.Text = "Thực hiện";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.UseVisualStyleForeColor = true;
            // 
            // FlexGrid1
            // 
            this.FlexGrid1.AllowAddNew = true;
            this.FlexGrid1.AllowDelete = true;
            this.FlexGrid1.AllowFiltering = true;
            this.FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlexGrid1.AutoResize = true;
            this.FlexGrid1.ColumnInfo = resources.GetString("FlexGrid1.ColumnInfo");
            this.FlexGrid1.DataSource = this.pcd_GetUsersBindingSource;
            this.FlexGrid1.Location = new System.Drawing.Point(2, 0);
            this.FlexGrid1.Name = "FlexGrid1";
            this.FlexGrid1.Rows.Count = 1;
            this.FlexGrid1.Size = new System.Drawing.Size(799, 397);
            this.FlexGrid1.TabIndex = 2;
            // 
            // pcd_GetUsersBindingSource
            // 
            this.pcd_GetUsersBindingSource.DataMember = "pcd_GetUsers";
            this.pcd_GetUsersBindingSource.DataSource = this.basicWebDataSet;
            // 
            // basicWebDataSet
            // 
            this.basicWebDataSet.DataSetName = "BasicWebDataSet";
            this.basicWebDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1ContextMenu1);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Commands.Add(this.View);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1ContextMenu1
            // 
            this.c1ContextMenu1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.MnInsert,
            this.c1CommandLink3,
            this.c1CommandLink2,
            this.c1CommandLink4});
            this.c1ContextMenu1.Name = "c1ContextMenu1";
            this.c1ContextMenu1.ShortcutText = "";
            // 
            // MnInsert
            // 
            this.MnInsert.Command = this.c1Command2;
            // 
            // c1Command2
            // 
            this.c1Command2.Image = ((System.Drawing.Image)(resources.GetObject("c1Command2.Image")));
            this.c1Command2.Name = "c1Command2";
            this.c1Command2.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.c1Command2.ShortcutText = "";
            this.c1Command2.Text = "Insert";
            this.c1Command2.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command2_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command3;
            this.c1CommandLink3.SortOrder = 1;
            // 
            // c1Command3
            // 
            this.c1Command3.Image = ((System.Drawing.Image)(resources.GetObject("c1Command3.Image")));
            this.c1Command3.Name = "c1Command3";
            this.c1Command3.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.c1Command3.ShortcutText = "";
            this.c1Command3.Text = "Delete";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command1;
            this.c1CommandLink2.SortOrder = 2;
            // 
            // c1Command1
            // 
            this.c1Command1.Image = ((System.Drawing.Image)(resources.GetObject("c1Command1.Image")));
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.c1Command1.ShortcutText = "";
            this.c1Command1.Text = "Edit";
            this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command4;
            this.c1CommandLink4.SortOrder = 3;
            this.c1CommandLink4.Text = "View";
            // 
            // c1Command4
            // 
            this.c1Command4.Image = ((System.Drawing.Image)(resources.GetObject("c1Command4.Image")));
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.c1Command4.ShortcutText = "";
            this.c1Command4.Text = "Post";
            // 
            // View
            // 
            this.View.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink5});
            this.View.Name = "View";
            this.View.ShortcutText = "";
            this.View.Text = "Search";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Text = "New Command";
            // 
            // c1TaskbarButton1
            // 
            this.c1TaskbarButton1.ContainerForm = this;
            // 
            // pcd_GetUsersTableAdapter
            // 
            this.pcd_GetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // c1Button2
            // 
            this.c1Button2.Location = new System.Drawing.Point(681, 415);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(93, 23);
            this.c1Button2.TabIndex = 5;
            this.c1Button2.Text = "Đóng";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.UseVisualStyleForeColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.FlexGrid1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1Input.C1Button btnAction;
        private C1.Win.C1FlexGrid.C1FlexGrid FlexGrid1;
        private C1.Win.C1Input.C1Button c1Button1;
        private BasicWebDataSet basicWebDataSet;
        private BasicWebDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1ContextMenu c1ContextMenu1;
        private C1.Win.C1Command.C1CommandLink MnInsert;
        private C1.Win.C1Command.C1Command c1Command2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1Command c1Command3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1Command c1Command1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1Command c1Command4;
        private C1.Win.C1Win7Pack.C1TaskbarButton c1TaskbarButton1;
        private System.Windows.Forms.BindingSource pcd_GetUsersBindingSource;
        private BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter pcd_GetUsersTableAdapter;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Command.C1CommandMenu View;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
    }
}