﻿namespace GearCatalog
{
    public class Gear
    {
        public int GearId { get; set; }
        //Remove this later when you figure out how to autogenerate it in the database
        public int CategoryId { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int WeightGrams { get; set; }
        public int LengthMM { get; set; }
        public int WidthMM { get; set; }
        public int DepthMM { get; set; }
        public int Locking { get; set; }
    }
}
