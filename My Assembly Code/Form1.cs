namespace My_Assembly_Code
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] user_input = {"foo"}; // String array to read input from input textbox
        int r1 = 0; // Register 1
        int r2 = 0; // Register 2
        int r3 = 0; // Register 3

        public void Load() // LOAD command
        {
            if (int.TryParse(user_input[1], out int var) == true) // Validate the value being assigned
            {
                switch (user_input[2]) // Validate the register being assigned to
                {
                    case "R1":
                        {
                            r1 = var;
                            break;
                        }
                    case "R2":
                        {
                            r2 = var;
                            break;
                        }
                    case "R3":
                        {
                            r3 = var;
                            break;
                        }
                    default: // Register error
                        {
                            MessageBox.Show("Must name a valid register to assign to. (R1, R2, or R3)");
                            break;
                        }
                }
            }
            else // Assigning value error
            {
                MessageBox.Show("Value registered must be an integer.");
                return;
            }           
        }
        public Form()
        {
            InitializeComponent();
            
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            // We can probably ignore this
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            user_input = input.Text.ToUpper().Split(' '); // Save textbox input to user_input, separated as an array
            if (user_input[0] == "LD") // Call the LOAD command
            {
                Load();
            }
            else // Command error
            {
                MessageBox.Show("'" + user_input[0] +  "' is an invalid command.");
            }
        }
    }
}
