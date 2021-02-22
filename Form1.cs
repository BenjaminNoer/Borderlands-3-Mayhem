using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Patagames.Ocr;
using System.Timers;
using WindowsInput.Native;
using WindowsInput;
using System.Text.RegularExpressions;

namespace Borderlands3MayhemV2
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer rerollTimer;
        private readonly InputSimulator sim = new InputSimulator();
        private string path;
        private bool reroll = false;
        private short wait = 10000, interval = 100;
        private Size resolution = new Size(1920, 1080);

        //Define modifiers in string arrays
        private readonly static string[] easy = { "Big Kick Energy", "Galaxy Brain", "Lootsplosion", "Speed Demon", "More Than Okay Boomer", "Slayer" },
        medium = { "Healy Avenger", "Charred Mode", "High Voltage", "Acid Reign", "Chilling Them Softly", "Totally Radical", "Mob Mentality", "Freeze Tag", "Floor is Lava", "Pain Tolerance" },
        hard = { "Chain Gang", "Drone Ranger", "Pool Party", "Laser Fare", "Boundary Issues", "Ticked Off" },
        veryHard = { "Buddy System", "Post Mortem", "Dazed and Infused", "Rogue Lite", "Not the Face", "Holy Crit" };
        private string[] active = {"", "", "", ""};

        public Form1() {InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add modifiers from string arrays to combo boxes on form load
            cbModifier1.Items.AddRange(easy);
            cbModifier2.Items.AddRange(medium);
            cbModifier3.Items.AddRange(hard);
            cbModifier4.Items.AddRange(veryHard);

            cbResolution.Items.AddRange(new string[] {"1280x720", "1360x720", "1366x720", "1600x900", "1920x1080", "2560x1440"});
            cbResolution.SelectedIndex = 4;

            rerollTimer = new System.Timers.Timer(wait);
            rerollTimer.Elapsed += RerollTimer_Elapsed;
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BO3Screenshot.jpg";

            Stop();
        }

        private void RerollTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            rerollTimer.Enabled = false;
            rerollTimer.Interval = interval;
            //Bitmap img = SaveArea(1700, 600, 499, 600, new Size(499, 600));
            int left = resolution.Width * 85 / 128;
            int top = resolution.Height * 5 / 12;
            Bitmap img = SaveArea(left, top, 499, top, new Size(499, top));
            img.Save(@path);
            Reroll(@path);
            img.Dispose();
        }

        private Bitmap SaveArea(int x, int y, int w, int h, Size s)
        {
            Rectangle rect = new Rectangle(x, y, w, h);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);

            return bmp;
        }

        private void Reroll(string BO3img)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(@BO3img);
                string formattedText = Regex.Replace(plainText, @"\s+", "").ToUpper();
                SetText(formattedText);
                if (formattedText.ToUpper().Contains(active[0]) && formattedText.Contains(active[1]) && formattedText.Contains(active[2]) && formattedText.Contains(active[3]))
                {
                    Stop();
                }
                else
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.VK_Q);
                    System.Threading.Thread.Sleep(250);
                    if (reroll)
                    {
                        rerollTimer.Enabled = true;
                    }
                }
            }
        }

        private void cbModifier1_SelectedIndexChanged(object sender, EventArgs e) {active[0] = Regex.Replace(cbModifier1.GetItemText(cbModifier1.SelectedItem).ToUpper(), @"\s+", "");}
        private void cbModifier2_SelectedIndexChanged(object sender, EventArgs e) {active[1] = Regex.Replace(cbModifier2.GetItemText(cbModifier2.SelectedItem).ToUpper(), @"\s+", "");}
        private void cbModifier3_SelectedIndexChanged(object sender, EventArgs e) {active[2] = Regex.Replace(cbModifier3.GetItemText(cbModifier3.SelectedItem).ToUpper(), @"\s+", "");}
        private void cbModifier4_SelectedIndexChanged(object sender, EventArgs e) {active[3] = Regex.Replace(cbModifier4.GetItemText(cbModifier4.SelectedItem).ToUpper(), @"\s+", "");}

        private void btnEasy_Click(object sender, EventArgs e) {cbModifier1.SelectedIndex = -1;}
        private void btnMedium_Click(object sender, EventArgs e) {cbModifier2.SelectedIndex = -1;}
        private void btnHard_Click(object sender, EventArgs e) {cbModifier3.SelectedIndex = -1;}
        private void btnVeryHard_Click(object sender, EventArgs e) {cbModifier4.SelectedIndex = -1;}

        private void nudWait_ValueChanged(object sender, EventArgs e) {wait = Convert.ToInt16(nudWait.Value * 100);}

        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {
            cbModifier1.SelectedIndex = -1;
            switch (nudLevel.Value)
            {
                case 1:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, false);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, false);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    break;
                case 2:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, false);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    break;
                case 3:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    SetValues(lblModifier3, "Medium", cbModifier3, medium);
                    break;
                case 4:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, false);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Hard", cbModifier2, hard);
                    break;
                case 5:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    SetValues(lblModifier3, "Hard", cbModifier3, hard);
                    break;
                case 6:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, true);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    SetValues(lblModifier3, "Medium", cbModifier3, medium);
                    SetValues(lblModifier4, "Hard", cbModifier4, hard);
                    break;
                case 7:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Hard", cbModifier2, hard);
                    SetValues(lblModifier3, "Hard", cbModifier3, hard);
                    break;
                case 8:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, false);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Very Hard", cbModifier2, veryHard);
                    break;
                case 9:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, false);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    SetValues(lblModifier3, "Very Hard", cbModifier3, veryHard);
                    break;
                case 10:
                    ToggleMod(lblModifier2, cbModifier2, btnMedium, true);
                    ToggleMod(lblModifier3, cbModifier3, btnHard, true);
                    ToggleMod(lblModifier4, cbModifier4, btnVeryHard, true);
                    SetValues(lblModifier2, "Medium", cbModifier2, medium);
                    SetValues(lblModifier3, "Hard", cbModifier3, hard);
                    SetValues(lblModifier4, "Very Hard", cbModifier4, veryHard);
                    break;
            }
        }

        private void SetValues(Label label, string modText, ComboBox comboBox, string[] items)
        {
            comboBox.SelectedIndex = -1;
            label.Text = modText;
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items);
        }

        private void ToggleMod(Label label, ComboBox comboBox, Button button, bool toggle)
        {
            comboBox.SelectedIndex = -1;
            label.Visible = toggle;
            comboBox.Visible = toggle;
            button.Visible = toggle;
        }

        delegate void SetTextCallback(string text);

        private void cbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dimensions = cbResolution.GetItemText(cbResolution.SelectedItem).Split('x');
            resolution.Width = Convert.ToInt16(dimensions[0]);
            resolution.Height = Convert.ToInt16(dimensions[1]);
        }

        private void SetText(string text)
        {
            if (this.rtxtOutput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.rtxtOutput.Text = text;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            reroll = true;
            rerollTimer.Enabled = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblOutput.Text = "OCR Output";
            rtxtOutput.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            rerollTimer.Interval = wait;
            reroll = false;
            rerollTimer.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            rtxtOutput.Text =
                "1. This program uses screenshots of your screen to read text and checks what the current mayhem modifiers are."
                + "\n\n2. DOES NOT WORK IN 3840x2160"
                + "\n\n3. Input resolution as the game's resolution if it is in fullscreen or input resolution as your monitor's resolution if the game is in windowed or borderless windowed mode."
                + "\n\n4. If your game is not in fullscreen make sure it fills the monitor since screenshots are taken where the mayhem modifiers are expected to appear when the game is in fullscreen."
                + "\n\n5. Screenshots are saved as BO3Screenshot.jpg in your Documents folder."
                + "\n\n6. Leaving any modifiers blank will make the program ignore them."
                + "\n\n7. This text box will be filled with the text the program recognizes in the screenshots when it starts.";
            lblOutput.Text = "Instructions and Help";
        }
    }
}