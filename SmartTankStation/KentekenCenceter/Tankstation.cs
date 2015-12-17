using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCenter
{
    public partial class Tankstation : Form
    {
        Fuelstation fuelstation;
        CommunicationArduino arduino1;
        CommunicationArduino arduino2;

        CommunicationPCs pcconnection;

        public Tankstation()
        {
            InitializeComponent();

            Text = "Welcome to our tankstation";
        
            fuelstation = new Fuelstation();
            pcconnection = new CommunicationPCs(fuelstation);
            fuelstation.setPC(pcconnection);
            arduino1 = new CommunicationArduino(fuelstation, "COM13");
            arduino2 = new CommunicationArduino(fuelstation, "COM12");
            fuelstation.setArduinos(arduino1, arduino2);

            foreach (Car caritem in fuelstation.AllCars)
            {
                listBoxCars.Items.Add(caritem);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduino1.CloseConnection();
            arduino2.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fuelstation.GetFuelType("11-KTF-6").ToString());
            listBoxCars.Items.Clear();
            foreach (Car caritem in fuelstation.AllCars)
            {
                listBoxCars.Items.Add(caritem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fuelstation.GetFuelType("40-NZ-SP").ToString());
            listBoxCars.Items.Clear();
            foreach (Car caritem in fuelstation.AllCars)
            {
                listBoxCars.Items.Add(caritem);
            }
        }


        private void btnDummyTest_Click(object sender, EventArgs e)
        {
            fuelstation.Pay("11-KTF-6", 12m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fuelstation.GetFuelType("59-FK-FB").ToString());
            listBoxCars.Items.Clear();
            foreach (Car caritem in fuelstation.AllCars)
            {
                listBoxCars.Items.Add(caritem);
            }
        }
    }
}
