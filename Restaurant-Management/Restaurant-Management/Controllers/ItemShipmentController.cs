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
    internal class ItemShipmentController : ICRUD<ItemShipment, ItemShipmentVM>
    {
        public static RestaurantEntities context;

        static ItemShipmentController()
        {
            context = new RestaurantEntities();
        }

        public ItemShipment GetItem(int id)
        {
            return context.ItemShipments.Find(id);
        }

        public List<ItemShipmentVM> ViewshipmentDetails(Supplier supplier, StoreItem storeItem)
        {
            return (from u in context.ItemShipments
                    where u.StoreItem.ID == storeItem.ID && u.Supplier.ID==supplier.ID
                    select new ItemShipmentVM
                    {
                        ID = u.ID,
                        ArrivalTime=u.ArrivalTime,
                        ExperiedTime=u.ExperiedTime,
                        StoreItem_Name=u.StoreItem.Name,
                        Supplier_Name=u.Supplier.Name,
                        Count=u.Count,
                    }).ToList();
        }
        public List<ItemShipmentVM> Viewshipmentsupplier(Supplier supplier)
        {
            return (from u in context.ItemShipments
                    where u.StoreItem == null && u.Supplier.ID == supplier.ID
                    select new ItemShipmentVM
                    {
                        ID = u.ID,
                        ArrivalTime = u.ArrivalTime,
                        ExperiedTime = u.ExperiedTime,
                        StoreItem_Name = null,
                        Supplier_Name = u.Supplier.Name,
                        Count=u.Count,
                    }).ToList();
        }
        public List<ItemShipmentVM> ViewshipmentstoreItem(StoreItem storeItem)
        {
            return (from u in context.ItemShipments
                    where u.StoreItem.ID == storeItem.ID && u.Supplier == null
                    select new ItemShipmentVM
                    {
                        ID = u.ID,
                        ArrivalTime = u.ArrivalTime,
                        ExperiedTime = u.ExperiedTime,
                        StoreItem_Name = u.StoreItem.Name,
                        Supplier_Name = null,
                        Count = u.Count,
                    }).ToList();
        }
        public List<ItemShipmentVM> ViewAll()
        {
            //var shipment = (from u in context.ItemShipments
            //             select new ItemShipmentVM
            //             {
            //                 ID = u.ID,
            //                 ArrivalTime = u.ArrivalTime,
            //                 ExperiedTime = u.ExperiedTime,
            //                 Count = u.Count,
            //                 StoreItem_Name = u.StoreItem.Name,
            //                 Supplier_Name = u.Supplier.Name,
            //             }).ToList();

            return null;
        }

        public List<ItemShipmentVM> Search(string searchTxt)
        {
            List<ItemShipmentVM> shiments = new List<ItemShipmentVM>();

            shiments.AddRange((from u in context.ItemShipments
                            where (u.ArrivalTime.ToString().Contains(searchTxt)
                            || u.ExperiedTime.ToString().Contains(searchTxt)
                            || u.Count.ToString().Contains(searchTxt)
                            || u.Supplier.Name.Contains(searchTxt)
                            || u.StoreItem.Name.Contains(searchTxt))
                            select new ItemShipmentVM
                            {
                                ID = u.ID,
                                ArrivalTime = u.ArrivalTime,
                                ExperiedTime = u.ExperiedTime,
                                Count = u.Count,
                                StoreItem_Name = u.StoreItem.Name,
                                Supplier_Name = u.Supplier.Name,
                            }).ToList());

            try
            {
                int id = int.Parse(searchTxt);
                shiments.AddRange((from u in context.ItemShipments
                                where u.ID == id
                                select new ItemShipmentVM
                                {
                                    ID = u.ID,
                                    ArrivalTime = u.ArrivalTime,
                                    ExperiedTime = u.ExperiedTime,
                                    Count = u.Count,
                                    StoreItem_Name = u.StoreItem.Name,
                                    Supplier_Name = u.Supplier.Name
                                }).ToList());
            }
            catch { }
            return shiments;
        }

        public bool Delete(int id)
        {
            try
            {
                context.ItemShipments.Remove(context.ItemShipments.Find(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(ItemShipment shipment)
        {
            try
            {
                ItemShipment editedShipment = context.ItemShipments.Find(shipment.ID);

                editedShipment.ArrivalTime = shipment.ArrivalTime;
                editedShipment.ExperiedTime = shipment.ExperiedTime;
                editedShipment.Count = shipment.Count;
                editedShipment.StoreItem = shipment.StoreItem;
                editedShipment.Supplier = shipment.Supplier;             
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(ItemShipment shipment)
        {
            try
            {
                context.ItemShipments.Add(shipment);

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
}