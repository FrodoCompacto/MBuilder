
using MBuilder.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MBuilder
{
    public partial class MBuilder : Form
    {
        private const int timerClock = 5;

        private InputHandler inputHandler;
        private Keyboard keyboard;
        private Mouse mouse;
        private Macro MacroRecording;

        private Macro SelectedMacro;

        private String folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private bool recording = false;
        private bool playing = false;
        private bool logOn = false;

        public MBuilder()
        {
            InitializeComponent();
            this.keyboard = new Keyboard();
            this.mouse = new Mouse();
            this.inputHandler = new InputHandler(this.keyboard, this.mouse);

            timer.Interval = timerClock;
            timer.Enabled = false;

            openMacro_dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openMacro_dialog.FilterIndex = 1;
            openMacro_dialog.Multiselect = false;


        }

        private void AppendText(String text)
        {
            txb_output.AppendText(text + System.Environment.NewLine);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (logOn)
            {
                if (recording)
                {
                    MacroRecording.addInput(new Mouse(mouse.PosX, mouse.PosY, mouse.L_Click, mouse.R_Click, mouse.M_Click), new Keyboard(keyboard.pressedKeys));
                }
                else if (playing)
                {
                    //PLAY
                    //UPDATE BAR
                }

                logKeys();
                updateGraph();
            }
        }

        private void updateGraph()
        {
            lbl_mousePos.Text = "X: " + mouse.PosX + ", Y: " + mouse.PosY;
            chart_mousePos.Series["MousePos"].Points.Clear();
            if (mouse.PosX < 0)
            {
                chart_mousePos.Series["MousePos"].Points.AddXY(1920 + mouse.PosX, mouse.PosY);
                chart_mousePos.Series["MousePos"].Points[0].Color = Color.Red;
            }
            else
            {
                chart_mousePos.Series["MousePos"].Points.AddXY(mouse.PosX, mouse.PosY);
            }
        }

        private void logKeys()
        {
            String aux = "";

            aux += keyboard.toString() + mouse.toString();

            if (!aux.Equals(""))
            {
                AppendText(aux);
            }
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            if (!recording)
            {
                recording = !recording;
                btn_record.Text = "Stop";
                btn_Play.Enabled = false;
                btn_SelectMacro.Enabled = false;
                timer.Enabled = true;
                btn_log.Enabled = false;
                btn_Mfolder.Enabled = false;
                this.logOn = true;
                lb_status.Text = "Status: Recording";
                MacroRecording = new Macro(timerClock);
            }
            else
            {
                btn_record.Text = "Record";
                recording = !recording;
                timer.Enabled = false;
                if (SelectedMacro != null)
                {
                    btn_Play.Enabled = true;
                }
                btn_SelectMacro.Enabled = true;
                btn_Mfolder.Enabled = true;
                btn_log.Enabled = true;
                this.logOn = false;
                lb_status.Text = "Status: Stopped";
                MacroRecording.saveMacro(folderPath);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (!logOn)
            {
                btn_log.Text = "Enable/Disable Log";
                timer.Enabled = true;
                this.logOn = true;
            }
            else
            {
                timer.Enabled = false;
                this.logOn = false;
            }
        }

        private void btn_Mfolder_Click(object sender, EventArgs e)
        {
            macroFolder_dialog.SelectedPath = folderPath;
            if (macroFolder_dialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = macroFolder_dialog.SelectedPath;
            }
        }

        private void btn_SelectMacro_Click(object sender, EventArgs e)
        {
            openMacro_dialog.InitialDirectory = folderPath;
            if (openMacro_dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedMacro = new Macro(openMacro_dialog.FileName);
                btn_Play.Enabled = true;
                lbl_Macro.Text = "Macro Selected: " + openMacro_dialog.SafeFileName;
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playing = !playing;
                btn_Play.Text = "Stop";
                btn_SelectMacro.Enabled = false;
                btn_record.Enabled = false;
                btn_log.Enabled = false;
                btn_Mfolder.Enabled = false;
                timer.Enabled = true;
                this.logOn = true;
                lb_status.Text = "Status: Playing";
            } else
            {
                playing = !playing;
                btn_Play.Text = "Play Macro";
                btn_SelectMacro.Enabled = true;
                btn_record.Enabled = true;
                btn_log.Enabled = true;
                btn_Mfolder.Enabled = true;
                timer.Enabled = false;
                this.logOn = false;
                lb_status.Text = "Status: Inactive";
            }
        }
    }
}
