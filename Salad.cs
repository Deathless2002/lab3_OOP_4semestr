using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Salad : Dish
    {
        public string? TypeOfSalad;

        public Salad()
        {
            this.Type = "Salad";
        }

        public override void ShowInList(DataGridView dgv)
        {
            string price = Convert.ToString(this.Dollar);
            price += "$ ";
            price += Convert.ToString(this.Cents);
            price += "с";


            dgv.Rows.Add(this.Type, this.Name, price, this.Weight, "", "", "", "",this.TypeOfSalad, "", "");
        }

        public override void ShowForEditEdition(Form2 Form2)
        {
            Form2.tbName.Text = this.Name;
            Form2.tbWeight.Text = Convert.ToString(this.Weight);
            Form2.tbDollar.Text = Convert.ToString(this.Dollar);
            Form2.tbCent.Text = Convert.ToString(this.Cents);
            Form2.gbTemperature.Visible = false;
            Form2.lbSubs.Visible = false;
            Form2.lbMeatType.Visible = false;
            Form2.lbMethod.Visible = false;
            Form2.lbSalad.Visible = true;
            Form2.tbUnique.Visible = true;
            Form2.chbGarnish.Visible = false;
            Form2.chbSoup.Visible = false;
            Form2.tbUnique.Text = this.TypeOfSalad;
        }

        public override void Edit(Form2 Form2)
        {
            this.Name = Form2.tbName.Text;
            this.Dollar = Convert.ToInt32(Form2.tbDollar.Text);
            this.Cents = Convert.ToInt32(Form2.tbCent.Text);
            this.Weight = Convert.ToInt32(Form2.tbWeight.Text);
            this.TypeOfSalad = Form2.tbUnique.Text;
           
        }
    }
}
