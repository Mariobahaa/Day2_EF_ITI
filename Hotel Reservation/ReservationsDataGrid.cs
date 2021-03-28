using Hotel_Reservation.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class ReservationsDataGrid : Form
    {
        public ReservationsDataGrid()
        {
            InitializeComponent();

            this.FormClosed += (sender, e) => Context.Dispose();
        }

        HotelContext Context = new HotelContext();
        BindingSource BSrc;
        private void LoadGridView()
        {

            BSrc = new BindingSource();
            Context.Reservations.Load();
            BSrc.DataSource = Context.Reservations.Local.ToBindingList();
            dataGridView1.DataSource = BSrc;
        }

    
        private void ReservationsDataGrid_Load(object sender, EventArgs e)
        {
            LoadGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BSrc.EndEdit();
            Context.SaveChanges();
        }
    }
}
