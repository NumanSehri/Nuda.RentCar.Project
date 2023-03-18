using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand:IEntitiy
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public List<Car> Cars { get; set; }     
    }
}
