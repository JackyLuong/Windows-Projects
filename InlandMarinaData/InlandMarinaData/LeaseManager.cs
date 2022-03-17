using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public static class LeaseManager
    {
        public static void AddLease(int slipId, int custId)
        {
            Lease newLease = new Lease()
            {
                SlipID = slipId,
                CustomerID = custId
            };
            InlandMarinaContext db = new InlandMarinaContext();
            db.Leases.Add(newLease);
            db.SaveChanges();
        }

    }
}
