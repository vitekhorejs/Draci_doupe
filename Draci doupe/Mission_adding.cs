using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Mission_adding
    {
        
        //public List<Mission> Mission()
        //{
            // List<Mission> missions = new List<Mission>();
            List<Mission> missions = new List<Mission>();
            //ObservableCollection<Mission> dataList = new ObservableCollection<Mission>();
            missions.Add(new Mission { Done = false, Level = 1, Mission_text = "ahoj :)", Mission_description = "musis tohle", Enemy_HP = 500, Enemy_Attack = 50, Enemy_defense = 5, Enemy_name = "mocný idiot", Enemy_Strenght = 5, Mission_name = "sejmi idiota", Reward = 100 });
            missions.Add(new Mission { Done = true, Level = 2, Mission_text = "ahodgdfj :)", Mission_description = "a tady zas tohle", Enemy_HP = 40, Enemy_Attack = 60, Enemy_defense = 4, Enemy_name = "idiot", Enemy_Strenght = 4, Mission_name = "sejmi", Reward = 500 });
            // dataList.Add(missions);

            
            //listView.ItemsSource = dataList;
            //return missions ;
        //}
    }
}
