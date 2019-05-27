﻿namespace Master.Forms
{
    partial class frmUserCodeCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCodeCategories));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spSelectAllUserCodeCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUDCategories = new Master.Class.DataSet.dsUDCategories();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CatCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.spSelectUserCodeCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CatNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NarrationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCatCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCatName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNarration = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spSelectUserCodeCategoriesTableAdapter = new Master.Class.DataSet.dsUDCategoriesTableAdapters.spSelectUserCodeCategoriesTableAdapter();
            this.spSelectAllUserCodeCategoriesTableAdapter = new Master.Class.DataSet.dsUDCategoriesTableAdapters.spSelectAllUserCodeCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUserCodeCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUDCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUserCodeCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCatName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.toolStrip1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.CatCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CatNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NarrationTextEdit);
            this.dataLayoutControl1.DataSource = this.spSelectUserCodeCategoriesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(560, 309);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 12);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 20);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 17);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(47, 17);
            this.cutToolStripButton.Text = "Edit";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(60, 17);
            this.copyToolStripButton.Text = "Delete";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 17);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spSelectAllUserCodeCategoriesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 127);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(536, 170);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // spSelectAllUserCodeCategoriesBindingSource
            // 
            this.spSelectAllUserCodeCategoriesBindingSource.DataMember = "spSelectAllUserCodeCategories";
            this.spSelectAllUserCodeCategoriesBindingSource.DataSource = this.dsUDCategories;
            // 
            // dsUDCategories
            // 
            this.dsUDCategories.DataSetName = "dsUDCategories";
            this.dsUDCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCatCode,
            this.colCatName,
            this.colNarration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCatCode
            // 
            this.colCatCode.FieldName = "CatCode";
            this.colCatCode.Name = "colCatCode";
            this.colCatCode.Visible = true;
            this.colCatCode.VisibleIndex = 0;
            // 
            // colCatName
            // 
            this.colCatName.FieldName = "CatName";
            this.colCatName.Name = "colCatName";
            this.colCatName.Visible = true;
            this.colCatName.VisibleIndex = 1;
            // 
            // colNarration
            // 
            this.colNarration.FieldName = "Narration";
            this.colNarration.Name = "colNarration";
            this.colNarration.Visible = true;
            this.colNarration.VisibleIndex = 2;
            // 
            // CatCodeTextEdit
            // 
            this.CatCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserCodeCategoriesBindingSource, "CatCode", true));
            this.CatCodeTextEdit.Location = new System.Drawing.Point(74, 67);
            this.CatCodeTextEdit.Name = "CatCodeTextEdit";
            this.CatCodeTextEdit.Size = new System.Drawing.Size(204, 20);
            this.CatCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CatCodeTextEdit.TabIndex = 4;
            // 
            // spSelectUserCodeCategoriesBindingSource
            // 
            this.spSelectUserCodeCategoriesBindingSource.DataMember = "spSelectUserCodeCategories";
            this.spSelectUserCodeCategoriesBindingSource.DataSource = this.dsUDCategories;
            // 
            // CatNameTextEdit
            // 
            this.CatNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserCodeCategoriesBindingSource, "CatName", true));
            this.CatNameTextEdit.Location = new System.Drawing.Point(332, 67);
            this.CatNameTextEdit.Name = "CatNameTextEdit";
            this.CatNameTextEdit.Size = new System.Drawing.Size(204, 20);
            this.CatNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CatNameTextEdit.TabIndex = 5;
            // 
            // NarrationTextEdit
            // 
            this.NarrationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.spSelectUserCodeCategoriesBindingSource, "Narration", true));
            this.NarrationTextEdit.Location = new System.Drawing.Point(74, 91);
            this.NarrationTextEdit.Name = "NarrationTextEdit";
            this.NarrationTextEdit.Size = new System.Drawing.Size(204, 20);
            this.NarrationTextEdit.StyleController = this.dataLayoutControl1;
            this.NarrationTextEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(560, 309);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(540, 289);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 115);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(540, 174);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCatCode,
            this.ItemForCatName,
            this.ItemForNarration});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(540, 91);
            this.layoutControlGroup3.Text = "User Code Categories";
            // 
            // ItemForCatCode
            // 
            this.ItemForCatCode.Control = this.CatCodeTextEdit;
            this.ItemForCatCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCatCode.Name = "ItemForCatCode";
            this.ItemForCatCode.Size = new System.Drawing.Size(258, 24);
            this.ItemForCatCode.Text = "Cat Code";
            this.ItemForCatCode.TextSize = new System.Drawing.Size(47, 13);
            // 
            // ItemForCatName
            // 
            this.ItemForCatName.Control = this.CatNameTextEdit;
            this.ItemForCatName.Location = new System.Drawing.Point(258, 0);
            this.ItemForCatName.Name = "ItemForCatName";
            this.ItemForCatName.Size = new System.Drawing.Size(258, 48);
            this.ItemForCatName.Text = "Cat Name";
            this.ItemForCatName.TextSize = new System.Drawing.Size(47, 13);
            // 
            // ItemForNarration
            // 
            this.ItemForNarration.Control = this.NarrationTextEdit;
            this.ItemForNarration.Location = new System.Drawing.Point(0, 24);
            this.ItemForNarration.Name = "ItemForNarration";
            this.ItemForNarration.Size = new System.Drawing.Size(258, 24);
            this.ItemForNarration.Text = "Narration";
            this.ItemForNarration.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.toolStrip1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(540, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // spSelectUserCodeCategoriesTableAdapter
            // 
            this.spSelectUserCodeCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // spSelectAllUserCodeCategoriesTableAdapter
            // 
            this.spSelectAllUserCodeCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserCodeCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 309);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmUserCodeCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Code Categories";
            this.Load += new System.EventHandler(this.frmUserCodeCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectAllUserCodeCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUDCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectUserCodeCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarrationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCatName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNarration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit CatCodeTextEdit;
        private System.Windows.Forms.BindingSource spSelectUserCodeCategoriesBindingSource;
        private Class.DataSet.dsUDCategories dsUDCategories;
        private DevExpress.XtraEditors.TextEdit CatNameTextEdit;
        private DevExpress.XtraEditors.TextEdit NarrationTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCatCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCatName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNarration;
        private Class.DataSet.dsUDCategoriesTableAdapters.spSelectUserCodeCategoriesTableAdapter spSelectUserCodeCategoriesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.BindingSource spSelectAllUserCodeCategoriesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCatName;
        private DevExpress.XtraGrid.Columns.GridColumn colNarration;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private Class.DataSet.dsUDCategoriesTableAdapters.spSelectAllUserCodeCategoriesTableAdapter spSelectAllUserCodeCategoriesTableAdapter;
    }
}