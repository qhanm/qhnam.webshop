using System;
using System.Collections.Generic;
using System.Text;

namespace qhnam.Data.Model.ViewModels
{
    public class AdvertistmentPageViewModel
    {
        public string Name { get; set; }

        public ICollection<AdvertistmentPositionViewModel> AdvertistmentPositions { get; set; }
    }
}
