namespace WindowsFormsApp1
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.basicWebDataSet = new WindowsFormsApp1.BasicWebDataSet();
            this.pcd_GetUsersTableAdapter = new WindowsFormsApp1.BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager();
            this.FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.pcd_GetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1ContextMenu1 = new C1.Win.C1Command.C1ContextMenu();
            this.MnInsert = new C1.Win.C1Command.C1CommandLink();
            this.c1Command2 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command3 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1Command4 = new C1.Win.C1Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.btnAction = new C1.Win.C1Input.C1Button();
            this.c1TaskbarButton1 = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).BeginInit();
            this.SuspendLayout();
            // 
            // basicWebDataSet
            // 
            this.basicWebDataSet.DataSetName = "BasicWebDataSet";
            this.basicWebDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcd_GetUsersTableAdapter
            // 
            this.pcd_GetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BasicWebDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FlexGrid1
            // 
            this.FlexGrid1.AllowAddNew = true;
            this.FlexGrid1.AllowDelete = true;
            this.FlexGrid1.AllowEditing = false;
            this.FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.FlexGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlexGrid1.AutoResize = true;
            this.FlexGrid1.ColumnInfo = resources.GetString("FlexGrid1.ColumnInfo");
            this.FlexGrid1.DataSource = this.pcd_GetUsersBindingSource;
            this.FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.FlexGrid1.Name = "FlexGrid1";
            this.FlexGrid1.Rows.Count = 1;
            this.FlexGrid1.Size = new System.Drawing.Size(801, 634);
            this.FlexGrid1.TabIndex = 0;
            // 
            // pcd_GetUsersBindingSource
            // 
            this.pcd_GetUsersBindingSource.DataMember = "pcd_GetUsers";
            this.pcd_GetUsersBindingSource.DataSource = this.basicWebDataSet;
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
            this.c1Command3.ShortcutText = "";
            this.c1Command3.Text = "Delete";
            this.c1Command3.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command3_Click);
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
            this.c1Command1.ShortcutText = "";
            this.c1Command1.Text = "Edit";
            this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command4;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1Command4
            // 
            this.c1Command4.Image = ((System.Drawing.Image)(resources.GetObject("c1Command4.Image")));
            this.c1Command4.Name = "c1Command4";
            this.c1Command4.ShortcutText = "";
            this.c1Command4.Text = "Post";
            this.c1Command4.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command4_Click);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1ContextMenu1);
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Commands.Add(this.c1Command2);
            this.c1CommandHolder1.Commands.Add(this.c1Command3);
            this.c1CommandHolder1.Commands.Add(this.c1Command4);
            this.c1CommandHolder1.Owner = this;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1CommandHolder1.SetC1Command(this.btnAction, this.c1ContextMenu1);
            this.c1CommandHolder1.SetC1ContextMenu(this.btnAction, this.c1ContextMenu1);
            this.btnAction.Location = new System.Drawing.Point(566, 652);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Thực hiện";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.UseVisualStyleForeColor = true;
            this.btnAction.AutoSizeChanged += new System.EventHandler(this.c1Button1_Click);
            // 
            // c1TaskbarButton1
            // 
            this.c1TaskbarButton1.ContainerForm = this;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.FlexGrid1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basicWebDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcd_GetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BasicWebDataSet basicWebDataSet;
        private BasicWebDataSetTableAdapters.pcd_GetUsersTableAdapter pcd_GetUsersTableAdapter;
        private BasicWebDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private C1.Win.C1FlexGrid.C1FlexGrid FlexGrid1;
        private System.Windows.Forms.BindingSource pcd_GetUsersBindingSource;
        private C1.Win.C1Command.C1ContextMenu c1ContextMenu1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Win7Pack.C1TaskbarButton c1TaskbarButton1;
        private C1.Win.C1Command.C1CommandLink MnInsert;
        private C1.Win.C1Command.C1Command c1Command2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1Command c1Command3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1Command c1Command1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1Command c1Command4;
        private C1.Win.C1Input.C1Button btnAction;
    }
}