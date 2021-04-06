
namespace lab1PictureBox
{
    partial class dogPictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dogPictureForm));
            this.dogPictureLabel = new System.Windows.Forms.Label();
            this.onePictureBox = new System.Windows.Forms.PictureBox();
            this.twoPictureBox = new System.Windows.Forms.PictureBox();
            this.threePictureBox = new System.Windows.Forms.PictureBox();
            this.fourPictureBox = new System.Windows.Forms.PictureBox();
            this.fivePictureBox = new System.Windows.Forms.PictureBox();
            this.pressMeOneLabel = new System.Windows.Forms.Label();
            this.pressMeTwoLabel = new System.Windows.Forms.Label();
            this.pressMeThreeLabel = new System.Windows.Forms.Label();
            this.pressMeFourLabel = new System.Windows.Forms.Label();
            this.pressMeFiveLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dogToolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPictureLabel
            // 
            this.dogPictureLabel.AutoSize = true;
            this.dogPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogPictureLabel.ForeColor = System.Drawing.Color.Teal;
            this.dogPictureLabel.Location = new System.Drawing.Point(738, 122);
            this.dogPictureLabel.Name = "dogPictureLabel";
            this.dogPictureLabel.Size = new System.Drawing.Size(873, 126);
            this.dogPictureLabel.TabIndex = 0;
            this.dogPictureLabel.Text = "Dog Picture Box";
            this.dogPictureLabel.Click += new System.EventHandler(this.dogPictureLabel_Click);
            // 
            // onePictureBox
            // 
            this.onePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("onePictureBox.Image")));
            this.onePictureBox.Location = new System.Drawing.Point(55, 374);
            this.onePictureBox.Name = "onePictureBox";
            this.onePictureBox.Size = new System.Drawing.Size(414, 302);
            this.onePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onePictureBox.TabIndex = 1;
            this.onePictureBox.TabStop = false;
            this.dogToolTips.SetToolTip(this.onePictureBox, "One dog");
            this.onePictureBox.Visible = false;
            this.onePictureBox.Click += new System.EventHandler(this.onePictureBox_Click);
            // 
            // twoPictureBox
            // 
            this.twoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("twoPictureBox.Image")));
            this.twoPictureBox.Location = new System.Drawing.Point(511, 374);
            this.twoPictureBox.Name = "twoPictureBox";
            this.twoPictureBox.Size = new System.Drawing.Size(414, 302);
            this.twoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoPictureBox.TabIndex = 2;
            this.twoPictureBox.TabStop = false;
            this.dogToolTips.SetToolTip(this.twoPictureBox, "Two dogs");
            this.twoPictureBox.Visible = false;
            this.twoPictureBox.Click += new System.EventHandler(this.twoPictureBox_Click);
            // 
            // threePictureBox
            // 
            this.threePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("threePictureBox.Image")));
            this.threePictureBox.Location = new System.Drawing.Point(967, 374);
            this.threePictureBox.Name = "threePictureBox";
            this.threePictureBox.Size = new System.Drawing.Size(414, 302);
            this.threePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threePictureBox.TabIndex = 3;
            this.threePictureBox.TabStop = false;
            this.dogToolTips.SetToolTip(this.threePictureBox, "Three dogs");
            this.threePictureBox.Visible = false;
            // 
            // fourPictureBox
            // 
            this.fourPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fourPictureBox.Image")));
            this.fourPictureBox.Location = new System.Drawing.Point(1423, 374);
            this.fourPictureBox.Name = "fourPictureBox";
            this.fourPictureBox.Size = new System.Drawing.Size(414, 302);
            this.fourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourPictureBox.TabIndex = 4;
            this.fourPictureBox.TabStop = false;
            this.dogToolTips.SetToolTip(this.fourPictureBox, "Four dogs");
            this.fourPictureBox.Visible = false;
            // 
            // fivePictureBox
            // 
            this.fivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fivePictureBox.Image")));
            this.fivePictureBox.Location = new System.Drawing.Point(1879, 374);
            this.fivePictureBox.Name = "fivePictureBox";
            this.fivePictureBox.Size = new System.Drawing.Size(414, 302);
            this.fivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fivePictureBox.TabIndex = 5;
            this.fivePictureBox.TabStop = false;
            this.dogToolTips.SetToolTip(this.fivePictureBox, "Five dogs");
            this.fivePictureBox.Visible = false;
            this.fivePictureBox.Click += new System.EventHandler(this.fivePictureBox_Click);
            // 
            // pressMeOneLabel
            // 
            this.pressMeOneLabel.AutoSize = true;
            this.pressMeOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMeOneLabel.ForeColor = System.Drawing.Color.Navy;
            this.pressMeOneLabel.Location = new System.Drawing.Point(139, 718);
            this.pressMeOneLabel.Name = "pressMeOneLabel";
            this.pressMeOneLabel.Size = new System.Drawing.Size(227, 55);
            this.pressMeOneLabel.TabIndex = 6;
            this.pressMeOneLabel.Text = "Press Me";
            this.pressMeOneLabel.Click += new System.EventHandler(this.pressMeOneLabel_Click);
            // 
            // pressMeTwoLabel
            // 
            this.pressMeTwoLabel.AutoSize = true;
            this.pressMeTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMeTwoLabel.ForeColor = System.Drawing.Color.Navy;
            this.pressMeTwoLabel.Location = new System.Drawing.Point(600, 718);
            this.pressMeTwoLabel.Name = "pressMeTwoLabel";
            this.pressMeTwoLabel.Size = new System.Drawing.Size(227, 55);
            this.pressMeTwoLabel.TabIndex = 7;
            this.pressMeTwoLabel.Text = "Press Me";
            this.pressMeTwoLabel.Click += new System.EventHandler(this.pressMeTwoLabel_Click);
            // 
            // pressMeThreeLabel
            // 
            this.pressMeThreeLabel.AutoSize = true;
            this.pressMeThreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMeThreeLabel.ForeColor = System.Drawing.Color.Navy;
            this.pressMeThreeLabel.Location = new System.Drawing.Point(1061, 718);
            this.pressMeThreeLabel.Name = "pressMeThreeLabel";
            this.pressMeThreeLabel.Size = new System.Drawing.Size(227, 55);
            this.pressMeThreeLabel.TabIndex = 8;
            this.pressMeThreeLabel.Text = "Press Me";
            this.pressMeThreeLabel.Click += new System.EventHandler(this.pressMeThreeLabel_Click);
            // 
            // pressMeFourLabel
            // 
            this.pressMeFourLabel.AutoSize = true;
            this.pressMeFourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMeFourLabel.ForeColor = System.Drawing.Color.Navy;
            this.pressMeFourLabel.Location = new System.Drawing.Point(1522, 718);
            this.pressMeFourLabel.Name = "pressMeFourLabel";
            this.pressMeFourLabel.Size = new System.Drawing.Size(227, 55);
            this.pressMeFourLabel.TabIndex = 9;
            this.pressMeFourLabel.Text = "Press Me";
            this.pressMeFourLabel.Click += new System.EventHandler(this.pressMeFourLabel_Click);
            // 
            // pressMeFiveLabel
            // 
            this.pressMeFiveLabel.AutoSize = true;
            this.pressMeFiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressMeFiveLabel.ForeColor = System.Drawing.Color.Navy;
            this.pressMeFiveLabel.Location = new System.Drawing.Point(1983, 718);
            this.pressMeFiveLabel.Name = "pressMeFiveLabel";
            this.pressMeFiveLabel.Size = new System.Drawing.Size(227, 55);
            this.pressMeFiveLabel.TabIndex = 10;
            this.pressMeFiveLabel.Text = "Press Me";
            this.pressMeFiveLabel.Click += new System.EventHandler(this.pressMeFiveLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(888, 944);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(202, 76);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "&Clear";
            this.dogToolTips.SetToolTip(this.clearButton, "This will clear picture");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1258, 944);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(202, 76);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "e&Xit";
            this.dogToolTips.SetToolTip(this.exitButton, "This will exit the program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dogToolTips
            // 
            this.dogToolTips.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dogPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2348, 1370);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pressMeFiveLabel);
            this.Controls.Add(this.pressMeFourLabel);
            this.Controls.Add(this.pressMeThreeLabel);
            this.Controls.Add(this.pressMeTwoLabel);
            this.Controls.Add(this.pressMeOneLabel);
            this.Controls.Add(this.fivePictureBox);
            this.Controls.Add(this.fourPictureBox);
            this.Controls.Add(this.threePictureBox);
            this.Controls.Add(this.twoPictureBox);
            this.Controls.Add(this.onePictureBox);
            this.Controls.Add(this.dogPictureLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dogPictureForm";
            this.Text = "Dog Pictures";
            this.Load += new System.EventHandler(this.dogPictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dogPictureLabel;
        private System.Windows.Forms.PictureBox onePictureBox;
        private System.Windows.Forms.PictureBox twoPictureBox;
        private System.Windows.Forms.PictureBox threePictureBox;
        private System.Windows.Forms.PictureBox fourPictureBox;
        private System.Windows.Forms.PictureBox fivePictureBox;
        private System.Windows.Forms.Label pressMeOneLabel;
        private System.Windows.Forms.Label pressMeTwoLabel;
        private System.Windows.Forms.Label pressMeThreeLabel;
        private System.Windows.Forms.Label pressMeFourLabel;
        private System.Windows.Forms.Label pressMeFiveLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip dogToolTips;
    }
}

