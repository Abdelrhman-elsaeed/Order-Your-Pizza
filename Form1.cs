using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5__Pizza_Project
{
    public partial class Form1 : Form
    {

        public void UpdateToppings()
        {
            UpdateTotalPrice();

            string ToppingsSummary = "";

            if(chkExtraChees.Checked)
            {
                ToppingsSummary += "Extra Chees,";
            }

            if (chkOlives.Checked)
            {
                ToppingsSummary += "Olives,";
            }

            if (chkOnion.Checked)
            {
                ToppingsSummary += "Onine,";
            }

            if (chkTomatoes.Checked)
            {
                ToppingsSummary += "Tomatos,";
            }

            if (chkMushrooms.Checked)
            {
                ToppingsSummary += "Olives,";
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsSummary += "Green Peppers,";
            }

            if (ToppingsSummary == "")
                ToppingsSummary = "No Toppings";

            lbToppings.Text = ToppingsSummary;
        }

        public void UpdateWhereToEat()
        {
            if(rbEatIn.Checked)
            {
                lbWhereToEate.Text = "Eat in";
            }
            else
            {
                lbWhereToEate.Text = "Take Out";
            }

        }

        public void UpdateCrustType()
        {
            if (rbCrustThin.Checked)
            {
                lbCrustType.Text = "Thin";
            }
            else
            {
                lbCrustType.Text = "Thick";
            }

        }

        public void UpdateSize()
        {
            if (rbSizeSmall.Checked)
            {
                lbSize.Text = "Small";
            }
            else if (rbSizeMedium.Checked)
            {
                lbSize.Text = "Medium";
            }
            else
            {
                lbSize.Text = "Large";
            }
           

        }

        public void UpdateTotalPrice()
        {
            float TotalPrice = 0;


            TotalPrice = CalculateToppingsPrice() + CalculateSizePrice() + CalculateCrustTypePrice();

            lbTotalPrice.Text = "$" + TotalPrice;
        }

        public float CalculateToppingsPrice()
        {
            float total=0;

            if (chkExtraChees.Checked)
            {
                total += Convert.ToSingle(chkExtraChees.Tag);
            }

            if(chkOlives.Checked)
            {
                total += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkMushrooms.Checked)
            {
                total += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                total += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                total += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkOnion.Checked)
            {
                total += Convert.ToSingle(chkOnion.Tag);
            }

            return total;
        }

        public float CalculateSizePrice()
        {
          

            if(rbSizeSmall.Checked)
            {
                return Convert.ToSingle(rbSizeSmall.Tag);
                
            }
            else if(rbSizeLarge.Checked)
            {
                return Convert.ToSingle(rbSizeLarge.Tag);
            }
            else
            {
                return Convert.ToSingle(rbSizeMedium.Tag);
            }


        }

        public float CalculateCrustTypePrice()
        {
            if(rbCrustThick.Checked)
            {
                return Convert.ToSingle(rbCrustThick.Tag);
            }
            else
            {
                return Convert.ToSingle(rbCrustThin.Tag);
            }
        }

        public void RestPizzaForm()
        {
            gbCrustSize.Enabled = true;
            gbToppings.Enabled = true;
            gbPizzaSize.Enabled = true;
            gbWhereToEate.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbSizeMedium.Checked = true;
            rbCrustThin.Checked = true;

            rbEatIn.Checked = true;

            chkExtraChees.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
        }



        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rbSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void rbSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void rbSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void rbCrustThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateCrustType();
        }

        private void rbCrustThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateCrustType();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();


        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"are you sure to complete your order cost ${CalculateToppingsPrice() + CalculateSizePrice() + CalculateCrustTypePrice()}" ,"Confirm Order",MessageBoxButtons.OKCancel)
                == (DialogResult.OK) );
            {
                MessageBox.Show("Order Successfully *_*", "Order State");
                gbCrustSize.Enabled  = false;
                gbToppings.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbWhereToEate.Enabled =false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestPizzaForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RestPizzaForm();
            

        }
    }
}
