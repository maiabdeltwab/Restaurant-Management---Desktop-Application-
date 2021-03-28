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
    internal class StoreItemController : ICRUD<StoreItem, StoreItemVM>
    {
        public static RestaurantEntities context;

        static StoreItemController()
        {
            context = new RestaurantEntities();
        }

        public List<StoreItemVM> ViewAll()
        {
            var StoreItems = (from sI in context.StoreItems
                              select new StoreItemVM
                              {
                                  ID = sI.ID,
                                  Name = sI.Name,
                                  Price = sI.Price,
                                  CurrentCount = sI.CurrentCount,
                                  RequiredCount = sI.RequiredCount,
                                  TypeName = sI.StoreItemType.Name,
                              }).ToList();

            return StoreItems;
        }

        public List<StoreItemVM> ViewItemsType(StoreItemType type)
        {
            return (from sI in context.StoreItems
                    where sI.ItemType_ID == type.ID
                    select new StoreItemVM
                    {
                        ID = sI.ID,
                        Name = sI.Name,
                        Price = sI.Price,
                        CurrentCount = sI.CurrentCount,
                        RequiredCount = sI.RequiredCount,
                        TypeName = sI.StoreItemType.Name,
                    }).ToList();
        }

        public List<StoreItemVM> Search(string searchTxt)
        {
            List<StoreItemVM> storeItems = new List<StoreItemVM>();

            storeItems.AddRange((from sI in context.StoreItems
                                 where (sI.Name.Contains(searchTxt)
                                 || sI.Price.ToString() == searchTxt
                                 || sI.CurrentCount.ToString() == searchTxt
                                 || sI.StoreItemType.Name.Contains(searchTxt)
                                 || sI.ID.ToString() == searchTxt)
                                 select new StoreItemVM
                                 {
                                     ID = sI.ID,
                                     Name = sI.Name,
                                     Price = sI.Price,
                                     CurrentCount = sI.CurrentCount,
                                     RequiredCount = sI.RequiredCount,
                                     TypeName = sI.StoreItemType.Name,
                                 }).ToList());

            return storeItems;
        }

        public bool Delete(int id)
        {
            try
            {
                context.StoreItems.Remove(context.StoreItems.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(StoreItem storeItem)
        {
            try
            {
                StoreItem editedItem = context.StoreItems.Find(storeItem.ID);

                editedItem.ID = storeItem.ID;
                editedItem.Name = storeItem.Name;
                editedItem.Price = storeItem.Price;
                editedItem.CurrentCount = storeItem.CurrentCount;
                editedItem.RequiredCount = storeItem.RequiredCount;
                editedItem.StoreItemType = storeItem.StoreItemType;
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(StoreItem storeItem)
        {
            try
            {
                context.StoreItems.Add(storeItem);

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<ItemDailyNeedVM> ViewDailyConsumption(Nullable<System.DateTime> Date)
        {
            var IDNs = (from Ic in context.StoreConsumptions
                        where Ic.Date == Date
                        group Ic.Count by Ic.StoreItem.ID into l
                        join sI in context.StoreItems on l.Key equals sI.ID
                        select new ItemDailyNeedVM
                        {
                            ID = sI.ID,
                            Name = sI.Name,
                            Count = l.Sum(),
                            CurrentCount = sI.CurrentCount,
                            RequiredCount = sI.RequiredCount,
                            Date = Date,
                        }).ToList();

            return IDNs;
        }
    }
}