using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public static class DockManager
    {
        /// <summary>
        /// Get Dock given the id
        /// </summary>
        /// <param name="id"> Dock id </param>
        /// <returns> Dock with given id</returns>
        public static Dock Find(int id)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Docks.Find(id);
        }
        /// <summary>
        /// Gets a list of all docks
        /// </summary>
        /// <returns>list of all docks</returns>
        public static List<Dock> GetDocks()
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Docks.ToList();
        }
    }
}
