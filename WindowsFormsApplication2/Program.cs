using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class PhoneListEntry
    {
        private String Name;
        private String PhoneNum;


        public PhoneListEntry()
        {
        }

        public PhoneListEntry(String newName, String newNum)
        {

            NameAccess = newName;
            PhoneNumAccess = newNum;
        }



        public String NameAccess
        {
            get { return Name; }
            set 
            { 
                Name = value;
            }
        }

        public String PhoneNumAccess
        {
            get { return PhoneNum; }
            set 
            { 
                PhoneNum = value;
            }
        }
    }

    class EntryArray
    {
        private static ArrayList EntryList = new ArrayList(); 

        public static void AddEntry(PhoneListEntry Entry)
        {
            EntryList.Add(Entry);

        }

        public static int ListSize()
        {
            return EntryList.Count;
        }

        public static String GetName(int i)
        {
            return ((PhoneListEntry)EntryList[i]).NameAccess;
        }

        public static String GetNumber(int i)
        {
            return ((PhoneListEntry)EntryList[i]).PhoneNumAccess;
        }

        public static void SetName(int i, String nameSet)
        {
            ((PhoneListEntry)EntryList[i]).NameAccess = nameSet;
        }

        public static void SetNumber(int i, String numberSet)
        {
            ((PhoneListEntry)EntryList[i]).PhoneNumAccess = numberSet;
        }

        public static void DeleteEntry(int i)
        {
            EntryList.RemoveAt(i);
        }

        public static void MoveEntryUp(int i)
        {
            if (i > 0)
            {
                EntryList.Reverse(i - 1, 2);
            }
        }

        public static void MoveEntryDown(int i)
        {
            if ((i < EntryList.Count - 1) && (i > -1))
            {
                EntryList.Reverse(i , 2);
            }
        }
    }


}
