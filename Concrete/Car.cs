using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car:IEntitiy
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Desciription { get; set; }
        public Brand Brand { get; set; } // navigation property
        public int BrandId { get; set; }


    }
}
