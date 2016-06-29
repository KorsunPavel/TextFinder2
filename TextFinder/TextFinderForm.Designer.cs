using System.Threading;

namespace TextFinder {
    partial class TextFinderForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFinderForm));
            this.Start_Page_URI_textBox = new System.Windows.Forms.TextBox();
            this.URI_Label = new System.Windows.Forms.Label();
            this.Threads_textBox = new System.Windows.Forms.TextBox();
            this.Threads_label = new System.Windows.Forms.Label();
            this.URI_count_to_search_label = new System.Windows.Forms.Label();
            this.Amount_of_pages_textBox = new System.Windows.Forms.TextBox();
            this.TargetWord_label = new System.Windows.Forms.Label();
            this.target_word_textBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Log_TextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start_Page_URI_textBox
            // 
            this.Start_Page_URI_textBox.Location = new System.Drawing.Point(224, 21);
            this.Start_Page_URI_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Page_URI_textBox.Name = "Start_Page_URI_textBox";
            this.Start_Page_URI_textBox.Size = new System.Drawing.Size(439, 20);
            this.Start_Page_URI_textBox.TabIndex = 0;
            this.Start_Page_URI_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // URI_Label
            // 
            this.URI_Label.AutoSize = true;
            this.URI_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URI_Label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.URI_Label.Location = new System.Drawing.Point(26, 21);
            this.URI_Label.Name = "URI_Label";
            this.URI_Label.Size = new System.Drawing.Size(108, 18);
            this.URI_Label.TabIndex = 2;
            this.URI_Label.Text = "Start page URI:";
            // 
            // Threads_textBox
            // 
            this.Threads_textBox.Location = new System.Drawing.Point(559, 97);
            this.Threads_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Threads_textBox.Name = "Threads_textBox";
            this.Threads_textBox.Size = new System.Drawing.Size(104, 20);
            this.Threads_textBox.TabIndex = 3;
            this.Threads_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Threads_label
            // 
            this.Threads_label.AutoSize = true;
            this.Threads_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Threads_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Threads_label.Location = new System.Drawing.Point(363, 97);
            this.Threads_label.Name = "Threads_label";
            this.Threads_label.Size = new System.Drawing.Size(168, 18);
            this.Threads_label.TabIndex = 4;
            this.Threads_label.Text = "Threads\' amount to use:";
            // 
            // URI_count_to_search_label
            // 
            this.URI_count_to_search_label.AutoSize = true;
            this.URI_count_to_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URI_count_to_search_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.URI_count_to_search_label.Location = new System.Drawing.Point(26, 97);
            this.URI_count_to_search_label.Name = "URI_count_to_search_label";
            this.URI_count_to_search_label.Size = new System.Drawing.Size(162, 18);
            this.URI_count_to_search_label.TabIndex = 5;
            this.URI_count_to_search_label.Text = "Amount of URI to scan:";
            // 
            // Amount_of_pages_textBox
            // 
            this.Amount_of_pages_textBox.Location = new System.Drawing.Point(224, 97);
            this.Amount_of_pages_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Amount_of_pages_textBox.Name = "Amount_of_pages_textBox";
            this.Amount_of_pages_textBox.Size = new System.Drawing.Size(104, 20);
            this.Amount_of_pages_textBox.TabIndex = 6;
            this.Amount_of_pages_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TargetWord_label
            // 
            this.TargetWord_label.AutoSize = true;
            this.TargetWord_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetWord_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TargetWord_label.Location = new System.Drawing.Point(26, 59);
            this.TargetWord_label.Name = "TargetWord_label";
            this.TargetWord_label.Size = new System.Drawing.Size(163, 18);
            this.TargetWord_label.TabIndex = 7;
            this.TargetWord_label.Text = "Search phrase or word:";
            // 
            // target_word_textBox
            // 
            this.target_word_textBox.Location = new System.Drawing.Point(224, 59);
            this.target_word_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.target_word_textBox.Name = "target_word_textBox";
            this.target_word_textBox.Size = new System.Drawing.Size(439, 20);
            this.target_word_textBox.TabIndex = 8;
            this.target_word_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(30, 534);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(633, 12);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 10;
            this.ProgressBar.Visible = false;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Gray;
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Start_Button.FlatAppearance.BorderSize = 2;
            this.Start_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start_Button.Location = new System.Drawing.Point(29, 130);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(297, 41);
            this.Start_Button.TabIndex = 11;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Log_TextBox
            // 
            this.Log_TextBox.BackColor = System.Drawing.Color.Black;
            this.Log_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_TextBox.ForeColor = System.Drawing.Color.Yellow;
            this.Log_TextBox.Location = new System.Drawing.Point(11, 0);
            this.Log_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log_TextBox.Multiline = true;
            this.Log_TextBox.Name = "Log_TextBox";
            this.Log_TextBox.ReadOnly = true;
            this.Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_TextBox.Size = new System.Drawing.Size(622, 329);
            this.Log_TextBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Gray;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Enabled = false;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(365, 130);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(297, 41);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Log_TextBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(29, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 331);
            this.panel1.TabIndex = 14;
            // 
            // TextFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(705, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.target_word_textBox);
            this.Controls.Add(this.TargetWord_label);
            this.Controls.Add(this.Amount_of_pages_textBox);
            this.Controls.Add(this.URI_count_to_search_label);
            this.Controls.Add(this.Threads_label);
            this.Controls.Add(this.Threads_textBox);
            this.Controls.Add(this.URI_Label);
            this.Controls.Add(this.Start_Page_URI_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TextFinderForm";
            this.Text = "TextFinder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CancellationTokenSource cancellationTokenSource;

        private System.Windows.Forms.TextBox Start_Page_URI_textBox;
        private System.Windows.Forms.Label URI_Label;
        private System.Windows.Forms.TextBox Threads_textBox;
        private System.Windows.Forms.Label Threads_label;
        private System.Windows.Forms.Label URI_count_to_search_label;
        private System.Windows.Forms.TextBox Amount_of_pages_textBox;
        private System.Windows.Forms.Label TargetWord_label;
        private System.Windows.Forms.TextBox target_word_textBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.TextBox Log_TextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
    }
}

