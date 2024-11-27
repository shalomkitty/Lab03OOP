namespace laba3ooop
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            buttonOpen = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonAbout = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(486, 387);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.GreenYellow;
            buttonOpen.Location = new Point(551, 112);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(193, 49);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Select json file";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.MediumSlateBlue;
            buttonEdit.Location = new Point(551, 224);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(193, 58);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit object";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.GreenYellow;
            buttonAdd.Location = new Point(551, 167);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(193, 51);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add object";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MediumSlateBlue;
            buttonDelete.Location = new Point(551, 288);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(193, 55);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete object";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.GreenYellow;
            buttonAbout.Location = new Point(587, 23);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(132, 60);
            buttonAbout.TabIndex = 5;
            buttonAbout.Text = "Info";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.MediumSlateBlue;
            buttonSave.Location = new Point(587, 360);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(132, 50);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save file";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonAbout);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Chornomaz Lab03";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonAbout;
        private Button buttonSave;
    }
}