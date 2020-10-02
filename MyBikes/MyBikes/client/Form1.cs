using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using MyBikes.bus;

namespace MyBikes.client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index;

        List<Bike> listBike = new List<Bike>();
        List<Mountain> listBikeMountain = new List<Mountain>();
        List<Road> listBikeRoad = new List<Road>();


        private void Form1_Load(object sender, EventArgs e)
        {
            // Enable Mountain CheckedBox
            radioButtonMountain.Checked = true;
            // Mountain Fields
            HFG.Visible = true;
            buttonDisplayMountain.Enabled = true;
            buttonDisplayMountain.Visible = true;
            label7.Visible = true;
            textBoxHFG.Enabled = true;
            textBoxHFG.Visible = true;
            label6.Visible = true;
            comboBoxSuspension.Enabled = true;
            comboBoxSuspension.Visible = true;
            label18.Visible = true;

            // Road Fields
            seatHeight.Visible = false;
            label8.Visible = false;
            buttonDisplayRoad.Enabled = false;
            buttonDisplayRoad.Visible = false;
            textBoxSeatHeight.Enabled = false;
            textBoxSeatHeight.Visible = false;

            // Adding the color list to DropDown
            foreach (EnumColor color in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(color);
            }
            this.comboBoxColor.Text = Convert.ToString(comboBoxColor.Items[0]);

            // Adding the Suspension list to DropDown
            foreach (EnumSuspension suspension in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(suspension);
            }
            this.comboBoxSuspension.Text = Convert.ToString(comboBoxSuspension.Items[0]);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                Mountain m1 = new Mountain();
                m1.SerialNumber = textBoxSerialNumber.Text;
                m1.Brand = textBoxBrand.Text;
                m1.Model = textBoxModel.Text;
                m1.Speed = Convert.ToDouble(textBoxSpeed.Text);
                m1.Color = (EnumColor)comboBoxColor.SelectedItem;
                m1.Suspension = (EnumSuspension)comboBoxSuspension.SelectedItem;
                m1.HeightFromGround = Convert.ToDouble(textBoxHFG.Text);

                Date d1 = new Date();

                d1.Day = Convert.ToInt32(textBoxDay.Text);
                d1.Month = Convert.ToInt32(textBoxMonth.Text);
                d1.Year = Convert.ToInt32(textBoxYear.Text);

                m1.MadeDate = d1;

                Bike b1 = m1;
                listBike.Add(b1);
                listBikeMountain.Add(m1);

            }
            else if (radioButtonRoad.Checked == true)
            {

                Road r1 = new Road();

                r1.SerialNumber = textBoxSerialNumber.Text;
                r1.Brand = textBoxBrand.Text;
                r1.Model = textBoxModel.Text;
                r1.Speed = Convert.ToDouble(textBoxSpeed.Text);
                r1.Color = (EnumColor)comboBoxColor.SelectedItem;
                r1.SeatHeight = Convert.ToDouble(textBoxSeatHeight.Text);

                Date d1 = new Date();

                d1.Day = Convert.ToInt32(textBoxDay.Text);
                d1.Month = Convert.ToInt32(textBoxMonth.Text);
                d1.Year = Convert.ToInt32(textBoxYear.Text);

                r1.MadeDate = d1;

                Bike b2 = r1;
                listBike.Add(b2);
                listBikeRoad.Add(r1);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                listBikeMountain.RemoveAt(index);
            }
            else if (radioButtonRoad.Checked == true)
            {
                listBikeRoad.RemoveAt(index);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                listBikeMountain[index].SerialNumber = textBoxSerialNumber.Text;
                listBikeMountain[index].Brand = textBoxBrand.Text;
                listBikeMountain[index].Model = textBoxModel.Text;
                listBikeMountain[index].Speed = Convert.ToDouble(textBoxSpeed.Text);
                listBikeMountain[index].Color = (EnumColor)comboBoxColor.SelectedIndex;
                listBikeMountain[index].Suspension = (EnumSuspension)comboBoxSuspension.SelectedIndex;
                listBikeMountain[index].HeightFromGround = Convert.ToDouble(textBoxHFG.Text);

                listBikeMountain[index].MadeDate.Day = Convert.ToInt32(textBoxDay.Text);
                listBikeMountain[index].MadeDate.Month = Convert.ToInt32(textBoxMonth.Text);
                listBikeMountain[index].MadeDate.Year = Convert.ToInt32(textBoxYear.Text);

                buttonDisplayMountain_Click(sender, e);
            }
            else if (radioButtonRoad.Checked == true)
            {
                listBikeRoad[index].SerialNumber = textBoxSerialNumber.Text;
                listBikeRoad[index].Brand = textBoxBrand.Text;
                listBikeRoad[index].Model = textBoxModel.Text;
                listBikeRoad[index].Speed = Convert.ToDouble(textBoxSpeed.Text);
                listBikeRoad[index].Color = (EnumColor)comboBoxColor.SelectedIndex;
                listBikeRoad[index].SeatHeight = Convert.ToDouble(textBoxSeatHeight.Text);

                listBikeRoad[index].MadeDate.Day = Convert.ToInt32(textBoxDay.Text);
                listBikeRoad[index].MadeDate.Month = Convert.ToInt32(textBoxMonth.Text);
                listBikeRoad[index].MadeDate.Year = Convert.ToInt32(textBoxYear.Text);

                buttonDisplayRoad_Click(sender, e);

            }
        }
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (listBike.Capacity != 0)
            {
                foreach (Bike bike in listBike)
                {
                    listBoxDisplay.Items.Add(bike);
                }
            }
            else
            {
                MessageBox.Show("No Data For Bike.");
            }

        }
        private void buttonDisplayMountain_Click(object sender, EventArgs e)
        {
            if (listBikeMountain.Capacity != 0)
            {
                foreach (Mountain mountain in listBikeMountain)
                {
                    listBoxDisplay.Items.Add(mountain);
                }
            }
            else
            {
                MessageBox.Show("No Data For Mountain Bike.");
            }
        }

        private void buttonDisplayRoad_Click(object sender, EventArgs e)
        {
            if (listBikeRoad.Capacity != 0)
            {
                foreach (Road road in listBikeRoad)
                {
                    listBoxDisplay.Items.Add(road);
                }
            }
            else
            {
                MessageBox.Show("No Data For Road Bike.");
            }


        }

        private void radioButtonMountain_CheckedChanged(object sender, EventArgs e)
        {
            // Mountain Fields
            HFG.Visible = true;
            buttonDisplayMountain.Enabled = true;
            buttonDisplayMountain.Visible = true;
            label7.Visible = true;
            textBoxHFG.Enabled = true;
            textBoxHFG.Visible = true;
            label6.Visible = true;
            comboBoxSuspension.Enabled = true;
            comboBoxSuspension.Visible = true;
            label18.Visible = true;

            // Road Fields
            seatHeight.Visible = false;
            label8.Visible = false;
            buttonDisplayRoad.Enabled = false;
            buttonDisplayRoad.Visible = false;
            textBoxSeatHeight.Enabled = false;
            textBoxSeatHeight.Visible = false;
        }

        private void radioButtonRoad_CheckedChanged(object sender, EventArgs e)
        {
            // Mountain Fields
            HFG.Visible = false;
            buttonDisplayMountain.Enabled = false;
            buttonDisplayMountain.Visible = false;
            label7.Visible = false;
            textBoxHFG.Enabled = false;
            textBoxHFG.Visible = false;
            label6.Visible = false;
            comboBoxSuspension.Enabled = false;
            comboBoxSuspension.Visible = false;
            label18.Visible = false;

            // Road Fields
            seatHeight.Visible = true;
            label8.Visible = true;
            buttonDisplayRoad.Enabled = true;
            buttonDisplayRoad.Visible = true;
            textBoxSeatHeight.Enabled = true;
            textBoxSeatHeight.Visible = true;
        }

        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxDisplay.SelectedIndex;

            if (radioButtonMountain.Checked == true)
            {
                radioButtonMountain.Checked = true;

                textBoxSerialNumber.Text = listBikeMountain[index].SerialNumber;
                textBoxBrand.Text = listBikeMountain[index].Brand;
                textBoxModel.Text = listBikeMountain[index].Model;
                textBoxSpeed.Text = Convert.ToString(listBikeMountain[index].Speed);
                comboBoxColor.Text = Convert.ToString(listBikeMountain[index].Color);
                comboBoxSuspension.Text = Convert.ToString(listBikeMountain[index].Suspension);
                textBoxHFG.Text = Convert.ToString(listBikeMountain[index].HeightFromGround);

                textBoxDay.Text = Convert.ToString(listBikeMountain[index].MadeDate.Day);
                textBoxMonth.Text = Convert.ToString(listBikeMountain[index].MadeDate.Month);
                textBoxYear.Text = Convert.ToString(listBikeMountain[index].MadeDate.Year);


            }
            else if (radioButtonRoad.Checked == true)
            {
                radioButtonRoad.Checked = true;

                textBoxSerialNumber.Text = listBikeRoad[index].SerialNumber;
                textBoxBrand.Text = listBikeRoad[index].Brand;
                textBoxModel.Text = listBikeRoad[index].Model;
                textBoxSpeed.Text = Convert.ToString(listBikeRoad[index].Speed);
                comboBoxColor.Text = Convert.ToString(listBikeRoad[index].Color);
                textBoxSeatHeight.Text = Convert.ToString(listBikeRoad[index].SeatHeight);

                textBoxDay.Text = Convert.ToString(listBikeRoad[index].MadeDate.Day);
                textBoxMonth.Text = Convert.ToString(listBikeRoad[index].MadeDate.Month);
                textBoxYear.Text = Convert.ToString(listBikeRoad[index].MadeDate.Year);

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }

            comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);
            comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);
            listBoxDisplay.Items.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            string sNumber = textBoxSearch.Text;

            if (radioButtonMountain.Checked == true)
            {
                Mountain temp = new Mountain();

                foreach (Mountain bike in listBikeMountain)
                {
                    if (String.Compare(bike.SerialNumber, sNumber) == 0)
                    {
                        temp = bike;
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Mountain Bike Found....\n" + temp);
                }
                else
                {
                    MessageBox.Show("Mountain Bike Not Found");
                }
            }
            else if (radioButtonRoad.Checked == true)
            {
                Road temp = new Road();

                foreach (Road bike in listBikeRoad)
                {
                    if (string.Equals(bike.SerialNumber, sNumber))
                    {
                        temp = bike;
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    MessageBox.Show("Road Bike Found....\n" + temp);
                }
                else
                {
                    MessageBox.Show("Road Bike Not Found");
                }
            }
        }

        // Save to Xml File
        private void saveXml_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                //FileHandler.SaveToXmlMountain(listBikeMountain);

                IFileHandler interface1 = new FileHandler();
                interface1.SaveToXmlMountain(listBikeMountain);
            }
            else if (radioButtonRoad.Checked == true)
            {
                //FileHandler.SaveToXmlRoad(listBikeRoad);

                IFileHandler interface1 = new FileHandler();
                interface1.SaveToXmlRoad(listBikeRoad);
            }

            IFileHandler interface2 = new FileHandler();
            interface2.SaveToXmlBike(listBike);

        }

        // Read from xml
        private void readxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonMountain.Checked == true)
            {
                IFileHandler interface1 = new FileHandler();
                listBikeMountain = interface1.ReadFromXmlMountain(listBikeMountain);

                foreach (Mountain mountain in listBikeMountain)
                {
                    this.listBoxDisplay.Items.Add(mountain);
                }

            }
            else if (radioButtonRoad.Checked == true)
            {
                IFileHandler interface1 = new FileHandler();
                listBikeRoad = interface1.ReadFromXmlRoad(listBikeRoad);

                foreach (Road road in listBikeRoad)
                {
                    this.listBoxDisplay.Items.Add(road);
                }
            }

            //IFileHandler interface2 = new FileHandler();
            //listBike = interface2.ReadFromXmlBike(listBike);

            //foreach (Bike bike in listBike)
            //{
            //    this.listBoxDisplay.Items.Add(bike);
            //}
        }

        // Save to Txt File
        private void saveTxt_Click(object sender, EventArgs e)
        {
            //if (radioButtonMountain.Checked == true)
            //{
            //    //FileHandler.SaveToTxtMountain(listBikeMountain);

            //    IFileHandler interface1 = new FileHandler();
            //    interface1.SaveToTxtMountain(listBikeMountain);

            //}
            //else if (radioButtonRoad.Checked == true)
            //{
            //    //FileHandler.SaveToTxtRoad(listBikeRoad);

            //    IFileHandler interface1 = new FileHandler();
            //    interface1.SaveToTxtRoad(listBikeRoad);
            //}

            //IFileHandler interface2 = new FileHandler();
            //interface2.SaveToTxtBike(listBike);

        }

        // Read From Txt
        private void readtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Save to Binary File
        private void saveBin_Click(object sender, EventArgs e)
        {
            //if (radioButtonMountain.Checked == true)
            //{
            //    //FileHandler.SaveToBinMountain(listBikeMountain);

            //    IFileHandler interface1 = new FileHandler();
            //    interface1.SaveToBinMountain(listBikeMountain);
            //}
            //else if (radioButtonRoad.Checked == true)
            //{
            //    //FileHandler.SaveToBinRoad(listBikeRoad);

            //    IFileHandler interface1 = new FileHandler();
            //    interface1.SaveToBinRoad(listBikeRoad);
            //}

            //IFileHandler interface2 = new FileHandler();
            //interface2.SaveToBinBike(listBike);       
        }

        // Read From Bin
        private void readbinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSerialNumber_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsLetterAndDigitCheck(errorProvider1, textBoxSerialNumber);
        }

        private void textBoxBrand_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsLetterCheck(errorProvider2, textBoxBrand);
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsLetterAndDigitCheck(errorProvider3, textBoxModel);
        }

        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider4, textBoxSpeed);
        }

        private void textBoxHFG_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider5, textBoxHFG);
        }

        private void textBoxSeatHeight_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider6, textBoxSeatHeight);
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider7, textBoxYear);
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider7, textBoxMonth);
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
            ICheckErrorProvider checkErrorProvider = new CheckErrorProvider();

            checkErrorProvider.IsDigitCheck(errorProvider7, textBoxDay);
        }

        
    }
}
