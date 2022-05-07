using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAuction.Models;

public class Image : IID
{
    public int ID { get; set; }
    public byte[]? Data { get; set; }
    //public int? CarID { get; set; }
    //public Car? Car { get; set; }
}

