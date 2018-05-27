using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RayTracing rt = new RayTracing();

        private void Application_Idle(object sender, PaintEventArgs e)
        {
            glControl1_Paint(sender, e);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            rt.Update();
            glControl1.SwapBuffers();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            rt.Resize(glControl1.Width, glControl1.Height);
        }
    }
}
