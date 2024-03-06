
namespace Pete_s_Auto_Body_Managemnet_App
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            panel1 = new Panel();
            panel3 = new Panel();
            CarDGV = new DataGridView();
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            CDate = new DateTimePicker();
            label8 = new Label();
            OwnerNameTb = new RichTextBox();
            ColorTb = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            CarModelTb = new RichTextBox();
            CarBrandTb = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            CarNumTb = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            label16 = new Label();
            pictureBox7 = new PictureBox();
            label15 = new Label();
            pictureBox6 = new PictureBox();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 671);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(CarDGV);
            panel3.Controls.Add(DeleteBtn);
            panel3.Controls.Add(EditBtn);
            panel3.Controls.Add(AddBtn);
            panel3.Controls.Add(CDate);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(OwnerNameTb);
            panel3.Controls.Add(ColorTb);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(CarModelTb);
            panel3.Controls.Add(CarBrandTb);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(CarNumTb);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(225, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 539);
            panel3.TabIndex = 1;
            // 
            // CarDGV
            // 
            CarDGV.BackgroundColor = Color.White;
            CarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDGV.Location = new Point(3, 321);
            CarDGV.Name = "CarDGV";
            CarDGV.Size = new Size(964, 215);
            CarDGV.TabIndex = 18;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Firebrick;
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(553, 263);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(126, 42);
            DeleteBtn.TabIndex = 17;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.DodgerBlue;
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(386, 263);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(126, 42);
            EditBtn.TabIndex = 16;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.SeaGreen;
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(214, 263);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(126, 42);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // CDate
            // 
            CDate.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CDate.Format = DateTimePickerFormat.Short;
            CDate.Location = new Point(719, 86);
            CDate.Name = "CDate";
            CDate.Size = new Size(158, 21);
            CDate.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(408, 151);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 13;
            label8.Text = "Owner Name";
            // 
            // OwnerNameTb
            // 
            OwnerNameTb.Location = new Point(408, 177);
            OwnerNameTb.Name = "OwnerNameTb";
            OwnerNameTb.Size = new Size(162, 67);
            OwnerNameTb.TabIndex = 12;
            OwnerNameTb.Text = "";
            // 
            // ColorTb
            // 
            ColorTb.Location = new Point(214, 177);
            ColorTb.Name = "ColorTb";
            ColorTb.Size = new Size(162, 67);
            ColorTb.TabIndex = 11;
            ColorTb.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(214, 151);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 10;
            label7.Text = "Car Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(408, 43);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 9;
            label6.Text = "Car Model";
            // 
            // CarModelTb
            // 
            CarModelTb.Location = new Point(408, 69);
            CarModelTb.Name = "CarModelTb";
            CarModelTb.Size = new Size(162, 67);
            CarModelTb.TabIndex = 8;
            CarModelTb.Text = "";
            // 
            // CarBrandTb
            // 
            CarBrandTb.Location = new Point(214, 69);
            CarBrandTb.Name = "CarBrandTb";
            CarBrandTb.Size = new Size(162, 67);
            CarBrandTb.TabIndex = 7;
            CarBrandTb.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(214, 43);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 6;
            label5.Text = "Car Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(22, 43);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 5;
            label4.Text = "Car Number";
            // 
            // CarNumTb
            // 
            CarNumTb.Location = new Point(22, 69);
            CarNumTb.Name = "CarNumTb";
            CarNumTb.Size = new Size(162, 67);
            CarNumTb.TabIndex = 4;
            CarNumTb.Text = "";
            CarNumTb.TextChanged += CarNumTb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 33);
            label3.TabIndex = 2;
            label3.Text = "Car Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(225, 20);
            label2.Name = "label2";
            label2.Size = new Size(239, 33);
            label2.TabIndex = 0;
            label2.Text = "Record Cars for Servicing";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1064, 20);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1045, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 671);
            panel2.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(4, 502);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(57, 54);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 33;
            pictureBox8.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(76, 511);
            label16.Name = "label16";
            label16.Size = new Size(74, 33);
            label16.TabIndex = 32;
            label16.Text = "Logout";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-15, 370);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(85, 72);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 31;
            pictureBox7.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(67, 392);
            label15.Name = "label15";
            label15.Size = new Size(97, 33);
            label15.TabIndex = 30;
            label15.Text = "Analytics";
            label15.Click += label15_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 310);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(67, 329);
            label14.Name = "label14";
            label14.Size = new Size(70, 33);
            label14.TabIndex = 28;
            label14.Text = "Billing";
            label14.Click += label14_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, 244);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(53, 261);
            label13.Name = "label13";
            label13.Size = new Size(110, 33);
            label13.TabIndex = 26;
            label13.Text = "Employees";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.LightSkyBlue;
            label12.Location = new Point(53, 137);
            label12.Name = "label12";
            label12.Size = new Size(55, 33);
            label12.TabIndex = 24;
            label12.Text = "Cars";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-6, 189);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(53, 196);
            label11.Name = "label11";
            label11.Size = new Size(65, 33);
            label11.TabIndex = 22;
            label11.Text = "Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(76, 72);
            label10.Name = "label10";
            label10.Size = new Size(63, 33);
            label10.TabIndex = 21;
            label10.Text = "MENU";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSkyBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(53, 9);
            label9.Name = "label9";
            label9.Size = new Size(111, 33);
            label9.TabIndex = 19;
            label9.Text = "Garage MS";
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 671);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cars";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CarDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void CarNumTb_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private RichTextBox CarNumTb;
        private Label label4;
        private DateTimePicker CDate;
        private Label label8;
        private RichTextBox OwnerNameTb;
        private RichTextBox ColorTb;
        private Label label7;
        private Label label6;
        private RichTextBox CarModelTb;
        private RichTextBox CarBrandTb;
        private Label label5;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private DataGridView CarDGV;
        private Label label9;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label12;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label14;
        private PictureBox pictureBox5;
        private Label label13;
        private PictureBox pictureBox7;
        private Label label15;
        private PictureBox pictureBox8;
        private Label label16;
    }
}
