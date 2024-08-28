using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentDiary
{
    public partial class AddEditStudent : Form
    {
        private string _filePath = $@"{Environment.CurrentDirectory}\students.txt";

        private int _studentId;

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            _studentId = id;

            if (id != 0)
            {
                Text = "Editing student";

                var students = DeserializerFromFile();
                var student = students.FirstOrDefault(x => x.Id == id);

                if (student == null)
                {
                    throw new Exception("Id not found");
                }

                tbId.Text = student.Id.ToString();
                tbFirstName.Text = student.FirstName;
                tbLastName.Text = student.LastName;
                tbMath.Text = student.Math;
                tbTech.Text = student.Tech;
                tbPhysics.Text = student.Physics;
                tbLan1.Text = student.Language1;
                tbLan2.Text = student.Language2;
                rtbComments.Text = student.Comments;
            }

            tbFirstName.Select();
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = DeserializerFromFile();

            // Tryb edycji - jeśli _studentId nie jest zerem, aktualizujemy istniejącego studenta
            if (_studentId != 0)
            {
                // Znajdź istniejącego studenta po ID
                var existingStudent = students.FirstOrDefault(x => x.Id == _studentId);
                if (existingStudent != null)
                {
                    // Aktualizuj właściwości istniejącego studenta
                    existingStudent.FirstName = tbFirstName.Text;
                    existingStudent.LastName = tbLastName.Text;
                    existingStudent.Math = tbMath.Text;
                    existingStudent.Tech = tbTech.Text;
                    existingStudent.Physics = tbPhysics.Text;
                    existingStudent.Language1 = tbLan1.Text;
                    existingStudent.Language2 = tbLan2.Text;
                    existingStudent.Comments = rtbComments.Text;
                }
                else
                {
                    MessageBox.Show("Student not found for editing.");
                    return;
                }
            }
            else
            {
                // Tryb dodawania - tworzymy nowego studenta
                var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();
                int newStudentId = (studentWithHighestId != null) ? studentWithHighestId.Id + 1 : 1; // Ustal nowe ID

                // Utwórz nowego studenta z wartościami z formularza
                var newStudent = new Student
                {
                    Id = newStudentId,
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Math = tbMath.Text,
                    Tech = tbTech.Text,
                    Physics = tbPhysics.Text,
                    Language1 = tbLan1.Text,
                    Language2 = tbLan2.Text,
                    Comments = rtbComments.Text,
                };

                students.Add(newStudent);
            }

            // Zapisz zaktualizowaną listę studentów do pliku
            SerializeToFile(students);
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }
    }
}
