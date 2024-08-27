using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDiary
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            System.IO.File.Create("\\\\kab-svr-fs02\\Users\\staz\\Pulpit\\Miko³aj Winkiel Praktykant\\StudentDiary\\NowyPlik.txt");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
