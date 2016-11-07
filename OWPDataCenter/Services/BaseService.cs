namespace OWPDataCenter.Services
{
    using Fanex.Data.Repository;

    public class BaseService
    {
        protected IDynamicRepository _repository;

        public BaseService()
        {
            _repository = new DynamicRepository();
        }
    }
}