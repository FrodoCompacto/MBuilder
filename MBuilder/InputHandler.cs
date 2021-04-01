using Gma.System.MouseKeyHook;
using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using LowLevelHooking;
using MBuilder.Models;


namespace MBuilder
{
    class InputHandler
    {

        private Keyboard keyboard;
        private Mouse mouse;

        public static GlobalKeyboardHook GlobalKeyboardHook { get; private set; }
        private static IKeyboardMouseEvents m_GlobalHook;

        private InputSimulator sim = new InputSimulator();

        public InputHandler(Keyboard keyboard, Mouse mouse)
        {
            this.keyboard = keyboard;
            this.mouse = mouse;

            GlobalKeyboardHook = new GlobalKeyboardHook();
            GlobalKeyboardHook.KeyDownOrUp += GlobalKeyboardHook_KeyDownOrUp;

            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;
            m_GlobalHook.MouseMoveExt += GlobalHookMouseDrag;
        }

        private void GlobalKeyboardHook_KeyDownOrUp(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (!e.IsUp)
            {
                keyboard.addKey(e.KeyCode);
            } else
            {
                keyboard.removeKey(e.KeyCode);
            }
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouse.L_Click = true;
            } else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mouse.R_Click = true;
            } else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                mouse.M_Click = true;
            }
        }

        private void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouse.L_Click = false;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                mouse.R_Click = false;
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                mouse.M_Click = false;
            }
        }

        private void GlobalHookMouseDrag(object sender, MouseEventExtArgs e)
        {
            mouse.PosX = e.X;
            mouse.PosY = e.Y;
        }

        public void PressKey(VirtualKey key)
        {
            sim.Keyboard.KeyPress((VirtualKeyCode)key);
        }
    }
}
