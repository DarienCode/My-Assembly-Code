namespace My_Assembly_Code
{
    partial class Form
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
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(92, 54);
            input.Margin = new Padding(2, 2, 2, 2);
            input.Name = "input";
            input.Size = new Size(121, 166);
            input.TabIndex = 0;
            input.Text = "";
            // 
            // runBtn
            // 
            runBtn.Location = new Point(106, 257);
            runBtn.Margin = new Padding(2, 2, 2, 2);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(90, 27);
            runBtn.TabIndex = 1;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 2;
            label1.Text = "R1:";
            // 
            // r1Txtbox
            // 
            r1Txtbox.Location = new Point(437, 54);
            r1Txtbox.Margin = new Padding(2, 2, 2, 2);
            r1Txtbox.Name = "r1Txtbox";
            r1Txtbox.Size = new Size(121, 27);
            r1Txtbox.TabIndex = 3;
            // 
            // r2Txtbox
            // 
            r2Txtbox.Location = new Point(437, 84);
            r2Txtbox.Margin = new Padding(2, 2, 2, 2);
            r2Txtbox.Name = "r2Txtbox";
            r2Txtbox.Size = new Size(121, 27);
            r2Txtbox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 4;
            label2.Text = "R2:";
            // 
            // r3Txtbox
            // 
            r3Txtbox.Location = new Point(437, 114);
            r3Txtbox.Margin = new Padding(2, 2, 2, 2);
            r3Txtbox.Name = "r3Txtbox";
            r3Txtbox.Size = new Size(121, 27);
            r3Txtbox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 6;
            label3.Text = "R3:";
            // 
            // output
            // 
            output.Location = new Point(351, 211);
            output.Margin = new Padding(2, 2, 2, 2);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(280, 133);
            output.TabIndex = 8;
            output.Text = "";
            output.TextChanged += output_TextChanged;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 353);
            Controls.Add(output);
            Controls.Add(r3Txtbox);
            Controls.Add(label3);
            Controls.Add(r2Txtbox);
            Controls.Add(label2);
            Controls.Add(r1Txtbox);
            Controls.Add(label1);
            Controls.Add(runBtn);
            Controls.Add(input);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form";
            Text = "Form1";
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
    }
}
