namespace CQRS.IRR.Criterias
{
    public class ByIdCriteria<TId> : ICriteria
    {
        public ByIdCriteria()
        {
        }

        public ByIdCriteria(TId id)
        {
            Id = id;
        }

        public TId Id { get; set; }
    }
}
