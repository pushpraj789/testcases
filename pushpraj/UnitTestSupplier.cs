﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capgemini.Inventory.BusinessLayer;
using Capgemini.Inventory.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Capgemini.Inventory.UnitTests
{
    [TestClass]
    public class AddSupplierBLTest
    {
        /// <summary>
        /// Add Supplier to the Collection if it is valid.
        /// </summary>
        [TestMethod]
        public async Task AddValidSupplier()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "pushpraj@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);

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

        /// <summary>
        /// Supplier Name can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierNameCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = null, SupplierMobile = "9988776655", Password = "Smith123#", Email = "smith@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Mobile can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierMobileCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "Smith", SupplierMobile = null, Password = "Smith123#", Email = "smith@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Password can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierPasswordCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierName = "Allen", SupplierMobile = "9877766554", Password = null, Email = "allen@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;
            Guid id = default(Guid);

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Email can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierEmailCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9876543210", Password = "John123#", Email = null };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// SupplierName should contain at least two characters
        /// </summary>
        [TestMethod]
        public async Task SupplierNameShouldContainAtLeastTwoCharacters()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierName = "J", SupplierMobile = "9877897890", Password = "John123#", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;
            Guid id = default(Guid);

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// SupplierMobile should be a valid mobile number
        /// </summary>
        [TestMethod]
        public async Task SupplierMobileRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877", Password = "John123#", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Password should be a valid password as per regular expression
        /// </summary>
        [TestMethod]
        public async Task SupplierPasswordRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877897890", Password = "John", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Email should be a valid email as per regular expression
        /// </summary>
        [TestMethod]
        public async Task SupplierEmailRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877897890", Password = "John123#", Email = "john" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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
    public class UpdateSupplierTest
    {
        [TestMethod]
        public async Task UpdateValidSupplier()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Rohit", SupplierMobile = "9876443210", Password = "Scott123#", Email = "rohitkr1@gmail.com" };
            bool isAdded = false;
            bool isUpdated = false;
            Guid id = default(Guid);
            string errorMessage = null;

            //Act
            try
            {

                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                Supplier updatesupplier = new Supplier() { SupplierID =supplier.SupplierID, SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "rohitkumar17@gmail.com" };
                isUpdated = await supplierBL.UpdateSupplierBL(updatesupplier);


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
        public async Task SupplierNameCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = null, SupplierMobile = "9988776655", Password = "Smith123#", Email = "smith@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Mobile can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierMobileCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "Smith", SupplierMobile = null, Password = "Smith123#", Email = "smith@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Password can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierPasswordCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierName = "Allen", SupplierMobile = "9877766554", Password = null, Email = "allen@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;
            Guid id = default(Guid);

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Supplier Email can't be null
        /// </summary>
        [TestMethod]
        public async Task SupplierEmailCanNotBeNull()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9876543210", Password = "John123#", Email = null };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// SupplierName should contain at least two characters
        /// </summary>
        [TestMethod]
        public async Task SupplierNameShouldContainAtLeastTwoCharacters()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierName = "J", SupplierMobile = "9877897890", Password = "John123#", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;
            Guid id = default(Guid);

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// SupplierMobile should be a valid mobile number
        /// </summary>
        [TestMethod]
        public async Task SupplierMobileRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877", Password = "John123#", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Password should be a valid password as per regular expression
        /// </summary>
        [TestMethod]
        public async Task SupplierPasswordRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877897890", Password = "John", Email = "john@gmail.com" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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

        /// <summary>
        /// Email should be a valid email as per regular expression
        /// </summary>
        [TestMethod]
        public async Task SupplierEmailRegExp()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Guid id = default(Guid);
            Supplier supplier = new Supplier() { SupplierName = "John", SupplierMobile = "9877897890", Password = "John123#", Email = "john" };
            bool isAdded = false;
            string errorMessage = null;

            //Act
            try
            {
                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
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
    public class DeleteSupplierTest
    {
        [TestMethod]
        public async Task DeleteValidSupplier()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "pusshpraj@gmail.com" };
            bool isAdded = false;
            bool isDeleted = false;
            Guid id = default(Guid);
            string errorMessage = null;

            //Act
            try
            {

                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                isDeleted = await supplierBL.DeleteSupplierBL(supplier.SupplierID);


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
        public async Task DeleteInValidSupplier()
        {
            //Arrange
            SupplierBL supplierBL = new SupplierBL();
            Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "pusshpraj@gmail.com" };
            bool isAdded = false;
            bool isDeleted = false;
            Guid id = default(Guid);
            string errorMessage = null;

            //Act
            try
            {

                (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                isDeleted = await supplierBL.DeleteSupplierBL(default(Guid));


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
        [TestClass]
        public class GetSupplierBySupplierIDTest
        {
            [TestMethod]
            public async Task GetSupplierBySupplierID()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott987@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(supplier.SupplierID);
                    //supplier1 is used to store the reference given by search ID method

                }
                catch (Exception ex)
                {
                    supplier1 = null;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsNotNull(supplier, errorMessage);
                }
            }
            [TestMethod]
            public async Task SupplierIDdoesnotexist()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(default(Guid));
                    //supplier1 is used to store the reference given by search ID method

                }
                catch (Exception ex)
                {
                    supplier1 = null;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsNull(supplier1, errorMessage);
                }
            }
        }
        [TestClass]
        public class GetSuppliersByNameTest
        {
            [TestMethod]
            public async Task GetSuppliersByName()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scot23t@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    List<Supplier> supplierlist = await supplierBL.GetSuppliersByNameBL(supplier1.SupplierName);
                    //supplier1 is used to store the reference given by search name method
                    foreach (Supplier item in supplierlist)
                    {
                        if (supplier1.SupplierName == item.SupplierName)
                        {
                            isDisplayed = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsTrue(isDisplayed, errorMessage);
                }
            }
            [TestMethod]
            public async Task InvalidName()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    List<Supplier> supplierlist = await supplierBL.GetSuppliersByNameBL("Rahul");
                    //supplier1 is used to store the reference given by search name method
                    foreach (Supplier item in supplierlist)
                    {
                        if (supplier1.SupplierName == item.SupplierName)
                        {
                            isDisplayed = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsFalse(isDisplayed, errorMessage);
                }
            }
        }
        [TestClass]
        public class GetSupplierByEmailTest
        {
            [TestMethod]
            public async Task GetSupplierByEmail()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    Supplier supplier2 = await supplierBL.GetSupplierByEmailBL(supplier1.Email);
                    //supplier2 is used to store the reference given by search name method

                    {
                        if (supplier1.SupplierName == supplier2.SupplierName)
                        {
                            isDisplayed = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsTrue(isDisplayed, errorMessage);
                }
            }

            [TestMethod]
            public async Task GetSupplierByInvalidEmail()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    Supplier supplier2 = await supplierBL.GetSupplierByEmailBL("supplier@gmail.com");
                    //supplier2 is used to store the reference given by search name method

                    {
                        if (supplier1.SupplierName == supplier2.SupplierName)
                        {
                            isDisplayed = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsFalse(isDisplayed, errorMessage);
                }
            }
        }
        [TestClass]
        public class GetSupplierByEmailAndPasswordTest
        {
            [TestMethod]
            public async Task GetSupplierByinvalidEmailAndPassword()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    Supplier supplier2 = await supplierBL.GetSupplierByEmailAndPasswordBL("kaushik87@gmail.com", "udaagdj$66");
                    //supplier2 is used to store the reference given by search name method

                    {
                        if ((supplier1.Password.Equals(supplier2.Password)) && (supplier1.Email.Equals(supplier2.Email)))
                        {
                            isDisplayed = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsFalse(isDisplayed, errorMessage);
                }
            }
            [TestMethod]
            public async Task GetSupplierByEmailAndPassword()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott5628@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    Supplier supplier2 = await supplierBL.GetSupplierByEmailAndPasswordBL(supplier1.Email,supplier1.Password);
                    //supplier2 is used to store the reference given by search name method

                    {
                        if ((supplier1.Password.Equals(supplier2.Password)) && (supplier1.Email.Equals(supplier2.Email)))
                        {
                            isDisplayed = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsTrue(isDisplayed, errorMessage);
                }
            }

        }
        [TestClass]
        public class UpdateSupplierPasswordTest
        {
            [TestMethod]
            public async Task UpdateSupplierPassword()
            {
                //Arrange
                SupplierBL supplierBL = new SupplierBL();
                Supplier supplier = new Supplier() { SupplierID = new Guid(), SupplierName = "Scott", SupplierMobile = "9876543210", Password = "Scott123#", Email = "scott@gmail.com" };
                bool isAdded = false;
                Supplier supplier1 = null;
                bool isDisplayed = false;
                Guid id = default(Guid);
                string errorMessage = null;

                //Act
                try
                {

                    (isAdded, id) = await supplierBL.AddSupplierBL(supplier);
                    supplier1 = await supplierBL.GetSupplierBySupplierIDBL(id);
                    Supplier supplier2 = await supplierBL.GetSupplierByEmailAndPasswordBL(supplier1.Email, supplier1.Password);
                    //supplier2 is used to store the reference given by search name method

                    {
                        if ((supplier1.Password.Equals(supplier2.Password)) && (supplier1.Email.Equals(supplier2.Email)))
                        {
                            isDisplayed = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    isDisplayed = false;
                    errorMessage = ex.Message;
                }
                finally
                {
                    //Assert
                    Assert.IsTrue(isDisplayed, errorMessage);
                }
            }

        }



    }
}
