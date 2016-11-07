namespace OWPDataCenter.Criteria
{
    using Fanex.Data.Repository;

    public class GetSelectedEventsCriteria : CriteriaBase
    {    
        public override string GetSettingKey()
        {
            return "OWP_API_SelectedEventsGet";
        }

        public override bool IsValid()
        {
 	        return true;
        }
    }
}