using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public class CManager
    {

        public static List<string[]> AddContact(List<string[]> ContactInfo, string CName, string Number = "")
        {
            for (int i = 0; i < ContactInfo.Count; i++)
            {
                if (CName == ContactInfo[i][0])
                {
                    return ContactInfo;
                }
            }
            ContactInfo.Add(new string[] { CName, Number });
            return ContactInfo;
        }
        public static List<string[]> RemoveContact(string CName, List<string[]> ContactInfo)
        {
            for (int i = 0; i < ContactInfo.Count; i++)
            {
                if (ContactInfo[i][0] == CName)
                {
                    ContactInfo.Remove(ContactInfo[i]);
                }
            }
            return ContactInfo;
        }
        public static List<string[]> ViewAllContacts(List<string[]> ContactInfo)
        {
            return ContactInfo;
        }
        public static List<string[]> ContactsManager(string Action, List<string[]> ContactInfo, string CName = "", string Number = "")
        {
            if (Action == "Add" && CName != "")
            {
                AddContact(ContactInfo, CName, Number);
            }
            if (Action == "Delete")
            {
                RemoveContact(CName, ContactInfo);
            }
            if (Action == "VeiwAll")
            {
               ViewAllContacts(ContactInfo);
            }
            return ContactInfo;
        }
    }
}
