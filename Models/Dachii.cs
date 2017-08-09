using System;

namespace dachii.Models
{
    public class Dachii
    {
        public int happyness {get; set;}
        public int fullness {get; set;}
        public int meals {get; set;}
        public int energy {get; set;}
        public string status {get; set;}
        
        public Dachii()
        {
            happyness = 20;
            fullness = 20;
            meals = 3;
            status = "You got a new dachi! play with it";

        }

        public Dachii feed()
        {
            // Feeding your Dojodachi costs 1 meal and gains a random amount of fullness between 5 and 10 (you cannot feed your Dojodachi if you do not have meals)
            // Every time you play with or feed your dojodachi there should be a
            Random rando = new Random();
            this.meals -= 1;
            if(rando.Next(0,4) !=0 )
            {
                int amt = rando.Next(5, 11);
                this.fullness += amt;
                this.status = $" Your Dachii just fed and is {amt} fuller!";
            }
            else
            {
                this.status = "Your Dachi did not want to eat....";
            }
            return this;
        }
        public Dachii work()
        {
            //Working costs 5 energt and earns between 1 and 3 meals
            Random rando = new Random();
            this.energy -= 5;
            int amt = rando.Next(1,4);
            this.meals += amt;
            this.status = $"Your  Dachii worked and earned {amt} meals";
            return this;
        }
                public Dachii play()
        {
            // Playing with your Dojodachi costs 5 energy and gains a random amount of happiness between 5 and 10
            this.energy -= 5;
            Random radno = new Random();
            if(radno.Next(0,4) != 0){
                int amt = radno.Next(5,11);
                this.happyness += amt;
                this.status = $"Your dachii just played and is {amt} happyer!";
            }
            else
            {
                this.status = "Your dachi did not wanna play...";
            }
            return this;
        }

        public Dachii sleep()
        {
            // Sleeping earns 15 energy and decreases fullness and happiness each by 5
            this.energy += 15;
            this.fullness -= 5;
            this.happyness -= 5;
            this.status = "Your dachi slept like a babe";
            if (fullness < 0 || happyness < 0)
            {
                this.status = "Your dachii done died yo...";
            }
            return this;
        }
    }
}  