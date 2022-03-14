/* Trooper Class Definition File
 * Author: Clint MacDonald
 * Date: March 8, 2022
 */
#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace PPProducts
{
    class Products
    {

        #region PROPERTIES

        public String ItemsQuantity { get; set; }
        public String ProductCategory { get; set; }
        public String ProductName { get; set; }
        public DateTime Made { get; set; }
        public String Size { get; set; }
        public Boolean IsInStock { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public static List<Products> Product = new List<Products>();
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor - by Clint
        /// </summary>
        public Products() {
            ItemsQuantity = string.Empty;
            ProductCategory = string.Empty;
            ProductName = string.Empty;
            Made = DateTime.Today;
            Size = string.Empty;
            IsInStock = false;
            PrimaryColor = Color.Gray;
            SecondaryColor = Color.Gray;
        }

        /// <summary>
        /// Input Parameter Constructor - by Clint
        /// </summary>
        /// <param name="itemsQuantity"></param>
        /// <param name="productCategory"></param>
        /// <param name="productName">The world the Trooper was BORN on.</param>
        /// <param name="made"></param>
        /// <param name="size"></param>
        /// <param name="isInStock"></param>
        /// <param name="primaryColor"></param>
        /// <param name="secondaryColor"></param>
        public Products(string itemsQuantity, String productCategory, String productName,
            DateTime made, String size, Boolean isInStock,
            Color primaryColor, Color secondaryColor)
        {
            // TODO: Add data validation here if needed
            ItemsQuantity= itemsQuantity;
            ProductCategory=productCategory;
            ProductName=productName;
            Made=made;
            Size = size;
            IsInStock = isInStock;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion

        #region METHODS

        #region CUSTOM METHODS (instantiated)
        
        #endregion

        #region STATIC METHODS

        /// <summary>
        /// Temp Method to populate some sample troopers for testing purposes
        /// </summary>
        /// <returns></returns>
        public static List<Products> GetSampleProducts()
        {
            List<Products> returnList = new List<Products>();

            returnList.Add(new Products("712", "Tops", "Striped T-Shirt", new DateTime(2022),
                            "M", true, Color.White, Color.Orange));
            returnList.Add(new Products("531", "Hoodies & Sweatshirts", "Fleece Hoodie", new DateTime(2020),
                            "XL", true, Color.White, Color.Red));
            returnList.Add(new Products("0", "Joggers & Sweatpants", "George Cargo Jogger", new DateTime(2022),
                                        "S", false, Color.LightGreen, Color.WhiteSmoke));

            return returnList;
        }

       
        #endregion

        #endregion
    }
}
