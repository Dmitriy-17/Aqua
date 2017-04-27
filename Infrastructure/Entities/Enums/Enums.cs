

namespace Infrastructure.Enums
{
    public enum WaterType
    {
        none = 0,

        fresh = 1,
        sea = 2

    }

    public enum EmployeeState
    {
        none = 0,

        Output = 1,
        Dismissed = 2,
        OnOrder = 3,
        Free = 4
    }

    public enum TypeOfService
    {
        none = 0,

        Cleaning = 1,
        Contract = 2
    }

    public enum OrderState
    {
        none = 0,

        Processing = 1,
        Accepted = 2,
        Reject = 3,
        Fulfilled = 4,

    }
}
