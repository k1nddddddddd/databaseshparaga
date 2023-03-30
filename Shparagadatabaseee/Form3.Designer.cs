namespace Shparagadatabaseee
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.расписаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписаниеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database21DataSet = new Shparagadatabaseee.database21DataSet();
            this.database21DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.парикмахерскиеУслугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.парикмахерские_услугиTableAdapter = new Shparagadatabaseee.database21DataSetTableAdapters.Парикмахерские_услугиTableAdapter();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new Shparagadatabaseee.database21DataSetTableAdapters.РасписаниеTableAdapter();
            this.database21DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database21DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mAKEUPБРОВИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAKE_UP__БРОВИTableAdapter = new Shparagadatabaseee.database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскиеУслугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.расписаниеDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.услугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // расписаниеDataGridViewTextBoxColumn
            // 
            this.расписаниеDataGridViewTextBoxColumn.DataPropertyName = "Расписание";
            this.расписаниеDataGridViewTextBoxColumn.HeaderText = "Расписание";
            this.расписаниеDataGridViewTextBoxColumn.Name = "расписаниеDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // услугиDataGridViewTextBoxColumn
            // 
            this.услугиDataGridViewTextBoxColumn.DataPropertyName = "Услуги";
            this.услугиDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.услугиDataGridViewTextBoxColumn.Name = "услугиDataGridViewTextBoxColumn";
            // 
            // расписаниеBindingSource1
            // 
            this.расписаниеBindingSource1.DataMember = "Расписание";
            this.расписаниеBindingSource1.DataSource = this.database21DataSet;
            // 
            // database21DataSet
            // 
            this.database21DataSet.DataSetName = "database21DataSet";
            this.database21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database21DataSetBindingSource
            // 
            this.database21DataSetBindingSource.DataSource = this.database21DataSet;
            this.database21DataSetBindingSource.Position = 0;
            // 
            // парикмахерскиеУслугиBindingSource
            // 
            this.парикмахерскиеУслугиBindingSource.DataMember = "Парикмахерские услуги";
            this.парикмахерскиеУслугиBindingSource.DataSource = this.database21DataSetBindingSource;
            // 
            // парикмахерские_услугиTableAdapter
            // 
            this.парикмахерские_услугиTableAdapter.ClearBeforeFill = true;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.database21DataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // database21DataSetBindingSource1
            // 
            this.database21DataSetBindingSource1.DataSource = this.database21DataSet;
            this.database21DataSetBindingSource1.Position = 0;
            // 
            // database21DataSetBindingSource2
            // 
            this.database21DataSetBindingSource2.DataSource = this.database21DataSet;
            this.database21DataSetBindingSource2.Position = 0;
            // 
            // mAKEUPБРОВИBindingSource
            // 
            this.mAKEUPБРОВИBindingSource.DataMember = "MAKE UP/ БРОВИ";
            this.mAKEUPБРОВИBindingSource.DataSource = this.database21DataSet;
            // 
            // mAKE_UP__БРОВИTableAdapter
            // 
            this.mAKE_UP__БРОВИTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.парикмахерскиеУслугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database21DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKEUPБРОВИBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database21DataSetBindingSource;
        private database21DataSet database21DataSet;
        private System.Windows.Forms.BindingSource парикмахерскиеУслугиBindingSource;
        private database21DataSetTableAdapters.Парикмахерские_услугиTableAdapter парикмахерские_услугиTableAdapter;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private database21DataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.BindingSource database21DataSetBindingSource1;
        private System.Windows.Forms.BindingSource database21DataSetBindingSource2;
        private System.Windows.Forms.BindingSource mAKEUPБРОВИBindingSource;
        private database21DataSetTableAdapters.MAKE_UP__БРОВИTableAdapter mAKE_UP__БРОВИTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn расписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource расписаниеBindingSource1;
    }
}