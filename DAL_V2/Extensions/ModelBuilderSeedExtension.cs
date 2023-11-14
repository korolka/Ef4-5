using DAL_V2.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Extensions
{
    public static class ModelBuilderSeedExtension
    {
        private const string BooksCategoryName = "Books";
        private const string NewspaperCategoryName = "Newspaper";
        private const string MagazineCategoryName = "Magazine";

        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            var categories = BuildCategories(modelBuilder);
            var users = BuildUsers(modelBuilder);
            var keyWords = BuildWords(modelBuilder);
            var products = BuildProducts(modelBuilder, categories.ToDictionary(item => item.Name, item => item.Id));
            var keyParams = BuildKeyParams(modelBuilder, products.ToDictionary(item => item.Name, item => item.Id),
               keyWords.ToDictionary(item => item.Keyword, item => item.Id));
            var carts = BuildCart(modelBuilder, users, products);
        }

        #region CategoryBuild

        private static Category[] BuildCategories(ModelBuilder modelBuilder)
        {
            var categoryArray = new[]
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = BooksCategoryName,
                    Icon = "favicon.ico"
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = NewspaperCategoryName,
                    Icon = "favicon.ico"
                }, new Category
                {
                    Id = Guid.NewGuid(),
                    Name = MagazineCategoryName,
                    Icon = "favicon.ico"
                }
            };

            modelBuilder.Entity<Category>().HasData(categoryArray);
            return categoryArray;
        }

        #endregion

        #region UserBuild

        private static User[] BuildUsers(ModelBuilder modelBuilder)
        {
            var usersArray = new[]
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Tom",
                    Login = "tom1996",
                    Password = "strongPassword",
                    Email = "email@gmail.com",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "John",
                    Login = "john_5709",
                    Password = "strongPassword2",
                    Email = "johm.email@gmail.com",
                }
            };

            modelBuilder.Entity<User>().HasData(usersArray);
            return usersArray;
        }

        #endregion

        #region KeyWordsBuild

        private static Word[] BuildWords(ModelBuilder modelBuilder)
        {
            var keyWordArray = new[]
            {
                new Word
                {
                    Id = Guid.NewGuid(),
                    Keyword = "book"
                },
                new Word
                {
                    Id = Guid.NewGuid(),
                    Keyword = "development"
                },
                new Word
                {
                    Id = Guid.NewGuid(),
                    Keyword = "news"
                },
                new Word
                {
                    Id = Guid.NewGuid(),
                    Keyword = "spiegel"
                },
                new Word
                {
                    Id = Guid.NewGuid(),
                    Keyword = "magazine"
                }
            };

            modelBuilder.Entity<Word>().HasData(keyWordArray);
            return keyWordArray;
        }

        #endregion

        #region ProductBuild

        private static Product[] BuildProducts(ModelBuilder modelBuilder, IDictionary<string, Guid> categories)
        {
            var productArray = new[]
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "NY Times",
                    Price = 1.99,
                    ActionPrice = 1,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[NewspaperCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial times",
                    Price = 2,
                    ActionPrice = 1,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[NewspaperCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Spiegel",
                    Price = 1.53,
                    ActionPrice = 1,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[MagazineCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Forbes",
                    Price = 1.74,
                    ActionPrice = 1,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[MagazineCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "CLR Programming",
                    Price = 5.50,
                    ActionPrice = 2.90,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[BooksCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Using patterns",
                    Price = 3.20,
                    ActionPrice = 2.90,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[BooksCategoryName]
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Java programming",
                    Price = 3.85,
                    ActionPrice = 2.10,
                    Description = "Lorem ipsum",
                    DescriptionField1 = "Lorem ipsum",
                    DescriptionField2 = "Lorem ipsum",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Gutenberg_Bible%2C_Lenox_Copy%2C_New_York_Public_Library%2C_2009._Pic_01.jpg",
                    CategoryId = categories[BooksCategoryName]
                }
            };

            modelBuilder.Entity<Product>().HasData(productArray);
            return productArray;
        }

        #endregion

        #region KeyParamsBuild

        private static KeyParams[] BuildKeyParams(ModelBuilder modelBuilder, IDictionary<string, Guid> products, IDictionary<string, Guid> keyWords)
        {
            var keyParamsArray = new KeyParams[]
            {
                new KeyParams
                {
                    ProductId = products["Java programming"],
                    KeyWordId = keyWords["book"]
                },
                new KeyParams
                {
                    ProductId = products["Java programming"],
                    KeyWordId = keyWords["development"]
                },
                new KeyParams
                {
                    ProductId = products["Using patterns"],
                    KeyWordId = keyWords["book"]
                },
                new KeyParams
                {
                    ProductId = products["Using patterns"],
                    KeyWordId = keyWords["development"]
                },

                new KeyParams
                {
                    ProductId = products["CLR Programming"],
                    KeyWordId = keyWords["book"]
                },
                new KeyParams
                {
                    ProductId = products["CLR Programming"],
                    KeyWordId = keyWords["development"]
                },

                new KeyParams
                {
                    ProductId = products["Spiegel"],
                    KeyWordId = keyWords["magazine"]
                },

                new KeyParams
                {
                    ProductId = products["Spiegel"],
                    KeyWordId = keyWords["spiegel"]
                },

                new KeyParams
                {
                    ProductId = products["Spiegel"],
                    KeyWordId = keyWords["news"]
                },

                new KeyParams
                {
                    ProductId = products["Forbes"],
                    KeyWordId = keyWords["magazine"]
                },

                new KeyParams
                {
                    ProductId = products["NY Times"],
                    KeyWordId = keyWords["news"]
                },

                new KeyParams
                {
                    ProductId = products["Financial times"],
                    KeyWordId = keyWords["news"]
                },
            };

            modelBuilder.Entity<KeyParams>().HasData(keyParamsArray);
            return keyParamsArray;
        }

        #endregion

        #region CartBuild

        private static Cart[] BuildCart(ModelBuilder modelBuilder, User[] users, Product[] products)
        {
            var cartArray = new Cart[]
            {
                new Cart
                {
                    UserId = users[0].Id,
                    ProductId = products[0].Id
                },
                new Cart
                {
                    UserId = users[0].Id,
                    ProductId = products[3].Id
                },
                new Cart
                {
                    UserId = users[1].Id,
                    ProductId = products[2].Id
                },
            };

            modelBuilder.Entity<Cart>().HasData(cartArray);
            return cartArray;
        }

        #endregion
    }
}