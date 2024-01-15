
namespace Sweng_example_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_fill = new System.Windows.Forms.CheckBox();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.trackBar_grn = new System.Windows.Forms.TrackBar();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_grn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.checkBox_fill);
            this.panel1.Controls.Add(this.trackBar_blue);
            this.panel1.Controls.Add(this.trackBar_grn);
            this.panel1.Controls.Add(this.trackBar_red);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 179);
            this.panel1.TabIndex = 0;
            // 
            // checkBox_fill
            // 
            this.checkBox_fill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_fill.AutoSize = true;
            this.checkBox_fill.Location = new System.Drawing.Point(16, 101);
            this.checkBox_fill.Name = "checkBox_fill";
            this.checkBox_fill.Size = new System.Drawing.Size(72, 29);
            this.checkBox_fill.TabIndex = 9;
            this.checkBox_fill.Text = "Fill";
            this.checkBox_fill.UseVisualStyleBackColor = true;
            this.checkBox_fill.CheckedChanged += new System.EventHandler(this.checkBox_fill_CheckedChanged);
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_blue.BackColor = System.Drawing.Color.Blue;
            this.trackBar_blue.Location = new System.Drawing.Point(1113, 12);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(202, 90);
            this.trackBar_blue.TabIndex = 8;
            this.trackBar_blue.Value = 150;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_blue_Scroll);
            // 
            // trackBar_grn
            // 
            this.trackBar_grn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_grn.BackColor = System.Drawing.Color.Green;
            this.trackBar_grn.Location = new System.Drawing.Point(895, 12);
            this.trackBar_grn.Maximum = 255;
            this.trackBar_grn.Name = "trackBar_grn";
            this.trackBar_grn.Size = new System.Drawing.Size(202, 90);
            this.trackBar_grn.TabIndex = 4;
            this.trackBar_grn.Value = 75;
            this.trackBar_grn.Scroll += new System.EventHandler(this.trackBar_grn_Scroll);
            // 
            // trackBar_red
            // 
            this.trackBar_red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_red.BackColor = System.Drawing.Color.Red;
            this.trackBar_red.Location = new System.Drawing.Point(682, 12);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(202, 90);
            this.trackBar_red.TabIndex = 3;
            this.trackBar_red.Value = 75;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_red_Scroll);
            // 
            // btn_line
            // 
            this.btn_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_line.Location = new System.Drawing.Point(189, 12);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(145, 56);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rect.Location = new System.Drawing.Point(519, 12);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(145, 56);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rect";
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ellipse.Location = new System.Drawing.Point(347, 12);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(145, 56);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "ellipse";
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eraser.Location = new System.Drawing.Point(202, 86);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(122, 44);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "eraser";
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pencil.Location = new System.Drawing.Point(16, 12);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(145, 56);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Free Draw";
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 780);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1553, 10);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1553, 790);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1553, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_grn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.TrackBar trackBar_grn;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.CheckBox checkBox_fill;
    }
}

