namespace Testing1
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
            this.txt_CarName = new System.Windows.Forms.TextBox();
            this.txt_CarNumber = new System.Windows.Forms.TextBox();
            this.txt_CarAvailability = new System.Windows.Forms.TextBox();
            this.lbl_CarName = new System.Windows.Forms.Label();
            this.lbl_CarNumber = new System.Windows.Forms.Label();
            this.lbl_CarAvailability = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_CarLocation = new System.Windows.Forms.Label();
            this.txt_CarLocation = new System.Windows.Forms.TextBox();
            this.lbl_CarNewName = new System.Windows.Forms.Label();
            this.txt_CarNewName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CarName
            // 
            this.txt_CarName.Location = new System.Drawing.Point(186, 88);
            this.txt_CarName.Name = "txt_CarName";
            this.txt_CarName.Size = new System.Drawing.Size(154, 20);
            this.txt_CarName.TabIndex = 0;
            // 
            // txt_CarNumber
            // 
            this.txt_CarNumber.Location = new System.Drawing.Point(186, 165);
            this.txt_CarNumber.Name = "txt_CarNumber";
            this.txt_CarNumber.Size = new System.Drawing.Size(154, 20);
            this.txt_CarNumber.TabIndex = 1;
            // 
            // txt_CarAvailability
            // 
            this.txt_CarAvailability.Location = new System.Drawing.Point(186, 243);
            this.txt_CarAvailability.Name = "txt_CarAvailability";
            this.txt_CarAvailability.Size = new System.Drawing.Size(154, 20);
            this.txt_CarAvailability.TabIndex = 2;
            // 
            // lbl_CarName
            // 
            this.lbl_CarName.AutoSize = true;
            this.lbl_CarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarName.Location = new System.Drawing.Point(92, 92);
            this.lbl_CarName.Name = "lbl_CarName";
            this.lbl_CarName.Size = new System.Drawing.Size(77, 16);
            this.lbl_CarName.TabIndex = 3;
            this.lbl_CarName.Text = "Car Name";
            // 
            // lbl_CarNumber
            // 
            this.lbl_CarNumber.AutoSize = true;
            this.lbl_CarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarNumber.Location = new System.Drawing.Point(79, 169);
            this.lbl_CarNumber.Name = "lbl_CarNumber";
            this.lbl_CarNumber.Size = new System.Drawing.Size(90, 16);
            this.lbl_CarNumber.TabIndex = 4;
            this.lbl_CarNumber.Text = "Car Number";
            // 
            // lbl_CarAvailability
            // 
            this.lbl_CarAvailability.AutoSize = true;
            this.lbl_CarAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarAvailability.Location = new System.Drawing.Point(56, 247);
            this.lbl_CarAvailability.Name = "lbl_CarAvailability";
            this.lbl_CarAvailability.Size = new System.Drawing.Size(113, 16);
            this.lbl_CarAvailability.TabIndex = 5;
            this.lbl_CarAvailability.Text = "Car Availability";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Navy;
            this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Insert.Location = new System.Drawing.Point(62, 306);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(87, 23);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Navy;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.Location = new System.Drawing.Point(62, 385);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Navy;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Location = new System.Drawing.Point(62, 346);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Display
            // 
            this.btn_Display.BackColor = System.Drawing.Color.Navy;
            this.btn_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Display.Location = new System.Drawing.Point(608, 306);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(105, 23);
            this.btn_Display.TabIndex = 9;
            this.btn_Display.Text = "Display All";
            this.btn_Display.UseVisualStyleBackColor = false;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 202);
            this.dataGridView1.TabIndex = 10;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_title.Location = new System.Drawing.Point(268, 22);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(259, 31);
            this.lbl_title.TabIndex = 11;
            this.lbl_title.Text = "Car Rental System";
            // 
            // lbl_CarLocation
            // 
            this.lbl_CarLocation.AutoSize = true;
            this.lbl_CarLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarLocation.Location = new System.Drawing.Point(74, 207);
            this.lbl_CarLocation.Name = "lbl_CarLocation";
            this.lbl_CarLocation.Size = new System.Drawing.Size(95, 16);
            this.lbl_CarLocation.TabIndex = 12;
            this.lbl_CarLocation.Text = "Car Location";
            // 
            // txt_CarLocation
            // 
            this.txt_CarLocation.Location = new System.Drawing.Point(186, 203);
            this.txt_CarLocation.Name = "txt_CarLocation";
            this.txt_CarLocation.Size = new System.Drawing.Size(154, 20);
            this.txt_CarLocation.TabIndex = 13;
            // 
            // lbl_CarNewName
            // 
            this.lbl_CarNewName.AutoSize = true;
            this.lbl_CarNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarNewName.Location = new System.Drawing.Point(58, 130);
            this.lbl_CarNewName.Name = "lbl_CarNewName";
            this.lbl_CarNewName.Size = new System.Drawing.Size(111, 16);
            this.lbl_CarNewName.TabIndex = 15;
            this.lbl_CarNewName.Text = "Car New Name";
            // 
            // txt_CarNewName
            // 
            this.txt_CarNewName.Location = new System.Drawing.Point(186, 126);
            this.txt_CarNewName.Name = "txt_CarNewName";
            this.txt_CarNewName.Size = new System.Drawing.Size(154, 20);
            this.txt_CarNewName.TabIndex = 14;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Navy;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Location = new System.Drawing.Point(62, 424);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 23);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "(Only enter values in Car Name, Car Number, Car Location, Car Availability to Ins" +
    "ert)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Only enter values in Car Name and Car New Name to update Car name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "(Only enter values in Car Name to delete that record)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "(Only enter values in Car Name to search that record)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Testing1.Properties.Resources.New1;
            this.pictureBox1.Location = new System.Drawing.Point(533, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 80);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(871, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_CarNewName);
            this.Controls.Add(this.txt_CarNewName);
            this.Controls.Add(this.txt_CarLocation);
            this.Controls.Add(this.lbl_CarLocation);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.lbl_CarAvailability);
            this.Controls.Add(this.lbl_CarNumber);
            this.Controls.Add(this.lbl_CarName);
            this.Controls.Add(this.txt_CarAvailability);
            this.Controls.Add(this.txt_CarNumber);
            this.Controls.Add(this.txt_CarName);
            this.Name = "Form1";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CarName;
        private System.Windows.Forms.TextBox txt_CarNumber;
        private System.Windows.Forms.TextBox txt_CarAvailability;
        private System.Windows.Forms.Label lbl_CarName;
        private System.Windows.Forms.Label lbl_CarNumber;
        private System.Windows.Forms.Label lbl_CarAvailability;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_CarLocation;
        private System.Windows.Forms.TextBox txt_CarLocation;
        private System.Windows.Forms.Label lbl_CarNewName;
        private System.Windows.Forms.TextBox txt_CarNewName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

