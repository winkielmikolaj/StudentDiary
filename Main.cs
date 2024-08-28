using Microsoft.VisualBasic;
using System.IO;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDiary
{
    public partial class Main : Form
    {
        private string _filePath = $@"{Environment.CurrentDirectory}\students.txt";

        public Main()
        {
            InitializeComponent();
            //list containing all students
            var students = DeserializerFromFile();

            dgvDiary.DataSource = students;

            //var students = new List<Student>();
            //students.Add(new Student() { FirstName = "Jan" });
            //students.Add(new Student() { FirstName = "Marek" });
            //students.Add(new Student() { FirstName = "Gregory" });

            SerializeToFile(students);

            var path = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\NowyPlik2.txt";

            //if (!File.Exists(path))
            //{
            //    //your own path with project
            //    File.Create(path);
            //}

            //File.Delete(path);
            //File.WriteAllText(path, "Hello World!");
            File.AppendAllText(path, "Witaj Œwiecie!\n");

            //var text = File.ReadAllText(path);

            MessageBox.Show("Welcome to StudentDiary!");
        }

        //public void SerializeToFile1(List<Student> students)
        //{
        //    var serializer = new XmlSerializer(typeof(List<Student>));
        //    StreamWriter streamWriter = null;
        //    try
        //    {



        //        streamWriter = new StreamWriter(_filePath);
        //        serializer.Serialize(streamWriter, students);
        //        streamWriter.Close();

        //    }
        //    finally
        //    {
        //        streamWriter.Dispose();
        //    }
        //}

        public void SerializeToFile(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public List<Student> DeserializerFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Student>();
            }

            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (List<Student>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student which you want to edit");

                return;
            }

            var addEditStudent = new AddEditStudent(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditStudent.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvDiary.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Please select a student which you want to edit");

            //    return;
            //}

            //var selectedStudent = dgvDiary.SelectedRows[0];

            //var confirmDelete = MessageBox.Show($"Are you sure you want to delete a student");
            //{
            //    (selectedStudent.Cells[1].Value.ToString() + " " +
            //        selectedStudent.Cells[2].Value.ToString()).Trim();
            //}
            //MessageBoxButtons.OKCancel;
            //);
            var selectedStudent = dgvDiary.SelectedRows[0];

            // Pobranie imienia i nazwiska studenta z wybranych komórek
            var studentName = (selectedStudent.Cells[1].Value.ToString() + " " +
                               selectedStudent.Cells[2].Value.ToString()).Trim();

            // Wyœwietlenie komunikatu potwierdzaj¹cego usuniêcie
            var confirmDelete = MessageBox.Show(
                $"Are you sure you want to delete the student {selectedStudent.Cells[1].Value.ToString()} {selectedStudent.Cells[2].Value.ToString()}?",
                "Confirm Delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            // Sprawdzenie odpowiedzi u¿ytkownika
            if (confirmDelete == DialogResult.OK)
            {
                var students = DeserializerFromFile();
                students.RemoveAll(x => x.Id == Convert.ToInt32(selectedStudent.Cells[0].Value));
                SerializeToFile(students);
                dgvDiary.DataSource = students;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var students = DeserializerFromFile();
            dgvDiary.DataSource = students;
        }
    }
}
