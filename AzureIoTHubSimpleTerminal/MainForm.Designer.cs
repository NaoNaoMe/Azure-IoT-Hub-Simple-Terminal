namespace AzureIoTHubSimpleTerminal
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceIDLabel = new System.Windows.Forms.Label();
            this.deviceIDTextBox = new System.Windows.Forms.TextBox();
            this.azureCommConnectButton = new System.Windows.Forms.Button();
            this.azureCommTxTextBox = new System.Windows.Forms.TextBox();
            this.commLogtextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newLineCheckBox = new System.Windows.Forms.CheckBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionStringTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.deviceIDLabel);
            this.groupBox1.Controls.Add(this.deviceIDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AzureIoTHUB Settings";
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(127, 43);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(213, 19);
            this.connectionStringTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection String";
            // 
            // deviceIDLabel
            // 
            this.deviceIDLabel.AutoSize = true;
            this.deviceIDLabel.Location = new System.Drawing.Point(14, 21);
            this.deviceIDLabel.Name = "deviceIDLabel";
            this.deviceIDLabel.Size = new System.Drawing.Size(55, 12);
            this.deviceIDLabel.TabIndex = 1;
            this.deviceIDLabel.Text = "Device ID";
            // 
            // deviceIDTextBox
            // 
            this.deviceIDTextBox.Location = new System.Drawing.Point(127, 18);
            this.deviceIDTextBox.Name = "deviceIDTextBox";
            this.deviceIDTextBox.Size = new System.Drawing.Size(213, 19);
            this.deviceIDTextBox.TabIndex = 0;
            // 
            // azureCommConnectButton
            // 
            this.azureCommConnectButton.Location = new System.Drawing.Point(248, 92);
            this.azureCommConnectButton.Name = "azureCommConnectButton";
            this.azureCommConnectButton.Size = new System.Drawing.Size(104, 29);
            this.azureCommConnectButton.TabIndex = 6;
            this.azureCommConnectButton.Text = "Connect";
            this.azureCommConnectButton.UseVisualStyleBackColor = true;
            this.azureCommConnectButton.Click += new System.EventHandler(this.azureCommConnectButton_Click);
            // 
            // azureCommTxTextBox
            // 
            this.azureCommTxTextBox.Location = new System.Drawing.Point(16, 17);
            this.azureCommTxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.azureCommTxTextBox.Name = "azureCommTxTextBox";
            this.azureCommTxTextBox.Size = new System.Drawing.Size(232, 19);
            this.azureCommTxTextBox.TabIndex = 7;
            this.azureCommTxTextBox.Text = "Text1234ABCD";
            this.azureCommTxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.azureCommTxTextBox_KeyPress);
            // 
            // commLogtextBox
            // 
            this.commLogtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commLogtextBox.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commLogtextBox.Location = new System.Drawing.Point(0, 0);
            this.commLogtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commLogtextBox.Multiline = true;
            this.commLogtextBox.Name = "commLogtextBox";
            this.commLogtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commLogtextBox.Size = new System.Drawing.Size(450, 199);
            this.commLogtextBox.TabIndex = 9;
            this.commLogtextBox.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newLineCheckBox);
            this.groupBox2.Controls.Add(this.azureCommTxTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmission Data";
            // 
            // newLineCheckBox
            // 
            this.newLineCheckBox.AutoSize = true;
            this.newLineCheckBox.Location = new System.Drawing.Point(254, 18);
            this.newLineCheckBox.Name = "newLineCheckBox";
            this.newLineCheckBox.Size = new System.Drawing.Size(67, 16);
            this.newLineCheckBox.TabIndex = 8;
            this.newLineCheckBox.Text = "NewLine";
            this.newLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.groupBox1);
            this.mainSplitContainer.Panel1.Controls.Add(this.azureCommConnectButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.groupBox2);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.commLogtextBox);
            this.mainSplitContainer.Size = new System.Drawing.Size(450, 396);
            this.mainSplitContainer.SplitterDistance = 193;
            this.mainSplitContainer.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 396);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "MainForm";
            this.Text = "AzureIoTHUB Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button azureCommConnectButton;
        private System.Windows.Forms.TextBox azureCommTxTextBox;
        private System.Windows.Forms.TextBox commLogtextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deviceIDLabel;
        private System.Windows.Forms.TextBox deviceIDTextBox;
        private System.Windows.Forms.CheckBox newLineCheckBox;
    }
}

