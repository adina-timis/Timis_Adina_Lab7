using SQLite;
using SQLiteNetExtensions.Attributes;
using Timis_Adina_Lab7.Models;

namespace Timis_Adina_Lab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}