namespace CQRS.IRR.Criterias
{
    public class ListCriteria : ICriteria
    {
        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
