using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Drink: Dish
    {
        public bool Temperature;


        public Drink()
        {
            this.Type = "Drink";
        }

        public override void ShowInList(DataGridView dgv)
        {
            string price = Convert.ToString(this.Dollar);
            price += "$ ";
            price += Convert.ToString(this.Cents);
            price += "с";

            string Temp;
            if (this.Temperature)
            {
                Temp = "Горячий";
            } else
            {
                Temp = "Холодный";
            }

            dgv.Rows.Add(this.Type, this.Name, price, this.Weight, Temp, "", "", "", "", "");
        }

        public override void ShowForEditEdition(Form2 Form2)
        {
            Form2.tbName.Text = this.Name;
            Form2.tbWeight.Text = Convert.ToString(this.Weight);
            Form2.tbDollar.Text = Convert.ToString(this.Dollar);
            Form2.tbCent.Text = Convert.ToString(this.Cents);
            Form2.gbTemperature.Visible = true;
            Form2.lbSubs.Visible = false;
            Form2.lbMeatType.Visible = false;
            Form2.lbMethod.Visible = false;
            Form2.lbSalad.Visible = false;
            Form2.tbUnique.Visible = false;
            Form2.chbGarnish.Visible = false;
            Form2.chbSoup.Visible = false;
            if (this.Temperature)
            {
                Form2.rbHot.Checked = true;
            }
            else
            {
                Form2.rbCold.Checked = true;
            }
        }


        public override void Edit(Form2 Form2)
        {
            this.Name = Form2.tbName.Text;
            this.Dollar = Convert.ToInt32(Form2.tbDollar.Text);
            this.Cents = Convert.ToInt32(Form2.tbCent.Text);
            this.Weight = Convert.ToInt32(Form2.tbWeight.Text);
            if (Form2.rbHot.Checked)
            {
                this.Temperature = true;
            }
            else
            {
                this.Temperature = false;
            }
        }

    }
}
