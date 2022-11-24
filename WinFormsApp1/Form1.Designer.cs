namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "New user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(242, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(242, 82);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(131, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(429, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(244, 132);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 20);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location";
            this.locationLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(586, 78);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(63, 24);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(586, 128);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 24);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gender";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(406, 56);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Open file";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(406, 110);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(90, 20);
            this.labelFile.TabIndex = 9;
            this.labelFile.Text = "filename.ext";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label nameLabel;
        private Label emailLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label locationLabel;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label label1;
        private Button buttonOpen;
        private Label labelFile;
    }
}