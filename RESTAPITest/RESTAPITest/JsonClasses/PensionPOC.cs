using System.Collections.Generic;

namespace RESTAPITest.JsonClasses
{
    public class PensionPOC
    {
        public string href { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Links
    {
        public PensionPOC parent { get; set; }
        public Self self { get; set; }
    }

    public class Bonuses
    {
        public int finalBonusAmount { get; set; }
        public int loyaltyBonusAtRetirement { get; set; }
        public int loyaltyBonusAmountAtTransfer { get; set; }
    }

    public class MarketValueReduction
    {
        public int maximumCarryForwardAllowance { get; set; }
        public int amount { get; set; }
    }

    public class PAFDeductions
    {
        public int marketDepreciationDiscountAmount { get; set; }
    }

    public class AccumulationPlanValuation
    {
        public string rightsType { get; set; }
        public string valuationDate { get; set; }
        public string fundHoldingType { get; set; }
        public double fundValue { get; set; }
        public int earlyExitCharge { get; set; }
    }

    public class DrawdownPlanValuation
    {
        public string valuationDate { get; set; }
        public double fundValue { get; set; }
    }

    public class PlanValuation
    {
        public string productFamily { get; set; }
        public string currency { get; set; }
        public string valuationDate { get; set; }
        public double fundValue { get; set; }
        public double transferValue { get; set; }
        public double accumulationFundValue { get; set; }
        public double drawdownFundValue { get; set; }
        public double unitLinkedFundValue { get; set; }
        public int withProfitsFundValue { get; set; }
        public double totalNonProtectedRightsFundValue { get; set; }
        public int totalFormerProtectedRightsFundValue { get; set; }
        public double accumulationTransferValue { get; set; }
        public double drawdownTransferValue { get; set; }
        public double nonProtectedRightsTransferValue { get; set; }
        public int formerProtectedRightsTransferValue { get; set; }
        public int guaranteedMaturityValue { get; set; }
        public int outstandingAdvisorCharge { get; set; }
        public int earlyExitCharge { get; set; }
        public Bonuses bonuses { get; set; }
        public MarketValueReduction marketValueReduction { get; set; }
        public PAFDeductions PAFDeductions { get; set; }
        public List<AccumulationPlanValuation> accumulationPlanValuation { get; set; }
        public DrawdownPlanValuation drawdownPlanValuation { get; set; }
    }

    public class PensionObject
    {
        public Links _links { get; set; }
        public List<PlanValuation> planValuation { get; set; }
    }
}
