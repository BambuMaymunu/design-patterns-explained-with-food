﻿using RealisticDependencies;

namespace BehavioralPatterns.State.Concretions {
    /// <summary>
    /// Implements particular behaviors associated with the state of a Rewards State Context 
    /// </summary>
    public class BasicTier: RewardsTier {
        public BasicTier(IApplicationLogger logger) : base(logger) { }
    }
}