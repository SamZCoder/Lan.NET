namespace Lan.NET.App.Forms
{
    partial class IPScannerForm
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
            this.startText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.endText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.StatusImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.IPAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOnlineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPScanResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPScanResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startText
            // 
            this.startText.Location = new System.Drawing.Point(157, 60);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(100, 20);
            this.startText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(470, 60);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "button1";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // endText
            // 
            this.endText.Location = new System.Drawing.Point(330, 60);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(100, 20);
            this.endText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusImageColumn,
            this.IPAddressColumn,
            this.IsOnlineColumn,
            this.StatusColumn});
            this.resultGridView.Location = new System.Drawing.Point(12, 111);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.resultGridView.RowTemplate.Height = 38;
            this.resultGridView.Size = new System.Drawing.Size(655, 268);
            this.resultGridView.TabIndex = 3;
            // 
            // StatusImageColumn
            // 
            this.StatusImageColumn.HeaderText = "Status";
            this.StatusImageColumn.Name = "StatusImageColumn";
            this.StatusImageColumn.ReadOnly = true;
            // 
            // IPAddressColumn
            // 
            this.IPAddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IPAddressColumn.HeaderText = "IP Address";
            this.IPAddressColumn.Name = "IPAddressColumn";
            this.IPAddressColumn.ReadOnly = true;
            // 
            // IsOnlineColumn
            // 
            this.IsOnlineColumn.HeaderText = "Online ?";
            this.IsOnlineColumn.Name = "IsOnlineColumn";
            this.IsOnlineColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusColumn.HeaderText = "Response";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // iPScanResultBindingSource
            // 
            this.iPScanResultBindingSource.DataSource = typeof(Lan.NET.Domain.IPScanResult);
            // 
            // IPScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.startText);
            this.Name = "IPScannerForm";
            this.Text = "IPScannerForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPScanResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource iPScanResultBindingSource;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewImageColumn StatusImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOnlineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}