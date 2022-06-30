namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m

                },

                new Product
                {
                    Id = 2,
                    Title = "Cat's Cradle",
                    Description = "Cat's Cradle is a satirical postmodern novel, with science fiction elements, by American writer Kurt Vonnegut. Vonnegut's fourth novel, it was first published in 1963, exploring and satirizing issues of science, technology, the purpose of religion, and the arms race, often through the use of black humor. After turning down his original thesis in 1947, the University of Chicago awarded Vonnegut his master's degree in anthropology in 1971 for Cat's Cradle.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Cat%27s_Cradle_%281st_ed._cover%29_-_Vonnegut.jpg",
                    Price = 7.99m

                },

                new Product
                {
                    Id = 3,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school and with the help of his friends, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
                    Price = 6.99m

                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
