namespace ImageCropTool
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
            this.filepathLabel = new System.Windows.Forms.Label();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Box10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Location = new System.Drawing.Point(179, 173);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(85, 13);
            this.filepathLabel.TabIndex = 8;
            this.filepathLabel.Text = "No File Selected";
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(82, 168);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(90, 23);
            this.SelectImageButton.TabIndex = 9;
            this.SelectImageButton.Text = "Select Image";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(1100, 545);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titles,
            this.Box1,
            this.Box2,
            this.Box3,
            this.Box4,
            this.Box5,
            this.Box6,
            this.Box7,
            this.Box8,
            this.Box9,
            this.Box10});
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 225);
            this.dataGridView1.TabIndex = 11;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Titles
            // 
            this.Titles.HeaderText = "Titles";
            this.Titles.Name = "Titles";
            this.Titles.ReadOnly = true;
            // 
            // Box1
            // 
            this.Box1.HeaderText = "Box1";
            this.Box1.Name = "Box1";
            // 
            // Box2
            // 
            this.Box2.HeaderText = "Box2";
            this.Box2.Name = "Box2";
            // 
            // Box3
            // 
            this.Box3.HeaderText = "Box3";
            this.Box3.Name = "Box3";
            // 
            // Box4
            // 
            this.Box4.HeaderText = "Box4";
            this.Box4.Name = "Box4";
            // 
            // Box5
            // 
            this.Box5.HeaderText = "Box5";
            this.Box5.Name = "Box5";
            // 
            // Box6
            // 
            this.Box6.HeaderText = "Box6";
            this.Box6.Name = "Box6";
            // 
            // Box7
            // 
            this.Box7.HeaderText = "Box7";
            this.Box7.Name = "Box7";
            // 
            // Box8
            // 
            this.Box8.HeaderText = "Box8";
            this.Box8.Name = "Box8";
            // 
            // Box9
            // 
            this.Box9.HeaderText = "Box9";
            this.Box9.Name = "Box9";
            // 
            // Box10
            // 
            this.Box10.HeaderText = "Box10";
            this.Box10.Name = "Box10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.filepathLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label filepathLabel;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box10;
    }
}

