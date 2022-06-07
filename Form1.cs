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
using System.Reflection;



namespace OOP3
{
    public partial class Form1 : Form
    {
        public static bool Adding;

        public static bool GetAdd { set { } get { return Adding; } }

        public delegate void Add(Dish dish);
        public delegate void Edit(Dish dish);

        public Add add;
        public Edit edit;


        public int index;
        public List<Dish> listDish = new List<Dish>();
        public Dish dish = new Dish();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Owner = this;
            Form2.gbTemperature.Visible = true;
            Form2.lbSubs.Visible = false;
            Form2.lbMeatType.Visible = false;
            Form2.lbMethod.Visible = false;
            Form2.lbSalad.Visible = false;
            Form2.tbUnique.Visible = false;
            Form2.chbGarnish.Visible = false;
            Form2.chbSoup.Visible = false;
            Adding = true;
            Form2.Show();
        }


        public void ShowList(List<Dish> list)
        {
            dgvDishes.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ShowInList(dgvDishes);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Owner = this;
            index = dgvDishes.CurrentRow.Index;
            Form2.gbDish.Visible = false;
            listDish[index].ShowForEditEdition(Form2);
            Adding = false;
            Form2.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = dgvDishes.CurrentRow.Index;
            listDish.RemoveAt(index);
            ShowList(listDish);
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string name;
                FileStream f = new FileStream(saveFD.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(f);
                for (int i = 0; i < listDish.Count; i++)
                {
                    writer.WriteLine("Ёкземпл€р класса:" + listDish[i].Type);
                    foreach (FieldInfo field in listDish[i].GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static
                        | BindingFlags.NonPublic))
                    {
                        string s = field.Name + " "
                            + field.GetValue(listDish[i]).ToString();
                        writer.WriteLine(s);
                    }
                    writer.WriteLine("===");
                }
                writer.Close();
                f.Close();
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Deserialization deserialization = Deserialization.GetDeserialization(openFD.FileName);
                List<Dish> newListDish = new List<Dish>();
                newListDish = deserialization.Deserialize();
                if (newListDish != null)
                {
                    listDish.Clear();
                    listDish = newListDish;
                    ShowList(listDish);
                }


            }
        }
    }
}