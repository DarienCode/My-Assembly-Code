namespace My_Assembly_Code
{
    partial class Form
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
            input.Location = new Point(115, 68);
            input.Name = "input";
            input.Size = new Size(150, 206);
            input.TabIndex = 0;
            input.Text = "";
            // 
            // runBtn
            // 
            runBtn.Location = new Point(132, 321);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(112, 34);
            runBtn.TabIndex = 1;
            runBtn.Text = "Run";
            runBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 71);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 2;
            label1.Text = "R1:";
            // 
            // r1Txtbox
            // 
            r1Txtbox.Location = new Point(546, 68);
            r1Txtbox.Name = "r1Txtbox";
            r1Txtbox.Size = new Size(150, 31);
            r1Txtbox.TabIndex = 3;
            // 
            // r2Txtbox
            // 
            r2Txtbox.Location = new Point(546, 105);
            r2Txtbox.Name = "r2Txtbox";
            r2Txtbox.Size = new Size(150, 31);
            r2Txtbox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 108);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 4;
            label2.Text = "R2:";
            // 
            // r3Txtbox
            // 
            r3Txtbox.Location = new Point(546, 142);
            r3Txtbox.Name = "r3Txtbox";
            r3Txtbox.Size = new Size(150, 31);
            r3Txtbox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 145);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 6;
            label3.Text = "R3:";
            // 
            // output
            // 
            output.Location = new Point(439, 264);
            output.Name = "output";
            output.ReadOnly = true;
            output.Size = new Size(349, 165);
            output.TabIndex = 8;
            output.Text = "";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox input;
        private Button runBtn;
        private Label label1;
        private TextBox r1Txtbox;
        private TextBox r2Txtbox;
        private Label label2;
        private TextBox r3Txtbox;
        private Label label3;
        private RichTextBox output;
    }
}
