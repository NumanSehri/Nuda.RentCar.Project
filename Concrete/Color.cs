using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color:IEntitiy
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
