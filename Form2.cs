using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbDrink_CheckedChanged(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = drink;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = true;
            lbSubs.Visible = false;
            lbMeatType.Visible = false;
            lbMethod.Visible = false;
            lbSalad.Visible = false;
            tbUnique.Visible = false;
            chbGarnish.Visible = false;
            chbSoup.Visible = false;
            Form1.add = dish =>
            {
                AddDrink(drink);
            };
        }


        private void AddDrink(Drink drink)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception(); 
            drink.Name = tbName.Text;
            drink.Weight = Convert.ToInt32(tbWeight.Text);
            if (rbCold.Checked) { drink.Temperature = false; }
            else { drink.Temperature = true; }
            drink.Dollar = Convert.ToInt32(tbDollar.Text);
            drink.Cents = Convert.ToInt32(tbCent.Text);
            Form1.listDish.Add(drink);
        }

        private void rbGarnish_CheckedChanged(object sender, EventArgs e)
        {
            Garnish garnish = new Garnish();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = garnish;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = false;
            lbSubs.Visible = false;
            lbMeatType.Visible = false;
            lbMethod.Visible = true;
            lbSalad.Visible = false;
            tbUnique.Visible = true;
            chbGarnish.Visible = false;
            chbSoup.Visible = false;
            Form1.add = dish =>
            {
                AddGarnish(garnish);
            };
        }

        private void AddGarnish(Garnish garnish)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "" || tbUnique.Text == "") throw new Exception(); 
            garnish.Name = tbName.Text;
            garnish.Method = tbUnique.Text;
            garnish.Weight = Convert.ToInt32(tbWeight.Text);
            garnish.Dollar = Convert.ToInt32(tbDollar.Text);
            garnish.Cents = Convert.ToInt32(tbCent.Text);
            Form1.listDish.Add(garnish);
        }

        private void rbMeatMD_CheckedChanged(object sender, EventArgs e)
        {
            Meat meat = new Meat();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = meat;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = false;
            lbSubs.Visible = false;
            lbMeatType.Visible = true;
            lbMethod.Visible = false;
            lbSalad.Visible = false;
            tbUnique.Visible = true;
            chbGarnish.Visible = true;
            chbSoup.Visible = false;
            Form1.add = dish =>
            {
                AddMeat(meat);
            };
        }


        private void AddMeat(Meat meat)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "" || tbUnique.Text == "") throw new Exception(); meat.Name = tbName.Text;
            meat.TypeOfMeat = tbUnique.Text;
            meat.Weight = Convert.ToInt32(tbWeight.Text);
            meat.Dollar = Convert.ToInt32(tbDollar.Text);
            meat.Cents = Convert.ToInt32(tbCent.Text);
            if (!chbGarnish.Checked) { meat.Garnish = false; }
            else { meat.Garnish = true; }

            Form1.listDish.Add(meat);
        }

        private void rbVeganMD_CheckedChanged(object sender, EventArgs e)
        {
            VeganMainDish veg = new VeganMainDish();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = veg;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = false;
            lbSubs.Visible = true;
            lbMeatType.Visible = false;
            lbMethod.Visible = false;
            lbSalad.Visible = false;
            tbUnique.Visible = true;
            chbGarnish.Visible = true;
            chbSoup.Visible = false;
            Form1.add = dish =>
            {
                AddVegan(veg);
            };
        }


        private void AddVegan(VeganMainDish veg)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "" || tbUnique.Text == "") throw new Exception(); veg.Name = tbName.Text;
            veg.Substitute = tbUnique.Text;
            veg.Weight = Convert.ToInt32(tbWeight.Text);
            veg.Dollar = Convert.ToInt32(tbDollar.Text);
            veg.Cents = Convert.ToInt32(tbCent.Text);
            if (!chbGarnish.Checked) { veg.Garnish = false; }
            else { veg.Garnish = true; }
            Form1.listDish.Add(veg);
        }

        private void rbSoup_CheckedChanged(object sender, EventArgs e)
        {
            Soup soup = new Soup();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = soup;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = false;
            lbSubs.Visible = false;
            lbMeatType.Visible = false;
            lbMethod.Visible = false;
            lbSalad.Visible = false;
            tbUnique.Visible = false;
            chbGarnish.Visible = false;
            chbSoup.Visible = true;
            Form1.add = dish =>
            {
                AddSoup(soup);
            };
        }

        private void AddSoup(Soup soup)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "") throw new Exception(); 
            soup.Name = tbName.Text;
            soup.Weight = Convert.ToInt32(tbWeight.Text);
            soup.Dollar = Convert.ToInt32(tbDollar.Text);
            soup.Cents = Convert.ToInt32(tbCent.Text);
            if (!chbSoup.Checked) { soup.Cream_soup = false; }
            else { soup.Cream_soup = true; }
            Form1.listDish.Add(soup);
        }

        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            Salad salad = new Salad();
            Form1 Form1 = (Form1)this.Owner;
            Form1.dish = salad;
            Dish printedEdition = Form1.dish;
            btnOK.Visible = true;
            gbTemperature.Visible = false;
            lbSubs.Visible = false;
            lbMeatType.Visible = false;
            lbMethod.Visible = false;
            lbSalad.Visible = true;
            tbUnique.Visible = true;
            chbGarnish.Visible = false;
            chbSoup.Visible = false;
            Form1.add = dish =>
            {
                AddSalad(salad);
            };

        }

        private void AddSalad(Salad salad)
        {
            Form1 Form1 = (Form1)this.Owner;
            if (tbName.Text == "" || tbUnique.Text == "") throw new Exception(); salad.Name = tbName.Text;
            salad.TypeOfSalad = tbUnique.Text;
            salad.Weight = Convert.ToInt32(tbWeight.Text);
            salad.Dollar = Convert.ToInt32(tbDollar.Text);
            salad.Cents = Convert.ToInt32(tbCent.Text);
            Form1.listDish.Add(salad);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Form1.GetAdd)
            {
                try
                {
                    Form1 Form1 = (Form1)this.Owner;
                    Dish dish = Form1.dish;
                    Form1.add(dish);
                    Form1.ShowList(Form1.listDish);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Поля заполнены неверно!");
                }
               
            }
            else
            {
                try
                {      
                Form1 Form1 = (Form1)this.Owner;       
                Form1.listDish[Form1.index].Edit(this);
                Form1.ShowList(Form1.listDish);
                Close();
                }
                catch
                {
                    MessageBox.Show("Поля заполнены неверно!");
                }
               
            }
        }
    }
}
