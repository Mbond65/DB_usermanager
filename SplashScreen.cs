using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DBUserManager
{
    public partial class SplashScreen : Form
    {
        public const double _softwareVersion = 1.0;
        public const string _softwareName = "DB User Manager";
        public const string _softwareID = "c68e0e60-b0be-435f-9dd7-b24178890312";
        public Timer _tmr;

        public SplashScreen()
        {
            InitializeComponent();
        }
        public void SplashScreen_Load(object sender, EventArgs e)
        {
        
            _tmr = new Timer();
            _tmr.Interval = 3000;
            _tmr.Start();
            _tmr.Tick += tmr_Tick;
        }
        public void tmr_Tick(object sender, EventArgs e)
        {
            _tmr.Stop();
            MetroForm form = new DBUserManager();
            form.Show();
            this.Hide();
        }
    }
}
