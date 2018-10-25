namespace CheckSpell
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
            this.dictBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.richTextBoxRaw = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dictBtn
            // 
            this.dictBtn.Location = new System.Drawing.Point(713, 415);
            this.dictBtn.Name = "dictBtn";
            this.dictBtn.Size = new System.Drawing.Size(75, 23);
            this.dictBtn.TabIndex = 0;
            this.dictBtn.Text = "Dict";
            this.dictBtn.UseVisualStyleBackColor = true;
            this.dictBtn.Click += new System.EventHandler(this.dictBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(12, 44);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 23);
            this.readBtn.TabIndex = 4;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // richTextBoxRaw
            // 
            this.richTextBoxRaw.Location = new System.Drawing.Point(125, 44);
            this.richTextBoxRaw.Name = "richTextBoxRaw";
            this.richTextBoxRaw.ReadOnly = true;
            this.richTextBoxRaw.Size = new System.Drawing.Size(385, 323);
            this.richTextBoxRaw.TabIndex = 5;
            this.richTextBoxRaw.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Process";
            // 
            // processBtn
            // 
            this.processBtn.Enabled = false;
            this.processBtn.Location = new System.Drawing.Point(12, 73);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 7;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(528, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 186);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(713, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count : 0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(695, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxRaw);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dictBtn);
            this.Name = "Form1";
            this.Text = "Check Spell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dictBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.RichTextBox richTextBoxRaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

