using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace My_Assembly_Code
{
    public partial class Form : System.Windows.Forms.Form
    {
        double r1 = 0; // Register 1
        double r2 = 0; // Register 2
        double r3 = 0; // Register 3
        List<Command> command_list = new List<Command>();


        public List<Command> ParseInput(string Input) // Create command_list
        {
            command_list.Clear();

            string[] lines = Input.Split('\n');

            foreach (string line in lines)
            {
                string[] words = line.ToUpper().Split(' ');

                Command new_cmd = new Command();
                new_cmd.Operation = words[0];
                new_cmd.Var1 = words[1];
                new_cmd.Var2 = words[2];
                if (words.Length > 3)
                {
                    new_cmd.Var3 = words[3];
                }

                command_list.Add(new_cmd);
            }
            return (command_list);
        }

        public void Load(Command cmd) // LOAD command
        {
            if (int.TryParse(cmd.Var1, out int var) == true) // Validate the value being assigned
            {
                switch (cmd.Var2) // Validate the register being assigned to
                {
                    case "R1":
                        {
                            r1 = var;
                            r1Txtbox.Text = r1.ToString();
                            break;
                        }
                    case "R2":
                        {
                            r2 = var;
                            r2Txtbox.Text = r2.ToString();
                            break;
                        }
                    case "R3":
                        {
                            r3 = var;
                            r3Txtbox.Text = r3.ToString();
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

            ParseInput(input.Text);

            foreach (Command cmd in command_list)
            {
                List<string> words = new List<string>();

                if (cmd.Operation == "LD") // Call the LOAD command
                {
                    Load(cmd);
                }
                else if (cmd.Operation == "ADD") // Call the Add command
                {
                    Add(cmd);
                }
                else if (cmd.Operation == "MUL") // Call the multiple command
                {
                    Multiple(cmd);
                }
                else if (cmd.Operation == "DIV") // call the divide command
                {
                    Divide(cmd);
                }
                else if (cmd.Operation == "SUB") // call the substract command
                {
                    Substract(cmd);
                }
                else // Command error
                {
                    MessageBox.Show("'" + cmd.Operation + "' is an invalid command.");
                }
            }
        }

        private void Add(Command cmd) 
        {
          if (cmd.Var3 == null) // Validate correct number of arguments
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
            double val = Getter(cmd.Var1);
            double val2 = Getter(cmd.Var2);
            Setter(cmd.Var3, val + val2);  
        }            

        private void Multiple(Command cmd)
        {
            if (cmd.Var3 == null) 
            {
                MessageBox.Show("MUL command requires 3 arguments: MUL dest src1 src2");
                return;
            }
            double val = Getter(cmd.Var1);
            double val2 = Getter(cmd.Var2);
            Setter(cmd.Var3, val * val2);
        }

        private void Divide(Command cmd)
        {
            if (cmd.Var3 == null)
            {
                MessageBox.Show("DIV command requires 4 arguments.");
                return;
            }

            double val = Getter(cmd.Var1);
            double val2 = Getter(cmd.Var2);
            Setter(cmd.Var3, val / val2);
        }


        private void Substract(Command cmd)
                {
            if (cmd.Var3 == null)
            {
                MessageBox.Show("SUB command requires 4 arguments.");
                return;
            }

            double val = Getter(cmd.Var1);
            double val2 = Getter(cmd.Var2);
            Setter(cmd.Var3, val - val2);
        }

        private double Getter(string reg)
        {
                switch (reg)
            {
                case "R1": return r1;
                case "R2": return r2;
                case "R3": return r3;
                default: MessageBox.Show("No register detected");
                    return 0;
            }
        }
        private void Setter(string reg, double number)
        {
            switch (reg)
            {
                case "R1": r1 = number; r1Txtbox.Text = number.ToString(); output.Text = number.ToString(); break;
                case "R2": r2 = number; r2Txtbox.Text = number.ToString(); output.Text = number.ToString(); break;
                case "R3": r3 = number; r3Txtbox.Text = number.ToString(); output.Text = number.ToString(); break;
                default: MessageBox.Show("Must name a valid register. (R1, R2, or R3)"); break;
            }
        }
    }

}
    