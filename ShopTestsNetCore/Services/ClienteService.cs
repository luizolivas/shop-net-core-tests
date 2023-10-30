using ShopTestsNetCore.Context;
using ShopTestsNetCore.DataModel;
using ShopTestsNetCore.Models;

namespace ShopTestsNetCore.Services
{
    public class ClienteService
    {
        
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> findAll(){
            return _context.Clientes.ToList();
        }

        public void Insert(Cliente cliente){
            _context.Add(cliente);
            _context.SaveChanges();
        }
    }
}