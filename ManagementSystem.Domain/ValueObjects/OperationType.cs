using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain.ValueObjects
{
    public partial record OperationType
    {
        public enum Value
        {
            Income,
            Expense
        }
        public Value? EnumValue { get; }
        private OperationType(Value enumValue) => EnumValue = enumValue;
        public static OperationType? Create(Value value)
        {
            if (!Enum.IsDefined(typeof(Value), value))
            {
                return null;
            }

            return new OperationType(value);
        }
    }
}
