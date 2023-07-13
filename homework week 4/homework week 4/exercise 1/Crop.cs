using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4.exercise_1
{
    /*
     * Create a class Crop with the following fields:
- name
- currentStage (a string representing the current growth stage of the crop).
Stages: Seed -> Sprout -> Plant -> CanBeHarvested -> Harvested

!! When you create a set, by default currentStage should be Seed

Add the following methods:
- Water() - advances the crop to the next growth stage.
- Harvest() - harvests the crop and sets the current growth stage to "Harvested". 
    You can harvest only if the currentStage is CanBeHarvested
     */
    public class Crop
    {
        public Crop() 
        {
            this.currentStage = stages[stageindex];
        }
        public string name;
        public string currentStage;
        int stageindex = 0;
        string[] stages=new string[5] {"Seed", "Sprout","Plant","CanBeHarvested","Harvested"};
        
        public void Water()
        { 
            if (stageindex < 3)
            {
                stageindex++;
                this.currentStage= stages[stageindex];
                //Console.WriteLine(stageindex);
            }
        }

        public void Harvest()
        { if (stageindex == 3) 
            {
                stageindex++;
                this.currentStage = stages[stageindex];
            } 
        }
    }
}
