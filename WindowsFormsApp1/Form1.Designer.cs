﻿namespace WindowsFormsApp1
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
            this.holderTop = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.holderLeft = new System.Windows.Forms.Panel();
            this.btn_rubber = new System.Windows.Forms.Button();
            this.btn_brush = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.holderRight = new System.Windows.Forms.Panel();
            this.btn_pen = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.drawarenapanel = new System.Windows.Forms.Panel();
            this.holderTop.SuspendLayout();
            this.holderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // holderTop
            // 
            this.holderTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.holderTop.Controls.Add(this.btn_save);
            this.holderTop.Controls.Add(this.btn_open);
            this.holderTop.Controls.Add(this.btn_new);
            this.holderTop.Controls.Add(this.btn_minimize);
            this.holderTop.Controls.Add(this.btn_close);
            this.holderTop.Location = new System.Drawing.Point(2, 2);
            this.holderTop.Name = "holderTop";
            this.holderTop.Size = new System.Drawing.Size(799, 40);
            this.holderTop.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(126, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 27);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(65, 3);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(55, 27);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(4, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(55, 28);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Location = new System.Drawing.Point(668, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(63, 31);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "Minimize";
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(737, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(59, 31);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // holderLeft
            // 
            this.holderLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.holderLeft.Controls.Add(this.btn_rubber);
            this.holderLeft.Controls.Add(this.btn_brush);
            this.holderLeft.Controls.Add(this.btn_circle);
            this.holderLeft.Location = new System.Drawing.Point(2, 39);
            this.holderLeft.Name = "holderLeft";
            this.holderLeft.Size = new System.Drawing.Size(59, 410);
            this.holderLeft.TabIndex = 1;
            // 
            // btn_rubber
            // 
            this.btn_rubber.Location = new System.Drawing.Point(4, 278);
            this.btn_rubber.Name = "btn_rubber";
            this.btn_rubber.Size = new System.Drawing.Size(52, 45);
            this.btn_rubber.TabIndex = 3;
            this.btn_rubber.Text = "Rubber";
            this.btn_rubber.UseVisualStyleBackColor = true;
            // 
            // btn_brush
            // 
            this.btn_brush.Location = new System.Drawing.Point(4, 77);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(52, 45);
            this.btn_brush.TabIndex = 0;
            this.btn_brush.Text = "Brush";
            this.btn_brush.UseVisualStyleBackColor = true;
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(4, 227);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(52, 45);
            this.btn_circle.TabIndex = 2;
            this.btn_circle.Text = "Circle";
            this.btn_circle.UseVisualStyleBackColor = true;
            // 
            // holderRight
            // 
            this.holderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.holderRight.Location = new System.Drawing.Point(758, 39);
            this.holderRight.Name = "holderRight";
            this.holderRight.Size = new System.Drawing.Size(40, 410);
            this.holderRight.TabIndex = 2;
            // 
            // btn_pen
            // 
            this.btn_pen.Location = new System.Drawing.Point(6, 167);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(52, 42);
            this.btn_pen.TabIndex = 3;
            this.btn_pen.Text = "Pen";
            this.btn_pen.UseVisualStyleBackColor = true;
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(6, 215);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(52, 45);
            this.btn_square.TabIndex = 1;
            this.btn_square.Text = "Square";
            this.btn_square.UseVisualStyleBackColor = true;
            // 
            // drawarenapanel
            // 
            this.drawarenapanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawarenapanel.ForeColor = System.Drawing.SystemColors.Control;
            this.drawarenapanel.Location = new System.Drawing.Point(58, 43);
            this.drawarenapanel.Name = "drawarenapanel";
            this.drawarenapanel.Size = new System.Drawing.Size(702, 406);
            this.drawarenapanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawarenapanel);
            this.Controls.Add(this.btn_pen);
            this.Controls.Add(this.holderRight);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.holderLeft);
            this.Controls.Add(this.holderTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.holderTop.ResumeLayout(false);
            this.holderLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel holderTop;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel holderLeft;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel holderRight;
        private System.Windows.Forms.Button btn_brush;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Button btn_rubber;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Panel drawarenapanel;
    }
}

