using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication3.Pages
{
    public class DashboardModel : PageModel
    {
        public int TotalMonetaryDonations { get; set; }
        public int TotalGoodsReceived { get; set; }
        public List<ActiveDisasterInfo> ActiveDisasters { get; set; }

        public void OnGet()
        {
            // Simulated data for testing purposes
            var donations = GetMonetaryDonations();
            var goods = GetGoodsReceived();
            ActiveDisasters = GetActiveDisastersInfo();

            // Calculate totals
            TotalMonetaryDonations = donations.Sum();
            TotalGoodsReceived = goods.Sum();
        }

        private List<int> GetMonetaryDonations()
        {
            // Simulated data for testing purposes
            return new List<int> { 1000, 2000, 3000 };
        }

        private List<int> GetGoodsReceived()
        {
            // Simulated data for testing purposes
            return new List<int> { 50, 75, 75 };
        }

        private List<ActiveDisasterInfo> GetActiveDisastersInfo()
        {
            // Simulated data for testing purposes
            return new List<ActiveDisasterInfo>
        {
            new ActiveDisasterInfo { Name = "Disaster 1", MoneyAllocated = 2000, GoodsAllocated = 100 },
            new ActiveDisasterInfo { Name = "Disaster 2", MoneyAllocated = 3000, GoodsAllocated = 100 },
        };
        }
    }

    public class ActiveDisasterInfo
    {
        public string Name { get; set; }
        public int MoneyAllocated { get; set; }
        public int GoodsAllocated { get; set; }
    }
}
