namespace BieuDoMuaQuat
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
            this.qLTVDataSet = new BieuDoMuaQuat.QLTVDataSet();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOC_GIATableAdapter = new BieuDoMuaQuat.QLTVDataSetTableAdapters.DOC_GIATableAdapter();
            this.dOCGIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOC_GIA";
            this.dOCGIABindingSource.DataSource = this.qLTVDataSet;
            // 
            // dOC_GIATableAdapter
            // 
            this.dOC_GIATableAdapter.ClearBeforeFill = true;
            // 
            // dOCGIABindingSource1
            // 
            this.dOCGIABindingSource1.DataMember = "DOC_GIA";
            this.dOCGIABindingSource1.DataSource = this.qLTVDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 468);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLTVDataSetTableAdapters.DOC_GIATableAdapter dOC_GIATableAdapter;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private System.Windows.Forms.BindingSource dOCGIABindingSource1;
    }
}

