using System;
using System.Collections.Generic;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem
    {
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit { get; set; }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream { get; set; } = true;

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
    }
}
