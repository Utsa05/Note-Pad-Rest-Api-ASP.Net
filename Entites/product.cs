namespace Product.Entities
{
    public record ProductEntity
    {
        public Guid? Id { get; init; }
        public String? Title { get; init; }
        public String? Description { get; init; }
        public decimal? Price { get; init; }
        public String? Status { get; init; }
        public DateTimeOffset? CreatedDate { get; init; }

    }
}