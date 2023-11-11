namespace StateManagementUsingCascadingValue
{
    public  class ProductService
    {
        public int ProductCount { get; set; }
        public List<Product> Products { get; set; }
        public ProductService()
        {
            Products = new(){
            new Product() {Id=1, Name = "Television " },
            new Product() {Id= 2, Name = "Mobile " },
            new Product() {Id= 3, Name = "Desktop " },
            new Product() {Id= 4, Name = "Laptop " },
            new Product() {Id= 5, Name = "Refrigerator " },
            new Product() {Id= 6, Name = "Computer " },
            new Product() {Id= 7, Name = "Keyboard " },
            new Product() {Id= 8, Name = "Mouse " },
            new Product() {Id= 9, Name = "Monitor " },
            new Product() {Id= 10, Name = "Microphone " },
            new Product() {Id= 11, Name = "Speaker " }
        };
           ProductCount = Products.Count();
        }
        
    }
    
}

