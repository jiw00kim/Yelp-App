namespace YelpApp
{
    partial class NumsByTips
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
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNumTips = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumTips)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // dataGridViewNumTips
            // 
            this.dataGridViewNumTips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumTips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.UserName,
            this.likes,
            this.Text});
            this.dataGridViewNumTips.Location = new System.Drawing.Point(1, 164);
            this.dataGridViewNumTips.Name = "dataGridViewNumTips";
            this.dataGridViewNumTips.RowHeadersWidth = 51;
            this.dataGridViewNumTips.RowTemplate.Height = 29;
            this.dataGridViewNumTips.Size = new System.Drawing.Size(798, 217);
            this.dataGridViewNumTips.TabIndex = 0;
            this.dataGridViewNumTips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNumTips_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // likes
            // 
            this.likes.HeaderText = "likes";
            this.likes.MinimumWidth = 6;
            this.likes.Name = "likes";
            this.likes.Width = 125;
            // 
            // Text
            // 
            this.Text.HeaderText = "Text";
            this.Text.MinimumWidth = 6;
            this.Text.Name = "Text";
            this.Text.Width = 380;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 78);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // AddTipButton
            // 
            this.AddTipButton.Location = new System.Drawing.Point(638, 21);
            this.AddTipButton.Name = "AddTipButton";
            this.AddTipButton.Size = new System.Drawing.Size(140, 57);
            this.AddTipButton.TabIndex = 3;
            this.AddTipButton.Text = "Add Tip";
            this.AddTipButton.UseVisualStyleBackColor = true;
            this.AddTipButton.Click += new System.EventHandler(this.AddTipButton_Click);
            // 
            // NumsByTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTipButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewNumTips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NumsByTips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NumsByTips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumTips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn Date;
        private DataGridView dataGridViewNumTips;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn likes;
        private DataGridViewTextBoxColumn Text;
        private TextBox textBox1;
        private Label label1;
        private Button AddTipButton;
    }
}