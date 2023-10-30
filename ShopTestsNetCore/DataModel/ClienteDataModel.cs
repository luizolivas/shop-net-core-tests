
using System.ComponentModel.DataAnnotations;

namespace ShopTestsNetCore.DataModel{

    public class ClienteDataModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }     
    }
}