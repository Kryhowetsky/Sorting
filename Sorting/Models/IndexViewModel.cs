using System.Collections.Generic;

namespace Sorting.Models
{
    public class IndexViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModels FilterViewModels { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}