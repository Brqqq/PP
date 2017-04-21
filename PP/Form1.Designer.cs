namespace PP
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonRemoveColor = new System.Windows.Forms.Button();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.pictureInput = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(6, 22);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(183, 20);
            this.textPath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(195, 22);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonRun);
            this.groupBox1.Controls.Add(this.buttonRemoveColor);
            this.groupBox1.Controls.Add(this.buttonAddColor);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.listBoxColors);
            this.groupBox1.Controls.Add(this.textPath);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 459);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(8, 407);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(262, 23);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Go";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonRemoveColor
            // 
            this.buttonRemoveColor.Location = new System.Drawing.Point(195, 83);
            this.buttonRemoveColor.Name = "buttonRemoveColor";
            this.buttonRemoveColor.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveColor.TabIndex = 5;
            this.buttonRemoveColor.Text = "Remove";
            this.buttonRemoveColor.UseVisualStyleBackColor = true;
            this.buttonRemoveColor.Click += new System.EventHandler(this.buttonRemoveColor_Click);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Location = new System.Drawing.Point(114, 83);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddColor.TabIndex = 4;
            this.buttonAddColor.Text = "Add";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(8, 83);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 3;
            // 
            // listBoxColors
            // 
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.Items.AddRange(new object[] {
            "e50000",
            "ffa7d1",
            "888888",
            "242424",
            "e59500",
            "e5d900",
            "94e044",
            "02be01",
            "00d3dd",
            "0083c7",
            "0000ea",
            "820080"});
            this.listBoxColors.Location = new System.Drawing.Point(6, 112);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(264, 251);
            this.listBoxColors.TabIndex = 2;
            this.listBoxColors.SelectedValueChanged += new System.EventHandler(this.listBoxColors_SelectedValueChanged);
            // 
            // pictureInput
            // 
            this.pictureInput.Location = new System.Drawing.Point(3, 3);
            this.pictureInput.Name = "pictureInput";
            this.pictureInput.Size = new System.Drawing.Size(519, 344);
            this.pictureInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureInput.TabIndex = 2;
            this.pictureInput.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureInput);
            this.panel1.Location = new System.Drawing.Point(307, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 459);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveColor;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureInput;
        private System.Windows.Forms.Panel panel1;
    }
}

