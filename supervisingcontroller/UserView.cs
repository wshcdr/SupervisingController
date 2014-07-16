using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace supervisingcontroller
{
    public partial class UserView : Form , IView
    {
        public event Action UpdateId;
        public event Action UpdateName;

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private UserControllor _controllor;


        UserControllor getController()
        {
            return _controllor;
        }





        public UserView()
        {
            InitializeComponent();

            _controllor = new UserControllor(this);
            this.textBox1.DataBindings.Add("Text", _controllor.Model, "ID");
            this.textBox2.DataBindings.Add("Text", _controllor.Model, "Name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //改变VIEW的UI控件的值，Controllor的Model会跟着变
            //this.textBox1.Text = "1";
            //this.textBox2.Text = "one";
            //Controllor.UpdatePerson();
            if (null != UpdateId)
            {
                this.UpdateId();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //改变Controllor的Model的值，VIEW的UI控件的值会跟着变
            //Controllor.Model.ID = "2";
            //Controllor.Model.Name = "two";

            //Controllor.UpdatePerson();

            if (this.UpdateName != null)
            {
                this.UpdateName();
            }
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "updateId";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "updateName";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "updateName";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 5;
            // 
            // UserView
            // 
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controllor.Model.Name = textBox3.Text;
            _controllor.UpdateUser();
        }
    }
}
