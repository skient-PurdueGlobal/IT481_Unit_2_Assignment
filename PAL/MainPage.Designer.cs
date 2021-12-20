
namespace IT481_Unit_2_Assignment.PAL
{
    partial class MainPage
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.addRecordGroup = new System.Windows.Forms.GroupBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.countRecordGroup = new System.Windows.Forms.GroupBox();
            this.countRecordButton = new System.Windows.Forms.Button();
            this.countRecordTextBox = new System.Windows.Forms.TextBox();
            this.viewDataButton = new System.Windows.Forms.Button();
            this.connectionGroup = new System.Windows.Forms.GroupBox();
            this.connectionTextBox = new System.Windows.Forms.TextBox();
            this.dbViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.addRecordGroup.SuspendLayout();
            this.countRecordGroup.SuspendLayout();
            this.connectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.addRecordGroup);
            this.mainSplitContainer.Panel1.Controls.Add(this.countRecordGroup);
            this.mainSplitContainer.Panel1.Controls.Add(this.viewDataButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.connectionGroup);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dbViewer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1164, 711);
            this.mainSplitContainer.SplitterDistance = 215;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // addRecordGroup
            // 
            this.addRecordGroup.Controls.Add(this.companyTextBox);
            this.addRecordGroup.Controls.Add(this.idTextBox);
            this.addRecordGroup.Controls.Add(this.companyLabel);
            this.addRecordGroup.Controls.Add(this.idLabel);
            this.addRecordGroup.Controls.Add(this.addRecordButton);
            this.addRecordGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addRecordGroup.Location = new System.Drawing.Point(38, 10);
            this.addRecordGroup.Name = "addRecordGroup";
            this.addRecordGroup.Size = new System.Drawing.Size(289, 147);
            this.addRecordGroup.TabIndex = 3;
            this.addRecordGroup.TabStop = false;
            this.addRecordGroup.Text = "Add Record";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(122, 45);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(151, 23);
            this.companyTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(122, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(151, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(14, 48);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(97, 15);
            this.companyLabel.TabIndex = 3;
            this.companyLabel.Text = "Company Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(14, 91);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(259, 42);
            this.addRecordButton.TabIndex = 1;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // countRecordGroup
            // 
            this.countRecordGroup.Controls.Add(this.countRecordButton);
            this.countRecordGroup.Controls.Add(this.countRecordTextBox);
            this.countRecordGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.countRecordGroup.Location = new System.Drawing.Point(839, 10);
            this.countRecordGroup.Name = "countRecordGroup";
            this.countRecordGroup.Size = new System.Drawing.Size(289, 147);
            this.countRecordGroup.TabIndex = 2;
            this.countRecordGroup.TabStop = false;
            this.countRecordGroup.Text = "No. of Records";
            // 
            // countRecordButton
            // 
            this.countRecordButton.Location = new System.Drawing.Point(14, 91);
            this.countRecordButton.Name = "countRecordButton";
            this.countRecordButton.Size = new System.Drawing.Size(259, 42);
            this.countRecordButton.TabIndex = 1;
            this.countRecordButton.Text = "Count Records";
            this.countRecordButton.UseVisualStyleBackColor = true;
            this.countRecordButton.Click += new System.EventHandler(this.countRecordButton_Click);
            // 
            // countRecordTextBox
            // 
            this.countRecordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.countRecordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countRecordTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countRecordTextBox.Location = new System.Drawing.Point(14, 21);
            this.countRecordTextBox.Multiline = true;
            this.countRecordTextBox.Name = "countRecordTextBox";
            this.countRecordTextBox.ReadOnly = true;
            this.countRecordTextBox.Size = new System.Drawing.Size(259, 39);
            this.countRecordTextBox.TabIndex = 0;
            this.countRecordTextBox.Text = "?";
            this.countRecordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewDataButton
            // 
            this.viewDataButton.Location = new System.Drawing.Point(333, 158);
            this.viewDataButton.Name = "viewDataButton";
            this.viewDataButton.Size = new System.Drawing.Size(500, 50);
            this.viewDataButton.TabIndex = 1;
            this.viewDataButton.Text = "View Database";
            this.viewDataButton.UseVisualStyleBackColor = true;
            this.viewDataButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // connectionGroup
            // 
            this.connectionGroup.Controls.Add(this.connectionTextBox);
            this.connectionGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.connectionGroup.Location = new System.Drawing.Point(393, 10);
            this.connectionGroup.Name = "connectionGroup";
            this.connectionGroup.Size = new System.Drawing.Size(377, 133);
            this.connectionGroup.TabIndex = 0;
            this.connectionGroup.TabStop = false;
            this.connectionGroup.Text = "Connection Status";
            // 
            // connectionTextBox
            // 
            this.connectionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.connectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionTextBox.Location = new System.Drawing.Point(14, 24);
            this.connectionTextBox.Multiline = true;
            this.connectionTextBox.Name = "connectionTextBox";
            this.connectionTextBox.ReadOnly = true;
            this.connectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectionTextBox.Size = new System.Drawing.Size(347, 94);
            this.connectionTextBox.TabIndex = 0;
            this.connectionTextBox.TabStop = false;
            this.connectionTextBox.Text = "Waiting For Connection...";
            this.connectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dbViewer
            // 
            this.dbViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbViewer.Location = new System.Drawing.Point(0, 0);
            this.dbViewer.Name = "dbViewer";
            this.dbViewer.RowTemplate.Height = 25;
            this.dbViewer.Size = new System.Drawing.Size(1160, 488);
            this.dbViewer.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 711);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit 2 Assignment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.addRecordGroup.ResumeLayout(false);
            this.addRecordGroup.PerformLayout();
            this.countRecordGroup.ResumeLayout(false);
            this.countRecordGroup.PerformLayout();
            this.connectionGroup.ResumeLayout(false);
            this.connectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dbViewer;
        private System.Windows.Forms.GroupBox connectionGroup;
        private System.Windows.Forms.TextBox connectionTextBox;
        private System.Windows.Forms.Button viewDataButton;
        private System.Windows.Forms.GroupBox countRecordGroup;
        private System.Windows.Forms.Button countRecordButton;
        private System.Windows.Forms.TextBox countRecordTextBox;
        private System.Windows.Forms.GroupBox addRecordGroup;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label idLabel;
    }
}