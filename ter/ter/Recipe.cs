using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ter
{
    [Table("Recipe")]
    public class Recipe
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comp1 { get; set; }
        public string Comp2 { get; set; }
    }
}
