using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProject
{
    
    public class Product
    {
        
        #region PROPERTIES
        public String ProductName { get; set; }
        public int Quantity { get; set; }
        public String Category { get; set; }
        public String Size { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }

        
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Default Constructor - by Duc
        /// </summary>
        public Product()
        {
           
        }

        /// <summary>
        /// Input Parameter Constructor - by Duc
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="quantity"></param>
        /// <param name="category"></param>
        /// <param name="size"></param>
        /// <param name="primaryColor"></param>
        /// <param name="secondaryColor"></param>
        public Product(int quantity, String category, String productName, String size, Color primaryColor, Color secondaryColor)
        {
            // TODO: Add data validation here if needed
            Quantity = quantity;
            Category = category;
            ProductName = productName;
            Size = size;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion

        #region METHODS

        #region CUSTOM METHODS (instantiated)

        #endregion

        #region STATIC METHODS

        /// <summary>
        /// Temp Method to populate some sample products for testing purposes
        /// </summary>
        /// <returns></returns>
        
        public static List<Product> GetSampleProduct()
        {
            List<Product> returnList = new List<Product>();

            returnList.Add(new Product(12, "Tops", "Striped T-Shirt", 
                            "M",  Color.White, Color.Orange));
            returnList.Add(new Product(53, "Hoodies & Sweatshirts", "Fleece Hoodie", 
                            "XL",  Color.White, Color.Red));
            returnList.Add(new Product(25, "Joggers & Sweatpants", "George Cargo Jogger", 
                                        "S", Color.LightGreen, Color.WhiteSmoke));

            return returnList;
            
        }
       

        #endregion

        #endregion
    }
}
