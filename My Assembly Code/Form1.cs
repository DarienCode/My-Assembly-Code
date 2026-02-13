using System.Reflection.Metadata.Ecma335;

namespace My_Assembly_Code
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] user_input = {"foo"}; // String array to read input from input textbox
        double r1 = 0; // Register 1
        double r2 = 0; // Register 2
        double r3 = 0; // Register 3

       

        public void Load() // LOAD command
        {
            if (int.TryParse(user_input[1], out int var) == true) // Validate the value being assigned
            {
                switch (user_input[2]) // Validate the register being assigned to
                {
                    case "R1":
                        {
                            r1 = var;
                            r1Txtbox.Text = var.ToString();
                            break;
                        }
                    case "R2":
                        {
                            r2 = var;
                            r2Txtbox.Text = var.ToString();
                            break;
                        }
                    case "R3":
                        {
                            r3 = var;
                            r3Txtbox.Text = var.ToString();
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
            else if (user_input[0] == "ADD") // Call the Add command
            {
                Add();
            }
            else if (user_input[0] == "MUL") // Call the multiple command
            {
                Multiple();
            }
            else if (user_input[0] == "DIV") // call the divide command
            {
                Divide();
            }
            else if (user_input[0] == "SUB") // call the substract command
                {
                    Substract();
            }
            else // Command error
            {
                MessageBox.Show("'" + user_input[0] + "' is an invalid command.");
            }
        }

        private void Add() 
        {
            double val;
            double val2;

          if(user_input.Length != 3) // Validate correct number of arguments
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
            // Get first register value
            switch (user_input[1])
            {
                case "R1":
                    {
                        val = r1;
                        break;
                    }
                case "R2":
                    {
                        val = r2;
                        break;
                    }
                case "R3":
                    {
                        val = r3;
                        break;
                    }
                default: // Register error
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            // Get second register value
            switch (user_input[2])
            {
                case "R1":
                    {
                        val2 = r1;
                        break;
                    }
                case "R2":
                    {
                        val2 = r2;
                        break;
                    }
                case "R3":
                    {
                        val2 = r3;
                        break;
                    }
                default: // Register error
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            r3 = val + val2;
            r3Txtbox.Text = r3.ToString();
            output.Text = r3.ToString();
            r1Txtbox.Text = "";
            r2Txtbox.Text = "";

        }

        private void Multiple()
        {
            double val;
            double val2;

            if (user_input.Length != 3) 
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
            
            switch (user_input[1])
            {
                case "R1":
                    {
                        val = r1;
                        break;
                    }
                case "R2":
                    {
                        val = r2;
                        break;
                    }
                case "R3":
                    {
                        val = r3;
                        break;
                    }
                default: 
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
           
            switch (user_input[2])
            {
                case "R1":
                    {
                        val2 = r1;
                        break;
                    }
                case "R2":
                    {
                        val2 = r2;
                        break;
                    }
                case "R3":
                    {
                        val2 = r3;
                        break;
                    }
                default: 
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            r3 = val * val2;
            r3Txtbox.Text = r3.ToString();
            output.Text = r3.ToString();
            r1Txtbox.Text = "";
            r2Txtbox.Text = "";

        }

        private void Divide()
        {
            double val;
            double val2;

            if (user_input.Length != 3) 
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
           
            switch (user_input[1])
            {
                case "R1":
                    {
                        val = r1;
                        break;
                    }
                case "R2":
                    {
                        val = r2;
                        break;
                    }
                case "R3":
                    {
                        val = r3;
                        break;
                    }
                default: 
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            
            switch (user_input[2])
            {
                case "R1":
                    {
                        val2 = r1;
                        break;
                    }
                case "R2":
                    {
                        val2 = r2;
                        break;
                    }
                case "R3":
                    {
                        val2 = r3;
                        break;
                    }
                default: 
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            r3 = val / val2;
            r3Txtbox.Text = r3.ToString();
            output.Text = r3.ToString();
            r1Txtbox.Text = "";
            r2Txtbox.Text = "";

        }


        private void Substract()
        {
            double val;
            double val2;

            if (user_input.Length != 3) 
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
           
            switch (user_input[1])
            {
                case "R1":
                    {
                        val = r1;
                        break;
                    }
                case "R2":
                    {
                        val = r2;
                        break;
                    }
                case "R3":
                    {
                        val = r3;
                        break;
                    }
                default: 
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
           
            switch (user_input[2])
            {
                case "R1":
                    {
                        val2 = r1;
                        break;
                    }
                case "R2":
                    {
                        val2 = r2;
                        break;
                    }
                case "R3":
                    {
                        val2 = r3;
                        break;
                    }
                default: // Register error
                    {
                        MessageBox.Show("Must name a valid register to add from. (R1, R2, or R3)");
                        return;
                    }
            }
            r3 = val - val2;
            r3Txtbox.Text = r3.ToString();
            output.Text = r3.ToString();
            r1Txtbox.Text = "";
            r2Txtbox.Text = "";

        }
    }

}
