using Restaurant_Management.Model;
using Restaurant_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Controllers
{
    internal class StoreItemTypeController : ICRUD<StoreItemType, StoreItemTypeVM>
    {
        public static RestaurantEntities context;

        static StoreItemTypeController()
        {
            context = new RestaurantEntities();
        }

        public List<StoreItemTypeVM> ViewAll()
        {
            var StoreItems = (from sI in context.StoreItemTypes
                              select new StoreItemTypeVM
                              {
                                  ID = sI.ID,
                                  Name = sI.Name,
                              }).ToList();
            return StoreItems;
        }

        public List<StoreItemTypeVM> Search(string searchTxt)
        {
            List<StoreItemTypeVM> storeItemTypes = new List<StoreItemTypeVM>();

            storeItemTypes.AddRange((from sI in context.StoreItemTypes
                                     where (sI.Name.Contains(searchTxt)
                                         || sI.ID.ToString() == searchTxt)
                                     select new StoreItemTypeVM
                                     {
                                         ID = sI.ID,
                                         Name = sI.Name,
                                     }).ToList());
            return storeItemTypes;
        }

        public bool Delete(int id)
        {
            try
            {
                context.StoreItemTypes.Remove(context.StoreItemTypes.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(StoreItemType storeItemType)
        {
            try
            {
                StoreItemType editedItem = context.StoreItemTypes.Find(storeItemType.ID);

                editedItem.ID = storeItemType.ID;
                editedItem.Name = storeItemType.Name;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(StoreItemType storeItem)
        {
            if (storeItem.Name == "" || storeItem.Name == "Enter Name")
                return false;
            else
            {
                try
                {
                    context.StoreItemTypes.Add(storeItem);

                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public StoreItemType GetStoreType(int id)
        {
            return context.StoreItemTypes.Find(id);
        }
    }
}