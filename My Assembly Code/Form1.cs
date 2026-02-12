namespace My_Assembly_Code
{
    public partial class Form : System.Windows.Forms.Form
    {
        int r1 = 0;
        int r2 = 0;
        int r3 = 0;
        public Form()
        {
            InitializeComponent();
            
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string[] user_input = input.Text.ToUpper().Split(' '); // (chris) Read from input textbox & assign uppercase split strings to user_input
            if (user_input[0] == "LD") // LOAD command
            {
                if (int.TryParse(user_input[1], out int v1) == true) // Validate the value being assigned
                {
                    if (user_input[2] == "R1") // Validate the register which the value is being assigned to
                    {
                        r1 = v1;
                    }
                    else if (user_input[2] == "R2")
                    {
                        r2 = v1;
                    }
                    else if (user_input[2] == "R3")
                    {
                        r3 = v1;
                    }
                    else // Throw register error
                    {
                        MessageBox.Show("Must give a valid register to assign the value to.");
                    }
                }
                else // Throw assigning value error
                {
                    MessageBox.Show("Cannot register an invalid value.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid command.");
            }
        }
    }
}
