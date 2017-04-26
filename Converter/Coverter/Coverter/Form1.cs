using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coverter
{
    public partial class FrmConverter : Form
    {
        public FrmConverter()
        {
            InitializeComponent();
        }

        private void FrmConverter_Load(object sender, EventArgs e)
        {
            //set Length measurement as a defaul select
            rdbLength.Checked = true;

            
            //call convert function to display the value of default
            lblOutput.Text = ConV(Convert.ToDouble(NumInput.Value), cmbWstern.SelectedItem.ToString(), cmbAsia.SelectedItem.ToString()).ToString();
           
        }
        
        private double ConV(double input, string ConvFrom, string ConvTo )
        {
            double result=0;
            //Converter for Length
            if (ConvFrom == "Mile")
            {
                if (ConvTo == "Kilometer") result = input * 1.60934;
                if (ConvTo == "Meter") result = input * 1609.34;
                if (ConvTo == "Centimeter") result = input * 160934.00;
                if (ConvTo == "Millimeter") result = input * 1609340.00;
            }
            if (ConvFrom == "Yard")
            {
                if (ConvTo == "Kilometer") result = input * 0.0009144;
                if (ConvTo == "Meter") result = input * 0.9144;
                if (ConvTo == "Centimeter") result = input * 91.44;
                if (ConvTo == "Millimeter") result = input * 914.4;
            }
            if (ConvFrom == "Feet")
            {
                if (ConvTo == "Kilometer") result = input * 0.0003048;
                if (ConvTo == "Meter") result = input * 0.3048;
                if (ConvTo == "Centimeter") result = input * 30.48;
                if (ConvTo == "Millimeter") result = input * 304.8;
            }
            if (ConvFrom == "Inch")
            {
                if (ConvTo == "Kilometer") result = input * 0.0000254;
                if (ConvTo == "Meter") result = input * 0.0254;
                if (ConvTo == "Centimeter") result = input * 2.54;
                if (ConvTo == "Millimeter") result = input * 25.4;
            }

            //converter for tempurature
            if (ConvFrom == "Fehrenheit") result =  (input -32) *5/9;

            //Converter for Weight
            if (ConvFrom == "US-Ton")
            {
                if (ConvTo == "Ton") result = input * 0.907185;
                if (ConvTo == "Killogram") result = input * 907.185;
                if (ConvTo == "Gram") result = input * 907185;
                if (ConvTo == "Milligram") result = input * 907200000;
            }
            if (ConvFrom == "Stone")
            {
                if (ConvTo == "Ton") result = input * 0.00635029;
                if (ConvTo == "Killogram") result = input * 6.35029;
                if (ConvTo == "Gram") result = input * 6350.29;
                if (ConvTo == "Milligram") result = input * 6350000;
            }
            if (ConvFrom == "Pound")
            {
                if (ConvTo == "Ton") result = input * 0.000453592;
                if (ConvTo == "Killogram") result = input * 0.453592;
                if (ConvTo == "Gram") result = input * 453.592;
                if (ConvTo == "Milligram") result = input * 453592;
            }
            if (ConvFrom == "Ounce")
            {
                if (ConvTo == "Ton") result = input * 0.00002834949999179;
                if (ConvTo == "Killogram") result = input * 0.0283495;
                if (ConvTo == "Gram") result = input * 28.3495;
                if (ConvTo == "Milligram") result = input * 28349.5;
            }

            //Converter for Area
            if (ConvFrom == "Square Mile")
            {
                if (ConvTo == "Square kilometer") result = input * 2.58999;
                if (ConvTo == "Square meter") result = input * 2589990.001027;
                if (ConvTo == "Hectare") result = input * 258.999;
                if (ConvTo == "Acre") result = input * 640.00;
            }
            if (ConvFrom == "Square Yard")
            {
                if (ConvTo == "Square kilometer") result = input * 0.00000083613;
                if (ConvTo == "Square meter") result = input * 0.836127;
                if (ConvTo == "Hectare") result = input * 0.000083613;
                if (ConvTo == "Acre") result = input * 0.000206612;
            }
            if (ConvFrom == "Square Feet")
            {
                if (ConvTo == "Square kilometer") result = input * 0.000000092903;
                if (ConvTo == "Square meter") result = input * 0.092903;
                if (ConvTo == "Hectare") result = input * 0.0000092903;
                if (ConvTo == "Acre") result = input * 0.000022957;
            }
            if (ConvFrom == "Square Inch")
            {
                if (ConvTo == "Square kilometer") result = input * 0.00000000064516;
                if (ConvTo == "Square meter") result = input * 0.00064516;
                if (ConvTo == "Hectare") result = input * 0.000000064516;
                if (ConvTo == "Acre") result = input * 0.00000015942;
            }
            // Converter Valume:

            if (ConvFrom == "Barrel")
            {
                if (ConvTo == "Cubbic meter") result = input * 0.1589873;
                if (ConvTo == "Liter") result = input * 158.9873;
                if (ConvTo == "Milliliter") result = input * 158987.3;

            }
            if (ConvFrom == "Gallon")
            {
                if (ConvTo == "Cubbic meter") result = input * 0.00378541;
                if (ConvTo == "Liter") result = input * 3.78541;
                if (ConvTo == "Milliliter") result = input * 3785.41;
            }
            if (ConvFrom == "Guart")
            {
                if (ConvTo == "Cubbic meter") result = input * 0.000946353;
                if (ConvTo == "Liter") result = input * 0.946353;
                if (ConvTo == "Milliliter") result = input * 946.353;
            }
            if (ConvFrom == "Pint")
            {
                if (ConvTo == "Cubbic meter") result = input * 0.000473176;
                if (ConvTo == "Liter") result = input * 0.473176;
                if (ConvTo == "Milliliter") result = input * 473.176;
            }

            return result;
        }

        //Converter measurement unit when American Combo box change
        private void cmbAsia_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cmbAsia.SelectedItem != null && cmbWstern.SelectedItem != null)
            {  
                lblOutput.Text = ConV(Convert.ToDouble(NumInput.Value), cmbWstern.SelectedItem.ToString(), cmbAsia.SelectedItem.ToString()).ToString();
            }
        }
        
        //Converter measurement unit when Australia Combo box change
        private void cmbWstern_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAsia.SelectedItem != null && cmbWstern.SelectedItem != null)
            { 
                lblOutput.Text = ConV(Convert.ToDouble(NumInput.Value), cmbWstern.SelectedItem.ToString(), cmbAsia.SelectedItem.ToString()).ToString();
            }
        }

        //Converter measurement unit when Number UpDown box change
        private void NumInput_ValueChanged(object sender, EventArgs e)
        {
            if (cmbAsia.SelectedItem != null && cmbWstern.SelectedItem != null)
            {
                lblOutput.Text = ConV(Convert.ToDouble(NumInput.Value), cmbWstern.SelectedItem.ToString(), cmbAsia.SelectedItem.ToString()).ToString();
            }
        }

        // Load Measurement Units to ComboBoxes When Type of Measurement Unit Change.

        private void rdbWeiht_CheckedChanged(object sender, EventArgs e)
        {
            cmbWstern.Items.Clear();
            cmbWstern.Items.Add("US-Ton");
            cmbWstern.Items.Add("Stone");
            cmbWstern.Items.Add("Pound");
            cmbWstern.Items.Add("Ounce");
            cmbWstern.SelectedIndex = 2;

            cmbAsia.Items.Clear();
            cmbAsia.Items.Add("Ton");
            cmbAsia.Items.Add("Killogram");
            cmbAsia.Items.Add("Gram");
            cmbAsia.Items.Add("Milligram");
            cmbAsia.SelectedIndex = 1;
           
        }

        private void rdbLength_CheckedChanged(object sender, EventArgs e)
        {
            cmbWstern.Items.Clear();
            cmbWstern.Items.Add("Mile");
            cmbWstern.Items.Add("Yard");
            cmbWstern.Items.Add("Feet");
            cmbWstern.Items.Add("Inch");
            cmbWstern.SelectedIndex = 0;

            cmbAsia.Items.Clear();
            cmbAsia.Items.Add("Kilometer");
            cmbAsia.Items.Add("Meter");
            cmbAsia.Items.Add("Centimeter");
            cmbAsia.Items.Add("Millimeter");
            cmbAsia.SelectedIndex = 0;
        }

        private void rdbArea_CheckedChanged(object sender, EventArgs e)
        {
            cmbWstern.Items.Clear();
            cmbWstern.Items.Add("Square Mile");
            cmbWstern.Items.Add("Square Yard");
            cmbWstern.Items.Add("Square Feet");
            cmbWstern.Items.Add("Square Inch");
            cmbWstern.SelectedIndex = 2;

            cmbAsia.Items.Clear();
            cmbAsia.Items.Add("Square kilometer");
            cmbAsia.Items.Add("Square meter");
            cmbAsia.Items.Add("Hectare");
            cmbAsia.Items.Add("Acre");
            cmbAsia.SelectedIndex = 1;
          
        }

        private void rdbTemperature_CheckedChanged(object sender, EventArgs e)
        {
            cmbWstern.Items.Clear();
            cmbWstern.Items.Add("Fehrenheit");
            cmbWstern.SelectedIndex = 0;

            cmbAsia.Items.Clear();
            cmbAsia.Items.Add("Celsius");
            cmbAsia.SelectedIndex = 0;
            
        }

        private void rdbValume_CheckedChanged(object sender, EventArgs e)
        {
            cmbWstern.Items.Clear();
            cmbWstern.Items.Add("Barrel");
            cmbWstern.Items.Add("Gallon");
            cmbWstern.Items.Add("Guart");
            cmbWstern.Items.Add("Pint");
            cmbWstern.SelectedIndex = 1;

            cmbAsia.Items.Clear();
            cmbAsia.Items.Add("Cubbic meter");
            cmbAsia.Items.Add("Liter");
            cmbAsia.Items.Add("Milliliter");
            cmbAsia.SelectedIndex = 1;

        }
    }
}
