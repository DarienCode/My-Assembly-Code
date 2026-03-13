using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace My_Assembly_Code
{    
    public partial class Form : System.Windows.Forms.Form
    {
        string[] user_input = {"foo"}; // String array to read input from input textbox
        double r1 = 0; // Register 1
        double r2 = 0; // Register 2
        double r3 = 0; // Register 3
        List<Command> command_list = new List<Command>();

        public class CharV // character variable format
        {
            public string name;
            public char value;
        }
        public class IntV // integer variable format
        {
            public string name;
            public double value;
        }
        List<CharV> char_list = new List<CharV>();
        List<IntV> int_list = new List<IntV>();

        public List<Command> ParseInput(string UserInput) // Create command_list
        {
            command_list.Clear();

            string[] lines = UserInput.Split('\n');

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

        public void Load() // LOAD command
        {
            if (int.TryParse(user_input[1], out int var) == true) // Validate the value being assigned
            {
                switch (user_input[2]) // Validate the register being assigned to
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
                words.Add(cmd.Operation);
                if (cmd.Var1 != null)
                {
                    words.Add(cmd.Var1);
                }
                if (cmd.Var2 != null)
                {
                    words.Add(cmd.Var2);
                }
                if (cmd.Var3 != null)
                {
                    words.Add(cmd.Var3);
                }

                user_input = words.ToArray(); // Running the humble ToArray method

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
                else if (user_input[0] == "INT") // call the integer variable command
                {
                    IntegerV();
                }
                else if (user_input[0] == "CHAR") // call the character variable command
                {
                    CharacterV();
                }
                else // Command error
                {
                    MessageBox.Show("'" + user_input[0] + "' is an invalid command.");
                }
            }
        }

        private void Add() 
        {
          if(user_input.Length != 4) // Validate correct number of arguments
            {
                MessageBox.Show("ADD command requires 3 arguments.");
                return;
            }
            double val = Getter(user_input[1]);
            double val2 = Getter(user_input[2]);
            Setter(user_input[3], val + val2);  
        }            

        private void Multiple()
        {
            if (user_input.Length != 4) 
            {
                MessageBox.Show("MUL command requires 3 arguments: MUL dest src1 src2");
                return;
            }
            double val = Getter(user_input[1]);
            double val2 = Getter(user_input[2]);
            Setter(user_input[3], val * val2);
        }

        private void Divide()
        {
            if (user_input.Length != 4) 
            {
                MessageBox.Show("DIV command requires 4 arguments.");
                return;
            }

            double val = Getter(user_input[1]);
            double val2 = Getter(user_input[2]);
            Setter(user_input[3], val / val2);
        }


        private void Substract()
                {
            if (user_input.Length != 4)
            {
                MessageBox.Show("SUB command requires 4 arguments.");
                return;
            }

            double val = Getter(user_input[1]);
            double val2 = Getter(user_input[2]);
            Setter(user_input[3], val - val2);
        }


        private void IntegerV()
        {
            if (user_input.Length != 3)
            {
                MessageBox.Show("INT command requires 3 arguments.");
                return;
            }
            IntV temp = new IntV();            
            if (double.TryParse(user_input[2], out temp.value))
            {
                temp.name = user_input[1];
                int_list.Add(temp);
                MessageBox.Show("Created " + int_list[int_list.Count - 1].name + " with a value of " + int_list[int_list.Count - 1].value + ".");
            }
            else
            {
                MessageBox.Show("INT command 3rd argument requires an integer input.");
                return;
            }
        }


        private void CharacterV()
        {
            if (user_input.Length != 3)
            {
                MessageBox.Show("CHAR command requires 3 arguments.");
                return;
            }
            CharV temp = new CharV();
            if (char.TryParse(user_input[2], out temp.value))
            {
                temp.name = user_input[1];
                char_list.Add(temp);
                MessageBox.Show("Created " + char_list[char_list.Count - 1].name + " with a value of " + char_list[char_list.Count - 1].value + ".");
            }
            else
            {
                MessageBox.Show("CHAR command 3rd argument requires a single character input.");
                return;
            }
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
    