using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions
    {
        //this method receives an item and returns it as an itemdto
        //itemdto was meant to hide the interface(contract) implementation
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }

    }
}