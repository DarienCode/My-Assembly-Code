namespace My_Assembly_Code
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            input = new RichTextBox();
            runBtn = new Button();
            label1 = new Label();
            r1Txtbox = new TextBox();
            r2Txtbox = new TextBox();
            label2 = new Label();
            r3Txtbox = new TextBox();
            label3 = new Label();
            output = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // input
            // 
            input.BackColor = Color.DimGray;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            input.ForeColor = SystemColors.ControlText;
            input.Location = new Point(115, 68);
            input.Margin = new Padding(2);
            input.Name = "input";
            input.Size = new Size(150, 206);
            input.TabIndex = 0;
            input.Text = "";
            // 
            // runBtn
            // 
            runBtn.BackColor = Color.DimGray;
            runBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runBtn.ForeColor = SystemColors.ActiveCaption;
            runBtn.Location = new Point(132, 321);
            runBtn.Margin = new Padding(2);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(111, 55);
            runBtn.TabIndex = 1;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = false;
            runBtn.Click += runBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(502, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 2;
            label1.Text = "R1:";
            // 
            // r1Txtbox
            // 
            r1Txtbox.BackColor = Color.DimGray;
            r1Txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            r1Txtbox.ForeColor = SystemColors.ControlText;
            r1Txtbox.Location = new Point(546, 68);
            r1Txtbox.Margin = new Padding(2);
            r1Txtbox.Name = "r1Txtbox";
            r1Txtbox.ReadOnly = true;
            r1Txtbox.Size = new Size(150, 39);
            r1Txtbox.TabIndex = 3;
            // 
            // r2Txtbox
            // 
            r2Txtbox.BackColor = Color.DimGray;
            r2Txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            r2Txtbox.ForeColor = SystemColors.ControlText;
            r2Txtbox.Location = new Point(546, 105);
            r2Txtbox.Margin = new Padding(2);
            r2Txtbox.Name = "r2Txtbox";
            r2Txtbox.ReadOnly = true;
            r2Txtbox.Size = new Size(150, 39);
            r2Txtbox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(502, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 4;
            label2.Text = "R2:";
            // 
            // r3Txtbox
            // 
            r3Txtbox.BackColor = Color.DimGray;
            r3Txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            r3Txtbox.ForeColor = SystemColors.ControlText;
            r3Txtbox.Location = new Point(546, 142);
            r3Txtbox.Margin = new Padding(2);
            r3Txtbox.Name = "r3Txtbox";
            r3Txtbox.ReadOnly = true;
            r3Txtbox.Size = new Size(150, 39);
            r3Txtbox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(502, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 6;
            label3.Text = "R3:";
            // 
            // output
            // 
            output.BackColor = Color.DimGray;
            output.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output.ForeColor = SystemColors.ControlText;
            output.Location = new Point(439, 264);
            output.Margin = new Padding(2);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(349, 165);
            output.TabIndex = 8;
            output.Text = "";
            output.TextChanged += output_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(270, 34);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(270, 34);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(60, 29);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 441);
            Controls.Add(output);
            Controls.Add(r3Txtbox);
            Controls.Add(label3);
            Controls.Add(r2Txtbox);
            Controls.Add(label2);
            Controls.Add(r1Txtbox);
            Controls.Add(label1);
            Controls.Add(runBtn);
            Controls.Add(input);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox input;
        public Button runBtn;
        public Label label1;
        public TextBox r1Txtbox;
        public TextBox r2Txtbox;
        public Label label2;
        public TextBox r3Txtbox;
        public Label label3;
        public RichTextBox output;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}
