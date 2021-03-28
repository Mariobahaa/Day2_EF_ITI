using Hotel_Reservation.Context;
using Hotel_Reservation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Context.Dispose();
        }

        HotelContext Context = new HotelContext();

        public bool frontendVerifier(string username, string password)
        {
            try
            {
                List<Frontend> user = (from F in Context.Frontend
                                           where F.UserName == username && F.PassWord == password
                                           select F).ToList();
                if (user.Count == 1) return true;

            }
            catch { }
            return false;
        }

        public bool kitchenVerifier(string username, string password)
        {
            try
            {
                List<Kitchen> user = (from F in Context.Kitchens
                                       where F.UserName == username && F.PassWord == password
                                       select F).ToList();
                if (user.Count == 1) return true;

            }
            catch { }
            return false;
        }
        private void lgnbtn_Click(object sender, EventArgs e)
        {
            var username =  usrnameTxt.Text;
            var password =  passtext.Text;
            if(frontendVerifier(username,password))
            {
                DetaildFormForReservation f = new DetaildFormForReservation();
                f.Show();
            }
            else if (kitchenVerifier(username, password))
            {
                kitchenDataGirdView f = new kitchenDataGirdView();
                f.Show();
            }

            else
            {
                MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            
        }
    }
}
