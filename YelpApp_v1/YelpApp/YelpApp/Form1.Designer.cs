namespace YelpApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NumTipsButton = new System.Windows.Forms.Button();
            this.dataGridViewBusiness = new System.Windows.Forms.DataGridView();
            this.ColumnBusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumTIps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalCheckins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxZipcode = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(14, 4);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1336, 767);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumTipsButton);
            this.tabPage1.Controls.Add(this.dataGridViewBusiness);
            this.tabPage1.Controls.Add(this.listBoxCategory);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listBoxZipcode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBoxCity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxState);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1328, 734);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Business Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NumTipsButton
            // 
            this.NumTipsButton.Location = new System.Drawing.Point(1038, 611);
            this.NumTipsButton.Name = "NumTipsButton";
            this.NumTipsButton.Size = new System.Drawing.Size(199, 116);
            this.NumTipsButton.TabIndex = 10;
            this.NumTipsButton.Text = "NumTipsButton";
            this.NumTipsButton.UseVisualStyleBackColor = true;
            this.NumTipsButton.Click += new System.EventHandler(this.NumTipsButton_Click);
            // 
            // dataGridViewBusiness
            // 
            this.dataGridViewBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusiness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBusinessName,
            this.ColumnAddress,
            this.ColumnCity,
            this.ColumnState,
            this.ColumnDistance,
            this.ColumnStars,
            this.ColumnNumTIps,
            this.ColumnTotalCheckins});
            this.dataGridViewBusiness.Location = new System.Drawing.Point(151, 93);
            this.dataGridViewBusiness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBusiness.Name = "dataGridViewBusiness";
            this.dataGridViewBusiness.RowHeadersWidth = 51;
            this.dataGridViewBusiness.RowTemplate.Height = 25;
            this.dataGridViewBusiness.Size = new System.Drawing.Size(965, 469);
            this.dataGridViewBusiness.TabIndex = 9;
            // 
            // ColumnBusinessName
            // 
            this.ColumnBusinessName.HeaderText = "BusinessName";
            this.ColumnBusinessName.MinimumWidth = 6;
            this.ColumnBusinessName.Name = "ColumnBusinessName";
            this.ColumnBusinessName.Width = 125;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 6;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 125;
            // 
            // ColumnCity
            // 
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.MinimumWidth = 6;
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.Width = 125;
            // 
            // ColumnState
            // 
            this.ColumnState.HeaderText = "State";
            this.ColumnState.MinimumWidth = 6;
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.Width = 125;
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.HeaderText = "Distance";
            this.ColumnDistance.MinimumWidth = 6;
            this.ColumnDistance.Name = "ColumnDistance";
            this.ColumnDistance.Width = 125;
            // 
            // ColumnStars
            // 
            this.ColumnStars.HeaderText = "Stars";
            this.ColumnStars.MinimumWidth = 6;
            this.ColumnStars.Name = "ColumnStars";
            this.ColumnStars.Width = 125;
            // 
            // ColumnNumTIps
            // 
            this.ColumnNumTIps.HeaderText = "# of Tips";
            this.ColumnNumTIps.MinimumWidth = 6;
            this.ColumnNumTIps.Name = "ColumnNumTIps";
            this.ColumnNumTIps.Width = 125;
            // 
            // ColumnTotalCheckins
            // 
            this.ColumnTotalCheckins.HeaderText = "TotalCheckins";
            this.ColumnTotalCheckins.MinimumWidth = 6;
            this.ColumnTotalCheckins.Name = "ColumnTotalCheckins";
            this.ColumnTotalCheckins.Width = 125;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 20;
            this.listBoxCategory.Location = new System.Drawing.Point(7, 437);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(137, 124);
            this.listBoxCategory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Business Category";
            // 
            // listBoxZipcode
            // 
            this.listBoxZipcode.FormattingEnabled = true;
            this.listBoxZipcode.ItemHeight = 20;
            this.listBoxZipcode.Location = new System.Drawing.Point(7, 264);
            this.listBoxZipcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxZipcode.Name = "listBoxZipcode";
            this.listBoxZipcode.Size = new System.Drawing.Size(137, 124);
            this.listBoxZipcode.TabIndex = 6;
            this.listBoxZipcode.SelectedIndexChanged += new System.EventHandler(this.listBoxZipcode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zipcode";
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 20;
            this.listBoxCity.Location = new System.Drawing.Point(7, 93);
            this.listBoxCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(137, 124);
            this.listBoxCity.TabIndex = 4;
            this.listBoxCity.SelectedIndexChanged += new System.EventHandler(this.listBoxCity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "State";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(51, 8);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(138, 28);
            this.comboBoxState.TabIndex = 1;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxState_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1328, 734);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BusinessName
            // 
            this.BusinessName.HeaderText = "BusinessName";
            this.BusinessName.MinimumWidth = 6;
            this.BusinessName.Name = "BusinessName";
            this.BusinessName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "BusinessName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "State";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "BusinessName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "BusinessName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "State";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance(miles)";
            this.Distance.MinimumWidth = 6;
            this.Distance.Name = "Distance";
            this.Distance.Width = 125;
            // 
            // Stars
            // 
            this.Stars.HeaderText = "Stars";
            this.Stars.MinimumWidth = 6;
            this.Stars.Name = "Stars";
            this.Stars.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 787);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Yelp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusiness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBoxState;
        private Label label1;
        private Label label2;
        private ListBox listBoxCity;
        private ListBox listBoxZipcode;
        private Label label3;
        private ListBox listBoxCategory;
        private Label label4;
        private DataGridView dataGridViewBusiness;
        private DataGridViewTextBoxColumn ColumnBusinessName;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnCity;
        private DataGridViewTextBoxColumn ColumnState;
        private DataGridViewTextBoxColumn ColumnDistance;
        private DataGridViewTextBoxColumn ColumnStars;
        private DataGridViewTextBoxColumn ColumnNumTIps;
        private DataGridViewTextBoxColumn ColumnTotalCheckins;
        private DataGridViewTextBoxColumn BusinessName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn Distance;
        private DataGridViewTextBoxColumn Stars;
        private Button NumTipsButton;
    }
}