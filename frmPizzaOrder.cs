using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pitzza_Project
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        //Get Groups Prices
        float GetSelectedToppingPrice()
        {
            float ToppingPrice = 0;
            if(chkExtraCheese.Checked)
                ToppingPrice +=  Convert.ToSingle(chkExtraCheese.Tag);

            if (chkMushrooms.Checked)
                ToppingPrice += Convert.ToSingle(chkMushrooms.Tag);

            if(chkTomatos.Checked)
                ToppingPrice += Convert.ToSingle(chkTomatos.Tag);

            if(chkOlives.Checked)
                ToppingPrice += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked)
                ToppingPrice += Convert.ToSingle(chkOnion.Tag);

            if(chkGreenPeppar.Checked)
                ToppingPrice += Convert.ToSingle(chkGreenPeppar.Tag);

            return ToppingPrice;

        }
        float GetSelectedCrustTypePrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThinkCrust.Tag);
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        //to Calculate total price
        float CalculateTotalPrice()
        {
            return  (GetSelectedSizePrice() 
                + GetSelectedCrustTypePrice() 
                + GetSelectedToppingPrice());
        }

        //to Update total price label using CalculateTotalPrice() Method
        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice();

        }

        //Update Groups and labels
        void UpdateSize()
        {

            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            else if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return ;
            }

            else if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThinkCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string strToppings = "";

            if (chkExtraCheese.Checked)
                strToppings = "Extra Cheese";

            if (chkMushrooms.Checked)
                strToppings += ", Mushrooms";

            if (chkTomatos.Checked)
                strToppings += ", Tomatos";

            if (chkOnion.Checked)
                strToppings += ", Onion";

            if (chkOlives.Checked)
                strToppings += ", Olives";
            
            if (chkGreenPeppar.Checked)
                strToppings += ", GreenPeppar";


            if(strToppings.StartsWith(", "))
                strToppings = strToppings.Substring(1, strToppings.Length-1);

            if (strToppings == "")
                strToppings = "No Toppings";

            lblToppings.Text = strToppings; 
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            if (rbEatOut.Checked)
            {
                lblWhereToEat.Text = "Eat Out";
                return;
            }
        }

        //To Reset the form and set defult choices
        void ResetForm()
        {
            //Enable Order Button
            UpdateTotalPrice();

            btnOrder.Enabled = true;

            //Enable Group Boxes
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            //Set Defult Size (Mediume)
            rbMedium.Checked = true;

            //Set Defult Crust Type (Thin Crust)
            rbThinCrust.Checked = true;

            //Set Defult Wher To Eate (Eat In)
            rbEatIn.Checked = true;

            //Reset Toppings
            chkExtraCheese.Checked = false;
            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppar.Checked = false;
            chkMushrooms.Checked = false;
            lblToppings.Text = "No Toppings";

            btnOrder.Enabled = true;    
        }

        //to update (Size - Crust - Toppings - WereToEate)
        void UpdateOderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
        }

        //Form Controls
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to make order?", "Confirm Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (DialogResult == DialogResult.Yes) {
            
                btnOrder.Enabled = false;   

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;    
                gbToppings.Enabled = false; 
                gbWhereToEat.Enabled = false;   

            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            gbSize.BackColor = Color.FromArgb(128, 255, 255, 255); // 50% white
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateOderSummary();
        }
    }
}
