using Hotel_Reservation.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hotel_Reservation.Entities;
using Hotel_Reservation.Context;
using System.Linq;

namespace Hotel_Reservation
{
    public partial class kitchenDataGirdView : Form
    {
        public kitchenDataGirdView()
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
            reservationDataGirdView.DataSource = BSrc;
        }

        private void dataGirdView_Load(object sender, EventArgs e)
        {
            LoadGridView();

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            BSrc.EndEdit();
            Context.SaveChanges();
        }
    }
}
