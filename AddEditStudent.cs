﻿using System;
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

            if (_studentId != 0)
            {
                students.RemoveAll(x => x.Id == _studentId);
            }
            else
            {
                var studentWithHighestId = students.OrderByDescending(x => x.Id).FirstOrDefault();

                var studentId = 0;
                if (studentWithHighestId == null)
                {
                    studentId = studentWithHighestId.Id + 1;
                }
            }
            //nie mam pojecia co to jest to na dole jakby co, ale wiem ze to to samo co ten if wyzej
            //var studentId = studentWithHighestId == null ? 1 : studentWithHighestId.Id;

            var student = new Student
            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Math = tbMath.Text,
                Tech = tbTech.Text,
                Physics = tbPhysics.Text,
                Language1 = tbLan1.Text,
                Language2 = tbLan2.Text,
                Comments = rtbComments.Text,
            };

            students.Add(student);

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
