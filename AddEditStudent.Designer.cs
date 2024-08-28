namespace StudentDiary
{
    partial class AddEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbId = new TextBox();
            lbId = new Label();
            lbFirstName = new Label();
            tbFirstName = new TextBox();
            lbLastName = new Label();
            tbLastName = new TextBox();
            lbMath = new Label();
            tbMath = new TextBox();
            lbTechClass = new Label();
            tbTech = new TextBox();
            lbPhysics = new Label();
            tbPhysics = new TextBox();
            lbLang1 = new Label();
            tbLan1 = new TextBox();
            lbLang2 = new Label();
            tbLan2 = new TextBox();
            rtbComments = new RichTextBox();
            lbComments = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Location = new Point(101, 33);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(223, 23);
            tbId.TabIndex = 0;
            tbId.TextChanged += textBox1_TextChanged;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(12, 36);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            lbId.Click += lbId_Click;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(12, 65);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(67, 15);
            lbFirstName.TabIndex = 3;
            lbFirstName.Text = "First Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(101, 62);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(223, 23);
            tbFirstName.TabIndex = 2;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(12, 94);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(66, 15);
            lbLastName.TabIndex = 5;
            lbLastName.Text = "Last Name:";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(101, 91);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(223, 23);
            tbLastName.TabIndex = 4;
            tbLastName.TextChanged += textBox3_TextChanged;
            // 
            // lbMath
            // 
            lbMath.AutoSize = true;
            lbMath.Location = new Point(12, 123);
            lbMath.Name = "lbMath";
            lbMath.Size = new Size(38, 15);
            lbMath.TabIndex = 7;
            lbMath.Text = "Math:";
            // 
            // tbMath
            // 
            tbMath.Location = new Point(101, 120);
            tbMath.Name = "tbMath";
            tbMath.Size = new Size(223, 23);
            tbMath.TabIndex = 6;
            // 
            // lbTechClass
            // 
            lbTechClass.AutoSize = true;
            lbTechClass.Location = new Point(12, 152);
            lbTechClass.Name = "lbTechClass";
            lbTechClass.Size = new Size(64, 15);
            lbTechClass.TabIndex = 9;
            lbTechClass.Text = "Tech Class:";
            // 
            // tbTech
            // 
            tbTech.Location = new Point(101, 149);
            tbTech.Name = "tbTech";
            tbTech.Size = new Size(223, 23);
            tbTech.TabIndex = 8;
            // 
            // lbPhysics
            // 
            lbPhysics.AutoSize = true;
            lbPhysics.Location = new Point(12, 181);
            lbPhysics.Name = "lbPhysics";
            lbPhysics.Size = new Size(49, 15);
            lbPhysics.TabIndex = 11;
            lbPhysics.Text = "Physics:";
            // 
            // tbPhysics
            // 
            tbPhysics.Location = new Point(101, 178);
            tbPhysics.Name = "tbPhysics";
            tbPhysics.Size = new Size(223, 23);
            tbPhysics.TabIndex = 10;
            // 
            // lbLang1
            // 
            lbLang1.AutoSize = true;
            lbLang1.Location = new Point(12, 210);
            lbLang1.Name = "lbLang1";
            lbLang1.Size = new Size(71, 15);
            lbLang1.TabIndex = 13;
            lbLang1.Text = "Language 1:";
            // 
            // tbLan1
            // 
            tbLan1.Location = new Point(101, 207);
            tbLan1.Name = "tbLan1";
            tbLan1.Size = new Size(223, 23);
            tbLan1.TabIndex = 12;
            // 
            // lbLang2
            // 
            lbLang2.AutoSize = true;
            lbLang2.Location = new Point(12, 239);
            lbLang2.Name = "lbLang2";
            lbLang2.Size = new Size(71, 15);
            lbLang2.TabIndex = 15;
            lbLang2.Text = "Language 2:";
            // 
            // tbLan2
            // 
            tbLan2.Location = new Point(101, 237);
            tbLan2.Name = "tbLan2";
            tbLan2.Size = new Size(223, 23);
            tbLan2.TabIndex = 14;
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(101, 263);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(223, 99);
            rtbComments.TabIndex = 16;
            rtbComments.Text = "";
            // 
            // lbComments
            // 
            lbComments.AutoSize = true;
            lbComments.Location = new Point(12, 266);
            lbComments.Name = "lbComments";
            lbComments.Size = new Size(69, 15);
            lbComments.TabIndex = 17;
            lbComments.Text = "Comments:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(249, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(168, 371);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // AddEditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 409);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lbComments);
            Controls.Add(rtbComments);
            Controls.Add(lbLang2);
            Controls.Add(tbLan2);
            Controls.Add(lbLang1);
            Controls.Add(tbLan1);
            Controls.Add(lbPhysics);
            Controls.Add(tbPhysics);
            Controls.Add(lbTechClass);
            Controls.Add(tbTech);
            Controls.Add(lbMath);
            Controls.Add(tbMath);
            Controls.Add(lbLastName);
            Controls.Add(tbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(tbFirstName);
            Controls.Add(lbId);
            Controls.Add(tbId);
            MaximumSize = new Size(362, 448);
            MinimumSize = new Size(362, 448);
            Name = "AddEditStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adding student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private Label lbId;
        private Label lbFirstName;
        private TextBox tbFirstName;
        private Label lbLastName;
        private TextBox tbLastName;
        private Label lbMath;
        private TextBox tbMath;
        private Label lbTechClass;
        private TextBox tbTech;
        private Label lbPhysics;
        private TextBox tbPhysics;
        private Label lbLang1;
        private TextBox tbLan1;
        private Label lbLang2;
        private TextBox tbLan2;
        private RichTextBox rtbComments;
        private Label lbComments;
        private Button btnCancel;
        private Button btnConfirm;
    }
}