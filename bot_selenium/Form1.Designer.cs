namespace bot_selenium
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
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.JS = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(62, 32);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(62, 247);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // JS
            // 
            this.JS.Location = new System.Drawing.Point(62, 209);
            this.JS.Name = "JS";
            this.JS.Size = new System.Drawing.Size(75, 23);
            this.JS.TabIndex = 2;
            this.JS.Text = "JS";
            this.JS.UseVisualStyleBackColor = true;
            this.JS.Click += new System.EventHandler(this.JS_Click);
            // 
            // Tab
            // 
            this.Tab.Location = new System.Drawing.Point(62, 114);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(75, 23);
            this.Tab.TabIndex = 3;
            this.Tab.Text = "Tab";
            this.Tab.UseVisualStyleBackColor = true;
            this.Tab.Click += new System.EventHandler(this.Tab_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(62, 75);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(192, 34);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(570, 352);
            this.TextBox1.TabIndex = 6;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.JS);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "bot_selenium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button JS;
        private System.Windows.Forms.Button Tab;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

