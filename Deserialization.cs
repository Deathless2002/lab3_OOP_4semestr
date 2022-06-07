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
    internal class Deserialization
    {

        Dictionary<string, int> NumberOfAttributes = new Dictionary<string, int>()
        {
            { "Drink", 6 },
            { "Meat", 7 },
            { "VeganMainDish", 7 },
            { "Salad", 6 },
            { "Garnish", 6 },
            { "Soup", 6 }

        };
        public string FileName;
        private Deserialization(string fileName)
        {
            this.FileName = fileName;
        }
        private static Deserialization deserialization;
        public static Deserialization GetDeserialization(string fileName)
        {
            deserialization = new Deserialization(fileName);

            return deserialization;
        }

        private Dish GetDish(string type, StreamReader reader)
        {
            int counter = 0, result;
            Type mytype = typeof(Dish);
            IEnumerable<Type> list = Assembly.GetAssembly(mytype).GetTypes().Where(type => type.IsSubclassOf(mytype));
            foreach (Type myitem in list)
            {
                if (myitem.Name == type)
                {
                    Dish instance = (Dish)Activator.CreateInstance(myitem);
                    string line, name = "", val = "";
                    int i;
                    bool done = false;
                    while (!reader.EndOfStream && !done)
                    {
                        line = reader.ReadLine();
                        if (line == "===")
                        {
                            done = true;
                            break;
                        }
                        i = 0;
                        name = "";
                        while (line[i] != ' ')
                        {
                            name = name + line[i];
                            i++;
                        }
                        i++;
                        val = "";
                        while (i < line.Length)
                        {
                            val = val + line[i];
                            i++;
                        }
                        FieldInfo[] fieldInfo = instance.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static
                        | BindingFlags.NonPublic);
                        foreach (FieldInfo field in fieldInfo)
                        {
                            if ((field.Name == name) && (val != ""))
                            {
                                try
                                {
                                    counter++;
                                    if ((val == "True") || (val == "False"))
                                    {
                                        field.SetValue(instance, Convert.ToBoolean(val)); ;
                                    }
                                   else field.SetValue(instance, val);
                                }
                                catch (Exception e)

                                {
                                    //MessageBox.Show(e.Message);
                                    if (int.TryParse(val, out result) == false)
                                        return null;
                                    else field.SetValue(instance, result);

                                }

                            }
                        }
                    }
                    if (counter == NumberOfAttributes[type])
                        return instance ;
                    else return null;
                }
            }
            return null;
        }

        public List<Dish> Deserialize()
        {
            List<Dish> list = new List<Dish>();
            string s, type = "";
            int len;
            FileStream fs = new FileStream(this.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            try
            {
                while (!reader.EndOfStream)
                {

                    s = reader.ReadLine();

                    if (s.Contains(':'))
                    {
                        type = "";
                        len = s.Length;
                        for (int i = s.IndexOf(':') + 1; i < len; i++)
                        {
                            type = type + s[i];
                        }
                    }
                    list.Add(GetDish(type, reader));
                    if (list[list.Count - 1] == null)
                        throw new Exception();
                       
                    
                }
                return list;

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
                        return null;
            }
            finally
            {
                fs.Close();
                reader.Close();
            }
           
           
            
        }



    }
}
