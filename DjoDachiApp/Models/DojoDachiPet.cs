namespace DjoDachiApp.Models
{
    public class DojoDachiPet
    {
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }
        public int Meals { get; set; }

        public DojoDachiPet(int happiness = 20, int fullness = 20, int energy = 50, int meals = 3)
        {
            Happiness = happiness;
            Fullness = fullness;
            Energy = energy;
            Meals = meals;
        }

        public bool IsFull => (Happiness > 100 && Fullness > 100 && Energy > 100);

        public bool IsDead => (Happiness <= 0 || Fullness <= 0);

        public void playWith(){
            if(Meals > 0)
            {
                Energy -= 5;
                Happiness += selector(5, 10);
            }
        }

        public void work(){
            Energy -= 5;
            Meals += selector(1, 3);
        }

        public void sleep(){
            Energy += 15;
            Fullness -=5;
            Happiness -= 5;
        }

        public void feed(){
            if(Meals > 0)
            {
                Energy += selector(5, 10);
                Meals--;
            }
        }
    }
}