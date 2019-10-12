using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Inventory.BusinessLayer;
using Capgemini.Inventory.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capgemini.Inventory.UnitTests
{
    [TestClass]
    public class AddsupplierAddressBLTest
    {
        /// <summary>
        /// Add supplierAddress to the Collection if it is valid.
        /// </summary>
        [TestMethod]
        public async Task AddValidsupplierAddress()
        {
            //Arrange
            SupplierBL supbl = new SupplierBL();
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded1 = false;
            Guid id1 = default(Guid);

            Supplier sup = new Supplier() { SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush2@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);

            SupplierAddress supplierAddress = new SupplierAddress() { SupplierID = sup.SupplierID, AddressLine1 = "This is addressline1", AddressLine2 = "This is addressline2", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };

            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;



            //Act
            try
            { 
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);

            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsTrue(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task AddressLine1CanNotBeNull()
        {
            //Arrange
            SupplierBL supbl = new SupplierBL();
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded1 = false;
            Guid id1 = default(Guid);

            Supplier sup = new Supplier() {SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "AddressLine1@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);

            SupplierAddress supplierAddress = new SupplierAddress() {SupplierID = sup.SupplierID, AddressLine1 = null, AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task AddressLine2CanNotBeNull()
        {
            //Arrange
            SupplierBL supbl = new SupplierBL();
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded1 = false;
            Guid id1 = default(Guid);

            Supplier sup = new Supplier() { SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "AddressLine2@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);

            SupplierAddress supplierAddress = new SupplierAddress() { SupplierID = sup.SupplierID, AddressLine1 = "somethin something", AddressLine2 =null, PinCode = "400708", City = "Mumbai", State = "Maharashtra" };

            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task PinCodeCanNotBeNull()
        {
            //Arrange
            SupplierAddress supplierAddress = new SupplierAddress() { AddressLine1 = "This is addressline1", AddressLine2 = "this is addressline2", PinCode = null, City = "Mumbai", State = "Maharashtra" };
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                Guid id1 = default(Guid);
                bool isAdded1 = false;
                Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush4@gmail.com" };
                SupplierBL supbl = new SupplierBL();
                (isAdded1, id1) = await supbl.AddSupplierBL(sup);
                supplierAddress.SupplierID = id1;
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);



            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task CityCanNotBeNull()
        {
            //Arrange
            SupplierAddress supplierAddress = new SupplierAddress() { AddressLine1 = "this is addressline1", AddressLine2 = "this is addressline2", PinCode = "400708", City = null, State = "Maharashtra" };
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                Guid id1 = default(Guid);
                bool isAdded1 = false;
                Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush5@gmail.com" };
                SupplierBL supbl = new SupplierBL();
                (isAdded1, id1) = await supbl.AddSupplierBL(sup);
                supplierAddress.SupplierID = id1;
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);



            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task StateCanNotBeNull()
        {
            //Arrange
            SupplierAddress supplierAddress = new SupplierAddress() { AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = null };
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                Guid id1 = default(Guid);
                bool isAdded1 = false;
                Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush6@gmail.com" };
                SupplierBL supbl = new SupplierBL();
                (isAdded1, id1) = await supbl.AddSupplierBL(sup);
                supplierAddress.SupplierID = id1;
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);



            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
    }
    [TestClass]
    public class UpdatesupplierAddressBLTest
    {
        /// <summary>
        /// Add supplierAddress to the Collection if it is valid.
        /// </summary>
        [TestMethod]
        public async Task UpdateValidsupplierAddress()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() {  SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush7@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() {  SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            bool isUpdated = false;
            Guid id = default(Guid);
            (isAdded1, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
            string errorMessage = null;

            //Act
            try
            {
                
                SupplierAddress updatesupplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
                isUpdated = await supplierAddressBL.UpdateSupplierAddressBL(updatesupplierAddress);

            }
            catch (Exception ex)
            {
                isUpdated = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsTrue(isUpdated, errorMessage);
            }
        }
        [TestMethod]
        public async Task AddressLine1CanNotBeNull()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush8@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = null, AddressLine2 = "paj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);


            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task AddressLine2CanNotBeNull()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "pushpraj@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = null, PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);


            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task PinCodeCanNotBeNull()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush9@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "this is addressline2", PinCode = null, City = "Mumbai", State = "Maharashtra" };
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);


            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task CityCanNotBeNull()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush10@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = null, State = "Maharashtra" };
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);


            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
        [TestMethod]
        public async Task StateCanNotBeNull()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush11@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State =null };
            bool isAdded = false;
            Guid id = default(Guid);
            string errorMessage = null;
            //Act
            try
            {
                (isAdded, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);


            }
            catch (Exception ex)
            {
                isAdded = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isAdded, errorMessage);
            }
        }
    }
    [TestClass]
    public class DeleteSupplierAddressTest
    {
        [TestMethod]
        public async Task DeleteInValidSupplierAddress()
        {
            //Arrange
            SupplierBL supbl = new SupplierBL();
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded1 = false;
            Guid id1 = default(Guid);

            Supplier sup = new Supplier() { SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush2@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);

            SupplierAddress supplierAddress = new SupplierAddress() { SupplierID = sup.SupplierID, AddressLine1 = "This is addressline1", AddressLine2 = "This is addressline2", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };

            bool isDeleted = false;
            Guid id = default(Guid);
            string errorMessage = null;




            //Act
            try
            {

                (isAdded1, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
                isDeleted = await supplierAddressBL.DeleteSupplierAddressBL(id);


            }
            catch (Exception ex)
            {
                isDeleted = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsFalse(isDeleted, errorMessage);
            }

        }

        [TestMethod]
        public async Task DeleteValidSupplierAddress()
        {
            //Arrange
            SupplierBL supbl = new SupplierBL();
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            bool isAdded1 = false;
            Guid id1 = default(Guid);

            Supplier sup = new Supplier() { SupplierName = "Shivam3", SupplierMobile = "9876543266", Password = "Scott123#", Email = "SonAyush2@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);

            SupplierAddress supplierAddress = new SupplierAddress() { SupplierID = sup.SupplierID, AddressLine1 = "This is addressline1", AddressLine2 = "This is addressline2", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };

            bool isDeleted = false;
            Guid id = default(Guid);
            string errorMessage = null;




            //Act
            try
            {

                (isAdded1, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
                isDeleted = await supplierAddressBL.DeleteSupplierAddressBL(supplierAddress.SupplierAddressID);


            }
            catch (Exception ex)
            {
                isDeleted = false;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsTrue(isDeleted, errorMessage);
            }

        }

    }
    [TestClass]
    public class GetSupplierAddressBySupplierAddressIDTest
    {
        [TestMethod]
        public async Task GetSupplierAddressBySupplierAddressID()
        {
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "jsdaggk", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush13@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            SupplierAddress supplierAddress1 = null;
            Guid id = default(Guid);
            string errorMessage = null;


            //Act
            try
            {

                (isAdded1, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
                supplierAddress1 = await supplierAddressBL.GetSupplierAddressBySupplierAddressIDBL(supplierAddress.SupplierAddressID);
                //supplier1 is used to store the reference given by search ID method

            }
            catch (Exception ex)
            {
                supplierAddress1 = null;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsNotNull(supplierAddress1, errorMessage);
            }
        }
        [TestMethod]
        public async Task SupplierIDdoesnotexist()
        {
            //Arrange
            //Arrange
            SupplierAddressBL supplierAddressBL = new SupplierAddressBL();
            Guid id1 = default(Guid);
            bool isAdded1 = false;
            SupplierBL supbl = new SupplierBL();
            Supplier sup = new Supplier() { SupplierID = Guid.NewGuid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "SonAyush14@gmail.com" };
            (isAdded1, id1) = await supbl.AddSupplierBL(sup);
            SupplierAddress supplierAddress = new SupplierAddress() { SupplierAddressID = Guid.NewGuid(), SupplierID = id1, AddressLine1 = "Scott123#", AddressLine2 = "pushpraj@gmail.com", PinCode = "400708", City = "Mumbai", State = "Maharashtra" };
            SupplierAddress supplierAddress1 = null;
            Guid id = default(Guid);
            string errorMessage = null;

            //Act
            try
            {

                (isAdded1, id) = await supplierAddressBL.AddSupplierAddressBL(supplierAddress);
                supplierAddress1 = await supplierAddressBL.GetSupplierAddressBySupplierAddressIDBL(id);
                //supplier1 is used to store the reference given by search ID method

            }
            catch (Exception ex)
            {
                supplierAddress1 = null;
                errorMessage = ex.Message;
            }
            finally
            {
                //Assert
                Assert.IsNull(supplierAddress1, errorMessage);
            }
        }
    }


}