using System;
using System.Collections.Generic;

namespace ContestProject.Model.EF.Entities
{
    public class Contest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public List<Result> Results { get; set; }
    }
}
