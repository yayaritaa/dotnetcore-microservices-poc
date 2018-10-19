﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyService.Domain
{
    public class ValidityPeriod : ICloneable
    {
        public virtual DateTimeOffset ValidFrom { get; protected set; }
        public virtual DateTimeOffset ValidTo { get; protected set; }

        public ValidityPeriod(DateTimeOffset validFrom, DateTimeOffset validTo)
        {
            ValidFrom = validFrom;
            ValidTo = validTo;
        }

        protected ValidityPeriod() { } //NH required

        public static ValidityPeriod Between(DateTimeOffset validFrom, DateTimeOffset validTo)
            => new ValidityPeriod(validFrom, validTo);

        public ValidityPeriod Clone()
        {
            return new ValidityPeriod(ValidFrom, ValidTo);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
