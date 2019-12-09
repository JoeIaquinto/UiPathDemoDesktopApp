using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiPathDemoDesktopApp
{
    public partial class MainForm : Form
    {
        private int randomMode = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fnameBox.Text))
            {
                MessageBox.Show("First name is required!");
                return;
            }
            if (string.IsNullOrWhiteSpace(lnameBox.Text))
            {
                MessageBox.Show("First name is required!");
                return;
            }
            if (string.IsNullOrWhiteSpace(pwBox.Text) )
            {
                MessageBox.Show("Password is required!");
                return;
            }
            if (string.IsNullOrWhiteSpace(cpwBox.Text))
            {
                MessageBox.Show("Password is required!");
                return;
            }
            if (!pwBox.Text.Equals(cpwBox.Text))
            {
                MessageBox.Show("Passwords must be the same!");
                return;
            }
            if (!tosBox.Checked)
            {
                MessageBox.Show("You must accept our TOS!");
            }

            MessageBox.Show("Welcome " + fnameBox.Text + "!");

            fnameBox.Clear();
            lnameBox.Clear();
            pwBox.Clear();
            cpwBox.Clear();
            dobPicker.Clear();
            favNumBox.Clear();
            spamBox.Checked = true;
            tosBox.Checked = false;
        }

        private void randomizer_Click(object sender, EventArgs e)
        {
            if (randomMode >= 1)
            {
                applyToAllControls(x => SetRandomLocation(x));
            }
            if (randomMode >= 2)
            {
                applyToAllControls(x => x.Scale(GetRandomScale()));
            }
            if (randomMode >= 3)
            {
                addEventHandlerToAllControls(new EventHandler(RandomLocationEventHandler));
            }
        }

        private void RandomLocationEventHandler(object sender, EventArgs e)
        {
            var control = (Control)sender;
            SetRandomLocation(control);
        }

        private void SetRandomLocation(Control control)
        {
            control.Location = GetRandomPoint();
        }

        private void slideDvd(Control control)
        {
            new Task(() =>
            {
                slideToDestination(GetRandomPoint(), control, 25, delegate() { Thread.Sleep(5); slideDvd(control); });
            }).Start();
        }
        private void rainbow(Control control)
        {
            new Task(() =>
            {
                colorize(control, 100, delegate () { rainbow(control); });
            }).Start();
        }

        private void applyToAllControls(Action<Control> action)
        {
            var typeToBeSelected = new List<Type>
                                    {
                                        typeof(TextBox)
                                        , typeof(MaskedTextBox)
                                        , typeof(Button)
                                        , typeof(RadioButton)
                                        , typeof(Label)
                                        , typeof(DateTimePicker)
                                        , typeof(CheckBox)
                                    };

            foreach (var item in GetAll(TopLevelControl, typeToBeSelected))
            {
                action.Invoke(item);
            }
        }
        private void addEventHandlerToAllControls(EventHandler e)
        {
            applyToAllControls(x => x.TextChanged += e);
        }

        private IEnumerable<Control> GetAll(Control control, IEnumerable<Type> filteringTypes)
        {
            var ctrls = control.Controls.Cast<Control>();

            return ctrls.SelectMany(ctrl => GetAll(ctrl, filteringTypes))
                        .Concat(ctrls)
                        .Where(ctl => filteringTypes.Any(t => ctl.GetType() == t));
        }

        private void slideToDestination(Point destination, Control control, int delay, Action onFinish)
        {
            new Task(() =>
            {
                int directionX = destination.X > control.Left ? 1 : -1;
                int directionY = destination.Y > control.Top ? 1 : -1;

                while (control.Left != destination.X || control.Top != destination.Y)
                {
                    try
                    {
                        if (control.Left != destination.X)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Left += directionX;
                            });
                        }
                        if (control.Top != destination.Y)
                        {
                            this.Invoke((Action)delegate ()
                            {
                                control.Top += directionY;
                            });
                        }
                        Thread.Sleep(delay);
                    }
                    catch
                    {
                        // form could be disposed
                        break;
                    }
                }

                if (onFinish != null) onFinish();

            }).Start();
        }

        private void colorize(Control control, int delay, Action onFinish)
        {
            new Task(() =>
            {
                var ran = new Random();
                var foreColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                var dirR = foreColor.R > control.ForeColor.R ? 1 : -1;
                var dirG = foreColor.G > control.ForeColor.G ? 1 : -1;
                var dirB = foreColor.B > control.ForeColor.B ? 1 : -1;
                while (control.ForeColor != foreColor)
                {
                    try
                    {
                        this.Invoke((Action)delegate ()
                        {
                            control.ForeColor = Color.FromArgb(control.ForeColor.R != foreColor.R ? control.ForeColor.R + dirR : control.ForeColor.R, control.ForeColor.G != foreColor.G ? control.ForeColor.G + dirG : control.ForeColor.G, control.ForeColor.B != foreColor.B ? control.ForeColor.B + dirB : control.ForeColor.B);
                        });
                        Thread.Sleep(delay);
                    }
                    catch
                    {
                        // form could be disposed
                        break;
                    }
                }

                if (onFinish != null) onFinish();

            }).Start();
        }

        private Point GetRandomPoint()
        {
            var rng = new Random();
            return new Point(rng.Next(0, Width), rng.Next(0, Height));
        }

        private SizeF GetRandomScale()
        {
            var rng = new Random();
            var x = (float)rng.NextDouble() * 2;
            var y = (float)rng.NextDouble() * 2;
            return new SizeF(x,y);
        }

        private void easybutton_CheckedChanged(object sender, EventArgs e)
        {
            randomMode = easybutton.Checked ? 1 : 0;
            if (easybutton.Checked)
            {
                mediumbutton.Checked = false;
                hardbutton.Checked = false;
            }
        }

        private void mediumbutton_CheckedChanged(object sender, EventArgs e)
        {
            randomMode = mediumbutton.Checked ? 2 : 0;
            if (mediumbutton.Checked)
            {
                easybutton.Checked = false;
                hardbutton.Checked = false;
            }
        }

        private void hardbutton_CheckedChanged(object sender, EventArgs e)
        {
            randomMode = hardbutton.Checked ? 3 : 0;
            if (hardbutton.Checked)
            {
                easybutton.Checked = false;
                mediumbutton.Checked = false;
            }
        }
        
    }
}
