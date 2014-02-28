﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BooleanExpression.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder
{
    using System;
    using System.Collections.Generic;
    using Catel.Runtime.Serialization;
    using Fasterflect;

    public class BooleanExpression : DataTypeExpression
    {
        #region Constructors
        public BooleanExpression()
        {
            BooleanValues = new List<bool> {true, false};
            Value = true;
            SelectedCondition = Condition.EqualTo;
            ValueControlType = ValueControlType.Boolean;
        }
        #endregion

        #region Properties
        public bool Value { get; set; }

        [ExcludeFromSerialization]
        public List<bool> BooleanValues { get; set; }
        #endregion

        #region Methods
        public override bool CalculateResult(string propertyName, object entity)
        {
            bool entityValue = (bool) entity.GetPropertyValue(propertyName);
            switch (SelectedCondition)
            {
                case Condition.EqualTo:
                    return entityValue == Value;

                default:
                    throw new NotSupportedException(string.Format("Condition '{0}' is not supported.", SelectedCondition));
            }
        }
        #endregion
    }
}