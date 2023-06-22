namespace SEDC.PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }

        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; set; }
        public static implicit operator Pizza(string v)
        {
            throw new NotImplementedException();
        }
       

    }
}
