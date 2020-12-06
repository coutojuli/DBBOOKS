namespace Juliana_N01348498_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTableGrid = new System.Windows.Forms.DataGridView();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTS5230DataSet = new Juliana_N01348498_Project.ITS5230DataSet();
            this.selectRowsToolStrip = new System.Windows.Forms.ToolStrip();
            this.booksTableAdapter = new Juliana_N01348498_Project.ITS5230DataSetTableAdapters.BooksTableAdapter();
            this.btnList = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.booksTableAdapter1 = new Juliana_N01348498_Project.ITS5230DataSetTableAdapters.BooksTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbConnection = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS5230DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            resources.ApplyResources(this.btnConect, "btnConect");
            this.btnConect.Name = "btnConect";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gvTableGrid
            // 
            resources.ApplyResources(this.gvTableGrid, "gvTableGrid");
            this.gvTableGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.gvTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTableGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvTableGrid.Name = "gvTableGrid";
            this.gvTableGrid.RowTemplate.Height = 33;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.iTS5230DataSet;
            // 
            // iTS5230DataSet
            // 
            this.iTS5230DataSet.DataSetName = "ITS5230DataSet";
            this.iTS5230DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectRowsToolStrip
            // 
            resources.ApplyResources(this.selectRowsToolStrip, "selectRowsToolStrip");
            this.selectRowsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.selectRowsToolStrip.Name = "selectRowsToolStrip";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // btnList
            // 
            resources.ApplyResources(this.btnList, "btnList");
            this.btnList.Name = "btnList";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // cbSort
            // 
            resources.ApplyResources(this.cbSort, "cbSort");
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            resources.GetString("cbSort.Items"),
            resources.GetString("cbSort.Items1"),
            resources.GetString("cbSort.Items2")});
            this.cbSort.Name = "cbSort";
            // 
            // lblSort
            // 
            resources.ApplyResources(this.lblSort, "lblSort");
            this.lblSort.Name = "lblSort";
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDelete
            // 
            resources.ApplyResources(this.lblDelete, "lblDelete");
            this.lblDelete.Name = "lblDelete";
            // 
            // txtDelete
            // 
            resources.ApplyResources(this.txtDelete, "txtDelete");
            this.txtDelete.Name = "txtDelete";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbConnection
            // 
            resources.ApplyResources(this.lbConnection, "lbConnection");
            this.lbConnection.Name = "lbConnection";
            // 
            // lblFile
            // 
            resources.ApplyResources(this.lblFile, "lblFile");
            this.lblFile.Name = "lblFile";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblFilename
            // 
            resources.ApplyResources(this.lblFilename, "lblFilename");
            this.lblFilename.Name = "lblFilename";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lbConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.selectRowsToolStrip);
            this.Controls.Add(this.gvTableGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConect);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTS5230DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ITS5230DataSet iTS5230DataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private ITS5230DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridView gvTableGrid;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.ToolStrip selectRowsToolStrip;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lblSort;
        private ITS5230DataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConnection;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblFilename;
    }
}

