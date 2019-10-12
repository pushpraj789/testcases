using System;
using System.Collections.Generic;
using System.IO;
using Capgemini.Inventory.Entities;
using Newtonsoft.Json;

namespace Capgemini.Inventory.Contracts.DALContracts
{
    /// <summary>
    /// This abstract class acts as a base for SupplierAddressDAL class
    /// </summary>
    public abstract class SupplierAddressDALBase
    {
        //Collection of SupplierAddress
        protected static List<SupplierAddress> SupplierAddressList = new List<SupplierAddress>();
        

        //Methods for CRUD operations
        public abstract (bool,Guid) AddSupplierAddressDAL(SupplierAddress newSupplierAddress);
        public abstract List<SupplierAddress> GetAllSuppliersAddressesDAL();
        public abstract SupplierAddress GetSupplierAddressBySupplierAddressIDDAL(Guid searchAddressID);
        public abstract bool UpdateSupplierAddressDAL(SupplierAddress updateSupplierAddress);
        public abstract bool DeleteSupplierAddressDAL(Guid deleteSupplierAddressID);

        /// <summary>
        /// Writes collection to the file in JSON format.
        /// </summary>
        
        /// <summary>
        /// Static Constructor.
        /// </summary>
        static SupplierAddressDALBase()
        {
            
        }
    }
}
