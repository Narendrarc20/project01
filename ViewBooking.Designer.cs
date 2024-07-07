namespace AdvancedRoomBookingSystemCSharp
{
    partial class ViewBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooking));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookrBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roombookDataSet2 = new AdvancedRoomBookingSystemCSharp.roombookDataSet2();
            this.bookrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDataSet1 = new AdvancedRoomBookingSystemCSharp.roomDataSet1();
            this.bookrTableAdapter = new AdvancedRoomBookingSystemCSharp.roomDataSet1TableAdapters.bookrTableAdapter();
            this.bookrTableAdapter1 = new AdvancedRoomBookingSystemCSharp.roombookDataSet2TableAdapters.bookrTableAdapter();
            this.roombookDataSet3 = new AdvancedRoomBookingSystemCSharp.roombookDataSet3();
            this.bookrBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookrTableAdapter2 = new AdvancedRoomBookingSystemCSharp.roombookDataSet3TableAdapters.bookrTableAdapter();
            this.roombookDataSet4 = new AdvancedRoomBookingSystemCSharp.roombookDataSet4();
            this.bookrBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookrTableAdapter3 = new AdvancedRoomBookingSystemCSharp.roombookDataSet4TableAdapters.bookrTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1081, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(228, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 31);
            this.label3.TabIndex = 82;
            this.label3.Text = "View Room Booking";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(349, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 26);
            this.textBox1.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Enter Booking Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 96;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 95;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fromdDataGridViewTextBoxColumn,
            this.todDataGridViewTextBoxColumn,
            this.roomnoDataGridViewTextBoxColumn,
            this.nopeopleDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookrBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(41, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(721, 261);
            this.dataGridView1.TabIndex = 97;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fromdDataGridViewTextBoxColumn
            // 
            this.fromdDataGridViewTextBoxColumn.DataPropertyName = "fromd";
            this.fromdDataGridViewTextBoxColumn.HeaderText = "fromd";
            this.fromdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fromdDataGridViewTextBoxColumn.Name = "fromdDataGridViewTextBoxColumn";
            this.fromdDataGridViewTextBoxColumn.Width = 125;
            // 
            // todDataGridViewTextBoxColumn
            // 
            this.todDataGridViewTextBoxColumn.DataPropertyName = "tod";
            this.todDataGridViewTextBoxColumn.HeaderText = "tod";
            this.todDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.todDataGridViewTextBoxColumn.Name = "todDataGridViewTextBoxColumn";
            this.todDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomnoDataGridViewTextBoxColumn
            // 
            this.roomnoDataGridViewTextBoxColumn.DataPropertyName = "roomno";
            this.roomnoDataGridViewTextBoxColumn.HeaderText = "roomno";
            this.roomnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnoDataGridViewTextBoxColumn.Name = "roomnoDataGridViewTextBoxColumn";
            this.roomnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nopeopleDataGridViewTextBoxColumn
            // 
            this.nopeopleDataGridViewTextBoxColumn.DataPropertyName = "nopeople";
            this.nopeopleDataGridViewTextBoxColumn.HeaderText = "nopeople";
            this.nopeopleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nopeopleDataGridViewTextBoxColumn.Name = "nopeopleDataGridViewTextBoxColumn";
            this.nopeopleDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            this.addrDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookrBindingSource1
            // 
            this.bookrBindingSource1.DataMember = "bookr";
            this.bookrBindingSource1.DataSource = this.roombookDataSet2;
            // 
            // roombookDataSet2
            // 
            this.roombookDataSet2.DataSetName = "roombookDataSet2";
            this.roombookDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrBindingSource
            // 
            this.bookrBindingSource.DataMember = "bookr";
            this.bookrBindingSource.DataSource = this.roomDataSet1;
            // 
            // roomDataSet1
            // 
            this.roomDataSet1.DataSetName = "roomDataSet1";
            this.roomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrTableAdapter
            // 
            this.bookrTableAdapter.ClearBeforeFill = true;
            // 
            // bookrTableAdapter1
            // 
            this.bookrTableAdapter1.ClearBeforeFill = true;
            // 
            // roombookDataSet3
            // 
            this.roombookDataSet3.DataSetName = "roombookDataSet3";
            this.roombookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrBindingSource2
            // 
            this.bookrBindingSource2.DataMember = "bookr";
            this.bookrBindingSource2.DataSource = this.roombookDataSet3;
            // 
            // bookrTableAdapter2
            // 
            this.bookrTableAdapter2.ClearBeforeFill = true;
            // 
            // roombookDataSet4
            // 
            this.roombookDataSet4.DataSetName = "roombookDataSet4";
            this.roombookDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrBindingSource3
            // 
            this.bookrBindingSource3.DataMember = "bookr";
            this.bookrBindingSource3.DataSource = this.roombookDataSet4;
            // 
            // bookrTableAdapter3
            // 
            this.bookrTableAdapter3.ClearBeforeFill = true;
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewBooking";
            this.Text = "ViewBooking";
            this.Load += new System.EventHandler(this.ViewBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private roomDataSet1 roomDataSet1;
        private System.Windows.Forms.BindingSource bookrBindingSource;
        private roomDataSet1TableAdapters.bookrTableAdapter bookrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private roombookDataSet2 roombookDataSet2;
        private System.Windows.Forms.BindingSource bookrBindingSource1;
        private roombookDataSet2TableAdapters.bookrTableAdapter bookrTableAdapter1;
        private roombookDataSet3 roombookDataSet3;
        private System.Windows.Forms.BindingSource bookrBindingSource2;
        private roombookDataSet3TableAdapters.bookrTableAdapter bookrTableAdapter2;
        private roombookDataSet4 roombookDataSet4;
        private System.Windows.Forms.BindingSource bookrBindingSource3;
        private roombookDataSet4TableAdapters.bookrTableAdapter bookrTableAdapter3;
    }
}