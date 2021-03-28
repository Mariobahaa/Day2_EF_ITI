using Hotel_Reservation.Context;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace Hotel_Reservation
{
    public partial class DetaildFormForReservation : Form
    {
        public DetaildFormForReservation()
        {
            InitializeComponent();

            this.FormClosed += (sender, e) => Context.Dispose();
        }


        HotelContext Context = new HotelContext();


        bool addnew = false;
        BindingNavigator bindingNavigator;
        BindingSource reservationBinding;
        BindingSource date;
        private void DetaildFormForReservation_Load(object sender, EventArgs e)
        {
            string str = "march" + "-" + "2" + "-" + "2020";

            string[] arr = str.Split("-");

            Context.Reservations.Load();

            //var Date = reservationContext.Reservations.Select(d => d.birth_day).ToList();

            reservationBinding = new BindingSource(Context.Reservations.Local.ToBindingList(), "");
            //date = new BindingSource(Date, "");

            bindingNavigator = new BindingNavigator(true);
            bindingNavigator.Dock = DockStyle.Top;
            bindingNavigator.BindingSource = reservationBinding;
            this.Controls.Add(bindingNavigator);

            floorCombo.DataSource = Context.Reservations.Select(F => F.room_floor).Distinct().ToList();
            roomnumCombo.DataSource = Context.Reservations.Select(F => F.room_number);
            stateCombo.DataSource = Context.Reservations.Select(F => F.state);
            roomTypeCombo.DataSource = Context.Reservations.Select(F => F.room_type);
            genderCombo.DataSource = Context.Reservations.Select(F => F.gender);

            nameTxt.DataBindings.Add("Text", reservationBinding, "first_name", true);
            lastTxt.DataBindings.Add("Text", reservationBinding, "last_name", true);
            birthDate.DataBindings.Add("Text", reservationBinding, "birth_day", true);

            genderCombo.DataBindings.Add("SelectedValue", reservationBinding, "gender", true);
            phonetxt.DataBindings.Add("Text", reservationBinding, "phone_number", true);
            emailTxt.DataBindings.Add("Text", reservationBinding, "email_address", true);

            streetTxt.DataBindings.Add("Text", reservationBinding, "street_address", true);
            aptTxt.DataBindings.Add("Text", reservationBinding, "apt_suite", true);

            CityTxt.DataBindings.Add("Text", reservationBinding, "city", true);
            stateCombo.DataBindings.Add("SelectedValue", reservationBinding, "state", true);
            zipTxt.DataBindings.Add("Text", reservationBinding, "zip_code", true);

            guestnumCombo.DataBindings.Add("SelectedValue", reservationBinding, "number_guest", true);
            roomTypeCombo.DataBindings.Add("SelectedValue", reservationBinding, "room_type", true);
            floorCombo.DataBindings.Add("SelectedValue", reservationBinding, "room_floor", true);

            roomnumCombo.DataBindings.Add("SelectedValue", reservationBinding, "room_number", true);
            arrivalDate.DataBindings.Add("Value", reservationBinding, "arrival_time", true);
            leavingDat.DataBindings.Add("Value", reservationBinding, "leaving_time", true);

            bindingNavigator.ItemClicked += BindingNavigator_ItemClicked;

          



            //floorCombo.SelectedIndex = floorCombo.
            //if (floorCombo.SelectedValue != null)


        }

        private void BindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //reservationBinding.MoveNext();\
            var arr = birthDate.Text.Split("-");
            //date.MoveNext();
            switch (e.ClickedItem.Text)
            {
                case "Add new":
                    addnew = true;
                    break;
                case "Delete":
                    reservationBinding.EndEdit();
                    Context.SaveChanges();
                    break;
            }
            //floorcombo.selectedindex = floorcombo.findstringexact(floorcombo.selecteditem.tostring());

            //roomnumcombo.selectedindex = roomnumcombo.findstringexact(roomnumcombo.selectedvalue.tostring());
            //roomtypecombo.selectedindex = roomtypecombo.findstringexact(roomtypecombo.selectedvalue.tostring());
            //statecombo.selectedindex = statecombo.findstringexact(statecombo.selectedvalue.tostring());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationsDataGrid RV = new ReservationsDataGrid();
            RV.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addnew)
            {
                var name = nameTxt.Text;
                var lname = lastTxt.Text;
                var dateOdBirth = birthDate.Text;

                var gender = genderCombo.Text;
                var phone = phonetxt.Text;
                var email = emailTxt.Text;

                var address = streetTxt.Text;
                var apt = aptTxt.Text;
                var city = CityTxt.Text;

                var state = stateCombo.Text;
                var zip = zipTxt.Text;
                int numOfguests;
                if (int.TryParse(guestnumCombo.Text , out int numguests))
                {
                     numOfguests = numguests;
                }
                else
                {
                    numOfguests = 1;
                }

                var roomtype = roomTypeCombo.Text;
                var floor = floorCombo.Text;
                var roomNum = roomnumCombo.Text;

                var arrrivalDate = arrivalDate.Value;
                var leavingDate = leavingDat.Value;

                var paymentType = "Visa";
                var totalPill = 500.00;
                var cardType = "Credit";

                var cardNumber = "0000000000000000";
                var cardExp = "beeeb eeeeeb";
                var card_Cvc = "ay7aga";



                var breakFast = 2;
                var lunch = 2;
                var Dinner = 2;
                
                var checkin = true;
                var cleaning = true;
                var towel = true;
                var s_surprise = false;
                var supplyStatus = false;
                var food_bill = 100;


                Context.Reservations.Add(new Entities.Reservation()
                {
                    first_name = name,
                    last_name = lname,
                    birth_day = dateOdBirth,
                    gender = gender,
                    phone_number = phone,
                    email_address = email,
                    street_address = address,
                    apt_suite = apt,
                    city = city,
                    state = state,
                    zip_code = zip,
                    number_guest = numOfguests,
                    room_type = roomtype,
                    room_floor = floor,
                    room_number = roomNum,
                    arrival_time = arrrivalDate,
                    leaving_time = leavingDate,
                    card_number = cardNumber,
                    card_cvc = card_Cvc,
                    card_exp = cardExp,
                    card_type = cardType,
                    payment_type = paymentType,
                    check_in = checkin,
                    break_fast = breakFast,
                    lunch = lunch,
                    dinner = Dinner,
                    cleaning = cleaning,
                    towel = towel,
                    s_surprise = s_surprise,
                    supply_status = supplyStatus,
                    food_bill = food_bill,
                    total_bill = totalPill

                });
                
                //reservationContext.SaveChanges();
                addnew = false;
            }
            reservationBinding.EndEdit();
            Context.SaveChanges();

            MessageBox.Show("Changes were saved !!");
        }

    }
}
