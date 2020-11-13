namespace EcoPacking.Data.Models
{
    using EcoPacking.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
