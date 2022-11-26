using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Deck_Builder.MTG
{
    public partial class Loading_Screen : Form
    {
        /*
        TODO:
            this whole code needs to be changed so that it checks a flag for determining
            if "loading_screen" is null
            currently there are a billion race conditions where "loading_screen" could
            be suddenly set to null after it was checked, leading to methods attempting
            to be called on a null and crashing
            this is because its managed by a thread and is volatile

            currently its up to luck whether the user closing the window crashes the
            process
        */

        //CONSTRUCTORS
        public Loading_Screen()
        {
            InitializeComponent();
        }

        //LOADS
        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            i_update_count = 0;
        }

        //MEMBERS
        static public Loading_Screen loading_screen;
        static private int i_update_count;
        static private int i_load_target;
        private delegate void CloseDelegate();
        private delegate void UpdateDelegate(string s);
        private delegate void InitialiseDelegate(int c);
        static private Thread thread;

        //METHODS
        static public void ShowLoadingScreen()
        {
            if (loading_screen == null)
                loading_screen = new Loading_Screen();

            thread = new Thread(new ThreadStart(Loading_Screen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            //handle must be created here or else on multiple run throughs the
            // delegate calls could crash the application
            WaitForHandle();
        }
        
        static public void ShowForm()
        {
            if (loading_screen != null)
                loading_screen.ShowDialog();
        }

        static public void CloseForm()
        {
            if (loading_screen != null)
                loading_screen.Invoke(new CloseDelegate(Loading_Screen.CloseFormInternal));
        }

        static public void UpdateForm(string s)
        {
            if (thread.IsAlive == false || loading_screen == null)
                return;

            loading_screen.Invoke(new UpdateDelegate(Loading_Screen.UpdateFormInternal), s);
        }

        static public void InitialiseForm(int c)
        {
            if (loading_screen != null)
                loading_screen.Invoke(new InitialiseDelegate(Loading_Screen.InitialiseFormInternal), c);
        }

        static private void CloseFormInternal()
        {
            if (loading_screen == null)
                return;

            loading_screen.Close();
            loading_screen = null;
        }

        static private void UpdateFormInternal(string s)
        {
            if (loading_screen == null)
                return;

            loading_screen.Progress_Box.Text = s;
            i_update_count++;
            loading_screen.Progress_Bar.Value = 100 * i_update_count / i_load_target;
        }

        static private void InitialiseFormInternal(int c)
        {
            if (loading_screen == null)
                return;

            loading_screen.Progress_Bar.Value = 0;
            i_load_target = c;
        }

        /*
         TODO:
            Add a counter to WaitForHandle method so that it may timeout after 
            a set amount of time
            When timeout just close the form, thread, and cancel the operation
            This should stop the thread from being held hostage and also allows
            the timeout to be handled
        */

        static private void WaitForHandle()
        {
            bool b_keep_waiting = true;
            while (b_keep_waiting)
            {
                Console.WriteLine("Waiting for handle");
                if (loading_screen == null)
                    b_keep_waiting = false;
                else if (loading_screen.IsHandleCreated)
                    b_keep_waiting = false;

                Thread.Sleep(200);
            }
        }

        private void Loading_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            loading_screen = null;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            JSONManager.cancel_operation();
        }
    }
}
