using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Entities
{
	public class Computer
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

        public Computer(string name, double price)
        {
			Id= Guid.NewGuid();
			Name= name;
			Price= price;
			
        }
    }
}
