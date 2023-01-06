using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportExcelWindows
{
    public partial class Loading : Form
    {
        //public Action Worker { set; get; }

        //public Loading(Action worker)
        //{
        //    InitializeComponent();
        //    if (worker == null)
        //        throw new ArgumentException();

        //    Worker = worker;
        //}
        public Loading()
        {
            InitializeComponent();
         
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void Loading_Shown(object sender, EventArgs e)
        {

        }
        //private void progressBar1_Click(object sender, EventArgs e)
        //{

        //}

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); },TaskScheduler.FromCurrentSynchronizationContext());
        //}
    }
}
