using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public static class SlipManager
    {
        /// <summary>
        /// Gets a list of all unlease slips
        /// </summary>
        /// /// <param name="leases"> list of all leases</param>
        /// <returns> List of unleased slips</returns>
        public static List<Slip> GetUnleasedSlips()
        {
            List<Slip> unleasedSlips = new List<Slip>();
            InlandMarinaContext db = new InlandMarinaContext();
            var slipQuery = (from slips in db.Slips
                            join leases in db.Leases on slips.ID equals leases.SlipID into slipLeaseJoined
                            from slipLease in slipLeaseJoined.DefaultIfEmpty()
                            where slipLease == null
                            select new { slips }).ToList();
            foreach (var slip in slipQuery)
            {
                unleasedSlips.Add(slip.slips);
            }
            return unleasedSlips;
        }
        /// <summary>
        /// Gets a list of slips given dock id
        /// </summary>
        /// <param name="dockId">given dock id</param>
        /// <returns> list of slips given dock id</returns>
        public static List<Slip> GetUnleasedSlipsByDocks(int dockId)
        {
            List<Slip> unleasedSlipsWithDock = new List<Slip>();
            InlandMarinaContext db = new InlandMarinaContext();
            var slipQuery = (from slips in db.Slips
                             join leases in db.Leases on slips.ID equals leases.SlipID into slipLeaseJoined
                             from slipLease in slipLeaseJoined.DefaultIfEmpty()
                             where slipLease == null && slips.DockID == dockId
                             select new { slips }).ToList();
            foreach (var slip in slipQuery)
            {
                unleasedSlipsWithDock.Add(slip.slips);
            }
            return unleasedSlipsWithDock;
        }
        public static List<Slip> GetUnleasedSlipsByCustId(int custId)
        {
            List<Slip> custSlip = new List<Slip>();
            InlandMarinaContext db = new InlandMarinaContext();
            var slipQuery = (from slips in db.Slips
                             join leases in db.Leases on slips.ID equals leases.SlipID 
                             where leases.CustomerID == custId
                             select new { slips }).ToList();
            foreach (var slip in slipQuery)
            {
                custSlip.Add(slip.slips);
            }
            return custSlip;
        }
    }
}
