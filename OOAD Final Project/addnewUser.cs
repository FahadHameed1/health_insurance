using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Final_Project
{
    public partial class addnewUser : Form
    {
        public delegate void useraddedEventHandler(object source, EventArgs e);
        public event useraddedEventHandler useradded;

        server.Service1 myserver = new server.Service1();
        server.User this_user;
        int this_index;

        public addnewUser()
        {
            InitializeComponent();
        }

        public addnewUser(server.User user, int index)
        {
            InitializeComponent();
            this_user = user;
            this_index = index;

            nametxtbox.Text = user.Name;
            emailtxtbox.Text = user.Email;
            phonetxtbox.Text = user.Phone;
            passtxtbox.Text = user.Password;

            addUserBtn.Text = "Save Changes";
        }
        private void addnewUser_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loginMenuButton_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string email = emailtxtbox.Text;
            string password = passtxtbox.Text;
            string username = usernametxtbox.Text;
            string phone = phonetxtbox.Text;

            if(this_user == null)
            {
                myserver.addUser(name, email, password, phone);
            }
            else
            {
                myserver.updateUser(this_index.ToString() ,name, email, password, phone);
            }
            
            Onuseradded();
            this.Hide();
        }

        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog() == DialogResult.OK)
            {
                pictureView.Image = Image.FromStream(op.OpenFile());
            }
        }

        public void Onuseradded()
        {
            if(useradded != null)
            {
                useradded(this, EventArgs.Empty);
            }
        }
    }
}
