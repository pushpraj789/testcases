using System;
using System.Collections.Generic;
using System.IO;
using Capgemini.Inventory.Entities;
using Newtonsoft.Json;

namespace Capgemini.Inventory.Contracts.DALContracts
{
    /// <summary>
    /// This abstract class acts as a base for SupplierDAL class
    /// </summary>
    public abstract class SupplierDALBase
    {
        //Collection of Suppliers
        protected static List<Supplier> supplierList = new List<Supplier>();
       

        //Methods for CRUD operations
        public abstract (bool,Guid) AddSupplierDAL(Supplier newSupplier);
        public abstract List<Supplier> GetAllSuppliersDAL();
        public abstract Supplier GetSupplierBySupplierIDDAL(Guid searchSupplierID);
        public abstract List<Supplier> GetSuppliersByNameDAL(string supplierName);
        public abstract Supplier GetSupplierByEmailDAL(string email);
        public abstract Supplier GetSupplierByEmailAndPasswordDAL(string email, string password);
        public abstract bool UpdateSupplierDAL(Supplier updateSupplier);
        public abstract bool UpdateSupplierPasswordDAL(Supplier updateSupplier);
        public abstract bool DeleteSupplierDAL(Guid deleteSupplierID);

        

        /// <summary>
        /// Static Constructor.
        /// </summary>
        static SupplierDALBase()
        {
           
        }
    }
}


