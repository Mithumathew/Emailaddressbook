using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parctice_home
{
    class VM : INotifyPropertyChanged
    {    //declaring all the variables
        private List<string> namelist;
        public List<string> Namelist
        {
            get { return namelist; }
            set { namelist = value; OnPropertyChanged(); }
        }

        private string persontext;
        public string Persontext
        {
            get { return persontext; }
            set { persontext = value; OnPropertyChanged(); }
        }

        List<Person> Personlist = new List<Person>();
        //Method to add name to list and display the details in textbox
        public void Getlist()
        {    //reading the txt file
            StreamReader sr = new StreamReader("names.txt");
            namelist = new List<string>();
            while (sr.Peek() != -1)
            {
                Person p = new parctice_home.Person();
                p.Name = sr.ReadLine();
                p.Email = sr.ReadLine();
                p.Phone = sr.ReadLine();
                Personlist.Add(p);
            }

            for (int i = 0; i < Personlist.Count; i++)
            { namelist.Add(Personlist[i].Name); }
        }
        //Method to display the selected anme in the textbox
        public void Selector( int index)
        {
            Persontext ="Name: "+ Personlist[index].Name + "\n" + "Email:"+ Personlist[index].Email + "\n" +"Phoneno: "+ Personlist[index].Phone;
        }








        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
