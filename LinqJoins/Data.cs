namespace LinqJoins;

public class Data
{
    public class Product {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int GroupId { get; set; }
        public static List<Product> GetProducts() {
            return new List<Product>() {
                new Product() { ProductId = 1, ProductName = "Apple", GroupId = 1 },
                new Product() { ProductId = 2, ProductName = "Orange", GroupId = 1 },
                new Product() { ProductId = 3, ProductName = "PC", GroupId = 2 },
                new Product() { ProductId = 4, ProductName = "Laptop", GroupId = 2 },
                new Product() { ProductId = 5, ProductName = "Printer", GroupId = 2 }
            };
        }
        public override string ToString() {
            return $"ID: {ProductId}, Name: {ProductName}, Group: {GroupId}";
        }
    }
    public class ProductGroup {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        

        public static List<ProductGroup> GetGroups() {
            return new List<ProductGroup>() {
                new ProductGroup() { GroupId = 1, GroupName = "Fruits" },
                new ProductGroup() { GroupId = 2, GroupName = "IT" },
                new ProductGroup() { GroupId = 3, GroupName = "Stuff" }
            };
        }
        public override string ToString() {
            return $"ID: {GroupId}, Name: {GroupName}";
        }
    }
}