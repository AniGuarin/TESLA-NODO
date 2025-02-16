using System;

namespace TeslaACDC.Data.Models;

public class Album : BaseEntity<int>
{

   public string Name {get; set;} = String.Empty;
   public int Year {get; set;}
   public string Genre {get; set;} 

   public int ArtistId{get; set;}

    
}

public enum Genre
{
   salsa, 
   rock,
   pop,
   reggaeton,
   reggae,
   metal,
   punk,
   jazz,
   blues,
   country,
   classical,
   electronic,
   hip_hop,
   rap,
   trap,
   r_and_b,
   soul,
   funk,
   disco,
   house,
}