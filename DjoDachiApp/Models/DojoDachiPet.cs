namespace DjoDachiApp.Models
{
    public class DojoDachiPet
    {
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }

        public bool IsFull => !string.IsNullOrEmpty(RequestId);

        public void feed(){

        }

        public void playWith(){
            
        }

        public void work(){
            
        }

        public void sleep(){
            
        }

        public void feed(){
            
        }

        /*
        
         */
    }
}