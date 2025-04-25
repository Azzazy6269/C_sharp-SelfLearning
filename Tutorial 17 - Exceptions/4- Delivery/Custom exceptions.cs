using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class AccidentException : Exception  
{
    public string Location { get; set; }
    public AccidentException(string location , string message) : base(message) 
    {
        Location = location;
    }
        
}


public class InvalidAddressException : Exception 
{
    public InvalidAddressException(string message) : base(message)
    {
        
    }
} 

public class GoodsIsDamaged : Exception  
{
    
}