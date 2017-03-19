using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Mission_adding
    {
        List<int> Mission_ID = new List<int>();
        List<string> Mission_Name = new List<string>();
        List<string> Mission_Text = new List<string>();

        public Mission_adding()
        {
            //---- 1. část ----

            //---- 1. kapitola
            Mission_ID.Add(0);
            Mission_ID.Add(1);
            Mission_ID.Add(2);
            Mission_ID.Add(3);


            //---- 1. kapitola
            Mission_Name.Add("Úvod");
            Mission_Name.Add("Výběr pomocníků");
            Mission_Name.Add("Štít");
            Mission_Name.Add("Kamínky");
            Mission_Name.Add("Pochod");


            Mission_Text.Add("Vítám tě ve hře. Včera nás přepadli zlý bojovnící, sebrali nám skoro vše. To nejdůležitější je, že vza-li kámen, který pohánní náš strom života. Je tedy na tobě, aby si ho získal zpět. Budeš muset jít, až do země, které se říká svět Chrámů.");
            Mission_Text.Add("Záchrana nebude vůbec jednoduchá, proto si vem sebou 2 ze 3 nabízených pomocníků. Šermíř ti přidá 50 bodů obrany, lučištník útok zdvojnásobí, ale soupeř ten tah útočí 2x. Léčitel přidá na konci tahu 1/4 tvých životů.");
            Mission_Text.Add("Po výběru ti vůdce tvé vesnice nabídnul štít. Cheš ho nebo ne? Rozhodni se a můžeme pokračovat.");
            Mission_Text.Add("Ještě než si vyšel zastavil tě tvůj kamarád a nabízí ti kamínky, za které si můžeš v budoucnu něco koupit. Vem si je budou se hodit.");
            Mission_Text.Add("Teď, když máš základní výbavu můžeme se vydat na výpravu.");

           
        
        }
        /* private List<Mission> Mission()
         {
             // List<Mission> missions = new List<Mission>();
             List<Mission> missions = new List<Mission>();
             //ObservableCollection<Mission> dataList = new ObservableCollection<Mission>();
             missions.Add(new Mission { Done = false, Level = 1, Mission_text = "ahoj :)", Mission_description = "musis tohle", Enemy_HP = 500, Enemy_Attack = 50, Enemy_defense = 5, Enemy_name = "mocný idiot", Enemy_Strenght = 5, Mission_name = "sejmi idiota", Reward = 100 });
             missions.Add(new Mission { Done = true, Level = 2, Mission_text = "ahodgdfj :)", Mission_description = "a tady zas tohle", Enemy_HP = 40, Enemy_Attack = 60, Enemy_defense = 4, Enemy_name = "idiot", Enemy_Strenght = 4, Mission_name = "sejmi", Reward = 500 });
             // dataList.Add(missions);,


             //listView.ItemsSource = dataList;
             return missions ;
         }
         public string GetMissionDescription()
         {
             return 
         }*/
        
        
        public string GetMissionName(int num)
        {
            string name = Mission_Name[num];
            return name;
        }

        public string GetMissionText(int num)
        {
            string text = Mission_Text[num];
            return text;
        }
    }
}
