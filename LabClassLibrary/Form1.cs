using StudentClassLibrary;

namespace LabClassLibrary
{
    public partial class Form1 : Form
    {
        StudentController controller = new StudentController();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_student_id = this.tbID.Text;
            controller.addStudent2List(input_student_id, input_name);
            string full = "NAME "+tbName.Text +"   "+"ID "+ tbID.Text;
            MessageBox.Show(full);
            displayData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.openFile();
            displayData();
        }
        
        private void displayData() {
            this.tbListofStudent.Text = controller.displayData();
        }
    }
}