using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Hospital
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void CloseAll()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void iCD11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FormICD_11 idc = new FormICD_11();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }
        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FormDoctor idc = new FormDoctor();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FormPatient idc = new FormPatient();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }
        private void newMeetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FormNewMeeting idc = new FormNewMeeting();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }
        private void meetingNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FormMeeting idc = new FormMeeting();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }
    }
}
