using EF_Core.Entities;
using EF_Core.Persistence;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Entitiy Framework Core - In Memory");

ComputerDbContext _context = new();
_context.Computers.Add(new("Monster Notebook", 35.000));
_context.Computers.Add(new("Hp Victus", 25.000));
_context.Computers.Add(new("MSI", 50.500));
_context.Computers.Add(new("Huawei Matepad", 30.000));

_context.SaveChanges();


var newProducts = new List<Computer>
{
	new("Matebook d16", 34.500),
	new("Acer Nitro", 22.400),
	new("Casper Excalibur", 40.00)
};

_context.Computers.AddRange(newProducts);
_context.SaveChanges();



void MakeChange(Guid id,string name, double price)
{
	var computer = _context.Computers.FirstOrDefault(x => x.Id == id);
	if (computer is null) return;
	computer.Name= name;
	computer.Price= price;
	_context.Computers.Update(computer);
	_context.SaveChanges();


}

void RemoveElement(Guid id)
{
	var computer = _context.Computers.FirstOrDefault(x=>x.Id == id);
	_context.Computers.Remove(computer);
	_context.SaveChanges();

}
