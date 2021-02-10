using CCR.Data;
using CCR.Util;
using System.Windows.Forms;

namespace CCR
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            AppRes.InitDirs();
            test();
           
        }

        void test()
        {
            CCRDataAccess ccrda = new CCRDataAccess();
            ccrda.testConnection();
        }
    }
}
